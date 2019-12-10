module Samples

open Feliz
open Feliz.AntDesign

let createSample (name: string) (xs: ReactElement list) =
    name, Html.div [
        prop.style [ style.padding 10 ]
        prop.children xs
    ]

let samples = [
    createSample "primary-button" [
        Ant.button [
            button.primary
            button.text "Primary"
        ]
    ]

    createSample "large-primary-button" [
        Ant.button [
            button.primary
            button.size.large
            button.text "Large Primary"
        ]
    ]

    createSample "danger-button" [
        Ant.button [
            button.danger
            button.text "Danger"
        ]
    ]

    createSample "ghost-button" [
        Ant.button [
            button.ghost
            button.icon.search
            button.text "Ghost"
        ]
    ]

    createSample "loading-button" [
        Ant.button [
            button.dashed
            button.text "Loading"
            button.loading true
        ]
    ]

    createSample "disabled-button" [
        Ant.button [
            button.primary
            button.disabled true
            button.text "Disabled"
        ]
    ]

    createSample "round-button" [
        Ant.button [
            button.shape.round
            button.icon.search
            button.primary
        ]
    ]
]