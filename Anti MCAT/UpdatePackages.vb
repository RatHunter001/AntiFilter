Imports Newtonsoft.Json.Linq
Imports System.Text.Encoding
Imports System.IO
Imports System.Text
Public Class UpdatePackages
    Dim CurrentFolder = System.IO.Path.GetDirectoryName(Application.ExecutablePath)
    Dim selectedpackage
    Private Sub UpdatePackages_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim FileCount As Integer = Integer.Parse(PHPFunctions.PHP("http://betese.dsf001.site/AntiFilter/AntiFilter.php", "POST", "Action=CountFiles"))
        Dim AllPackages As String = (PHPFunctions.PHP("http://betese.dsf001.site/AntiFilter/AntiFilter.php", "POST", "Action=DownloadPackages"))
        Dim AllPackagesList As New List(Of String)
        Dim myJObject = JObject.Parse(AllPackages)
        For x As Integer = 0 To (FileCount + 10)
            Try
                AllPackagesList.Add(myJObject.SelectToken(x.ToString()))
                ListBox1.Items.Add(myJObject.SelectToken(x.ToString()))
            Catch ex As Exception
            End Try
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim client As New Net.WebClient
        client.Encoding = UTF8
        If Not (ListBox1.SelectedItem = Nothing) Then
            Try
                FastColoredTextBox1.Text = client.DownloadString("http://betese.dsf001.site/AntiFilter/Packages/" + ListBox1.SelectedItem)
                selectedpackage = ListBox1.SelectedItem
            Catch ex As Exception
                MsgBox("Could not download. Here's an useless error message: " + ex.Message, vbCritical, "Error")
            End Try
        Else
            MsgBox("bloody hell mate", vbCritical, "o o oa oa")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox(CurrentFolder)
        My.Computer.FileSystem.CreateDirectory(CurrentFolder + "\AntiFilterPackages")
        Dim AntiFilterPackagesFolder = CurrentFolder + "\AntiFilterPackages"

        Dim fs As FileStream = File.Create(AntiFilterPackagesFolder)

        ' Add text to the file.
        Dim info As Byte() = New UTF8Encoding(True).GetBytes(FastColoredTextBox1.Text)
        fs.Write(info, 0, info.Length)
        fs.Close()
    End Sub
End Class