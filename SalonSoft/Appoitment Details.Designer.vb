<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Find_Client
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Find_Client))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.RadioGroup1 = New DevExpress.XtraEditors.RadioGroup()
        Me.SalonsoftDataSet1 = New SalonSoft.salonsoftDataSet1()
        Me.AppointmentsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AppointmentsTableAdapter = New SalonSoft.salonsoftDataSet1TableAdapters.appointmentsTableAdapter()
        Me.TableAdapterManager1 = New SalonSoft.salonsoftDataSet1TableAdapters.TableAdapterManager()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSubject = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStart = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEnd = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colResourceID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colid_User = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAllDay = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLocation = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLabel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colResourceIDs = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReminderInfo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustomField1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AppointmentsGridControl = New DevExpress.XtraGrid.GridControl()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalonsoftDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppointmentsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppointmentsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 18)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(54, 18)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Search:"
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(127, 18)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(181, 20)
        Me.TextEdit1.TabIndex = 3
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(912, 16)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 4
        Me.SimpleButton1.Text = "Close"
        '
        'RadioGroup1
        '
        Me.RadioGroup1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.RadioGroup1.Location = New System.Drawing.Point(448, 14)
        Me.RadioGroup1.Name = "RadioGroup1"
        Me.RadioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Resources ID"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Description")})
        Me.RadioGroup1.Size = New System.Drawing.Size(210, 27)
        Me.RadioGroup1.TabIndex = 8
        '
        'SalonsoftDataSet1
        '
        Me.SalonsoftDataSet1.DataSetName = "salonsoftDataSet1"
        Me.SalonsoftDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AppointmentsBindingSource1
        '
        Me.AppointmentsBindingSource1.DataMember = "appointments"
        Me.AppointmentsBindingSource1.DataSource = Me.SalonsoftDataSet1
        '
        'AppointmentsTableAdapter
        '
        Me.AppointmentsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.appointmentsTableAdapter = Me.AppointmentsTableAdapter
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.resourcesTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = SalonSoft.salonsoftDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSubject, Me.colStart, Me.colEnd, Me.colResourceID, Me.colid_User, Me.colAllDay, Me.colLocation, Me.colDescription, Me.colStatus, Me.colLabel, Me.colResourceIDs, Me.colReminderInfo, Me.colCustomField1})
        Me.GridView1.GridControl = Me.AppointmentsGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colSubject
        '
        Me.colSubject.FieldName = "Subject"
        Me.colSubject.Name = "colSubject"
        Me.colSubject.Visible = True
        Me.colSubject.VisibleIndex = 0
        Me.colSubject.Width = 74
        '
        'colStart
        '
        Me.colStart.FieldName = "Start"
        Me.colStart.Name = "colStart"
        Me.colStart.Visible = True
        Me.colStart.VisibleIndex = 1
        Me.colStart.Width = 74
        '
        'colEnd
        '
        Me.colEnd.FieldName = "End"
        Me.colEnd.Name = "colEnd"
        Me.colEnd.Visible = True
        Me.colEnd.VisibleIndex = 2
        Me.colEnd.Width = 74
        '
        'colResourceID
        '
        Me.colResourceID.FieldName = "ResourceID"
        Me.colResourceID.Name = "colResourceID"
        Me.colResourceID.Visible = True
        Me.colResourceID.VisibleIndex = 3
        Me.colResourceID.Width = 81
        '
        'colid_User
        '
        Me.colid_User.FieldName = "id_User"
        Me.colid_User.Name = "colid_User"
        Me.colid_User.Visible = True
        Me.colid_User.VisibleIndex = 4
        Me.colid_User.Width = 73
        '
        'colAllDay
        '
        Me.colAllDay.FieldName = "AllDay"
        Me.colAllDay.Name = "colAllDay"
        Me.colAllDay.Visible = True
        Me.colAllDay.VisibleIndex = 5
        Me.colAllDay.Width = 73
        '
        'colLocation
        '
        Me.colLocation.FieldName = "Location"
        Me.colLocation.Name = "colLocation"
        Me.colLocation.Visible = True
        Me.colLocation.VisibleIndex = 6
        Me.colLocation.Width = 73
        '
        'colDescription
        '
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 7
        Me.colDescription.Width = 73
        '
        'colStatus
        '
        Me.colStatus.FieldName = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.Visible = True
        Me.colStatus.VisibleIndex = 8
        Me.colStatus.Width = 73
        '
        'colLabel
        '
        Me.colLabel.FieldName = "Label"
        Me.colLabel.Name = "colLabel"
        Me.colLabel.Visible = True
        Me.colLabel.VisibleIndex = 9
        Me.colLabel.Width = 73
        '
        'colResourceIDs
        '
        Me.colResourceIDs.FieldName = "ResourceIDs"
        Me.colResourceIDs.Name = "colResourceIDs"
        Me.colResourceIDs.Visible = True
        Me.colResourceIDs.VisibleIndex = 10
        Me.colResourceIDs.Width = 73
        '
        'colReminderInfo
        '
        Me.colReminderInfo.FieldName = "ReminderInfo"
        Me.colReminderInfo.Name = "colReminderInfo"
        Me.colReminderInfo.Visible = True
        Me.colReminderInfo.VisibleIndex = 11
        Me.colReminderInfo.Width = 73
        '
        'colCustomField1
        '
        Me.colCustomField1.FieldName = "CustomField1"
        Me.colCustomField1.Name = "colCustomField1"
        Me.colCustomField1.Visible = True
        Me.colCustomField1.VisibleIndex = 12
        '
        'AppointmentsGridControl
        '
        Me.AppointmentsGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AppointmentsGridControl.DataSource = Me.AppointmentsBindingSource1
        Me.AppointmentsGridControl.Location = New System.Drawing.Point(23, 47)
        Me.AppointmentsGridControl.MainView = Me.GridView1
        Me.AppointmentsGridControl.Name = "AppointmentsGridControl"
        Me.AppointmentsGridControl.Size = New System.Drawing.Size(1016, 505)
        Me.AppointmentsGridControl.TabIndex = 8
        Me.AppointmentsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'Find_Client
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1040, 564)
        Me.ControlBox = False
        Me.Controls.Add(Me.AppointmentsGridControl)
        Me.Controls.Add(Me.RadioGroup1)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.TextEdit1)
        Me.Controls.Add(Me.LabelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Find_Client"
        Me.Text = "Appoitment Details"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalonsoftDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppointmentsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppointmentsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RadioGroup1 As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents SalonsoftDataSet1 As SalonSoft.salonsoftDataSet1
    Friend WithEvents AppointmentsBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents AppointmentsTableAdapter As SalonSoft.salonsoftDataSet1TableAdapters.appointmentsTableAdapter
    Friend WithEvents TableAdapterManager1 As SalonSoft.salonsoftDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSubject As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStart As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEnd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colResourceID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colid_User As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAllDay As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLocation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLabel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colResourceIDs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReminderInfo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustomField1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AppointmentsGridControl As DevExpress.XtraGrid.GridControl
End Class
