Public Class ScanTemp

    Public Shared activeForm As ScanTemp
    Public Shared result As Decimal

    Dim started As Boolean

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Results.Show()
        Close()
    End Sub

    Private Sub ScanTemp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        activeForm = Me
        UpdateValues(0)

        Timer1.Start()
        Button1.Enabled = False
        Button2.Enabled = False
        started = False
    End Sub

    Public Sub UpdateValues(ByVal n As String)

        TextBox1.Text = n
        result = CDec(n)

        Button2.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If started Then Exit Sub
        Form1.SetMode(4)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not started Then
            started = True
            Button2.Enabled = False
            Button1.Enabled = True
        End If
    End Sub
End Class