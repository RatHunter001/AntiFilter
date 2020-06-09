Imports System.Net
Imports Newtonsoft.Json.Linq
Imports System.IO
Imports System.Text
Module PHPFunctions
    Public Function PHP(ByVal url As String, ByVal method As String, ByVal data As String)
        Try

            Dim request As System.Net.WebRequest = System.Net.WebRequest.Create(url)
            request.Method = method
            Dim postData = data
            Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
            request.ContentType = "application/x-www-form-urlencoded"
            request.ContentLength = byteArray.Length
            Dim dataStream As Stream = request.GetRequestStream()
            dataStream.Write(byteArray, 0, byteArray.Length)
            dataStream.Close()
            Dim response As WebResponse = request.GetResponse()
            dataStream = response.GetResponseStream()
            Dim reader As New StreamReader(dataStream)
            Dim responseFromServer As String = reader.ReadToEnd()
            reader.Close()
            dataStream.Close()
            response.Close()
            Return (responseFromServer)
        Catch ex As Exception
            Dim error1 As String = ErrorToString()
            If error1 = "Invalid URI: The format of the URI could not be determined." Then
                MsgBox("ERROR! Must have HTTP:// before the URL.")
            Else
                MsgBox(error1)
            End If
            Return ("ERROR")
        End Try
    End Function
End Module
