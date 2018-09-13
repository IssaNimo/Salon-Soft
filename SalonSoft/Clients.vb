Public Class Clients 

    Private Sub ClientsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClientsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SalonsoftDataSet)

    End Sub

    Private Sub Clients_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SalonsoftDataSet.clients' table. You can move, or remove it, as needed.
        Me.ClientsTableAdapter.Fill(Me.SalonsoftDataSet.clients)

    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        ClientsBindingNavigator.AddNewItem.PerformClick()
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Validate()
        Me.ClientsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SalonsoftDataSet)
        MsgBox("Client Saved", MsgBoxStyle.Information)
        Me.Close()

    End Sub
End Class