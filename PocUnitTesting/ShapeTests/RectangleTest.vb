Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports POCVB.Shapes

Namespace PocUnitTesting
    <TestClass>
    Public Class RectangleTest
        Private Const DefaultRectangleString = "[Rectangle] Width : 0, Height : 0"
        Private Const RectangleDrawString = "[Rectangle] Width : {0}, Height : {1}"

        <TestMethod>
        Sub TestZeroRectangle()
            Dim circle As Shape = New Rectangle(0, 0)
            Assert.AreEqual(circle.Draw(), DefaultRectangleString)
        End Sub

        <TestMethod>
        Sub TestBothPositiveValues()
            Dim positiveValue As Integer = 100
            Dim rectangle As Shape = New Rectangle(positiveValue, positiveValue)
            Assert.AreEqual(rectangle.Draw(), GetRectangleDrawString(positiveValue, positiveValue))
        End Sub

        <TestMethod>
        Sub TestBothNegativeValues()
            Dim negativeInteger As Integer = -100
            Dim rectangle As Shape = New Rectangle(negativeInteger, negativeInteger)
            Assert.AreEqual(rectangle.Draw(), GetRectangleDrawString(negativeInteger, negativeInteger))
        End Sub

        <TestMethod>
        Sub TestNegativeAndPositiveValues()
            Dim negativeInteger As Integer = -100
            Dim positiveInteger As Integer = -negativeInteger
            Dim rectangle As Shape = New Rectangle(negativeInteger, positiveInteger)
            Assert.AreEqual(rectangle.Draw(), GetRectangleDrawString(negativeInteger, positiveInteger))
        End Sub

        <TestMethod>
        Sub TestMaxInteger()
            Dim maxInteger As Integer = Int32.MaxValue
            Dim rectangle As Shape = New Rectangle(maxInteger, maxInteger)
            Assert.AreEqual(rectangle.Draw(), GetRectangleDrawString(maxInteger, maxInteger))
        End Sub

        <TestMethod>
        Sub TestMinInteger()
            Dim minInteger As Integer = Int32.MinValue
            Dim rectangle As Shape = New Rectangle(minInteger, minInteger)
            Assert.AreEqual(rectangle.Draw(), GetRectangleDrawString(minInteger, minInteger))
        End Sub

        Private Function GetRectangleDrawString(width As Integer, height As Integer) As String
            Return String.Format(RectangleDrawString, width, height)
        End Function
    End Class
End Namespace