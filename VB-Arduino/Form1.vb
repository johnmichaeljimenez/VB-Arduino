Public Class Form1

    Public Shared activeForm As Form1
    Dim readSerial As String

    Public Shared scanMode As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        readSerial = ""


        'PersonalInfo.patientNo = "00000006"
        'PersonalInfo.firstName = "asd"
        'PersonalInfo.gender = "Male"
        'PersonalInfo.birthday = "1/1/1"
        'PersonalInfo.birthplace = "asd"
        'PersonalInfo.address = "address"
        'PersonalInfo.contactNo = "0909"
        'PatientNoCheck.existing = True
        'PrintExcel(PersonalInfo.patientNo)
        'Application.Exit()
        'Exit Sub



        activeForm = Me

        SerialPort1.Open()

        'testprint()

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
                Case 3
                    If readSerial.Contains(",") Then
                        Dim spl() As String = readSerial.Split(",")
                        ScanPulse.activeForm.UpdateValues(spl(0), spl(1))
                    End If
                Case 4

                Case Else

            End Select

            'MessageBox.Show("Read Serial: " + readSerial)


            readSerial = ""
            scanMode = 0
        End If
    End Sub

    Public Sub testprint()
        Dim templatePath As String = Application.StartupPath + "/test2.xlsx"
        Dim savePath As String = Application.StartupPath + "/test2.xlsx"

        Dim excelApp As New Microsoft.Office.Interop.Excel.Application()

        Dim currentWorkbook As Microsoft.Office.Interop.Excel.Workbook = excelApp.Workbooks.Add(templatePath)
        Dim currentWorksheet As Microsoft.Office.Interop.Excel.Worksheet = currentWorkbook.ActiveSheet ' (Microsoft.Office.Interop.Excel.Worksheet)
        excelApp.Visible = False

        Dim empty As Boolean = True

        Dim row As Integer = 1
        While True
            Dim value As String = currentWorksheet.Range("A" + (row.ToString())).Value
            Debug.Print("row: A" + row.ToString() + "  value: " + value)
            empty = String.IsNullOrEmpty(value)
            If empty Then
                Debug.Print(">" + value)
                Exit While
            End If
            row += 1
        End While

        currentWorksheet.Range("A" + row.ToString()).Value = DateTime.Now.ToString()

        excelApp.DisplayAlerts = False

        currentWorksheet.SaveAs(savePath)
        currentWorkbook.Close()
        excelApp.Quit()
    End Sub


End Class
