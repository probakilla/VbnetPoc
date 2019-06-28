Imports DesignPatterns.Shapes

Namespace Flyweight
    Public Class RectangleFlywieght
        Private Property RectangleMap As Dictionary(Of String, Rectangle)

        Public Sub New()
            RectangleMap = New Dictionary(Of String, Rectangle)
        End Sub

        Public Function GetRectangle(width As Integer, height As Integer) As Rectangle
            Dim rectangleString = CreateRectangleString(width, height)
            If RectangleMap.ContainsKey(rectangleString) Then
                Return RectangleMap.Item(rectangleString)
            Else
                Dim rectangle = New Rectangle(width, height)
                RectangleMap.Add(rectangleString, rectangle)
                Return rectangle
            End If
        End Function

        Private Function CreateRectangleString(width As Integer, height As Integer) As String
            Dim rectangleString As String = "Rectangle," & width.ToString & "," & height.ToString
            Return rectangleString
        End Function
    End Class
End Namespace