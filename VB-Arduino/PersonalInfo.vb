Imports VB_Arduino.Utils

Public Class PersonalInfo
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

    End Sub

    Private Sub PersonalInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KillOSK()
        Process.Start("osk")

    End Sub

    Sub KillOSK()
        Dim proc = Process.GetProcessesByName("osk")
        For i As Integer = 0 To proc.Count - 1
            proc(i).Kill()
        Next i
    End Sub

    Private Sub PersonalInfo_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        KillOSK()
    End Sub

    Private Sub PersonalInfo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        KillOSK()
    End Sub
End Class