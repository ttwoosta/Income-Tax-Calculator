<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIncomeTaxCalculator
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
        Me.picIncomeTaxCalculator = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblTaxRates = New System.Windows.Forms.Label()
        Me.lblAnnualIncomeLabel = New System.Windows.Forms.Label()
        Me.txtAnnualIncome = New System.Windows.Forms.TextBox()
        Me.lblFederalTaxLabel = New System.Windows.Forms.Label()
        Me.lblStateTaxLabel = New System.Windows.Forms.Label()
        Me.lblNetPayLabel = New System.Windows.Forms.Label()
        Me.lblFICATaxLabel = New System.Windows.Forms.Label()
        Me.lblFICATax = New System.Windows.Forms.Label()
        Me.lblFederalTax = New System.Windows.Forms.Label()
        Me.lblStateTax = New System.Windows.Forms.Label()
        Me.lblNetPay = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picIncomeTaxCalculator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picIncomeTaxCalculator
        '
        Me.picIncomeTaxCalculator.Image = Global.Income_Tax_Calculator.My.Resources.Resources.income_tax
        Me.picIncomeTaxCalculator.Location = New System.Drawing.Point(34, 62)
        Me.picIncomeTaxCalculator.Name = "picIncomeTaxCalculator"
        Me.picIncomeTaxCalculator.Size = New System.Drawing.Size(229, 220)
        Me.picIncomeTaxCalculator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picIncomeTaxCalculator.TabIndex = 0
        Me.picIncomeTaxCalculator.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(335, 34)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(247, 25)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Income Tax Calculator"
        '
        'lblTaxRates
        '
        Me.lblTaxRates.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaxRates.Location = New System.Drawing.Point(323, 72)
        Me.lblTaxRates.Name = "lblTaxRates"
        Me.lblTaxRates.Size = New System.Drawing.Size(274, 57)
        Me.lblTaxRates.TabIndex = 2
        Me.lblTaxRates.Text = "The amount of taxes will compute base on FICA tax (X.XX%), Federal tax (XX%), and" &
    " State income tax (X%)."
        Me.lblTaxRates.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblAnnualIncomeLabel
        '
        Me.lblAnnualIncomeLabel.AutoSize = True
        Me.lblAnnualIncomeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnnualIncomeLabel.Location = New System.Drawing.Point(356, 154)
        Me.lblAnnualIncomeLabel.Name = "lblAnnualIncomeLabel"
        Me.lblAnnualIncomeLabel.Size = New System.Drawing.Size(99, 16)
        Me.lblAnnualIncomeLabel.TabIndex = 3
        Me.lblAnnualIncomeLabel.Text = "Annual income:"
        '
        'txtAnnualIncome
        '
        Me.txtAnnualIncome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnnualIncome.Location = New System.Drawing.Point(470, 151)
        Me.txtAnnualIncome.Name = "txtAnnualIncome"
        Me.txtAnnualIncome.Size = New System.Drawing.Size(55, 22)
        Me.txtAnnualIncome.TabIndex = 4
        Me.txtAnnualIncome.Text = "888888"
        '
        'lblFederalTaxLabel
        '
        Me.lblFederalTaxLabel.AutoSize = True
        Me.lblFederalTaxLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFederalTaxLabel.Location = New System.Drawing.Point(377, 212)
        Me.lblFederalTaxLabel.Name = "lblFederalTaxLabel"
        Me.lblFederalTaxLabel.Size = New System.Drawing.Size(78, 16)
        Me.lblFederalTaxLabel.TabIndex = 5
        Me.lblFederalTaxLabel.Text = "Federal tax:"
        '
        'lblStateTaxLabel
        '
        Me.lblStateTaxLabel.AutoSize = True
        Me.lblStateTaxLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStateTaxLabel.Location = New System.Drawing.Point(393, 241)
        Me.lblStateTaxLabel.Name = "lblStateTaxLabel"
        Me.lblStateTaxLabel.Size = New System.Drawing.Size(62, 16)
        Me.lblStateTaxLabel.TabIndex = 6
        Me.lblStateTaxLabel.Text = "State tax:"
        '
        'lblNetPayLabel
        '
        Me.lblNetPayLabel.AutoSize = True
        Me.lblNetPayLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetPayLabel.Location = New System.Drawing.Point(397, 270)
        Me.lblNetPayLabel.Name = "lblNetPayLabel"
        Me.lblNetPayLabel.Size = New System.Drawing.Size(58, 16)
        Me.lblNetPayLabel.TabIndex = 7
        Me.lblNetPayLabel.Text = "Net pay:"
        '
        'lblFICATaxLabel
        '
        Me.lblFICATaxLabel.AutoSize = True
        Me.lblFICATaxLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFICATaxLabel.Location = New System.Drawing.Point(395, 183)
        Me.lblFICATaxLabel.Name = "lblFICATaxLabel"
        Me.lblFICATaxLabel.Size = New System.Drawing.Size(60, 16)
        Me.lblFICATaxLabel.TabIndex = 8
        Me.lblFICATaxLabel.Text = "FICA tax:"
        '
        'lblFICATax
        '
        Me.lblFICATax.AutoSize = True
        Me.lblFICATax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFICATax.Location = New System.Drawing.Point(467, 183)
        Me.lblFICATax.Name = "lblFICATax"
        Me.lblFICATax.Size = New System.Drawing.Size(63, 16)
        Me.lblFICATax.TabIndex = 9
        Me.lblFICATax.Text = "$8,888.88"
        '
        'lblFederalTax
        '
        Me.lblFederalTax.AutoSize = True
        Me.lblFederalTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFederalTax.Location = New System.Drawing.Point(467, 212)
        Me.lblFederalTax.Name = "lblFederalTax"
        Me.lblFederalTax.Size = New System.Drawing.Size(63, 16)
        Me.lblFederalTax.TabIndex = 10
        Me.lblFederalTax.Text = "$8,888.88"
        '
        'lblStateTax
        '
        Me.lblStateTax.AutoSize = True
        Me.lblStateTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStateTax.Location = New System.Drawing.Point(467, 241)
        Me.lblStateTax.Name = "lblStateTax"
        Me.lblStateTax.Size = New System.Drawing.Size(63, 16)
        Me.lblStateTax.TabIndex = 11
        Me.lblStateTax.Text = "$8,888.88"
        '
        'lblNetPay
        '
        Me.lblNetPay.AutoSize = True
        Me.lblNetPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetPay.Location = New System.Drawing.Point(467, 270)
        Me.lblNetPay.Name = "lblNetPay"
        Me.lblNetPay.Size = New System.Drawing.Size(63, 16)
        Me.lblNetPay.TabIndex = 12
        Me.lblNetPay.Text = "$8,888.88"
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.CadetBlue
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(332, 315)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(81, 23)
        Me.btnCalculate.TabIndex = 13
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.CadetBlue
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(424, 315)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(81, 23)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.CadetBlue
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(516, 315)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(81, 23)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmIncomeTaxCalculator
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(644, 361)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblNetPay)
        Me.Controls.Add(Me.lblStateTax)
        Me.Controls.Add(Me.lblFederalTax)
        Me.Controls.Add(Me.lblFICATax)
        Me.Controls.Add(Me.lblFICATaxLabel)
        Me.Controls.Add(Me.lblNetPayLabel)
        Me.Controls.Add(Me.lblStateTaxLabel)
        Me.Controls.Add(Me.lblFederalTaxLabel)
        Me.Controls.Add(Me.txtAnnualIncome)
        Me.Controls.Add(Me.lblAnnualIncomeLabel)
        Me.Controls.Add(Me.lblTaxRates)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picIncomeTaxCalculator)
        Me.Name = "frmIncomeTaxCalculator"
        Me.Text = "Income Tax Calculator"
        CType(Me.picIncomeTaxCalculator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picIncomeTaxCalculator As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblTaxRates As Label
    Friend WithEvents lblAnnualIncomeLabel As Label
    Friend WithEvents txtAnnualIncome As TextBox
    Friend WithEvents lblFederalTaxLabel As Label
    Friend WithEvents lblStateTaxLabel As Label
    Friend WithEvents lblNetPayLabel As Label
    Friend WithEvents lblFICATaxLabel As Label
    Friend WithEvents lblFICATax As Label
    Friend WithEvents lblFederalTax As Label
    Friend WithEvents lblStateTax As Label
    Friend WithEvents lblNetPay As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
