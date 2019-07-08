Namespace Connection
    Public Class RealConnection : Implements IConnection
        Public Function ConnectTo(address As String) As String Implements IConnection.ConnectTo
            Return String.Format("Connecting to: {0}", address)
        End Function
    End Class
End Namespace
