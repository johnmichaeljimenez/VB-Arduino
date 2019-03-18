<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScanPulse
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(640, 365)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 45)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Next"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(475, 60)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(292, 275)
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(423, 26)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Please put your index finger gently on the sensor pressing softly during the meas" &
    "urement." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "It is recommended to breathe calmly and relax."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "BPM"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(36, 74)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(36, 20)
        Me.TextBox1.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Pulse Rate Measurement"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(138, 74)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(36, 20)
        Me.TextBox2.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(135, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "SpO2"
        '
        'ScanPulse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 442)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ScanPulse"
        Me.Text = "ScanPulse"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
End Class
