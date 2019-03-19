Public Class ScanHeight

    Public Shared activeForm As ScanHeight
    Public Shared result As Decimal

    Private Sub ScanHeight_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MessageBox.Show("")
        activeForm = Me
        UpdateValues(0)

        Timer1.Start()
        btnNext.Enabled = False
    End Sub

    Public Sub UpdateValues(ByVal n As String)
        Dim h As Decimal = CDec(n)
        Dim meters, inch As Decimal
        Dim feet As Integer
        Dim feet2 As Decimal
        Dim centimeters As Decimal

        centimeters = h / 10
        meters = h / 1000
        feet2 = (3.280839895 * meters)
        feet = CInt(feet2)
        inch = (feet2 - feet) * 12

        txtFeet.Text = feet.ToString()
        txtInch.Text = inch.ToString("F2")
        txtMeters.Text = centimeters.ToString()

        result = centimeters
        If n > 0 Then
            btnNext.Enabled = True
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Results.Show()
        Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Form1.SetMode(1)
    End Sub
End Class