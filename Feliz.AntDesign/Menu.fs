namespace Feliz.AntDesign

open Feliz
open Fable.Core
open Fable.Core.JsInterop

type MenuOnSelectProps =
    abstract key : string
    abstract keyPath : string array
    abstract selectedKeys : string array

[<Erase>]
type menu =
    static member inline children (xs: ReactElement list) = prop.custom("children", Array.ofList xs)
    static member inline style (xs: IStyleAttribute list) = prop.style xs
    static member inline defaultOpenKeys (xs: string list) = Interop.mkAttr "defaultOpenKeys" (Array.ofList xs)
    static member inline defaultOpenKeys (xs: string array) = Interop.mkAttr "defaultOpenKeys" xs
    static member inline defaultOpenKeys (xs: int list) = Interop.mkAttr "defaultOpenKeys" (Array.ofList xs)
    static member inline defaultOpenKeys (xs: int array) = Interop.mkAttr "defaultOpenKeys" xs
    static member inline defaultSelectedKeys (xs: string list) = Interop.mkAttr "defaultSelectedKeys" (Array.ofList xs)
    static member inline defaultSelectedKeys (xs: string array) = Interop.mkAttr "defaultSelectedKeys" xs
    static member inline defaultSelectedKeys (xs: int list) = Interop.mkAttr "defaultSelectedKeys" (Array.ofList xs)
    static member inline defaultSelectedKeys (xs: int array) = Interop.mkAttr "defaultSelectedKeys" xs
    static member inline openKeys (xs: string list) = Interop.mkAttr "defaultOpenKeys" (Array.ofList xs)
    static member inline openKeys (xs: string array) = Interop.mkAttr "defaultOpenKeys" xs
    static member inline openKeys (xs: int list) = Interop.mkAttr "defaultOpenKeys" (Array.ofList xs)
    static member inline openKeys (xs: int array) = Interop.mkAttr "defaultOpenKeys" xs
    static member inline selectedKeys (xs: string list) = Interop.mkAttr "defaultSelectedKeys" (Array.ofList xs)
    static member inline selectedKeys (xs: string array) = Interop.mkAttr "defaultSelectedKeys" xs
    static member inline selectedKeys (xs: int list) = Interop.mkAttr "defaultSelectedKeys" (Array.ofList xs)
    static member inline selectedKeys (xs: int array) = Interop.mkAttr "defaultSelectedKeys" xs
    /// Render submenu into DOM before it becomes visible
    static member inline forceSubMenuRender (value: bool) = Interop.mkAttr "forceSubMenuRender" value
    /// Specifies the collapsed status when menu is inline mode
    static member inline inlineCollapsed (value: bool) = Interop.mkAttr "inlineCollapsed" value
    /// Indent (in pixels) of inline menu items on each level. Default is 24
    static member inline inlineIndent (indent: int) = Interop.mkAttr "inlineIndent" indent
    /// Allows selecting menu items
    static member inline selectable (selectable: bool) = Interop.mkAttr "selectable" selectable
    /// Called when a menu item is selected
    static member inline onSelect(handler: MenuOnSelectProps -> unit) = Interop.mkAttr "onSelect" handler

module menu =
    [<Erase>]
    type mode =
        static member inline inline' = Interop.mkAttr "mode" "inline"
        static member inline vertical = Interop.mkAttr "mode" "vertical"
        static member inline horizontal = Interop.mkAttr "mode" "inline"

    [<Erase>]
    type theme =
        static member inline dark = Interop.mkAttr "theme" "dark"
        static member inline light = Interop.mkAttr "theme" "light"


[<Erase>]
type menuItem =
    static member inline children (xs: ReactElement list) = prop.custom("children", Array.ofList xs)
    static member inline style (xs: IStyleAttribute list) = prop.style xs
    static member inline key (key: string) = prop.key key
    static member inline text (content: string) = prop.text content
    static member inline disabled (disabled: bool) = Interop.mkAttr "disabled" disabled
    static member inline title (title: string) = Interop.mkAttr "title" title

type menuItemGroup =
    static member inline key (key: string) = prop.key key
    static member inline title (title: string) = Interop.mkAttr "title" title
    static member inline children (xs: ReactElement list) = prop.custom("children", Array.ofList xs)

[<Erase>]
type subMenu =
    static member inline children (xs: ReactElement list) = prop.custom("children", Array.ofList xs)
    static member inline key (key: string) = prop.key key
    static member inline title (title: string) = Interop.mkAttr "title" title
    static member inline title (xs: ReactElement list) = Interop.mkAttr "title" (React.fragment xs)