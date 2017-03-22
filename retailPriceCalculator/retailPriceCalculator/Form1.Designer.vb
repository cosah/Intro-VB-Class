<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRetailPriceCalc
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
        Me.txtWholesaleCost = New System.Windows.Forms.TextBox()
        Me.txtMarkup = New System.Windows.Forms.TextBox()
        Me.txtRetailPrice = New System.Windows.Forms.TextBox()
        Me.lblWholesaleCost = New System.Windows.Forms.Label()
        Me.lblMarkup = New System.Windows.Forms.Label()
        Me.lblRetailPrice = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtWholesaleCost
        '
        Me.txtWholesaleCost.Location = New System.Drawing.Point(135, 13)
        Me.txtWholesaleCost.Name = "txtWholesaleCost"
        Me.txtWholesaleCost.Size = New System.Drawing.Size(100, 20)
        Me.txtWholesaleCost.TabIndex = 0
        '
        'txtMarkup
        '
        Me.txtMarkup.Location = New System.Drawing.Point(135, 40)
        Me.txtMarkup.Name = "txtMarkup"
        Me.txtMarkup.Size = New System.Drawing.Size(100, 20)
        Me.txtMarkup.TabIndex = 1
        '
        'txtRetailPrice
        '
        Me.txtRetailPrice.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtRetailPrice.Enabled = False
        Me.txtRetailPrice.Location = New System.Drawing.Point(135, 67)
        Me.txtRetailPrice.Name = "txtRetailPrice"
        Me.txtRetailPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtRetailPrice.TabIndex = 2
        '
        'lblWholesaleCost
        '
        Me.lblWholesaleCost.AutoSize = True
        Me.lblWholesaleCost.Location = New System.Drawing.Point(13, 16)
        Me.lblWholesaleCost.Name = "lblWholesaleCost"
        Me.lblWholesaleCost.Size = New System.Drawing.Size(116, 13)
        Me.lblWholesaleCost.TabIndex = 3
        Me.lblWholesaleCost.Text = "Wholesale Cost of Item"
        '
        'lblMarkup
        '
        Me.lblMarkup.AutoSize = True
        Me.lblMarkup.Location = New System.Drawing.Point(75, 43)
        Me.lblMarkup.Name = "lblMarkup"
        Me.lblMarkup.Size = New System.Drawing.Size(54, 13)
        Me.lblMarkup.TabIndex = 4
        Me.lblMarkup.Text = "Markup %"
        '
        'lblRetailPrice
        '
        Me.lblRetailPrice.AutoSize = True
        Me.lblRetailPrice.Location = New System.Drawing.Point(68, 70)
        Me.lblRetailPrice.Name = "lblRetailPrice"
        Me.lblRetailPrice.Size = New System.Drawing.Size(61, 13)
        Me.lblRetailPrice.TabIndex = 5
        Me.lblRetailPrice.Text = "Retail Price"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(34, 100)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(80, 40)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Get Retail"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(143, 100)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(80, 40)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmRetailPriceCalc
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(257, 153)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblRetailPrice)
        Me.Controls.Add(Me.lblMarkup)
        Me.Controls.Add(Me.lblWholesaleCost)
        Me.Controls.Add(Me.txtRetailPrice)
        Me.Controls.Add(Me.txtMarkup)
        Me.Controls.Add(Me.txtWholesaleCost)
        Me.Name = "frmRetailPriceCalc"
        Me.Text = "Retail Price Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtWholesaleCost As TextBox
    Friend WithEvents txtMarkup As TextBox
    Friend WithEvents txtRetailPrice As TextBox
    Friend WithEvents lblWholesaleCost As Label
    Friend WithEvents lblMarkup As Label
    Friend WithEvents lblRetailPrice As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
End Class
