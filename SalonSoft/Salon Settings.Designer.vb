<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Salon_Settings
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
        Dim SalonNameLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim FaxLabel As System.Windows.Forms.Label
        Dim PhoneNumberLabel As System.Windows.Forms.Label
        Dim BuildingLabel As System.Windows.Forms.Label
        Dim KRAPinLabel As System.Windows.Forms.Label
        Dim SloganLabel As System.Windows.Forms.Label
        Dim LogoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Salon_Settings))
        Me.SalonsoftDataSet = New SalonSoft.salonsoftDataSet()
        Me.SalonsettingsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalonsettingsTableAdapter = New SalonSoft.salonsoftDataSetTableAdapters.salonsettingsTableAdapter()
        Me.TableAdapterManager = New SalonSoft.salonsoftDataSetTableAdapters.TableAdapterManager()
        Me.SalonsettingsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.SalonsettingsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.SalonNameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.AddressTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.EmailTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.FaxTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PhoneNumberTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.BuildingTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.KRAPinTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.SloganTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LogoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        SalonNameLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        FaxLabel = New System.Windows.Forms.Label()
        PhoneNumberLabel = New System.Windows.Forms.Label()
        BuildingLabel = New System.Windows.Forms.Label()
        KRAPinLabel = New System.Windows.Forms.Label()
        SloganLabel = New System.Windows.Forms.Label()
        LogoLabel = New System.Windows.Forms.Label()
        CType(Me.SalonsoftDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalonsettingsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalonsettingsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SalonsettingsBindingNavigator.SuspendLayout()
        CType(Me.SalonNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddressTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmailTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FaxTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PhoneNumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuildingTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KRAPinTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SloganTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SalonNameLabel
        '
        SalonNameLabel.AutoSize = True
        SalonNameLabel.Location = New System.Drawing.Point(12, 108)
        SalonNameLabel.Name = "SalonNameLabel"
        SalonNameLabel.Size = New System.Drawing.Size(67, 13)
        SalonNameLabel.TabIndex = 3
        SalonNameLabel.Text = "Salon Name:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(12, 134)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(50, 13)
        AddressLabel.TabIndex = 5
        AddressLabel.Text = "Address:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(12, 160)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 7
        EmailLabel.Text = "Email:"
        '
        'FaxLabel
        '
        FaxLabel.AutoSize = True
        FaxLabel.Location = New System.Drawing.Point(12, 186)
        FaxLabel.Name = "FaxLabel"
        FaxLabel.Size = New System.Drawing.Size(29, 13)
        FaxLabel.TabIndex = 9
        FaxLabel.Text = "Fax:"
        '
        'PhoneNumberLabel
        '
        PhoneNumberLabel.AutoSize = True
        PhoneNumberLabel.Location = New System.Drawing.Point(12, 212)
        PhoneNumberLabel.Name = "PhoneNumberLabel"
        PhoneNumberLabel.Size = New System.Drawing.Size(81, 13)
        PhoneNumberLabel.TabIndex = 11
        PhoneNumberLabel.Text = "Phone Number:"
        '
        'BuildingLabel
        '
        BuildingLabel.AutoSize = True
        BuildingLabel.Location = New System.Drawing.Point(12, 238)
        BuildingLabel.Name = "BuildingLabel"
        BuildingLabel.Size = New System.Drawing.Size(47, 13)
        BuildingLabel.TabIndex = 13
        BuildingLabel.Text = "Building:"
        '
        'KRAPinLabel
        '
        KRAPinLabel.AutoSize = True
        KRAPinLabel.Location = New System.Drawing.Point(12, 264)
        KRAPinLabel.Name = "KRAPinLabel"
        KRAPinLabel.Size = New System.Drawing.Size(45, 13)
        KRAPinLabel.TabIndex = 15
        KRAPinLabel.Text = "KRAPin:"
        '
        'SloganLabel
        '
        SloganLabel.AutoSize = True
        SloganLabel.Location = New System.Drawing.Point(12, 290)
        SloganLabel.Name = "SloganLabel"
        SloganLabel.Size = New System.Drawing.Size(43, 13)
        SloganLabel.TabIndex = 17
        SloganLabel.Text = "Slogan:"
        '
        'LogoLabel
        '
        LogoLabel.AutoSize = True
        LogoLabel.Location = New System.Drawing.Point(12, 316)
        LogoLabel.Name = "LogoLabel"
        LogoLabel.Size = New System.Drawing.Size(34, 13)
        LogoLabel.TabIndex = 19
        LogoLabel.Text = "Logo:"
        '
        'SalonsoftDataSet
        '
        Me.SalonsoftDataSet.DataSetName = "salonsoftDataSet"
        Me.SalonsoftDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SalonsettingsBindingSource
        '
        Me.SalonsettingsBindingSource.DataMember = "salonsettings"
        Me.SalonsettingsBindingSource.DataSource = Me.SalonsoftDataSet
        '
        'SalonsettingsTableAdapter
        '
        Me.SalonsettingsTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.salonsettingsTableAdapter = Me.SalonsettingsTableAdapter
        Me.TableAdapterManager.servicesTableAdapter = Nothing
        Me.TableAdapterManager.taskdependesnciesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SalonSoft.salonsoftDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usersTableAdapter = Nothing
        '
        'SalonsettingsBindingNavigator
        '
        Me.SalonsettingsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SalonsettingsBindingNavigator.BindingSource = Me.SalonsettingsBindingSource
        Me.SalonsettingsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SalonsettingsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SalonsettingsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SalonsettingsBindingNavigatorSaveItem})
        Me.SalonsettingsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SalonsettingsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SalonsettingsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SalonsettingsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SalonsettingsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SalonsettingsBindingNavigator.Name = "SalonsettingsBindingNavigator"
        Me.SalonsettingsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SalonsettingsBindingNavigator.Size = New System.Drawing.Size(504, 25)
        Me.SalonsettingsBindingNavigator.TabIndex = 0
        Me.SalonsettingsBindingNavigator.Text = "BindingNavigator1"
        Me.SalonsettingsBindingNavigator.Visible = False
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
        'SalonsettingsBindingNavigatorSaveItem
        '
        Me.SalonsettingsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SalonsettingsBindingNavigatorSaveItem.Image = CType(resources.GetObject("SalonsettingsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SalonsettingsBindingNavigatorSaveItem.Name = "SalonsettingsBindingNavigatorSaveItem"
        Me.SalonsettingsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.SalonsettingsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'SalonNameTextEdit
        '
        Me.SalonNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SalonsettingsBindingSource, "SalonName", True))
        Me.SalonNameTextEdit.Location = New System.Drawing.Point(99, 105)
        Me.SalonNameTextEdit.Name = "SalonNameTextEdit"
        Me.SalonNameTextEdit.Size = New System.Drawing.Size(186, 20)
        Me.SalonNameTextEdit.TabIndex = 4
        '
        'AddressTextEdit
        '
        Me.AddressTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SalonsettingsBindingSource, "Address", True))
        Me.AddressTextEdit.Location = New System.Drawing.Point(99, 131)
        Me.AddressTextEdit.Name = "AddressTextEdit"
        Me.AddressTextEdit.Size = New System.Drawing.Size(186, 20)
        Me.AddressTextEdit.TabIndex = 6
        '
        'EmailTextEdit
        '
        Me.EmailTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SalonsettingsBindingSource, "Email", True))
        Me.EmailTextEdit.Location = New System.Drawing.Point(99, 157)
        Me.EmailTextEdit.Name = "EmailTextEdit"
        Me.EmailTextEdit.Size = New System.Drawing.Size(186, 20)
        Me.EmailTextEdit.TabIndex = 8
        '
        'FaxTextEdit
        '
        Me.FaxTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SalonsettingsBindingSource, "Fax", True))
        Me.FaxTextEdit.Location = New System.Drawing.Point(99, 183)
        Me.FaxTextEdit.Name = "FaxTextEdit"
        Me.FaxTextEdit.Size = New System.Drawing.Size(186, 20)
        Me.FaxTextEdit.TabIndex = 10
        '
        'PhoneNumberTextEdit
        '
        Me.PhoneNumberTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SalonsettingsBindingSource, "PhoneNumber", True))
        Me.PhoneNumberTextEdit.Location = New System.Drawing.Point(99, 209)
        Me.PhoneNumberTextEdit.Name = "PhoneNumberTextEdit"
        Me.PhoneNumberTextEdit.Size = New System.Drawing.Size(186, 20)
        Me.PhoneNumberTextEdit.TabIndex = 12
        '
        'BuildingTextEdit
        '
        Me.BuildingTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SalonsettingsBindingSource, "Building", True))
        Me.BuildingTextEdit.Location = New System.Drawing.Point(99, 235)
        Me.BuildingTextEdit.Name = "BuildingTextEdit"
        Me.BuildingTextEdit.Size = New System.Drawing.Size(186, 20)
        Me.BuildingTextEdit.TabIndex = 14
        '
        'KRAPinTextEdit
        '
        Me.KRAPinTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SalonsettingsBindingSource, "KRAPin", True))
        Me.KRAPinTextEdit.Location = New System.Drawing.Point(99, 261)
        Me.KRAPinTextEdit.Name = "KRAPinTextEdit"
        Me.KRAPinTextEdit.Size = New System.Drawing.Size(186, 20)
        Me.KRAPinTextEdit.TabIndex = 16
        '
        'SloganTextEdit
        '
        Me.SloganTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SalonsettingsBindingSource, "Slogan", True))
        Me.SloganTextEdit.Location = New System.Drawing.Point(99, 287)
        Me.SloganTextEdit.Name = "SloganTextEdit"
        Me.SloganTextEdit.Size = New System.Drawing.Size(186, 20)
        Me.SloganTextEdit.TabIndex = 18
        '
        'LogoTextEdit
        '
        Me.LogoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SalonsettingsBindingSource, "Logo", True))
        Me.LogoTextEdit.Location = New System.Drawing.Point(99, 313)
        Me.LogoTextEdit.Name = "LogoTextEdit"
        Me.LogoTextEdit.Size = New System.Drawing.Size(186, 20)
        Me.LogoTextEdit.TabIndex = 20
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 359)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 21
        Me.SimpleButton1.Text = "Add"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(126, 359)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton2.TabIndex = 22
        Me.SimpleButton2.Text = "Save"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Location = New System.Drawing.Point(232, 359)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton3.TabIndex = 23
        Me.SimpleButton3.Text = "Delete"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"), Object)
        Me.PictureEdit1.Location = New System.Drawing.Point(3, 7)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureEdit1.Size = New System.Drawing.Size(90, 87)
        Me.PictureEdit1.TabIndex = 24
        '
        'Salon_Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 394)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.SimpleButton3)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(SalonNameLabel)
        Me.Controls.Add(Me.SalonNameTextEdit)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextEdit)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextEdit)
        Me.Controls.Add(FaxLabel)
        Me.Controls.Add(Me.FaxTextEdit)
        Me.Controls.Add(PhoneNumberLabel)
        Me.Controls.Add(Me.PhoneNumberTextEdit)
        Me.Controls.Add(BuildingLabel)
        Me.Controls.Add(Me.BuildingTextEdit)
        Me.Controls.Add(KRAPinLabel)
        Me.Controls.Add(Me.KRAPinTextEdit)
        Me.Controls.Add(SloganLabel)
        Me.Controls.Add(Me.SloganTextEdit)
        Me.Controls.Add(LogoLabel)
        Me.Controls.Add(Me.LogoTextEdit)
        Me.Controls.Add(Me.SalonsettingsBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Salon_Settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Salon_Settings"
        CType(Me.SalonsoftDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalonsettingsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalonsettingsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SalonsettingsBindingNavigator.ResumeLayout(False)
        Me.SalonsettingsBindingNavigator.PerformLayout()
        CType(Me.SalonNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddressTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmailTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FaxTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PhoneNumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuildingTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KRAPinTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SloganTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SalonsoftDataSet As SalonSoft.salonsoftDataSet
    Friend WithEvents SalonsettingsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SalonsettingsTableAdapter As SalonSoft.salonsoftDataSetTableAdapters.salonsettingsTableAdapter
    Friend WithEvents TableAdapterManager As SalonSoft.salonsoftDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SalonsettingsBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents SalonsettingsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents SalonNameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents AddressTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents EmailTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FaxTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PhoneNumberTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BuildingTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents KRAPinTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SloganTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LogoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
End Class
