﻿Public Class PatientNoCheck
    Public Shared existing As Boolean

    Private Sub PatientNoCheck_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Normal
        StartPosition = FormStartPosition.Manual
        Location = Screen.AllScreens(UBound(Screen.AllScreens)).Bounds.Location
        WindowState = FormWindowState.Maximized
        grp1.Visible = True
        grp2.Visible = False
        existing = False
        HideKeyboard()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If rbYes.Checked Then
            grp1.Visible = False
            grp2.Visible = True
            ShowKeyboard()
        Else
            existing = False
            PersonalInfo.patientNo = ""
            HideKeyboard()
            PersonalInfo.Show()
            Close()
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim pn As String = txtPatientNo.Text

        If pn = "" Then
            MessageBox.Show("Please enter your Patient No.")
            Exit Sub
        End If

        If pn.Length < txtPatientNo.MaxLength Then
            MessageBox.Show("Please enter your Patient No.")
            Exit Sub
        End If

        If CheckExcelFile(pn) Then
            PersonalInfo.patientNo = pn
            MessageBox.Show("You can now proceed to sensor readings.")
            'PersonalInfo.Show()
            existing = True
            Utils.ReadData(pn)
            HideKeyboard()
            ScanHeight.Show()
            Close()
            Exit Sub
        End If

        If (MessageBox.Show("Data with Patient No. " + pn + " not found. Do you want to create a new record?", "", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
            PersonalInfo.patientNo = ""
            existing = False
            PersonalInfo.Show()
            'HideKeyboard()
            Close()
        End If


    End Sub

    Private Sub PatientNoCheck_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
    End Sub

    Private Sub FormClosingEvent(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            'Application.Exit()
        End If
    End Sub
End Class