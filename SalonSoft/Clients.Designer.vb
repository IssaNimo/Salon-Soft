<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clients
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
        Dim ClientIdLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim OccupationLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim MobileLabel As System.Windows.Forms.Label
        Dim HomeLabel As System.Windows.Forms.Label
        Dim DateOfBirthLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clients))
        Dim ButtonImageOptions1 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Dim ButtonImageOptions2 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.OccupationTextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.ClientsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalonsoftDataSet = New SalonSoft.salonsoftDataSet()
        Me.GenderComboBox = New System.Windows.Forms.ComboBox()
        Me.ClientIdTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.FirstNameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LastNameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DateOfBirthTextEdit = New DevExpress.XtraEditors.DateEdit()
        Me.ClientsTableAdapter = New SalonSoft.salonsoftDataSetTableAdapters.clientsTableAdapter()
        Me.ClientsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ClientsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.MobileTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.HomeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.EmailTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.TableAdapterManager = New SalonSoft.salonsoftDataSetTableAdapters.TableAdapterManager()
        ClientIdLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        OccupationLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        MobileLabel = New System.Windows.Forms.Label()
        HomeLabel = New System.Windows.Forms.Label()
        DateOfBirthLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.OccupationTextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalonsoftDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientIdTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FirstNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LastNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateOfBirthTextEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateOfBirthTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClientsBindingNavigator.SuspendLayout()
        CType(Me.MobileTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HomeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmailTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ClientIdLabel
        '
        ClientIdLabel.AutoSize = True
        ClientIdLabel.Location = New System.Drawing.Point(8, 51)
        ClientIdLabel.Name = "ClientIdLabel"
        ClientIdLabel.Size = New System.Drawing.Size(51, 13)
        ClientIdLabel.TabIndex = 4
        ClientIdLabel.Text = "Client Id:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(8, 77)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(62, 13)
        FirstNameLabel.TabIndex = 6
        FirstNameLabel.Text = "First Name:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New System.Drawing.Point(8, 103)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(61, 13)
        LastNameLabel.TabIndex = 8
        LastNameLabel.Text = "Last Name:"
        '
        'OccupationLabel
        '
        OccupationLabel.AutoSize = True
        OccupationLabel.Location = New System.Drawing.Point(8, 129)
        OccupationLabel.Name = "OccupationLabel"
        OccupationLabel.Size = New System.Drawing.Size(65, 13)
        OccupationLabel.TabIndex = 10
        OccupationLabel.Text = "Occupation:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Location = New System.Drawing.Point(8, 155)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(46, 13)
        GenderLabel.TabIndex = 12
        GenderLabel.Text = "Gender:"
        '
        'MobileLabel
        '
        MobileLabel.AutoSize = True
        MobileLabel.Location = New System.Drawing.Point(9, 64)
        MobileLabel.Name = "MobileLabel"
        MobileLabel.Size = New System.Drawing.Size(41, 13)
        MobileLabel.TabIndex = 14
        MobileLabel.Text = "Mobile:"
        '
        'HomeLabel
        '
        HomeLabel.AutoSize = True
        HomeLabel.Location = New System.Drawing.Point(9, 90)
        HomeLabel.Name = "HomeLabel"
        HomeLabel.Size = New System.Drawing.Size(38, 13)
        HomeLabel.TabIndex = 16
        HomeLabel.Text = "Home:"
        '
        'DateOfBirthLabel
        '
        DateOfBirthLabel.AutoSize = True
        DateOfBirthLabel.Location = New System.Drawing.Point(8, 181)
        DateOfBirthLabel.Name = "DateOfBirthLabel"
        DateOfBirthLabel.Size = New System.Drawing.Size(74, 13)
        DateOfBirthLabel.TabIndex = 18
        DateOfBirthLabel.Text = "Date Of Birth:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(9, 116)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 20
        EmailLabel.Text = "Email:"
        '
        'GroupControl1
        '
        Me.GroupControl1.CaptionImageOptions.Image = CType(resources.GetObject("GroupControl1.CaptionImageOptions.Image"), System.Drawing.Image)
        Me.GroupControl1.CaptionImageOptions.Location = DevExpress.Utils.GroupElementLocation.AfterText
        Me.GroupControl1.Controls.Add(Me.OccupationTextEdit1)
        Me.GroupControl1.Controls.Add(Me.GenderComboBox)
        Me.GroupControl1.Controls.Add(ClientIdLabel)
        Me.GroupControl1.Controls.Add(DateOfBirthLabel)
        Me.GroupControl1.Controls.Add(Me.ClientIdTextEdit)
        Me.GroupControl1.Controls.Add(FirstNameLabel)
        Me.GroupControl1.Controls.Add(GenderLabel)
        Me.GroupControl1.Controls.Add(Me.FirstNameTextEdit)
        Me.GroupControl1.Controls.Add(OccupationLabel)
        Me.GroupControl1.Controls.Add(LastNameLabel)
        Me.GroupControl1.Controls.Add(Me.LastNameTextEdit)
        Me.GroupControl1.Controls.Add(Me.DateOfBirthTextEdit)
        ButtonImageOptions1.Location = DevExpress.XtraEditors.ButtonPanel.ImageLocation.BeforeText
        Me.GroupControl1.CustomHeaderButtons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("General", True, ButtonImageOptions1)})
        Me.GroupControl1.Location = New System.Drawing.Point(13, 13)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(284, 219)
        Me.GroupControl1.TabIndex = 0
        '
        'OccupationTextEdit1
        '
        Me.OccupationTextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClientsBindingSource, "Occupation", True))
        Me.OccupationTextEdit1.Location = New System.Drawing.Point(88, 126)
        Me.OccupationTextEdit1.Name = "OccupationTextEdit1"
        Me.OccupationTextEdit1.Size = New System.Drawing.Size(155, 20)
        Me.OccupationTextEdit1.TabIndex = 26
        '
        'ClientsBindingSource
        '
        Me.ClientsBindingSource.DataMember = "clients"
        Me.ClientsBindingSource.DataSource = Me.SalonsoftDataSet
        '
        'SalonsoftDataSet
        '
        Me.SalonsoftDataSet.DataSetName = "salonsoftDataSet"
        Me.SalonsoftDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GenderComboBox
        '
        Me.GenderComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientsBindingSource, "Gender", True))
        Me.GenderComboBox.FormattingEnabled = True
        Me.GenderComboBox.Items.AddRange(New Object() {"Male", "Female"})
        Me.GenderComboBox.Location = New System.Drawing.Point(88, 151)
        Me.GenderComboBox.Name = "GenderComboBox"
        Me.GenderComboBox.Size = New System.Drawing.Size(155, 21)
        Me.GenderComboBox.TabIndex = 26
        '
        'ClientIdTextEdit
        '
        Me.ClientIdTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClientsBindingSource, "ClientId", True))
        Me.ClientIdTextEdit.Location = New System.Drawing.Point(88, 48)
        Me.ClientIdTextEdit.Name = "ClientIdTextEdit"
        Me.ClientIdTextEdit.Size = New System.Drawing.Size(155, 20)
        Me.ClientIdTextEdit.TabIndex = 5
        '
        'FirstNameTextEdit
        '
        Me.FirstNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClientsBindingSource, "FirstName", True))
        Me.FirstNameTextEdit.Location = New System.Drawing.Point(88, 74)
        Me.FirstNameTextEdit.Name = "FirstNameTextEdit"
        Me.FirstNameTextEdit.Size = New System.Drawing.Size(155, 20)
        Me.FirstNameTextEdit.TabIndex = 7
        '
        'LastNameTextEdit
        '
        Me.LastNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClientsBindingSource, "LastName", True))
        Me.LastNameTextEdit.Location = New System.Drawing.Point(88, 100)
        Me.LastNameTextEdit.Name = "LastNameTextEdit"
        Me.LastNameTextEdit.Size = New System.Drawing.Size(155, 20)
        Me.LastNameTextEdit.TabIndex = 9
        '
        'DateOfBirthTextEdit
        '
        Me.DateOfBirthTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClientsBindingSource, "DateOfBirth", True))
        Me.DateOfBirthTextEdit.EditValue = Nothing
        Me.DateOfBirthTextEdit.Location = New System.Drawing.Point(88, 178)
        Me.DateOfBirthTextEdit.Name = "DateOfBirthTextEdit"
        Me.DateOfBirthTextEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateOfBirthTextEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateOfBirthTextEdit.Properties.DisplayFormat.FormatString = ""
        Me.DateOfBirthTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DateOfBirthTextEdit.Properties.EditFormat.FormatString = ""
        Me.DateOfBirthTextEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DateOfBirthTextEdit.Properties.Mask.EditMask = ""
        Me.DateOfBirthTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.DateOfBirthTextEdit.Size = New System.Drawing.Size(155, 20)
        Me.DateOfBirthTextEdit.TabIndex = 19
        '
        'ClientsTableAdapter
        '
        Me.ClientsTableAdapter.ClearBeforeFill = True
        '
        'ClientsBindingNavigator
        '
        Me.ClientsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ClientsBindingNavigator.BindingSource = Me.ClientsBindingSource
        Me.ClientsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ClientsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ClientsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ClientsBindingNavigatorSaveItem})
        Me.ClientsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ClientsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ClientsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ClientsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ClientsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ClientsBindingNavigator.Name = "ClientsBindingNavigator"
        Me.ClientsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ClientsBindingNavigator.Size = New System.Drawing.Size(684, 25)
        Me.ClientsBindingNavigator.TabIndex = 1
        Me.ClientsBindingNavigator.Text = "BindingNavigator1"
        Me.ClientsBindingNavigator.Visible = False
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
        'ClientsBindingNavigatorSaveItem
        '
        Me.ClientsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ClientsBindingNavigatorSaveItem.Image = CType(resources.GetObject("ClientsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ClientsBindingNavigatorSaveItem.Name = "ClientsBindingNavigatorSaveItem"
        Me.ClientsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ClientsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'MobileTextEdit
        '
        Me.MobileTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClientsBindingSource, "Mobile", True))
        Me.MobileTextEdit.Location = New System.Drawing.Point(89, 61)
        Me.MobileTextEdit.Name = "MobileTextEdit"
        Me.MobileTextEdit.Size = New System.Drawing.Size(155, 20)
        Me.MobileTextEdit.TabIndex = 15
        '
        'HomeTextEdit
        '
        Me.HomeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClientsBindingSource, "Home", True))
        Me.HomeTextEdit.Location = New System.Drawing.Point(89, 87)
        Me.HomeTextEdit.Name = "HomeTextEdit"
        Me.HomeTextEdit.Size = New System.Drawing.Size(155, 20)
        Me.HomeTextEdit.TabIndex = 17
        '
        'EmailTextEdit
        '
        Me.EmailTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClientsBindingSource, "Email", True))
        Me.EmailTextEdit.Location = New System.Drawing.Point(89, 113)
        Me.EmailTextEdit.Name = "EmailTextEdit"
        Me.EmailTextEdit.Size = New System.Drawing.Size(155, 20)
        Me.EmailTextEdit.TabIndex = 21
        '
        'GroupControl2
        '
        Me.GroupControl2.CaptionImageOptions.Image = CType(resources.GetObject("GroupControl2.CaptionImageOptions.Image"), System.Drawing.Image)
        Me.GroupControl2.Controls.Add(Me.HomeTextEdit)
        Me.GroupControl2.Controls.Add(MobileLabel)
        Me.GroupControl2.Controls.Add(HomeLabel)
        Me.GroupControl2.Controls.Add(EmailLabel)
        Me.GroupControl2.Controls.Add(Me.MobileTextEdit)
        Me.GroupControl2.Controls.Add(Me.EmailTextEdit)
        Me.GroupControl2.CustomHeaderButtons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Contacts", True, ButtonImageOptions2)})
        Me.GroupControl2.Location = New System.Drawing.Point(12, 241)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(285, 165)
        Me.GroupControl2.TabIndex = 22
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.SimpleButton1.Location = New System.Drawing.Point(279, 438)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 23
        Me.SimpleButton1.Text = "Cancel"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.SimpleButton2.Location = New System.Drawing.Point(143, 438)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton2.TabIndex = 24
        Me.SimpleButton2.Text = "Save"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.SimpleButton3.Location = New System.Drawing.Point(7, 438)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton3.TabIndex = 25
        Me.SimpleButton3.Text = "Add New"
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.appointmentsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clientsTableAdapter = Me.ClientsTableAdapter
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
        'Clients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 486)
        Me.ControlBox = False
        Me.Controls.Add(Me.SimpleButton3)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.ClientsBindingNavigator)
        Me.Controls.Add(Me.GroupControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Clients"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Clients"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.OccupationTextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalonsoftDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientIdTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FirstNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LastNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateOfBirthTextEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateOfBirthTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClientsBindingNavigator.ResumeLayout(False)
        Me.ClientsBindingNavigator.PerformLayout()
        CType(Me.MobileTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HomeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmailTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SalonsoftDataSet As SalonSoft.salonsoftDataSet
    Friend WithEvents ClientsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientsTableAdapter As SalonSoft.salonsoftDataSetTableAdapters.clientsTableAdapter
    Friend WithEvents TableAdapterManager As SalonSoft.salonsoftDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ClientsBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ClientsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ClientIdTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FirstNameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LastNameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents MobileTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents HomeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents EmailTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GenderComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents OccupationTextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DateOfBirthTextEdit As DevExpress.XtraEditors.DateEdit
End Class
