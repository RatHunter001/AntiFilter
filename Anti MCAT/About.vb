Public Class About
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Load(PHPFunctions.PHP("http://betese.dsf001.site/AntiFilter/about.php", "POST", "Action=GetLogo"))
    End Sub
End Class