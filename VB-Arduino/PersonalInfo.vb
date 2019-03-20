Imports VB_Arduino.Utils

Public Class PersonalInfo

    Public Shared patientNo As String
    Public Shared surname, firstName, middleName, namePrefix As String
    Public Shared birthday, birthplace As String
    Public Shared gender As String
    Public Shared address, city, contactNo As String

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If txtPatientNo.Text = "" Or txtLastName.Text = "" Or txtFirstName.Text = "" Or txtBirthPlace.Text = "" Or txtAddress.Text = "" Or txtCity.Text = "" Then
            MsgBox("Please fill up all required fields (*)")
            Exit Sub
        End If

        patientNo = txtPatientNo.Text
        surname = txtLastName.Text
        firstName = txtFirstName.Text
        middleName = txtMiddleName.Text
        namePrefix = txtNamePrefix.Text
        birthday = dtBirthday.Value.ToShortDateString()
        birthplace = txtBirthPlace.Text
        gender = cmbGender.SelectedItem.ToString()
        address = txtAddress.Text
        city = txtCity.Text
        contactNo = txtContact.Text

        ScanHeight.Show()
        Close()

    End Sub

    Private Sub PersonalInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KillOSK()
        Process.Start("osk")

    End Sub

    Sub KillOSK()
        Dim proc = Process.GetProcessesByName("osk")
        For i As Integer = 0 To proc.Count - 1
            proc(i).Kill()
        Next i
    End Sub

    Private Sub PersonalInfo_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        KillOSK()
    End Sub

    Private Sub PersonalInfo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        KillOSK()
    End Sub
End Class