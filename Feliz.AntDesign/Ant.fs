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
    static member inline layoutHeader (children: #seq<ReactElement>) =
        ofImport "Layout.Header" "antd" [] children
    static member inline layoutFooter (children: #seq<ReactElement>) =
        ofImport "Layout.Footer" "antd" [] children
    static member inline layoutSider (children: #seq<ReactElement>) =
        ofImport "Layout.Sider" "antd" [ ] children
    static member inline layoutContent (children: #seq<ReactElement>) =
        ofImport "Layout.Content" "antd" [ ] children
    static member inline layoutContent (properties: IReactProperty list) =
        Interop.reactApi.createElement(import "Layout.Content" "antd", createObj !!properties)
    static member inline menu (children: #seq<ReactElement>) =
        ofImport "Menu" "antd" children
    static member inline menu (properties: IReactProperty list) =
        Interop.reactApi.createElement(import "Menu" "antd", createObj !!properties)
    static member inline menuIem (properties: IReactProperty list) =
        Interop.reactApi.createElement(import "Menu.Item" "antd", createObj !!properties)
    static member inline subMenu (properties: IReactProperty list) =
        Interop.reactApi.createElement(import "Menu.SubMenu" "antd", createObj !!properties)