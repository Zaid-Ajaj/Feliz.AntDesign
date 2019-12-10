namespace Feliz.AntDesign

open Feliz
open Fable.Core
open Fable.Core.JsInterop
open Fable.React

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
    static member inline menuIem (properties: IReactProperty list) =
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
