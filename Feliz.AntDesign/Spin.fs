namespace Feliz.AntDesign

open Feliz
open Fable.Core

[<Erase>]
type spin =
    /// whether Spin is spinning
    static member inline spinning (spinning: bool) = Interop.mkAttr "spinning" spinning
    /// customize description content when Spin has children
    static member inline tip (content: string) = Interop.mkAttr "tip" content
    /// React node of the spinning indicator
    static member inline indicator (indicator: ReactElement list) = Interop.mkAttr "indicator" (React.fragment indicator)
    /// specifies a delay in milliseconds for loading state (prevent flush)
    static member inline delay (delay: int) = Interop.mkAttr "delay" delay
    static member inline children (xs: ReactElement list) = prop.children xs

module spin =
    /// size of Spin
    [<Erase>]
    type size =
        static member inline small = Interop.mkAttr "size" "small"
        static member inline default' = Interop.mkAttr "size" "default"
        static member inline large = Interop.mkAttr "size" "large"
