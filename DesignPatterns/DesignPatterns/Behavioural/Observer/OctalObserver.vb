Namespace Observer
    Public Class OctalObserver : Inherits AbstractObserver
        Public Sub New(subject As Subject)
            MyBase.New(subject)
        End Sub

        Public Overrides Function Update() As String
            Return String.Format("Oct: {0}", ToOctal(Subject.GetState))
        End Function

        Private Function ToOctal(int As Integer) As String
            Return Convert.ToString(int, 8)
        End Function
    End Class
End Namespace