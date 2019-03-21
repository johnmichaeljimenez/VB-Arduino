<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PatientNoCheck
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.grp1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbYes = New System.Windows.Forms.RadioButton()
        Me.rbNo = New System.Windows.Forms.RadioButton()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.grp2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPatientNo = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.grp1.SuspendLayout()
        Me.grp2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.grp1)
        Me.FlowLayoutPanel1.Controls.Add(Me.grp2)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(234, 38)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(784, 442)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'grp1
        '
        Me.grp1.AutoSize = True
        Me.grp1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.grp1.Controls.Add(Me.Label1)
        Me.grp1.Controls.Add(Me.rbYes)
        Me.grp1.Controls.Add(Me.rbNo)
        Me.grp1.Controls.Add(Me.btnNext)
        Me.grp1.Location = New System.Drawing.Point(3, 3)
        Me.grp1.Name = "grp1"
        Me.grp1.Size = New System.Drawing.Size(412, 76)
        Me.grp1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.grp1.SetFlowBreak(Me.Label1, True)
        Me.Label1.Font = New System.Drawing.Font("Roboto", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(339, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Do you have an existing Patient No. ?"
        '
        'rbYes
        '
        Me.rbYes.AutoSize = True
        Me.rbYes.Font = New System.Drawing.Font("Roboto", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbYes.ForeColor = System.Drawing.Color.White
        Me.rbYes.Location = New System.Drawing.Point(3, 37)
        Me.rbYes.Name = "rbYes"
        Me.rbYes.Size = New System.Drawing.Size(61, 28)
        Me.rbYes.TabIndex = 1
        Me.rbYes.TabStop = True
        Me.rbYes.Text = "Yes"
        Me.rbYes.UseVisualStyleBackColor = True
        '
        'rbNo
        '
        Me.rbNo.AutoSize = True
        Me.rbNo.Font = New System.Drawing.Font("Roboto", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNo.ForeColor = System.Drawing.Color.White
        Me.rbNo.Location = New System.Drawing.Point(70, 37)
        Me.rbNo.Name = "rbNo"
        Me.rbNo.Size = New System.Drawing.Size(53, 28)
        Me.rbNo.TabIndex = 2
        Me.rbNo.TabStop = True
        Me.rbNo.Text = "No"
        Me.rbNo.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.AutoSize = True
        Me.btnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Font = New System.Drawing.Font("Roboto", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.White
        Me.btnNext.Location = New System.Drawing.Point(129, 37)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 36)
        Me.btnNext.TabIndex = 3
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'grp2
        '
        Me.grp2.AutoSize = True
        Me.grp2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.grp2.Controls.Add(Me.Label2)
        Me.grp2.Controls.Add(Me.txtPatientNo)
        Me.grp2.Controls.Add(Me.btnSubmit)
        Me.grp2.Location = New System.Drawing.Point(3, 85)
        Me.grp2.Name = "grp2"
        Me.grp2.Size = New System.Drawing.Size(380, 76)
        Me.grp2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.grp2.SetFlowBreak(Me.Label2, True)
        Me.Label2.Font = New System.Drawing.Font("Roboto", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(268, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Please enter your Patient No."
        '
        'txtPatientNo
        '
        Me.txtPatientNo.Font = New System.Drawing.Font("Roboto", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientNo.Location = New System.Drawing.Point(3, 37)
        Me.txtPatientNo.MaxLength = 8
        Me.txtPatientNo.Name = "txtPatientNo"
        Me.txtPatientNo.Size = New System.Drawing.Size(100, 28)
        Me.txtPatientNo.TabIndex = 4
        '
        'btnSubmit
        '
        Me.btnSubmit.AutoSize = True
        Me.btnSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Font = New System.Drawing.Font("Roboto", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.Location = New System.Drawing.Point(109, 37)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 36)
        Me.btnSubmit.TabIndex = 3
        Me.btnSubmit.Text = "Next"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Roboto", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(-5, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(795, 79)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Patient Record"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel1.Location = New System.Drawing.Point(2, 186)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(788, 157)
        Me.Panel1.TabIndex = 5
        '
        'PatientNoCheck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(784, 442)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Name = "PatientNoCheck"
        Me.Text = "PatientNoCheck"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.grp1.ResumeLayout(False)
        Me.grp1.PerformLayout()
        Me.grp2.ResumeLayout(False)
        Me.grp2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents grp1 As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents rbYes As RadioButton
    Friend WithEvents rbNo As RadioButton
    Friend WithEvents btnNext As Button
    Friend WithEvents grp2 As FlowLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtPatientNo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
End Class
