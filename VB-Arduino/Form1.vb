Public Class Form1

    Public Shared activeForm As Form

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        activeForm = Me
    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        Me.Hide()
        PatientNoCheck.Show()
    End Sub
End Class
