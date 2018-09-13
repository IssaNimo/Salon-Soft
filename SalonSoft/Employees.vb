
Public Class Employees
    Private Sub EmployeesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EmployeesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SalonsoftDataSet)

    End Sub

    Private Sub Employees_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SalonsoftDataSet.employees' table. You can move, or remove it, as needed.
        Me.EmployeesTableAdapter.Fill(Me.SalonsoftDataSet.employees)

    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        EmployeesBindingNavigator.AddNewItem.PerformClick()
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
            Me.Validate()
            Me.EmployeesBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.SalonsoftDataSet)
            MsgBox("Employee Saved", MsgBoxStyle.Information)
        Me.Close()
        Me.Dispose()
    End Sub

  

End Class