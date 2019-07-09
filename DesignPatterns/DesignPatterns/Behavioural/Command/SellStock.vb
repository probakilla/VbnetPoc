Namespace Command
    Public Class SellStock : Implements IOrder
        Private ReadOnly stock As Stock

        Public Sub New(stock As Stock)
            Me.stock = stock
        End Sub

        Public Function Execute() As String Implements IOrder.Execute
            Return stock.Sell()
        End Function
    End Class
End Namespace