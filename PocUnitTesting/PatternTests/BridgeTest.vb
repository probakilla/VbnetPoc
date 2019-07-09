Imports DesignPatterns.Bridge
Imports Microsoft.VisualStudio.TestTools.UnitTesting

Namespace PocUnitTesting
    <TestClass>
    Public Class BridgeTest
        <TestMethod>
        Public Sub RedPenTest()
            Dim red = New RedImplementation
            Dim pen = New Pen(red)
            Dim drawing = pen.Draw
            Assert.AreEqual(drawing, "Red")
        End Sub

        <TestMethod>
        Public Sub GreenPenTest()
            Dim green = New GreenImplementation
            Dim pen = New Pen(green)
            Dim drawing = pen.Draw
            Assert.AreEqual(drawing, "Green")
        End Sub
    End Class
End Namespace
