Public Class EmployeesSearch 

    Private Sub EmployeesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EmployeesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SalonsoftDataSet)

    End Sub

    Private Sub EmployeesSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SalonsoftDataSet.employees' table. You can move, or remove it, as needed.
        Me.EmployeesTableAdapter.Fill(Me.SalonsoftDataSet.employees)

    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub

    Private Sub TextEdit1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextEdit1.EditValueChanged
        EmployeesBindingSource.Filter = "FirstName like'" & TextEdit1.Text & "%'"
    End Sub
End Class