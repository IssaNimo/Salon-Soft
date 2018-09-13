Public Class Total_Amount 

    Private Sub PayrollBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PayrollBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PayrollBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SalonsoftDataSet)

    End Sub

    Private Sub Total_Amount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SalonsoftDataSet.payroll' table. You can move, or remove it, as needed.
        Me.PayrollTableAdapter.Fill(Me.SalonsoftDataSet.payroll)

    End Sub

    Private Sub TextEdit1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextEdit1.EditValueChanged
        PayrollBindingSource.Filter = "EmployeesName like'" & TextEdit1.Text & "%'"
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Dim pay As Integer = PayrollDataGridView.CurrentRow.Index
        PaySlip.TextEdit1.Text = PayrollDataGridView.Item(0, pay).Value.ToString
        PaySlip.TextEdit4.Text = PayrollDataGridView.Item(1, pay).Value.ToString
        Dim total As Integer
        For i As Integer = 0 To PayrollDataGridView.RowCount() - 1
            total += PayrollDataGridView.Item(4, i).Value
        Next
        PaySlip.TextEdit5.Text = total.ToString
        PaySlip.ShowDialog()
    End Sub
    
End Class