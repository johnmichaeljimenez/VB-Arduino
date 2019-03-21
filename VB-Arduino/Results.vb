Imports VB_Arduino.Utils
Public Class Results
    Private Sub Results_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtBirthday.Text = PersonalInfo.birthday
        txtBirthplace.Text = PersonalInfo.birthplace
        txtGender.Text = PersonalInfo.gender
        txtName.Text = PersonalInfo.firstName + " " + PersonalInfo.middleName + " " + PersonalInfo.surname + " " + PersonalInfo.namePrefix
        txtHeight.Text = ScanHeight.result.ToString() + " cm"
        txtPulseRate.Text = ScanPulse.resultBPM.ToString() + "(" + ScanPulse.resultSat.ToString() + "%)"
        txtTemperature.Text = ScanTemp.result.ToString() + " °"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PrintExcel(PersonalInfo.patientNo)
        MessageBox.Show("Thank you for using this device. Stay healthy and God Bless.")
        Form1.activeForm.Show()
        Close()
    End Sub
End Class