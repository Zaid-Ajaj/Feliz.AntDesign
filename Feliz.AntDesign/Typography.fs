namespace Feliz.AntDesign

open Feliz
open Fable.Core
open Fable.Core.JsInterop

[<Erase>]
type paragraph =
    static member inline text (content: string) = prop.text content
    static member inline editable (editable: bool) = Interop.mkAttr "editable" editable
    static member inline copyable (copyable: bool) = Interop.mkAttr "copyable" copyable
    static member inline disabled (disabled: bool) = Interop.mkAttr "disabled" disabled
    static member inline ellipsis (ellipsis: bool) = Interop.mkAttr "ellipsis" ellipsis
    static member inline mark (mark: bool) = Interop.mkAttr "mark" mark
    static member inline code (code: bool) = Interop.mkAttr "code" code
    static member inline underline (underline: bool) = Interop.mkAttr "underline" underline
    static member inline delete (delete: bool) = Interop.mkAttr "delete" delete
    static member inline strong (strong: bool) = Interop.mkAttr "strong" strong
    static member inline secondary = Interop.mkAttr "type" "secondary"
    static member inline warning = Interop.mkAttr "type" "warning"
    static member inline danger = Interop.mkAttr "type" "danger"
    static member inline children (xs: ReactElement list) = prop.children xs
    static member inline style (xs: IStyleAttribute list) = prop.style xs

[<Erase>]
type title =
    static member inline text (content: string) = prop.text content
    static member inline level (level: int) = Interop.mkAttr "level" level
    static member inline editable (editable: bool) = Interop.mkAttr "editable" editable
    static member inline copyable (copyable: bool) = Interop.mkAttr "copyable" copyable
    static member inline disabled (disabled: bool) = Interop.mkAttr "disabled" disabled
    static member inline ellipsis (ellipsis: bool) = Interop.mkAttr "ellipsis" ellipsis
    static member inline mark (mark: bool) = Interop.mkAttr "mark" mark
    static member inline code (code: bool) = Interop.mkAttr "code" code
    static member inline underline (underline: bool) = Interop.mkAttr "underline" underline
    static member inline delete (delete: bool) = Interop.mkAttr "delete" delete
    static member inline strong (strong: bool) = Interop.mkAttr "strong" strong
    static member inline secondary = Interop.mkAttr "type" "secondary"
    static member inline warning = Interop.mkAttr "type" "warning"
    static member inline danger = Interop.mkAttr "type" "danger"
    static member inline children (xs: ReactElement list) = prop.children xs
    static member inline style (xs: IStyleAttribute list) = prop.style xs


[<Erase>]
type text =
    static member inline text (content: string) = prop.text content
    static member inline editable (editable: bool) = Interop.mkAttr "editable" editable
    static member inline copyable (copyable: bool) = Interop.mkAttr "copyable" copyable
    static member inline disabled (disabled: bool) = Interop.mkAttr "disabled" disabled
    static member inline ellipsis (ellipsis: bool) = Interop.mkAttr "ellipsis" ellipsis
    static member inline mark (mark: bool) = Interop.mkAttr "mark" mark
    static member inline code (code: bool) = Interop.mkAttr "code" code
    static member inline underline (underline: bool) = Interop.mkAttr "underline" underline
    static member inline delete (delete: bool) = Interop.mkAttr "delete" delete
    static member inline strong (strong: bool) = Interop.mkAttr "strong" strong
    static member inline secondary = Interop.mkAttr "type" "secondary"
    static member inline warning = Interop.mkAttr "type" "warning"
    static member inline danger = Interop.mkAttr "type" "danger"
    static member inline children (xs: ReactElement list) = prop.children xs
    static member inline style (xs: IStyleAttribute list) = prop.style xs

