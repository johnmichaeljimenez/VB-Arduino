﻿Imports System.IO
Module Utils

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
            Empty = String.IsNullOrEmpty(value)
            If Empty Then
                Debug.Print(">" + value)
                Exit While
            End If
            row += 1
        End While

        Debug.Print("writing to " + row.ToString())

        Dim dt As DateTime = DateTime.Now
        currentWorksheet.Range(Cells.DateExamined + row.ToString()).Value = dt.ToShortDateString() + " " + dt.ToShortTimeString()
        currentWorksheet.Range(Cells.Height + row.ToString()).Value = ScanHeight.result.ToString() + " cm"
        currentWorksheet.Range(Cells.PulseRate + row.ToString()).Value = ScanPulse.resultBPM.ToString() + " : " + ScanPulse.resultSat.ToString() + "%"
        currentWorksheet.Range(Cells.Temperature + row.ToString()).Value = ScanPulse.resultBPM.ToString() + " : " + ScanTemp.result.ToString() + "°"

        excelApp.DisplayAlerts = False

        currentWorksheet.SaveAs(savePath)
        currentWorkbook.Close()
        excelApp.Quit()
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