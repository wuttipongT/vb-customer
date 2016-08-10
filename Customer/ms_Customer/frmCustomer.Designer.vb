<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ms_Customer
    Inherits System.Windows.Forms.Form

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
        Me.Label2 = New System.Windows.Forms.Label
        Me.grdCustomer = New System.Windows.Forms.DataGridView
        Me.Col_Index = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CustomerID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CustomerType = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CustomerName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CustomerAddr = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.StartDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EndDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CusotmerStatus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnLinkCreate = New System.Windows.Forms.Button
        Me.btnEdit = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnSearch = New System.Windows.Forms.Button
        Me.searchCustomerId = New System.Windows.Forms.TextBox
        Me.txtNameFind = New System.Windows.Forms.TextBox
        Me.typeFind = New System.Windows.Forms.ComboBox
        Me.cboStatusFind = New System.Windows.Forms.ComboBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        CType(Me.grdCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "รายละเอียด"
        '
        'grdCustomer
        '
        Me.grdCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdCustomer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Col_Index, Me.CustomerID, Me.CustomerType, Me.CustomerName, Me.CustomerAddr, Me.StartDate, Me.EndDate, Me.CusotmerStatus})
        Me.grdCustomer.Location = New System.Drawing.Point(7, 89)
        Me.grdCustomer.Name = "grdCustomer"
        Me.grdCustomer.Size = New System.Drawing.Size(758, 180)
        Me.grdCustomer.TabIndex = 3
        '
        'Col_Index
        '
        Me.Col_Index.HeaderText = "Index"
        Me.Col_Index.Name = "Col_Index"
        Me.Col_Index.Visible = False
        '
        'CustomerID
        '
        Me.CustomerID.HeaderText = "รหัสลูกค้า"
        Me.CustomerID.Name = "CustomerID"
        '
        'CustomerType
        '
        Me.CustomerType.HeaderText = "ประเภทลูกค้า"
        Me.CustomerType.Name = "CustomerType"
        '
        'CustomerName
        '
        Me.CustomerName.HeaderText = "ชื่อลูกค้า"
        Me.CustomerName.Name = "CustomerName"
        '
        'CustomerAddr
        '
        Me.CustomerAddr.HeaderText = "ที่อยู่"
        Me.CustomerAddr.Name = "CustomerAddr"
        '
        'StartDate
        '
        Me.StartDate.HeaderText = "วันเริ่มต้น"
        Me.StartDate.Name = "StartDate"
        '
        'EndDate
        '
        Me.EndDate.HeaderText = "วันหมดอายุ"
        Me.EndDate.Name = "EndDate"
        '
        'CusotmerStatus
        '
        Me.CusotmerStatus.HeaderText = "สถานะ"
        Me.CusotmerStatus.Name = "CusotmerStatus"
        '
        'btnLinkCreate
        '
        Me.btnLinkCreate.Location = New System.Drawing.Point(7, 275)
        Me.btnLinkCreate.Name = "btnLinkCreate"
        Me.btnLinkCreate.Size = New System.Drawing.Size(88, 36)
        Me.btnLinkCreate.TabIndex = 4
        Me.btnLinkCreate.Text = "สร้าง"
        Me.btnLinkCreate.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(97, 275)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(93, 36)
        Me.btnEdit.TabIndex = 5
        Me.btnEdit.Text = "แก้ไข"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(678, 275)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(87, 36)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "ปิด"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(83, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "รหัสลูกค้า"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(349, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "ชื่อ"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(659, 10)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(89, 30)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "ค้นหา"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'searchCustomerId
        '
        Me.searchCustomerId.Location = New System.Drawing.Point(87, 34)
        Me.searchCustomerId.Name = "searchCustomerId"
        Me.searchCustomerId.Size = New System.Drawing.Size(100, 20)
        Me.searchCustomerId.TabIndex = 6
        '
        'txtNameFind
        '
        Me.txtNameFind.Location = New System.Drawing.Point(352, 34)
        Me.txtNameFind.Name = "txtNameFind"
        Me.txtNameFind.Size = New System.Drawing.Size(100, 20)
        Me.txtNameFind.TabIndex = 6
        '
        'typeFind
        '
        Me.typeFind.FormattingEnabled = True
        Me.typeFind.Location = New System.Drawing.Point(207, 34)
        Me.typeFind.Name = "typeFind"
        Me.typeFind.Size = New System.Drawing.Size(121, 21)
        Me.typeFind.TabIndex = 7
        '
        'cboStatusFind
        '
        Me.cboStatusFind.FormattingEnabled = True
        Me.cboStatusFind.Location = New System.Drawing.Point(468, 33)
        Me.cboStatusFind.Name = "cboStatusFind"
        Me.cboStatusFind.Size = New System.Drawing.Size(116, 21)
        Me.cboStatusFind.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(7, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(758, 69)
        Me.Panel1.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboStatusFind)
        Me.GroupBox1.Controls.Add(Me.typeFind)
        Me.GroupBox1.Controls.Add(Me.txtNameFind)
        Me.GroupBox1.Controls.Add(Me.searchCustomerId)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(755, 65)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "เงื่อนไขการค้นหา"
        '
        'ms_Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 316)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnLinkCreate)
        Me.Controls.Add(Me.grdCustomer)
        Me.Controls.Add(Me.Label2)
        Me.Name = "ms_Customer"
        Me.Text = "Customer"
        CType(Me.grdCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grdCustomer As System.Windows.Forms.DataGridView
    Friend WithEvents btnLinkCreate As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Col_Index As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerAddr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StartDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EndDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CusotmerStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents searchCustomerId As System.Windows.Forms.TextBox
    Friend WithEvents txtNameFind As System.Windows.Forms.TextBox
    Friend WithEvents typeFind As System.Windows.Forms.ComboBox
    Friend WithEvents cboStatusFind As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
