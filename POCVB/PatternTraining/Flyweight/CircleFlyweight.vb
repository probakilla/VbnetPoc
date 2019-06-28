Imports POCVB.Shapes

Namespace Flyweight
    Public Class CircleFlyweight
        Private Property CircleMap As Dictionary(Of String, Circle)

        Public Sub New()
            CircleMap = New Dictionary(Of String, Circle)
        End Sub

        Public Function GetCircle(radius As Integer) As Circle
            Dim circleString As String = CreateCircleString(radius)
            If CircleMap.ContainsKey(circleString) Then
                Return CircleMap.Item(circleString)
            Else
                Dim circle As New Circle(radius)
                CircleMap.Add(circleString, circle)
                Return circle
            End If
        End Function

        Private Function CreateCircleString(radius As Integer) As String
            Return "Cricle," & radius.ToString
        End Function
    End Class
End Namespace