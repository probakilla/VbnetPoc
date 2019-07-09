Imports DesignPatterns.Car

Namespace Visitor
    Public Class ReductionVisitor : Implements ICarElementVisitor
        Private Sale As Double

        Public Sub New(sale As Double)
            Me.Sale = sale
        End Sub

        Public Sub Visit(element As ICarElement) Implements ICarElementVisitor.Visit
            Dim elementPrice As Integer = element.GetPrice
            Dim reducedPrice As Integer = CInt(elementPrice * Sale)
            element.SetPrice(reducedPrice)
        End Sub

        Public Sub Visit(car As Car.Car) Implements ICarElementVisitor.Visit
            For Each element In car.GetElements
                element.Accept(Me)
            Next
        End Sub
    End Class
End Namespace
