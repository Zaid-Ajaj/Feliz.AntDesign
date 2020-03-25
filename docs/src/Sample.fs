module Sample

open Feliz

let create (name: string) (xs: ReactElement list) =
    name, Html.div [
        prop.style [ style.padding 10 ]
        prop.children xs
    ]