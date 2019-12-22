# Collapse

See [Ant Design Docs](https://ant.design/components/collapse/)

A content area which can be collapsed and expanded.

### When to use
 - Can be used to group or hide complex regions to keep the page clean.
 - `Accordion` is a special kind of `Collapse`, which allows only one panel to be expanded at a time.

### Examples
Basic Collapse

```fsharp:basic-collapse
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
```