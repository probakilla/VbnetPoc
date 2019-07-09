Imports DesignPatterns.Car

Namespace Visitor
    Public Class FreeCarVisitor : Implements ICarElementVisitor

        Public Sub Visit(element As ICarElement) Implements ICarElementVisitor.Visit
            element.SetPrice(0)
        End Sub

        Public Sub Visit(car As Car.Car) Implements ICarElementVisitor.Visit
            Dim elements = car.GetElements
            For Each element In elements
                element.Accept(Me)
            Next
        End Sub
    End Class
End Namespace
