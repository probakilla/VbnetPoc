Imports POCVB.Car

Namespace Visitor
    Public Interface CarElementVisitor
        Sub Visit(element As CarElement)
        Sub Visit(car As Car.Car)
    End Interface
End Namespace
