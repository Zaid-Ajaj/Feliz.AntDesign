module Collapse

open Feliz
open Feliz.AntDesign

let samples = [
    Sample.create "basic-collapse" [
        Ant.collapse [
            collapse.defaultActiveKey [ "1" ]
            collapse.panels [
                Ant.collapsePanel [
                    collapsePanel.key "1"
                    collapsePanel.header "This is panel header 1"
                    collapsePanel.children [
                        Html.p  "A dog is a type of domesticated animal. Known for its loyalty and faithfulness"
                    ]
                ]

                Ant.collapsePanel [
                    collapsePanel.key "2"
                    collapsePanel.header "This is panel header 2"
                    collapsePanel.children [
                        Html.p  "A dog is a type of domesticated animal. Known for its loyalty and faithfulness"
                    ]
                ]

                Ant.collapsePanel [
                    collapsePanel.key "3"
                    collapsePanel.disabled true
                    collapsePanel.header "This is panel header 3"
                    collapsePanel.children [
                        Html.p  "A dog is a type of domesticated animal. Known for its loyalty and faithfulness"
                    ]
                ]
            ]
        ]
    ]
]