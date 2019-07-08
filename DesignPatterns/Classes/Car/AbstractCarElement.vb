Imports DesignPatterns.Visitor

Namespace Car
    Public MustInherit Class AbstractCarElement : Implements ICarElement
        Protected Price As Integer

        Public Sub New(price As Integer)
            Me.Price = price
        End Sub

        Public Sub Accept(visitor As ICarElementVisitor) Implements ICarElement.Accept
            visitor.Visit(Me)
        End Sub

        Public Sub SetPrice(price As Integer) Implements ICarElement.SetPrice
            Me.Price = price
        End Sub

        Public Function GetPrice() As Integer Implements ICarElement.GetPrice
            Return Price
        End Function
    End Class
End Namespace
