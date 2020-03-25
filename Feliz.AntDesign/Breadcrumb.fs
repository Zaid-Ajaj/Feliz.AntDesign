namespace Feliz.AntDesign 

open Feliz
open Fable.Core
open Fable.Core.JsInterop

[<Erase>]
type breadcrumb = 
    /// The seperator used for the Breadcrumb component. Uses '/' by default.
    static member inline separator (element: string) = Interop.mkAttr "separator" element
    /// The seperator used for the Breadcrumb component. Uses '/' by default.
    static member inline separator (content: ReactElement list) = Interop.mkAttr "separator" (React.fragment content)
    /// The items of the breadcrumb.
    static member inline children (items: IBreadcrumbItem list) = prop.children (unbox<ReactElement list> items)

type breadcrumbItem = 
    static member inline href (link: string) = prop.href link
    static member inline onClick handler = prop.onClick handler
    static member inline overlay (content: ReactElement list) = Interop.mkAttr "overlay" (React.fragment content)
    static member inline text (content: string) = prop.text content