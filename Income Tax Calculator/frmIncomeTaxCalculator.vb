' Program:      Income Tax Calculator
' Author:       Tu Tong
' Date:         Octocber 15, 2017
' Purpose:      This application calculates and displays 
'               the amount of taxes from annual income.

' Turn on strict type checking,
' to prevent automatic conversion of values

Public Class frmIncomeTaxCalculator

    ' Declar class variable for The FICA tax rate,
    ' Federal tax rate, state income tax rate
    Const _cdecFICATaxRate As Decimal = 0.0765D
    Const _cdecFederalTaxRate As Decimal = 0.22D
    Const _cdecStateTaxRate As Decimal = 0.03D

    Private Sub frmIncomeTaxCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This event handler is executed when the form is loaded.
        ' It displays the tax rate heading, clears the Text property
        ' of the Annual Income Textbox, the Text property of 
        ' all of the tax label objects, and set focus on Annual
        ' income Textbox object.

        lblTaxRates.Text = "The amount of taxes will compute base on FICA tax (" & _cdecFICATaxRate.ToString("P") & "), Federal tax (" & _cdecFederalTaxRate.ToString("P0") & "), and State income tax (" & _cdecStateTaxRate.ToString("P0") & ")."

        txtAnnualIncome.Clear()
        lblFederalTax.Text = ""
        lblFICATax.Text = ""
        lblStateTax.Text = ""
        lblNetPay.Text = ""

        txtAnnualIncome.Focus()

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' This event handler is executed when the user taps or clicks
        ' the Calculate button. It calculates and displays the amount
        ' of taxes and Net pay total.

        ' Declare and initialize the variables
        Dim strAnnualIncome As String
        Dim decAnnualIncome As Decimal
        Dim decFICATax As Decimal
        Dim decFederalTax As Decimal
        Dim decStateTax As Decimal
        Dim decNetPay As Decimal

        ' Placing the annual income in a string var
        ' and convert the value to an integer
        strAnnualIncome = txtAnnualIncome.Text
        decAnnualIncome = Convert.ToDecimal(strAnnualIncome)

        ' Calculate FICA tax
        decFICATax = decAnnualIncome * _cdecFICATaxRate

        ' Calculate Federal tax
        decFederalTax = decAnnualIncome * _cdecFederalTaxRate

        ' Calculate State tax
        decStateTax = decAnnualIncome * _cdecStateTaxRate

        ' Calculate Net pay
        decNetPay = decAnnualIncome - (decFICATax + decFederalTax + decStateTax)

        ' Convert the decimal values to a string currency
        ' and display them on their labels.
        lblFICATax.Text = decFICATax.ToString("C")
        lblFederalTax.Text = decFederalTax.ToString("C")
        lblStateTax.Text = decStateTax.ToString("C")
        lblNetPay.Text = decNetPay.ToString("C")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' This event handler is executed when user taps or clicks
        ' the Clear button. It clears teh number of Annual Income
        ' textbox and labels, and then set the focus on
        ' Annual Income TextBox object.

        txtAnnualIncome.Clear()
        lblFederalTax.Text = ""
        lblFICATax.Text = ""
        lblStateTax.Text = ""
        lblNetPay.Text = ""

        txtAnnualIncome.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' This even handler is executed when user taps or clicks
        ' the Close button. It close the with and terminate the application.

        Close()

    End Sub
End Class
