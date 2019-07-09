Namespace Observer
    Public Class BinaryObserver : Inherits AbstractObserver
        Public Sub New(subject As Subject)
            MyBase.New(subject)
        End Sub

        Public Overrides Function Update() As String
            Return String.Format("Bin: {0}", ToBinary(Subject.GetState))
        End Function

        Private Function ToBinary(int As Integer) As String
            Return Convert.ToString(int, 2).PadLeft(32, "0"c)
        End Function
    End Class
End Namespace
