Namespace Singleton
    Public Class CalculatorSingleton
        Private Shared INSTANCE As CalculatorSingleton = Nothing

        Private Sub New()
        End Sub

        Public Shared Function GetInstance() As CalculatorSingleton
            If INSTANCE Is Nothing Then
                INSTANCE = New CalculatorSingleton
            End If
            Return INSTANCE
        End Function

        Public Function Addition(a As Integer, b As Integer) As Integer
            Return a + b
        End Function

        Public Function Substraction(a As Integer, b As Integer) As Integer
            Return a - b
        End Function

        Public Function Multiplication(a As Integer, b As Integer) As Integer
            Return a * b
        End Function

        Public Function Division(a As Integer, b As Integer) As Double
            If b = 0 Then
                Throw New ArithmeticException
            End If
            Return a / b
        End Function
    End Class
End Namespace
