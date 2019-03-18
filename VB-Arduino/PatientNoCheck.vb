Public Class PatientNoCheck
    Private Sub PatientNoCheck_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grp1.Visible = True
        grp2.Visible = False
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If rbYes.Checked Then
            grp1.Visible = False
            grp2.Visible = True
        Else
            PersonalInfo.patientNo = ""
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
            Utils.ReadData(pn)
            Results.Show()
            Close()
            Exit Sub
        End If

        If (MessageBox.Show("Data with Patient No. " + pn + " not found. Do you want to create a new record?", "", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
            PersonalInfo.patientNo = ""
            PersonalInfo.Show()
            Close()
        End If


    End Sub
End Class