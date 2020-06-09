
Imports Newtonsoft.Json.Linq

Public Class Form1
    Private aa As String
    Private b As String
    Private c As String
    Private d As String
    Private ee As String
    Private f As String
    Private g As String
    Private h As String
    Private i As String
    Private j As String
    Private k As String
    Private l As String
    Private m As String
    Private n As String
    Private o As String
    Private p As String
    Private r As String
    Private s As String
    Private t As String
    Private u As String
    Private v As String
    Private y As String
    Private z As String

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.SelectedIndex = 1 Then
            Me.aa = "α"
            Me.b = "б"
            Me.c = "ƈ"
            Me.d = "Ð"
            Me.ee = "ё"
            Me.f = "ƒ"
            Me.g = "ğ"
            Me.h = "ɧ"
            Me.i = "į"
            Me.j = "J"
            Me.k = "ĸ"
            Me.l = "ʟ"
            Me.m = "ṁ"
            Me.n = "л"
            Me.o = "ö"
            Me.p = "ρ"
            Me.r = "ṙ"
            Me.s = "š"
            Me.t = "т"
            Me.u = "ü"
            Me.v = "ᴠ"
            Me.y = "Ý"
            Me.z = "ᴢ"
        ElseIf ComboBox1.SelectedIndex = 0 Then
            Me.aa = "Ä"
            Me.b = "ß"
            Me.c = "ƈ"
            Me.d = "Ð"
            Me.ee = "є"
            Me.f = "ƒ"
            Me.g = "Ğ"
            Me.h = "ɧ"
            Me.i = "į"
            Me.j = "J"
            Me.k = "ĸ"
            Me.l = "ʟ"
            Me.m = "ᴹ"
            Me.n = "Ѝ"
            Me.o = "Ő"
            Me.p = "ρ"
            Me.r = "Ṝ"
            Me.s = "Ƨ"
            Me.t = "Ƚ"
            Me.u = "ü"
            Me.v = "ᴠ"
            Me.y = "Ý"
            Me.z = "ᴢ"
        Else
            MsgBox("aa")
        End If

        Try
            Me.RichTextBox2.Text = Me.RichTextBox1.Text
            Me.RichTextBox2.Text = Me.RichTextBox2.Text.Replace("A", Me.aa)
            Me.RichTextBox2.Text = Me.RichTextBox2.Text.Replace("a", Me.aa)
            Me.RichTextBox2.Text = Me.RichTextBox2.Text.Replace("B", Me.b)
            Me.RichTextBox2.Text = Me.RichTextBox2.Text.Replace("b", Me.b)
            Me.RichTextBox2.Text = Me.RichTextBox2.Text.Replace("C", Me.c)
            Me.RichTextBox2.Text = Me.RichTextBox2.Text.Replace("c", Me.c)
            Me.RichTextBox2.Text = Me.RichTextBox2.Text.Replace("D", Me.d)
            Me.RichTextBox2.Text = Me.RichTextBox2.Text.Replace("d", Me.d)
            Me.RichTextBox2.Text = Me.RichTextBox2.Text.Replace("E", Me.ee)
            Me.RichTextBox2.Text = Me.RichTextBox2.Text.Replace("e", Me.ee)
            Me.RichTextBox2.Text = Me.RichTextBox2.Text.Replace("F", Me.f)
            Me.RichTextBox2.Text = Me.RichTextBox2.Text.Replace("f", Me.f)
            Me.RichTextBox2.Text = Me.RichTextBox2.Text.Replace("G", Me.g)
            Me.RichTextBox2.Text = Me.RichTextBox2.Text.Replace("g", Me.g)
            Me.RichTextBox2.Text = Me.RichTextBox2.Text.Replace("H", Me.h)
            Me.RichTextBox2.Text = Me.RichTextBox2.Text.Replace("h", Me.h)
            Me.RichTextBox2.Text = Me.RichTextBox2.Text.Replace("İ", Me.i)
            Me.RichTextBox2.Text = Me.RichTextBox2.Text.Replace("i", Me.i)
            Me.RichTextBox2.Text = Me.RichTextBox2.Text.Replace("J", Me.j)
            Me.RichTextBox2.Text = Me.RichTextBox2.Text.Replace("j", Me.j)
            Me.RichTextBox2.Text = Me.RichTextBox2.Text.Replace("K", Me.k)
            Me.RichTextBox2.Text = Me.RichTextBox2.Text.Replace("k", Me.k)
            Me.RichTextBox2.Text = Me.RichTextBox2.Text.Replace("L", Me.l)
            Me.RichTextBox2.Text = Me.RichTextBox2.Text.Replace("l", Me.l)
            Me.RichTextBox2.Text = Me.RichTextBox2.Text.Replace("M", Me.m)
            Me.RichTextBox2.Text = Me.RichTextBox2.Text.Replace("m", Me.m)
            Me.RichTextBox2.Text = Me.RichTextBox2.Text.Replace("N", Me.n)
            Me.RichTextBox2.Text = Me.RichTextBox2.Text.Replace("n", Me.n)
            Me.RichTextBox2.Text = Me.RichTextBox2.Text.Replace("O", Me.o)
            Me.RichTextBox2.Text = Me.RichTextBox2.Text.Replace("o", Me.o)
            Me.RichTextBox2.Text = Me.RichTextBox2.Text.Replace("P", Me.p)
            Me.RichTextBox2.Text = Me.RichTextBox2.Text.Replace("p", Me.p)
            Me.RichTextBox2.Text = Me.RichTextBox2.Text.Replace("R", Me.r)
            Me.RichTextBox2.Text = Me.RichTextBox2.Text.Replace("r", Me.r)
            Me.RichTextBox2.Text = Me.RichTextBox2.Text.Replace("S", Me.s)
            Me.RichTextBox2.Text = Me.RichTextBox2.Text.Replace("s", Me.s)
            Me.RichTextBox2.Text = Me.RichTextBox2.Text.Replace("T", Me.t)
            Me.RichTextBox2.Text = Me.RichTextBox2.Text.Replace("t", Me.t)
            Me.RichTextBox2.Text = Me.RichTextBox2.Text.Replace("U", Me.u)
            Me.RichTextBox2.Text = Me.RichTextBox2.Text.Replace("u", Me.u)
            Me.RichTextBox2.Text = Me.RichTextBox2.Text.Replace("V", Me.v)
            Me.RichTextBox2.Text = Me.RichTextBox2.Text.Replace("v", Me.v)
            Me.RichTextBox2.Text = Me.RichTextBox2.Text.Replace("Y", Me.y)
            Me.RichTextBox2.Text = Me.RichTextBox2.Text.Replace("y", Me.y)
            Me.RichTextBox2.Text = Me.RichTextBox2.Text.Replace("Z", Me.z)
            Me.RichTextBox2.Text = Me.RichTextBox2.Text.Replace("z", Me.z)
        Catch exception As System.Exception
            MessageBox.Show(exception.Message)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = My.Settings.abbas
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        My.Settings.abbas = ComboBox1.SelectedIndex
        My.Settings.Save()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Clipboard.SetText(RichTextBox2.Text)
        Catch ex As Exception
            MsgBox("Write something you idiot")
        End Try

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://discord.gg/v4gugsP")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        UpdatePackages.Show()


    End Sub
End Class
