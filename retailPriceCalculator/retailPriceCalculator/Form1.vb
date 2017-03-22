Public Class frmRetailPriceCalc
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        If ValInput() Then
            Dim Markup As Decimal = txtMarkup.Text
            Dim Cost As Decimal = txtWholesaleCost.Text
            txtRetailPrice.Text = CalcPrice(Markup, Cost).ToString("c")
        End If
    End Sub

    Function ValInput() As Boolean
        Try
            Dim Markup As Decimal = txtMarkup.Text
            Dim Cost As Decimal = txtWholesaleCost.Text
            If Cost < 0 Then
                Return False
            End If
            Return True
        Catch
            MsgBox("Numeric values please. Price must be greater than zero.", , "Input Error")
            Dim number As Decimal
            If Decimal.TryParse(txtMarkup.Text, number) <> True Then
                txtMarkup.Text = ""
                txtMarkup.Select()
            End If
            If Decimal.TryParse(txtWholesaleCost.Text, number) <> True Then
                txtWholesaleCost.Text = ""
                txtWholesaleCost.Select()
            End If
            txtRetailPrice.Text = ""
            Return False
        End Try
    End Function

    Function CalcPrice(ByVal Val1, ByVal Val2) As Decimal
        Dim Price As Decimal = Val2 + ((Val1 / 100) * Val2)
        Return Price
    End Function
End Class
