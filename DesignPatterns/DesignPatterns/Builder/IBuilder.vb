Namespace Builder
    Public Interface IBuilder
        Sub InitDocument()
        Sub MakeTitle(title As String)
        Sub MakeHeader(header As String)
        Sub MakeParagraph(text As String)
        Sub MakeNewline()
        Function GetDocument() As String
    End Interface
End Namespace
