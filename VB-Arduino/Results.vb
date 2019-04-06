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
        txtPulseRate.Text = ScanPulse.resultSat.ToString() + "(" + ScanPulse.resultBPM.ToString() + "%) - " + GetPulseRemarks()
        txtTemperature.Text = ScanTemp.result.ToString() + " °C (" + GetTemperatureRemarks() + ")"
        CalculateBMI()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PrintExcel(PersonalInfo.patientNo)
        MessageBox.Show("Thank you for using this device. Stay healthy and God Bless.")
        Form1.activeForm.Show()
        Close()
    End Sub

    Public Shared Function GetPulseRemarks() As String
        If ScanPulse.resultSat <= 100 And ScanPulse.resultSat >= 97.1 Then
            Return "Normal"
        ElseIf ScanPulse.resultSat < 97.1 And ScanPulse.resultSat >= 90.1 Then
            Return "Mild Hypoxemia"
        ElseIf ScanPulse.resultSat < 90.1 And ScanPulse.resultSat >= 75.1 Then
            Return "Moderate Hypoxemia"
        ElseIf ScanPulse.resultSat < 75.1 Then
            Return "Severe Hypoxemia"
        End If

        Return ""
    End Function

    Public Shared Function GetTemperatureRemarks() As String
        If ScanTemp.result <= 42.5 And ScanTemp.result >= 39.5 Then
            Return "Very High Fever"
        ElseIf ScanTemp.result <= 39.4 And ScanTemp.result >= 38.6 Then
            Return "High Fever"
        ElseIf ScanTemp.result <= 38.5 And ScanTemp.result >= 38.1 Then
            Return "Moderate Fever"
        ElseIf ScanTemp.result <= 38 And ScanTemp.result >= 37.6 Then
            Return "Light Fever"
        ElseIf ScanTemp.result <= 37.5 And ScanTemp.result >= 37 Then
            Return "Increased Temperature"
        ElseIf ScanTemp.result <= 36.9 And ScanTemp.result >= 35.8 Then
            Return "Normal"
        ElseIf ScanTemp.result < 35.8 Then
            Return "Low Temperature"
        End If

        Return ""
    End Function

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