Public Class Payroll 

    Private Sub PayrollBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PayrollBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PayrollBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SalonsoftDataSet)

    End Sub

    Private Sub Payroll_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SalonsoftDataSet.payroll' table. You can move, or remove it, as needed.
        Me.PayrollTableAdapter.Fill(Me.SalonsoftDataSet.payroll)
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        PayrollBindingNavigator.AddNewItem.PerformClick()
        DateTextEdit.Text = Date.Now.ToString
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        Dim totalamount As Integer = Total_AmountTextEdit.Text
        If RadioButton1.Checked = True Then
            EmployeeComissionTextEdit.Text = totalamount * 0.5
            OwnerComissionTextEdit.Text = totalamount * 0.5
        ElseIf RadioButton2.Checked = True Then
            EmployeeComissionTextEdit.Text = totalamount * 0.4
            OwnerComissionTextEdit.Text = totalamount * 0.6
        ElseIf RadioButton3.Checked = True Then
            EmployeeComissionTextEdit.Text = totalamount * 0.35
            OwnerComissionTextEdit.Text = totalamount * 0.65
        End If      
    End Sub

   
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        If RadioButton1.Checked = True Then
            Total_Amount.TableAdapterManager.payrollTableAdapter.Insert(EmployeesName:=EmployeesNameTextEdit.Text, EmployeeComission:=EmployeeComissionTextEdit.Text, OwnerComission:=OwnerComissionTextEdit.Text, Service:=RadioButton1.Text, Total_Amount:=Total_AmountTextEdit.Text, _Date:=DateTextEdit.Text)
        End If
        If RadioButton2.Checked = True Then
            Total_Amount.TableAdapterManager.payrollTableAdapter.Insert(EmployeesName:=EmployeesNameTextEdit.Text, EmployeeComission:=EmployeeComissionTextEdit.Text, OwnerComission:=OwnerComissionTextEdit.Text, Service:=RadioButton2.Text, Total_Amount:=Total_AmountTextEdit.Text, _Date:=DateTextEdit.Text)
        End If
        If RadioButton3.Checked = True Then
            Total_Amount.TableAdapterManager.payrollTableAdapter.Insert(EmployeesName:=EmployeesNameTextEdit.Text, EmployeeComission:=EmployeeComissionTextEdit.Text, OwnerComission:=OwnerComissionTextEdit.Text, Service:=RadioButton3.Text, Total_Amount:=Total_AmountTextEdit.Text, _Date:=DateTextEdit.Text)
        End If
        MsgBox("Saved", MsgBoxStyle.Information)
        Me.Close()
    End Sub
End Class