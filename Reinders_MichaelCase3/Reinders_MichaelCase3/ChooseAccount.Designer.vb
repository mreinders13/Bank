<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChooseAccount
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
        Me.pnlAcctType = New System.Windows.Forms.Panel()
        Me.rbTypeCredit = New System.Windows.Forms.RadioButton()
        Me.rbTypeSavings = New System.Windows.Forms.RadioButton()
        Me.rbTypeChecking = New System.Windows.Forms.RadioButton()
        Me.lstAccountSelect = New System.Windows.Forms.ListBox()
        Me.lstCustomerSelect = New System.Windows.Forms.ListBox()
        Me.pnlTransfer = New System.Windows.Forms.Panel()
        Me.txtTransferAmount = New System.Windows.Forms.TextBox()
        Me.lblTansferAmount = New System.Windows.Forms.Label()
        Me.btnMakeTransfer = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlAccountType2 = New System.Windows.Forms.Panel()
        Me.rbCreditCard2 = New System.Windows.Forms.RadioButton()
        Me.rbSavings2 = New System.Windows.Forms.RadioButton()
        Me.rbChecking2 = New System.Windows.Forms.RadioButton()
        Me.lstAccount2Select = New System.Windows.Forms.ListBox()
        Me.pnlWithdrawlDeposit = New System.Windows.Forms.Panel()
        Me.btnMakeDeposit = New System.Windows.Forms.Button()
        Me.btnMakeWithdrawl = New System.Windows.Forms.Button()
        Me.txtDepositAmount = New System.Windows.Forms.TextBox()
        Me.txtWithdrawlAmount = New System.Windows.Forms.TextBox()
        Me.lblDepositAmount = New System.Windows.Forms.Label()
        Me.lblWithdrawlAmount = New System.Windows.Forms.Label()
        Me.lblChooseAccount = New System.Windows.Forms.Label()
        Me.btnWithdrawl = New System.Windows.Forms.Button()
        Me.btnDeposit = New System.Windows.Forms.Button()
        Me.btnTransfer = New System.Windows.Forms.Button()
        Me.btnViewBalances = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.pnlAcctType.SuspendLayout()
        Me.pnlTransfer.SuspendLayout()
        Me.pnlAccountType2.SuspendLayout()
        Me.pnlWithdrawlDeposit.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlAcctType
        '
        Me.pnlAcctType.Controls.Add(Me.rbTypeCredit)
        Me.pnlAcctType.Controls.Add(Me.rbTypeSavings)
        Me.pnlAcctType.Controls.Add(Me.rbTypeChecking)
        Me.pnlAcctType.Location = New System.Drawing.Point(183, 65)
        Me.pnlAcctType.Name = "pnlAcctType"
        Me.pnlAcctType.Size = New System.Drawing.Size(97, 74)
        Me.pnlAcctType.TabIndex = 15
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
        'lstAccountSelect
        '
        Me.lstAccountSelect.FormattingEnabled = True
        Me.lstAccountSelect.Location = New System.Drawing.Point(317, 55)
        Me.lstAccountSelect.Name = "lstAccountSelect"
        Me.lstAccountSelect.Size = New System.Drawing.Size(188, 95)
        Me.lstAccountSelect.TabIndex = 13
        '
        'lstCustomerSelect
        '
        Me.lstCustomerSelect.FormattingEnabled = True
        Me.lstCustomerSelect.Location = New System.Drawing.Point(15, 55)
        Me.lstCustomerSelect.Name = "lstCustomerSelect"
        Me.lstCustomerSelect.Size = New System.Drawing.Size(139, 95)
        Me.lstCustomerSelect.TabIndex = 12
        '
        'pnlTransfer
        '
        Me.pnlTransfer.Controls.Add(Me.txtTransferAmount)
        Me.pnlTransfer.Controls.Add(Me.lblTansferAmount)
        Me.pnlTransfer.Controls.Add(Me.btnMakeTransfer)
        Me.pnlTransfer.Controls.Add(Me.Label1)
        Me.pnlTransfer.Controls.Add(Me.pnlAccountType2)
        Me.pnlTransfer.Controls.Add(Me.lstAccount2Select)
        Me.pnlTransfer.Location = New System.Drawing.Point(170, 167)
        Me.pnlTransfer.Name = "pnlTransfer"
        Me.pnlTransfer.Size = New System.Drawing.Size(337, 203)
        Me.pnlTransfer.TabIndex = 16
        '
        'txtTransferAmount
        '
        Me.txtTransferAmount.Location = New System.Drawing.Point(49, 167)
        Me.txtTransferAmount.Name = "txtTransferAmount"
        Me.txtTransferAmount.Size = New System.Drawing.Size(117, 20)
        Me.txtTransferAmount.TabIndex = 22
        '
        'lblTansferAmount
        '
        Me.lblTansferAmount.AutoSize = True
        Me.lblTansferAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTansferAmount.Location = New System.Drawing.Point(46, 147)
        Me.lblTansferAmount.Name = "lblTansferAmount"
        Me.lblTansferAmount.Size = New System.Drawing.Size(122, 17)
        Me.lblTansferAmount.TabIndex = 21
        Me.lblTansferAmount.Text = "Transfer Amount: "
        '
        'btnMakeTransfer
        '
        Me.btnMakeTransfer.Location = New System.Drawing.Point(177, 147)
        Me.btnMakeTransfer.Name = "btnMakeTransfer"
        Me.btnMakeTransfer.Size = New System.Drawing.Size(111, 40)
        Me.btnMakeTransfer.TabIndex = 20
        Me.btnMakeTransfer.Text = "Complete Transfer"
        Me.btnMakeTransfer.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(319, 39)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Please select the Account Type and Specific Account you wish to Transfer Funds to" &
    ":"
        '
        'pnlAccountType2
        '
        Me.pnlAccountType2.Controls.Add(Me.rbCreditCard2)
        Me.pnlAccountType2.Controls.Add(Me.rbSavings2)
        Me.pnlAccountType2.Controls.Add(Me.rbChecking2)
        Me.pnlAccountType2.Location = New System.Drawing.Point(46, 46)
        Me.pnlAccountType2.Name = "pnlAccountType2"
        Me.pnlAccountType2.Size = New System.Drawing.Size(97, 74)
        Me.pnlAccountType2.TabIndex = 18
        '
        'rbCreditCard2
        '
        Me.rbCreditCard2.AutoSize = True
        Me.rbCreditCard2.Location = New System.Drawing.Point(4, 50)
        Me.rbCreditCard2.Name = "rbCreditCard2"
        Me.rbCreditCard2.Size = New System.Drawing.Size(77, 17)
        Me.rbCreditCard2.TabIndex = 2
        Me.rbCreditCard2.TabStop = True
        Me.rbCreditCard2.Text = "Credit Card"
        Me.rbCreditCard2.UseVisualStyleBackColor = True
        '
        'rbSavings2
        '
        Me.rbSavings2.AutoSize = True
        Me.rbSavings2.Location = New System.Drawing.Point(4, 27)
        Me.rbSavings2.Name = "rbSavings2"
        Me.rbSavings2.Size = New System.Drawing.Size(63, 17)
        Me.rbSavings2.TabIndex = 1
        Me.rbSavings2.TabStop = True
        Me.rbSavings2.Text = "Savings"
        Me.rbSavings2.UseVisualStyleBackColor = True
        '
        'rbChecking2
        '
        Me.rbChecking2.AutoSize = True
        Me.rbChecking2.Location = New System.Drawing.Point(4, 4)
        Me.rbChecking2.Name = "rbChecking2"
        Me.rbChecking2.Size = New System.Drawing.Size(70, 17)
        Me.rbChecking2.TabIndex = 0
        Me.rbChecking2.TabStop = True
        Me.rbChecking2.Text = "Checking"
        Me.rbChecking2.UseVisualStyleBackColor = True
        '
        'lstAccount2Select
        '
        Me.lstAccount2Select.FormattingEnabled = True
        Me.lstAccount2Select.Location = New System.Drawing.Point(147, 46)
        Me.lstAccount2Select.Name = "lstAccount2Select"
        Me.lstAccount2Select.Size = New System.Drawing.Size(188, 95)
        Me.lstAccount2Select.TabIndex = 17
        '
        'pnlWithdrawlDeposit
        '
        Me.pnlWithdrawlDeposit.Controls.Add(Me.btnMakeDeposit)
        Me.pnlWithdrawlDeposit.Controls.Add(Me.btnMakeWithdrawl)
        Me.pnlWithdrawlDeposit.Controls.Add(Me.txtDepositAmount)
        Me.pnlWithdrawlDeposit.Controls.Add(Me.txtWithdrawlAmount)
        Me.pnlWithdrawlDeposit.Controls.Add(Me.lblDepositAmount)
        Me.pnlWithdrawlDeposit.Controls.Add(Me.lblWithdrawlAmount)
        Me.pnlWithdrawlDeposit.Location = New System.Drawing.Point(232, 396)
        Me.pnlWithdrawlDeposit.Name = "pnlWithdrawlDeposit"
        Me.pnlWithdrawlDeposit.Size = New System.Drawing.Size(337, 203)
        Me.pnlWithdrawlDeposit.TabIndex = 22
        '
        'btnMakeDeposit
        '
        Me.btnMakeDeposit.Location = New System.Drawing.Point(139, 103)
        Me.btnMakeDeposit.Name = "btnMakeDeposit"
        Me.btnMakeDeposit.Size = New System.Drawing.Size(100, 35)
        Me.btnMakeDeposit.TabIndex = 5
        Me.btnMakeDeposit.Text = "Deposit"
        Me.btnMakeDeposit.UseVisualStyleBackColor = True
        '
        'btnMakeWithdrawl
        '
        Me.btnMakeWithdrawl.Location = New System.Drawing.Point(139, 34)
        Me.btnMakeWithdrawl.Name = "btnMakeWithdrawl"
        Me.btnMakeWithdrawl.Size = New System.Drawing.Size(100, 35)
        Me.btnMakeWithdrawl.TabIndex = 4
        Me.btnMakeWithdrawl.Text = "Withdrawl"
        Me.btnMakeWithdrawl.UseVisualStyleBackColor = True
        '
        'txtDepositAmount
        '
        Me.txtDepositAmount.Location = New System.Drawing.Point(139, 77)
        Me.txtDepositAmount.Name = "txtDepositAmount"
        Me.txtDepositAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtDepositAmount.TabIndex = 3
        '
        'txtWithdrawlAmount
        '
        Me.txtWithdrawlAmount.Location = New System.Drawing.Point(139, 8)
        Me.txtWithdrawlAmount.Name = "txtWithdrawlAmount"
        Me.txtWithdrawlAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtWithdrawlAmount.TabIndex = 2
        '
        'lblDepositAmount
        '
        Me.lblDepositAmount.AutoSize = True
        Me.lblDepositAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepositAmount.Location = New System.Drawing.Point(20, 77)
        Me.lblDepositAmount.Name = "lblDepositAmount"
        Me.lblDepositAmount.Size = New System.Drawing.Size(112, 17)
        Me.lblDepositAmount.TabIndex = 1
        Me.lblDepositAmount.Text = "Deposit Amount:"
        Me.lblDepositAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblWithdrawlAmount
        '
        Me.lblWithdrawlAmount.AutoSize = True
        Me.lblWithdrawlAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWithdrawlAmount.Location = New System.Drawing.Point(7, 8)
        Me.lblWithdrawlAmount.Name = "lblWithdrawlAmount"
        Me.lblWithdrawlAmount.Size = New System.Drawing.Size(125, 17)
        Me.lblWithdrawlAmount.TabIndex = 0
        Me.lblWithdrawlAmount.Text = "Withdrawl Amount:"
        Me.lblWithdrawlAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblChooseAccount
        '
        Me.lblChooseAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChooseAccount.Location = New System.Drawing.Point(15, 13)
        Me.lblChooseAccount.Name = "lblChooseAccount"
        Me.lblChooseAccount.Size = New System.Drawing.Size(490, 39)
        Me.lblChooseAccount.TabIndex = 17
        Me.lblChooseAccount.Text = "Please Select which Customer, Type of Account, and the Specific Account you with " &
    "to process a transaction for:"
        '
        'btnWithdrawl
        '
        Me.btnWithdrawl.Location = New System.Drawing.Point(15, 209)
        Me.btnWithdrawl.Name = "btnWithdrawl"
        Me.btnWithdrawl.Size = New System.Drawing.Size(139, 36)
        Me.btnWithdrawl.TabIndex = 18
        Me.btnWithdrawl.Text = "Make a Withdrawl"
        Me.btnWithdrawl.UseVisualStyleBackColor = True
        '
        'btnDeposit
        '
        Me.btnDeposit.Location = New System.Drawing.Point(15, 251)
        Me.btnDeposit.Name = "btnDeposit"
        Me.btnDeposit.Size = New System.Drawing.Size(139, 36)
        Me.btnDeposit.TabIndex = 19
        Me.btnDeposit.Text = "Make A Deposit"
        Me.btnDeposit.UseVisualStyleBackColor = True
        '
        'btnTransfer
        '
        Me.btnTransfer.Location = New System.Drawing.Point(15, 293)
        Me.btnTransfer.Name = "btnTransfer"
        Me.btnTransfer.Size = New System.Drawing.Size(139, 36)
        Me.btnTransfer.TabIndex = 20
        Me.btnTransfer.Text = "Transfer Between Accounts"
        Me.btnTransfer.UseVisualStyleBackColor = True
        '
        'btnViewBalances
        '
        Me.btnViewBalances.Location = New System.Drawing.Point(15, 167)
        Me.btnViewBalances.Name = "btnViewBalances"
        Me.btnViewBalances.Size = New System.Drawing.Size(139, 36)
        Me.btnViewBalances.TabIndex = 21
        Me.btnViewBalances.Text = "View Balances"
        Me.btnViewBalances.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(15, 335)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(139, 52)
        Me.btnBack.TabIndex = 23
        Me.btnBack.Text = "Cancel"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'frmChooseAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(795, 625)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.pnlWithdrawlDeposit)
        Me.Controls.Add(Me.btnViewBalances)
        Me.Controls.Add(Me.btnTransfer)
        Me.Controls.Add(Me.btnDeposit)
        Me.Controls.Add(Me.btnWithdrawl)
        Me.Controls.Add(Me.lblChooseAccount)
        Me.Controls.Add(Me.pnlTransfer)
        Me.Controls.Add(Me.pnlAcctType)
        Me.Controls.Add(Me.lstAccountSelect)
        Me.Controls.Add(Me.lstCustomerSelect)
        Me.Name = "frmChooseAccount"
        Me.Text = "ChooseAccount"
        Me.pnlAcctType.ResumeLayout(False)
        Me.pnlAcctType.PerformLayout()
        Me.pnlTransfer.ResumeLayout(False)
        Me.pnlTransfer.PerformLayout()
        Me.pnlAccountType2.ResumeLayout(False)
        Me.pnlAccountType2.PerformLayout()
        Me.pnlWithdrawlDeposit.ResumeLayout(False)
        Me.pnlWithdrawlDeposit.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlAcctType As Panel
    Friend WithEvents rbTypeCredit As RadioButton
    Friend WithEvents rbTypeSavings As RadioButton
    Friend WithEvents rbTypeChecking As RadioButton
    Friend WithEvents lstAccountSelect As ListBox
    Friend WithEvents lstCustomerSelect As ListBox
    Friend WithEvents pnlTransfer As Panel
    Friend WithEvents lblChooseAccount As Label
    Friend WithEvents pnlAccountType2 As Panel
    Friend WithEvents rbCreditCard2 As RadioButton
    Friend WithEvents rbSavings2 As RadioButton
    Friend WithEvents rbChecking2 As RadioButton
    Friend WithEvents lstAccount2Select As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnWithdrawl As Button
    Friend WithEvents btnDeposit As Button
    Friend WithEvents btnTransfer As Button
    Friend WithEvents btnViewBalances As Button
    Friend WithEvents pnlWithdrawlDeposit As Panel
    Friend WithEvents txtTransferAmount As TextBox
    Friend WithEvents lblTansferAmount As Label
    Friend WithEvents btnMakeTransfer As Button
    Friend WithEvents btnMakeWithdrawl As Button
    Friend WithEvents txtDepositAmount As TextBox
    Friend WithEvents txtWithdrawlAmount As TextBox
    Friend WithEvents lblDepositAmount As Label
    Friend WithEvents lblWithdrawlAmount As Label
    Friend WithEvents btnMakeDeposit As Button
    Friend WithEvents btnBack As Button
End Class
