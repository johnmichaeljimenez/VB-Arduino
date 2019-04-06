Imports System.IO
Module Utils
    Declare Function Wow64DisableWow64FsRedirection Lib "kernel32" (ByRef oldvalue As Long) As Boolean
    Declare Function Wow64EnableWow64FsRedirection Lib "kernel32" (ByRef oldvalue As Long) As Boolean
    Private osk As String = "C:\Windows\System32\osk.exe"

    Dim progDir As String = Application.StartupPath + "/data/"

    Public Function CheckExcelFile(ByVal f As String) As Boolean
        Dim e As Boolean = File.Exists(progDir + f + ".xlsx")
        Return e
    End Function

    Public Sub PrintExcel(ByVal f As String)
        Dim templatePath As String = Application.StartupPath + "/template.xlsx"
        Dim savePath As String = progDir + f + ".xlsx"

        If (PatientNoCheck.existing) Then
            templatePath = savePath
        End If

        Dim excelApp As New Microsoft.Office.Interop.Excel.Application()

        Dim currentWorkbook As Microsoft.Office.Interop.Excel.Workbook = excelApp.Workbooks.Add(templatePath)
        Dim currentWorksheet As Microsoft.Office.Interop.Excel.Worksheet = currentWorkbook.ActiveSheet ' (Microsoft.Office.Interop.Excel.Worksheet)
        excelApp.Visible = False


        currentWorksheet.Range(Cells.PatientNo).Value = PersonalInfo.patientNo
        currentWorksheet.Range(Cells.Name).Value = PersonalInfo.firstName + " " + PersonalInfo.middleName + " " + PersonalInfo.surname + " " + PersonalInfo.namePrefix
        currentWorksheet.Range(Cells.Gender).Value = PersonalInfo.gender
        currentWorksheet.Range(Cells.Birthdate).Value = PersonalInfo.birthday
        currentWorksheet.Range(Cells.Birthplace).Value = PersonalInfo.birthplace
        currentWorksheet.Range(Cells.Address).Value = PersonalInfo.address
        currentWorksheet.Range(Cells.ContactNo).Value = PersonalInfo.contactNo

        Dim empty As Boolean = False

        'Dim row As Integer = 15
        'While empty
        '    row += 1
        '    Dim value As String = currentWorksheet.Range(Cells.DateExamined + row.ToString()).Value
        '    Debug.Print("row: " + Cells.DateExamined + row.ToString() + "  value: " + value)
        '    empty = String.IsNullOrEmpty(value)
        'End While


        Dim row As Integer = 15
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

        Debug.Print("writing to " + row.ToString())

        Dim dt As DateTime = DateTime.Now
        currentWorksheet.Range(Cells.DateExamined + row.ToString()).Value = dt.ToShortDateString() + " " + dt.ToShortTimeString()
        currentWorksheet.Range(Cells.Height + row.ToString()).Value = ScanHeight.result.ToString() + " cm"
        currentWorksheet.Range(Cells.Weight + row.ToString()).Value = (ScanWeight.result / 1000).ToString() + " kg"
        currentWorksheet.Range(Cells.PulseRate + row.ToString()).Value = ScanPulse.resultSat.ToString() + " : " + ScanPulse.resultBPM.ToString() + "% - (" + Results.GetPulseRemarks() + ")"
        currentWorksheet.Range(Cells.Temperature + row.ToString()).Value = ScanTemp.result.ToString() + " °C (" + Results.GetTemperatureRemarks() + ")"
        currentWorksheet.Range(Cells.BMI + row.ToString()).Value = Results.bmiResult

        excelApp.DisplayAlerts = False

        currentWorksheet.SaveAs(savePath)
        currentWorkbook.Close()
        excelApp.Quit()
        System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp)
    End Sub

    Public Sub ReadData(ByVal f As String)
        Dim dataPath As String = progDir + f + ".xlsx"

        Dim excelApp As New Microsoft.Office.Interop.Excel.Application()

        Dim currentWorkbook As Microsoft.Office.Interop.Excel.Workbook = excelApp.Workbooks.Add(dataPath)
        Dim currentWorksheet As Microsoft.Office.Interop.Excel.Worksheet = currentWorkbook.ActiveSheet ' (Microsoft.Office.Interop.Excel.Worksheet)
        excelApp.Visible = False


        PersonalInfo.patientNo = currentWorksheet.Range(Cells.PatientNo).Value.ToString()
        PersonalInfo.firstName = currentWorksheet.Range(Cells.Name).Value.ToString()
        PersonalInfo.gender = currentWorksheet.Range(Cells.Gender).Value.ToString()
        PersonalInfo.birthday = currentWorksheet.Range(Cells.Birthdate).Value.ToString()
        PersonalInfo.birthplace = currentWorksheet.Range(Cells.Birthplace).Value.ToString()
        PersonalInfo.address = currentWorksheet.Range(Cells.Address).Value.ToString()
        PersonalInfo.contactNo = currentWorksheet.Range(Cells.ContactNo).Value.ToString()

        excelApp.DisplayAlerts = False

        currentWorkbook.Close()
        excelApp.Quit()
        System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp)
    End Sub

    Public Sub ShowKeyboard()
        Dim path As String = (Environment.GetFolderPath(Environment.SpecialFolder.System) + "\osk.exe")
        'MessageBox.Show(path)
        'Process.Start(New ProcessStartInfo(
        '    (Path)))
        'Process.Start("C:\Windows\System32\osk.exe")

        Dim old As Long
        If Environment.Is64BitOperatingSystem Then
            If Wow64DisableWow64FsRedirection(old) Then
                Process.Start(osk)
                Wow64EnableWow64FsRedirection(old)
            End If
        Else
            Process.Start(osk)
        End If
    End Sub

    Public Sub HideKeyboard()
        Dim proc = Process.GetProcessesByName("osk")
        For i As Integer = 0 To proc.Count - 1
            proc(i).Kill()
        Next i
    End Sub

End Module

Public Class Cells
    Public Const PatientNo = "B4"
    Public Const Name = "B6"
    Public Const Gender = "B7"
    Public Const Birthdate = "B8"
    Public Const Birthplace = "B9"
    Public Const Address = "B10"
    Public Const ContactNo = "B11"
    Public Const DateExamined = "A"
    Public Const Height = "B"
    Public Const Weight = "C"
    Public Const PulseRate = "D"
    Public Const Temperature = "E"
    Public Const BMI = "F"
End Class