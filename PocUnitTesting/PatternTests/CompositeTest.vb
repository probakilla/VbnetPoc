Imports DesignPatterns.Composite
Imports Microsoft.VisualStudio.TestTools.UnitTesting

Namespace PocUnitTesting
    <TestClass>
    Public Class CompositeTest
        <TestMethod>
        Public Sub CompositeTest()
            Dim company = New Company
            Dim employee1 = New Employee
            Dim employee2 = New Employee
            Dim employee3 = New Employee
            company.AddEmployee(employee1)
            company.AddEmployee(employee2)
            company.AddEmployee(employee3)
            For Each employee In company.Employees
                Assert.AreEqual(CType(employee, Employee).Money, 0)
            Next
            company.GetSalary(1)
            For Each employee In company.Employees
                Assert.AreEqual(CType(employee, Employee).Money, 1)
            Next
        End Sub
    End Class
End Namespace
