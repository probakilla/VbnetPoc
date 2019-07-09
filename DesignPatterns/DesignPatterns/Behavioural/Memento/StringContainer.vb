Namespace Memento
    Public Class StringContainer
        Public State As String = String.Empty

        Public Sub SetState(state As String)
            Me.State = state
        End Sub

        Public Function GetState() As String
            Return State
        End Function

        Public Function SaveState() As Memento
            Return New Memento(State)
        End Function

        Public Sub RestoreState(memento As Memento)
            State = memento.GetState
        End Sub
    End Class
End Namespace
