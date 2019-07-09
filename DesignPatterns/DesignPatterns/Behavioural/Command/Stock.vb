Namespace Command
    Public Class Stock
        Private ReadOnly Name As String
        Private ReadOnly Quantity As Integer

        Public Sub New(name As String, quantity As Integer)
            Me.Name = name
            Me.Quantity = quantity
        End Sub

        Public Function Buy() As String
            Return String.Format("Stock [Name: {0}, Quantity: {1}] bought", Name, Quantity.ToString)
        End Function

        Public Function Sell() As String
            Return String.Format("Stock [Name: {0}, Quantity: {1}] sold", Name, Quantity.ToString)
        End Function
    End Class
End Namespace
