namespace Feliz.AntDesign

open Feliz
open Fable.Core
open Fable.Core.JsInterop


[<Erase>]
type row =
    static member inline gutter (gutter: int) = Interop.mkAttr "gutter" gutter
    static member inline gutter(?xs: int, ?sm: int, ?md: int, ?lg: int, ?xl: int, ?xxl: int) =
        let gutter = createObj [
            "xs" ==> Option.defaultValue 0 xs
            "sm" ==> Option.defaultValue 0 sm
            "md" ==> Option.defaultValue 0 md
            "lg" ==> Option.defaultValue 0 lg
            "xl" ==> Option.defaultValue 0 xl
            "xxl" ==> Option.defaultValue 0 xxl
        ]
        Interop.mkAttr "gutter" gutter
    static member inline flex = Interop.mkAttr "type" "flex"
    static member inline children (xs: ReactElement list) = prop.children xs
    static member inline style (xs: IStyleAttribute list) = prop.style xs

module row =
    [<Erase>]
    type align =
        static member inline top = Interop.mkAttr "align" "top"
        static member inline middle = Interop.mkAttr "align" "middle"
        static member inline bottom = Interop.mkAttr "align" "bottom"
    
    [<Erase>]
    type justify =
        static member inline startPosition = Interop.mkAttr "justify" "start"
        static member inline endPosition = Interop.mkAttr "justify" "end"
        static member inline center = Interop.mkAttr "justify" "center"
        static member inline spaceAround = Interop.mkAttr "justify" "space-around"
        static member inline spaceBetween = Interop.mkAttr "justify" "space-between"



[<Erase>]
type col =
    static member inline offset (offset: int) = Interop.mkAttr "offset" offset
    static member inline order (order: int) = Interop.mkAttr "order" order
    static member inline pull (pull: int) = Interop.mkAttr "pull" pull
    static member inline push (push: int) = Interop.mkAttr "push" push
    static member inline span (span: int) = Interop.mkAttr "span" span
    static member inline xs (xs: int) = Interop.mkAttr "xs" xs
    static member inline xs(?span: int, ?offset: int) =
        let xs = createObj [
            "span" ==> Option.defaultValue 0 span
            "offset" ==> Option.defaultValue 0 offset
        ]
        Interop.mkAttr "xs" xs
    static member inline sm (sm: int) = Interop.mkAttr "sm" sm
    static member inline sm(?span: int, ?offset: int) =
        let sm = createObj [
            "span" ==> Option.defaultValue 0 span
            "offset" ==> Option.defaultValue 0 offset
        ]
        Interop.mkAttr "sm" sm
    static member inline md (md: int) = Interop.mkAttr "md" md
    static member inline md(?span: int, ?offset: int) =
        let md = createObj [
            "span" ==> Option.defaultValue 0 span
            "offset" ==> Option.defaultValue 0 offset
        ]
        Interop.mkAttr "md" md
    static member inline lg (lg: int) = Interop.mkAttr "lg" lg
    static member inline lg(?span: int, ?offset: int) =
        let lg = createObj [
            "span" ==> Option.defaultValue 0 span
            "offset" ==> Option.defaultValue 0 offset
        ]
        Interop.mkAttr "lg" lg
    static member inline xl (xl: int) = Interop.mkAttr "xl" xl
    static member inline xl(?span: int, ?offset: int) =
        let xl = createObj [
            "span" ==> Option.defaultValue 0 span
            "offset" ==> Option.defaultValue 0 offset
        ]
        Interop.mkAttr "xl" xl
    static member inline xxl (xxl: int) = Interop.mkAttr "xxl" xxl
    static member inline xxl(?span: int, ?offset: int) =
        let xxl = createObj [
            "span" ==> Option.defaultValue 0 span
            "offset" ==> Option.defaultValue 0 offset
        ]
        Interop.mkAttr "xxl" xxl
    static member inline children (xs: ReactElement list) = prop.children xs
    static member inline style (xs: IStyleAttribute list) = prop.style xs
