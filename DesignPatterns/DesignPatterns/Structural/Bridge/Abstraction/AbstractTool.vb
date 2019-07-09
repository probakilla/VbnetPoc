Namespace Bridge
    Public MustInherit Class AbstractTool
        Protected ReadOnly Color As IColorImplementation

        Public Sub New(color As IColorImplementation)
            Me.Color = color
        End Sub

        Public MustOverride Function Draw() As string
    End Class
End Namespace
