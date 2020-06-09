Imports Newtonsoft.Json.Linq

Public Class UpdatePackages
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
        If Not (ListBox1.SelectedItem = Nothing) Then
            Try
                client.DownloadString("http://betese.dsf001.site/AntiFilter/Packages/" + ListBox1.SelectedItem)
            Catch ex As Exception
                MsgBox("Could not download. Here's an useless error message: " + ex.Message, vbCritical, "Error")
            End Try
        Else
            MsgBox("bloody hell mate", vbCritical, "o o oa oa")
        End If
    End Sub
End Class