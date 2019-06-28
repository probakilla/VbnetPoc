Imports DesignPatterns.Visitor

Namespace Car
    Public MustInherit Class AbstractCarElement : Implements CarElement
        Protected Property Price As Integer

        Public Sub New(price As Integer)
            Me.Price = price
        End Sub

        Public Sub Accept(visitor As CarElementVisitor) Implements CarElement.Accept
            visitor.Visit(Me)
        End Sub

        Public Sub SetPrice(price As Integer) Implements CarElement.SetPrice
            Me.Price = price
        End Sub

        Public Function GetPrice() As Integer Implements CarElement.GetPrice
            Return Price
        End Function
    End Class
End Namespace
