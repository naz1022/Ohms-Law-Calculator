Public Class OhmsLaw

    'Radio Button Events'
    Public Sub rb_checkedChanged(sender As System.Object, e As System.EventArgs) Handles rbResistance.CheckedChanged, rbCurrent.CheckedChanged, rbVoltage.CheckedChanged
        'Control Handler'
        For Each cntrl As Control In Controls
            'Radio Button Handler'
            If TypeOf cntrl Is RadioButton Then
                'Current radiobutton OR resistance radiobutton is checked'
                If rbCurrent.Checked = True Or rbResistance.Checked = True Then
                    'Equals sign label visible'
                    labelEquals.Visible = True
                    'Operator sign label visible'
                    labelOperator.Visible = True
                    'Operator label is division symbol'
                    labelOperator.Text = ("÷")
                    'Text above textboxOne becomes voltage and visible'
                    labelNumbOne.Text = ("Voltage")
                    labelNumbOne.Visible = True
                    'Button txtboxOneClear text change'
                    btnTextboxOneClear.Text = ("CLEAR VOLTAGE")
                    'Calulate button displays calculate voltage'
                    btnCalculate.Text = ("CALCULATE VOLTAGE")
                    'Button txtboxAnsweClear text change'
                    btnTextboxAnswerClear.Text = ("CLEAR VOLTAGE")
                    'Current radiobutton checked'
                    If rbCurrent.Checked = True Then
                        'label numbTwo text and visble change'
                        labelNumbTwo.Text = ("Resistance")
                        labelNumbTwo.Visible = True
                        'Button txtboxTwoClear text change'
                        btnTextboxTwoClear.Text = ("CLEAR RESISTANCE")
                        'label answer text and visible change'
                        labelAnswer.Text = ("Current")
                        labelAnswer.Visible = True
                        'Calculate button text change'
                        btnCalculate.Text = ("CALCULATE CURRENT")
                        'Button btnTextboxAnswerClear button'
                        btnTextboxAnswerClear.Text = ("CLEAR CURRENT")

                        'Resistance radiobutton Checked'
                    ElseIf rbResistance.Checked = True Then
                        'Label labelNumbTwo text and visible change'
                        labelNumbTwo.Text = ("Current")
                        labelNumbTwo.Visible = True
                        'Button btnTextboxTwoClear text change'
                        btnTextboxTwoClear.Text = ("CLEAR CURRENT")
                        'Label labelAnswer text change'
                        labelAnswer.Text = ("Resistance")
                        'Button btnCalculate text change'
                        btnCalculate.Text = ("CALCULATE RESISTANCE")
                        'Button btnTextboxAnswerClear text change'
                        btnTextboxAnswerClear.Text = ("CLEAR RESISTANCE")
                    End If
                    'Voltage radiobutton text change'
                ElseIf rbVoltage.Checked = True Then
                    'Label labelEquals visible change'
                    labelEquals.Visible = True
                    'Label labelOperator text and visble change'
                    labelOperator.Text = ("×")
                    labelOperator.Visible = True
                    'Label labelNumbOne text change'
                    labelNumbOne.Text = ("Current")
                    labelNumbOne.Visible = True
                    'Button btnTextboxOneClear text change'
                    btnTextboxOneClear.Text = ("CLEAR CURRENT")
                    'Label labelNumbTwo visible and text change '
                    labelNumbTwo.Text = ("Resistance")
                    labelNumbTwo.Visible = True
                    'Button btnTextboxTwoClear text change'
                    btnTextboxTwoClear.Text = ("CLEAR RESISTANCE")
                    'Label labelAnswer visible and text change'
                    labelAnswer.Text = ("Voltage")
                    labelAnswer.Visible = True
                    'Button btnCalculate visible and text change'
                    btnCalculate.Text = ("CALCULATE VOLTAGE")
                    'Button btnTextboxAnswerClear text change'
                    btnTextboxAnswerClear.Text = ("CLEAR VOLTAGE")
                End If
            End If
        Next
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim ohms As Physics

        ohms = New Physics

        If rbVoltage.Checked Then
            txtBoxAns.Text = ohms.Volts(txtBoxNumOne.Text, txtBoxNumTwo.Text)
        End If

        If rbCurrent.Checked Then
            txtBoxAns.Text = ohms.Current(txtBoxNumOne.Text, txtBoxNumTwo.Text)
        End If

        If rbResistance.Checked Then
            txtBoxAns.Text = ohms.Resistance(txtBoxNumOne.Text, txtBoxNumTwo.Text)
        End If

    End Sub

    Private Sub txtBoxNumOne_TextChanged(sender As Object, e As EventArgs) Handles btnTextboxOneClear.Click
        txtBoxNumOne.Text = ""
    End Sub

    Private Sub btnTextboxTwoClear_Click(sender As Object, e As EventArgs) Handles btnTextboxTwoClear.Click
        txtBoxNumTwo.Text = ""
    End Sub

    Private Sub btnTextboxAnswerClear_Click(sender As Object, e As EventArgs) Handles btnTextboxAnswerClear.Click
        txtBoxAns.Text = ""
    End Sub

    Private Sub btnClearAll_Click(sender As Object, e As EventArgs) Handles btnClearAll.Click
        txtBoxNumOne.Text = ""
        txtBoxNumTwo.Text = ""
        txtBoxAns.Text = ""
    End Sub

End Class
