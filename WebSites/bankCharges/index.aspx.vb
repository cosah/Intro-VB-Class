
Partial Class index
    Inherits System.Web.UI.Page

    Protected Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try
            lblStatus.Visible = False
            Dim intChecks As Integer = CInt(txtChecks.Text)
            Dim decRate As Decimal = 0
            If intChecks < 0 Then
                lblStatus.Text = "Enter a non-negative integer for number of checks."
                lblStatus.Visible = True
            Else
                Select Case intChecks
                    Case 0 To 19
                        decRate = 0.1
                    Case 20 To 39
                        decRate = 0.08
                    Case 40 To 59
                        decRate = 0.06
                    Case Is >= 60
                        decRate = 0.04
                End Select
                txtCheckFees.Text = (decRate * intChecks).ToString("c")
                txtTotalFees.Text = (decRate * intChecks + 10).ToString("c")
            End If
        Catch
            lblStatus.Text = "Enter a valid integer for number of checks."
            lblStatus.Visible = True
        End Try
    End Sub
    Protected Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtChecks.Text = String.Empty
        txtCheckFees.Text = String.Empty
        txtTotalFees.Text = String.Empty
        lblStatus.Visible = False
    End Sub
End Class
