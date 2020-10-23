Imports System.ComponentModel

Public Class frmInicio
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim resistencias As New ResistenciaEquivalente
        resistencias.Show()
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim capacitancias As New Capacitancias
        capacitancias.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim iductancia As New Inductanciavb
        iductancia.Show()
        Me.Close()
    End Sub
End Class