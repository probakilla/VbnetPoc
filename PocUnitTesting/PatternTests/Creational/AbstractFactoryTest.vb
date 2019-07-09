Imports System.Text
Imports DesignPatterns.AbstractFactory
Imports Microsoft.VisualStudio.TestTools.UnitTesting

Namespace DesignPattern.CreationalTest
    <TestClass>
    Public Class AbstractFactoryTest
        <TestMethod>
        Public Sub TestIntelFactory()
            Dim factory = New IntelComputerFactory(100, 200, 300)
            Dim computer = factory.GetComputer()
            Dim strBuilder = New StringBuilder()
            strBuilder.Append("Pc configuration:").AppendLine _
                .Append("Motherboard").AppendLine.Append("Brand: ASUS").AppendLine.Append("Price: 100").AppendLine _
                .Append("Processor").AppendLine.Append("Brand: Intel").AppendLine.Append("Price: 200").AppendLine _
                .Append("Graphic Card").AppendLine.Append("Brand: ASUS").AppendLine.Append("Price: 300").AppendLine()
            Assert.AreEqual(strBuilder.ToString, computer.GetDescription)
        End Sub

        <TestMethod>
        Public Sub TestAMDFactory()
            Dim factory = New AmdComputerFactory(100, 200, 300)
            Dim computer = factory.GetComputer()
            Dim strBuilder = New StringBuilder()
            strBuilder.Append("Pc configuration:").AppendLine _
                .Append("Motherboard").AppendLine.Append("Brand: MSI").AppendLine.Append("Price: 100").AppendLine _
                .Append("Processor").AppendLine.Append("Brand: AMD").AppendLine.Append("Price: 200").AppendLine _
                .Append("Graphic Card").AppendLine.Append("Brand: MSI").AppendLine.Append("Price: 300").AppendLine()
            Assert.AreEqual(strBuilder.ToString, computer.GetDescription)
        End Sub

        <TestMethod>
        Public Sub TestCustomFactory()
            Dim factory = New CustomComputerFactory(100, 200, 300)
            Dim computer = factory.GetComputer()
            Dim strBuilder = New StringBuilder()
            strBuilder.Append("Pc configuration:").AppendLine _
                .Append("Motherboard").AppendLine.Append("Brand: ASUS").AppendLine.Append("Price: 100").AppendLine _
                .Append("Processor").AppendLine.Append("Brand: AMD").AppendLine.Append("Price: 200").AppendLine _
                .Append("Graphic Card").AppendLine.Append("Brand: MSI").AppendLine.Append("Price: 300").AppendLine()
            Assert.AreEqual(strBuilder.ToString, computer.GetDescription)
        End Sub
    End Class
End Namespace
