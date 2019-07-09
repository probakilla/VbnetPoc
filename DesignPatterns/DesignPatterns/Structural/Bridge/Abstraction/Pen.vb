Namespace Bridge
    Public Class Pen : Inherits AbstractTool
        Public Sub New(color As IColorImplementation)
            MyBase.New(color)
        End Sub

        Public Overrides Function Draw() As String
            Return Color.Draw()
        End Function
    End Class
End Namespace
