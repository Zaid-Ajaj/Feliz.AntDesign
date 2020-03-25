namespace Feliz.AntDesign

open Feliz
open Fable.Core
open Fable.Core.JsInterop

[<Erase>]
type button =
    static member inline primary = Interop.mkAttr "type" "primary"
    static member inline dashed = Interop.mkAttr "type" "dashed"
    static member inline danger = Interop.mkAttr "type" "danger"
    static member inline link = Interop.mkAttr "type" "link"
    static member inline ghost = Interop.mkAttr "type" "ghost"
    static member inline disabled (disabled: bool) = Interop.mkAttr "disabled" disabled
    static member inline loading(loading: bool) = Interop.mkAttr "loading" loading
    static member inline loading(delay: int) = Interop.mkAttr "loading" (createObj [ "delay" ==> delay ])
    static member inline text (content: string) = prop.text content
    static member inline onClick handler = prop.onClick handler
    static member inline children (xs: ReactElement list) = prop.children xs
    static member inline style (xs: IStyleAttribute list) = prop.style xs
    static member inline icon (elem: ReactElement) = prop.custom("icon", elem)

module button =
    [<Erase>]
    type shape =
        static member inline circle = Interop.mkAttr "shape" "circle"
        static member inline round = Interop.mkAttr "shape" "round"

    [<Erase>]
    type size =
        static member inline small = Interop.mkAttr "size" "small"
        static member inline large = Interop.mkAttr "size" "large"

    [<Erase>]
    type icon =
        static member inline searchOutlined() = prop.custom("icon", AntIcons.searchOutlined [ ])
        static member inline homeOutlined() = prop.custom("icon", AntIcons.homeOutlined [ ])