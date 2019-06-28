Imports POCVB.Car

Namespace Visitor
    Public Class ReductionVisitor : Implements CarElementVisitor
        Private Property Sale As Double

        Public Sub New(sale As Double)
            Me.Sale = sale
        End Sub

        Public Sub Visit(element As CarElement) Implements CarElementVisitor.Visit
            Dim elementPrice = element.GetPrice
            element.SetPrice(elementPrice * Sale)
        End Sub

        Public Sub Visit(car As Car.Car) Implements CarElementVisitor.Visit
            For Each element In car.GetElements
                element.Accept(Me)
            Next
        End Sub
    End Class
End Namespace
