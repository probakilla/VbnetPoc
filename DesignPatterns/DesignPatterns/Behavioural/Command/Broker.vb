Imports System.Text

Namespace Command
    Public Class Broker
        Private Orders As List(Of IOrder)

        Public Sub New()
            Orders = New List(Of IOrder)
        End Sub

        Public Sub TakeOrder(order As IOrder)
            Orders.Add(order)
        End Sub

        Public Function PlaceOrders() As String
            Dim strBuilder = New StringBuilder
            For Each order In Orders
                strBuilder.Append(order.Execute()).AppendLine()
            Next
            Orders.Clear()
            Return strBuilder.ToString
        End Function
    End Class
End Namespace
