Namespace Composite
    Public Class Company : Implements IEmployee
        Private _employees As List(Of IEmployee)
        Public Property Employees As List(Of IEmployee)
            Get
                Return _employees
            End Get
            Private Set(value As List(Of IEmployee))
                _employees = value
            End Set
        End Property

        Public Sub New()
            _employees = New List(Of IEmployee)
        End Sub

        Public Sub GetSalary(salary As Integer) Implements IEmployee.GetSalary
            For Each employee In _employees
                employee.GetSalary(salary)
            Next
        End Sub

        Public Sub AddEmployee(employee As IEmployee)
            _employees.Add(employee)
        End Sub
    End Class
End Namespace
