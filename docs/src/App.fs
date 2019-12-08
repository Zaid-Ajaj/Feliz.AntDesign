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
                menu.theme.light
                menu.selectedKeys [| "1" |]
                menu.mode.inline'
                menu.children [
                    Ant.menuIem [
                        menuItem.key "1"
                        menuItem.text "Introduction"
                    ]

                    Ant.menuIem [
                        menuItem.key "2"
                        menuItem.text "Installation"
                    ]
                ]
            ]
        ]

        Ant.layout [
            Ant.layoutContent [
                layoutContent.style [ style.padding 20 ]
                layoutContent.children [
                    Ant.button [
                        button.primary
                        button.size.large
                        button.icon.search
                        button.text "Click"
                    ]

                    Ant.icon [
                        icon.search
                    ]

                    Ant.icon [
                        icon.copy
                        icon.rotate 20.0
                        icon.theme.twoTone
                        icon.twoToneColor "#000"
                    ]
                    
                    Ant.title [
                        title.text "Introduction"
                    ]
                    Ant.paragraph [
                        paragraph.text "In the process of internal desktop applications development, many different design specs and implementations would be involved, which might cause designers and developers difficulties and duplication and reduce the efficiency of development."
                    ]

                    Ant.paragraph [
                        paragraph.text "After massive project practice and summaries, Ant Design, a design language for background"
                        paragraph.children[
                            Ant.text [
                                text.text "uniform the user interface specs for internal background projects, lower the unnecessary cost of design differences and implementation and liberate the resources of design and front-end development"
                                text.strong true
                            ]
                        ]
                    ]
                    
                    Ant.title [
                        title.text "Another title"
                        title.level 2
                    ]

                    Ant.paragraph [
                        paragraph.children [
                            Ant.text [
                                text.text "We supply a series of design principles, practical patterns and high quality design resources"
                                text.children [
                                    Ant.text [
                                        text.text "principles, practical resources"
                                        text.code true
                                    ]

                                ]
                            ]
                        ]
                        
                    ]

                    
                ]
            ]
        ]
    ]