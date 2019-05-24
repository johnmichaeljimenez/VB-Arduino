Imports System.Text.RegularExpressions
Imports VB_Arduino.Utils

Public Class PersonalInfo

    Public Shared patientNo As String
    Public Shared surname, firstName, middleName, namePrefix As String
    Public Shared birthday, birthplace As String
    Public Shared gender As String
    Public Shared address, city, contactNo As String



    Private Sub txtPatientNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPatientNo.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPatientNo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPatientNo.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        txtPatientNo.Text = digitsOnly.Replace(txtPatientNo.Text, "")
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        PatientNoCheck.Show()
        Close()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If txtPatientNo.Text.Length <> 8 Then
            MsgBox("Patient No. should be 8 digits.")
            Exit Sub
        End If

        If txtPatientNo.Text = "" Or txtLastName.Text = "" Or txtFirstName.Text = "" Or txtBirthPlace.Text = "" Or txtAddress.Text = "" Or txtCity.Text = "" Then
            MsgBox("Please fill up all required fields (*)")
            Exit Sub
        End If

        If Utils.CheckExcelFile(txtPatientNo.Text) Then
            MessageBox.Show("The Patient No. you entered is already in use by another patient.")
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
        HideKeyboard()
        ShowKeyboard()
        WindowState = FormWindowState.Normal
        StartPosition = FormStartPosition.Manual
        Location = Screen.AllScreens(UBound(Screen.AllScreens)).Bounds.Location
        WindowState = FormWindowState.Maximized
        'Process.Start("osk")

        cmbGender.SelectedIndex = 0
    End Sub


    Private Sub PersonalInfo_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        HideKeyboard()
    End Sub

    Private Sub FormClosingEvent(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            'Application.Exit()
        End If
    End Sub

    Private Sub TextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContact.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtContact.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        txtContact.Text = digitsOnly.Replace(txtContact.Text, "")
    End Sub
End Class