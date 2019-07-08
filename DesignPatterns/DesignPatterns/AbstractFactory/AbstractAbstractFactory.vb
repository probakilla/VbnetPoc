Imports DesignPatterns.Computer

Namespace AbstractFactory
    Public MustInherit Class AbstractAbstractFactory : Implements IAbstractFactory

        Protected MotherboardPrice As Integer
        Protected ProcessorPrice As Integer
        Protected GraphicCardPrice As Integer

        Public Sub New(motherboardPrice As Integer, processorPrice As Integer, graphicCardPrice As Integer)
            Me.MotherboardPrice = motherboardPrice
            Me.ProcessorPrice = processorPrice
            Me.GraphicCardPrice = graphicCardPrice
        End Sub

        Public MustOverride Function GetComputer() As SystemUnit Implements IAbstractFactory.GetComputer
    End Class
End Namespace
