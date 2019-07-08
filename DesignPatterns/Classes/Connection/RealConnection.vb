Namespace Connection
    Public Class RealConnection : Implements IConnection
        Public Function ConnectTo(address As String) As String Implements IConnection.ConnectTo
            Return "Connecting to: " & address
        End Function
    End Class
End Namespace
