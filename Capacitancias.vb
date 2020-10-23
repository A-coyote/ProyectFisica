Public Class Capacitancias
    Private Sub checkCap1_CheckedChanged(sender As Object, e As EventArgs) Handles checkCap1.CheckedChanged
        If Me.checkCap1.Checked = True Then
            checkCap2.Enabled = False
            checkCap3.Enabled = False
            checkCap4.Enabled = False

            pnlCap1.Visible = True
        Else
            checkCap1.Enabled = True
            checkCap2.Enabled = True
            checkCap3.Enabled = True
            checkCap4.Enabled = True
            pnlResultado.Visible = False
            pnlCap1.Visible = False
        End If
    End Sub

    Private Sub checkCap2_CheckedChanged(sender As Object, e As EventArgs) Handles checkCap2.CheckedChanged
        If Me.checkCap2.Checked = True Then
            checkCap1.Enabled = False
            checkCap3.Enabled = False
            checkCap4.Enabled = False

            pnlCap2.Visible = True
        Else
            checkCap1.Enabled = True
            checkCap2.Enabled = True
            checkCap3.Enabled = True
            checkCap4.Enabled = True
            pnlResultado.Visible = False
            pnlCap2.Visible = False
        End If
    End Sub

    Private Sub checkCap3_CheckedChanged(sender As Object, e As EventArgs) Handles checkCap3.CheckedChanged
        If Me.checkCap3.Checked = True Then
            checkCap1.Enabled = False
            checkCap2.Enabled = False
            checkCap4.Enabled = False

            pnlCap3.Visible = True
        Else
            checkCap1.Enabled = True
            checkCap2.Enabled = True
            checkCap3.Enabled = True
            checkCap4.Enabled = True
            pnlResultado.Visible = False
            pnlCap3.Visible = False
        End If
    End Sub

    Private Sub checkCap4_CheckedChanged(sender As Object, e As EventArgs) Handles checkCap4.CheckedChanged
        If Me.checkCap4.Checked = True Then
            checkCap1.Enabled = False
            checkCap2.Enabled = False
            checkCap3.Enabled = False

            pnlCap4.Visible = True
        Else
            checkCap1.Enabled = True
            checkCap2.Enabled = True
            checkCap3.Enabled = True
            checkCap4.Enabled = True
            pnlResultado.Visible = False
            pnlCap4.Visible = False
        End If
    End Sub

    Private Sub btnCalcularCap1_Click(sender As Object, e As EventArgs) Handles btnCalcularCap1.Click
        Dim resultado, operacion As Double
        pnlResultado.Visible = True
        operacion = (1) / ((1 / txt1Cap1.Text))
        resultado = operacion
        lblValor.Text = resultado
        txt1Cap1.Text = ""
    End Sub

    Private Sub btnCalcularCap2_Click(sender As Object, e As EventArgs) Handles btnCalcularCap2.Click
        Dim resultado, operacion As Double
        pnlResultado.Visible = True
        operacion = (1) / ((1 / txt2Cap1.Text) + (1 / txt2Cap2.Text))
        resultado = operacion
        lblValor.Text = resultado
        txt2Cap1.Text = ""
        txt2Cap2.Text = ""
    End Sub

    Private Sub btnCalcularCap3_Click(sender As Object, e As EventArgs) Handles btnCalcularCap3.Click
        Dim resultado, operacion As Double
        pnlResultado.Visible = True
        operacion = (1) / ((1 / txt3Cap1.Text) + (1 / txt3Cap2.Text) + (1 / txt3Cap3.Text))
        resultado = operacion
        lblValor.Text = resultado
        txt3Cap1.Text = ""
        txt3Cap2.Text = ""
        txt3Cap3.Text = ""
    End Sub

    Private Sub btnCalcularCap4_Click(sender As Object, e As EventArgs) Handles btnCalcularCap4.Click
        Dim resultado, operacion As Double
        pnlResultado.Visible = True
        operacion = (1) / ((1 / txt4Cap1.Text) + (1 / txt4Cap2.Text) + (1 / txt4Cap3.Text) + (1 / txt4Cap4.Text))
        resultado = operacion
        lblValor.Text = resultado
        txt4Cap1.Text = ""
        txt4Cap2.Text = ""
        txt4Cap3.Text = ""
        txt4Cap4.Text = ""
    End Sub

    Private Sub btnCapacitanciaParalelo_Click(sender As Object, e As EventArgs) Handles btnCapacitanciaParalelo.Click
        pnlCapParalela.Visible = True
        pnlCapSerie.Visible = False
    End Sub

    Private Sub btnCapacitanciaSerie_Click(sender As Object, e As EventArgs) Handles btnCapacitanciaSerie.Click
        pnlCapParalela.Visible = False
        pnlCapSerie.Visible = True
    End Sub

    Private Sub checkCapSerie1_CheckedChanged(sender As Object, e As EventArgs) Handles checkCapSerie1.CheckedChanged
        If Me.checkCapSerie1.Checked = True Then
            checkCapSerie2.Enabled = False
            checkCapSerie3.Enabled = False
            checkCapSerie4.Enabled = False

            pnlCapSerie1.Visible = True
        Else
            checkCapSerie1.Enabled = True
            checkCapSerie2.Enabled = True
            checkCapSerie3.Enabled = True
            checkCapSerie4.Enabled = True
            pnlResultadoSerie.Visible = False
            pnlCapSerie1.Visible = False
        End If
    End Sub

    Private Sub checkCapSerie2_CheckedChanged(sender As Object, e As EventArgs) Handles checkCapSerie2.CheckedChanged
        If Me.checkCapSerie2.Checked = True Then
            checkCapSerie1.Enabled = False
            checkCapSerie3.Enabled = False
            checkCapSerie4.Enabled = False

            pnlCapSerie2.Visible = True
        Else
            checkCapSerie1.Enabled = True
            checkCapSerie2.Enabled = True
            checkCapSerie3.Enabled = True
            checkCapSerie4.Enabled = True
            pnlResultadoSerie.Visible = False
            pnlCapSerie2.Visible = False
        End If
    End Sub

    Private Sub checkCapSerie3_CheckedChanged(sender As Object, e As EventArgs) Handles checkCapSerie3.CheckedChanged
        If Me.checkCapSerie3.Checked = True Then
            checkCapSerie1.Enabled = False
            checkCapSerie2.Enabled = False
            checkCapSerie4.Enabled = False

            pnlCapSerie3.Visible = True
        Else
            checkCapSerie1.Enabled = True
            checkCapSerie2.Enabled = True
            checkCapSerie3.Enabled = True
            checkCapSerie4.Enabled = True
            pnlResultadoSerie.Visible = False
            pnlCapSerie3.Visible = False
        End If
    End Sub

    Private Sub checkCapSerie4_CheckedChanged(sender As Object, e As EventArgs) Handles checkCapSerie4.CheckedChanged
        If Me.checkCapSerie4.Checked = True Then
            checkCapSerie1.Enabled = False
            checkCapSerie3.Enabled = False
            checkCapSerie2.Enabled = False

            pnlCapSerie4.Visible = True
        Else
            checkCapSerie1.Enabled = True
            checkCapSerie2.Enabled = True
            checkCapSerie3.Enabled = True
            checkCapSerie4.Enabled = True
            pnlResultadoSerie.Visible = False
            pnlCapSerie4.Visible = False
        End If
    End Sub

    Private Sub btn1Serie_Click(sender As Object, e As EventArgs) Handles btn1Serie.Click
        Dim resultado, operacion As Double
        pnlResultadoSerie.Visible = True
        operacion = (1 * txt1Serie1.Text)
        resultado = operacion
        lblResultado.Text = resultado
        txt1Serie1.Text = ""
    End Sub

    Private Sub btn2Serie_Click(sender As Object, e As EventArgs) Handles btn2Serie.Click
        Dim resultado, operacion As Double
        pnlResultadoSerie.Visible = True
        operacion = ((1 * txt2Serie1.Text) + (1 * txt2Serie2.Text))
        resultado = operacion
        lblResultado.Text = resultado
        txt2Serie1.Text = ""
        txt2Serie2.Text = ""
    End Sub

    Private Sub btn3Serie_Click(sender As Object, e As EventArgs) Handles btn3Serie.Click
        Dim resultado, operacion As Double
        pnlResultadoSerie.Visible = True
        operacion = ((1 * txt3Serie1.Text) + (1 * txt3Serie2.Text) + (1 * txt3Serie3.Text))
        resultado = operacion
        lblResultado.Text = resultado
        txt3Serie1.Text = ""
        txt3Serie2.Text = ""
        txt3Serie3.Text = ""
    End Sub

    Private Sub btn4Serie_Click(sender As Object, e As EventArgs) Handles btn4Serie.Click
        Dim resultado, operacion As Double
        pnlResultadoSerie.Visible = True
        operacion = ((1 * txt4Serie1.Text) + (1 * txt4Serie2.Text) + (1 * txt4Serie3.Text) + (1 * txt4Serie4.Text))
        resultado = operacion
        lblResultado.Text = resultado
        txt4Serie1.Text = ""
        txt4Serie2.Text = ""
        txt4Serie3.Text = ""
        txt4Serie4.Text = ""
    End Sub

    Private Sub Capacitancias_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Hide()
        frmInicio.Show()
    End Sub
End Class