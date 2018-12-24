<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreateAccount
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
        Me.lblCurrentOrNew = New System.Windows.Forms.Label()
        Me.rbNewCustomer = New System.Windows.Forms.RadioButton()
        Me.rbExistingCustomer = New System.Windows.Forms.RadioButton()
        Me.lblSelectAccountType = New System.Windows.Forms.Label()
        Me.rbChecking = New System.Windows.Forms.RadioButton()
        Me.rbSavings = New System.Windows.Forms.RadioButton()
        Me.rbCredit = New System.Windows.Forms.RadioButton()
        Me.pnlAccountType = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblNewCustomerFirst = New System.Windows.Forms.Label()
        Me.lblNewCustomerLast = New System.Windows.Forms.Label()
        Me.txtNewCustomerFirst = New System.Windows.Forms.TextBox()
        Me.txtNewCustomerLast = New System.Windows.Forms.TextBox()
        Me.pnlNewCustomerName = New System.Windows.Forms.Panel()
        Me.btnCreateCustomer = New System.Windows.Forms.Button()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.lblCustomerID = New System.Windows.Forms.Label()
        Me.pnlExistingCustomer = New System.Windows.Forms.Panel()
        Me.lblSelectCustomer = New System.Windows.Forms.Label()
        Me.lstExistingCustomers = New System.Windows.Forms.ListBox()
        Me.pnlCSAcctCreate = New System.Windows.Forms.Panel()
        Me.txtIntlCashDeposit = New System.Windows.Forms.TextBox()
        Me.txtCSAcctNumber = New System.Windows.Forms.TextBox()
        Me.lblCSCashDeposit = New System.Windows.Forms.Label()
        Me.lblCSAccountNumber = New System.Windows.Forms.Label()
        Me.lblEnterCSinfo = New System.Windows.Forms.Label()
        Me.pnlCreditInfo = New System.Windows.Forms.Panel()
        Me.txtIntlCredit = New System.Windows.Forms.TextBox()
        Me.txtCreditAcctNumber = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCreateAccount = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.pnlAccountType.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlNewCustomerName.SuspendLayout()
        Me.pnlExistingCustomer.SuspendLayout()
        Me.pnlCSAcctCreate.SuspendLayout()
        Me.pnlCreditInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCurrentOrNew
        '
        Me.lblCurrentOrNew.AutoSize = True
        Me.lblCurrentOrNew.Location = New System.Drawing.Point(13, 13)
        Me.lblCurrentOrNew.Name = "lblCurrentOrNew"
        Me.lblCurrentOrNew.Size = New System.Drawing.Size(393, 13)
        Me.lblCurrentOrNew.TabIndex = 0
        Me.lblCurrentOrNew.Text = "Please indicate if the New Account is for an existing customer or a new customer." &
    " "
        '
        'rbNewCustomer
        '
        Me.rbNewCustomer.AutoSize = True
        Me.rbNewCustomer.Location = New System.Drawing.Point(3, 3)
        Me.rbNewCustomer.Name = "rbNewCustomer"
        Me.rbNewCustomer.Size = New System.Drawing.Size(94, 17)
        Me.rbNewCustomer.TabIndex = 1
        Me.rbNewCustomer.Text = "New Customer"
        Me.rbNewCustomer.UseVisualStyleBackColor = True
        '
        'rbExistingCustomer
        '
        Me.rbExistingCustomer.AutoSize = True
        Me.rbExistingCustomer.Location = New System.Drawing.Point(3, 26)
        Me.rbExistingCustomer.Name = "rbExistingCustomer"
        Me.rbExistingCustomer.Size = New System.Drawing.Size(108, 17)
        Me.rbExistingCustomer.TabIndex = 2
        Me.rbExistingCustomer.Text = "Existing Customer"
        Me.rbExistingCustomer.UseVisualStyleBackColor = True
        '
        'lblSelectAccountType
        '
        Me.lblSelectAccountType.AutoSize = True
        Me.lblSelectAccountType.Location = New System.Drawing.Point(13, 120)
        Me.lblSelectAccountType.Name = "lblSelectAccountType"
        Me.lblSelectAccountType.Size = New System.Drawing.Size(278, 13)
        Me.lblSelectAccountType.TabIndex = 3
        Me.lblSelectAccountType.Text = "Please indicate which type of account should be created."
        '
        'rbChecking
        '
        Me.rbChecking.AutoSize = True
        Me.rbChecking.Location = New System.Drawing.Point(3, 3)
        Me.rbChecking.Name = "rbChecking"
        Me.rbChecking.Size = New System.Drawing.Size(70, 17)
        Me.rbChecking.TabIndex = 4
        Me.rbChecking.Text = "Checking"
        Me.rbChecking.UseVisualStyleBackColor = True
        '
        'rbSavings
        '
        Me.rbSavings.AutoSize = True
        Me.rbSavings.Location = New System.Drawing.Point(91, 3)
        Me.rbSavings.Name = "rbSavings"
        Me.rbSavings.Size = New System.Drawing.Size(63, 17)
        Me.rbSavings.TabIndex = 5
        Me.rbSavings.Text = "Savings"
        Me.rbSavings.UseVisualStyleBackColor = True
        '
        'rbCredit
        '
        Me.rbCredit.AutoSize = True
        Me.rbCredit.Location = New System.Drawing.Point(177, 3)
        Me.rbCredit.Name = "rbCredit"
        Me.rbCredit.Size = New System.Drawing.Size(52, 17)
        Me.rbCredit.TabIndex = 6
        Me.rbCredit.Text = "Credit"
        Me.rbCredit.UseVisualStyleBackColor = True
        '
        'pnlAccountType
        '
        Me.pnlAccountType.Controls.Add(Me.rbChecking)
        Me.pnlAccountType.Controls.Add(Me.rbCredit)
        Me.pnlAccountType.Controls.Add(Me.rbSavings)
        Me.pnlAccountType.Location = New System.Drawing.Point(40, 136)
        Me.pnlAccountType.Name = "pnlAccountType"
        Me.pnlAccountType.Size = New System.Drawing.Size(254, 24)
        Me.pnlAccountType.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rbNewCustomer)
        Me.Panel1.Controls.Add(Me.rbExistingCustomer)
        Me.Panel1.Location = New System.Drawing.Point(40, 29)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(131, 50)
        Me.Panel1.TabIndex = 8
        '
        'lblNewCustomerFirst
        '
        Me.lblNewCustomerFirst.AutoSize = True
        Me.lblNewCustomerFirst.Location = New System.Drawing.Point(6, 6)
        Me.lblNewCustomerFirst.Name = "lblNewCustomerFirst"
        Me.lblNewCustomerFirst.Size = New System.Drawing.Size(63, 13)
        Me.lblNewCustomerFirst.TabIndex = 9
        Me.lblNewCustomerFirst.Text = "First Name: "
        '
        'lblNewCustomerLast
        '
        Me.lblNewCustomerLast.AutoSize = True
        Me.lblNewCustomerLast.Location = New System.Drawing.Point(6, 30)
        Me.lblNewCustomerLast.Name = "lblNewCustomerLast"
        Me.lblNewCustomerLast.Size = New System.Drawing.Size(64, 13)
        Me.lblNewCustomerLast.TabIndex = 10
        Me.lblNewCustomerLast.Text = "Last Name: "
        '
        'txtNewCustomerFirst
        '
        Me.txtNewCustomerFirst.Location = New System.Drawing.Point(75, 3)
        Me.txtNewCustomerFirst.Name = "txtNewCustomerFirst"
        Me.txtNewCustomerFirst.Size = New System.Drawing.Size(100, 20)
        Me.txtNewCustomerFirst.TabIndex = 11
        '
        'txtNewCustomerLast
        '
        Me.txtNewCustomerLast.Location = New System.Drawing.Point(76, 27)
        Me.txtNewCustomerLast.Name = "txtNewCustomerLast"
        Me.txtNewCustomerLast.Size = New System.Drawing.Size(100, 20)
        Me.txtNewCustomerLast.TabIndex = 12
        '
        'pnlNewCustomerName
        '
        Me.pnlNewCustomerName.Controls.Add(Me.btnCreateCustomer)
        Me.pnlNewCustomerName.Controls.Add(Me.txtCustomerID)
        Me.pnlNewCustomerName.Controls.Add(Me.lblCustomerID)
        Me.pnlNewCustomerName.Controls.Add(Me.lblNewCustomerFirst)
        Me.pnlNewCustomerName.Controls.Add(Me.txtNewCustomerLast)
        Me.pnlNewCustomerName.Controls.Add(Me.lblNewCustomerLast)
        Me.pnlNewCustomerName.Controls.Add(Me.txtNewCustomerFirst)
        Me.pnlNewCustomerName.Location = New System.Drawing.Point(177, 29)
        Me.pnlNewCustomerName.Name = "pnlNewCustomerName"
        Me.pnlNewCustomerName.Size = New System.Drawing.Size(231, 88)
        Me.pnlNewCustomerName.TabIndex = 13
        '
        'btnCreateCustomer
        '
        Me.btnCreateCustomer.Location = New System.Drawing.Point(182, 6)
        Me.btnCreateCustomer.Name = "btnCreateCustomer"
        Me.btnCreateCustomer.Size = New System.Drawing.Size(46, 63)
        Me.btnCreateCustomer.TabIndex = 15
        Me.btnCreateCustomer.Text = "Create"
        Me.btnCreateCustomer.UseVisualStyleBackColor = True
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Location = New System.Drawing.Point(76, 53)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(100, 20)
        Me.txtCustomerID.TabIndex = 14
        '
        'lblCustomerID
        '
        Me.lblCustomerID.Location = New System.Drawing.Point(3, 53)
        Me.lblCustomerID.Name = "lblCustomerID"
        Me.lblCustomerID.Size = New System.Drawing.Size(71, 32)
        Me.lblCustomerID.TabIndex = 13
        Me.lblCustomerID.Text = "Customer ID:  (5 digits)"
        '
        'pnlExistingCustomer
        '
        Me.pnlExistingCustomer.Controls.Add(Me.lblSelectCustomer)
        Me.pnlExistingCustomer.Controls.Add(Me.lstExistingCustomers)
        Me.pnlExistingCustomer.Location = New System.Drawing.Point(177, 29)
        Me.pnlExistingCustomer.Name = "pnlExistingCustomer"
        Me.pnlExistingCustomer.Size = New System.Drawing.Size(231, 88)
        Me.pnlExistingCustomer.TabIndex = 14
        '
        'lblSelectCustomer
        '
        Me.lblSelectCustomer.AutoSize = True
        Me.lblSelectCustomer.Location = New System.Drawing.Point(4, 1)
        Me.lblSelectCustomer.Name = "lblSelectCustomer"
        Me.lblSelectCustomer.Size = New System.Drawing.Size(119, 13)
        Me.lblSelectCustomer.TabIndex = 1
        Me.lblSelectCustomer.Text = "Please select customer:"
        '
        'lstExistingCustomers
        '
        Me.lstExistingCustomers.FormattingEnabled = True
        Me.lstExistingCustomers.Location = New System.Drawing.Point(3, 17)
        Me.lstExistingCustomers.Name = "lstExistingCustomers"
        Me.lstExistingCustomers.Size = New System.Drawing.Size(172, 69)
        Me.lstExistingCustomers.TabIndex = 0
        '
        'pnlCSAcctCreate
        '
        Me.pnlCSAcctCreate.Controls.Add(Me.txtIntlCashDeposit)
        Me.pnlCSAcctCreate.Controls.Add(Me.txtCSAcctNumber)
        Me.pnlCSAcctCreate.Controls.Add(Me.lblCSCashDeposit)
        Me.pnlCSAcctCreate.Controls.Add(Me.lblCSAccountNumber)
        Me.pnlCSAcctCreate.Controls.Add(Me.lblEnterCSinfo)
        Me.pnlCSAcctCreate.Location = New System.Drawing.Point(43, 167)
        Me.pnlCSAcctCreate.Name = "pnlCSAcctCreate"
        Me.pnlCSAcctCreate.Size = New System.Drawing.Size(248, 100)
        Me.pnlCSAcctCreate.TabIndex = 15
        '
        'txtIntlCashDeposit
        '
        Me.txtIntlCashDeposit.Location = New System.Drawing.Point(137, 60)
        Me.txtIntlCashDeposit.Name = "txtIntlCashDeposit"
        Me.txtIntlCashDeposit.Size = New System.Drawing.Size(100, 20)
        Me.txtIntlCashDeposit.TabIndex = 4
        '
        'txtCSAcctNumber
        '
        Me.txtCSAcctNumber.Location = New System.Drawing.Point(137, 29)
        Me.txtCSAcctNumber.Name = "txtCSAcctNumber"
        Me.txtCSAcctNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtCSAcctNumber.TabIndex = 3
        '
        'lblCSCashDeposit
        '
        Me.lblCSCashDeposit.Location = New System.Drawing.Point(28, 60)
        Me.lblCSCashDeposit.Name = "lblCSCashDeposit"
        Me.lblCSCashDeposit.Size = New System.Drawing.Size(100, 28)
        Me.lblCSCashDeposit.TabIndex = 2
        Me.lblCSCashDeposit.Text = "Initial Cash Deposit: (if any)"
        Me.lblCSCashDeposit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCSAccountNumber
        '
        Me.lblCSAccountNumber.Location = New System.Drawing.Point(19, 27)
        Me.lblCSAccountNumber.Name = "lblCSAccountNumber"
        Me.lblCSAccountNumber.Size = New System.Drawing.Size(109, 23)
        Me.lblCSAccountNumber.TabIndex = 1
        Me.lblCSAccountNumber.Text = "Account Number:"
        Me.lblCSAccountNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEnterCSinfo
        '
        Me.lblEnterCSinfo.AutoSize = True
        Me.lblEnterCSinfo.Location = New System.Drawing.Point(4, 4)
        Me.lblEnterCSinfo.Name = "lblEnterCSinfo"
        Me.lblEnterCSinfo.Size = New System.Drawing.Size(185, 13)
        Me.lblEnterCSinfo.TabIndex = 0
        Me.lblEnterCSinfo.Text = "Please enter the following information:"
        '
        'pnlCreditInfo
        '
        Me.pnlCreditInfo.Controls.Add(Me.txtIntlCredit)
        Me.pnlCreditInfo.Controls.Add(Me.txtCreditAcctNumber)
        Me.pnlCreditInfo.Controls.Add(Me.Label1)
        Me.pnlCreditInfo.Controls.Add(Me.Label2)
        Me.pnlCreditInfo.Controls.Add(Me.Label3)
        Me.pnlCreditInfo.Location = New System.Drawing.Point(43, 167)
        Me.pnlCreditInfo.Name = "pnlCreditInfo"
        Me.pnlCreditInfo.Size = New System.Drawing.Size(248, 100)
        Me.pnlCreditInfo.TabIndex = 16
        '
        'txtIntlCredit
        '
        Me.txtIntlCredit.Location = New System.Drawing.Point(137, 60)
        Me.txtIntlCredit.Name = "txtIntlCredit"
        Me.txtIntlCredit.Size = New System.Drawing.Size(100, 20)
        Me.txtIntlCredit.TabIndex = 4
        '
        'txtCreditAcctNumber
        '
        Me.txtCreditAcctNumber.Location = New System.Drawing.Point(137, 29)
        Me.txtCreditAcctNumber.Name = "txtCreditAcctNumber"
        Me.txtCreditAcctNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtCreditAcctNumber.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(28, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 28)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Initial Credit Limit:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(19, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Account Number:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(185, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Please enter the following information:"
        '
        'btnCreateAccount
        '
        Me.btnCreateAccount.Location = New System.Drawing.Point(297, 167)
        Me.btnCreateAccount.Name = "btnCreateAccount"
        Me.btnCreateAccount.Size = New System.Drawing.Size(126, 48)
        Me.btnCreateAccount.TabIndex = 17
        Me.btnCreateAccount.Text = "Create Account"
        Me.btnCreateAccount.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(11, 319)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(126, 48)
        Me.btnCancel.TabIndex = 18
        Me.btnCancel.Text = "Back to Menu"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmCreateAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 379)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnCreateAccount)
        Me.Controls.Add(Me.pnlExistingCustomer)
        Me.Controls.Add(Me.pnlCreditInfo)
        Me.Controls.Add(Me.pnlCSAcctCreate)
        Me.Controls.Add(Me.pnlNewCustomerName)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlAccountType)
        Me.Controls.Add(Me.lblSelectAccountType)
        Me.Controls.Add(Me.lblCurrentOrNew)
        Me.Name = "frmCreateAccount"
        Me.Text = " Create Account "
        Me.pnlAccountType.ResumeLayout(False)
        Me.pnlAccountType.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlNewCustomerName.ResumeLayout(False)
        Me.pnlNewCustomerName.PerformLayout()
        Me.pnlExistingCustomer.ResumeLayout(False)
        Me.pnlExistingCustomer.PerformLayout()
        Me.pnlCSAcctCreate.ResumeLayout(False)
        Me.pnlCSAcctCreate.PerformLayout()
        Me.pnlCreditInfo.ResumeLayout(False)
        Me.pnlCreditInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCurrentOrNew As Label
    Friend WithEvents rbNewCustomer As RadioButton
    Friend WithEvents rbExistingCustomer As RadioButton
    Friend WithEvents lblSelectAccountType As Label
    Friend WithEvents rbChecking As RadioButton
    Friend WithEvents rbSavings As RadioButton
    Friend WithEvents rbCredit As RadioButton
    Friend WithEvents pnlAccountType As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblNewCustomerFirst As Label
    Friend WithEvents lblNewCustomerLast As Label
    Friend WithEvents txtNewCustomerFirst As TextBox
    Friend WithEvents txtNewCustomerLast As TextBox
    Friend WithEvents pnlNewCustomerName As Panel
    Friend WithEvents pnlExistingCustomer As Panel
    Friend WithEvents lstExistingCustomers As ListBox
    Friend WithEvents lblSelectCustomer As Label
    Friend WithEvents pnlCSAcctCreate As Panel
    Friend WithEvents txtIntlCashDeposit As TextBox
    Friend WithEvents txtCSAcctNumber As TextBox
    Friend WithEvents lblCSCashDeposit As Label
    Friend WithEvents lblCSAccountNumber As Label
    Friend WithEvents lblEnterCSinfo As Label
    Friend WithEvents pnlCreditInfo As Panel
    Friend WithEvents txtIntlCredit As TextBox
    Friend WithEvents txtCreditAcctNumber As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCreateAccount As Button
    Friend WithEvents txtCustomerID As TextBox
    Friend WithEvents lblCustomerID As Label
    Friend WithEvents btnCreateCustomer As Button
    Friend WithEvents btnCancel As Button
End Class
