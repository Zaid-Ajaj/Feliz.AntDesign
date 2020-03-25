module Button

open Feliz.AntDesign

let samples = [
    Sample.create "primary-button" [
        Ant.button [
            button.primary
            button.text "Primary"
        ]
    ]

    Sample.create "large-primary-button" [
        Ant.button [
            button.primary
            button.size.large
            button.text "Large Primary"
        ]
    ]

    Sample.create "danger-button" [
        Ant.button [
            button.danger
            button.text "Danger"
        ]
    ]

    Sample.create "ghost-button" [
        Ant.button [
            button.ghost
            button.text "Ghost"
            button.icon.searchOutlined()
        ]
    ]

    Sample.create "loading-button" [
        Ant.button [
            button.dashed
            button.text "Loading"
            button.loading true
        ]
    ]

    Sample.create "disabled-button" [
        Ant.button [
            button.primary
            button.disabled true
            button.text "Disabled"
        ]
    ]

    Sample.create "round-button" [
        Ant.button [
            button.primary
            button.shape.round
            button.icon.homeOutlined()
        ]
    ]

    Sample.create "custom-icon" [
        Ant.button [
            button.primary
            button.shape.round
            button.icon (AntIcons.homeOutlined [ icon.spin true ])
        ]
    ]
]