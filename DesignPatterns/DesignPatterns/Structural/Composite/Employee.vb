Namespace Composite
    Public Class Employee : Implements IEmployee
        Private _money As Integer
        Public Property Money As Integer
            Get
                Return _money
            End Get
            Private Set(value As Integer)
                _money = value
            End Set
        End Property

        Public Sub New()
            Money = 0
        End Sub

        Public Sub GetSalary(salary As Integer) Implements IEmployee.GetSalary
            Money += salary
        End Sub
    End Class
End Namespace
