Public Class Inductanciavb
    Private Sub checkInductancia1_CheckedChanged(sender As Object, e As EventArgs) Handles checkInductancia1.CheckedChanged
        If Me.checkInductancia1.Checked = True Then
            checkInductancia2.Enabled = False
            checkInductancia3.Enabled = False
            checkInductancia4.Enabled = False


            pnl1paralelo.Visible = True
        Else
            checkInductancia1.Enabled = True
            checkInductancia2.Enabled = True
            checkInductancia3.Enabled = True
            checkInductancia4.Enabled = True
            pnlResultadoInductancia.Visible = False
            pnl1paralelo.Visible = False
        End If
    End Sub

    Private Sub checkInductancia2_CheckedChanged(sender As Object, e As EventArgs) Handles checkInductancia2.CheckedChanged
        If Me.checkInductancia2.Checked = True Then
            checkInductancia1.Enabled = False
            checkInductancia3.Enabled = False
            checkInductancia4.Enabled = False


            pnl2Paralelo.Visible = True
        Else
            checkInductancia1.Enabled = True
            checkInductancia2.Enabled = True
            checkInductancia3.Enabled = True
            checkInductancia4.Enabled = True
            pnlResultadoInductancia.Visible = False
            pnl2Paralelo.Visible = False
        End If
    End Sub

    Private Sub checkInductancia3_CheckedChanged(sender As Object, e As EventArgs) Handles checkInductancia3.CheckedChanged
        If Me.checkInductancia3.Checked = True Then
            checkInductancia1.Enabled = False
            checkInductancia2.Enabled = False
            checkInductancia4.Enabled = False


            pnl3Paralelo.Visible = True
        Else
            checkInductancia1.Enabled = True
            checkInductancia2.Enabled = True
            checkInductancia3.Enabled = True
            checkInductancia4.Enabled = True
            pnlResultadoInductancia.Visible = False
            pnl3Paralelo.Visible = False
        End If
    End Sub

    Private Sub checkInductancia4_CheckedChanged(sender As Object, e As EventArgs) Handles checkInductancia4.CheckedChanged
        If Me.checkInductancia4.Checked = True Then
            checkInductancia1.Enabled = False
            checkInductancia2.Enabled = False
            checkInductancia3.Enabled = False


            pnl4Paralelo.Visible = True
        Else
            checkInductancia1.Enabled = True
            checkInductancia2.Enabled = True
            checkInductancia3.Enabled = True
            checkInductancia4.Enabled = True
            pnlResultadoInductancia.Visible = False
            pnl4Paralelo.Visible = False
        End If
    End Sub

    Private Sub btnparalelo1_Click(sender As Object, e As EventArgs) Handles btnparalelo1.Click
        Dim resultado, operacion As Double
        pnlResultadoInductancia.Visible = True
        operacion = (1 / (1 / txt1ParaleloInd1.Text))
        resultado = operacion
        lblValorInduc.Text = resultado
        txt1ParaleloInd1.Text = ""

    End Sub

    Private Sub btnParalelo2_Click(sender As Object, e As EventArgs) Handles btnParalelo2.Click
        Dim resultado, operacion As Double
        pnlResultadoInductancia.Visible = True
        operacion = (1 / ((1 / txt2Paralelo1.Text) + (1 / txt2Paralelo2.Text)))
        resultado = operacion
        lblValorInduc.Text = resultado
        txt2Paralelo1.Text = ""
        txt2Paralelo2.Text = ""
    End Sub

    Private Sub btnParalelo3_Click(sender As Object, e As EventArgs) Handles btnParalelo3.Click
        Dim resultado, operacion As Double
        pnlResultadoInductancia.Visible = True
        operacion = (1) / ((1 / txt3Paralelo1.Text) + (1 / txt3Paralelo2.Text) + (1 / txt3Paralelo3.Text))
        resultado = operacion
        lblValorInduc.Text = resultado
        txt3Paralelo1.Text = ""
        txt3Paralelo2.Text = ""
        txt3Paralelo3.Text = ""
    End Sub

    Private Sub btn4Paralelo_Click(sender As Object, e As EventArgs) Handles btn4Paralelo.Click
        Dim resultado, operacion As Double
        pnlResultadoInductancia.Visible = True
        operacion = (1) / ((1 / txt4Paralelo1.Text) + (1 / txt4Paralelo2.Text) + (1 / txt4Paralelo3.Text) + (1 / txt4Paralelo4.Text))
        resultado = operacion
        lblValorInduc.Text = resultado
        txt4Paralelo1.Text = ""
        txt4Paralelo2.Text = ""
        txt4Paralelo3.Text = ""
        txt4Paralelo4.Text = ""
    End Sub

    Private Sub btnParalelo_Click(sender As Object, e As EventArgs) Handles btnParalelo.Click
        pnlParalelo.Visible = True
        pnlSerie.Visible = False
    End Sub

    Private Sub checkSerie1_CheckedChanged(sender As Object, e As EventArgs) Handles checkSerie1.CheckedChanged
        If Me.checkSerie1.Checked = True Then
            checkSerie2.Enabled = False
            checkSerie3.Enabled = False
            checkSerie4.Enabled = False


            pnl1Serie.Visible = True
        Else
            checkSerie1.Enabled = True
            checkSerie2.Enabled = True
            checkSerie3.Enabled = True
            checkSerie4.Enabled = True
            pnlResultadoSerie.Visible = False
            pnl1Serie.Visible = False
        End If
    End Sub

    Private Sub btnSerie_Click(sender As Object, e As EventArgs) Handles btnSerie.Click
        pnlParalelo.Visible = False
        pnlSerie.Visible = True
    End Sub

    Private Sub checkSerie2_CheckedChanged(sender As Object, e As EventArgs) Handles checkSerie2.CheckedChanged
        If Me.checkSerie2.Checked = True Then
            checkSerie1.Enabled = False
            checkSerie3.Enabled = False
            checkSerie4.Enabled = False


            pnl2Serie.Visible = True
        Else
            checkSerie1.Enabled = True
            checkSerie2.Enabled = True
            checkSerie3.Enabled = True
            checkSerie4.Enabled = True
            pnlResultadoSerie.Visible = False
            pnl2Serie.Visible = False
        End If
    End Sub

    Private Sub checkSerie3_CheckedChanged(sender As Object, e As EventArgs) Handles checkSerie3.CheckedChanged
        If Me.checkSerie3.Checked = True Then
            checkSerie1.Enabled = False
            checkSerie2.Enabled = False
            checkSerie4.Enabled = False


            pnl3Serie.Visible = True
        Else
            checkSerie1.Enabled = True
            checkSerie2.Enabled = True
            checkSerie3.Enabled = True
            checkSerie4.Enabled = True
            pnlResultadoSerie.Visible = False
            pnl3Serie.Visible = False
        End If
    End Sub

    Private Sub checkSerie4_CheckedChanged(sender As Object, e As EventArgs) Handles checkSerie4.CheckedChanged
        If Me.checkSerie4.Checked = True Then
            checkSerie1.Enabled = False
            checkSerie3.Enabled = False
            checkSerie2.Enabled = False


            pnl4Serie.Visible = True
        Else
            checkSerie1.Enabled = True
            checkSerie2.Enabled = True
            checkSerie3.Enabled = True
            checkSerie4.Enabled = True
            pnlResultadoSerie.Visible = False
            pnl4Serie.Visible = False
        End If
    End Sub

    Private Sub btnSerie1_Click(sender As Object, e As EventArgs) Handles btnSerie1.Click
        Dim resultado, operacion As Double
        pnlResultadoSerie.Visible = True
        operacion = ((1 * txt1Serie1.Text))
        resultado = operacion
        lblValorSerie.Text = resultado
        txt1Serie1.Text = ""
    End Sub

    Private Sub btnSerie2_Click(sender As Object, e As EventArgs) Handles btnSerie2.Click
        Dim resultado, operacion As Double
        pnlResultadoSerie.Visible = True
        operacion = ((1 * txt2Serie1.Text) + (1 * txt2Serie2.Text))
        resultado = operacion
        lblValorSerie.Text = resultado
        txt2Serie1.Text = ""
        txt2Serie2.Text = ""
    End Sub

    Private Sub btnSerie3_Click(sender As Object, e As EventArgs) Handles btnSerie3.Click
        Dim resultado, operacion As Double
        pnlResultadoSerie.Visible = True
        operacion = ((1 * txt3Serie1.Text) + (1 * txt3Serie2.Text) + (1 * txt3Serie3.Text))
        resultado = operacion
        lblValorSerie.Text = resultado
        txt3Serie1.Text = ""
        txt3Serie2.Text = ""
        txt3Serie3.Text = ""
    End Sub

    Private Sub btn4Serie_Click(sender As Object, e As EventArgs) Handles btn4Serie.Click
        Dim resultado, operacion As Double
        pnlResultadoSerie.Visible = True
        operacion = ((1 * txt4Serie1.Text) + (1 * txt4Serie2.Text) + (1 * txt4Serie3.Text) + (1 * txt4Serie4.Text))
        resultado = operacion
        lblValorSerie.Text = resultado
        txt4Serie1.Text = ""
        txt4Serie2.Text = ""
        txt4Serie3.Text = ""
        txt4Serie4.Text = ""
    End Sub
End Class