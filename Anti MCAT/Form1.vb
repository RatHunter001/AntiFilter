
Imports System.IO
Imports Newtonsoft.Json.Linq

Public Class Form1
    Dim CurrentFolder = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\AntiFilterPackages"
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
    Private Sub TranslateText()
        Try
            Dim currentpackage = CurrentFolder + "\" + ComboBox1.SelectedItem
            Dim myJObject = JObject.Parse(My.Computer.FileSystem.ReadAllText(currentpackage))
            Me.aa = myJObject.SelectToken("letter_a")
            Me.b = myJObject.SelectToken("letter_b")
            Me.c = myJObject.SelectToken("letter_c")
            Me.d = myJObject.SelectToken("letter_d")
            Me.ee = myJObject.SelectToken("letter_e")
            Me.f = myJObject.SelectToken("letter_f")
            Me.g = myJObject.SelectToken("letter_g")
            Me.h = myJObject.SelectToken("letter_h")
            Me.i = myJObject.SelectToken("letter_i")
            Me.j = myJObject.SelectToken("letter_j")
            Me.k = myJObject.SelectToken("letter_k")
            Me.l = myJObject.SelectToken("letter_l")
            Me.m = myJObject.SelectToken("letter_m")
            Me.n = myJObject.SelectToken("letter_n")
            Me.o = myJObject.SelectToken("letter_o")
            Me.p = myJObject.SelectToken("letter_p")
            Me.r = myJObject.SelectToken("letter_r")
            Me.s = myJObject.SelectToken("letter_s")
            Me.t = myJObject.SelectToken("letter_t")
            Me.u = myJObject.SelectToken("letter_u")
            Me.v = myJObject.SelectToken("letter_v")
            Me.y = myJObject.SelectToken("letter_y")
            Me.z = myJObject.SelectToken("letter_z")
        Catch ex As Exception

        End Try

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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TranslateText()
    End Sub
    Public Sub Scan()
        Try
            Dim ScanFolder As String()
            ScanFolder = Directory.GetFiles(CurrentFolder, ".", SearchOption.AllDirectories.GetHashCode)
            For Each dFile As String In ScanFolder
                If dFile.Contains(".json") Then
                    ComboBox1.Items.Add(System.IO.Path.GetFileName(dFile))
                Else
                End If

            Next
            Try
                ComboBox1.SelectedIndex = My.Settings.abbas
            Catch ex As Exception
            End Try
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            PHPFunctions.PHP("http://betese.dsf001.site/AntiFilter/AntiFilter.php", "POST", "Action=DownloadPackages")
        Catch ex As Exception

        End Try
        Scan()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        My.Settings.abbas = ComboBox1.SelectedIndex
        My.Settings.Save()
        TranslateText()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Clipboard.SetText(RichTextBox2.Text)
        Catch ex As Exception
            MsgBox("Write something betese", vbCritical, "Error")
        End Try

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://discord.gg/v4gugsP")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        UpdatePackages.Show()


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ComboBox1.Items.Clear()
        Scan()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        About.Show()
    End Sub
End Class
