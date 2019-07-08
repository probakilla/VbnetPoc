Imports DesignPatterns.Shapes

Namespace MethodFactory
    Public Interface IFactory
        Function GetShape(shapeType As String) As IShape
    End Interface
End Namespace