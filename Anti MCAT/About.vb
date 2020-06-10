Public Class About
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            PictureBox1.Load("http://betese.dsf001.site/AntiFilter/Logo.php")
        Catch ex As Exception
            Console.WriteLine("Could not load image.")
        End Try
        Try
            RichTextBox1.Text = PHPFunctions.PHP("http://betese.dsf001.site/AntiFilter/about.php", "POST", "Action=GetCredits")
        Catch ex As Exception
            RichTextBox1.Text = "Could not load credits."
        End Try
    End Sub
End Class