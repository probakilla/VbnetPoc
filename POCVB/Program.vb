Module Program
    Private Sub BlockConsole()
        Console.WriteLine("Press ENTER to dismiss")
        Console.ReadLine()
    End Sub

    Sub Main(args As String())
        Dim testConcat As New StringBuilderVsConcat(10000)
        BlockConsole()
    End Sub
End Module
