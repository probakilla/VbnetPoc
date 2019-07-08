Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports DesignPatterns.MethodFactory
Imports DesignPatterns.Shapes

Namespace PocUnitTesting
    <TestClass>
    Public Class FactoryTest
        Private Fixture As ShapeFactory

        Private Const DefaultRectangleDraw = "[Rectangle] Width : 0, Height : 0"
        Private Const DefaultCircleDraw = "[Circle] Radius : 0"

        <TestInitialize>
        Public Sub SetUp()
            Fixture = New ShapeFactory()
        End Sub

        <TestCleanup>
        Public Sub TearDown()
            Fixture = Nothing
        End Sub

        <TestMethod>
        Sub CorrectCircle()
            Dim circle As IShape = Fixture.GetShape("circle")
            Assert.AreEqual(circle.Draw(), DefaultCircleDraw)
            Assert.IsTrue(TypeOf circle Is Circle)
        End Sub

        <TestMethod>
        Sub CorrectRectangle()
            Dim rectangle As IShape = Fixture.GetShape("rectangle")
            Assert.AreEqual(rectangle.Draw(), DefaultRectangleDraw)
            Assert.IsTrue(TypeOf rectangle Is Rectangle)
        End Sub

        <TestMethod>
        Sub RandomCaseCircle()
            Dim circle As IShape = Fixture.GetShape("ciRcLE")
            Assert.AreEqual(circle.Draw(), DefaultCircleDraw)
            Assert.IsTrue(TypeOf circle Is Circle)
        End Sub

        <TestMethod>
        Sub RandomCaseRectangle()
            Dim rectangle As IShape = Fixture.GetShape("ReCtaNGle")
            Assert.AreEqual(rectangle.Draw(), DefaultRectangleDraw)
            Assert.IsTrue(TypeOf rectangle Is Rectangle)
        End Sub

        <TestMethod>
        <ExpectedException(GetType(UnknownShapeException))>
        Sub TestBadString()
            Dim fakeShape As IShape = Fixture.GetShape("not a shape")
        End Sub

        <TestMethod>
        <ExpectedException(GetType(UnknownShapeException))>
        Sub TestEmptyString()
            Dim fakeShape As IShape = Fixture.GetShape("")
            Assert.IsNotNull(fakeShape)
        End Sub
    End Class
End Namespace

