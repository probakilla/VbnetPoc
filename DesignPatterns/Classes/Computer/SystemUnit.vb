Imports System.Text

Namespace Computer
    Public Structure SystemUnit
        Private ReadOnly Processor As IComputerPart
        Private ReadOnly GraphicCard As IComputerPart
        Private ReadOnly Motherboard As IComputerPart

        Public Sub New(processor As IComputerPart, graphicCard As IComputerPart, motherboard As IComputerPart)
            Me.Processor = processor
            Me.GraphicCard = graphicCard
            Me.Motherboard = motherboard
        End Sub

        Public Function GetDescription() As String
            Dim strBuilder = New StringBuilder()
            strBuilder.Append("Pc configuration:").AppendLine _
                .Append(Motherboard.GetDescription) _
                .Append(Processor.GetDescription) _
                .Append(GraphicCard.GetDescription)
            Return strBuilder.ToString
        End Function
    End Structure
End Namespace
