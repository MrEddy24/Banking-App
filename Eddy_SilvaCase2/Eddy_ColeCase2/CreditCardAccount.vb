Option Strict On
Public Class CreditCardAccount
    Public HiddenCreditCardAccountID As Integer
    Public HiddenAccountBalance As Double = 12000.86
    Public HiddenClosed As Boolean

    Public AccountHistory As New List(Of AccountTransaction)
    Public Sub New()

    End Sub

    Public Sub New(argID As Integer, argBeginningBalance As Double)
        HiddenCreditCardAccountID = argID
        HiddenAccountBalance = argBeginningBalance

    End Sub

    Public ReadOnly Property GetID As Integer
        Get
            Return HiddenCreditCardAccountID
        End Get
    End Property

    Public ReadOnly Property GetBalance As Double
        Get
            Return HiddenAccountBalance
        End Get
    End Property

    Public Sub CloseAccount()
        HiddenClosed = True
    End Sub

    Public Function MakeWithdrawal(ByVal amount As Double) As Double
        If (HiddenAccountBalance > amount) Then
            HiddenAccountBalance = HiddenAccountBalance - amount
            'AccountTransaction.RecordTransaction(amount, TransTypeEnum.WithdrawalOut,
            '    "Withdrawal completed", AccountHistory)
        Else
            'AccountTransaction.RecordTransaction(0, TransTypeEnum.WithdrawalOut,
            '    "Withdrawal failed - insufficient funds", AccountHistory)

            'Throw New System.ArgumentOutOfRangeException()
        End If

        Return HiddenAccountBalance
    End Function

    Public Function MakeDeposit(ByVal amount As Double) As Double
        If (amount < 0) Then
            'AccountTransaction.RecordTransaction(0, TransTypeEnum.DepositIn,
            '    "Deposit failed - amount not positive", AccountHistory)
            Throw New System.ArgumentOutOfRangeException()
        Else
            'AccountTransaction.RecordTransaction(amount, TransTypeEnum.DepositIn,
            '    "Deposit completed", AccountHistory)
            HiddenAccountBalance = HiddenAccountBalance + amount
        End If
        Return HiddenAccountBalance
    End Function
End Class
