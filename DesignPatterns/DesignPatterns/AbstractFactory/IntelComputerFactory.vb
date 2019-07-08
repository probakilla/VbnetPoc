Imports DesignPatterns.Computer

Namespace AbstractFactory
    Public Class IntelComputerFactory : Inherits AbstractAbstractFactory
        Public Sub New(motherboardPrice As Integer, processorPrice As Integer, graphicCardPrice As Integer)
            MyBase.New(motherboardPrice, processorPrice, graphicCardPrice)
        End Sub

        Public Overrides Function GetComputer() As SystemUnit
            Dim processor = New IntelProcessor(ProcessorPrice)
            Dim motherboard = New AsusMotherboard(MotherboardPrice)
            Dim graphicCard = New AsusGraphicCard(GraphicCardPrice)
            Return New SystemUnit(processor, graphicCard, motherboard)
        End Function
    End Class
End Namespace
