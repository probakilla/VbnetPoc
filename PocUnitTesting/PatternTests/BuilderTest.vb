Imports System.Text
Imports DesignPatterns.Builder
Imports Microsoft.VisualStudio.TestTools.UnitTesting

Namespace PocUnitTesting
    <TestClass>
    Public Class BuilderTest
        Private Function BuildDocument(builder As IBuilder) As String
            builder.InitDocument()
            builder.MakeTitle("title")
            builder.MakeHeader("header")
            builder.MakeParagraph("first line")
            builder.MakeNewline()
            builder.MakeParagraph("second line")
            Return builder.GetDocument()
        End Function

        <TestMethod>
        Public Sub MarkdownBuilderTest()
            Dim builder = New MarkDownBuilder()
            Dim document = BuildDocument(builder)
            Dim strBuilder = New StringBuilder()
            strBuilder.Append("# title").AppendLine().Append("## header").AppendLine().Append("first line").AppendLine()
            strBuilder.Append("second line")
            Assert.AreEqual(document, strBuilder.ToString)
        End Sub

        <TestMethod>
        Public Sub LatexBuilderTest()
            Dim builder = New LatexBuilder()
            Dim document = BuildDocument(builder)
            Dim strBuilder = New StringBuilder()
            strBuilder.Append("\documentclass{article}").AppendLine().Append("\begin{document}").AppendLine()
            strBuilder.Append("\title{title}").AppendLine().Append("\section{header}").AppendLine()
            strBuilder.Append("first line").AppendLine().AppendLine().Append("second line").Append("\end{document}")
            Assert.AreEqual(document, strBuilder.ToString)
        End Sub

        <TestMethod>
        Public Sub HtmlBuildeTest()
            Dim builder = New HtmlBuilder()
            Dim document = BuildDocument(builder)
            Dim strBuilder = New StringBuilder()
            strBuilder.Append("<!DOCTYPE>").AppendLine().Append("<html>").AppendLine().Append("<body>").AppendLine()
            strBuilder.Append("<h3>header</h3>").AppendLine().Append("<p>first line</p>").Append("<br>").AppendLine()
            strBuilder.Append("<p>second line</p>").Append("</body>").AppendLine().Append("</html>").AppendLine()
            Assert.AreEqual(document, strBuilder.ToString)
        End Sub
    End Class
End Namespace
