Imports System.IO
Imports System.Text

Namespace StrnigVsConcat
    Public Class CsvPerfBuilder
        Private Property IterationStep As Integer
        Private Property MaxIterations As Integer
        Private Property CsvScaleStringBuilder As StringBuilder
        Private Property CvsConcatMethodStringBuilder As StringBuilder
        Private Property CvsConcatOperatorStringBuilder As StringBuilder
        Private Property CvsStringBuilderStringBuilder As StringBuilder
        Private Property TransposedCsvStringBuilder As StringBuilder
        Private Const FileName As String = "C:\Users\frndourpa\Desktop\results.csv"

        Public Sub New(iterationStep As Integer, maxIterations As Integer)
            Me.IterationStep = iterationStep
            Me.MaxIterations = maxIterations
            CsvScaleStringBuilder = New StringBuilder(String.Empty)
            CvsConcatMethodStringBuilder = New StringBuilder(String.Empty)
            CvsConcatOperatorStringBuilder = New StringBuilder(String.Empty)
            CvsStringBuilderStringBuilder = New StringBuilder(String.Empty)
            TransposedCsvStringBuilder = New StringBuilder("Scale, ConcatMethod, ConcatOperator, StringBuilder") _
                .AppendLine()
            RunTransposed()
        End Sub

        Private Sub Run()
            RunTestLoop()
            WriteResults()
        End Sub

        Private Sub RunTransposed()
            RunTransposedLoop()
            WriteTransposedResults()
        End Sub

        Private Sub RunTestLoop()
            For i As Integer = 0 To MaxIterations Step IterationStep
                Dim testClass As New StringBuilderVsConcat(i)
                CsvScaleStringBuilder.Append(i.ToString).Append(",")
                CvsConcatMethodStringBuilder.Append(testClass.TestStringConcatMethod.ElapsedTicks.ToString).Append(",")
                CvsConcatOperatorStringBuilder.Append(testClass.TestStringConcatOperator.ElapsedTicks.ToString).Append(",")
                CvsStringBuilderStringBuilder.Append(testClass.TestStringBuilder.ElapsedTicks.ToString).Append(",")
                testClass = Nothing
            Next
            RemoveStringBuildersLastCharacter()
        End Sub
        Private Sub RunTransposedLoop()
            For i As Integer = 0 To MaxIterations Step IterationStep
                Dim testClass As New StringBuilderVsConcat(i)
                TransposedCsvStringBuilder.Append(i).Append(",")
                TransposedCsvStringBuilder.Append(testClass.TestStringConcatMethod.ElapsedTicks).Append(",")
                TransposedCsvStringBuilder.Append(testClass.TestStringConcatOperator.ElapsedTicks).Append(",")
                TransposedCsvStringBuilder.Append(testClass.TestStringBuilder.ElapsedTicks).AppendLine()
                testClass = Nothing
            Next
            TransposedCsvStringBuilder.Length = TransposedCsvStringBuilder.Length - 1
        End Sub

        Private Sub RemoveStringBuildersLastCharacter()
            CsvScaleStringBuilder.Length = CsvScaleStringBuilder.Length - 1
            CvsConcatMethodStringBuilder.Length = CvsConcatMethodStringBuilder.Length - 1
            CvsConcatOperatorStringBuilder.Length = CvsConcatOperatorStringBuilder.Length - 1
            CvsStringBuilderStringBuilder.Length = CvsStringBuilderStringBuilder.Length - 1
        End Sub

        Private Sub WriteResults()
            CheckFileExists()
            Using stream As New StreamWriter(File.Open(FileName, FileMode.OpenOrCreate))
                stream.WriteLine(CsvScaleStringBuilder.ToString)
                stream.WriteLine(CvsConcatMethodStringBuilder.ToString)
                stream.WriteLine(CvsConcatOperatorStringBuilder.ToString)
                stream.WriteLine(CvsStringBuilderStringBuilder.ToString)
            End Using
        End Sub

        Private Sub WriteTransposedResults()
            CheckFileExists()
            Using stream As New StreamWriter(File.Open(FileName, FileMode.OpenOrCreate))
                stream.Write(TransposedCsvStringBuilder.ToString)
            End Using
        End Sub

        Private Sub CheckFileExists()
            If File.Exists(FileName) Then
                File.Delete(FileName)
            End If
        End Sub
    End Class
End Namespace