Namespace Observer
    Public MustInherit Class AbstractObserver : Implements IObserver
        Protected Subject As Subject

        Public Sub New(subject As Subject)
            Me.Subject = subject
            subject.Attach(Me)
        End Sub

        Public MustOverride Function Update() As String Implements IObserver.Update
    End Class
End Namespace
