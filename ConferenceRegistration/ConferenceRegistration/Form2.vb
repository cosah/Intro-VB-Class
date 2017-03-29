Public Class frmConfOptions

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        resetfrm()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If (chkConfReg.Checked <> True) And (chkDiner.Checked Or lstWorkshops.SelectedItems.Count > 0) Then
            resetfrm()
            MsgBox("You must register for the main event to attend optional events", , "Registration Error")
        ElseIf chkConfReg.Checked Then
            getTotal(chkDiner.Checked, lstWorkshops.SelectedIndex)
            Me.Close()
        Else
            MsgBox("Event registration failed: Not registered for main event.", , "Registration Error")
            Me.Close()
        End If

    End Sub

    Private Sub resetfrm()
        chkConfReg.Checked = False
        chkDiner.Checked = False
        lstWorkshops.ClearSelected()
    End Sub

End Class