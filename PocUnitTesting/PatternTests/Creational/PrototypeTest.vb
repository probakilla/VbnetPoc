Imports DesignPatterns.Prototype
Imports Microsoft.VisualStudio.TestTools.UnitTesting

Namespace DesignPattern.CreationalTest
    <TestClass>
    Public Class PrototypeTest
        Private Const WaterStr = "water"
        Private Const BeerStr = "beer"

        Private Function GetWaterClone() As Liquid
            Dim water = New Liquid(WaterStr)
            Return CType(water.Clone, Liquid)
        End Function

        <TestMethod>
        Public Sub TestPrimitiveCopy()
            Dim water = GetWaterClone()
            Assert.AreEqual(water.Name, WaterStr)
        End Sub

        <TestMethod>
        Public Sub TestCopyModification()
            Dim water = New Liquid(WaterStr)
            Dim copiedWater = CType(water.Clone, Liquid)
            Assert.AreEqual(copiedWater.Name, WaterStr)
            copiedWater.Name = BeerStr
            Assert.AreEqual(water.Name, WaterStr)
        End Sub

        <TestMethod>
        Public Sub TestDeepCopy()
            Dim water = New Liquid(WaterStr)
            Dim waterBottle = New Bottle(water)
            Dim copiedBottle = CType(waterBottle.Clone, Bottle)
            Assert.AreEqual(copiedBottle.Content.Name, WaterStr)
        End Sub

        <TestMethod>
        Public Sub TestDeepCopyModification()
            Dim water = New Liquid(WaterStr)
            Dim waterBottle = New Bottle(water)
            Dim copiedBottle = CType(waterBottle.Clone, Bottle)
            copiedBottle.Content.Name = BeerStr
            Assert.AreEqual(waterBottle.Content.Name, WaterStr)
        End Sub
    End Class
End Namespace
