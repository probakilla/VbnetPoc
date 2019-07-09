Imports DesignPatterns.Facade
Imports Microsoft.VisualStudio.TestTools.UnitTesting

Namespace PocUnitTesting
    <TestClass>
    Public Class FacadeTest
        <TestMethod>
        Public Sub FacadeRectangleDrawTest()
            Dim facade = New ShapeFacade
            Dim rectangleDrawing = facade.DrawRectangle
            Assert.AreEqual("[Rectangle] Width : 2, Height : 2", rectangleDrawing)
        End Sub

        <TestMethod>
        Public Sub FacadeCircleDrawTest()
            Dim facade = New ShapeFacade
            Dim circleDrawing = facade.DrawCircle
            Assert.AreEqual("[Circle] Radius : 2", circleDrawing)
        End Sub
    End Class
End Namespace
