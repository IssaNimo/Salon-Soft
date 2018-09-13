Imports DevExpress.XtraScheduler
Imports System.ComponentModel

Public Class MainForm

    Private Property AppoitmentsTableAdapter As Object


    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        If MessageBox.Show("Are you sure you want to exit ?", "Exiting...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub ClientsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClientsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SalonsoftDataSet)

    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        XtraTabControl1.Visible = False
        'TODO: This line of code loads data into the 'SalonsoftDataSet.payroll' table. You can move, or remove it, as needed.
        Me.PayrollTableAdapter.Fill(Me.SalonsoftDataSet.payroll)
        'TODO: This line of code loads data into the 'SalonsoftDataSet1.resources' table. You can move, or remove it, as needed.
        Me.ResourcesTableAdapter.Fill(Me.SalonsoftDataSet1.resources)
        'TODO: This line of code loads data into the 'SalonsoftDataSet1.appointments' table. You can move, or remove it, as needed.
        Me.AppointmentsTableAdapter.Fill(Me.SalonsoftDataSet1.appointments)
        'TODO: This line of code loads data into the 'SalonsoftDataSet2.resources' table. You can move, or remove it, as needed.
        Me.ProductTableAdapter.Fill(Me.SalonsoftDataSet.product)
        'TODO: This line of code loads data into the 'SalonsoftDataSet.employees' table. You can move, or remove it, as needed.
        Me.EmployeesTableAdapter.Fill(Me.SalonsoftDataSet.employees)
        'TODO: This line of code loads data into the 'SalonsoftDataSet.services' table. You can move, or remove it, as needed.
        Me.ServicesTableAdapter.Fill(Me.SalonsoftDataSet.services)
        'TODO: This line of code loads data into the 'SalonsoftDataSet.employees' table. You can move, or remove it, as needed.
        Me.EmployeesTableAdapter.Fill(Me.SalonsoftDataSet.employees)
        'TODO: This line of code loads data into the 'SalonsoftDataSet.clients' table. You can move, or remove it, as needed
        Me.ClientsTableAdapter.Fill(Me.SalonsoftDataSet.clients)

        SchedulerControl1.Start = DateTime.Now




        Application.DoEvents()
        Me.ProductTableAdapter.Fill(Me.SalonsoftDataSet.product)
        Me.EmployeesTableAdapter.Fill(Me.SalonsoftDataSet.employees)
        Me.ServicesTableAdapter.Fill(Me.SalonsoftDataSet.services)
        Me.ClientsTableAdapter.Fill(Me.SalonsoftDataSet.clients)
        Me.AppointmentsTableAdapter.Fill(Me.SalonsoftDataSet1.appointments)
        Me.ResourcesTableAdapter1.Fill(Me.SalonsoftDataSet.resources)
        Me.PayrollTableAdapter.Fill(Me.SalonsoftDataSet.payroll)
    End Sub

    Private Sub AccordionControlElement2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccordionControlElement2.Click
        Clients.ShowDialog()
    End Sub

    Private Sub BarLargeButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarLargeButtonItem1.ItemClick
        XtraTabControl1.Visible = True
        XtraTabControl1.SelectedTabPage = XtraTabPage1
    End Sub

    Private Sub AccordionControlElement6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccordionControlElement6.Click
        XtraTabPage1.PageVisible = False


    End Sub

    Private Sub BarLargeButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarLargeButtonItem2.ItemClick
        XtraTabControl1.Visible = True
        XtraTabControl1.SelectedTabPage = XtraTabPage2
    End Sub

    Private Sub AccordionControlElement12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccordionControlElement12.Click
        XtraTabPage2.PageVisible = False
    End Sub

    Private Sub AccordionControlElement8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccordionControlElement8.Click
        Employees.ShowDialog()
    End Sub

    Private Sub BarLargeButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarLargeButtonItem3.ItemClick
        XtraTabControl1.Visible = True
        XtraTabControl1.SelectedTabPage = XtraTabPage3
    End Sub

    Private Sub AccordionControlElement14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccordionControlElement14.Click
        Services.ShowDialog()
    End Sub

    Private Sub AccordionControlElement5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccordionControlElement5.Click
        Me.ClientsTableAdapter.Fill(Me.SalonsoftDataSet.clients)
    End Sub

    Private Sub AccordionControlElement3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccordionControlElement3.Click
        If MessageBox.Show("Are you sure you want to delete ?", "Deleting...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            ClientsBindingSource.RemoveCurrent()
            Me.Validate()
            Me.ClientsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.SalonsoftDataSet)

        End If
    End Sub

    Private Sub AccordionControlElement9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccordionControlElement9.Click
        If MessageBox.Show("Are you sure you want to delete ?", "Deleting...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            EmployeesBindingSource.RemoveCurrent()
            Me.Validate()
            Me.EmployeesBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.SalonsoftDataSet)
        End If
    End Sub

    Private Sub AccordionControlElement11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccordionControlElement11.Click
        Me.EmployeesTableAdapter.Fill(Me.SalonsoftDataSet.employees)
    End Sub

    Private Sub AccordionControlElement16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccordionControlElement16.Click
        If MessageBox.Show("Are you sure you want to delete ?", "Deleting...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            ServicesBindingSource.RemoveCurrent()
            Me.Validate()
            Me.ServicesBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.SalonsoftDataSet)
        End If
    End Sub

    Private Sub AccordionControlElement20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccordionControlElement20.Click
        Products.ShowDialog()
    End Sub

    Private Sub AccordionControlElement21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccordionControlElement21.Click
        If MessageBox.Show("Are you sure you want to delete ?", "Deleting...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            ProductBindingSource.RemoveCurrent()
            Me.Validate()
            Me.ProductBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.SalonsoftDataSet)
        End If
    End Sub

    Private Sub AccordionControlElement23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccordionControlElement23.Click
        Me.ProductTableAdapter.Fill(Me.SalonsoftDataSet.product)
    End Sub

    Private Sub AccordionControlElement24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccordionControlElement24.Click
        XtraTabPage4.PageVisible = False
    End Sub

    Private Sub BarLargeButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarLargeButtonItem4.ItemClick
        XtraTabControl1.Visible = True
        XtraTabControl1.SelectedTabPage = XtraTabPage4
    End Sub

    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    End Sub

    Private Sub BarButtonItem6_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        Client_Information.ShowDialog()
    End Sub

    Private Sub BarLargeButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarLargeButtonItem5.ItemClick
        XtraTabControl1.Visible = True
        XtraTabControl1.SelectedTabPage = XtraTabPage5
    End Sub

    Private Sub AccordionControlElement18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccordionControlElement18.Click
        XtraTabPage3.PageVisible = False
    End Sub
    Private Sub BarLargeButtonItem7_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarLargeButtonItem7.ItemClick
        XtraTabControl1.Visible = True
        XtraTabControl1.SelectedTabPage = XtraTabPage5
    End Sub

    Public Class SchedulerDataObject
        Public Property Appointments() As System.Collections.IEnumerable
        Public Property Resources() As System.Collections.IEnumerable
    End Class

    Private Sub BarLargeButtonItem8_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Find_Client.ShowDialog()
    End Sub

    Private Sub BarButtonItem7_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        Find_Client.ShowDialog()
    End Sub

    Private Sub AccordionControlElement17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccordionControlElement17.Click
        Me.ServicesTableAdapter.Fill(Me.SalonsoftDataSet.services)
    End Sub

    Private Sub BarButtonItem10_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        ServiceSearch.ShowDialog()
    End Sub

    Private Sub BarButtonItem8_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        EmployeesSearch.ShowDialog()
    End Sub

    Private Sub BarLargeButtonItem9_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarLargeButtonItem9.ItemClick
        XtraTabControl1.Visible = True
        XtraTabControl1.SelectedTabPage = XtraTabPage7
    End Sub

    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        XtraTabPage7.Hide()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        EmpApt.ShowDialog()

    End Sub

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ResourcesBindingSource.EndEdit()
        Me.ResourcesTableAdapter1.Fill(Me.SalonsoftDataSet.resources)
        MsgBox("Resource Saved", MsgBoxStyle.Information)
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If MessageBox.Show("Are you sure you want to delete ?", "Deleting...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            ResourcesBindingSource1.RemoveCurrent()
            Me.Validate()
            Me.ResourcesBindingSource.EndEdit()
            Me.ResourcesTableAdapter1.Fill(Me.SalonsoftDataSet.resources)
        End If
    End Sub

    Private Sub BarButtonItem9_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        Search_Products.ShowDialog()
    End Sub

    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ResourcesTableAdapter1.Fill(Me.SalonsoftDataSet.resources)
    End Sub

    Private Sub BarButtonItem13_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem13.ItemClick
        Permission.ShowDialog()
    End Sub

    Private Sub BarButtonItem11_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem11.ItemClick
        Salon_Settings.ShowDialog()
    End Sub

    Private Sub BarButtonItem12_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem12.ItemClick
        Users.ShowDialog()
    End Sub

    Private Sub BarLargeButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarLargeButtonItem6.ItemClick
        Payroll.ShowDialog()
    End Sub

    Private Sub A_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Payroll.ShowDialog()
    End Sub

    Private Sub AccordionControlElement28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If MessageBox.Show("Are you sure you want to delete ?", "Deleting...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            PayrollBindingSource.RemoveCurrent()
            Me.Validate()
            Me.PayrollBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.SalonsoftDataSet)
        End If
    End Sub

    Private Sub AccordionControlElement27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.PayrollTableAdapter.Fill(Me.SalonsoftDataSet.payroll)
    End Sub

    Private Sub BarButtonItem14_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem14.ItemClick
        Total_Amount.ShowDialog()
    End Sub

    Private Sub SchedulerStorage1_AppointmentsChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraScheduler.PersistentObjectsEventArgs) Handles SchedulerStorage1.AppointmentsChanged, SchedulerStorage1.AppointmentsDeleted, SchedulerStorage1.AppointmentsInserted
        AppointmentsTableAdapter.Update(SalonsoftDataSet1)
        SalonsoftDataSet1.AcceptChanges()
    End Sub

    Private Sub SimpleButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        EmpApt.ShowDialog()
    End Sub

    Private Sub AccordionControlElement27_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccordionControlElement27.Click
        EmpApt.ShowDialog()
    End Sub
End Class

