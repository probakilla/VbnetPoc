Imports POCVB.Car

Namespace Visitor
    Public Class FreeCarVisitor : Implements CarElementVisitor

        Public Sub Visit(element As CarElement) Implements CarElementVisitor.Visit
            element.SetPrice(0)
        End Sub

        Public Sub Visit(car As Car.Car) Implements CarElementVisitor.Visit
            Dim elements = car.GetElements
            For Each element In elements
                element.Accept(Me)
            Next
        End Sub
    End Class
End Namespace
