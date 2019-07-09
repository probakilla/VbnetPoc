Namespace Memento
    Public Class Memento
        Private ReadOnly State As String

        Public Sub New(state As String)
            Me.State = state
        End Sub

        Public Function GetState() As String
            Return State
        End Function
    End Class
End Namespace
