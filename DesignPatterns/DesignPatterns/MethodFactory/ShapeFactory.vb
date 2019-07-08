Imports DesignPatterns.Flyweight
Imports DesignPatterns.Shapes

Namespace MethodFactory
    Public Class ShapeFactory : Implements IFactory
        Private RectangleFactory As RectangleFlywieght
        Private CircleFactory As CircleFlyweight

        Private Const RECTANGLE = "rectangle"
        Private Const CIRCLE = "circle"

        Public Sub New()
            RectangleFactory = New RectangleFlywieght()
            CircleFactory = New CircleFlyweight()
        End Sub

        Public Function GetShape(shapeType As String) As IShape Implements IFactory.GetShape
            If RECTANGLE.Equals(shapeType.ToLower) Then
                Return RectangleFactory.GetRectangle(0, 0)
            ElseIf CIRCLE.Equals(shapeType.ToLower) Then
                Return CircleFactory.GetCircle(0)
            Else
                Throw New UnknownShapeException("This shape does not exists")
            End If
        End Function
    End Class
End Namespace