Imports DesignPatterns.Visitor

Namespace Car
    Public Class Car
        Private CarElements As List(Of ICarElement)

        Public Sub New()
            CarElements = New List(Of ICarElement) From
                {
                New Wheel("front left", 100),
                New Wheel("front right", 100),
                New Wheel("back left", 100),
                New Wheel("back right", 100),
                New Body(1100), New Engine(500)
            }
        End Sub

        Public Function GetElements() As List(Of ICarElement)
            Return CarElements
        End Function

        Public Function GetTotalPrice() As Integer
            Dim totalPrice As Integer
            For Each element In CarElements
                totalPrice += element.GetPrice
            Next
            Return totalPrice
        End Function

        Public Sub Accept(visitor As ICarElementVisitor)
            visitor.Visit(Me)
        End Sub
    End Class
End Namespace
