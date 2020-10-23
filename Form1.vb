Public Class Form1
    Private Sub tmrInicio_Tick(sender As Object, e As EventArgs) Handles tmrInicio.Tick
        Try
            While Me.Opacity > 0
                Me.Opacity -= 0.00001
            End While
            tmrInicio.Stop()
            Me.Hide()
            frmInicio.Show()
        Catch ex As Exception
            MsgBox("Error", MsgBoxStyle.Critical, "Error de inicio")
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Visible = False
        tmrInicio.Start()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
