module Comment

open Feliz
open Feliz.AntDesign
open System

let samples = [
    Sample.create "basic-comment" [
        Ant.comment [
            comment.author [ Html.a [ prop.text "Han Solo" ] ]
            comment.actions [
                Html.span [
                    prop.key "comment-like"
                    prop.text "LIKE"
                ]

                Html.span [
                    prop.key "comment-dislike"
                    prop.text "DISLIKE"
                ]
            ]

            comment.avatar [
                Ant.avatar [
                    avatar.src "https://zos.alipayobjects.com/rmsportal/ODTLcjxAfvqbxHnVXCYX.png"
                    avatar.alt "Han Solo"
                ]
            ]

            comment.content [
                Html.p "We supply a series of design principles"
            ]

            comment.datetime [
                Html.span (DateTime.Now.ToShortDateString())
            ]
        ]
    ]
]