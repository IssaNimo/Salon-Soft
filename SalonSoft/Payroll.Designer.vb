<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payroll
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DateLabel As System.Windows.Forms.Label
        Dim ServiceLabel As System.Windows.Forms.Label
        Dim Total_AmountLabel As System.Windows.Forms.Label
        Dim EmployeeComissionLabel As System.Windows.Forms.Label
        Dim OwnerComissionLabel As System.Windows.Forms.Label
        Dim EmployeesNameLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Payroll))
        Dim ButtonImageOptions1 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Me.SalonsoftDataSet = New SalonSoft.salonsoftDataSet()
        Me.PayrollBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PayrollTableAdapter = New SalonSoft.salonsoftDataSetTableAdapters.payrollTableAdapter()
        Me.TableAdapterManager = New SalonSoft.salonsoftDataSetTableAdapters.TableAdapterManager()
        Me.PayrollBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.PayrollBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.DateTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Total_AmountTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.EmployeeComissionTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.OwnerComissionTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.EmployeesNameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        DateLabel = New System.Windows.Forms.Label()
        ServiceLabel = New System.Windows.Forms.Label()
        Total_AmountLabel = New System.Windows.Forms.Label()
        EmployeeComissionLabel = New System.Windows.Forms.Label()
        OwnerComissionLabel = New System.Windows.Forms.Label()
        EmployeesNameLabel = New System.Windows.Forms.Label()
        CType(Me.SalonsoftDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PayrollBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PayrollBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PayrollBindingNavigator.SuspendLayout()
        CType(Me.DateTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Total_AmountTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeComissionTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OwnerComissionTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.EmployeesNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Location = New System.Drawing.Point(9, 72)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(34, 13)
        DateLabel.TabIndex = 3
        DateLabel.Text = "Date:"
        '
        'ServiceLabel
        '
        ServiceLabel.AutoSize = True
        ServiceLabel.Location = New System.Drawing.Point(18, 222)
        ServiceLabel.Name = "ServiceLabel"
        ServiceLabel.Size = New System.Drawing.Size(46, 13)
        ServiceLabel.TabIndex = 5
        ServiceLabel.Text = "Service:"
        '
        'Total_AmountLabel
        '
        Total_AmountLabel.AutoSize = True
        Total_AmountLabel.Location = New System.Drawing.Point(9, 130)
        Total_AmountLabel.Name = "Total_AmountLabel"
        Total_AmountLabel.Size = New System.Drawing.Size(75, 13)
        Total_AmountLabel.TabIndex = 7
        Total_AmountLabel.Text = "Total Amount:"
        '
        'EmployeeComissionLabel
        '
        EmployeeComissionLabel.AutoSize = True
        EmployeeComissionLabel.Location = New System.Drawing.Point(9, 159)
        EmployeeComissionLabel.Name = "EmployeeComissionLabel"
        EmployeeComissionLabel.Size = New System.Drawing.Size(107, 13)
        EmployeeComissionLabel.TabIndex = 9
        EmployeeComissionLabel.Text = "Employee Comission:"
        '
        'OwnerComissionLabel
        '
        OwnerComissionLabel.AutoSize = True
        OwnerComissionLabel.Location = New System.Drawing.Point(9, 188)
        OwnerComissionLabel.Name = "OwnerComissionLabel"
        OwnerComissionLabel.Size = New System.Drawing.Size(93, 13)
        OwnerComissionLabel.TabIndex = 11
        OwnerComissionLabel.Text = "Owner Comission:"
        '
        'EmployeesNameLabel
        '
        EmployeesNameLabel.AutoSize = True
        EmployeesNameLabel.Location = New System.Drawing.Point(9, 101)
        EmployeesNameLabel.Name = "EmployeesNameLabel"
        EmployeesNameLabel.Size = New System.Drawing.Size(92, 13)
        EmployeesNameLabel.TabIndex = 15
        EmployeesNameLabel.Text = "Employees Name:"
        '
        'SalonsoftDataSet
        '
        Me.SalonsoftDataSet.DataSetName = "salonsoftDataSet"
        Me.SalonsoftDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PayrollBindingSource
        '
        Me.PayrollBindingSource.DataMember = "payroll"
        Me.PayrollBindingSource.DataSource = Me.SalonsoftDataSet
        '
        'PayrollTableAdapter
        '
        Me.PayrollTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.appointmentsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clientsTableAdapter = Nothing
        Me.TableAdapterManager.employeesTableAdapter = Nothing
        Me.TableAdapterManager.payrollTableAdapter = Me.PayrollTableAdapter
        Me.TableAdapterManager.productTableAdapter = Nothing
        Me.TableAdapterManager.resourcesTableAdapter = Nothing
        Me.TableAdapterManager.salonsettingsTableAdapter = Nothing
        Me.TableAdapterManager.servicesTableAdapter = Nothing
        Me.TableAdapterManager.taskdependesnciesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SalonSoft.salonsoftDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usersTableAdapter = Nothing
        '
        'PayrollBindingNavigator
        '
        Me.PayrollBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PayrollBindingNavigator.BindingSource = Me.PayrollBindingSource
        Me.PayrollBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PayrollBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PayrollBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PayrollBindingNavigatorSaveItem})
        Me.PayrollBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PayrollBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PayrollBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PayrollBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PayrollBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PayrollBindingNavigator.Name = "PayrollBindingNavigator"
        Me.PayrollBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PayrollBindingNavigator.Size = New System.Drawing.Size(608, 25)
        Me.PayrollBindingNavigator.TabIndex = 0
        Me.PayrollBindingNavigator.Text = "BindingNavigator1"
        Me.PayrollBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'PayrollBindingNavigatorSaveItem
        '
        Me.PayrollBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PayrollBindingNavigatorSaveItem.Image = CType(resources.GetObject("PayrollBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PayrollBindingNavigatorSaveItem.Name = "PayrollBindingNavigatorSaveItem"
        Me.PayrollBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PayrollBindingNavigatorSaveItem.Text = "Save Data"
        '
        'DateTextEdit
        '
        Me.DateTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PayrollBindingSource, "Date", True))
        Me.DateTextEdit.Location = New System.Drawing.Point(122, 69)
        Me.DateTextEdit.Name = "DateTextEdit"
        Me.DateTextEdit.Size = New System.Drawing.Size(219, 20)
        Me.DateTextEdit.TabIndex = 4
        '
        'Total_AmountTextEdit
        '
        Me.Total_AmountTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PayrollBindingSource, "Total Amount", True))
        Me.Total_AmountTextEdit.Location = New System.Drawing.Point(122, 127)
        Me.Total_AmountTextEdit.Name = "Total_AmountTextEdit"
        Me.Total_AmountTextEdit.Size = New System.Drawing.Size(219, 20)
        Me.Total_AmountTextEdit.TabIndex = 8
        '
        'EmployeeComissionTextEdit
        '
        Me.EmployeeComissionTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PayrollBindingSource, "EmployeeComission", True))
        Me.EmployeeComissionTextEdit.Location = New System.Drawing.Point(122, 156)
        Me.EmployeeComissionTextEdit.Name = "EmployeeComissionTextEdit"
        Me.EmployeeComissionTextEdit.Size = New System.Drawing.Size(219, 20)
        Me.EmployeeComissionTextEdit.TabIndex = 10
        '
        'OwnerComissionTextEdit
        '
        Me.OwnerComissionTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PayrollBindingSource, "OwnerComission", True))
        Me.OwnerComissionTextEdit.Location = New System.Drawing.Point(122, 185)
        Me.OwnerComissionTextEdit.Name = "OwnerComissionTextEdit"
        Me.OwnerComissionTextEdit.Size = New System.Drawing.Size(219, 20)
        Me.OwnerComissionTextEdit.TabIndex = 12
        '
        'GroupControl1
        '
        Me.GroupControl1.CaptionImageOptions.Image = CType(resources.GetObject("GroupControl1.CaptionImageOptions.Image"), System.Drawing.Image)
        Me.GroupControl1.Controls.Add(Me.EmployeesNameTextEdit)
        Me.GroupControl1.Controls.Add(EmployeesNameLabel)
        Me.GroupControl1.Controls.Add(Me.RadioButton3)
        Me.GroupControl1.Controls.Add(Me.RadioButton2)
        Me.GroupControl1.Controls.Add(Me.RadioButton1)
        Me.GroupControl1.Controls.Add(Me.EmployeeComissionTextEdit)
        Me.GroupControl1.Controls.Add(DateLabel)
        Me.GroupControl1.Controls.Add(Me.OwnerComissionTextEdit)
        Me.GroupControl1.Controls.Add(Me.DateTextEdit)
        Me.GroupControl1.Controls.Add(OwnerComissionLabel)
        Me.GroupControl1.Controls.Add(ServiceLabel)
        Me.GroupControl1.Controls.Add(EmployeeComissionLabel)
        Me.GroupControl1.Controls.Add(Me.Total_AmountTextEdit)
        Me.GroupControl1.Controls.Add(Total_AmountLabel)
        ButtonImageOptions1.Location = DevExpress.XtraEditors.ButtonPanel.ImageLocation.BeforeText
        Me.GroupControl1.CustomHeaderButtons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Payroll Details", True, ButtonImageOptions1)})
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(408, 258)
        Me.GroupControl1.TabIndex = 13
        '
        'EmployeesNameTextEdit
        '
        Me.EmployeesNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PayrollBindingSource, "EmployeesName", True))
        Me.EmployeesNameTextEdit.Location = New System.Drawing.Point(121, 98)
        Me.EmployeesNameTextEdit.Name = "EmployeesNameTextEdit"
        Me.EmployeesNameTextEdit.Size = New System.Drawing.Size(219, 20)
        Me.EmployeesNameTextEdit.TabIndex = 18
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(287, 222)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(53, 17)
        Me.RadioButton3.TabIndex = 15
        Me.RadioButton3.Text = "Other"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(216, 223)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(59, 17)
        Me.RadioButton2.TabIndex = 14
        Me.RadioButton2.Text = "Beauty"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(130, 223)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(67, 17)
        Me.RadioButton1.TabIndex = 13
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Weaving"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 279)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 14
        Me.SimpleButton1.Text = "Add"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.SimpleButton2.Location = New System.Drawing.Point(333, 279)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton2.TabIndex = 15
        Me.SimpleButton2.Text = "Cancel"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.SimpleButton3.Location = New System.Drawing.Point(226, 279)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton3.TabIndex = 16
        Me.SimpleButton3.Text = "Calculate"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.SimpleButton4.Location = New System.Drawing.Point(119, 279)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton4.TabIndex = 17
        Me.SimpleButton4.Text = "Save"
        '
        'Payroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 337)
        Me.ControlBox = False
        Me.Controls.Add(Me.SimpleButton4)
        Me.Controls.Add(Me.SimpleButton3)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.PayrollBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Payroll"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payroll"
        CType(Me.SalonsoftDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PayrollBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PayrollBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PayrollBindingNavigator.ResumeLayout(False)
        Me.PayrollBindingNavigator.PerformLayout()
        CType(Me.DateTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Total_AmountTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeComissionTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OwnerComissionTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.EmployeesNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SalonsoftDataSet As SalonSoft.salonsoftDataSet
    Friend WithEvents PayrollBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PayrollTableAdapter As SalonSoft.salonsoftDataSetTableAdapters.payrollTableAdapter
    Friend WithEvents TableAdapterManager As SalonSoft.salonsoftDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PayrollBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PayrollBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents DateTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Total_AmountTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents EmployeeComissionTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents OwnerComissionTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents EmployeesNameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
End Class
