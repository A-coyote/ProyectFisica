Public Class ResistenciaEquivalente
    Private Sub check1_CheckedChanged(sender As Object, e As EventArgs) Handles check1.CheckedChanged
        If Me.check1.Checked = True Then
            pcbResistencia1.Visible = True
            pcbResistencia2.Visible = False
            pcbResistencia3.Visible = False
            pcbResistencia4.Visible = False
            check2.Enabled = False
            check3.Enabled = False
            check4.Enabled = False


            pnlResistencia1.Visible = True
        Else
            pcbResistencia1.Visible = False
            pcbResistencia2.Visible = False
            pcbResistencia3.Visible = False
            pcbResistencia4.Visible = False
            check1.Enabled = True
            check2.Enabled = True
            check3.Enabled = True
            check4.Enabled = True
            pnlResultado.Visible = False
            pnlResistencia1.Visible = False
        End If
    End Sub

    Private Sub check2_CheckedChanged(sender As Object, e As EventArgs) Handles check2.CheckedChanged
        If Me.check2.Checked = True Then
            pcbResistencia1.Visible = False
            pcbResistencia2.Visible = True
            pcbResistencia3.Visible = False
            pcbResistencia4.Visible = False
            check1.Enabled = False
            check3.Enabled = False
            check4.Enabled = False

            pnlResistencia2.Visible = True
        Else
            pcbResistencia1.Visible = False
            pcbResistencia2.Visible = False
            pcbResistencia3.Visible = False
            pcbResistencia4.Visible = False
            check1.Enabled = True
            check2.Enabled = True
            check3.Enabled = True
            check4.Enabled = True
            pnlResultado.Visible = False
            pnlResistencia2.Visible = False
        End If
    End Sub

    Private Sub check3_CheckedChanged(sender As Object, e As EventArgs) Handles check3.CheckedChanged
        If Me.check3.Checked = True Then
            pcbResistencia1.Visible = False
            pcbResistencia2.Visible = False
            pcbResistencia3.Visible = True
            pcbResistencia4.Visible = False
            check1.Enabled = False
            check2.Enabled = False
            check4.Enabled = False

            pnlResistencia3.Visible = True
        Else
            pcbResistencia1.Visible = False
            pcbResistencia2.Visible = False
            pcbResistencia3.Visible = False
            pcbResistencia4.Visible = False
            check1.Enabled = True
            check2.Enabled = True
            check3.Enabled = True
            check4.Enabled = True
            pnlResultado.Visible = False
            pnlResistencia3.Visible = False
        End If
    End Sub

    Private Sub check4_CheckedChanged(sender As Object, e As EventArgs) Handles check4.CheckedChanged
        If Me.check4.Checked = True Then
            pcbResistencia1.Visible = False
            pcbResistencia2.Visible = False
            pcbResistencia3.Visible = False
            pcbResistencia4.Visible = True
            check1.Enabled = False
            check2.Enabled = False
            check3.Enabled = False

            pnlResistencia4.Visible = True
        Else
            pcbResistencia1.Visible = False
            pcbResistencia2.Visible = False
            pcbResistencia3.Visible = False
            pcbResistencia4.Visible = False
            check1.Enabled = True
            check2.Enabled = True
            check3.Enabled = True
            check4.Enabled = True
            pnlResultado.Visible = False
            pnlResistencia4.Visible = False
        End If
    End Sub

    Private Sub btnCalcularResistencia1_Click(sender As Object, e As EventArgs) Handles btnCalcularResistencia1.Click
        Dim resultado, operacion As Double
        pnlResultado.Visible = True
        operacion = (1) / (1 / txt1Resistencia1.Text)
        resultado = operacion
        lblValor.Text = resultado
        txt1Resistencia1.Text = ""

    End Sub

    Private Sub btnCalcularResistencia2_Click(sender As Object, e As EventArgs) Handles btnCalcularResistencia2.Click
        Dim resultado, operacion As Double
        pnlResultado.Visible = True
        operacion = (1) / ((1 / txt2resistencia1.Text) + (1 / txt2Resistencia2.Text))
        resultado = operacion
        lblValor.Text = resultado
        txt2resistencia1.Text = ""
        txt2Resistencia2.Text = ""
    End Sub

    Private Sub btnCalcularResistencia3_Click(sender As Object, e As EventArgs) Handles btnCalcularResistencia3.Click
        Dim resultado, operacion As Double
        pnlResultado.Visible = True
        operacion = (1) / ((1 / txt3Resistencia1.Text) + (1 / txt3Resistencia2.Text) + (1 / txt3Resistencia3.Text))
        resultado = operacion
        lblValor.Text = resultado
        txt3Resistencia1.Text = ""
        txt3Resistencia2.Text = ""
        txt3Resistencia3.Text = ""
    End Sub

    Private Sub btnCalcularResistencia4_Click(sender As Object, e As EventArgs) Handles btnCalcularResistencia4.Click
        Dim resultado, operacion As Double
        pnlResultado.Visible = True
        operacion = (1) / ((1 / txt4Resistencia1.Text) + (1 / txt4Resistencia2.Text) + (1 / txt4Resistencia3.Text) + (1 / txt4Resistencia4.Text))
        resultado = operacion
        lblValor.Text = resultado
        txt4Resistencia1.Text = ""
        txt4Resistencia2.Text = ""
        txt4Resistencia3.Text = ""
        txt4Resistencia4.Text = ""
    End Sub

    Private Sub btnParalelo_Click(sender As Object, e As EventArgs) Handles btnParalelo.Click
        pnlParalelo.Visible = True
        pnlSerie.Visible = False
    End Sub

    Private Sub btnSerie_Click(sender As Object, e As EventArgs) Handles btnSerie.Click
        pnlParalelo.Visible = False
        pnlSerie.Visible = True
    End Sub

    Private Sub btn4Serie_Click(sender As Object, e As EventArgs) Handles btn4Serie.Click
        Dim resultado, operacion As Double
        pnlResultadoSerie.Visible = True
        operacion = ((1*txt4Serie1.Text) + (1*txt4Serie2.Text) + (1*txt4Serie3.Text) + (1*txt4Serie4.Text))
        resultado = operacion
        labelValorSerie.Text = resultado
        txt4Serie1.Text = ""
        txt4Serie2.Text = ""
        txt4Serie3.Text = ""
        txt4Serie4.Text = ""
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles checkSerie1.CheckedChanged
        If Me.checkSerie1.Checked = True Then
            pnl1Serie.Visible = True
            pnl2Serie.Visible = False
            pnl3Serie.Visible = False
            pnl4Serie.Visible = False
            checkSerie2.Enabled = False
            checkSerie3.Enabled = False
            checkSerie4.Enabled = False

        Else
            pnl1Serie.Visible = False
            pnl2Serie.Visible = False
            pnl3Serie.Visible = False
            pnl4Serie.Visible = False
            checkSerie1.Enabled = True
            checkSerie2.Enabled = True
            checkSerie3.Enabled = True
            checkSerie4.Enabled = True
            pnlResultadoSerie.Visible = False
        End If
    End Sub

    Private Sub checkSerie2_CheckedChanged(sender As Object, e As EventArgs) Handles checkSerie2.CheckedChanged
        If Me.checkSerie2.Checked = True Then
            pnl1Serie.Visible = False
            pnl2Serie.Visible = True
            pnl3Serie.Visible = False
            pnl4Serie.Visible = False
            checkSerie1.Enabled = False
            checkSerie3.Enabled = False
            checkSerie4.Enabled = False

        Else
            pnl1Serie.Visible = False
            pnl2Serie.Visible = False
            pnl3Serie.Visible = False
            pnl4Serie.Visible = False
            checkSerie1.Enabled = True
            checkSerie2.Enabled = True
            checkSerie3.Enabled = True
            checkSerie4.Enabled = True
            pnlResultadoSerie.Visible = False
        End If
    End Sub

    Private Sub checkSerie3_CheckedChanged(sender As Object, e As EventArgs) Handles checkSerie3.CheckedChanged
        If Me.checkSerie3.Checked = True Then
            pnl1Serie.Visible = False
            pnl2Serie.Visible = False
            pnl3Serie.Visible = True
            pnl4Serie.Visible = False
            checkSerie1.Enabled = False
            checkSerie2.Enabled = False
            checkSerie4.Enabled = False

        Else
            pnl1Serie.Visible = False
            pnl2Serie.Visible = False
            pnl3Serie.Visible = False
            pnl4Serie.Visible = False
            checkSerie1.Enabled = True
            checkSerie2.Enabled = True
            checkSerie3.Enabled = True
            checkSerie4.Enabled = True
            pnlResultadoSerie.Visible = False
        End If
    End Sub

    Private Sub checkSerie4_CheckedChanged(sender As Object, e As EventArgs) Handles checkSerie4.CheckedChanged
        If Me.checkSerie4.Checked = True Then
            pnl1Serie.Visible = False
            pnl2Serie.Visible = False
            pnl3Serie.Visible = False
            pnl4Serie.Visible = True
            checkSerie1.Enabled = False
            checkSerie3.Enabled = False
            checkSerie2.Enabled = False

        Else
            pnl1Serie.Visible = False
            pnl2Serie.Visible = False
            pnl3Serie.Visible = False
            pnl4Serie.Visible = False
            checkSerie1.Enabled = True
            checkSerie2.Enabled = True
            checkSerie3.Enabled = True
            checkSerie4.Enabled = True
            pnlResultadoSerie.Visible = False
        End If
    End Sub

    Private Sub btnSerie1_Click(sender As Object, e As EventArgs) Handles btnSerie1.Click
        Dim resultado, operacion As Double
        pnlResultadoSerie.Visible = True
        operacion = txt1Serie1.Text
        resultado = operacion
        labelValorSerie.Text = resultado
        txt1Serie1.Text = ""


    End Sub

    Private Sub btnSerie2_Click(sender As Object, e As EventArgs) Handles btnSerie2.Click
        Dim resultado, operacion As Double
        pnlResultadoSerie.Visible = True
        operacion = ((1 * txt2Serie1.Text) + (1 * txt2Serie2.Text))
        resultado = operacion
        labelValorSerie.Text = resultado
        txt2Serie1.Text = ""
        txt2Serie2.Text = ""
    End Sub

    Private Sub btnSerie3_Click(sender As Object, e As EventArgs) Handles btnSerie3.Click
        Dim resultado, operacion As Double
        pnlResultadoSerie.Visible = True
        operacion = ((1 * txt3Serie1.Text) + (1 * txt3Serie2.Text) + (1 * txt3Serie3.Text))
        resultado = operacion
        labelValorSerie.Text = resultado
        txt3Serie1.Text = ""
        txt3Serie2.Text = ""
        txt3Serie3.Text = ""
    End Sub

    Private Sub ResistenciaEquivalente_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.hide()
        frmInicio.Show()
    End Sub
End Class