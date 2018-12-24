<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRemoveAccount
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCloseAccount = New System.Windows.Forms.Button()
        Me.btnCloseCancel = New System.Windows.Forms.Button()
        Me.lstRemoveCustomerSelect = New System.Windows.Forms.ListBox()
        Me.lstRemoveAccountSelect = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbTypeCredit = New System.Windows.Forms.RadioButton()
        Me.rbTypeSavings = New System.Windows.Forms.RadioButton()
        Me.rbTypeChecking = New System.Windows.Forms.RadioButton()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please Select the customer. "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(191, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Please Select which account to close. "
        '
        'btnCloseAccount
        '
        Me.btnCloseAccount.Location = New System.Drawing.Point(210, 145)
        Me.btnCloseAccount.Name = "btnCloseAccount"
        Me.btnCloseAccount.Size = New System.Drawing.Size(103, 39)
        Me.btnCloseAccount.TabIndex = 2
        Me.btnCloseAccount.TabStop = False
        Me.btnCloseAccount.Text = "Close Account"
        Me.btnCloseAccount.UseVisualStyleBackColor = True
        '
        'btnCloseCancel
        '
        Me.btnCloseCancel.Location = New System.Drawing.Point(210, 201)
        Me.btnCloseCancel.Name = "btnCloseCancel"
        Me.btnCloseCancel.Size = New System.Drawing.Size(103, 39)
        Me.btnCloseCancel.TabIndex = 3
        Me.btnCloseCancel.TabStop = False
        Me.btnCloseCancel.Text = "Cancel"
        Me.btnCloseCancel.UseVisualStyleBackColor = True
        '
        'lstRemoveCustomerSelect
        '
        Me.lstRemoveCustomerSelect.FormattingEnabled = True
        Me.lstRemoveCustomerSelect.Location = New System.Drawing.Point(16, 30)
        Me.lstRemoveCustomerSelect.Name = "lstRemoveCustomerSelect"
        Me.lstRemoveCustomerSelect.Size = New System.Drawing.Size(139, 95)
        Me.lstRemoveCustomerSelect.TabIndex = 4
        '
        'lstRemoveAccountSelect
        '
        Me.lstRemoveAccountSelect.FormattingEnabled = True
        Me.lstRemoveAccountSelect.Location = New System.Drawing.Point(16, 145)
        Me.lstRemoveAccountSelect.Name = "lstRemoveAccountSelect"
        Me.lstRemoveAccountSelect.Size = New System.Drawing.Size(188, 95)
        Me.lstRemoveAccountSelect.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(171, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Please select account type."
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rbTypeCredit)
        Me.Panel1.Controls.Add(Me.rbTypeSavings)
        Me.Panel1.Controls.Add(Me.rbTypeChecking)
        Me.Panel1.Location = New System.Drawing.Point(174, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(97, 74)
        Me.Panel1.TabIndex = 7
        '
        'rbTypeCredit
        '
        Me.rbTypeCredit.AutoSize = True
        Me.rbTypeCredit.Location = New System.Drawing.Point(4, 50)
        Me.rbTypeCredit.Name = "rbTypeCredit"
        Me.rbTypeCredit.Size = New System.Drawing.Size(77, 17)
        Me.rbTypeCredit.TabIndex = 2
        Me.rbTypeCredit.TabStop = True
        Me.rbTypeCredit.Text = "Credit Card"
        Me.rbTypeCredit.UseVisualStyleBackColor = True
        '
        'rbTypeSavings
        '
        Me.rbTypeSavings.AutoSize = True
        Me.rbTypeSavings.Location = New System.Drawing.Point(4, 27)
        Me.rbTypeSavings.Name = "rbTypeSavings"
        Me.rbTypeSavings.Size = New System.Drawing.Size(63, 17)
        Me.rbTypeSavings.TabIndex = 1
        Me.rbTypeSavings.TabStop = True
        Me.rbTypeSavings.Text = "Savings"
        Me.rbTypeSavings.UseVisualStyleBackColor = True
        '
        'rbTypeChecking
        '
        Me.rbTypeChecking.AutoSize = True
        Me.rbTypeChecking.Location = New System.Drawing.Point(4, 4)
        Me.rbTypeChecking.Name = "rbTypeChecking"
        Me.rbTypeChecking.Size = New System.Drawing.Size(70, 17)
        Me.rbTypeChecking.TabIndex = 0
        Me.rbTypeChecking.TabStop = True
        Me.rbTypeChecking.Text = "Checking"
        Me.rbTypeChecking.UseVisualStyleBackColor = True
        '
        'frmRemoveAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 269)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lstRemoveAccountSelect)
        Me.Controls.Add(Me.lstRemoveCustomerSelect)
        Me.Controls.Add(Me.btnCloseCancel)
        Me.Controls.Add(Me.btnCloseAccount)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmRemoveAccount"
        Me.Text = "Close an Account"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCloseAccount As Button
    Friend WithEvents btnCloseCancel As Button
    Friend WithEvents lstRemoveCustomerSelect As ListBox
    Friend WithEvents lstRemoveAccountSelect As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents rbTypeCredit As RadioButton
    Friend WithEvents rbTypeSavings As RadioButton
    Friend WithEvents rbTypeChecking As RadioButton
End Class
