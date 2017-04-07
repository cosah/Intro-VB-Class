<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLargeSmall
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
        Me.btnInput = New System.Windows.Forms.Button()
        Me.btnMinMax = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lstValues = New System.Windows.Forms.ListBox()
        Me.lblMinMax = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnInput
        '
        Me.btnInput.Location = New System.Drawing.Point(13, 13)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(155, 25)
        Me.btnInput.TabIndex = 0
        Me.btnInput.Text = "Step 1: Input the Integers"
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'btnMinMax
        '
        Me.btnMinMax.Location = New System.Drawing.Point(13, 44)
        Me.btnMinMax.Name = "btnMinMax"
        Me.btnMinMax.Size = New System.Drawing.Size(155, 25)
        Me.btnMinMax.TabIndex = 1
        Me.btnMinMax.Text = "Step 2: Display Min and Max"
        Me.btnMinMax.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(13, 75)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 25)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lstValues
        '
        Me.lstValues.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstValues.ColumnWidth = 50
        Me.lstValues.FormattingEnabled = True
        Me.lstValues.Location = New System.Drawing.Point(175, 13)
        Me.lstValues.MultiColumn = True
        Me.lstValues.Name = "lstValues"
        Me.lstValues.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lstValues.Size = New System.Drawing.Size(107, 65)
        Me.lstValues.TabIndex = 3
        '
        'lblMinMax
        '
        Me.lblMinMax.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblMinMax.AutoSize = True
        Me.lblMinMax.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblMinMax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMinMax.Location = New System.Drawing.Point(175, 85)
        Me.lblMinMax.MinimumSize = New System.Drawing.Size(107, 20)
        Me.lblMinMax.Name = "lblMinMax"
        Me.lblMinMax.Size = New System.Drawing.Size(107, 20)
        Me.lblMinMax.TabIndex = 4
        '
        'frmLargeSmall
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(295, 115)
        Me.Controls.Add(Me.lblMinMax)
        Me.Controls.Add(Me.lstValues)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnMinMax)
        Me.Controls.Add(Me.btnInput)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLargeSmall"
        Me.Text = "Largest / Smallest Values"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnInput As Button
    Friend WithEvents btnMinMax As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lstValues As ListBox
    Friend WithEvents lblMinMax As Label
End Class
