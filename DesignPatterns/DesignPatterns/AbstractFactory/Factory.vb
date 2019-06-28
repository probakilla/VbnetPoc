Imports DesignPatterns.Shapes

Namespace AbstractFactory
    Public Interface Factory
        Function GetShape(shapeType As String) As Shape
    End Interface
End Namespace