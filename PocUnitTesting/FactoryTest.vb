Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports POCVB.AbstractFactory
Imports POCVB.Shapes

Namespace PocUnitTesting
    <TestClass>
    Public Class FactoryTest
        Private Property Fixture As ShapeFactory

        Private Const DefaultRectangleDraw = "[Rectangle] Width : 0, Height : 0"
        Private Const DefaultCircleDraw = "[Circle] Radius : 0"

        <TestInitialize>
        Sub SetUp()
            Fixture = New ShapeFactory()
        End Sub

        <TestCleanup>
        Sub TearDown()
            Fixture = Nothing
        End Sub

        <TestMethod>
        Sub CorrectCircle()
            Dim circle As Shape = Fixture.GetShape("circle")
            Assert.AreEqual(circle.Draw(), DefaultCircleDraw)
            Assert.IsTrue(TypeOf circle Is Circle)
        End Sub

        <TestMethod>
        Sub CorrectRectangle()
            Dim rectangle As Shape = Fixture.GetShape("rectangle")
            Assert.AreEqual(rectangle.Draw(), DefaultRectangleDraw)
            Assert.IsTrue(TypeOf rectangle Is Rectangle)
        End Sub

        <TestMethod>
        Sub RandomCaseCircle()
            Dim circle As Shape = Fixture.GetShape("ciRcLE")
            Assert.AreEqual(circle.Draw(), DefaultCircleDraw)
            Assert.IsTrue(TypeOf circle Is Circle)
        End Sub

        <TestMethod>
        Sub RandomCaseRectangle()
            Dim rectangle As Shape = Fixture.GetShape("ReCtaNGle")
            Assert.AreEqual(rectangle.Draw(), DefaultRectangleDraw)
            Assert.IsTrue(TypeOf rectangle Is Rectangle)
        End Sub

        <TestMethod>
        <ExpectedException(GetType(UnknownShapeException))>
        Sub TestBadString()
            Dim fakeShape As Shape = Fixture.GetShape("not a shape")
        End Sub

        <TestMethod>
        <ExpectedException(GetType(UnknownShapeException))>
        Sub TestEmptyString()
            Dim fakeShape As Shape = Fixture.GetShape("")
        End Sub

        <TestMethod>
        <ExpectedException(GetType(UnknownShapeException))>
        Sub TestImplicitCast()
            Dim fakeShape As Shape = Fixture.GetShape(1240724)
        End Sub
    End Class
End Namespace

