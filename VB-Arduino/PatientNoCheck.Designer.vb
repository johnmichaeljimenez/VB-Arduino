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
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.grp1.SuspendLayout()
        Me.grp2.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.grp1)
        Me.FlowLayoutPanel1.Controls.Add(Me.grp2)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
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
        Me.grp1.Size = New System.Drawing.Size(241, 52)
        Me.grp1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.grp1.SetFlowBreak(Me.Label1, True)
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Do you have an existing Patient No. ?"
        '
        'rbYes
        '
        Me.rbYes.AutoSize = True
        Me.rbYes.Location = New System.Drawing.Point(3, 26)
        Me.rbYes.Name = "rbYes"
        Me.rbYes.Size = New System.Drawing.Size(43, 17)
        Me.rbYes.TabIndex = 1
        Me.rbYes.TabStop = True
        Me.rbYes.Text = "Yes"
        Me.rbYes.UseVisualStyleBackColor = True
        '
        'rbNo
        '
        Me.rbNo.AutoSize = True
        Me.rbNo.Location = New System.Drawing.Point(52, 26)
        Me.rbNo.Name = "rbNo"
        Me.rbNo.Size = New System.Drawing.Size(39, 17)
        Me.rbNo.TabIndex = 2
        Me.rbNo.TabStop = True
        Me.rbNo.Text = "No"
        Me.rbNo.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(97, 26)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 3
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'grp2
        '
        Me.grp2.AutoSize = True
        Me.grp2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.grp2.Controls.Add(Me.Label2)
        Me.grp2.Controls.Add(Me.txtPatientNo)
        Me.grp2.Controls.Add(Me.btnSubmit)
        Me.grp2.Location = New System.Drawing.Point(250, 3)
        Me.grp2.Name = "grp2"
        Me.grp2.Size = New System.Drawing.Size(257, 55)
        Me.grp2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.grp2.SetFlowBreak(Me.Label2, True)
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Please enter your Patient No."
        '
        'txtPatientNo
        '
        Me.txtPatientNo.Location = New System.Drawing.Point(3, 29)
        Me.txtPatientNo.MaxLength = 8
        Me.txtPatientNo.Name = "txtPatientNo"
        Me.txtPatientNo.Size = New System.Drawing.Size(100, 20)
        Me.txtPatientNo.TabIndex = 4
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(109, 29)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 3
        Me.btnSubmit.Text = "Next"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'PatientNoCheck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 442)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Name = "PatientNoCheck"
        Me.Text = "PatientNoCheck"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.grp1.ResumeLayout(False)
        Me.grp1.PerformLayout()
        Me.grp2.ResumeLayout(False)
        Me.grp2.PerformLayout()
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
End Class
