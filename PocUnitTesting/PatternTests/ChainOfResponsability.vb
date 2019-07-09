Imports DesignPatterns.ChainOfResponsability
Imports Microsoft.VisualStudio.TestTools.UnitTesting

Namespace PocUnitTesting
    <TestClass>
    Public Class ChainOfResponsability
        Private Logger As AbstractLogger
        Private Const MESSAGE = "message"

        <TestInitialize>
        Public Sub SetUp()
            Dim consoleLogger = New Logger(AbstractLogger.INFO)
            Dim errorLoger = New ErrorLogger(AbstractLogger.ERR)
            Dim infoLogger = New InfoLogger(AbstractLogger.DEBUG)
            errorLoger.SetNextLogger(infoLogger)
            infoLogger.SetNextLogger(consoleLogger)
            Logger = errorLoger
        End Sub

        <TestCleanup>
        Public Sub TearDown()
            Logger = Nothing
        End Sub

        <TestMethod>
        Public Sub LogTest()
            Dim log = Logger.LogMessage(AbstractLogger.INFO, MESSAGE)
            Assert.AreEqual(String.Format("Log> {0}", MESSAGE), log)
        End Sub

        <TestMethod>
        Public Sub LogErrorTest()
            Dim err = Logger.LogMessage(AbstractLogger.ERR, MESSAGE)
            Assert.AreEqual(String.Format("Error> {0}", MESSAGE), err)
        End Sub

        <TestMethod>
        Public Sub LogInfoTest()
            Dim info = Logger.LogMessage(AbstractLogger.DEBUG, MESSAGE)
            Assert.AreEqual(String.Format("Info> {0}", MESSAGE), info)
        End Sub
    End Class
End Namespace
