<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScanHeight
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
        Me.components = New System.ComponentModel.Container()
        Me.txtFeet = New System.Windows.Forms.TextBox()
        Me.txtInch = New System.Windows.Forms.TextBox()
        Me.txtMeters = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFeet
        '
        Me.txtFeet.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFeet.Location = New System.Drawing.Point(25, 117)
        Me.txtFeet.Name = "txtFeet"
        Me.txtFeet.ReadOnly = True
        Me.txtFeet.Size = New System.Drawing.Size(63, 27)
        Me.txtFeet.TabIndex = 1
        '
        'txtInch
        '
        Me.txtInch.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInch.Location = New System.Drawing.Point(94, 117)
        Me.txtInch.Name = "txtInch"
        Me.txtInch.ReadOnly = True
        Me.txtInch.Size = New System.Drawing.Size(78, 27)
        Me.txtInch.TabIndex = 2
        '
        'txtMeters
        '
        Me.txtMeters.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMeters.Location = New System.Drawing.Point(340, 117)
        Me.txtMeters.Name = "txtMeters"
        Me.txtMeters.ReadOnly = True
        Me.txtMeters.Size = New System.Drawing.Size(79, 27)
        Me.txtMeters.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(22, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Feet"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(91, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Inch"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(337, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Centimeters"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Roboto", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(14, 232)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(419, 48)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Please stand straight and stable." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Do not jump or move during the measurement."
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(480, 94)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(292, 219)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'btnNext
        '
        Me.btnNext.AutoSize = True
        Me.btnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.White
        Me.btnNext.Location = New System.Drawing.Point(628, 362)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 39)
        Me.btnNext.TabIndex = 17
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 5000
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Roboto", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 24)
        Me.Label6.Margin = New System.Windows.Forms.Padding(3, 0, 3, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(802, 37)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Height Measurement"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ScanHeight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 480)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMeters)
        Me.Controls.Add(Me.txtInch)
        Me.Controls.Add(Me.txtFeet)
        Me.Name = "ScanHeight"
        Me.Text = "ScanHeight"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFeet As TextBox
    Friend WithEvents txtInch As TextBox
    Friend WithEvents txtMeters As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnNext As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label6 As Label
End Class
