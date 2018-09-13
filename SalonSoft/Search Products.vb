Public Class Search_Products 

    Private Sub ResourcesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ProductBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SalonsoftDataSet)

    End Sub

    Private Sub Search_Products_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SalonsoftDataSet.product' table. You can move, or remove it, as needed.
        Me.ProductTableAdapter.Fill(Me.SalonsoftDataSet.product)

    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
End Class