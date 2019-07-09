Namespace Command
    Public Class BuyStock : Implements IOrder
        Private ReadOnly stock As Stock

        Public Sub New(stock As Stock)
            Me.stock = stock
        End Sub

        Public Function Execute() As String Implements IOrder.Execute
            Return stock.Buy()
        End Function
    End Class
End Namespace
