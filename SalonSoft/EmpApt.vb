Public Class EmpApt

    Private Sub ResourcesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResourcesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ResourcesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SalonsoftDataSet)

    End Sub

    Private Sub Resources_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SalonsoftDataSet.resources' table. You can move, or remove it, as needed.
        Me.ResourcesTableAdapter.Fill(Me.SalonsoftDataSet.resources)

    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        ResourcesBindingNavigator.AddNewItem.PerformClick()
    End Sub

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        Me.Validate()
        Me.ResourcesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SalonsoftDataSet)

    End Sub

    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton5.Click
        Me.ResourcesTableAdapter.Fill(Me.SalonsoftDataSet.resources)
        

    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        If MessageBox.Show("Are you sure you want to delete ?", "Deleting...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            ResourcesBindingSource.RemoveCurrent()
            Me.Validate()
            Me.ResourcesBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.SalonsoftDataSet)
        End If
    End Sub

    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        Me.Close()
    End Sub
End Class