<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfOptions
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
        Me.grpConf = New System.Windows.Forms.GroupBox()
        Me.chkDiner = New System.Windows.Forms.CheckBox()
        Me.chkConfReg = New System.Windows.Forms.CheckBox()
        Me.grpWorkshops = New System.Windows.Forms.GroupBox()
        Me.lblSelectOne = New System.Windows.Forms.Label()
        Me.lstWorkshops = New System.Windows.Forms.ListBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.grpConf.SuspendLayout()
        Me.grpWorkshops.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpConf
        '
        Me.grpConf.Controls.Add(Me.chkDiner)
        Me.grpConf.Controls.Add(Me.chkConfReg)
        Me.grpConf.Location = New System.Drawing.Point(13, 13)
        Me.grpConf.Name = "grpConf"
        Me.grpConf.Size = New System.Drawing.Size(217, 96)
        Me.grpConf.TabIndex = 0
        Me.grpConf.TabStop = False
        Me.grpConf.Text = "Conference"
        '
        'chkDiner
        '
        Me.chkDiner.AutoSize = True
        Me.chkDiner.Location = New System.Drawing.Point(7, 62)
        Me.chkDiner.Name = "chkDiner"
        Me.chkDiner.Size = New System.Drawing.Size(203, 17)
        Me.chkDiner.TabIndex = 1
        Me.chkDiner.Text = "Opening Night Dinner && Keynote: $30"
        Me.chkDiner.UseVisualStyleBackColor = True
        '
        'chkConfReg
        '
        Me.chkConfReg.AutoSize = True
        Me.chkConfReg.Checked = True
        Me.chkConfReg.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkConfReg.Location = New System.Drawing.Point(7, 23)
        Me.chkConfReg.Name = "chkConfReg"
        Me.chkConfReg.Size = New System.Drawing.Size(170, 17)
        Me.chkConfReg.TabIndex = 0
        Me.chkConfReg.Text = "Conference Registration: $895"
        Me.chkConfReg.UseVisualStyleBackColor = True
        '
        'grpWorkshops
        '
        Me.grpWorkshops.Controls.Add(Me.lblSelectOne)
        Me.grpWorkshops.Controls.Add(Me.lstWorkshops)
        Me.grpWorkshops.Location = New System.Drawing.Point(237, 13)
        Me.grpWorkshops.Name = "grpWorkshops"
        Me.grpWorkshops.Size = New System.Drawing.Size(163, 96)
        Me.grpWorkshops.TabIndex = 1
        Me.grpWorkshops.TabStop = False
        Me.grpWorkshops.Text = "Preconference Workshops"
        '
        'lblSelectOne
        '
        Me.lblSelectOne.AutoSize = True
        Me.lblSelectOne.BackColor = System.Drawing.Color.Transparent
        Me.lblSelectOne.Location = New System.Drawing.Point(10, 16)
        Me.lblSelectOne.Name = "lblSelectOne"
        Me.lblSelectOne.Size = New System.Drawing.Size(60, 13)
        Me.lblSelectOne.TabIndex = 1
        Me.lblSelectOne.Text = "Select One"
        '
        'lstWorkshops
        '
        Me.lstWorkshops.FormattingEnabled = True
        Me.lstWorkshops.Items.AddRange(New Object() {"Intro to E-commerce", "The Future of the Web", "Advanced Visual Basic", "Network Security"})
        Me.lstWorkshops.Location = New System.Drawing.Point(7, 30)
        Me.lstWorkshops.Name = "lstWorkshops"
        Me.lstWorkshops.Size = New System.Drawing.Size(150, 56)
        Me.lstWorkshops.TabIndex = 0
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(20, 115)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 2
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(319, 115)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 3
        Me.btnSubmit.Text = "&Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'frmConfOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(412, 147)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.grpWorkshops)
        Me.Controls.Add(Me.grpConf)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConfOptions"
        Me.Text = "Conference Options"
        Me.grpConf.ResumeLayout(False)
        Me.grpConf.PerformLayout()
        Me.grpWorkshops.ResumeLayout(False)
        Me.grpWorkshops.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpConf As GroupBox
    Friend WithEvents chkDiner As CheckBox
    Friend WithEvents chkConfReg As CheckBox
    Friend WithEvents grpWorkshops As GroupBox
    Friend WithEvents lstWorkshops As ListBox
    Friend WithEvents btnReset As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblSelectOne As Label
End Class
