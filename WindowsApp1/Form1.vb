Imports CefSharp
Imports CefSharp.WinForms
Public Class Form1
    Private WithEvents browser As ChromiumWebBrowser

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim settings As New CefSettings
        settings.RemoteDebuggingPort = 8088
        CefSharp.Cef.Initialize(settings)
        browser = New ChromiumWebBrowser("http://www.google.com") With {
            .Dock = DockStyle.Fill
        }
        Panel1.Controls.Add(browser)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        browser.Back
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        browser.Load(TextBox1.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        browser.Forward
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        browser.Reload
    End Sub
End Class
