Imports DesignPatterns.Computer

Namespace AbstractFactory
    Public Class AmdComputerFactory : Inherits AbstractAbstractFactory
        Public Sub New(motherboardPrice As Integer, processorPrice As Integer, graphicCardPrice As Integer)
            MyBase.New(motherboardPrice, processorPrice, graphicCardPrice)
        End Sub

        Public Overrides Function GetComputer() As SystemUnit
            Dim processor = New AmdProcessor(ProcessorPrice)
            Dim motherboard = New MsiMotherboard(MotherboardPrice)
            Dim graphicCard = New MsiGraphicCard(GraphicCardPrice)
            Return New SystemUnit(processor, graphicCard, motherboard)
        End Function
    End Class
End Namespace
