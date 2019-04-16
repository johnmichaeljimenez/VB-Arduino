Public Class ScanWeight

    Public Shared activeForm As ScanWeight
    Public Shared result As Decimal

    Dim count As Integer

    Private Sub ScanWeight_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        count = 10
        txtTimer.Text = count.ToString()
        WindowState = FormWindowState.Normal
        StartPosition = FormStartPosition.Manual
        Location = Screen.AllScreens(UBound(Screen.AllScreens)).Bounds.Location
        WindowState = FormWindowState.Maximized
        activeForm = Me
        UpdateValues(0)

        Timer1.Start()
        Button1.Enabled = False
    End Sub


    Public Sub UpdateValues(ByVal n As String)
        Dim grams As Decimal = CDec(n)
        Dim pounds As Decimal = grams * 0.00220462

        result = grams

        TextBox1.Text = pounds.ToString("F4")
        TextBox2.Text = (grams / 1000).ToString("F4")

        If n > 0 Then
            Form1.SetMode(0)
            Button1.Enabled = True
            Timer1.Stop()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ScanPulse.Show()
        Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If count = 0 Then
            Form1.SetMode(2)
            Exit Sub
        End If

        count -= 1
        txtTimer.Text = count.ToString()
        'Form1.SetMode(2)
    End Sub
    Private Sub FormClosingEvent(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            'Application.Exit()
        End If
    End Sub
End Class