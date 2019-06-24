Imports System.Text

Public Class StringBuilderVsConcat
    Private NbIter As Integer

    Const CONCAT_TEXT = "01234567890123456789"
    Sub New(nbIter As Integer)
        Me.NbIter = nbIter
        RunTests()
    End Sub

    Public Sub RunTests()
        TestStringConcat()
        TestStringBuilder()
    End Sub

    Private Sub TestStringConcat()
        Dim stopwatch As New Stopwatch()
        Dim testString As String = String.Empty
        stopwatch.Start()
        For i = 0 To NbIter
            testString &= CONCAT_TEXT
        Next
        stopwatch.Stop()
        Dim elapsedTime As String = stopwatch.ElapsedTicks
        Dim displayString As String = BuildDisplayString("String Concat", elapsedTime, testString)
        Console.WriteLine(displayString)
    End Sub

    Private Sub TestStringBuilder()
        Dim stopwatch As New Stopwatch()
        Dim stringBuilder As New StringBuilder(String.Empty)
        stopwatch.Start()
        For i = 0 To NbIter
            stringBuilder.Append(CONCAT_TEXT)
        Next
        stopwatch.Stop()
        Dim elapsedTime As String = stopwatch.ElapsedTicks
        Dim displayString As String = BuildDisplayString("String Builder", elapsedTime, stringBuilder.ToString)
        Console.WriteLine(displayString)
    End Sub

    Private Function BuildDisplayString(type As String, elapsedTime As String, str As String)
        Dim displayString As String =
            "Result from " & type & " : " & vbCrLf &
            "  Iteration number : " & NbIter & vbCrLf &
            "  Execution time : " & elapsedTime & vbCrLf &
            "  String length : " & str.Length & vbCrLf
        Return displayString
    End Function
End Class
