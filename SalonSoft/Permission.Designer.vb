<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Permission
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
        Dim UserNameLabel As System.Windows.Forms.Label
        Dim CapacityLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Permission))
        Dim ClientsLabel As System.Windows.Forms.Label
        Dim EmployeesLabel As System.Windows.Forms.Label
        Dim ProductsLabel As System.Windows.Forms.Label
        Dim ServicesLabel As System.Windows.Forms.Label
        Dim AppoitmentsLabel As System.Windows.Forms.Label
        Dim PayrollLabel As System.Windows.Forms.Label
        Dim ResourcesLabel As System.Windows.Forms.Label
        Me.SalonsoftDataSet = New SalonSoft.salonsoftDataSet()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsersTableAdapter = New SalonSoft.salonsoftDataSetTableAdapters.usersTableAdapter()
        Me.TableAdapterManager = New SalonSoft.salonsoftDataSetTableAdapters.TableAdapterManager()
        Me.UsersBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.UsersBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.UserNameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CapacityTextEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.ClientsCheckBox = New System.Windows.Forms.CheckBox()
        Me.EmployeesCheckBox = New System.Windows.Forms.CheckBox()
        Me.ProductsCheckBox = New System.Windows.Forms.CheckBox()
        Me.ServicesCheckBox = New System.Windows.Forms.CheckBox()
        Me.AppoitmentsCheckBox = New System.Windows.Forms.CheckBox()
        Me.PayrollCheckBox = New System.Windows.Forms.CheckBox()
        Me.ResourcesCheckBox = New System.Windows.Forms.CheckBox()
        UserNameLabel = New System.Windows.Forms.Label()
        CapacityLabel1 = New System.Windows.Forms.Label()
        ClientsLabel = New System.Windows.Forms.Label()
        EmployeesLabel = New System.Windows.Forms.Label()
        ProductsLabel = New System.Windows.Forms.Label()
        ServicesLabel = New System.Windows.Forms.Label()
        AppoitmentsLabel = New System.Windows.Forms.Label()
        PayrollLabel = New System.Windows.Forms.Label()
        ResourcesLabel = New System.Windows.Forms.Label()
        CType(Me.SalonsoftDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UsersBindingNavigator.SuspendLayout()
        CType(Me.UserNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CapacityTextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserNameLabel
        '
        UserNameLabel.AutoSize = True
        UserNameLabel.Location = New System.Drawing.Point(41, 77)
        UserNameLabel.Name = "UserNameLabel"
        UserNameLabel.Size = New System.Drawing.Size(63, 13)
        UserNameLabel.TabIndex = 25
        UserNameLabel.Text = "User Name:"
        '
        'CapacityLabel1
        '
        CapacityLabel1.AutoSize = True
        CapacityLabel1.Location = New System.Drawing.Point(49, 114)
        CapacityLabel1.Name = "CapacityLabel1"
        CapacityLabel1.Size = New System.Drawing.Size(53, 13)
        CapacityLabel1.TabIndex = 46
        CapacityLabel1.Text = "Capacity:"
        '
        'SalonsoftDataSet
        '
        Me.SalonsoftDataSet.DataSetName = "salonsoftDataSet"
        Me.SalonsoftDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsersBindingSource
        '
        Me.UsersBindingSource.DataMember = "users"
        Me.UsersBindingSource.DataSource = Me.SalonsoftDataSet
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.appointmentsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clientsTableAdapter = Nothing
        Me.TableAdapterManager.employeesTableAdapter = Nothing
        Me.TableAdapterManager.payrollTableAdapter = Nothing
        Me.TableAdapterManager.productTableAdapter = Nothing
        Me.TableAdapterManager.resourcesTableAdapter = Nothing
        Me.TableAdapterManager.salonsettingsTableAdapter = Nothing
        Me.TableAdapterManager.servicesTableAdapter = Nothing
        Me.TableAdapterManager.taskdependesnciesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SalonSoft.salonsoftDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usersTableAdapter = Me.UsersTableAdapter
        '
        'UsersBindingNavigator
        '
        Me.UsersBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.UsersBindingNavigator.BindingSource = Me.UsersBindingSource
        Me.UsersBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.UsersBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.UsersBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.UsersBindingNavigatorSaveItem})
        Me.UsersBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.UsersBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.UsersBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.UsersBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.UsersBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.UsersBindingNavigator.Name = "UsersBindingNavigator"
        Me.UsersBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.UsersBindingNavigator.Size = New System.Drawing.Size(350, 25)
        Me.UsersBindingNavigator.TabIndex = 23
        Me.UsersBindingNavigator.Text = "BindingNavigator1"
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
        'UsersBindingNavigatorSaveItem
        '
        Me.UsersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UsersBindingNavigatorSaveItem.Image = CType(resources.GetObject("UsersBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.UsersBindingNavigatorSaveItem.Name = "UsersBindingNavigatorSaveItem"
        Me.UsersBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.UsersBindingNavigatorSaveItem.Text = "Save Data"
        '
        'UserNameTextEdit
        '
        Me.UserNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.UsersBindingSource, "UserName", True))
        Me.UserNameTextEdit.Location = New System.Drawing.Point(149, 74)
        Me.UserNameTextEdit.Name = "UserNameTextEdit"
        Me.UserNameTextEdit.Size = New System.Drawing.Size(136, 20)
        Me.UserNameTextEdit.TabIndex = 26
        '
        'CapacityTextEdit1
        '
        Me.CapacityTextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.UsersBindingSource, "Capacity", True))
        Me.CapacityTextEdit1.Location = New System.Drawing.Point(149, 111)
        Me.CapacityTextEdit1.Name = "CapacityTextEdit1"
        Me.CapacityTextEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CapacityTextEdit1.Properties.Items.AddRange(New Object() {"Admin", "Employee", "Owner"})
        Me.CapacityTextEdit1.Size = New System.Drawing.Size(136, 20)
        Me.CapacityTextEdit1.TabIndex = 47
        '
        'ClientsLabel
        '
        ClientsLabel.AutoSize = True
        ClientsLabel.Location = New System.Drawing.Point(78, 155)
        ClientsLabel.Name = "ClientsLabel"
        ClientsLabel.Size = New System.Drawing.Size(43, 13)
        ClientsLabel.TabIndex = 57
        ClientsLabel.Text = "Clients:"
        '
        'ClientsCheckBox
        '
        Me.ClientsCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UsersBindingSource, "Clients", True))
        Me.ClientsCheckBox.Location = New System.Drawing.Point(181, 150)
        Me.ClientsCheckBox.Name = "ClientsCheckBox"
        Me.ClientsCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.ClientsCheckBox.TabIndex = 58
        Me.ClientsCheckBox.Text = "Y/N"
        Me.ClientsCheckBox.UseVisualStyleBackColor = True
        '
        'EmployeesLabel
        '
        EmployeesLabel.AutoSize = True
        EmployeesLabel.Location = New System.Drawing.Point(78, 185)
        EmployeesLabel.Name = "EmployeesLabel"
        EmployeesLabel.Size = New System.Drawing.Size(62, 13)
        EmployeesLabel.TabIndex = 59
        EmployeesLabel.Text = "Employees:"
        '
        'EmployeesCheckBox
        '
        Me.EmployeesCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UsersBindingSource, "Employees", True))
        Me.EmployeesCheckBox.Location = New System.Drawing.Point(181, 180)
        Me.EmployeesCheckBox.Name = "EmployeesCheckBox"
        Me.EmployeesCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.EmployeesCheckBox.TabIndex = 60
        Me.EmployeesCheckBox.Text = "Y/N"
        Me.EmployeesCheckBox.UseVisualStyleBackColor = True
        '
        'ProductsLabel
        '
        ProductsLabel.AutoSize = True
        ProductsLabel.Location = New System.Drawing.Point(78, 215)
        ProductsLabel.Name = "ProductsLabel"
        ProductsLabel.Size = New System.Drawing.Size(53, 13)
        ProductsLabel.TabIndex = 61
        ProductsLabel.Text = "Products:"
        '
        'ProductsCheckBox
        '
        Me.ProductsCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UsersBindingSource, "Products", True))
        Me.ProductsCheckBox.Location = New System.Drawing.Point(181, 210)
        Me.ProductsCheckBox.Name = "ProductsCheckBox"
        Me.ProductsCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.ProductsCheckBox.TabIndex = 62
        Me.ProductsCheckBox.Text = "Y/N"
        Me.ProductsCheckBox.UseVisualStyleBackColor = True
        '
        'ServicesLabel
        '
        ServicesLabel.AutoSize = True
        ServicesLabel.Location = New System.Drawing.Point(78, 245)
        ServicesLabel.Name = "ServicesLabel"
        ServicesLabel.Size = New System.Drawing.Size(51, 13)
        ServicesLabel.TabIndex = 63
        ServicesLabel.Text = "Services:"
        '
        'ServicesCheckBox
        '
        Me.ServicesCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UsersBindingSource, "Services", True))
        Me.ServicesCheckBox.Location = New System.Drawing.Point(181, 240)
        Me.ServicesCheckBox.Name = "ServicesCheckBox"
        Me.ServicesCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.ServicesCheckBox.TabIndex = 64
        Me.ServicesCheckBox.Text = "Y/N"
        Me.ServicesCheckBox.UseVisualStyleBackColor = True
        '
        'AppoitmentsLabel
        '
        AppoitmentsLabel.AutoSize = True
        AppoitmentsLabel.Location = New System.Drawing.Point(78, 275)
        AppoitmentsLabel.Name = "AppoitmentsLabel"
        AppoitmentsLabel.Size = New System.Drawing.Size(71, 13)
        AppoitmentsLabel.TabIndex = 65
        AppoitmentsLabel.Text = "Appoitments:"
        '
        'AppoitmentsCheckBox
        '
        Me.AppoitmentsCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UsersBindingSource, "Appoitments", True))
        Me.AppoitmentsCheckBox.Location = New System.Drawing.Point(181, 270)
        Me.AppoitmentsCheckBox.Name = "AppoitmentsCheckBox"
        Me.AppoitmentsCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.AppoitmentsCheckBox.TabIndex = 66
        Me.AppoitmentsCheckBox.Text = "Y/N"
        Me.AppoitmentsCheckBox.UseVisualStyleBackColor = True
        '
        'PayrollLabel
        '
        PayrollLabel.AutoSize = True
        PayrollLabel.Location = New System.Drawing.Point(78, 305)
        PayrollLabel.Name = "PayrollLabel"
        PayrollLabel.Size = New System.Drawing.Size(43, 13)
        PayrollLabel.TabIndex = 67
        PayrollLabel.Text = "Payroll:"
        '
        'PayrollCheckBox
        '
        Me.PayrollCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UsersBindingSource, "Payroll", True))
        Me.PayrollCheckBox.Location = New System.Drawing.Point(181, 300)
        Me.PayrollCheckBox.Name = "PayrollCheckBox"
        Me.PayrollCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.PayrollCheckBox.TabIndex = 68
        Me.PayrollCheckBox.Text = "Y/N"
        Me.PayrollCheckBox.UseVisualStyleBackColor = True
        '
        'ResourcesLabel
        '
        ResourcesLabel.AutoSize = True
        ResourcesLabel.Location = New System.Drawing.Point(78, 335)
        ResourcesLabel.Name = "ResourcesLabel"
        ResourcesLabel.Size = New System.Drawing.Size(61, 13)
        ResourcesLabel.TabIndex = 69
        ResourcesLabel.Text = "Resources:"
        '
        'ResourcesCheckBox
        '
        Me.ResourcesCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UsersBindingSource, "Resources", True))
        Me.ResourcesCheckBox.Location = New System.Drawing.Point(181, 330)
        Me.ResourcesCheckBox.Name = "ResourcesCheckBox"
        Me.ResourcesCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.ResourcesCheckBox.TabIndex = 70
        Me.ResourcesCheckBox.Text = "Y/N"
        Me.ResourcesCheckBox.UseVisualStyleBackColor = True
        '
        'Permission
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 447)
        Me.Controls.Add(ClientsLabel)
        Me.Controls.Add(Me.ClientsCheckBox)
        Me.Controls.Add(EmployeesLabel)
        Me.Controls.Add(Me.EmployeesCheckBox)
        Me.Controls.Add(ProductsLabel)
        Me.Controls.Add(Me.ProductsCheckBox)
        Me.Controls.Add(ServicesLabel)
        Me.Controls.Add(Me.ServicesCheckBox)
        Me.Controls.Add(AppoitmentsLabel)
        Me.Controls.Add(Me.AppoitmentsCheckBox)
        Me.Controls.Add(PayrollLabel)
        Me.Controls.Add(Me.PayrollCheckBox)
        Me.Controls.Add(ResourcesLabel)
        Me.Controls.Add(Me.ResourcesCheckBox)
        Me.Controls.Add(CapacityLabel1)
        Me.Controls.Add(UserNameLabel)
        Me.Controls.Add(Me.UserNameTextEdit)
        Me.Controls.Add(Me.UsersBindingNavigator)
        Me.Controls.Add(Me.CapacityTextEdit1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Permission"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Permission"
        CType(Me.SalonsoftDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UsersBindingNavigator.ResumeLayout(False)
        Me.UsersBindingNavigator.PerformLayout()
        CType(Me.UserNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CapacityTextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SalonsoftDataSet As SalonSoft.salonsoftDataSet
    Friend WithEvents UsersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsersTableAdapter As SalonSoft.salonsoftDataSetTableAdapters.usersTableAdapter
    Friend WithEvents TableAdapterManager As SalonSoft.salonsoftDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UsersBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents UsersBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents UserNameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CapacityTextEdit1 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents ClientsCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents EmployeesCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ProductsCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ServicesCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents AppoitmentsCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents PayrollCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ResourcesCheckBox As System.Windows.Forms.CheckBox
End Class
