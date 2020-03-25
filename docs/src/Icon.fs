module Icon

open Feliz
open Feliz.AntDesign

(*
let samples = [ 
    Sample.create "clock-circle-icon-main-example" [
        Ant.row [
            row.children [
                Ant.col [
                    col.span 8
                    col.children [
                        Ant.icon [
                            icon.clockCircle
                            icon.style [ style.fontSize 25 ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 8
                    col.children [
                        Ant.icon [
                            icon.clockCircle
                            icon.theme.filled
                            icon.style [ style.fontSize 25 ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 8
                    col.children [
                        Ant.icon [
                            icon.clockCircle
                            icon.theme.twoTone
                            icon.style [ style.fontSize 25 ]
                        ]
                    ]
                ]
            ]
        ]
    ]

    Sample.create "directional-icons" [
        Ant.title [
            title.text "Directional Icons"
            title.level 3
        ]
        Ant.row [
            row.style [ style.paddingBottom 22 ]
            row.children [
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.stepBackward
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "stepBackward"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.stepForward
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "stepForward"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.fastForward
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "fastForward"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.fastBackward
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "fastBackward"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.shrink
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "shrink"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.arrowsAlt
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "arrowsAlt"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
            ]
        ]
        Ant.row [
            row.style [ style.paddingBottom 22 ]
            row.children [
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.down
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "down"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.up
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "up"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.left
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "left"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.right
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "right"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.caretUp
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "caretUp"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.caretDown
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "caretDown"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
            ]
        ]
        Ant.row [
            row.style [ style.paddingBottom 22 ]
            row.children [
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.caretLeft
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "caretLeft"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.caretRight
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "caretRight"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.upCircle
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "upCircle"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.downCircle
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "downCircle"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.leftCircle
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "leftCircle"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.rightCircle
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "rightCircle"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
            ]
        ]
        Ant.row [
            row.style [ style.paddingBottom 22 ]
            row.children [
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.doubleRight
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "doubleRight"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.doubleLeft
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "doubleLeft"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.verticalLeft
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "verticalLeft"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.verticalRight
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "verticalRight"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.verticalAlignTop
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "verticalAlignTop"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.verticalAlignMiddle
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "verticalAlignMiddle"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
            ]
        ]
        Ant.row [
            row.style [ style.paddingBottom 22 ]
            row.children [
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.verticalAlignBottom
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "verticalAlignBottom"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.forward
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "forward"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.backward
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "backward"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.rollback
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "rollback"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.enter
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "enter"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.retweet
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "retweet"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
            ]
        ]
        Ant.row [
            row.style [ style.paddingBottom 22 ]
            row.children [
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.swap
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "swap"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.swapLeft
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "swapLeft"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.swapRight
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "swapRight"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.arrowUp
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "arrowUp"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.arrowDown
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "arrowDown"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.arrowLeft
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "arrowLeft"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
            ]
        ]
        Ant.row [
            row.style [ style.paddingBottom 22 ]
            row.children [
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.arrowRight
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "arrowRight"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.playCircle
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "playCircle"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.upSquare
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "upSquare"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.downSquare
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "downSquare"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.leftSquare
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "leftSquare"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.rightSquare
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "rightSquare"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
            ]
        ]
        Ant.row [
            row.style [ style.paddingBottom 22 ]
            row.children [
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.login
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "login"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.logout
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "logout"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.menuFold
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "menuFold"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.menuUnfold
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "menuUnfold"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.borderBottom
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "borderBottom"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.borderHorizontal
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "borderHorizontal"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
            ]
        ]
        Ant.row [
            row.style [ style.paddingBottom 22 ]
            row.children [
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.borderInner
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "borderInner"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.borderOuter
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "borderOuter"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.borderLeft
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "borderLeft"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.borderRight
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "borderRight"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.borderTop
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "borderTop"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.borderVerticle
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "borderVerticle"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
            ]
        ]
        Ant.row [
            row.style [ style.paddingBottom 22 ]
            row.children [
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.picCenter
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "picCenter"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.picLeft
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "picLeft"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.picRight
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "picRight"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.radiusBottomleft
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "radiusBottomleft"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.radiusBottomright
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "radiusBottomright"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.radiusUpleft
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "radiusUpleft"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
            ]
        ]
        Ant.row [
            row.style [ style.paddingBottom 22 ]
            row.children [
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.radiusUpright
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "radiusUpright"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.fullscreen
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "fullscreen"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.fullscreenExit
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "fullscreenExit"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
            ]
        ]
    ]

    Sample.create "suggested-icons" [
        Ant.title [
            title.text "Suggested Icons"
            title.level 3
        ]
        Ant.row [
            row.style [ style.paddingBottom 22 ]
            row.children [
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.question
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "question"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.questionCircle
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "questionCircle"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.plus
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "plus"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.plusCircle
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "plusCircle"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.pause
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "pause"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.pauseCircle
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "pauseCircle"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
            ]
        ]
        Ant.row [
            row.style [ style.paddingBottom 22 ]
            row.children [
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.minus
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "minus"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.minusCircle
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "minusCircle"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.plusSquare
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "plusSquare"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.minusSquare
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "minusSquare"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.info
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "info"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.infoCircle
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "infoCircle"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
            ]
        ]
        Ant.row [
            row.style [ style.paddingBottom 22 ]
            row.children [
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.exclamation
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "exclamation"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.exclamationCircle
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "exclamationCircle"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.close
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "close"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.closeCircle
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "closeCircle"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.closeSquare
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "closeSquare"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.check
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "check"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
            ]
        ]
        Ant.row [
            row.style [ style.paddingBottom 22 ]
            row.children [
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.checkCircle
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "checkCircle"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.checkSquare
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "checkSquare"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.clockCircle
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "clockCircle"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.warning
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "warning"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.issuesClose
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "issuesClose"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.stop
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "stop"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
            ]
        ]
    ]

    Sample.create "editor-icons" [
        Ant.title [
            title.text "Editor Icons"
            title.level 3
        ]
        Ant.row [
            row.style [ style.paddingBottom 10 ]
            row.children [
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.edit
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "edit"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.form
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "form"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.copy
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "copy"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.scissor
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "scissor"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.delete
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "delete"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.snippets
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "snippets"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]

            ]
        ]
        Ant.row [
            row.style [ style.paddingBottom 10 ]
            row.children [
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.diff
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "diff"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.highlight
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "highlight"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.alignCenter
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "alignCenter"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.alignLeft
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "alignLeft"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.alignRight
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "alignRight"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.bgColors
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "bgColors"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
            ]
        ]
        Ant.row [
            row.style [ style.paddingBottom 10 ]
            row.children [
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.bold
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "bold"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.italic
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "italic"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.underline
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "underline"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.strikethrough
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "strikethrough"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.redo
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "redo"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.undo
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "undo"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
            ]
        ]
        Ant.row [
            row.style [ style.paddingBottom 10 ]
            row.children [
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.zoomIn
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "zoomIn"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.zoomOut
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "zoomOut"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.fontColors
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "fontColors"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.fontSize
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "fontSize"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.lineHeight
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "lineHeight"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.dash
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "dash"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
            ]
        ]
        Ant.row [
            row.style [ style.paddingBottom 10 ]
            row.children [
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.smallDash
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "smallDash"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.sortAscending
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "sortAscending"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.sortDescending
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "sortDescending"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.drag
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "drag"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.orderedList
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "orderedList"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.unorderedList
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "unorderedList"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
            ]
        ]
        Ant.row [
            row.style [ style.paddingBottom 10 ]
            row.children [
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.radiusSetting
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "radiusSetting"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.columnWidth
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "columnWidth"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.columnHeight
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "columnHeight"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
            ]
        ]
    ]

    Sample.create "data-icons" [
        Ant.title [
            title.text "Data Icons"
            title.level 3
        ]
        Ant.row [
            row.style [ style.paddingBottom 10 ]
            row.children [
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.areaChart
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "areaChart"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.pieChart
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "pieChart"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.barChart
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "barChart"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.dotChart
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "dotChart"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.lineChart
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "lineChart"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.radarChart
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "radarChart"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
            ]
        ]
        Ant.row [
            row.style [ style.paddingBottom 10 ]
            row.children [
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.heatMap
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "heatMap"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.fall
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "fall"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.rise
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "rise"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.stock
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "stock"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.boxPlot
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "boxPlot"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.fund
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "fund"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
            ]
        ]
        Ant.row [
            row.style [ style.paddingBottom 10 ]
            row.children [
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.sliders
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "sliders"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
            ]
        ]
    ]

    Sample.create "brand-logos" [
        Ant.title [
            title.text "Brand and Logos"
            title.level 3
        ]
        Ant.row [
            row.style [ style.paddingBottom 10 ]
            row.children [
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.android
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "android"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.apple
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "apple"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.windows
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "windows"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.ie
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "ie"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.chrome
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "chrome"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.github
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "github"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
            ]
        ]
        Ant.row [
            row.style [ style.paddingBottom 10 ]
            row.children [
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.aliwangwang
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "aliwangwang"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.dingding
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "dingding"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.weiboSquare
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "weiboSquare"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.weiboCircle
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "weiboCircle"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.taobaoCircle
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "taobaoCircle"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.html5
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "html5"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
            ]
        ]
        Ant.row [
            row.style [ style.paddingBottom 10 ]
            row.children [
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.weibo
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "weibo"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.twitter
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "twitter"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.wechat
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "wechat"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.youtube
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "youtube"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.alipayCircle
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "alipayCircle"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.taobao
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "taobao"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
            ]
        ]
        Ant.row [
            row.style [ style.paddingBottom 10 ]
            row.children [
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.skype
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "skype"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.qq
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "qq"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.mediumWorkmark
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "mediumWorkmark"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.gitlab
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "gitlab"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.medium
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "medium"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.linkedin
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "linkedin"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
            ]
        ]
        Ant.row [
            row.style [ style.paddingBottom 10 ]
            row.children [
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.googlePlus
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "googlePlus"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.dropbox
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "dropbox"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.facebook
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "facebook"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.codepen
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "codepen"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.codeSandbox
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "codeSandbox"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.amazon
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "amazon"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
            ]
        ]
        Ant.row [
            row.style [ style.paddingBottom 10 ]
            row.children [
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.google
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "google"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.codepenCircle
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "codepenCircle"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.alipay
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "alipay"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.antDesign
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "antDesign"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.antCloud
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "antCloud"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.aliyun
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "aliyun"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
            ]
        ]
        Ant.row [
            row.style [ style.paddingBottom 10 ]
            row.children [
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.zhihu
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "zhihu"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.slack
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "slack"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.slackSquare
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "slackSquare"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.behance
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "behance"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.behanceSquare
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "behanceSquare"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.dribbble
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "dribbble"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
            ]
        ]
        Ant.row [
            row.style [ style.paddingBottom 10 ]
            row.children [
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.dribbbleSquare
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "dribbbleSquare"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.instagram
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "instagram"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.yuque
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "yuque"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.alibaba
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "alibaba"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.yahoo
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "yahoo"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.reddit
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "reddit"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
            ]
        ]
        Ant.row [
            row.style [ style.paddingBottom 10 ]
            row.children [
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.sketch
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "sketch"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
            ]
        ]
    ]

    Sample.create "application-icons" [
        Ant.title [
            title.text "Application Icons"
            title.level 3
        ]
        Ant.row [
            row.style [ style.paddingBottom 10 ]
            row.children [
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.accountBook
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "accountBook"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.alert
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "alert"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.api
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "api"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.appstore
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "appstore"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.audio
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "audio"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.bank
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "bank"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
            ]
        ]
        Ant.row [
            row.style [ style.paddingBottom 10 ]
            row.children [
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.bell
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "bell"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.book
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "book"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.bug
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "bug"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.bulb
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "bulb"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.calculator
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "calculator"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.build
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "build"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
            ]
        ]
        Ant.row [
            row.style [ style.paddingBottom 10 ]
            row.children [
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.calendar
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "calendar"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.camera
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "camera"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.car
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "car"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.carryOut
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "carryOut"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.cloud
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "cloud"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.code
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "code"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
            ]
        ]
        Ant.row [
            row.style [ style.paddingBottom 10 ]
            row.children [
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.compass
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "compass"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.contacts
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "contacts"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.container
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "container"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.control
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "control"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.creditCard
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "creditCard"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.crown
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "crown"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
            ]
        ]
        Ant.row [
            row.style [ style.paddingBottom 10 ]
            row.children [
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.customerServ
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "customerServ"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.dashboard
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "dashboard"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.database
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "database"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.dislike
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "dislike"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.environment
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "environment"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.experiment
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "experiment"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
            ]
        ]
        Ant.row [
            row.style [ style.paddingBottom 10 ]
            row.children [
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.eyeInvisible
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "eyeInvisible"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.eye
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "eye"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.fileAdd
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "fileAdd"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.fileExcel
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "fileExcel"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.fileExclamat
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "fileExclamat"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.fileImage
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "fileImage"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
            ]
        ]
        Ant.row [
            row.style [ style.paddingBottom 10 ]
            row.children [
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.fileMarkdown
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "fileMarkdown"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.filePdf
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "filePdf"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.filePpt
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "filePpt"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.fileText
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "fileText"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.fileUnknown
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "fileUnknown"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.fileWord
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "fileWord"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
            ]
        ]
        Ant.row [
            row.style [ style.paddingBottom 10 ]
            row.children [
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.fileZip
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "fileZip"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.file
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "file"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.filter
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "filter"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.fire
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "fire"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.flag
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "flag"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.folderAdd
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "folderAdd"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
            ]
        ]
        Ant.row [
            row.style [ style.paddingBottom 10 ]
            row.children [
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.folder
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "folder"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.folderOpen
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "folderOpen"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.frown
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "frown"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.funnelPlot
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "funnelPlot"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.gift
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "gift"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.hdd
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "hdd"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
            ]
        ]
        Ant.row [
            row.style [ style.paddingBottom 10 ]
            row.children [
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.heart
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "heart"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.home
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "home"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.hourglass
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "hourglass"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.idcard
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "idcard"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.insurance
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "insurance"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.interaction
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "interaction"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
            ]
        ]
        Ant.row [
            row.style [ style.paddingBottom 10 ]
            row.children [
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.layout
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "layout"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.like
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "like"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.lock
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "lock"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.mail
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "mail"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.medicineBox
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "medicineBox"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.meh
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "meh"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
            ]
        ]
        Ant.row [
            row.style [ style.paddingBottom 10 ]
            row.children [
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.message
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "message"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.mobile
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "mobile"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.moneyCollect
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "moneyCollect"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.payCircle
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "payCircle"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.notification
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "notification"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.phone
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "phone"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
            ]
        ]
        Ant.row [
            row.style [ style.paddingBottom 10 ]
            row.children [
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.picture
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "picture"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.playSquare
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "playSquare"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.printer
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "printer"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.profile
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "profile"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.project
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "project"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.pushpin
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "pushpin"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
            ]
        ]
        Ant.row [
            row.style [ style.paddingBottom 10 ]
            row.children [
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.propertySafety
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "propertySafety"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.read
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "read"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.reconciliation
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "reconciliation"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.redEnvelope
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "redEnvelope"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.rest
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "rest"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.rocket
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "rocket"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
            ]
        ]
        Ant.row [
            row.style [ style.paddingBottom 10 ]
            row.children [
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.safetyCertificate
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "safetyCertificate"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.save
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "save"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.schedule
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "schedule"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.securityScan
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "securityScan"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.setting
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "setting"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.shop
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "shop"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
            ]
        ]
        Ant.row [
            row.style [ style.paddingBottom 10 ]
            row.children [
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.shopping
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "shopping"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.skin
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "skin"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.smile
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "smile"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.sound
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "sound"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.star
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "star"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.switcher
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "switcher"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
            ]
        ]
        Ant.row [
            row.style [ style.paddingBottom 10 ]
            row.children [
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.tablet
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "tablet"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.tag
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "tag"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.tags
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "tags"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.tool
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "tool"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.thunderbolt
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "thunderbolt"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.trophy
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "trophy"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
            ]
        ]
        Ant.row [
            row.style [ style.paddingBottom 10 ]
            row.children [
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.unlock
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "unlock"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.usb
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "usb"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.videoCamera
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "videoCamera"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.wallet
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "wallet"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.apartment
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "apartment"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.audit
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "audit"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
            ]
        ]
        Ant.row [
            row.style [ style.paddingBottom 10 ]
            row.children [
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.barcode
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "barcode"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.bars
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "bars"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.block
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "block"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.border
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "border"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.branches
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "branches"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.ci
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "ci"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
            ]
        ]
        Ant.row [
            row.style [ style.paddingBottom 10 ]
            row.children [
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.cloudDownload
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "cloudDownload"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.cloudServer
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "cloudServer"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.cloudSync
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "cloudSync"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.cloudUpload
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "cloudUpload"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.cluster
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "cluster"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.coffee
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "coffee"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
            ]
        ]
        Ant.row [
            row.style [ style.paddingBottom 10 ]
            row.children [
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.copyright
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "copyright"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.deploymentUnit
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "deploymentUnit"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.desktop
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "desktop"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.disconnect
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "disconnect"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.dollar
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "dollar"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.download
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "download"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
            ]
        ]
        Ant.row [
            row.style [ style.paddingBottom 10 ]
            row.children [
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.ellipsis
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "ellipsis"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.euro
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "euro"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.exceptionIcon
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "exceptionIcon"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.export
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "export"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.fileDone
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "fileDone"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.fileJpg
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "fileJpg"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
            ]
        ]
        Ant.row [
            row.style [ style.paddingBottom 10 ]
            row.children [
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.fileProtect
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "fileProtect"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.fileSync
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "fileSync"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.fileSearch
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "fileSearch"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.fork
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "fork"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.gateway
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "gateway"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.gold
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "gold"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
            ]
        ]
        Ant.row [
            row.style [ style.paddingBottom 10 ]
            row.children [
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.history
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "history"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]

                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.import
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "import"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]

                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.inbox
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "inbox"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]

                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.key
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "key"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]

                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.laptop
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "laptop"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]

                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.link
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "link"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
            ]
        ]
        Ant.row [
            row.style [ style.paddingBottom 10 ]
            row.children [
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.line
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "line"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]

                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.loading3Quarters
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "loading3Quarters"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]

                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.loading
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "loading"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]

                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.man
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "man"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]

                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.menu
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "menu"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]

                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.monitor
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "monitor"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
            ]
        ]
        Ant.row [
            row.style [ style.paddingBottom 10 ]
            row.children [
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.more
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "more"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]

                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.number
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "number"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]

                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.percentage
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "percentage"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]

                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.paperClip
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "paperClip"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]

                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.pound
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "pound"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]

                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.poweroff
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "poweroff"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
            ]
        ]
        Ant.row [
            row.style [ style.paddingBottom 10 ]
            row.children [
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.pullRequest
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "pullRequest"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]

                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.qrcode
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "qrcode"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]

                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.reload
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "reload"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]

                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.safety
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "safety"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]

                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.robot
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "robot"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]

                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.scan
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "scan"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
            ]
        ]
        Ant.row [
            row.style [ style.paddingBottom 10 ]
            row.children [
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.select
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "select"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]

                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.shake
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "shake"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]

                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.shareAlt
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "shareAlt"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]

                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.shoppingCart
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "shoppingCart"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]

                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.solution
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "solution"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]

                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.sync
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "sync"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
            ]
        ]
        Ant.row [
            row.style [ style.paddingBottom 10 ]
            row.children [
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.table
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "table"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]

                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.team
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "team"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]

                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.toTop
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "toTop"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]

                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.trademark
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "trademark"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]

                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.transaction
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "transaction"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]

                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.upload
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "upload"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
            ]
        ]
        Ant.row [
            row.style [ style.paddingBottom 10 ]
            row.children [
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.userAdd
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "userAdd"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]

                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.userDelete
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "userDelete"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]

                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.usergroupAdd
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "usergroupAdd"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]

                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.user
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "user"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]

                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.usergroupDelete
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "usergroupDelete"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]

                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.wifi
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "wifi"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
            ]
        ]
        Ant.row [
            row.style [ style.paddingBottom 10 ]
            row.children [
                Ant.col [
                    col.span 4
                    col.style [ style.textAlign.center ]
                    col.children [
                        Ant.icon [
                            icon.woman
                            icon.style [ style.fontSize 30; style.paddingBottom 10]
                        ]
                        Ant.title [
                            title.text "woman"
                            title.style [ style.fontSize 10; style.fontWeight.lighter ]
                        ]
                    ]
                ]
            ]
        ]
    ]

]*)