Imports System.Text

Namespace Builder
    Public Class MarkDownBuilder : Implements IBuilder
        Private Document As StringBuilder

        Public Sub New()
            Document = New StringBuilder()
        End Sub

        Public Sub InitDocument() Implements IBuilder.InitDocument
            Document.Append(String.Empty)
        End Sub

        Public Sub MakeTitle(title As String) Implements IBuilder.MakeTitle
            Document.Append("# " & title).AppendLine()
        End Sub

        Public Sub MakeHeader(header As String) Implements IBuilder.MakeHeader
            Document.Append("## " & header).AppendLine()
        End Sub

        Public Sub MakeParagraph(text As String) Implements IBuilder.MakeParagraph
            Document.Append(text)
        End Sub

        Public Sub MakeNewline() Implements IBuilder.MakeNewline
            Document.AppendLine()
        End Sub

        Public Function GetDocument() As String Implements IBuilder.GetDocument
            Return Document.ToString
        End Function
    End Class
End Namespace
