<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRemind
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim CustomerIDLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRemind))
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.lblEstimates = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.picClock = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboMonthSelection = New System.Windows.Forms.ComboBox()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.radYear = New System.Windows.Forms.RadioButton()
        Me.radSixMonths = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CustomersBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReminderDataDataSet = New Remind_the_Clients.ReminderDataDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.picSearch = New System.Windows.Forms.PictureBox()
        Me.CustomerIDComboBox = New System.Windows.Forms.ComboBox()
        Me.CustomersTableAdapter = New Remind_the_Clients.ReminderDataDataSetTableAdapters.CustomersTableAdapter()
        Me.TableAdapterManager = New Remind_the_Clients.ReminderDataDataSetTableAdapters.TableAdapterManager()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.YearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CurrentYearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.stripTxtBoxCurrentYear = New System.Windows.Forms.ToolStripTextBox()
        Me.NextYearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.striptxtBoxNextYear = New System.Windows.Forms.ToolStripTextBox()
        Me.FormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblError = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        CustomerIDLabel1 = New System.Windows.Forms.Label()
        CType(Me.picClock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustomersBindingNavigator.SuspendLayout()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReminderDataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.picSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Location = New System.Drawing.Point(15, 78)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(60, 13)
        First_NameLabel.TabIndex = 17
        First_NameLabel.Text = "First Name:"
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Location = New System.Drawing.Point(14, 104)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(61, 13)
        Last_NameLabel.TabIndex = 18
        Last_NameLabel.Text = "Last Name:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(40, 141)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 20
        EmailLabel.Text = "Email:"
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Location = New System.Drawing.Point(34, 167)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(41, 13)
        PhoneLabel.TabIndex = 22
        PhoneLabel.Text = "Phone:"
        '
        'CustomerIDLabel1
        '
        CustomerIDLabel1.AutoSize = True
        CustomerIDLabel1.Location = New System.Drawing.Point(78, 14)
        CustomerIDLabel1.Name = "CustomerIDLabel1"
        CustomerIDLabel1.Size = New System.Drawing.Size(68, 13)
        CustomerIDLabel1.TabIndex = 0
        CustomerIDLabel1.Text = "Customer ID:"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(37, 310)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 47)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lblLogin
        '
        Me.lblLogin.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lblLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLogin.Location = New System.Drawing.Point(118, 29)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(55, 23)
        Me.lblLogin.TabIndex = 1
        Me.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEstimates
        '
        Me.lblEstimates.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lblEstimates.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEstimates.Location = New System.Drawing.Point(28, 29)
        Me.lblEstimates.Name = "lblEstimates"
        Me.lblEstimates.Size = New System.Drawing.Size(52, 23)
        Me.lblEstimates.TabIndex = 2
        Me.lblEstimates.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(111, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Logged in as:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkRed
        Me.Label2.Location = New System.Drawing.Point(7, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Estimates Due:"
        '
        'picClock
        '
        Me.picClock.Image = Global.Remind_the_Clients.My.Resources.Resources._800px_COLOURBOX18896228
        Me.picClock.Location = New System.Drawing.Point(22, 43)
        Me.picClock.Name = "picClock"
        Me.picClock.Size = New System.Drawing.Size(139, 124)
        Me.picClock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picClock.TabIndex = 5
        Me.picClock.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Current Month:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(27, 251)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Remind Month:"
        '
        'cboMonthSelection
        '
        Me.cboMonthSelection.FormattingEnabled = True
        Me.cboMonthSelection.Location = New System.Drawing.Point(22, 201)
        Me.cboMonthSelection.Name = "cboMonthSelection"
        Me.cboMonthSelection.Size = New System.Drawing.Size(139, 21)
        Me.cboMonthSelection.TabIndex = 11
        '
        'lblDisplay
        '
        Me.lblDisplay.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplay.Location = New System.Drawing.Point(22, 267)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(139, 26)
        Me.lblDisplay.TabIndex = 12
        Me.lblDisplay.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'radYear
        '
        Me.radYear.AutoSize = True
        Me.radYear.Location = New System.Drawing.Point(242, 74)
        Me.radYear.Name = "radYear"
        Me.radYear.Size = New System.Drawing.Size(87, 17)
        Me.radYear.TabIndex = 15
        Me.radYear.TabStop = True
        Me.radYear.Text = "12 MONTHS"
        Me.radYear.UseVisualStyleBackColor = True
        '
        'radSixMonths
        '
        Me.radSixMonths.AutoSize = True
        Me.radSixMonths.Location = New System.Drawing.Point(243, 51)
        Me.radSixMonths.Name = "radSixMonths"
        Me.radSixMonths.Size = New System.Drawing.Size(81, 17)
        Me.radSixMonths.TabIndex = 14
        Me.radSixMonths.TabStop = True
        Me.radSixMonths.Text = "6 MONTHS"
        Me.radSixMonths.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(249, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Remind In:"
        '
        'CustomersBindingNavigator
        '
        Me.CustomersBindingNavigator.AddNewItem = Nothing
        Me.CustomersBindingNavigator.BindingSource = Me.CustomersBindingSource
        Me.CustomersBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CustomersBindingNavigator.DeleteItem = Nothing
        Me.CustomersBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CustomersBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.CustomersBindingNavigator.Location = New System.Drawing.Point(0, 413)
        Me.CustomersBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CustomersBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CustomersBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CustomersBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CustomersBindingNavigator.Name = "CustomersBindingNavigator"
        Me.CustomersBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CustomersBindingNavigator.Size = New System.Drawing.Size(576, 25)
        Me.CustomersBindingNavigator.TabIndex = 16
        Me.CustomersBindingNavigator.Text = "BindingNavigator1"
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "Customers"
        Me.CustomersBindingSource.DataSource = Me.ReminderDataDataSet
        '
        'ReminderDataDataSet
        '
        Me.ReminderDataDataSet.DataSetName = "ReminderDataDataSet"
        Me.ReminderDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'First_NameTextBox
        '
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "First Name", True))
        Me.First_NameTextBox.Enabled = False
        Me.First_NameTextBox.Location = New System.Drawing.Point(81, 75)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.First_NameTextBox.TabIndex = 18
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Last Name", True))
        Me.Last_NameTextBox.Enabled = False
        Me.Last_NameTextBox.Location = New System.Drawing.Point(81, 101)
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Last_NameTextBox.TabIndex = 19
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Email", True))
        Me.EmailTextBox.Enabled = False
        Me.EmailTextBox.Location = New System.Drawing.Point(81, 138)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EmailTextBox.TabIndex = 21
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Phone", True))
        Me.PhoneTextBox.Enabled = False
        Me.PhoneTextBox.Location = New System.Drawing.Point(81, 164)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PhoneTextBox.TabIndex = 23
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.picSearch)
        Me.Panel1.Controls.Add(Last_NameLabel)
        Me.Panel1.Controls.Add(EmailLabel)
        Me.Panel1.Controls.Add(Me.Last_NameTextBox)
        Me.Panel1.Controls.Add(First_NameLabel)
        Me.Panel1.Controls.Add(PhoneLabel)
        Me.Panel1.Controls.Add(Me.First_NameTextBox)
        Me.Panel1.Controls.Add(Me.EmailTextBox)
        Me.Panel1.Controls.Add(CustomerIDLabel1)
        Me.Panel1.Controls.Add(Me.PhoneTextBox)
        Me.Panel1.Controls.Add(Me.CustomerIDComboBox)
        Me.Panel1.Location = New System.Drawing.Point(225, 129)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(220, 228)
        Me.Panel1.TabIndex = 24
        '
        'picSearch
        '
        Me.picSearch.Image = Global.Remind_the_Clients.My.Resources.Resources.search_icon
        Me.picSearch.Location = New System.Drawing.Point(149, 19)
        Me.picSearch.Name = "picSearch"
        Me.picSearch.Size = New System.Drawing.Size(32, 35)
        Me.picSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSearch.TabIndex = 24
        Me.picSearch.TabStop = False
        '
        'CustomerIDComboBox
        '
        Me.CustomerIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "CustomerID", True))
        Me.CustomerIDComboBox.DataSource = Me.CustomersBindingSource
        Me.CustomerIDComboBox.DisplayMember = "CustomerID"
        Me.CustomerIDComboBox.FormattingEnabled = True
        Me.CustomerIDComboBox.Location = New System.Drawing.Point(89, 33)
        Me.CustomerIDComboBox.Name = "CustomerIDComboBox"
        Me.CustomerIDComboBox.Size = New System.Drawing.Size(49, 21)
        Me.CustomerIDComboBox.TabIndex = 1
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomersTableAdapter = Me.CustomersTableAdapter
        Me.TableAdapterManager.UpdateOrder = Remind_the_Clients.ReminderDataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.lblStatus)
        Me.Panel2.Controls.Add(Me.lblEstimates)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.lblLogin)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(365, 16)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(199, 90)
        Me.Panel2.TabIndex = 25
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.YearToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(576, 24)
        Me.MenuStrip1.TabIndex = 26
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'YearToolStripMenuItem
        '
        Me.YearToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TextToolStripMenuItem, Me.FormToolStripMenuItem})
        Me.YearToolStripMenuItem.Name = "YearToolStripMenuItem"
        Me.YearToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.YearToolStripMenuItem.Text = "Menu"
        '
        'TextToolStripMenuItem
        '
        Me.TextToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CurrentYearToolStripMenuItem, Me.NextYearToolStripMenuItem})
        Me.TextToolStripMenuItem.Name = "TextToolStripMenuItem"
        Me.TextToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TextToolStripMenuItem.Text = "Update"
        '
        'CurrentYearToolStripMenuItem
        '
        Me.CurrentYearToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stripTxtBoxCurrentYear})
        Me.CurrentYearToolStripMenuItem.Name = "CurrentYearToolStripMenuItem"
        Me.CurrentYearToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CurrentYearToolStripMenuItem.Text = "Current Year:"
        '
        'stripTxtBoxCurrentYear
        '
        Me.stripTxtBoxCurrentYear.Name = "stripTxtBoxCurrentYear"
        Me.stripTxtBoxCurrentYear.Size = New System.Drawing.Size(100, 23)
        Me.stripTxtBoxCurrentYear.Text = "2018"
        '
        'NextYearToolStripMenuItem
        '
        Me.NextYearToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.striptxtBoxNextYear})
        Me.NextYearToolStripMenuItem.Name = "NextYearToolStripMenuItem"
        Me.NextYearToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NextYearToolStripMenuItem.Text = "Next Year:"
        '
        'striptxtBoxNextYear
        '
        Me.striptxtBoxNextYear.Name = "striptxtBoxNextYear"
        Me.striptxtBoxNextYear.Size = New System.Drawing.Size(100, 23)
        Me.striptxtBoxNextYear.Text = "2019"
        '
        'FormToolStripMenuItem
        '
        Me.FormToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomersToolStripMenuItem})
        Me.FormToolStripMenuItem.Name = "FormToolStripMenuItem"
        Me.FormToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.FormToolStripMenuItem.Text = "Open"
        '
        'CustomersToolStripMenuItem
        '
        Me.CustomersToolStripMenuItem.Name = "CustomersToolStripMenuItem"
        Me.CustomersToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CustomersToolStripMenuItem.Text = "Customers"
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStatus.Location = New System.Drawing.Point(73, 59)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(100, 23)
        Me.lblStatus.TabIndex = 27
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkRed
        Me.Label6.Location = New System.Drawing.Point(20, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Status:"
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.BackColor = System.Drawing.SystemColors.Desktop
        Me.lblError.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(483, 391)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(80, 22)
        Me.lblError.TabIndex = 27
        Me.lblError.Text = "ERROR."
        '
        'frmRemind
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 438)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.CustomersBindingNavigator)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.radYear)
        Me.Controls.Add(Me.radSixMonths)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.cboMonthSelection)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.picClock)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmRemind"
        Me.Text = " Reminder Application"
        CType(Me.picClock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustomersBindingNavigator.ResumeLayout(False)
        Me.CustomersBindingNavigator.PerformLayout()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReminderDataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSave As Button
    Friend WithEvents lblLogin As Label
    Friend WithEvents lblEstimates As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents picClock As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cboMonthSelection As ComboBox
    Friend WithEvents lblDisplay As Label
    Friend WithEvents radYear As RadioButton
    Friend WithEvents radSixMonths As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents ReminderDataDataSet As ReminderDataDataSet
    Friend WithEvents CustomersBindingSource As BindingSource
    Friend WithEvents CustomersTableAdapter As ReminderDataDataSetTableAdapters.CustomersTableAdapter
    Friend WithEvents TableAdapterManager As ReminderDataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CustomersBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents First_NameTextBox As TextBox
    Friend WithEvents Last_NameTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CustomerIDComboBox As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents YearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CurrentYearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents stripTxtBoxCurrentYear As ToolStripTextBox
    Friend WithEvents NextYearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents striptxtBoxNextYear As ToolStripTextBox
    Friend WithEvents picSearch As PictureBox
    Friend WithEvents FormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label6 As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblError As Label
End Class
