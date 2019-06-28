Namespace Shapes
    Public Class Circle : Implements Shape
        Private Property Radius As Integer

        Public Sub New(radius As Integer)
            Me.Radius = radius
        End Sub

        Private Function Draw() As String Implements Shape.Draw
            Return String.Format("[Circle] Radius : {0}", Radius)
        End Function
    End Class
End Namespace