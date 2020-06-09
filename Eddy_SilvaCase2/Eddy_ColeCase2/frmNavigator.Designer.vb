<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNavigator
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
        Me.btnMakeWithdrawal = New System.Windows.Forms.Button()
        Me.btnMakeDeposit = New System.Windows.Forms.Button()
        Me.btnTransferFunds = New System.Windows.Forms.Button()
        Me.btnGetBalances = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.btnCreditCardPayment = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnMakeWithdrawal
        '
        Me.btnMakeWithdrawal.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnMakeWithdrawal.Location = New System.Drawing.Point(320, 52)
        Me.btnMakeWithdrawal.Name = "btnMakeWithdrawal"
        Me.btnMakeWithdrawal.Size = New System.Drawing.Size(215, 51)
        Me.btnMakeWithdrawal.TabIndex = 0
        Me.btnMakeWithdrawal.Text = "Make Withdrawal"
        Me.btnMakeWithdrawal.UseVisualStyleBackColor = False
        '
        'btnMakeDeposit
        '
        Me.btnMakeDeposit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnMakeDeposit.Location = New System.Drawing.Point(320, 119)
        Me.btnMakeDeposit.Name = "btnMakeDeposit"
        Me.btnMakeDeposit.Size = New System.Drawing.Size(215, 51)
        Me.btnMakeDeposit.TabIndex = 1
        Me.btnMakeDeposit.Text = "Make Deposit"
        Me.btnMakeDeposit.UseVisualStyleBackColor = False
        '
        'btnTransferFunds
        '
        Me.btnTransferFunds.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnTransferFunds.Location = New System.Drawing.Point(320, 186)
        Me.btnTransferFunds.Name = "btnTransferFunds"
        Me.btnTransferFunds.Size = New System.Drawing.Size(215, 51)
        Me.btnTransferFunds.TabIndex = 2
        Me.btnTransferFunds.Text = "Transfer Funds"
        Me.btnTransferFunds.UseVisualStyleBackColor = False
        '
        'btnGetBalances
        '
        Me.btnGetBalances.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnGetBalances.Location = New System.Drawing.Point(25, 69)
        Me.btnGetBalances.Name = "btnGetBalances"
        Me.btnGetBalances.Size = New System.Drawing.Size(215, 70)
        Me.btnGetBalances.TabIndex = 3
        Me.btnGetBalances.Text = "Get Balances"
        Me.btnGetBalances.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Hello "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(239, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "What  would you like to do today?"
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerName.Location = New System.Drawing.Point(65, 16)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(84, 16)
        Me.lblCustomerName.TabIndex = 6
        Me.lblCustomerName.Text = "Cole Eddy,"
        '
        'btnCreditCardPayment
        '
        Me.btnCreditCardPayment.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCreditCardPayment.Location = New System.Drawing.Point(320, 253)
        Me.btnCreditCardPayment.Name = "btnCreditCardPayment"
        Me.btnCreditCardPayment.Size = New System.Drawing.Size(215, 51)
        Me.btnCreditCardPayment.TabIndex = 7
        Me.btnCreditCardPayment.Text = "Make a Payment"
        Me.btnCreditCardPayment.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(25, 274)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(215, 70)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "Done"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'frmNavigator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(557, 356)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCreditCardPayment)
        Me.Controls.Add(Me.lblCustomerName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnGetBalances)
        Me.Controls.Add(Me.btnTransferFunds)
        Me.Controls.Add(Me.btnMakeDeposit)
        Me.Controls.Add(Me.btnMakeWithdrawal)
        Me.Name = "frmNavigator"
        Me.Text = "Navigator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnMakeWithdrawal As Button
    Friend WithEvents btnMakeDeposit As Button
    Friend WithEvents btnTransferFunds As Button
    Friend WithEvents btnGetBalances As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents btnCreditCardPayment As Button
    Friend WithEvents btnClose As Button
End Class
