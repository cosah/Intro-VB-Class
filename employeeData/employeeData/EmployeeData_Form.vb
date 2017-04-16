Imports System.IO
Public Class frmEmployeeData
    Dim fileName As String
    Dim empReg As StreamWriter
    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Close()
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Clear()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If File.Exists(fileName) Then
            empReg = File.AppendText(fileName)
        Else
            empReg = File.CreateText(fileName)
        End If
        For Each ctrl In Me.grpEmployeeData.Controls
            If (ctrl.GetType() Is GetType(TextBox) Or ctrl.GetType() Is GetType(ComboBox)) Then
                empReg.WriteLine(ctrl.Text)
            End If
        Next
        empReg.Close()
        MsgBox("Saved")
        Clear()
    End Sub
    Private Sub frmEmployeeData_Load(sender As Object, e As EventArgs) Handles Me.Shown
        fileName = InputBox("Enter new or existing employee registry filename", "Enter Filename", "Employees.txt")
    End Sub
    Private Sub Clear()
        For Each ctrl In Me.grpEmployeeData.Controls
            If (ctrl.GetType() Is GetType(TextBox)) Then
                ctrl.Text = ""
            End If
        Next
        cmbDepartment.SelectedIndex = -1
    End Sub
End Class
