module Grid

open Feliz
open Feliz.AntDesign

let samples = [
    Sample.create "basic-grid" [
        Ant.title [
            title.text "Basic Grid"
            title.level 3
        ]
        Ant.row [
            row.style [ style.paddingBottom 10 ]
            row.children [
                Ant.col [
                    col.span 12
                    col.style [ style.backgroundColor "#2fa6ef"; style.height 50 ]
                    col.children [
                        Ant.title [
                            title.text "col-12"
                            title.level 4
                            title.style [ style.textAlign.center; style.color.white ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 12
                    col.style [ style.backgroundColor "#5ab9f4 "; style.height 50 ]
                    col.children [
                        Ant.title [
                            title.text "col-12"
                            title.level 4
                            title.style [ style.textAlign.center; style.color.white ]
                        ]
                    ]
                ]
            ]
        ]
        Ant.row [
            row.style [ style.paddingBottom 10 ]
            row.children [
                Ant.col [
                    col.span 8
                    col.style [ style.backgroundColor "#2fa6ef"; style.height 50 ]
                    col.children [
                        Ant.title [
                            title.text "col-8"
                            title.level 4
                            title.style [ style.textAlign.center; style.color.white ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 8
                    col.style [ style.backgroundColor "#5ab9f4 "; style.height 50 ]
                    col.children [
                        Ant.title [
                            title.text "col-8"
                            title.level 4
                            title.style [ style.textAlign.center; style.color.white ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 8
                    col.style [ style.backgroundColor "#2fa6ef"; style.height 50 ]
                    col.children [
                        Ant.title [
                            title.text "col-8"
                            title.level 4
                            title.style [ style.textAlign.center; style.color.white ]
                        ]
                    ]
                ]
            ]
        ]

        Ant.row [
            row.style [ style.paddingBottom 10 ]
            row.children [
                Ant.col [
                    col.span 6
                    col.style [ style.backgroundColor "#2fa6ef"; style.height 50 ]
                    col.children [
                        Ant.title [
                            title.text "col-6"
                            title.level 4
                            title.style [ style.textAlign.center; style.color.white ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 6
                    col.style [ style.backgroundColor "#5ab9f4 "; style.height 50 ]
                    col.children [
                        Ant.title [
                            title.text "col-6"
                            title.level 4
                            title.style [ style.textAlign.center; style.color.white ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 6
                    col.style [ style.backgroundColor "#2fa6ef"; style.height 50 ]
                    col.children [
                        Ant.title [
                            title.text "col-6"
                            title.level 4
                            title.style [ style.textAlign.center; style.color.white ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 6
                    col.style [ style.backgroundColor "#5ab9f4"; style.height 50 ]
                    col.children [
                        Ant.title [
                            title.text "col-6"
                            title.level 4
                            title.style [ style.textAlign.center; style.color.white ]
                        ]
                    ]
                ]
            ]
        ]
    ]

    Sample.create "flex-aligned-align-top-grid" [
        Ant.title [
            title.text "Flex Alignement"
            title.level 3
        ]
        Ant.row [
            Ant.title [
                title.text "Align Top"
                title.level 4
            ]

            Ant.row [
                row.style [ style.paddingBottom 10 ]
                row.flex
                row.justify.center
                row.align.top
                row.children [
                    Ant.col [
                        col.span 6
                        col.style [ style.backgroundColor "#5ab9f4"; style.height 60 ]
                        col.children [
                            Ant.title [
                                title.text "col-8"
                                title.level 4
                                title.style [ style.textAlign.center; style.color.white ]
                            ]
                        ]
                    ]
                    Ant.col [
                        col.span 6
                        col.style [ style.backgroundColor "#2fa6ef"; style.height 100 ]
                        col.children [
                            Ant.title [
                                title.text "col-8"
                                title.level 4
                                title.style [ style.textAlign.center; style.color.white ]
                            ]
                        ]
                    ]
                    Ant.col [
                        col.span 6
                        col.style [ style.backgroundColor "#5ab9f4"; style.height 80 ]
                        col.children [
                            Ant.title [
                                title.text "col-8"
                                title.level 4
                                title.style [ style.textAlign.center; style.color.white ]
                            ]
                        ]
                    ]
                ]
            ]
        ]
    ]

    Sample.create "flex-aligned-align-center-grid" [
        Ant.row [
            Ant.title [
                title.text "Align Center"
                title.level 4
            ]

            Ant.row [
                row.style [ style.paddingBottom 10 ]
                row.flex
                row.justify.spaceAround
                row.align.middle
                row.children [
                    Ant.col [
                        col.span 6
                        col.style [ style.backgroundColor "#5ab9f4"; style.height 60 ]
                        col.children [
                            Ant.title [
                                title.text "col-8"
                                title.level 4
                                title.style [ style.textAlign.center; style.color.white ]
                            ]
                        ]
                    ]
                    Ant.col [
                        col.span 6
                        col.style [ style.backgroundColor "#2fa6ef"; style.height 100 ]
                        col.children [
                            Ant.title [
                                title.text "col-8"
                                title.level 4
                                title.style [ style.textAlign.center; style.color.white ]
                            ]
                        ]
                    ]
                    Ant.col [
                        col.span 6
                        col.style [ style.backgroundColor "#5ab9f4"; style.height 80 ]
                        col.children [
                            Ant.title [
                                title.text "col-8"
                                title.level 4
                                title.style [ style.textAlign.center; style.color.white ]
                            ]
                        ]
                    ]
                ]
            ]
        ]
    ]

    Sample.create "flex-aligned-align-bottom-grid" [
        Ant.row [
            Ant.title [
                title.text "Align Bottom"
                title.level 4
            ]
            Ant.row [
                row.style [ style.paddingBottom 10 ]
                row.flex
                row.justify.spaceBetween
                row.align.bottom
                row.children [
                    Ant.col [
                        col.span 6
                        col.style [ style.backgroundColor "#5ab9f4"; style.height 60 ]
                        col.children [
                            Ant.title [
                                title.text "col-8"
                                title.level 4
                                title.style [ style.textAlign.center; style.color.white ]
                            ]
                        ]
                    ]
                    Ant.col [
                        col.span 6
                        col.style [ style.backgroundColor "#2fa6ef"; style.height 100 ]
                        col.children [
                            Ant.title [
                                title.text "col-8"
                                title.level 4
                                title.style [ style.textAlign.center; style.color.white ]
                            ]
                        ]
                    ]
                    Ant.col [
                        col.span 6
                        col.style [ style.backgroundColor "#5ab9f4"; style.height 80 ]
                        col.children [
                            Ant.title [
                                title.text "col-8"
                                title.level 4
                                title.style [ style.textAlign.center; style.color.white ]
                            ]
                        ]
                    ]
                ]
            ]
        ]
    ]

    Sample.create "flex-order-grid" [
        Ant.title [
            title.text "Flex Order"
            title.level 3
        ]
        Ant.row [
            row.style [ style.paddingBottom 10 ]
            row.flex
            row.children [
                Ant.col [
                    col.span 6
                    col.order 4
                    col.style [ style.backgroundColor "#5ab9f4"; style.height 50 ]
                    col.children [
                        Ant.title [
                            title.text "1 col-6-order-4"
                            title.level 4
                            title.style [ style.textAlign.center; style.color.white ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 6
                    col.order 3
                    col.style [ style.backgroundColor "#2fa6ef"; style.height 50 ]
                    col.children [
                        Ant.title [
                            title.text "2 col-6-order-3"
                            title.level 4
                            title.style [ style.textAlign.center; style.color.white ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 6
                    col.order 2
                    col.style [ style.backgroundColor "#5ab9f4"; style.height 50 ]
                    col.children [
                        Ant.title [
                            title.text "3 col-6-order-2"
                            title.level 4
                            title.style [ style.textAlign.center; style.color.white ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 6
                    col.order 1
                    col.style [ style.backgroundColor "#2fa6ef"; style.height 50 ]
                    col.children [
                        Ant.title [
                            title.text "4 col-6-order-1"
                            title.level 4
                            title.style [ style.textAlign.center; style.color.white ]
                        ]
                    ]
                ]
            ]
        ]
    ]

    Sample.create "flex-layout-sub-element-align-left" [
        Ant.title [
            title.text "Flex Layout"
            title.level 3
        ]
        Ant.row [
            Ant.title [
                title.text "sub-element align left"
                title.level 4
            ]
            Ant.row [
                row.style [ style.paddingBottom 10 ]
                row.flex
                row.justify.startPosition
                row.children [
                    Ant.col [
                        col.span 4
                        col.style [ style.backgroundColor "#5ab9f4"; style.height 50 ]
                        col.children [
                            Ant.title [
                                title.text "col-4"
                                title.level 4
                                title.style [ style.textAlign.center; style.color.white ]
                            ]
                        ]
                    ]
                    Ant.col [
                        col.span 4
                        col.style [ style.backgroundColor "#2fa6ef"; style.height 50 ]
                        col.children [
                            Ant.title [
                                title.text "col-4"
                                title.level 4
                                title.style [ style.textAlign.center; style.color.white ]
                            ]
                        ]
                    ]
                    Ant.col [
                        col.span 4
                        col.style [ style.backgroundColor "#5ab9f4"; style.height 50 ]
                        col.children [
                            Ant.title [
                                title.text "col-4"
                                title.level 4
                                title.style [ style.textAlign.center; style.color.white ]
                            ]
                        ]
                    ]
                    Ant.col [
                        col.span 4
                        col.style [ style.backgroundColor "#2fa6ef"; style.height 50 ]
                        col.children [
                            Ant.title [
                                title.text "col-4"
                                title.level 4
                                title.style [ style.textAlign.center; style.color.white ]
                            ]
                        ]
                    ]
                ]
            ]
        ]
    ]

    Sample.create "flex-layout-sub-element-align-center" [
        Ant.row [
            Ant.title [
                title.text "sub-element align center"
                title.level 4
            ]
            Ant.row [
                row.style [ style.paddingBottom 10 ]
                row.flex
                row.justify.center
                row.children [
                    Ant.col [
                        col.span 4
                        col.style [ style.backgroundColor "#5ab9f4"; style.height 50 ]
                        col.children [
                            Ant.title [
                                title.text "col-4"
                                title.level 4
                                title.style [ style.textAlign.center; style.color.white ]
                            ]
                        ]
                    ]
                    Ant.col [
                        col.span 4
                        col.style [ style.backgroundColor "#2fa6ef"; style.height 50 ]
                        col.children [
                            Ant.title [
                                title.text "col-4"
                                title.level 4
                                title.style [ style.textAlign.center; style.color.white ]
                            ]
                        ]
                    ]
                    Ant.col [
                        col.span 4
                        col.style [ style.backgroundColor "#5ab9f4"; style.height 50 ]
                        col.children [
                            Ant.title [
                                title.text "col-4"
                                title.level 4
                                title.style [ style.textAlign.center; style.color.white ]
                            ]
                        ]
                    ]
                    Ant.col [
                        col.span 4
                        col.style [ style.backgroundColor "#2fa6ef"; style.height 50 ]
                        col.children [
                            Ant.title [
                                title.text "col-4"
                                title.level 4
                                title.style [ style.textAlign.center; style.color.white ]
                            ]
                        ]
                    ]
                ]
            ]
        ]
    ]

    Sample.create "flex-layout-sub-element-align-right" [
        Ant.row [
            Ant.title [
                title.text "sub-element align right"
                title.level 4
            ]
            Ant.row [
                row.style [ style.paddingBottom 10 ]
                row.flex
                row.justify.endPosition
                row.children [
                    Ant.col [
                        col.span 4
                        col.style [ style.backgroundColor "#5ab9f4"; style.height 50 ]
                        col.children [
                            Ant.title [
                                title.text "col-4"
                                title.level 4
                                title.style [ style.textAlign.center; style.color.white ]
                            ]
                        ]
                    ]
                    Ant.col [
                        col.span 4
                        col.style [ style.backgroundColor "#2fa6ef"; style.height 50 ]
                        col.children [
                            Ant.title [
                                title.text "col-4"
                                title.level 4
                                title.style [ style.textAlign.center; style.color.white ]
                            ]
                        ]
                    ]
                    Ant.col [
                        col.span 4
                        col.style [ style.backgroundColor "#5ab9f4"; style.height 50 ]
                        col.children [
                            Ant.title [
                                title.text "col-4"
                                title.level 4
                                title.style [ style.textAlign.center; style.color.white ]
                            ]
                        ]
                    ]
                    Ant.col [
                        col.span 4
                        col.style [ style.backgroundColor "#2fa6ef"; style.height 50 ]
                        col.children [
                            Ant.title [
                                title.text "col-4"
                                title.level 4
                                title.style [ style.textAlign.center; style.color.white ]
                            ]
                        ]
                    ]
                ]
            ]
        ]
    ]

    Sample.create "grid-gutter" [
        Ant.title [
            title.text "Grid Gutter"
            title.level 3
        ]
        Ant.row [
            row.style [ style.paddingBottom 10 ]
            row.gutter 16
            row.children [
                Ant.col [
                    col.span 6
                    col.style [ style.backgroundColor "#5ab9f4"; style.height 50 ]
                    col.children [
                        Ant.title [
                            title.text "col-6"
                            title.level 4
                            title.style [ style.textAlign.center; style.color.white ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 6
                    col.style [ style.backgroundColor "#2fa6ef"; style.height 50 ]
                    col.children [
                        Ant.title [
                            title.text "col-6"
                            title.level 4
                            title.style [ style.textAlign.center; style.color.white ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 6
                    col.style [ style.backgroundColor "#5ab9f4"; style.height 50 ]
                    col.children [
                        Ant.title [
                            title.text "col-6"
                            title.level 4
                            title.style [ style.textAlign.center; style.color.white ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 6
                    col.style [ style.backgroundColor "#2fa6ef"; style.height 50 ]
                    col.children [
                        Ant.title [
                            title.text "col-6"
                            title.level 4
                            title.style [ style.textAlign.center; style.color.white ]
                        ]
                    ]
                ]
            ]
        ]
    ]
    Sample.create "a-column-first" [
        Ant.title [
            title.text "Column Offset"
            title.level 3
        ]
        Ant.row [
            Ant.row [
                row.style [ style.paddingBottom 10 ]
                row.children [
                    Ant.col [
                        col.span 8
                        col.style [ style.backgroundColor "#5ab9f4"; style.height 50 ]
                        col.children [
                            Ant.title [
                                title.text "col-8"
                                title.level 4
                                title.style [ style.textAlign.center; style.color.white ]
                            ]
                        ]
                    ]
                    Ant.col [
                        col.span 8
                        col.offset 8
                        col.style [ style.backgroundColor "#2fa6ef"; style.height 50 ]
                        col.children [
                            Ant.title [
                                title.text "col-8-offset-8"
                                title.level 4
                                title.style [ style.textAlign.center; style.color.white ]
                            ]
                        ]
                    ]
                ]
            ]
            Ant.row [
                row.style [ style.paddingBottom 10 ]
                row.children [
                    Ant.col [
                        col.span 6
                        col.offset 6
                        col.style [ style.backgroundColor "#5ab9f4"; style.height 50 ]
                        col.children [
                            Ant.title [
                                title.text "col-6-offset-6"
                                title.level 4
                                title.style [ style.textAlign.center; style.color.white ]
                            ]
                        ]
                    ]
                    Ant.col [
                        col.span 6
                        col.offset 6
                        col.style [ style.backgroundColor "#2fa6ef"; style.height 50 ]
                        col.children [
                            Ant.title [
                                title.text "col-6-offset-6"
                                title.level 4
                                title.style [ style.textAlign.center; style.color.white ]
                            ]
                        ]
                    ]
                ]
            ]
            Ant.row [
                row.style [ style.paddingBottom 10 ]
                row.children [
                    Ant.col [
                        col.span 12
                        col.offset 6
                        col.style [ style.backgroundColor "#5ab9f4"; style.height 50 ]
                        col.children [
                            Ant.title [
                                title.text "col-12-offset-6"
                                title.level 4
                                title.style [ style.textAlign.center; style.color.white ]
                            ]
                        ]
                    ]
                ]
            ]
        ]
    ]
    Sample.create "responsive" [
        Ant.title [
            title.text "Responsive"
            title.level 3
        ]
        Ant.row [
            row.style [ style.paddingBottom 10 ]
            row.children [
                Ant.col [
                    col.xs 2
                    col.sm 4
                    col.md 6
                    col.lg 8
                    col.xl 10
                    col.style [ style.backgroundColor "#2fa6ef"; style.height 50 ]
                    col.children [
                        Ant.title [
                            title.text "col"
                            title.level 4
                            title.style [ style.textAlign.center; style.color.white ]
                        ]
                    ]
                ]
                Ant.col [
                    col.xs 20
                    col.sm 16
                    col.md 12
                    col.lg 8
                    col.xl 4
                    col.style [ style.backgroundColor "#5ab9f4"; style.height 50 ]
                    col.children [
                        Ant.title [
                            title.text "col"
                            title.level 4
                            title.style [ style.textAlign.center; style.color.white ]
                        ]
                    ]
                ]
                Ant.col [
                    col.xs 2
                    col.sm 4
                    col.md 6
                    col.lg 8
                    col.xl 10
                    col.style [ style.backgroundColor "#2fa6ef"; style.height 50 ]
                    col.children [
                        Ant.title [
                            title.text "col"
                            title.level 4
                            title.style [ style.textAlign.center; style.color.white ]
                        ]
                    ]
                ]
            ]
        ]
    ]

    Sample.create "grid-sort" [
        Ant.title [
            title.text "Grid Sort"
            title.level 3
        ]
        Ant.row [
            row.style [ style.paddingBottom 10 ]
            row.children [
                Ant.col [
                    col.span 18
                    col.push 6
                    col.style [ style.backgroundColor "#2fa6ef"; style.height 50 ]
                    col.children [
                        Ant.title [
                            title.text "col-18 col-push-6"
                            title.level 4
                            title.style [ style.textAlign.center; style.color.white ]
                        ]
                    ]
                ]
                Ant.col [
                    col.span 6
                    col.pull 18
                    col.style [ style.backgroundColor "#5ab9f4"; style.height 50 ]
                    col.children [
                        Ant.title [
                            title.text "col-6 col-pull-18"
                            title.level 4
                            title.style [ style.textAlign.center; style.color.white ]
                        ]
                    ]
                ]
            ]
        ]
    ]
]