namespace Feliz.AntDesign

open Feliz
open Fable.Core
open Fable.Core.JsInterop
open Fable.React

type ICollapsePanel = interface end

[<Erase>]
type Ant =
    static member inline button (children: #seq<ReactElement>) =
        ofImport "Button" "antd" children
    static member inline button (properties: IReactProperty list) =
        Interop.reactApi.createElement(import "Button" "antd", createObj !!properties)
    static member inline layout (children: #seq<ReactElement>) =
        ofImport "Layout" "antd" [] children
    static member inline header (children: #seq<ReactElement>) =
        ofImport "Layout.Header" "antd" [] children
    static member inline footer (children: #seq<ReactElement>) =
        ofImport "Layout.Footer" "antd" [] children
    static member inline sider (children: #seq<ReactElement>) =
        ofImport "Layout.Sider" "antd" [ ] children
    static member inline sider (properties: IReactProperty list) =
        Interop.reactApi.createElement(import "Layout.Sider" "antd",  createObj !!properties)
    static member inline content (children: #seq<ReactElement>) =
        ofImport "Layout.Content" "antd" [ ] children
    static member inline content (properties: IReactProperty list) =
        Interop.reactApi.createElement(import "Layout.Content" "antd", createObj !!properties)
    static member inline menuItemGroup (children: #seq<ReactElement>) =
        ofImport "Menu.ItemGroup" "antd" [ ] children
    static member inline menuItemGroup (properties: IReactProperty list) =
        Interop.reactApi.createElement(import "Menu.ItemGroup" "antd", createObj !!properties)
    static member inline menu (children: #seq<ReactElement>) =
        ofImport "Menu" "antd" children
    static member inline menu (properties: IReactProperty list) =
        Interop.reactApi.createElement(import "Menu" "antd", createObj !!properties)
    static member inline spin (children: #seq<ReactElement>) =
        ofImport "Spin" "antd" children
    static member inline spin (properties: IReactProperty list) =
        Interop.reactApi.createElement(import "Spin" "antd", createObj !!properties)
    static member inline menuItem (properties: IReactProperty list) =
        Interop.reactApi.createElement(import "Menu.Item" "antd", createObj !!properties)
    static member inline subMenu (properties: IReactProperty list) =
        Interop.reactApi.createElement(import "Menu.SubMenu" "antd", createObj !!properties)
    static member inline icon (children: #seq<ReactElement>) =
        ofImport "Icon" "antd" children
    static member inline icon (properties: IReactProperty list) =
        Interop.reactApi.createElement(import "Icon" "antd", createObj !!properties)
    static member inline text (children: #seq<ReactElement>) =
        ofImport "Typography.Text" "antd" [ ] children
    static member inline text (properties: IReactProperty list) =
        Interop.reactApi.createElement(import "Typography.Text" "antd", createObj !!properties)
    static member inline title (children: #seq<ReactElement>) =
        ofImport "Typography.Title" "antd" [ ] children
    static member inline title (properties: IReactProperty list) =
        Interop.reactApi.createElement(import "Typography.Title" "antd", createObj !!properties)
    static member inline paragraph (children: #seq<ReactElement>) =
        ofImport "Typography.Paragraph" "antd" [ ] children
    static member inline paragraph (properties: IReactProperty list) =
        Interop.reactApi.createElement(import "Typography.Paragraph" "antd", createObj !!properties)
    static member inline row (children: #seq<ReactElement>) =
        ofImport "Row" "antd" [ ] children
    static member inline row (properties: IReactProperty list) =
        Interop.reactApi.createElement(import "Row" "antd", createObj !!properties)
    static member inline col (children: #seq<ReactElement>) =
        ofImport "Col" "antd" [ ] children
    static member inline col (properties: IReactProperty list) =
        Interop.reactApi.createElement(import "Col" "antd", createObj !!properties)
    static member inline avatar (properties: IReactProperty list) =
        Interop.reactApi.createElement(import "Avatar" "antd", createObj !!properties)
    static member inline avatar (children: #seq<ReactElement>) =
        ofImport "Avatar" "antd" [ ] children
    static member inline badge (properties: IReactProperty list) =
        Interop.reactApi.createElement(import "Badge" "antd", createObj !!properties)
    static member inline comment (properties: IReactProperty list) =
        Interop.reactApi.createElement(import "Comment" "antd", createObj !!properties)
    static member inline badge (children: #seq<ReactElement>) =
        ofImport "Badge" "antd" [ ] children
    static member inline collapse (panels: ICollapsePanel list) =
        ofImport "Collapse" "antd" [ ] (unbox panels)
    static member inline collapse (properties: #seq<IReactProperty>) =
        Interop.reactApi.createElement(import "Collapse" "antd", createObj !!properties)
    static member inline collapsePanel (children: ReactElement list) =
        ofImport "Collapse.Panel" "antd" [ ] children
        |> unbox<ICollapsePanel>
    static member inline collapsePanel (properties: #seq<IReactProperty>) =
        Interop.reactApi.createElement(import "Collapse.Panel" "antd", createObj !!properties)
        |> unbox<ICollapsePanel>