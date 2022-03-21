Public Class Form1
    Private Sub cmdClick_Click(sender As Object, e As EventArgs) Handles cmdClick.Click
        Dim strName As String = txtName.Text
        Dim strResult As String = "Hello " + strName

        lblResult.Text = strResult

    End Sub
End Class
