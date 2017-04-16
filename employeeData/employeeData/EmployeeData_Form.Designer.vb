<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployeeData
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
        Me.grpEmployeeData = New System.Windows.Forms.GroupBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblExtension = New System.Windows.Forms.Label()
        Me.lblTelephone = New System.Windows.Forms.Label()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.lblEmployeeNumber = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblMiddleName = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtEmailAddress = New System.Windows.Forms.TextBox()
        Me.txtExtension = New System.Windows.Forms.TextBox()
        Me.txtTelephone = New System.Windows.Forms.TextBox()
        Me.cmbDepartment = New System.Windows.Forms.ComboBox()
        Me.txtEmployeeNumber = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtMiddleName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.grpEmployeeData.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpEmployeeData
        '
        Me.grpEmployeeData.Controls.Add(Me.txtFirstName)
        Me.grpEmployeeData.Controls.Add(Me.txtMiddleName)
        Me.grpEmployeeData.Controls.Add(Me.txtLastName)
        Me.grpEmployeeData.Controls.Add(Me.txtEmployeeNumber)
        Me.grpEmployeeData.Controls.Add(Me.cmbDepartment)
        Me.grpEmployeeData.Controls.Add(Me.txtTelephone)
        Me.grpEmployeeData.Controls.Add(Me.txtExtension)
        Me.grpEmployeeData.Controls.Add(Me.txtEmailAddress)
        Me.grpEmployeeData.Controls.Add(Me.lblFirstName)
        Me.grpEmployeeData.Controls.Add(Me.lblMiddleName)
        Me.grpEmployeeData.Controls.Add(Me.lblLastName)
        Me.grpEmployeeData.Controls.Add(Me.lblEmployeeNumber)
        Me.grpEmployeeData.Controls.Add(Me.lblDepartment)
        Me.grpEmployeeData.Controls.Add(Me.lblTelephone)
        Me.grpEmployeeData.Controls.Add(Me.lblExtension)
        Me.grpEmployeeData.Controls.Add(Me.lblEmail)

        Me.grpEmployeeData.Location = New System.Drawing.Point(13, 13)
        Me.grpEmployeeData.Name = "grpEmployeeData"
        Me.grpEmployeeData.Size = New System.Drawing.Size(248, 243)
        Me.grpEmployeeData.TabIndex = 0
        Me.grpEmployeeData.TabStop = False
        Me.grpEmployeeData.Text = "Enter Employee Data"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(28, 214)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(76, 13)
        Me.lblEmail.TabIndex = 15
        Me.lblEmail.Text = "E-mail Address"
        '
        'lblExtension
        '
        Me.lblExtension.AutoSize = True
        Me.lblExtension.Location = New System.Drawing.Point(51, 187)
        Me.lblExtension.Name = "lblExtension"
        Me.lblExtension.Size = New System.Drawing.Size(53, 13)
        Me.lblExtension.TabIndex = 14
        Me.lblExtension.Text = "Extension"
        '
        'lblTelephone
        '
        Me.lblTelephone.AutoSize = True
        Me.lblTelephone.Location = New System.Drawing.Point(46, 160)
        Me.lblTelephone.Name = "lblTelephone"
        Me.lblTelephone.Size = New System.Drawing.Size(58, 13)
        Me.lblTelephone.TabIndex = 13
        Me.lblTelephone.Text = "Telephone"
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Location = New System.Drawing.Point(42, 132)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(62, 13)
        Me.lblDepartment.TabIndex = 12
        Me.lblDepartment.Text = "Department"
        '
        'lblEmployeeNumber
        '
        Me.lblEmployeeNumber.AutoSize = True
        Me.lblEmployeeNumber.Location = New System.Drawing.Point(11, 105)
        Me.lblEmployeeNumber.Name = "lblEmployeeNumber"
        Me.lblEmployeeNumber.Size = New System.Drawing.Size(93, 13)
        Me.lblEmployeeNumber.TabIndex = 11
        Me.lblEmployeeNumber.Text = "Employee Number"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(46, 78)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(58, 13)
        Me.lblLastName.TabIndex = 10
        Me.lblLastName.Text = "Last Name"
        '
        'lblMiddleName
        '
        Me.lblMiddleName.AutoSize = True
        Me.lblMiddleName.Location = New System.Drawing.Point(35, 51)
        Me.lblMiddleName.Name = "lblMiddleName"
        Me.lblMiddleName.Size = New System.Drawing.Size(69, 13)
        Me.lblMiddleName.TabIndex = 9
        Me.lblMiddleName.Text = "Middle Name"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(47, 24)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(57, 13)
        Me.lblFirstName.TabIndex = 8
        Me.lblFirstName.Text = "First Name"
        '
        'txtEmailAddress
        '
        Me.txtEmailAddress.Location = New System.Drawing.Point(107, 210)
        Me.txtEmailAddress.Name = "txtEmailAddress"
        Me.txtEmailAddress.Size = New System.Drawing.Size(121, 20)
        Me.txtEmailAddress.TabIndex = 7
        '
        'txtExtension
        '
        Me.txtExtension.Location = New System.Drawing.Point(107, 183)
        Me.txtExtension.Name = "txtExtension"
        Me.txtExtension.Size = New System.Drawing.Size(121, 20)
        Me.txtExtension.TabIndex = 6
        '
        'txtTelephone
        '
        Me.txtTelephone.Location = New System.Drawing.Point(107, 156)
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.Size = New System.Drawing.Size(121, 20)
        Me.txtTelephone.TabIndex = 5
        '
        'cmbDepartment
        '
        Me.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDepartment.FormattingEnabled = True
        Me.cmbDepartment.Items.AddRange(New Object() {"Accounting", "Administration", "Marketing", "MIS", "Sales"})
        Me.cmbDepartment.Location = New System.Drawing.Point(107, 128)
        Me.cmbDepartment.Name = "cmbDepartment"
        Me.cmbDepartment.Size = New System.Drawing.Size(121, 21)
        Me.cmbDepartment.TabIndex = 4
        '
        'txtEmployeeNumber
        '
        Me.txtEmployeeNumber.Location = New System.Drawing.Point(107, 101)
        Me.txtEmployeeNumber.Name = "txtEmployeeNumber"
        Me.txtEmployeeNumber.Size = New System.Drawing.Size(121, 20)
        Me.txtEmployeeNumber.TabIndex = 3
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(107, 74)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(121, 20)
        Me.txtLastName.TabIndex = 2
        '
        'txtMiddleName
        '
        Me.txtMiddleName.Location = New System.Drawing.Point(107, 47)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(121, 20)
        Me.txtMiddleName.TabIndex = 1
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(107, 20)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(121, 20)
        Me.txtFirstName.TabIndex = 0
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(46, 265)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(85, 30)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "&Save Record"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(143, 265)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(85, 30)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(95, 301)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(85, 30)
        Me.btnQuit.TabIndex = 3
        Me.btnQuit.Text = "&Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'frmEmployeeData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(274, 342)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.grpEmployeeData)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmEmployeeData"
        Me.Text = "Employee Data"
        Me.grpEmployeeData.ResumeLayout(False)
        Me.grpEmployeeData.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpEmployeeData As GroupBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblExtension As Label
    Friend WithEvents lblTelephone As Label
    Friend WithEvents lblDepartment As Label
    Friend WithEvents lblEmployeeNumber As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblMiddleName As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtEmailAddress As TextBox
    Friend WithEvents txtExtension As TextBox
    Friend WithEvents txtTelephone As TextBox
    Friend WithEvents cmbDepartment As ComboBox
    Friend WithEvents txtEmployeeNumber As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnQuit As Button
End Class
