Public Class Salon_Settings 

    Private Sub SalonsettingsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalonsettingsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SalonsettingsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SalonsoftDataSet)

    End Sub

    Private Sub Salon_Settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SalonsoftDataSet.salonsettings' table. You can move, or remove it, as needed.
        Me.SalonsettingsTableAdapter.Fill(Me.SalonsoftDataSet.salonsettings)

    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        SalonsettingsBindingNavigator.AddNewItem.PerformClick()
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Validate()
        Me.SalonsettingsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SalonsoftDataSet)
        MsgBox("Saved", MsgBoxStyle.Information)
        Me.Close()
    End Sub

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        SalonsettingsBindingSource.RemoveCurrent()
    End Sub
End Class