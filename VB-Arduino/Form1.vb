Public Class Form1

    Public Shared activeForm As Form1
    Dim readSerial As String

    Public Shared scanMode As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        activeForm = Me

        SerialPort1.Open()
        readSerial = ""
    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        Me.Hide()
        PatientNoCheck.Show()
    End Sub

    Public Shared Sub SetMode(ByVal x As Integer)
        scanMode = x
        activeForm.SerialPort1.WriteLine(x)
    End Sub

    Private Sub SerialPort1_DataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived

        Dim str As String = SerialPort1.ReadLine()
        Debug.Print(str)
        readSerial += str

        readSerial = readSerial.Trim()
    End Sub

    Public Function IsFinished() As Boolean
        Return readSerial.StartsWith("$") And readSerial.EndsWith("#")
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If IsFinished() Then
            readSerial = readSerial.Replace("$", "").Replace("#", "")

            Select Case scanMode
                Case 1
                    ScanHeight.activeForm.UpdateValues(readSerial)
                Case 2

                Case Else

            End Select

            'MessageBox.Show("Read Serial: " + readSerial)


            readSerial = ""
            scanMode = 0
        End If
    End Sub
End Class
