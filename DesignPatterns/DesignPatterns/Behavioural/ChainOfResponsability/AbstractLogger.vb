Namespace ChainOfResponsability
    Public MustInherit Class AbstractLogger
        Public Shared ReadOnly INFO As Integer = 1
        Public Shared ReadOnly DEBUG As Integer = 2
        Public Shared ReadOnly ERR As Integer = 3

        Protected Level As Integer
        Protected NextLogger As AbstractLogger

        Public Sub New(level As Integer)
            Me.Level = level
        End Sub

        Public Sub SetNextLogger(logger As AbstractLogger)
            NextLogger = logger
        End Sub

        Public Function LogMessage(level As Integer, message As String) As String
            If Me.Level <= level Then
                Return Write(message)
            End If
            If NextLogger Is Nothing Then
                Return "ERROR"
            End If
            Return NextLogger.LogMessage(level, message)
        End Function

        Protected MustOverride Function Write(message As String) As String
    End Class
End Namespace
