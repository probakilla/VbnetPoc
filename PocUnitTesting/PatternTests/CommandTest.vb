Imports System.Text
Imports DesignPatterns.Command
Imports Microsoft.VisualStudio.TestTools.UnitTesting

Namespace PocUnitTesting
    <TestClass>
    Public Class CommandTest
        <TestMethod>
        Public Sub CommandOrderTest()
            Dim stock = New Stock("stock", 5)
            Dim buyStockOrder = New BuyStock(stock)
            Dim sellStockOrder = New SellStock(stock)
            Dim Broker = New Broker
            Broker.TakeOrder(buyStockOrder)
            Broker.TakeOrder(sellStockOrder)
            Dim orderSummary = Broker.PlaceOrders
            Dim strBuilder = New StringBuilder
            strBuilder.Append("Stock [Name: stock, Quantity: 5] bought").AppendLine()
            strBuilder.Append("Stock [Name: stock, Quantity: 5] sold").AppendLine()
            Assert.AreEqual(strBuilder.ToString, orderSummary)
        End Sub
    End Class
End Namespace
