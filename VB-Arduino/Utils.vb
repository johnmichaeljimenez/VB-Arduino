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
