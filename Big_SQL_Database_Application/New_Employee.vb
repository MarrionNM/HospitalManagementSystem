Public Class New_Employee
    Dim Object2 As clsDbConnection

    Private Sub New_Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Object2 = New clsDbConnection
        Object2.ExecuteQuery("SELECT * FROM Manage_Employees")

        If Object2.ErrorMessage = "" Then
            DgvEMployees.DataSource = Object2.table
        End If

    End Sub
End Class