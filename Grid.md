# Grid

```fsharp:basic-grid 
Ant.row [
    row.children [
        Ant.col [
            col.span 12
        ]
        Ant.col [
            col.span 12
        ]
    ]
]
Ant.row [
    row.children [
        Ant.col [
            col.span 8
        ]
        Ant.col [
            col.span 8
        ]
        Ant.col [
            col.span 8
        ]
    ]
]
Ant.row [
    row.children [
        Ant.col [
            col.span 6
        ]
        Ant.col [
            col.span 6
        ]
        Ant.col [
            col.span 6
        ]
        Ant.col [
            col.span 6
        ]
    ]
]
```
```fsharp:flex-aligned-align-top-grid 
Ant.row [
    row.flex
    row.justify.center
    row.align.top
    row.children [
        Ant.col [
            col.span 6
        ]
        Ant.col [
            col.span 6
        ]
        Ant.col [
            col.span 6
        ]
    ]
]
```
```fsharp:flex-aligned-align-center-grid 
Ant.row [
    row.flex
    row.justify.spaceAround
    row.align.middle
    row.children [
        Ant.col [
            col.span 6
        ]
        Ant.col [
            col.span 6
        ]
        Ant.col [
            col.span 6
        ]
    ]
]
```
```fsharp:flex-aligned-align-bottom-grid 
Ant.row [
    row.flex
    row.justify.spaceBetween
    row.align.bottom
    row.children [
        Ant.col [
            col.span 6
        ]
        Ant.col [
            col.span 6
        ]
        Ant.col [
            col.span 6
        ]
    ]
]
```
```fsharp:flex-order-grid
Ant.row [
    row.flex
    row.children [
        Ant.col [
            col.span 6
            col.order 4
        ]
        Ant.col [
            col.span 6
            col.order 3
        ]
        Ant.col [
            col.span 6
            col.order 2
        ]
        Ant.col [
            col.span 6
            col.order 1
        ]
    ]
] 
```
```fsharp:flex-layout-sub-element-align-left
Ant.row [
    row.flex
    row.justify.startPosition
    row.children [
        Ant.col [
            col.span 4
        ]
        Ant.col [
            col.span 4
        ]
        Ant.col [
            col.span 4
        ]
        Ant.col [
            col.span 4
        ]
    ]
]
```
```fsharp:flex-layout-sub-element-align-center
Ant.row [
    row.flex
    row.justify.center
    row.children [
        Ant.col [
            col.span 4
        ]
        Ant.col [
            col.span 4
        ]
        Ant.col [
            col.span 4
        ]
        Ant.col [
            col.span 4
        ]
    ]
]
```
```fsharp:flex-layout-sub-element-align-right
Ant.row [
    row.flex
    row.justify.endPosition
    row.children [
        Ant.col [
            col.span 4
        ]
        Ant.col [
            col.span 4
        ]
        Ant.col [
            col.span 4
        ]
        Ant.col [
            col.span 4
        ]
    ]
]
```
```fsharp:grid-gutter
Ant.row [
    row.gutter 16
    row.children [
        Ant.col [
            col.span 6
        ]
        Ant.col [
            col.span 6
        ]
        Ant.col [
            col.span 6
        ]
        Ant.col [
            col.span 6
        ]        
    ]
]
```
```fsharp:a-column-first
Ant.row [
    row.children [
        Ant.row [
            row.children [
                Ant.col [
                    col.span 8
                ]
                Ant.col [
                    col.span 8
                    col.offset 8
                ]
            ]
        ]
        Ant.row [
            row.children [
                Ant.col [
                    col.span 6
                    col.offset 6
                ]
                Ant.col [
                    col.span 6
                    col.offset 6
                ]
            ]
        ]
        Ant.row [
            row.children [
                Ant.col [
                    col.span 12
                    col.offset 6
                ]
            ]
        ]
    ]
]
```
```fsharp:responsive
Ant.row [
    row.children [
        Ant.col [
            col.xs 2
            col.sm 4
            col.md(span=6)
            col.lg 8
            col.xl 10
        ]
        Ant.col [
            col.xs(span=20, offset=0)
            col.sm 16
            col.md 12
            col.lg 8
            col.xl 4              
        ]
        Ant.col [
            col.xs 2
            col.sm 4
            col.md 6
            col.lg(span=8)
            col.xl 10
        ]
    ]
]
```
```fsharp:grid-sort
Ant.row [
    row.children [
        Ant.col [
            col.span 18
            col.push 6
        ]
        Ant.col [
            col.span 6
            col.pull 18
        ]
    ]
]
```



