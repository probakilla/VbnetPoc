Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports DesignPatterns.Shapes

Namespace PocUnitTesting
    <TestClass>
    Public Class CircleTest
        Private Const DefaultCircleDraw = "[Circle] Radius : 0"
        Private Const CircleDrawString = "[Circle] Radius : {0}"

        <TestMethod>
        Sub TestZeroCircle()
            Dim circle As Shape = New Circle(0)
            Assert.AreEqual(circle.Draw(), DefaultCircleDraw)
        End Sub

        <TestMethod>
        Sub TestPositiveValue()
            Dim positiveValue As Integer = 100
            Dim circle As Shape = New Circle(positiveValue)
            Assert.AreEqual(circle.Draw(), GetCircleDrawString(positiveValue))
        End Sub

        <TestMethod>
        Sub TestNegativeValue()
            Dim negativeInteger As Integer = -100
            Dim circle As Shape = New Circle(negativeInteger)
            Assert.AreEqual(circle.Draw(), GetCircleDrawString(negativeInteger))
        End Sub

        <TestMethod>
        Sub TestMaxInteger()
            Dim maxInteger As Integer = Int32.MaxValue
            Dim circle As Shape = New Circle(maxInteger)
            Assert.AreEqual(circle.Draw(), GetCircleDrawString(maxInteger))
        End Sub

        <TestMethod>
        Sub TestMinInteger()
            Dim minInteger As Integer = Int32.MinValue
            Dim circle As Shape = New Circle(minInteger)
            Assert.AreEqual(circle.Draw(), GetCircleDrawString(minInteger))
        End Sub

        Private Function GetCircleDrawString(value As Integer) As String
            Return String.Format(CircleDrawString, value)
        End Function
    End Class
End Namespace
