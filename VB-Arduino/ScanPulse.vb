﻿Public Class ScanPulse

    Public Shared activeForm As ScanPulse
    Public Shared resultBPM, resultSat As Decimal

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Form1.SetMode(3)
        Timer1.Stop()
    End Sub

    Private Sub ScanPulse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        activeForm = Me
        WindowState = FormWindowState.Normal
        StartPosition = FormStartPosition.Manual
        Location = Screen.AllScreens(UBound(Screen.AllScreens)).Bounds.Location
        WindowState = FormWindowState.Maximized
        UpdateValues(0, 0)

        Timer1.Start()
        btnNext.Enabled = False
    End Sub


    Public Sub UpdateValues(ByVal n As String, ByVal m As String)
        txtBPM.Text = m
        txtSat.Text = n

        resultBPM = CDec(m)
        resultSat = CDec(n)
        btnNext.Enabled = True
        Timer1.Stop()
        Form1.SetMode(0)
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        ScanTemp.Show()
        Close()
    End Sub
    Private Sub FormClosingEvent(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            'Application.Exit()
        End If
    End Sub
End Class