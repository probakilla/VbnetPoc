Imports System.Text

Namespace StrnigVsConcat
    Public Class StringBuilderVsConcat
        Private NbIter As Integer

        Private Const CONCAT_TEXT = "01234567890123456789"

        Sub New(nbIter As Integer)
            Me.NbIter = nbIter
        End Sub

        Public Sub RunTests()
            Console.WriteLine("Iteration number : " & NbIter & vbCrLf)
            DisplayResultStringConcatOperator()
            DisplayResultStringBuilder()
            DisplayStringConcatMethodResults()
        End Sub

        Private Sub DisplayResultStringConcatOperator()
            Dim elapsedTime As Stopwatch = TestStringConcatOperator()
            Dim displayString As String = BuildDisplayString("String Concat Operator", elapsedTime)
            Console.WriteLine(displayString)
        End Sub

        Public Function TestStringConcatOperator() As Stopwatch
            Dim stopwatch As New Stopwatch()
            Dim testString As String = String.Empty
            stopwatch.Start()
            For i = 0 To NbIter
                testString &= CONCAT_TEXT
            Next
            stopwatch.Stop()
            Return stopwatch
        End Function

        Private Sub DisplayResultStringBuilder()
            Dim elapsedTime As Stopwatch = TestStringBuilder()
            Dim displayString As String = BuildDisplayString("String Builder", elapsedTime)
            Console.WriteLine(displayString)
        End Sub

        Public Function TestStringBuilder() As Stopwatch
            Dim stopwatch As New Stopwatch()
            Dim stringBuilder As New StringBuilder(String.Empty)
            stopwatch.Start()
            For i = 0 To NbIter
                stringBuilder.Append(CONCAT_TEXT)
            Next
            stopwatch.Stop()
            Return stopwatch
        End Function

        Private Sub DisplayStringConcatMethodResults()
            Dim elapsedTime As Stopwatch = TestStringConcatMethod()
            Dim displayString As String = BuildDisplayString("String Concat Method", elapsedTime)
            Console.WriteLine(displayString)
        End Sub

        Public Function TestStringConcatMethod() As Stopwatch
            Dim stopwatch As New Stopwatch()
            Dim str As String = String.Empty
            stopwatch.Start()
            For i = 0 To NbIter
                str = String.Concat(str, CONCAT_TEXT)
            Next
            stopwatch.Stop()
            Return stopwatch
        End Function

        Private Function BuildDisplayString(type As String, stopwatch As Stopwatch)
            Dim displayString As String =
                "Result from " & type & " : " & vbCrLf &
                "  Execution time : " & stopwatch.ElapsedTicks & " ticks" & vbCrLf &
                "  Execution time : " & stopwatch.ElapsedMilliseconds & "ms" & vbCrLf
            Return displayString
        End Function

        Private Function GetElapsedTime(timeSpan As TimeSpan) As String
            Dim elapsedTime As String = String.Format("{0:00}:{1:00}:{2:00}.{3:00000000}",
                                                      timeSpan.Hours, timeSpan.Minutes,
                                                      timeSpan.Seconds, timeSpan.Milliseconds)
            Return elapsedTime
        End Function
    End Class
End Namespace