﻿Public Class For_RecaudoVisor
    Private Sub For_RecaudoVisor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub For_RecaudoVisor_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub
End Class