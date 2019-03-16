Imports System.IO
Module Utils

    Dim progDir As String = Application.StartupPath + "/data/"

    Public Function CheckExcelFile(ByVal f As String) As Boolean
        Dim e As Boolean = File.Exists(progDir + f + ".xlsx")
        Return e
    End Function

    Public Sub PrintExcel(ByVal f As String)
        Dim templatePath As String = progDir + "template.xlsx"
        Dim savePath As String = progDir + f + ".xlsx"

        Dim excelApp As New Microsoft.Office.Interop.Excel.Application()

        Dim currentWorkbook As Microsoft.Office.Interop.Excel.Workbook = excelApp.Workbooks.Add(templatePath)
        Dim currentWorksheet As Microsoft.Office.Interop.Excel.Worksheet = currentWorkbook.ActiveSheet ' (Microsoft.Office.Interop.Excel.Worksheet)
        excelApp.Visible = True


        currentWorksheet.Range("A3").Value = "" 'dt.Rows[0].Field<String>("name")
        excelApp.DisplayAlerts = False

        currentWorksheet.SaveAs(savePath)
        currentWorkbook.Close()
        excelApp.Quit()
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
    Public Const DateExamined = "A15"
    Public Const Height = "B15"
    Public Const Weight = "C15"
    Public Const PulseRate = "D15"
    Public Const Temperature = "E15"
    Public Const BMI = "F15"
End Class