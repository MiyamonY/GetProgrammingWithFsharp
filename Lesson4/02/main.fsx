open System
open System.Net
open System.Windows.Forms

let webClient = new WebClient()
let fsharpOrg = webClient.DownloadString(Uri "http://fsharp.org")

let browser = WebBrowser(ScriptErrorsSupressed=true,Dock = DockStyle.Fill, DocumtnText=fsharpOrg)
let form = Form(Text="Hello from F#")
form.Controls.Add browser
form.Show()

