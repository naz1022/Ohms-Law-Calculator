<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OhmsLaw
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.rbVoltage = New System.Windows.Forms.RadioButton()
        Me.rbCurrent = New System.Windows.Forms.RadioButton()
        Me.rbResistance = New System.Windows.Forms.RadioButton()
        Me.txtBoxNumOne = New System.Windows.Forms.TextBox()
        Me.txtBoxNumTwo = New System.Windows.Forms.TextBox()
        Me.txtBoxAns = New System.Windows.Forms.TextBox()
        Me.labelEquals = New System.Windows.Forms.Label()
        Me.labelOperator = New System.Windows.Forms.Label()
        Me.labelAnswer = New System.Windows.Forms.Label()
        Me.labelNumbTwo = New System.Windows.Forms.Label()
        Me.labelNumbOne = New System.Windows.Forms.Label()
        Me.btnTextboxOneClear = New System.Windows.Forms.Button()
        Me.btnTextboxTwoClear = New System.Windows.Forms.Button()
        Me.btnTextboxAnswerClear = New System.Windows.Forms.Button()
        Me.btnClearAll = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnCalculate.Location = New System.Drawing.Point(16, 91)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(364, 80)
        Me.btnCalculate.TabIndex = 9
        Me.btnCalculate.Text = "CALCULATE"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'rbVoltage
        '
        Me.rbVoltage.AutoSize = True
        Me.rbVoltage.Location = New System.Drawing.Point(30, 22)
        Me.rbVoltage.Name = "rbVoltage"
        Me.rbVoltage.Size = New System.Drawing.Size(77, 17)
        Me.rbVoltage.TabIndex = 13
        Me.rbVoltage.TabStop = True
        Me.rbVoltage.Text = "Voltage (V)"
        Me.rbVoltage.UseVisualStyleBackColor = False
        '
        'rbCurrent
        '
        Me.rbCurrent.AutoSize = True
        Me.rbCurrent.Location = New System.Drawing.Point(161, 22)
        Me.rbCurrent.Name = "rbCurrent"
        Me.rbCurrent.Size = New System.Drawing.Size(71, 17)
        Me.rbCurrent.TabIndex = 14
        Me.rbCurrent.TabStop = True
        Me.rbCurrent.Text = "Current (I)"
        Me.rbCurrent.UseVisualStyleBackColor = True
        '
        'rbResistance
        '
        Me.rbResistance.AutoSize = True
        Me.rbResistance.Location = New System.Drawing.Point(285, 22)
        Me.rbResistance.Name = "rbResistance"
        Me.rbResistance.Size = New System.Drawing.Size(95, 17)
        Me.rbResistance.TabIndex = 15
        Me.rbResistance.TabStop = True
        Me.rbResistance.Text = "Resistance (R)"
        Me.rbResistance.UseVisualStyleBackColor = True
        '
        'txtBoxNumOne
        '
        Me.txtBoxNumOne.Location = New System.Drawing.Point(16, 65)
        Me.txtBoxNumOne.Name = "txtBoxNumOne"
        Me.txtBoxNumOne.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxNumOne.TabIndex = 16
        Me.txtBoxNumOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtBoxNumTwo
        '
        Me.txtBoxNumTwo.Location = New System.Drawing.Point(150, 65)
        Me.txtBoxNumTwo.Name = "txtBoxNumTwo"
        Me.txtBoxNumTwo.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxNumTwo.TabIndex = 17
        Me.txtBoxNumTwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtBoxAns
        '
        Me.txtBoxAns.Enabled = False
        Me.txtBoxAns.Location = New System.Drawing.Point(281, 66)
        Me.txtBoxAns.Name = "txtBoxAns"
        Me.txtBoxAns.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxAns.TabIndex = 18
        Me.txtBoxAns.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'labelEquals
        '
        Me.labelEquals.AutoSize = True
        Me.labelEquals.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.labelEquals.Location = New System.Drawing.Point(262, 69)
        Me.labelEquals.Name = "labelEquals"
        Me.labelEquals.Size = New System.Drawing.Size(15, 16)
        Me.labelEquals.TabIndex = 20
        Me.labelEquals.Text = "="
        Me.labelEquals.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.labelEquals.Visible = False
        '
        'labelOperator
        '
        Me.labelOperator.AutoSize = True
        Me.labelOperator.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.labelOperator.Location = New System.Drawing.Point(127, 66)
        Me.labelOperator.Name = "labelOperator"
        Me.labelOperator.Size = New System.Drawing.Size(62, 17)
        Me.labelOperator.TabIndex = 21
        Me.labelOperator.Text = "operator"
        Me.labelOperator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.labelOperator.Visible = False
        '
        'labelAnswer
        '
        Me.labelAnswer.AutoSize = True
        Me.labelAnswer.Location = New System.Drawing.Point(282, 50)
        Me.labelAnswer.Name = "labelAnswer"
        Me.labelAnswer.Size = New System.Drawing.Size(42, 13)
        Me.labelAnswer.TabIndex = 25
        Me.labelAnswer.Text = "Answer"
        Me.labelAnswer.Visible = False
        '
        'labelNumbTwo
        '
        Me.labelNumbTwo.AutoSize = True
        Me.labelNumbTwo.Location = New System.Drawing.Point(147, 50)
        Me.labelNumbTwo.Name = "labelNumbTwo"
        Me.labelNumbTwo.Size = New System.Drawing.Size(53, 13)
        Me.labelNumbTwo.TabIndex = 26
        Me.labelNumbTwo.Text = "Number 2"
        Me.labelNumbTwo.Visible = False
        '
        'labelNumbOne
        '
        Me.labelNumbOne.AutoSize = True
        Me.labelNumbOne.Location = New System.Drawing.Point(13, 50)
        Me.labelNumbOne.Name = "labelNumbOne"
        Me.labelNumbOne.Size = New System.Drawing.Size(53, 13)
        Me.labelNumbOne.TabIndex = 27
        Me.labelNumbOne.Text = "Number 1"
        Me.labelNumbOne.Visible = False
        '
        'btnTextboxOneClear
        '
        Me.btnTextboxOneClear.Location = New System.Drawing.Point(16, 192)
        Me.btnTextboxOneClear.Name = "btnTextboxOneClear"
        Me.btnTextboxOneClear.Size = New System.Drawing.Size(85, 60)
        Me.btnTextboxOneClear.TabIndex = 28
        Me.btnTextboxOneClear.Text = "Clear Textbox One"
        Me.btnTextboxOneClear.UseVisualStyleBackColor = True
        '
        'btnTextboxTwoClear
        '
        Me.btnTextboxTwoClear.Location = New System.Drawing.Point(107, 192)
        Me.btnTextboxTwoClear.Name = "btnTextboxTwoClear"
        Me.btnTextboxTwoClear.Size = New System.Drawing.Size(85, 60)
        Me.btnTextboxTwoClear.TabIndex = 29
        Me.btnTextboxTwoClear.Text = "Clear Textbox Two"
        Me.btnTextboxTwoClear.UseVisualStyleBackColor = True
        '
        'btnTextboxAnswerClear
        '
        Me.btnTextboxAnswerClear.Location = New System.Drawing.Point(204, 192)
        Me.btnTextboxAnswerClear.Name = "btnTextboxAnswerClear"
        Me.btnTextboxAnswerClear.Size = New System.Drawing.Size(85, 60)
        Me.btnTextboxAnswerClear.TabIndex = 30
        Me.btnTextboxAnswerClear.Text = "Clear Textbox Answer"
        Me.btnTextboxAnswerClear.UseVisualStyleBackColor = True
        '
        'btnClearAll
        '
        Me.btnClearAll.Location = New System.Drawing.Point(295, 192)
        Me.btnClearAll.Name = "btnClearAll"
        Me.btnClearAll.Size = New System.Drawing.Size(85, 60)
        Me.btnClearAll.TabIndex = 31
        Me.btnClearAll.Text = "CLEAR ALL"
        Me.btnClearAll.UseVisualStyleBackColor = True
        '
        'OhmsLaw
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(398, 256)
        Me.Controls.Add(Me.btnClearAll)
        Me.Controls.Add(Me.btnTextboxAnswerClear)
        Me.Controls.Add(Me.btnTextboxTwoClear)
        Me.Controls.Add(Me.btnTextboxOneClear)
        Me.Controls.Add(Me.labelNumbOne)
        Me.Controls.Add(Me.labelNumbTwo)
        Me.Controls.Add(Me.labelAnswer)
        Me.Controls.Add(Me.labelOperator)
        Me.Controls.Add(Me.labelEquals)
        Me.Controls.Add(Me.txtBoxAns)
        Me.Controls.Add(Me.txtBoxNumTwo)
        Me.Controls.Add(Me.txtBoxNumOne)
        Me.Controls.Add(Me.rbResistance)
        Me.Controls.Add(Me.rbCurrent)
        Me.Controls.Add(Me.rbVoltage)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "OhmsLaw"
        Me.Text = "Ohms Law Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCalculate As Button
    Friend WithEvents rbVoltage As RadioButton
    Friend WithEvents rbCurrent As RadioButton
    Friend WithEvents rbResistance As RadioButton
    Friend WithEvents txtBoxNumOne As TextBox
    Friend WithEvents labelEquals As Label
    Friend WithEvents labelOperator As Label
    Friend WithEvents labelAnswer As Label
    Friend WithEvents labelNumbTwo As Label
    Friend WithEvents labelNumbOne As Label
    Public WithEvents txtBoxAns As TextBox
    Public WithEvents txtBoxNumTwo As TextBox
    Friend WithEvents btnTextboxOneClear As Button
    Friend WithEvents btnTextboxTwoClear As Button
    Friend WithEvents btnTextboxAnswerClear As Button
    Friend WithEvents btnClearAll As Button
End Class
