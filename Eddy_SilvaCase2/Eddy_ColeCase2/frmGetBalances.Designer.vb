<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGetBalances
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
        Me.btnDone = New System.Windows.Forms.Button()
        Me.btnAnotherTransactions = New System.Windows.Forms.Button()
        Me.lblCreditBalance = New System.Windows.Forms.Label()
        Me.lblSavingsBalance = New System.Windows.Forms.Label()
        Me.lblCheckingBalance = New System.Windows.Forms.Label()
        Me.btnCheckingBalance = New System.Windows.Forms.Button()
        Me.btnCreditCardBalance = New System.Windows.Forms.Button()
        Me.btnSavingsBalance = New System.Windows.Forms.Button()
        Me.PanelAccountBalances = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelAccountBalances.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDone
        '
        Me.btnDone.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnDone.Location = New System.Drawing.Point(327, 270)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(215, 70)
        Me.btnDone.TabIndex = 22
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = False
        '
        'btnAnotherTransactions
        '
        Me.btnAnotherTransactions.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAnotherTransactions.Location = New System.Drawing.Point(327, 194)
        Me.btnAnotherTransactions.Name = "btnAnotherTransactions"
        Me.btnAnotherTransactions.Size = New System.Drawing.Size(215, 70)
        Me.btnAnotherTransactions.TabIndex = 23
        Me.btnAnotherTransactions.Text = "Another Transaction"
        Me.btnAnotherTransactions.UseVisualStyleBackColor = False
        '
        'lblCreditBalance
        '
        Me.lblCreditBalance.AutoSize = True
        Me.lblCreditBalance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblCreditBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreditBalance.Location = New System.Drawing.Point(199, 218)
        Me.lblCreditBalance.Name = "lblCreditBalance"
        Me.lblCreditBalance.Size = New System.Drawing.Size(51, 18)
        Me.lblCreditBalance.TabIndex = 30
        Me.lblCreditBalance.Text = "Label3"
        '
        'lblSavingsBalance
        '
        Me.lblSavingsBalance.AutoSize = True
        Me.lblSavingsBalance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblSavingsBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSavingsBalance.Location = New System.Drawing.Point(199, 143)
        Me.lblSavingsBalance.Name = "lblSavingsBalance"
        Me.lblSavingsBalance.Size = New System.Drawing.Size(51, 18)
        Me.lblSavingsBalance.TabIndex = 29
        Me.lblSavingsBalance.Text = "Label2"
        '
        'lblCheckingBalance
        '
        Me.lblCheckingBalance.AutoSize = True
        Me.lblCheckingBalance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblCheckingBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCheckingBalance.Location = New System.Drawing.Point(199, 67)
        Me.lblCheckingBalance.Name = "lblCheckingBalance"
        Me.lblCheckingBalance.Size = New System.Drawing.Size(51, 18)
        Me.lblCheckingBalance.TabIndex = 28
        Me.lblCheckingBalance.Text = "Label1"
        '
        'btnCheckingBalance
        '
        Me.btnCheckingBalance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCheckingBalance.Location = New System.Drawing.Point(12, 51)
        Me.btnCheckingBalance.Name = "btnCheckingBalance"
        Me.btnCheckingBalance.Size = New System.Drawing.Size(163, 53)
        Me.btnCheckingBalance.TabIndex = 25
        Me.btnCheckingBalance.Text = "Checking Balance"
        Me.btnCheckingBalance.UseVisualStyleBackColor = False
        '
        'btnCreditCardBalance
        '
        Me.btnCreditCardBalance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCreditCardBalance.Location = New System.Drawing.Point(12, 202)
        Me.btnCreditCardBalance.Name = "btnCreditCardBalance"
        Me.btnCreditCardBalance.Size = New System.Drawing.Size(163, 53)
        Me.btnCreditCardBalance.TabIndex = 27
        Me.btnCreditCardBalance.Text = "Credit Card Balance"
        Me.btnCreditCardBalance.UseVisualStyleBackColor = False
        '
        'btnSavingsBalance
        '
        Me.btnSavingsBalance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSavingsBalance.Location = New System.Drawing.Point(12, 126)
        Me.btnSavingsBalance.Name = "btnSavingsBalance"
        Me.btnSavingsBalance.Size = New System.Drawing.Size(163, 54)
        Me.btnSavingsBalance.TabIndex = 26
        Me.btnSavingsBalance.Text = "Savings Balance"
        Me.btnSavingsBalance.UseVisualStyleBackColor = False
        '
        'PanelAccountBalances
        '
        Me.PanelAccountBalances.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PanelAccountBalances.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelAccountBalances.Controls.Add(Me.Label1)
        Me.PanelAccountBalances.Controls.Add(Me.lblCreditBalance)
        Me.PanelAccountBalances.Controls.Add(Me.lblSavingsBalance)
        Me.PanelAccountBalances.Controls.Add(Me.lblCheckingBalance)
        Me.PanelAccountBalances.Controls.Add(Me.btnCheckingBalance)
        Me.PanelAccountBalances.Controls.Add(Me.btnCreditCardBalance)
        Me.PanelAccountBalances.Controls.Add(Me.btnSavingsBalance)
        Me.PanelAccountBalances.Location = New System.Drawing.Point(10, 12)
        Me.PanelAccountBalances.Name = "PanelAccountBalances"
        Me.PanelAccountBalances.Size = New System.Drawing.Size(306, 327)
        Me.PanelAccountBalances.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 20)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Account Balances:"
        '
        'frmGetBalances
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(557, 356)
        Me.Controls.Add(Me.btnAnotherTransactions)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.PanelAccountBalances)
        Me.Name = "frmGetBalances"
        Me.Text = "frmGetBalances"
        Me.PanelAccountBalances.ResumeLayout(False)
        Me.PanelAccountBalances.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnDone As Button
    Friend WithEvents btnAnotherTransactions As Button
    Friend WithEvents lblCreditBalance As Label
    Friend WithEvents lblSavingsBalance As Label
    Friend WithEvents lblCheckingBalance As Label
    Friend WithEvents btnCheckingBalance As Button
    Friend WithEvents btnCreditCardBalance As Button
    Friend WithEvents btnSavingsBalance As Button
    Friend WithEvents PanelAccountBalances As Panel
    Friend WithEvents Label1 As Label
End Class
