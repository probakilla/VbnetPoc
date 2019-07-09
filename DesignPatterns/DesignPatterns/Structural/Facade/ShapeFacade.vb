Imports DesignPatterns.Shapes

Namespace Facade
    Public Class ShapeFacade
        Private Circle As IShape
        Private Rectangle As IShape

        Public Sub New()
            Circle = New Circle(2)
            Rectangle = New Rectangle(2, 2)
        End Sub

        Public Function DrawCircle() As String
            Return Circle.Draw
        End Function

        Public Function DrawRectangle() As String
            Return Rectangle.Draw
        End Function
    End Class
End Namespace
