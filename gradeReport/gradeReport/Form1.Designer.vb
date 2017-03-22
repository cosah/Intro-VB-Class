<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGradeReport
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
        Me.lstGrades = New System.Windows.Forms.ListBox()
        Me.btnEnterData = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstGrades
        '
        Me.lstGrades.Enabled = False
        Me.lstGrades.FormattingEnabled = True
        Me.lstGrades.Location = New System.Drawing.Point(13, 13)
        Me.lstGrades.Name = "lstGrades"
        Me.lstGrades.Size = New System.Drawing.Size(400, 121)
        Me.lstGrades.TabIndex = 0
        '
        'btnEnterData
        '
        Me.btnEnterData.Location = New System.Drawing.Point(13, 141)
        Me.btnEnterData.Name = "btnEnterData"
        Me.btnEnterData.Size = New System.Drawing.Size(75, 23)
        Me.btnEnterData.TabIndex = 1
        Me.btnEnterData.Text = "Enter Data"
        Me.btnEnterData.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(338, 141)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmGradeReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 173)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnEnterData)
        Me.Controls.Add(Me.lstGrades)
        Me.Name = "frmGradeReport"
        Me.Text = "Grade Report"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstGrades As ListBox
    Friend WithEvents btnEnterData As Button
    Friend WithEvents btnExit As Button
End Class
