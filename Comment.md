# Comment

See [Ant Design Docs](https://ant.design/components/comment/)

A comment displays user feedback and discussion to website content.

### When To Use

Comments can be used to enable discussions on an entity such as a page, blog post, issue or other.

### Example

```fsharp:basic-comment
Ant.comment [
    comment.author [ Html.a "Han Solo" ]
    comment.actions [
        Html.span [
            prop.key "comment-like"
            prop.children [
                Ant.icon [ icon.like ]
            ]
        ]
        Html.span [
            prop.key "comment-dislike"
            prop.children [
                Ant.icon [ icon.dislike ]
            ]
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
```