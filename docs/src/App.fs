module App

open Feliz
open Feliz.AntDesign
open Elmish

type State = { Count: int }

type Msg =
    | Increment
    | Decrement

let init() = { Count = 0 }, Cmd.none

let update (msg: Msg) (state: State) =
    match msg with
    | Increment -> { state with Count = state.Count + 1 }, Cmd.none
    | Decrement -> { state with Count = state.Count - 1 }, Cmd.none

let render (state: State) (dispatch: Msg -> unit) =
    Ant.layout [
        Ant.layoutSider [
            Ant.menu [
                prop.custom("defaultSelectedKey", [| 1 |])
                prop.custom("defaultOpenKeys", [| "sub1" |])
                prop.custom("mode", "inline")
                prop.children [
                    Ant.menuIem [
                        prop.custom("key", 1)
                        prop.text "Page 1"
                    ]

                    Ant.menuIem [
                        prop.custom("key", 2)
                        prop.text "Page 2"
                    ]
                ]
            ]
        ]

        Ant.layout [
            Ant.layoutContent [
                prop.style [ style.padding 20 ]
                prop.children [
                    Ant.button [
                        button.primary
                        button.size.large
                        button.icon.search
                        button.text "Click"
                    ]
                ]
            ]
        ]
    ]
