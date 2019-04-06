Imports VB_Arduino.Utils
Public Class Results
    Public Shared bmiResult As String

    Private Sub Results_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Normal
        StartPosition = FormStartPosition.Manual
        Location = Screen.AllScreens(UBound(Screen.AllScreens)).Bounds.Location
        WindowState = FormWindowState.Maximized
        txtBirthday.Text = PersonalInfo.birthday
        txtBirthplace.Text = PersonalInfo.birthplace
        txtGender.Text = PersonalInfo.gender
        txtName.Text = PersonalInfo.firstName + " " + PersonalInfo.middleName + " " + PersonalInfo.surname + " " + PersonalInfo.namePrefix
        txtHeight.Text = ScanHeight.result.ToString() + " cm"
        txtWeight.Text = (ScanWeight.result.ToString() / 1000).ToString() + " kg"
        txtPulseRate.Text = ScanPulse.resultSat.ToString() + "(" + ScanPulse.resultBPM.ToString() + "%)"
        txtTemperature.Text = ScanTemp.result.ToString() + " °C"
        CalculateBMI()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PrintExcel(PersonalInfo.patientNo)
        MessageBox.Show("Thank you for using this device. Stay healthy and God Bless.")
        Form1.activeForm.Show()
        Close()
    End Sub

    Sub CalculateBMI()
        Dim kg, m As Decimal
        kg = ScanWeight.result / 1000
        m = ScanHeight.result / 100

        Dim bmi As Decimal = (kg) / (m ^ 2)
        txtBMI.Text = bmi.ToString("F1")

        Dim remarks As String = ""

        If bmi < 18.5 Then
            remarks = "Underweight"
        ElseIf bmi >= 18.5 And bmi <= 24.9 Then
            remarks = "Normal Weight"
        ElseIf bmi >= 25 And bmi <= 29.9 Then
            remarks = "Overweight"
        ElseIf bmi > 30 Then
            remarks = "Obesity"
        End If

        txtBMI.Text += " (" + remarks + ")"
        bmiResult = txtBMI.Text

    End Sub

    Private Sub FormClosingEvent(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            'Application.Exit()
        End If
    End Sub
End Class