<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form12
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IDLabel As System.Windows.Forms.Label
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim Total_itemLabel As System.Windows.Forms.Label
        Dim Total_priceLabel As System.Windows.Forms.Label
        Dim Pay_statusLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form12))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LoginInfoDataSet = New GroupProj.LoginInfoDataSet()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerTableAdapter = New GroupProj.LoginInfoDataSetTableAdapters.customerTableAdapter()
        Me.TableAdapterManager = New GroupProj.LoginInfoDataSetTableAdapters.TableAdapterManager()
        Me.CustomerBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.CustomerBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CustomerDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnUpD = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Pay_statusComboBox = New System.Windows.Forms.ComboBox()
        Me.Total_priceLabel1 = New System.Windows.Forms.Label()
        Me.Total_itemLabel1 = New System.Windows.Forms.Label()
        Me.UsernameLabel1 = New System.Windows.Forms.Label()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.btnSea = New System.Windows.Forms.Button()
        IDLabel = New System.Windows.Forms.Label()
        UsernameLabel = New System.Windows.Forms.Label()
        Total_itemLabel = New System.Windows.Forms.Label()
        Total_priceLabel = New System.Windows.Forms.Label()
        Pay_statusLabel = New System.Windows.Forms.Label()
        CType(Me.LoginInfoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustomerBindingNavigator.SuspendLayout()
        CType(Me.CustomerDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(19, 44)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(27, 19)
        IDLabel.TabIndex = 0
        IDLabel.Text = "ID:"
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Location = New System.Drawing.Point(19, 93)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(78, 19)
        UsernameLabel.TabIndex = 2
        UsernameLabel.Text = "username:"
        '
        'Total_itemLabel
        '
        Total_itemLabel.AutoSize = True
        Total_itemLabel.Location = New System.Drawing.Point(19, 135)
        Total_itemLabel.Name = "Total_itemLabel"
        Total_itemLabel.Size = New System.Drawing.Size(78, 19)
        Total_itemLabel.TabIndex = 4
        Total_itemLabel.Text = "total item:"
        '
        'Total_priceLabel
        '
        Total_priceLabel.AutoSize = True
        Total_priceLabel.Location = New System.Drawing.Point(19, 177)
        Total_priceLabel.Name = "Total_priceLabel"
        Total_priceLabel.Size = New System.Drawing.Size(82, 19)
        Total_priceLabel.TabIndex = 6
        Total_priceLabel.Text = "total price:"
        '
        'Pay_statusLabel
        '
        Pay_statusLabel.AutoSize = True
        Pay_statusLabel.Location = New System.Drawing.Point(22, 219)
        Pay_statusLabel.Name = "Pay_statusLabel"
        Pay_statusLabel.Size = New System.Drawing.Size(79, 19)
        Pay_statusLabel.TabIndex = 8
        Pay_statusLabel.Text = "pay status:"
        '
        'LoginInfoDataSet
        '
        Me.LoginInfoDataSet.DataSetName = "LoginInfoDataSet"
        Me.LoginInfoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "customer"
        Me.CustomerBindingSource.DataSource = Me.LoginInfoDataSet
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.customerTableAdapter = Me.CustomerTableAdapter
        Me.TableAdapterManager.itemsaleTableAdapter = Nothing
        Me.TableAdapterManager.loginInfoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = GroupProj.LoginInfoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CustomerBindingNavigator
        '
        Me.CustomerBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CustomerBindingNavigator.BindingSource = Me.CustomerBindingSource
        Me.CustomerBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CustomerBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CustomerBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CustomerBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CustomerBindingNavigatorSaveItem})
        Me.CustomerBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CustomerBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CustomerBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CustomerBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CustomerBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CustomerBindingNavigator.Name = "CustomerBindingNavigator"
        Me.CustomerBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CustomerBindingNavigator.Size = New System.Drawing.Size(1262, 31)
        Me.CustomerBindingNavigator.TabIndex = 0
        Me.CustomerBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 28)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'CustomerBindingNavigatorSaveItem
        '
        Me.CustomerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CustomerBindingNavigatorSaveItem.Image = CType(resources.GetObject("CustomerBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CustomerBindingNavigatorSaveItem.Name = "CustomerBindingNavigatorSaveItem"
        Me.CustomerBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 28)
        Me.CustomerBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CustomerDataGridView
        '
        Me.CustomerDataGridView.AutoGenerateColumns = False
        Me.CustomerDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CustomerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomerDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.CustomerDataGridView.DataSource = Me.CustomerBindingSource
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CustomerDataGridView.DefaultCellStyle = DataGridViewCellStyle1
        Me.CustomerDataGridView.GridColor = System.Drawing.Color.Black
        Me.CustomerDataGridView.Location = New System.Drawing.Point(286, 119)
        Me.CustomerDataGridView.Name = "CustomerDataGridView"
        Me.CustomerDataGridView.RowHeadersWidth = 51
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CustomerDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.CustomerDataGridView.RowTemplate.Height = 24
        Me.CustomerDataGridView.Size = New System.Drawing.Size(964, 483)
        Me.CustomerDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "username"
        Me.DataGridViewTextBoxColumn2.HeaderText = "username"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "total_item"
        Me.DataGridViewTextBoxColumn3.HeaderText = "total_item"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "total_price"
        Me.DataGridViewTextBoxColumn4.HeaderText = "total_price"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "pay_status"
        Me.DataGridViewTextBoxColumn5.HeaderText = "pay_status"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnHome)
        Me.GroupBox1.Controls.Add(Me.btnUpD)
        Me.GroupBox1.Controls.Add(Me.btnDel)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Pay_statusLabel)
        Me.GroupBox1.Controls.Add(Me.Pay_statusComboBox)
        Me.GroupBox1.Controls.Add(Total_priceLabel)
        Me.GroupBox1.Controls.Add(Me.Total_priceLabel1)
        Me.GroupBox1.Controls.Add(Total_itemLabel)
        Me.GroupBox1.Controls.Add(Me.Total_itemLabel1)
        Me.GroupBox1.Controls.Add(UsernameLabel)
        Me.GroupBox1.Controls.Add(Me.UsernameLabel1)
        Me.GroupBox1.Controls.Add(IDLabel)
        Me.GroupBox1.Controls.Add(Me.IDTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 119)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(259, 483)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DecepTech"
        '
        'btnHome
        '
        Me.btnHome.ForeColor = System.Drawing.Color.Black
        Me.btnHome.Location = New System.Drawing.Point(123, 398)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(100, 30)
        Me.btnHome.TabIndex = 15
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'btnUpD
        '
        Me.btnUpD.ForeColor = System.Drawing.Color.Black
        Me.btnUpD.Location = New System.Drawing.Point(17, 362)
        Me.btnUpD.Name = "btnUpD"
        Me.btnUpD.Size = New System.Drawing.Size(100, 30)
        Me.btnUpD.TabIndex = 14
        Me.btnUpD.Text = "Update"
        Me.btnUpD.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.ForeColor = System.Drawing.Color.Black
        Me.btnDel.Location = New System.Drawing.Point(17, 398)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(100, 30)
        Me.btnDel.TabIndex = 13
        Me.btnDel.Text = "Delete"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(123, 362)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 30)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Pay_statusComboBox
        '
        Me.Pay_statusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "pay_status", True))
        Me.Pay_statusComboBox.FormattingEnabled = True
        Me.Pay_statusComboBox.Items.AddRange(New Object() {"Pending", "Cancelled", "Completed"})
        Me.Pay_statusComboBox.Location = New System.Drawing.Point(23, 241)
        Me.Pay_statusComboBox.Name = "Pay_statusComboBox"
        Me.Pay_statusComboBox.Size = New System.Drawing.Size(171, 27)
        Me.Pay_statusComboBox.TabIndex = 9
        '
        'Total_priceLabel1
        '
        Me.Total_priceLabel1.BackColor = System.Drawing.Color.White
        Me.Total_priceLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Total_priceLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "total_price", True))
        Me.Total_priceLabel1.ForeColor = System.Drawing.Color.Black
        Me.Total_priceLabel1.Location = New System.Drawing.Point(23, 196)
        Me.Total_priceLabel1.Name = "Total_priceLabel1"
        Me.Total_priceLabel1.Size = New System.Drawing.Size(171, 23)
        Me.Total_priceLabel1.TabIndex = 7
        Me.Total_priceLabel1.Text = "Label1"
        '
        'Total_itemLabel1
        '
        Me.Total_itemLabel1.BackColor = System.Drawing.Color.White
        Me.Total_itemLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Total_itemLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "total_item", True))
        Me.Total_itemLabel1.ForeColor = System.Drawing.Color.Black
        Me.Total_itemLabel1.Location = New System.Drawing.Point(23, 154)
        Me.Total_itemLabel1.Name = "Total_itemLabel1"
        Me.Total_itemLabel1.Size = New System.Drawing.Size(171, 23)
        Me.Total_itemLabel1.TabIndex = 5
        Me.Total_itemLabel1.Text = "Label1"
        '
        'UsernameLabel1
        '
        Me.UsernameLabel1.BackColor = System.Drawing.Color.White
        Me.UsernameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.UsernameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "username", True))
        Me.UsernameLabel1.ForeColor = System.Drawing.Color.Black
        Me.UsernameLabel1.Location = New System.Drawing.Point(23, 112)
        Me.UsernameLabel1.Name = "UsernameLabel1"
        Me.UsernameLabel1.Size = New System.Drawing.Size(171, 23)
        Me.UsernameLabel1.TabIndex = 3
        Me.UsernameLabel1.Text = "Label1"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(23, 66)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(171, 24)
        Me.IDTextBox.TabIndex = 1
        '
        'btnSea
        '
        Me.btnSea.BackColor = System.Drawing.Color.Red
        Me.btnSea.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSea.ForeColor = System.Drawing.Color.White
        Me.btnSea.Location = New System.Drawing.Point(1221, 39)
        Me.btnSea.Name = "btnSea"
        Me.btnSea.Size = New System.Drawing.Size(29, 30)
        Me.btnSea.TabIndex = 10
        Me.btnSea.Text = "X"
        Me.btnSea.UseVisualStyleBackColor = False
        '
        'Form12
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1262, 673)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CustomerDataGridView)
        Me.Controls.Add(Me.CustomerBindingNavigator)
        Me.Controls.Add(Me.btnSea)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form12"
        Me.Text = "DecepTech Admin"
        CType(Me.LoginInfoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustomerBindingNavigator.ResumeLayout(False)
        Me.CustomerBindingNavigator.PerformLayout()
        CType(Me.CustomerDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LoginInfoDataSet As LoginInfoDataSet
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerTableAdapter As LoginInfoDataSetTableAdapters.customerTableAdapter
    Friend WithEvents TableAdapterManager As LoginInfoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CustomerBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents CustomerBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CustomerDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Pay_statusComboBox As ComboBox
    Friend WithEvents Total_priceLabel1 As Label
    Friend WithEvents Total_itemLabel1 As Label
    Friend WithEvents UsernameLabel1 As Label
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents btnUpD As Button
    Friend WithEvents btnDel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnSea As Button
    Friend WithEvents btnHome As Button
End Class
