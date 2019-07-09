Imports DesignPatterns.Car

Namespace Visitor
    Public Interface ICarElementVisitor
        Sub Visit(element As ICarElement)
        Sub Visit(car As Car.Car)
    End Interface
End Namespace
