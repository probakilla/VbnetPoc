Namespace Shapes
    Public Class Rectangle : Implements IShape
        Private ReadOnly Width As Integer
        Private ReadOnly Height As Integer

        Public Sub New(width As Integer, height As Integer)
            Me.Width = width
            Me.Height = height
        End Sub

        Public Function Draw() As String Implements IShape.Draw
            Return String.Format("[Rectangle] Width : {0}, Height : {1}", Width, Height)
        End Function
    End Class
End Namespace
