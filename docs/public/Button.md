# Button

```fsharp:primary-button
Ant.button [
    button.primary
    button.text "Primary"
]
```
```fsharp:large-primary-button
Ant.button [
    button.primary
    button.size.large
    button.text "Large Primary"
]
```

```fsharp:danger-button
Ant.button [
    button.danger
    button.text "Danger"
]
```
```fsharp:ghost-button
Ant.button [
    button.ghost
    button.text "Ghost"
    button.icon.searchOutlined()
]
```

```fsharp:loading-button
Ant.button [
    button.dashed
    button.text "Loading"
    button.loading true
]
```
```fsharp:disabled-button
Ant.button [
    button.primary
    button.disabled true
    button.text "Disabled"
]
```
```fsharp:round-button
Ant.button [
    button.primary
    button.shape.round
    button.icon.homeOutlined()
]
```
```fsharp:custom-icon
Ant.button [
    button.primary
    button.shape.round
    button.icon (AntIcons.homeOutlined [ icon.spin true ])
]
```