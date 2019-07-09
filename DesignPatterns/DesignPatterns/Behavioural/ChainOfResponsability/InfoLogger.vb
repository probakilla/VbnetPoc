Namespace ChainOfResponsability
    Public Class InfoLogger : Inherits AbstractLogger
        Public Sub New(level As Integer)
            MyBase.New(level)
        End Sub

        Protected Overrides Function Write(message As String) As String
            Return String.Format("Info> {0}", message)
        End Function
    End Class
End Namespace
