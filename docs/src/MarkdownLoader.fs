module MarkdownLoader

open Feliz
open Elmish
open Feliz.ElmishComponents
open Fable.SimpleHttp
open Fable.Core
open Fable.Core.JsInterop
open Feliz.Markdown
open Feliz.AntDesign

type State =
    | Initial
    | Loading
    | Errored of string
    | LoadedMarkdown of content: string

type Msg =
    | StartLoading of path: string list
    | Loaded of Result<string, int * string>

type IMarkdownHeadingProps =
    abstract level : int
    abstract children : ReactElement array

type IMarkdownParagraphProps =
    abstract children : ReactElement array

type Highlight =
    static member inline highlight (properties: IReactProperty list) =
        Interop.reactApi.createElement(importDefault "react-highlight", createObj !!properties)

/// Renders a code block from markdown using react-highlight.
/// Injects sample React components when the code block has language of the format <language>:<sample-name>
let codeBlockRenderer (codeProps: Markdown.ICodeProperties) =
    if codeProps.language <> null && codeProps.language.Contains ":" then
        let languageParts = codeProps.language.Split(':')
        let sampleName = languageParts.[1]
        let sampleApp =
            Samples.samples
            |> List.tryFind (fun (name, _) -> name = sampleName)
            |> Option.map snd
            |> Option.defaultValue (Html.h1 [
                prop.style [ style.color.crimson ];
                prop.text (sprintf "Could not find sample app '%s'" sampleName)
            ])

        Html.div [
            sampleApp
            Highlight.highlight [
                prop.className "fsharp"
                prop.text(codeProps.value)
            ]
        ]
    else
        Highlight.highlight [
            prop.className "fsharp"
            prop.text(codeProps.value)
        ]

let githubPath (rawPath: string) =
    let parts = rawPath.Split('/')
    if parts.Length > 5
    then sprintf "http://www.github.com/%s/%s" parts.[3] parts.[4]
    else rawPath

let init (path: string list) = Initial, Cmd.ofMsg (StartLoading path)

let resolvePath = function
| [ one: string ] when one.StartsWith "http" -> one
| segments -> String.concat "/" segments

let update (msg: Msg) (state: State) =
    match msg with
    | StartLoading path ->
        let loadMarkdownAsync() = async {
            do! Async.Sleep 1000
            let! (statusCode, responseText) = Http.get (resolvePath path)
            if statusCode = 200
            then return Loaded (Ok responseText)
            else return Loaded (Error (statusCode, responseText))
        }

        Loading, Cmd.OfAsync.perform loadMarkdownAsync () id

    | Loaded (Ok content) ->
        State.LoadedMarkdown content, Cmd.none

    | Loaded (Error (status, error)) ->
        State.LoadedMarkdown error, Cmd.none

let headingRenderer (renderProps: IMarkdownHeadingProps) =
    Ant.title [
        prop.children renderProps.children
    ]

let paragraphRenderer (renderProps: IMarkdownParagraphProps) =
    Ant.paragraph [
        prop.children renderProps.children
    ]

let createRenderer name renderer = unbox<IMarkdownRenderer> (prop.custom(name, renderer))

let renderMarkdown (path: string) (content: string) =
    Html.div [
        prop.style [ style.padding 20 ]
        prop.children [
            if path.StartsWith "https://raw.githubusercontent.com" then
                Html.h2 [
                    Html.anchor [
                        prop.style [ style.marginLeft 10; style.color.lightGreen ]
                        prop.href (githubPath path)
                        prop.text "View on Github"
                    ]
                ]

            Markdown.markdown [
                markdown.source content
                markdown.escapeHtml false
                markdown.renderers [
                    markdown.renderers.code codeBlockRenderer
                    createRenderer "heading" headingRenderer
                    createRenderer "paragraph" paragraphRenderer
                ]
            ]
        ]
    ]

let centeredSpinner =
    Html.div [
        prop.style [
            style.textAlign.center
            style.marginLeft length.auto
            style.marginRight length.auto
            style.marginTop 50
        ]
        prop.children [
            Ant.spin [
                spin.size.large
            ]
        ]
    ]

let render path (state: State) dispatch  =
    match state with
    | Initial -> Html.none
    | Loading -> centeredSpinner
    | LoadedMarkdown content -> renderMarkdown (resolvePath path) content
    | Errored error ->
        Html.h1 [
            prop.style [ style.color.crimson ]
            prop.text error
        ]

let loadMarkdown' (path: string list) =
    React.elmishComponent("LoadMarkdown", init path, update, render path, key=resolvePath path)

let loadMarkdown (path: string list) = loadMarkdown' path