Imports System.Text

Namespace Builder
    Public Class LatexBuilder : Implements IBuilder
        Private Document As StringBuilder

        Public Sub New()
            Document = New StringBuilder()
        End Sub

        Public Sub InitDocument() Implements IBuilder.InitDocument
            Document.Append("\documentclass{article}").AppendLine()
            Document.Append("\begin{document}").AppendLine()
        End Sub

        Public Sub MakeTitle(title As String) Implements IBuilder.MakeTitle
            Document.Append("\title{" & title & "}").AppendLine()
        End Sub

        Public Sub MakeHeader(header As String) Implements IBuilder.MakeHeader
            Document.Append("\section{" & header & "}").AppendLine()
        End Sub

        Public Sub MakeParagraph(text As String) Implements IBuilder.MakeParagraph
            Document.Append(text)
        End Sub

        Public Sub MakeNewline() Implements IBuilder.MakeNewline
            Document.AppendLine().AppendLine()
        End Sub

        Public Function GetDocument() As String Implements IBuilder.GetDocument
            Document.Append("\end{document}")
            Return Document.ToString
        End Function
    End Class
End Namespace
