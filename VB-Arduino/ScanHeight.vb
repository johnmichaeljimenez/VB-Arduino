Public Class ScanHeight

    Public Shared activeForm As ScanHeight

    Private Sub ScanHeight_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MessageBox.Show("")
        activeForm = Me
        UpdateValues(0)



        Form1.SetMode(1)
    End Sub

    Public Sub UpdateValues(ByVal n As String)
        Dim h As Decimal = CDec(n)
        Dim meters, inch As Decimal
        Dim feet As Integer
        Dim feet2 As Decimal

        meters = h / 1000
        feet2 = (3.280839895 * meters)
        feet = CInt(feet2)
        inch = (feet2 - feet) * 12

        txtFeet.Text = feet.ToString()
        txtInch.Text = inch.ToString()
        txtMeters.Text = meters.ToString()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

    End Sub
End Class