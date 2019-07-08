Imports DesignPatterns.Car

Namespace Visitor
    Public Class AddPriceVisitor : Implements ICarElementVisitor
        Private PriceToAdd As Integer

        Public Sub New(price As Integer)
            PriceToAdd = price
        End Sub

        Public Sub Visit(element As ICarElement) Implements ICarElementVisitor.Visit
            Dim elementPrice = element.GetPrice
            element.SetPrice(elementPrice + PriceToAdd)
        End Sub

        Public Sub Visit(car As Car.Car) Implements ICarElementVisitor.Visit
            Dim elements = car.GetElements
            For Each element In elements
                element.Accept(Me)
            Next
        End Sub
    End Class
End Namespace
