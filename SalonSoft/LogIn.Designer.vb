<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogIn
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
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.SalonSoft.SplashScreen1), True, True)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LogIn))
        Me.SalonsoftDataSet = New SalonSoft.salonsoftDataSet()
        Me.UsersBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.PasswordTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.TableAdapterManager = New SalonSoft.salonsoftDataSetTableAdapters.TableAdapterManager()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.UsersTableAdapter = New SalonSoft.salonsoftDataSetTableAdapters.usersTableAdapter()
        Me.CapacityTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ClientsCheckBox = New System.Windows.Forms.CheckBox()
        Me.EmployeesCheckBox = New System.Windows.Forms.CheckBox()
        Me.ProductsCheckBox = New System.Windows.Forms.CheckBox()
        Me.ServicesCheckBox = New System.Windows.Forms.CheckBox()
        Me.AppoitmentsCheckBox = New System.Windows.Forms.CheckBox()
        Me.PayrollCheckBox = New System.Windows.Forms.CheckBox()
        Me.ResourcesCheckBox = New System.Windows.Forms.CheckBox()
        UserNameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        CType(Me.SalonsoftDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UsersBindingNavigator.SuspendLayout()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PasswordTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CapacityTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserNameLabel
        '
        UserNameLabel.AutoSize = True
        UserNameLabel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UserNameLabel.ForeColor = System.Drawing.Color.Transparent
        UserNameLabel.Location = New System.Drawing.Point(149, 42)
        UserNameLabel.Name = "UserNameLabel"
        UserNameLabel.Size = New System.Drawing.Size(81, 16)
        UserNameLabel.TabIndex = 4
        UserNameLabel.Text = "User Name:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PasswordLabel.ForeColor = System.Drawing.Color.Transparent
        PasswordLabel.Location = New System.Drawing.Point(156, 79)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(73, 16)
        PasswordLabel.TabIndex = 6
        PasswordLabel.Text = "Password:"
        '
        'SplashScreenManager1
        '
        SplashScreenManager1.ClosingDelay = 500
        '
        'SalonsoftDataSet
        '
        Me.SalonsoftDataSet.DataSetName = "salonsoftDataSet"
        Me.SalonsoftDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.UsersBindingNavigator.Size = New System.Drawing.Size(597, 29)
        Me.UsersBindingNavigator.TabIndex = 1
        Me.UsersBindingNavigator.Text = "BindingNavigator1"
        Me.UsersBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 26)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'UsersBindingSource
        '
        Me.UsersBindingSource.DataMember = "users"
        Me.UsersBindingSource.DataSource = Me.SalonsoftDataSet
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 26)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 26)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 26)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 26)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 29)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(58, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 29)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 26)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 26)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 29)
        '
        'UsersBindingNavigatorSaveItem
        '
        Me.UsersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UsersBindingNavigatorSaveItem.Image = CType(resources.GetObject("UsersBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.UsersBindingNavigatorSaveItem.Name = "UsersBindingNavigatorSaveItem"
        Me.UsersBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 26)
        Me.UsersBindingNavigatorSaveItem.Text = "Save Data"
        '
        'UserNameTextEdit
        '
        Me.UserNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.UsersBindingSource, "UserName", True))
        Me.UserNameTextEdit.Location = New System.Drawing.Point(70, 76)
        Me.UserNameTextEdit.Name = "UserNameTextEdit"
        Me.UserNameTextEdit.Size = New System.Drawing.Size(10, 20)
        Me.UserNameTextEdit.TabIndex = 5
        '
        'PasswordTextEdit
        '
        Me.PasswordTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.UsersBindingSource, "Password", True))
        Me.PasswordTextEdit.Location = New System.Drawing.Point(88, 76)
        Me.PasswordTextEdit.Name = "PasswordTextEdit"
        Me.PasswordTextEdit.Size = New System.Drawing.Size(10, 20)
        Me.PasswordTextEdit.TabIndex = 7
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.BackColor = System.Drawing.Color.White
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.ForeColor = System.Drawing.Color.Black
        Me.SimpleButton1.Appearance.Options.UseBackColor = True
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Appearance.Options.UseForeColor = True
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.SimpleButton1.Location = New System.Drawing.Point(292, 129)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(84, 32)
        Me.SimpleButton1.TabIndex = 8
        Me.SimpleButton1.Text = "LogIn"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.BackColor = System.Drawing.Color.White
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.SimpleButton2.Appearance.Options.UseBackColor = True
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.Appearance.Options.UseForeColor = True
        Me.SimpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.SimpleButton2.Location = New System.Drawing.Point(152, 129)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(95, 32)
        Me.SimpleButton2.TabIndex = 9
        Me.SimpleButton2.Text = "Cancel"
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(235, 40)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.TextEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.TextEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.TextEdit1.Size = New System.Drawing.Size(141, 20)
        Me.TextEdit1.TabIndex = 10
        '
        'TextEdit2
        '
        Me.TextEdit2.Location = New System.Drawing.Point(235, 78)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.TextEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.TextEdit2.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit2.Properties.Appearance.Options.UseForeColor = True
        Me.TextEdit2.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextEdit2.Size = New System.Drawing.Size(141, 20)
        Me.TextEdit2.TabIndex = 11
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.appointmentsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clientsTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.employeesTableAdapter = Nothing
        Me.TableAdapterManager.payrollTableAdapter = Nothing
        Me.TableAdapterManager.productTableAdapter = Nothing
        Me.TableAdapterManager.resourcesTableAdapter = Nothing
        Me.TableAdapterManager.salonsettingsTableAdapter = Nothing
        Me.TableAdapterManager.servicesTableAdapter = Nothing
        Me.TableAdapterManager.taskdependesnciesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SalonSoft.salonsoftDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usersTableAdapter = Nothing
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(5, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(141, 162)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
        '
        'CapacityTextEdit
        '
        Me.CapacityTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.UsersBindingSource, "Capacity", True))
        Me.CapacityTextEdit.Location = New System.Drawing.Point(70, 126)
        Me.CapacityTextEdit.Name = "CapacityTextEdit"
        Me.CapacityTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.CapacityTextEdit.Properties.Appearance.Options.UseForeColor = True
        Me.CapacityTextEdit.Size = New System.Drawing.Size(14, 20)
        Me.CapacityTextEdit.TabIndex = 22
        '
        'ClientsCheckBox
        '
        Me.ClientsCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UsersBindingSource, "Clients", True))
        Me.ClientsCheckBox.ForeColor = System.Drawing.Color.White
        Me.ClientsCheckBox.Location = New System.Drawing.Point(54, 113)
        Me.ClientsCheckBox.Name = "ClientsCheckBox"
        Me.ClientsCheckBox.Size = New System.Drawing.Size(10, 24)
        Me.ClientsCheckBox.TabIndex = 33
        Me.ClientsCheckBox.UseVisualStyleBackColor = True
        '
        'EmployeesCheckBox
        '
        Me.EmployeesCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UsersBindingSource, "Employees", True))
        Me.EmployeesCheckBox.ForeColor = System.Drawing.Color.White
        Me.EmployeesCheckBox.Location = New System.Drawing.Point(54, 96)
        Me.EmployeesCheckBox.Name = "EmployeesCheckBox"
        Me.EmployeesCheckBox.Size = New System.Drawing.Size(14, 24)
        Me.EmployeesCheckBox.TabIndex = 35
        Me.EmployeesCheckBox.UseVisualStyleBackColor = True
        '
        'ProductsCheckBox
        '
        Me.ProductsCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UsersBindingSource, "Products", True))
        Me.ProductsCheckBox.ForeColor = System.Drawing.Color.White
        Me.ProductsCheckBox.Location = New System.Drawing.Point(56, 83)
        Me.ProductsCheckBox.Name = "ProductsCheckBox"
        Me.ProductsCheckBox.Size = New System.Drawing.Size(12, 24)
        Me.ProductsCheckBox.TabIndex = 37
        Me.ProductsCheckBox.UseVisualStyleBackColor = True
        '
        'ServicesCheckBox
        '
        Me.ServicesCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UsersBindingSource, "Services", True))
        Me.ServicesCheckBox.ForeColor = System.Drawing.Color.White
        Me.ServicesCheckBox.Location = New System.Drawing.Point(85, 96)
        Me.ServicesCheckBox.Name = "ServicesCheckBox"
        Me.ServicesCheckBox.Size = New System.Drawing.Size(13, 24)
        Me.ServicesCheckBox.TabIndex = 39
        Me.ServicesCheckBox.UseVisualStyleBackColor = True
        '
        'AppoitmentsCheckBox
        '
        Me.AppoitmentsCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UsersBindingSource, "Appoitments", True))
        Me.AppoitmentsCheckBox.ForeColor = System.Drawing.Color.White
        Me.AppoitmentsCheckBox.Location = New System.Drawing.Point(74, 102)
        Me.AppoitmentsCheckBox.Name = "AppoitmentsCheckBox"
        Me.AppoitmentsCheckBox.Size = New System.Drawing.Size(12, 24)
        Me.AppoitmentsCheckBox.TabIndex = 41
        Me.AppoitmentsCheckBox.UseVisualStyleBackColor = True
        '
        'PayrollCheckBox
        '
        Me.PayrollCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UsersBindingSource, "Payroll", True))
        Me.PayrollCheckBox.ForeColor = System.Drawing.Color.White
        Me.PayrollCheckBox.Location = New System.Drawing.Point(70, 129)
        Me.PayrollCheckBox.Name = "PayrollCheckBox"
        Me.PayrollCheckBox.Size = New System.Drawing.Size(14, 24)
        Me.PayrollCheckBox.TabIndex = 43
        Me.PayrollCheckBox.UseVisualStyleBackColor = True
        '
        'ResourcesCheckBox
        '
        Me.ResourcesCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UsersBindingSource, "Resources", True))
        Me.ResourcesCheckBox.ForeColor = System.Drawing.Color.White
        Me.ResourcesCheckBox.Location = New System.Drawing.Point(104, 113)
        Me.ResourcesCheckBox.Name = "ResourcesCheckBox"
        Me.ResourcesCheckBox.Size = New System.Drawing.Size(14, 24)
        Me.ResourcesCheckBox.TabIndex = 45
        Me.ResourcesCheckBox.UseVisualStyleBackColor = True
        '
        'LogIn
        '
        Me.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Appearance.ForeColor = System.Drawing.Color.Black
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseFont = True
        Me.Appearance.Options.UseForeColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 186)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextEdit2)
        Me.Controls.Add(Me.TextEdit1)
        Me.Controls.Add(UserNameLabel)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(Me.UsersBindingNavigator)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.UserNameTextEdit)
        Me.Controls.Add(Me.PasswordTextEdit)
        Me.Controls.Add(Me.CapacityTextEdit)
        Me.Controls.Add(Me.ClientsCheckBox)
        Me.Controls.Add(Me.EmployeesCheckBox)
        Me.Controls.Add(Me.ProductsCheckBox)
        Me.Controls.Add(Me.ServicesCheckBox)
        Me.Controls.Add(Me.AppoitmentsCheckBox)
        Me.Controls.Add(Me.PayrollCheckBox)
        Me.Controls.Add(Me.ResourcesCheckBox)
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.LookAndFeel.SkinName = "Office 2016 Dark"
        Me.Name = "LogIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LogIn"
        CType(Me.SalonsoftDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UsersBindingNavigator.ResumeLayout(False)
        Me.UsersBindingNavigator.PerformLayout()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PasswordTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CapacityTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PasswordTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CapacityTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ClientsCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents EmployeesCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ProductsCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ServicesCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents AppoitmentsCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents PayrollCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ResourcesCheckBox As System.Windows.Forms.CheckBox
End Class
