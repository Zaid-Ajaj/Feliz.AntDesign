namespace Feliz.AntDesign

open Feliz
open Fable.Core
open Fable.Core.JsInterop

module internal Interop =
    [<Emit("Object.entries($0)")>]
    let inline objectEntries (x: obj) : (obj * obj) array = jsNative

[<Erase>]
type avatar =
    /// the size of the avatar
    static member inline size(size: int) = Interop.mkAttr "size" size
    /// the address of the image for an image avatar
    static member inline src(source: string) = Interop.mkAttr "src" source
    ///	a list of sources to use for different screen resolutions
    static member inline srcSet(set: string) = Interop.mkAttr "srcSet" set
    /// This attribute defines the alternative text describing the image
    static member inline alt(alt: string) = Interop.mkAttr "alt" alt
    /// handler when img load error, return false to prevent default fallback behavior
    static member inline onError(handler: unit -> bool) = Interop.mkAttr "onError" handler

module avatar =
    [<Erase>]
    /// The shape of avatar
    type shape =
        static member inline round = Interop.mkAttr "shape" "round"
        static member inline square = Interop.mkAttr "shape" "square"

    [<Erase>]
    type size =
        static member inline default' = Interop.mkAttr "size" "default"
        static member inline large = Interop.mkAttr "size" "large"
        static member inline small = Interop.mkAttr "size" "small"

    [<Erase>]
    type icon =
        static member inline search = Interop.mkAttr "icon" "search"
        static member inline minus = Interop.mkAttr "icon" "minus"
        static member inline stepBackward = Interop.mkAttr "icon" "step-backward"
        static member inline stepForward = Interop.mkAttr "icon" "step-forward"
        static member inline fastBackward = Interop.mkAttr "icon" "fast-backward"
        static member inline fastForward = Interop.mkAttr "icon" "fast-forward"
        static member inline shrink = Interop.mkAttr "icon" "shrink"
        static member inline arrowsAlt = Interop.mkAttr "icon" "arrows-alt"
        static member inline down = Interop.mkAttr "icon" "down"
        static member inline up = Interop.mkAttr "icon" "up"
        static member inline left = Interop.mkAttr "icon" "left"
        static member inline right = Interop.mkAttr "icon" "right"
        static member inline caretUp = Interop.mkAttr "icon" "caret-up"
        static member inline caretDown = Interop.mkAttr "icon" "caret-down"
        static member inline caretLeft = Interop.mkAttr "icon" "caret-left"
        static member inline caretRight = Interop.mkAttr "icon" "caret-right"
        static member inline upCircle = Interop.mkAttr "icon" "up-circle"
        static member inline downCircle = Interop.mkAttr "icon" "down-circle"
        static member inline leftCircle = Interop.mkAttr "icon" "left-circle"
        static member inline rightCircle = Interop.mkAttr "icon" "right-circle"
        static member inline doubleRight = Interop.mkAttr "icon" "double-right"
        static member inline doubleLeft = Interop.mkAttr "icon" "double-left"
        static member inline verticalLeft = Interop.mkAttr "icon" "vertical-left"
        static member inline verticalRight = Interop.mkAttr "icon" "vertical-right"
        static member inline verticalAlignTop = Interop.mkAttr "icon" "vertical-align-top"
        static member inline verticalAlignMiddle = Interop.mkAttr "icon" "vertical-align-middle"
        static member inline verticalAlignBottom = Interop.mkAttr "icon" "vertical-align-bottom"
        static member inline forward = Interop.mkAttr "icon" "forward"
        static member inline backward = Interop.mkAttr "icon" "backward"
        static member inline rollback = Interop.mkAttr "icon" "rollback"
        static member inline enter = Interop.mkAttr "icon" "enter"
        static member inline retweet = Interop.mkAttr "icon" "retweet"
        static member inline swap = Interop.mkAttr "icon" "swap"
        static member inline swapLeft = Interop.mkAttr "icon" "swap-left"
        static member inline swapRight = Interop.mkAttr "icon" "swap-right"
        static member inline arrowUp = Interop.mkAttr "icon" "arrow-up"
        static member inline arrowDown = Interop.mkAttr "icon" "arrow-down"
        static member inline arrowLeft = Interop.mkAttr "icon" "arrow-left"
        static member inline arrowRight = Interop.mkAttr "icon" "arrow-right"
        static member inline playCircle = Interop.mkAttr "icon" "play-circle"
        static member inline upSquare = Interop.mkAttr "icon" "up-square"
        static member inline downSquare = Interop.mkAttr "icon" "down-square"
        static member inline leftSquare = Interop.mkAttr "icon" "left-square"
        static member inline rightSquare = Interop.mkAttr "icon" "right-square"
        static member inline login = Interop.mkAttr "icon" "login"
        static member inline logout = Interop.mkAttr "icon" "logout"
        static member inline menuFold = Interop.mkAttr "icon" "menu-fold"
        static member inline menuUnfold = Interop.mkAttr "icon" "menu-unfold"
        static member inline borderBottom = Interop.mkAttr "icon" "border-bottom"
        static member inline borderHorizontal = Interop.mkAttr "icon" "border-horizontal"
        static member inline borderInner = Interop.mkAttr "icon" "border-inner"
        static member inline borderOuter = Interop.mkAttr "icon" "border-outer"
        static member inline borderLeft = Interop.mkAttr "icon" "border-left"
        static member inline borderRight = Interop.mkAttr "icon" "border-right"
        static member inline borderTop = Interop.mkAttr "icon" "border-top"
        static member inline borderVerticle = Interop.mkAttr "icon" "border-verticle"
        static member inline picCenter = Interop.mkAttr "icon" "pic-center"
        static member inline picLeft = Interop.mkAttr "icon" "pic-left"
        static member inline picRight = Interop.mkAttr "icon" "pic-right"
        static member inline radiusBottomleft = Interop.mkAttr "icon" "radius-bottomleft"
        static member inline radiusBottomright = Interop.mkAttr "icon" "radius-bottomright"
        static member inline radiusUpleft = Interop.mkAttr "icon" "radius-upleft"
        static member inline radiusUpright = Interop.mkAttr "icon" "radius-upright"
        static member inline fullscreen = Interop.mkAttr "icon" "fullscreen"
        static member inline fullscreenExit = Interop.mkAttr "icon" "fullscreen-exit"
        static member inline question  = Interop.mkAttr "icon" "question"
        static member inline questionCircle  = Interop.mkAttr "icon" "question-circle"
        static member inline plus  = Interop.mkAttr "icon" "plus"
        static member inline plusCircle  = Interop.mkAttr "icon" "plus-circle"
        static member inline pause  = Interop.mkAttr "icon" "pause"
        static member inline pauseCircle  = Interop.mkAttr "icon" "pause-circle"
        static member inline minusCircle  = Interop.mkAttr "icon" "minus-circle"
        static member inline plusSquare  = Interop.mkAttr "icon" "plus-square"
        static member inline minusSquare  = Interop.mkAttr "icon" "minus-square"
        static member inline info  = Interop.mkAttr "icon" "info"
        static member inline infoCircle  = Interop.mkAttr "icon" "info-circle"
        static member inline exclamation  = Interop.mkAttr "icon" "exclamation"
        static member inline exclamationCircle  = Interop.mkAttr "icon" "exclamation-circle"
        static member inline close  = Interop.mkAttr "icon" "close"
        static member inline closeCircle  = Interop.mkAttr "icon" "close-circle"
        static member inline closeSquare  = Interop.mkAttr "icon" "close-square"
        static member inline check  = Interop.mkAttr "icon" "check"
        static member inline checkCircle  = Interop.mkAttr "icon" "check-circle"
        static member inline checkSquare  = Interop.mkAttr "icon" "check-square"
        static member inline clockCircle  = Interop.mkAttr "icon" "clock-circle"
        static member inline warning  = Interop.mkAttr "icon" "warning"
        static member inline issuesClose  = Interop.mkAttr "icon" "issues-close"
        static member inline stop  = Interop.mkAttr "icon" "stop"
        static member inline edit  = Interop.mkAttr "icon" "edit"
        static member inline form  = Interop.mkAttr "icon" "form"
        static member inline copy  = Interop.mkAttr "icon" "copy"
        static member inline scissor  = Interop.mkAttr "icon" "scissor"
        static member inline delete  = Interop.mkAttr "icon" "delete"
        static member inline snippets  = Interop.mkAttr "icon" "snippets"
        static member inline diff  = Interop.mkAttr "icon" "diff"
        static member inline highlight  = Interop.mkAttr "icon" "highlight"
        static member inline alignCenter  = Interop.mkAttr "icon" "align-center"
        static member inline alignLeft  = Interop.mkAttr "icon" "align-left"
        static member inline alignRight  = Interop.mkAttr "icon" "align-right"
        static member inline bgColors  = Interop.mkAttr "icon" "bg-colors"
        static member inline bold  = Interop.mkAttr "icon" "bold"
        static member inline italic  = Interop.mkAttr "icon" "italic"
        static member inline underline  = Interop.mkAttr "icon" "underline"
        static member inline strikethrough  = Interop.mkAttr "icon" "strikethrough"
        static member inline redo  = Interop.mkAttr "icon" "redo"
        static member inline undo  = Interop.mkAttr "icon" "undo"
        static member inline zoomIn  = Interop.mkAttr "icon" "zoom-in"
        static member inline zoomOut  = Interop.mkAttr "icon" "zoom-out"
        static member inline fontColors  = Interop.mkAttr "icon" "font-colors"
        static member inline fontSize  = Interop.mkAttr "icon" "font-size"
        static member inline lineHeight  = Interop.mkAttr "icon" "line-height"
        static member inline dash  = Interop.mkAttr "icon" "dash"
        static member inline smallDash  = Interop.mkAttr "icon" "small-dash"
        static member inline sortAscending  = Interop.mkAttr "icon" "sort-ascending"
        static member inline sortDescending  = Interop.mkAttr "icon" "sort-descending"
        static member inline drag  = Interop.mkAttr "icon" "drag"
        static member inline orderedList  = Interop.mkAttr "icon" "ordered-list"
        static member inline unorderedList  = Interop.mkAttr "icon" "unordered-list"
        static member inline radiusSetting  = Interop.mkAttr "icon" "radius-setting"
        static member inline columnWidth  = Interop.mkAttr "icon" "column-width"
        static member inline columnHeight  = Interop.mkAttr "icon" "column-height"
        static member inline areaChart  = Interop.mkAttr "icon" "area-chart"
        static member inline pieChart  = Interop.mkAttr "icon" "pie-chart"
        static member inline barChart  = Interop.mkAttr "icon" "bar-chart"
        static member inline dotChart  = Interop.mkAttr "icon" "dot-chart"
        static member inline lineChart  = Interop.mkAttr "icon" "line-chart"
        static member inline radarChart  = Interop.mkAttr "icon" "radar-chart"
        static member inline heatMap  = Interop.mkAttr "icon" "heat-map"
        static member inline fall  = Interop.mkAttr "icon" "fall"
        static member inline rise  = Interop.mkAttr "icon" "rise"
        static member inline stock  = Interop.mkAttr "icon" "stock"
        static member inline boxPlot  = Interop.mkAttr "icon" "box-plot"
        static member inline fund  = Interop.mkAttr "icon" "fund"
        static member inline sliders  = Interop.mkAttr "icon" "sliders"
        static member inline android  = Interop.mkAttr "icon" "android"
        static member inline apple  = Interop.mkAttr "icon" "apple"
        static member inline windows  = Interop.mkAttr "icon" "windows"
        static member inline ie  = Interop.mkAttr "icon" "ie"
        static member inline chrome  = Interop.mkAttr "icon" "chrome"
        static member inline github  = Interop.mkAttr "icon" "github"
        static member inline aliwangwang  = Interop.mkAttr "icon" "aliwangwang"
        static member inline dingding  = Interop.mkAttr "icon" "dingding"
        static member inline weiboSquare  = Interop.mkAttr "icon" "weibo-square"
        static member inline weiboCircle  = Interop.mkAttr "icon" "weibo-circle"
        static member inline taobaoCircle  = Interop.mkAttr "icon" "taobao-circle"
        static member inline html5  = Interop.mkAttr "icon" "html5"
        static member inline weibo  = Interop.mkAttr "icon" "weibo"
        static member inline twitter  = Interop.mkAttr "icon" "twitter"
        static member inline wechat  = Interop.mkAttr "icon" "wechat"
        static member inline youtube  = Interop.mkAttr "icon" "youtube"
        static member inline alipayCircle  = Interop.mkAttr "icon" "alipay-circle"
        static member inline taobao  = Interop.mkAttr "icon" "taobao"
        static member inline skype  = Interop.mkAttr "icon" "skype"
        static member inline qq  = Interop.mkAttr "icon" "qq"
        static member inline mediumWorkmark  = Interop.mkAttr "icon" "medium-workmark"
        static member inline gitlab  = Interop.mkAttr "icon" "gitlab"
        static member inline medium  = Interop.mkAttr "icon" "medium"
        static member inline linkedin  = Interop.mkAttr "icon" "linkedin"
        static member inline googlePlus  = Interop.mkAttr "icon" "google-plus"
        static member inline dropbox  = Interop.mkAttr "icon" "dropbox"
        static member inline facebook  = Interop.mkAttr "icon" "facebook"
        static member inline codepen  = Interop.mkAttr "icon" "codepen"
        static member inline codeSandbox  = Interop.mkAttr "icon" "code-sandbox"
        static member inline amazon  = Interop.mkAttr "icon" "amazon"
        static member inline google  = Interop.mkAttr "icon" "google"
        static member inline codepenCircle  = Interop.mkAttr "icon" "codepen-circle"
        static member inline alipay  = Interop.mkAttr "icon" "alipay"
        static member inline antDesign  = Interop.mkAttr "icon" "ant-design"
        static member inline antCloud  = Interop.mkAttr "icon" "ant-cloud"
        static member inline aliyun  = Interop.mkAttr "icon" "aliyun"
        static member inline zhihu  = Interop.mkAttr "icon" "zhihu"
        static member inline slack  = Interop.mkAttr "icon" "slack"
        static member inline slackSquare  = Interop.mkAttr "icon" "slack-square"
        static member inline behance  = Interop.mkAttr "icon" "behance"
        static member inline behanceSquare  = Interop.mkAttr "icon" "behance-square"
        static member inline dribbble  = Interop.mkAttr "icon" "dribbble"
        static member inline dribbbleSquare  = Interop.mkAttr "icon" "dribbble-square"
        static member inline instagram  = Interop.mkAttr "icon" "instagram"
        static member inline yuque  = Interop.mkAttr "icon" "yuque"
        static member inline alibaba  = Interop.mkAttr "icon" "alibaba"
        static member inline yahoo  = Interop.mkAttr "icon" "yahoo"
        static member inline reddit  = Interop.mkAttr "icon" "reddit"
        static member inline sketch  = Interop.mkAttr "icon" "sketch"
        static member inline accountBook = Interop.mkAttr "icon" "account-book"
        static member inline alert = Interop.mkAttr "icon" "alert"
        static member inline api = Interop.mkAttr "icon" "api"
        static member inline appstore = Interop.mkAttr "icon" "appstore"
        static member inline audio = Interop.mkAttr "icon" "audio"
        static member inline bank = Interop.mkAttr "icon" "bank"
        static member inline bell = Interop.mkAttr "icon" "bell"
        static member inline book = Interop.mkAttr "icon" "book"
        static member inline bug = Interop.mkAttr "icon" "bug"
        static member inline bulb = Interop.mkAttr "icon" "bulb"
        static member inline calculator = Interop.mkAttr "icon" "calculator"
        static member inline build = Interop.mkAttr "icon" "build"
        static member inline calendar = Interop.mkAttr "icon" "calendar"
        static member inline camera = Interop.mkAttr "icon" "camera"
        static member inline car = Interop.mkAttr "icon" "car"
        static member inline carryOut = Interop.mkAttr "icon" "carry-out"
        static member inline cloud = Interop.mkAttr "icon" "cloud"
        static member inline code = Interop.mkAttr "icon" "code"
        static member inline compass = Interop.mkAttr "icon" "compass"
        static member inline contacts = Interop.mkAttr "icon" "contacts"
        static member inline container = Interop.mkAttr "icon" "container"
        static member inline control = Interop.mkAttr "icon" "control"
        static member inline creditCard = Interop.mkAttr "icon" "credit-card"
        static member inline crown = Interop.mkAttr "icon" "crown"
        static member inline customerServ = Interop.mkAttr "icon" "customer-service"
        static member inline dashboard = Interop.mkAttr "icon" "dashboard"
        static member inline database = Interop.mkAttr "icon" "database"
        static member inline dislike = Interop.mkAttr "icon" "dislike"
        static member inline environment = Interop.mkAttr "icon" "environment"
        static member inline experiment = Interop.mkAttr "icon" "experiment"
        static member inline eyeInvisible = Interop.mkAttr "icon" "eye-invisible"
        static member inline eye = Interop.mkAttr "icon" "eye"
        static member inline fileAdd = Interop.mkAttr "icon" "file-add"
        static member inline fileExcel = Interop.mkAttr "icon" "file-excel"
        static member inline fileExclamat = Interop.mkAttr "icon" "file-exclamation"
        static member inline fileImage = Interop.mkAttr "icon" "file-image"
        static member inline fileMarkdown = Interop.mkAttr "icon" "file-markdown"
        static member inline filePdf = Interop.mkAttr "icon" "file-pdf"
        static member inline filePpt = Interop.mkAttr "icon" "file-ppt"
        static member inline fileText = Interop.mkAttr "icon" "file-text"
        static member inline fileUnknown = Interop.mkAttr "icon" "file-unknown"
        static member inline fileWord = Interop.mkAttr "icon" "file-word"
        static member inline fileZip = Interop.mkAttr "icon" "file-zip"
        static member inline file = Interop.mkAttr "icon" "file"
        static member inline filter = Interop.mkAttr "icon" "filter"
        static member inline fire = Interop.mkAttr "icon" "fire"
        static member inline flag = Interop.mkAttr "icon" "flag"
        static member inline folderAdd = Interop.mkAttr "icon" "folder-add"
        static member inline folder = Interop.mkAttr "icon" "folder"
        static member inline folderOpen = Interop.mkAttr "icon" "folder-open"
        static member inline frown = Interop.mkAttr "icon" "frown"
        static member inline funnelPlot = Interop.mkAttr "icon" "funnel-plot"
        static member inline gift = Interop.mkAttr "icon" "gift"
        static member inline hdd = Interop.mkAttr "icon" "hdd"
        static member inline heart = Interop.mkAttr "icon" "heart"
        static member inline home = Interop.mkAttr "icon" "home"
        static member inline hourglass = Interop.mkAttr "icon" "hourglass"
        static member inline idcard = Interop.mkAttr "icon" "idcard"
        static member inline insurance = Interop.mkAttr "icon" "insurance"
        static member inline interaction = Interop.mkAttr "icon" "interaction"
        static member inline layout = Interop.mkAttr "icon" "layout"
        static member inline like = Interop.mkAttr "icon" "like"
        static member inline lock = Interop.mkAttr "icon" "lock"
        static member inline mail = Interop.mkAttr "icon" "mail"
        static member inline medicineBox = Interop.mkAttr "icon" "medicine-box"
        static member inline meh = Interop.mkAttr "icon" "meh"
        static member inline message = Interop.mkAttr "icon" "message"
        static member inline mobile = Interop.mkAttr "icon" "mobile"
        static member inline moneyCollect = Interop.mkAttr "icon" "money-collect"
        static member inline payCircle = Interop.mkAttr "icon" "pay-circle"
        static member inline notification = Interop.mkAttr "icon" "notification"
        static member inline phone = Interop.mkAttr "icon" "phone"
        static member inline picture = Interop.mkAttr "icon" "picture"
        static member inline playSquare = Interop.mkAttr "icon" "play-square"
        static member inline printer = Interop.mkAttr "icon" "printer"
        static member inline profile = Interop.mkAttr "icon" "profile"
        static member inline project = Interop.mkAttr "icon" "project"
        static member inline pushpin = Interop.mkAttr "icon" "pushpin"
        static member inline propertySafety = Interop.mkAttr "icon" "property-safety"
        static member inline read = Interop.mkAttr "icon" "read"
        static member inline reconciliation = Interop.mkAttr "icon" "reconciliation"
        static member inline redEnvelope = Interop.mkAttr "icon" "red-envelope"
        static member inline rest = Interop.mkAttr "icon" "rest"
        static member inline rocket = Interop.mkAttr "icon" "rocket"
        static member inline safetyCertificate = Interop.mkAttr "icon" "safety-certificate"
        static member inline save = Interop.mkAttr "icon" "save"
        static member inline schedule = Interop.mkAttr "icon" "schedule"
        static member inline securityScan = Interop.mkAttr "icon" "security-scan"
        static member inline setting = Interop.mkAttr "icon" "setting"
        static member inline shop = Interop.mkAttr "icon" "shop"
        static member inline shopping = Interop.mkAttr "icon" "shopping"
        static member inline skin = Interop.mkAttr "icon" "skin"
        static member inline smile = Interop.mkAttr "icon" "smile"
        static member inline sound = Interop.mkAttr "icon" "sound"
        static member inline star = Interop.mkAttr "icon" "star"
        static member inline switcher = Interop.mkAttr "icon" "switcher"
        static member inline tablet = Interop.mkAttr "icon" "tablet"
        static member inline tag = Interop.mkAttr "icon" "tag"
        static member inline tags = Interop.mkAttr "icon" "tags"
        static member inline tool = Interop.mkAttr "icon" "tool"
        static member inline thunderbolt = Interop.mkAttr "icon" "thunderbolt"
        static member inline trophy = Interop.mkAttr "icon" "trophy"
        static member inline unlock = Interop.mkAttr "icon" "unlock"
        static member inline usb = Interop.mkAttr "icon" "usb"
        static member inline videoCamera = Interop.mkAttr "icon" "video-camera"
        static member inline wallet = Interop.mkAttr "icon" "wallet"
        static member inline apartment = Interop.mkAttr "icon" "apartment"
        static member inline audit = Interop.mkAttr "icon" "audit"
        static member inline barcode = Interop.mkAttr "icon" "barcode"
        static member inline bars = Interop.mkAttr "icon" "bars"
        static member inline block = Interop.mkAttr "icon" "block"
        static member inline border = Interop.mkAttr "icon" "border"
        static member inline branches = Interop.mkAttr "icon" "branches"
        static member inline ci = Interop.mkAttr "icon" "ci"
        static member inline cloudDownload = Interop.mkAttr "icon" "cloud-download"
        static member inline cloudServer = Interop.mkAttr "icon" "cloud-server"
        static member inline cloudSync = Interop.mkAttr "icon" "cloud-sync"
        static member inline cloudUpload = Interop.mkAttr "icon" "cloud-upload"
        static member inline cluster = Interop.mkAttr "icon" "cluster"
        static member inline coffee = Interop.mkAttr "icon" "coffee"
        static member inline copyright = Interop.mkAttr "icon" "copyright"
        static member inline deploymentUnit = Interop.mkAttr "icon" "deployment-unit"
        static member inline desktop = Interop.mkAttr "icon" "desktop"
        static member inline disconnect = Interop.mkAttr "icon" "disconnect"
        static member inline dollar = Interop.mkAttr "icon" "dollar"
        static member inline download = Interop.mkAttr "icon" "download"
        static member inline ellipsis = Interop.mkAttr "icon" "ellipsis"
        static member inline euro = Interop.mkAttr "icon" "euro"
        static member inline exceptionIcon = Interop.mkAttr "icon" "exception"
        static member inline export = Interop.mkAttr "icon" "export"
        static member inline fileDone = Interop.mkAttr "icon" "file-done"
        static member inline fileJpg = Interop.mkAttr "icon" "file-jpg"
        static member inline fileProtect = Interop.mkAttr "icon" "file-protect"
        static member inline fileSync = Interop.mkAttr "icon" "file-sync"
        static member inline fileSearch = Interop.mkAttr "icon" "file-search"
        static member inline fork = Interop.mkAttr "icon" "fork"
        static member inline gateway = Interop.mkAttr "icon" "gateway"
        static member inline globalIcon = Interop.mkAttr "icon" "global"
        static member inline gold = Interop.mkAttr "icon" "gold"
        static member inline history = Interop.mkAttr "icon" "history"
        static member inline import = Interop.mkAttr "icon" "import"
        static member inline inbox = Interop.mkAttr "icon" "inbox"
        static member inline key = Interop.mkAttr "icon" "key"
        static member inline laptop = Interop.mkAttr "icon" "laptop"
        static member inline link = Interop.mkAttr "icon" "link"
        static member inline line = Interop.mkAttr "icon" "line"
        static member inline loading3Quarters = Interop.mkAttr "icon" "loading-3-quarters"
        static member inline loading = Interop.mkAttr "icon" "loading"
        static member inline man = Interop.mkAttr "icon" "man"
        static member inline menu = Interop.mkAttr "icon" "menu"
        static member inline monitor = Interop.mkAttr "icon" "monitor"
        static member inline more = Interop.mkAttr "icon" "more"
        static member inline number = Interop.mkAttr "icon" "number"
        static member inline percentage = Interop.mkAttr "icon" "percentage"
        static member inline paperClip = Interop.mkAttr "icon" "paper-clip"
        static member inline pound = Interop.mkAttr "icon" "pound"
        static member inline poweroff = Interop.mkAttr "icon" "poweroff"
        static member inline pullRequest = Interop.mkAttr "icon" "pull-request"
        static member inline qrcode = Interop.mkAttr "icon" "qrcode"
        static member inline reload = Interop.mkAttr "icon" "reload"
        static member inline safety = Interop.mkAttr "icon" "safety"
        static member inline robot = Interop.mkAttr "icon" "robot"
        static member inline scan = Interop.mkAttr "icon" "scan"
        static member inline select = Interop.mkAttr "icon" "select"
        static member inline shake = Interop.mkAttr "icon" "shake"
        static member inline shareAlt = Interop.mkAttr "icon" "share-alt"
        static member inline shoppingCart = Interop.mkAttr "icon" "shopping-cart"
        static member inline solution = Interop.mkAttr "icon" "solution"
        static member inline sync = Interop.mkAttr "icon" "sync"
        static member inline table = Interop.mkAttr "icon" "table"
        static member inline team = Interop.mkAttr "icon" "team"
        static member inline toTop = Interop.mkAttr "icon" "to-top"
        static member inline trademark = Interop.mkAttr "icon" "trademark"
        static member inline transaction = Interop.mkAttr "icon" "transaction"
        static member inline upload = Interop.mkAttr "icon" "upload"
        static member inline userAdd = Interop.mkAttr "icon" "user-add"
        static member inline userDelete = Interop.mkAttr "icon" "user-delete"
        static member inline usergroupAdd = Interop.mkAttr "icon" "usergroup-add"
        static member inline user = Interop.mkAttr "icon" "user"
        static member inline usergroupDelete = Interop.mkAttr "icon" "usergroup-delete"
        static member inline wifi = Interop.mkAttr "icon" "wifi"
        static member inline woman = Interop.mkAttr "icon" "woman"

[<Erase>]
type badge =
    static member inline style (styles: IStyleAttribute list) = Interop.mkAttr "style" (createObj !!styles)
    static member inline children (children: ReactElement list) = prop.children children
    static member inline color (color: string) = Interop.mkAttr "color" color
    /// Whether to display a red dot instead of `count`
    static member inline dot (dot: bool) = Interop.mkAttr "dot" dot
    /// Number to show in badge
    static member inline count (count: int) = Interop.mkAttr "count" count
    /// Number to show in badge
    static member inline count (count: ReactElement list) = Interop.mkAttr "count" (React.fragment count)
    /// Whether to show badge when count is zero. Default is `false`.
    static member inline showZero (showZero: bool) = Interop.mkAttr "showZero" showZero
    /// If `status` is set, `text` sets the display text of the status dot
    static member inline text (text: string) = Interop.mkAttr "text" text
    /// Text to show when hovering over the badge
    static member inline title (title: string) = Interop.mkAttr "title" title
    /// Max count to show. Default is 99.
    static member inline overflowCount (count: int) = Interop.mkAttr "overflowCount" count
    /// Offset of the badge dot
    static member inline offset (x: int, y: int) = Interop.mkAttr "offset" (x,y)

[<Erase>]
type comment =
    static member inline style (styles: IStyleAttribute list) = Interop.mkAttr "style" (createObj !!styles)
    /// List of action items rendered below the comment content
    static member inline actions(actions: ReactElement list) = Interop.mkAttr "actions" (Array.ofList actions)
    /// The element to display as the comment author
    static member inline author (author: string) = Interop.mkAttr "author" author
    /// The element to display as the comment author
    static member inline author (author: ReactElement list) = Interop.mkAttr "author" (React.fragment author)
    /// The element to display as the comment avatar - generally an antd Avatar or src
    static member inline avatar (avatar: string) = Interop.mkAttr "avatar" avatar
    /// The element to display as the comment avatar - generally an antd Avatar or src
    static member inline avatar (avatar: ReactElement list) = Interop.mkAttr "avatar" (React.fragment avatar)
    /// The main content of the comment
    static member inline content (avatar: string) = Interop.mkAttr "content" avatar
    /// The main content of the comment
    static member inline content (avatar: ReactElement list) = Interop.mkAttr "content" (React.fragment avatar)
    static member inline datetime (datetime: string) = Interop.mkAttr "datetime" datetime
    static member inline datetime (datetime: ReactElement list) = Interop.mkAttr "datetime" (React.fragment datetime)
    static member inline children (children: ReactElement list) = prop.children children

[<Erase>]
type collapse =
    static member inline style (styles: IStyleAttribute list) = Interop.mkAttr "style" (createObj !!styles)
    /// Key of the active panel
    static member inline activeKey (key: string) = Interop.mkAttr "activeKey" key
    /// Keys of the active panels
    static member inline activeKey (keys: string list) = Interop.mkAttr "activeKey" (Array.ofList keys)
    /// Key of the initial active panel
    static member inline defaultActiveKey (key: string) = Interop.mkAttr "defaultActiveKey" key
    /// Keys of the initial active panels
    static member inline defaultActiveKey (keys: string list) = Interop.mkAttr "defaultActiveKey" (Array.ofList keys)
    /// Toggles rendering of the border around the collapse block.
    static member inline bordered (value: bool) = Interop.mkAttr "bordered" value
    /// If true, Collapse renders as Accordion
    static member inline accordion (value: bool) = Interop.mkAttr "accordion" value
    /// Destroy Inactive Panel
    static member inline destroyInactivePanel (value: bool) = Interop.mkAttr "destroyInactivePanel" value
    /// The panels of the Collapse component
    static member inline panels (panels: ICollapsePanel list) = prop.children (unbox<ReactElement list> panels)
    static member inline onChange (handler: string list -> unit) = Interop.mkAttr "onChange" (List.ofArray >> handler)
    static member inline expandIcon (render: IReactProperty list -> ReactElement) =
        Interop.mkAttr "expandIcon" (fun props -> Interop.objectEntries(props) |> unbox |> List.ofArray |> render)

module collapse =
    [<Erase>]
    type expandIconPosition =
        static member inline left = Interop.mkAttr "expandIconPosition" "left"
        static member inline right = Interop.mkAttr "expandIconPosition" "right"

[<Erase>]
type collapsePanel =
    static member inline style (styles: IStyleAttribute list) = Interop.mkAttr "style" (createObj !!styles)
    /// If true, panel cannot be opened or closed.
    static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
    /// Forced render of content on panel, instead of lazy rending after clicking on header. Default is false
    static member inline forceRender (value: bool) = Interop.mkAttr "forceRender" value
    /// Title of the panel
    static member inline header (content: string) = Interop.mkAttr "header" content
    /// Title of the panel
    static member inline header (content: ReactElement list) = Interop.mkAttr "header" (React.fragment content)
    /// Unique key identifying the panel from among its siblings.
    static member inline key (key: string) = Interop.mkAttr "key" key
    /// If false, panel will not show arrow icon
    static member inline showArrow (value: bool) = Interop.mkAttr "showArrow" value
    /// Extra element in the corner
    static member inline extra (node: ReactElement list) = Interop.mkAttr "extra" (React.fragment node)
    static member inline children (elements: ReactElement list) = prop.children elements
    static member inline text (content: string) = prop.text content

module badge =
    [<Erase>]
    type status =
        static member inline success = Interop.mkAttr "status" "success"
        static member inline processing = Interop.mkAttr "status" "processing"
        static member inline error = Interop.mkAttr "status" "error"
        static member inline warning = Interop.mkAttr "status" "warning"
        static member inline default' = Interop.mkAttr "status" "default"