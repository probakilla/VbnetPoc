Imports DesignPatterns.Visitor

Namespace Car
    Public Interface ICarElement
        Sub Accept(visitor As ICarElementVisitor)
        Function GetPrice() As Integer
        Sub SetPrice(price As Integer)
    End Interface
End Namespace