Imports System.Text

Namespace Builder
    Public Class HtmlBuilder : Implements IBuilder
        Private Document As StringBuilder

        Public Sub New()
            Document = New StringBuilder()
        End Sub

        Public Sub InitDocument() Implements IBuilder.InitDocument
            Document.Append("<!DOCTYPE>").AppendLine()
            Document.Append("<html>").AppendLine()
            Document.Append("<body>").AppendLine()
        End Sub

        Public Sub MakeTitle(title As String) Implements IBuilder.MakeTitle
            Document.Append(String.Empty)
        End Sub

        Public Sub MakeHeader(header As String) Implements IBuilder.MakeHeader
            Document.Append("<h3>" & header & "</h3>").AppendLine()
        End Sub

        Public Sub MakeParagraph(text As String) Implements IBuilder.MakeParagraph
            Document.Append("<p>" & text & "</p>")
        End Sub

        Public Sub MakeNewline() Implements IBuilder.MakeNewline
            Document.Append("<br>").AppendLine()
        End Sub

        Public Function GetDocument() As String Implements IBuilder.GetDocument
            Document.Append("</body>").AppendLine()
            Document.Append("</html>").AppendLine()
            Return Document.ToString
        End Function
    End Class
End Namespace
