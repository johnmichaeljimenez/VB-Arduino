<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PersonalInfo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtPatientNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMiddleName = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtNamePrefix = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtBirthday = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtBirthPlace = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label11)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtPatientNo)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtLastName)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label3)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtFirstName)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label4)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtMiddleName)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label12)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtNamePrefix)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label5)
        Me.FlowLayoutPanel1.Controls.Add(Me.dtBirthday)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label13)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtBirthPlace)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label6)
        Me.FlowLayoutPanel1.Controls.Add(Me.cmbGender)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label7)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtAddress)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label8)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtCity)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label9)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtContact)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label10)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnNext)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(12)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(784, 442)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.FlowLayoutPanel1.SetFlowBreak(Me.Label1, True)
        Me.Label1.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 0, 3, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Personal Information"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(15, 42)
        Me.Label11.Margin = New System.Windows.Forms.Padding(3, 0, 15, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 18)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Patient No.*"
        '
        'txtPatientNo
        '
        Me.FlowLayoutPanel1.SetFlowBreak(Me.txtPatientNo, True)
        Me.txtPatientNo.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientNo.Location = New System.Drawing.Point(124, 45)
        Me.txtPatientNo.MaxLength = 8
        Me.txtPatientNo.Name = "txtPatientNo"
        Me.txtPatientNo.Size = New System.Drawing.Size(162, 26)
        Me.txtPatientNo.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 74)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 0, 15, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Last Name*"
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(120, 77)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(162, 26)
        Me.txtLastName.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(288, 74)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3, 0, 15, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "First Name*"
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(394, 77)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(162, 26)
        Me.txtFirstName.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(562, 74)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3, 0, 15, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 18)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Middle Name"
        '
        'txtMiddleName
        '
        Me.txtMiddleName.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiddleName.Location = New System.Drawing.Point(15, 109)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(162, 26)
        Me.txtMiddleName.TabIndex = 6
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(183, 106)
        Me.Label12.Margin = New System.Windows.Forms.Padding(3, 0, 15, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 18)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Prefix"
        '
        'txtNamePrefix
        '
        Me.txtNamePrefix.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamePrefix.Location = New System.Drawing.Point(249, 109)
        Me.txtNamePrefix.Name = "txtNamePrefix"
        Me.txtNamePrefix.Size = New System.Drawing.Size(162, 26)
        Me.txtNamePrefix.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(417, 106)
        Me.Label5.Margin = New System.Windows.Forms.Padding(3, 0, 15, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(180, 18)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Birthday* (MM/DD/YYYY)"
        '
        'dtBirthday
        '
        Me.dtBirthday.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtBirthday.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtBirthday.Location = New System.Drawing.Point(15, 141)
        Me.dtBirthday.MaxDate = New Date(2018, 12, 31, 0, 0, 0, 0)
        Me.dtBirthday.MinDate = New Date(1920, 1, 1, 0, 0, 0, 0)
        Me.dtBirthday.Name = "dtBirthday"
        Me.dtBirthday.Size = New System.Drawing.Size(200, 26)
        Me.dtBirthday.TabIndex = 7
        Me.dtBirthday.Value = New Date(2018, 12, 31, 0, 0, 0, 0)
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(221, 138)
        Me.Label13.Margin = New System.Windows.Forms.Padding(3, 0, 15, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 18)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Birthplace*"
        '
        'txtBirthPlace
        '
        Me.txtBirthPlace.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBirthPlace.Location = New System.Drawing.Point(323, 141)
        Me.txtBirthPlace.Name = "txtBirthPlace"
        Me.txtBirthPlace.Size = New System.Drawing.Size(162, 26)
        Me.txtBirthPlace.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(491, 138)
        Me.Label6.Margin = New System.Windows.Forms.Padding(3, 0, 15, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 18)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Gender*"
        '
        'cmbGender
        '
        Me.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGender.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbGender.Location = New System.Drawing.Point(572, 141)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(121, 26)
        Me.cmbGender.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 170)
        Me.Label7.Margin = New System.Windows.Forms.Padding(3, 0, 15, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 18)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Address*"
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(103, 173)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(162, 26)
        Me.txtAddress.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(271, 170)
        Me.Label8.Margin = New System.Windows.Forms.Padding(3, 0, 15, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(131, 18)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "City/Municipality*"
        '
        'txtCity
        '
        Me.txtCity.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCity.Location = New System.Drawing.Point(420, 173)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(162, 26)
        Me.txtCity.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(588, 170)
        Me.Label9.Margin = New System.Windows.Forms.Padding(3, 0, 15, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 18)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Contact Number"
        '
        'txtContact
        '
        Me.txtContact.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.Location = New System.Drawing.Point(15, 205)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(162, 26)
        Me.txtContact.TabIndex = 16
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(183, 202)
        Me.Label10.Margin = New System.Windows.Forms.Padding(3, 0, 15, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(231, 18)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "*Please fill out all required fields"
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(432, 205)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 17
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'PersonalInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 442)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Name = "PersonalInfo"
        Me.Text = "PersonalInfo"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dtBirthday As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCity As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtContact As TextBox
    Friend WithEvents btnNext As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtPatientNo As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtNamePrefix As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtBirthPlace As TextBox
End Class
