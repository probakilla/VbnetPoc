Imports DesignPatterns.Car

Namespace Visitor
    Public Class AddPriceVisitor : Implements CarElementVisitor
        Private Property PriceToAdd As Integer

        Public Sub New(price As Integer)
            PriceToAdd = price
        End Sub

        Public Sub Visit(element As CarElement) Implements CarElementVisitor.Visit
            Dim elementPrice = element.GetPrice
            element.SetPrice(elementPrice + PriceToAdd)
        End Sub

        Public Sub Visit(car As Car.Car) Implements CarElementVisitor.Visit
            Dim elements = car.GetElements
            For Each element In elements
                element.Accept(Me)
            Next
        End Sub
    End Class
End Namespace
