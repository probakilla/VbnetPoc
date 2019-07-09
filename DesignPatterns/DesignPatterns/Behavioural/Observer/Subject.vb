Imports System.Text

Namespace Observer
    Public Class Subject
        Private Observers As List(Of IObserver) = New List(Of IObserver)
        Private State As Integer

        Public Function SetState(state As Integer) As String
            Me.State = state
            Return Notify()
        End Function

        Public Function GetState() As Integer
            Return State
        End Function

        Public Sub Attach(observer As IObserver)
            Observers.Add(observer)
        End Sub

        Public Function Notify() As String
            Dim strString = New StringBuilder
            For Each obs In Observers
                strString.Append(obs.Update()).AppendLine()
            Next
            Return strString.ToString
        End Function
    End Class
End Namespace
