Imports POCVB.Visitor

Namespace Car
    Public Class Car
        Private Property CarElements As List(Of CarElement)

        Public Sub New()
            CarElements = New List(Of CarElement) From
                {
                New Wheel("front left", 100),
                New Wheel("front right", 100),
                New Wheel("back left", 100),
                New Wheel("back right", 100),
                New Body(1100), New Engine(500)
            }
        End Sub

        Public Function GetElements() As List(Of CarElement)
            Return CarElements
        End Function

        Public Function GetTotalPrice() As Integer
            Dim totalPrice As Integer
            For Each element In CarElements
                totalPrice += element.GetPrice
            Next
            Return totalPrice
        End Function

        Public Sub Accept(visitor As CarElementVisitor)
            visitor.Visit(Me)
        End Sub
    End Class
End Namespace
