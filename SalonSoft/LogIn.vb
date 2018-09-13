Public Class LogIn 

    Private Sub UsersBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UsersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SalonsoftDataSet)

    End Sub

    Private Sub LogIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SalonsoftDataSet.users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.SalonsoftDataSet.users)
        Threading.Thread.Sleep(4000)
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
        Application.Exit()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If TextEdit1.Text = "" = False And TextEdit2.Text = "" = False Then
            If TextEdit2.Text = PasswordTextEdit.Text Then
                If TextEdit1.Text = UserNameTextEdit.Text Then
                    MainForm.ToolStripStatusLabel2.Text = UserNameTextEdit.Text
                    MainForm.ToolStripStatusLabel3.Text = CapacityTextEdit.Text
                    MainForm.Show()
                    Access()


                Else
                    MsgBox("Invalid username", MsgBoxStyle.Critical)
                    Exit Sub
                End If
            Else
                MsgBox("Invalid password", MsgBoxStyle.Critical)
                Exit Sub
            End If
        Else
            MsgBox("Please enter a username and password", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Me.Hide()


    End Sub

    Sub Access()
        If Me.ClientsCheckBox.Checked = True Then
            MainForm.BarLargeButtonItem1.Enabled = True

        Else
            MainForm.BarLargeButtonItem1.Enabled = False
        End If
        If Me.EmployeesCheckBox.Checked = True Then
            MainForm.BarLargeButtonItem2.Enabled = True
        Else
            MainForm.BarLargeButtonItem2.Enabled = False
        End If
        If Me.ServicesCheckBox.Checked = True Then
            MainForm.BarLargeButtonItem3.Enabled = True
        Else
            MainForm.BarLargeButtonItem3.Enabled = True
        End If
        If Me.ProductsCheckBox.Checked = True Then
            MainForm.BarLargeButtonItem4.Enabled = True
        Else
            MainForm.BarLargeButtonItem4.Enabled = False

        End If
        If Me.AppoitmentsCheckBox.Checked = True Then
            MainForm.BarLargeButtonItem5.Enabled = True
        Else
            MainForm.BarLargeButtonItem5.Enabled = False
        End If
        If Me.PayrollCheckBox.Checked = True Then
            MainForm.BarLargeButtonItem6.Enabled = True
        Else
            MainForm.BarLargeButtonItem6.Enabled = False
        End If
        If Me.ResourcesCheckBox.Checked = True Then
            MainForm.BarLargeButtonItem7.Enabled = True
        Else
            MainForm.BarLargeButtonItem7.Enabled = False
        End If



    End Sub

    Private Sub TextEdit1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextEdit1.EditValueChanged
        UsersBindingSource.Filter = "UserName like'" & TextEdit1.Text & "%'"

    End Sub

    Private Sub TextEdit2_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextEdit2.EditValueChanged
        UsersBindingSource.Filter = "Password like'" & TextEdit2.Text & "%'"
    End Sub
End Class