Imports DesignPatterns.Connection

Namespace Proxy
    Public Class ProxyConnection : Implements IConnection
        Private Connection As IConnection = New RealConnection()
        Private BannedSites As New List(Of String) From {"banned.com", "forbiden.com"}

        Public Function ConnectTo(address As String) As String Implements IConnection.ConnectTo
            If BannedSites.Contains(address.ToLower) Then
                Return "DENIED"
            Else
                Return Connection.ConnectTo(address)
            End If
        End Function
    End Class
End Namespace