module App

open Feliz
open Feliz.AntDesign
open Elmish
open Fable.Core
open Fable.Core.JsInterop

type State = {
    SelectedMenuItem: string array
}

type Msg =
    | SelectMenuItem of string array

let init() = { SelectedMenuItem = [| "Overview.md" |] }, Cmd.none

let update (msg: Msg) (state: State) =
    match msg with
    | SelectMenuItem path -> { state with SelectedMenuItem = path }, Cmd.none

let render (state: State) (dispatch: Msg -> unit) =
    Ant.layout [
        Ant.sider [
            sider.style [ style.backgroundColor.white ]
            sider.children [
                Ant.menu [
                    menu.mode.inline'
                    menu.theme.light
                    menu.selectedKeys state.SelectedMenuItem
                    menu.defaultSelectedKeys state.SelectedMenuItem
                    menu.onSelect (fun ev -> dispatch (SelectMenuItem ev.keyPath))
                    menu.children [
                        Ant.menuItemGroup [
                            menuItemGroup.title "Feliz.AntDesign"
                            menuItemGroup.children [
                                Ant.menuItem [
                                    menuItem.key "Overview.md"
                                    menuItem.text "Overview"
                                ]
                                Ant.menuItem [
                                    menuItem.key "Installation.md"
                                    menuItem.text "Installation"
                                ]
                            ]
                        ]

                        Ant.menuItemGroup [
                            menuItemGroup.title "Components"
                            menuItemGroup.children [
                                Ant.menuItem [
                                    menuItem.key "Button.md"
                                    menuItem.text "Button"
                                ]

                                Ant.menuItem [
                                    menuItem.key "Grid.md"
                                    menuItem.text "Grid"
                                ]

                                Ant.menuItem [
                                    menuItem.key "Breadcrumb.md"
                                    menuItem.text "Breadcrumb"
                                ]

                                Ant.menuItem [
                                    menuItem.key "Comment.md"
                                    menuItem.text "Comment"
                                ]

                                Ant.menuItem [
                                    menuItem.key "Collapse.md"
                                    menuItem.text "Collapse"
                                ]
                            ]
                        ]
                    ]
                ]
            ]
        ]

        Ant.layout [
            Ant.content [
                content.style [ style.padding 20; style.backgroundColor.white ]
                content.children [
                    MarkdownLoader.loadMarkdown (List.ofArray state.SelectedMenuItem)
                ]
            ]
        ]
    ]