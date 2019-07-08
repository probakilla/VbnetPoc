Imports DesignPatterns.Adapter
Imports Microsoft.VisualStudio.TestTools.UnitTesting

Namespace PocUnitTesting
    <TestClass>
    Public Class AdapterTest
        <TestMethod>
        Public Sub TestRectangleAdapter()
            Dim rectangle = New RectangleAdapter(1, 2, 1, 3)
            Dim result = rectangle.Draw()
            Assert.AreEqual("[Rectangle] Width : 1, Height : 2", result)
        End Sub
    End Class
End Namespace
