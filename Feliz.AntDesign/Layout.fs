namespace Feliz.AntDesign

open Feliz
open Fable.Core
open Fable.Core.JsInterop

[<Erase>]
type layout =
    static member inline children (xs: ReactElement list) = prop.children xs
    static member inline style (xs: IStyleAttribute list) = prop.style xs

[<Erase>]
type sider =
    static member inline children (xs: ReactElement list) = prop.children xs
    static member inline style (xs: IStyleAttribute list) = prop.style xs

[<Erase>]
type content =
    static member inline children (xs: ReactElement list) = prop.children xs
    static member inline style (xs: IStyleAttribute list) = prop.style xs