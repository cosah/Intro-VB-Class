Public Class frmConfReg

    Private Sub btnSelectConf_Click(sender As Object, e As EventArgs) Handles btnSelectConf.Click
        Dim frmOptions As New frmConfOptions
        frmOptions.ShowDialog()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        For Each ctrl In Me.grpRegistrant.Controls
            If (ctrl.GetType() Is GetType(TextBox)) Then
                ctrl.Text = ""
            End If
        Next
        txtTotal.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class
