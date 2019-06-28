Imports DesignPatterns.Visitor

Namespace Car
    Public Interface CarElement
        Sub Accept(visitor As CarElementVisitor)
        Function GetPrice() As Integer
        Sub SetPrice(price As Integer)
    End Interface
End Namespace