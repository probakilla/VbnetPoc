Namespace Bridge
    Public MustInherit Class AbstractColor : Implements IColorImplementation
        Protected ReadOnly Color As String

        Public Sub New(color As String)
            Me.Color = color
        End Sub

        Public Function Draw() As String Implements IColorImplementation.Draw
            Return Color
        End Function
    End Class
End Namespace
