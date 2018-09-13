Public Class Permission 
    Private Sub Permission_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SalonsoftDataSet.users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.SalonsoftDataSet.users)
       
    End Sub

    Private Sub UsersBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.UsersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SalonsoftDataSet)
        Me.UsersTableAdapter.Fill(Me.SalonsoftDataSet.users)
    End Sub

    Private Sub UsersBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UsersBindingSource.EndEdit()
        Me.UsersTableAdapter.Update(Me.SalonsoftDataSet.users)
    End Sub


End Class