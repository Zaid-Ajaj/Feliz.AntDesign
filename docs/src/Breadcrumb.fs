module Breadcrumb

open Feliz
open Feliz.AntDesign

let samples = [
    Sample.create "basic-usage" [
        Ant.breadcrumb [
            Ant.breadcrumbItem [ Html.text "Home" ]
            Ant.breadcrumbItem [
                Html.a [ prop.href "#"; prop.text "Application Center" ]
            ]

            Ant.breadcrumbItem [
                Html.a [ prop.href "#"; prop.text "Application List" ]
            ]

            Ant.breadcrumbItem [ Html.text "An Application" ]
        ]
    ]

    Sample.create "custom-separator" [
        Ant.breadcrumb [
            breadcrumb.separator ">"
            breadcrumb.children [
                Ant.breadcrumbItem [ Html.text "Home" ]

                Ant.breadcrumbItem [
                    breadcrumbItem.href "#"
                    breadcrumbItem.text "Application Center"
                ]

                Ant.breadcrumbItem [
                    breadcrumbItem.href "#"
                    breadcrumbItem.text "Application Center"
                ]

                Ant.breadcrumbItem [ Html.text "An Application" ]
            ]
        ]
    ]

    Sample.create "configurable-separator" [
        Ant.breadcrumb [
            breadcrumb.separator ""
            breadcrumb.children [
                Ant.breadcrumbItem [ Html.text "Location" ]
                
                Ant.breadcrumbSeparator ":"
                
                Ant.breadcrumbItem [
                    breadcrumbItem.href "#"
                    breadcrumbItem.text "Application Center"
                ]

                Ant.breadcrumbSeparator [ ]

                Ant.breadcrumbItem [
                    breadcrumbItem.href "#"
                    breadcrumbItem.text "Application Center"
                ]

                Ant.breadcrumbSeparator [ ]

                Ant.breadcrumbItem "An Application"
            ]
        ]
    ]
]