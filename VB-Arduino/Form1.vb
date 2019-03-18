Public Class Form1

    Public Shared activeForm As Form

    Private Sub FlowLayoutPanel1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        PatientNoCheck.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        activeForm = Me
    End Sub
End Class
