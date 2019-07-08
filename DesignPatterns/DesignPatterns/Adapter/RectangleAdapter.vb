Imports DesignPatterns.Shapes

Namespace Adapter
    Public Class RectangleAdapter : Implements IShape
        Private Rectangle As Rectangle

        Public Sub New(x1 As Integer, x2 As Integer, y1 As Integer, y2 As Integer)
            Dim width = Math.Abs(x1 - x2)
            Dim height = Math.Abs(y1 - y2)
            Rectangle = New Rectangle(width, height)
        End Sub

        Public Function Draw() As String Implements IShape.Draw
            Return Rectangle.Draw
        End Function
    End Class
End Namespace
