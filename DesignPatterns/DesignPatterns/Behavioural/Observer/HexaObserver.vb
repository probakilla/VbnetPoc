Namespace Observer
    Public Class HexaObserver : Inherits AbstractObserver
        Public Sub New(subject As Subject)
            MyBase.New(subject)
        End Sub

        Public Overrides Function Update() As String
            Return String.Format("Hex: {0}", ToHex(Subject.GetState))
        End Function

        Private Function ToHex(int As Integer) As String
            Return Convert.ToString(int, 16)
        End Function
    End Class
End Namespace