<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProcessSelect
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
        Me.btnCreateAccount = New System.Windows.Forms.Button()
        Me.btnRemoveAccount = New System.Windows.Forms.Button()
        Me.btnProcessTransactions = New System.Windows.Forms.Button()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.btnViewRecords = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCreateAccount
        '
        Me.btnCreateAccount.Location = New System.Drawing.Point(12, 61)
        Me.btnCreateAccount.Name = "btnCreateAccount"
        Me.btnCreateAccount.Size = New System.Drawing.Size(123, 46)
        Me.btnCreateAccount.TabIndex = 0
        Me.btnCreateAccount.Text = "Create Account "
        Me.btnCreateAccount.UseVisualStyleBackColor = True
        '
        'btnRemoveAccount
        '
        Me.btnRemoveAccount.Location = New System.Drawing.Point(12, 113)
        Me.btnRemoveAccount.Name = "btnRemoveAccount"
        Me.btnRemoveAccount.Size = New System.Drawing.Size(123, 46)
        Me.btnRemoveAccount.TabIndex = 1
        Me.btnRemoveAccount.Text = "Remove Account"
        Me.btnRemoveAccount.UseVisualStyleBackColor = True
        '
        'btnProcessTransactions
        '
        Me.btnProcessTransactions.Location = New System.Drawing.Point(159, 61)
        Me.btnProcessTransactions.Name = "btnProcessTransactions"
        Me.btnProcessTransactions.Size = New System.Drawing.Size(123, 46)
        Me.btnProcessTransactions.TabIndex = 2
        Me.btnProcessTransactions.Text = "Process Transaction"
        Me.btnProcessTransactions.UseVisualStyleBackColor = True
        '
        'lblWelcome
        '
        Me.lblWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(12, 13)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(270, 45)
        Me.lblWelcome.TabIndex = 3
        Me.lblWelcome.Text = "Welcome Employee. Please select which process you wish to begin: "
        '
        'btnViewRecords
        '
        Me.btnViewRecords.Location = New System.Drawing.Point(159, 113)
        Me.btnViewRecords.Name = "btnViewRecords"
        Me.btnViewRecords.Size = New System.Drawing.Size(123, 46)
        Me.btnViewRecords.TabIndex = 4
        Me.btnViewRecords.Text = "View Records "
        Me.btnViewRecords.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(159, 205)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(123, 46)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmProcessSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(296, 263)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnViewRecords)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.btnProcessTransactions)
        Me.Controls.Add(Me.btnRemoveAccount)
        Me.Controls.Add(Me.btnCreateAccount)
        Me.Name = "frmProcessSelect"
        Me.Text = "Process Select"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCreateAccount As Button
    Friend WithEvents btnRemoveAccount As Button
    Friend WithEvents btnProcessTransactions As Button
    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnViewRecords As Button
    Friend WithEvents btnExit As Button
End Class
