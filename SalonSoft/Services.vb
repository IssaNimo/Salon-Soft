Public Class Services 

    Private Sub ServicesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServicesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ServicesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SalonsoftDataSet)

    End Sub

    Private Sub Services_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SalonsoftDataSet.services' table. You can move, or remove it, as needed.
        Me.ServicesTableAdapter.Fill(Me.SalonsoftDataSet.services)
        Application.DoEvents()
        Me.ServicesTableAdapter.Fill(Me.SalonsoftDataSet.services)
    End Sub

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        ServicesBindingNavigator.AddNewItem.PerformClick()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
            Me.Validate()
            Me.ServicesBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.SalonsoftDataSet)
            MsgBox("Service Saved", MsgBoxStyle.Information)
            Me.Close()
    End Sub
End Class