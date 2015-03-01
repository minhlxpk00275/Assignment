<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmloaisp
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
        Me.lbl_gioitinh = New System.Windows.Forms.Label()
        Me.lbl_tenkh = New System.Windows.Forms.Label()
        Me.lbl_idkh = New System.Windows.Forms.Label()
        Me.bntxoa = New System.Windows.Forms.Button()
        Me.bntsua = New System.Windows.Forms.Button()
        Me.bntthem = New System.Windows.Forms.Button()
        Me.txtmota = New System.Windows.Forms.TextBox()
        Me.txttenloaisp = New System.Windows.Forms.TextBox()
        Me.txtidloaisp = New System.Windows.Forms.TextBox()
        Me.lstloaisp = New System.Windows.Forms.ListView()
        Me.idloaisp = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tenloaisp = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mota = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'lbl_gioitinh
        '
        Me.lbl_gioitinh.AutoSize = True
        Me.lbl_gioitinh.Location = New System.Drawing.Point(29, 157)
        Me.lbl_gioitinh.Name = "lbl_gioitinh"
        Me.lbl_gioitinh.Size = New System.Drawing.Size(38, 13)
        Me.lbl_gioitinh.TabIndex = 31
        Me.lbl_gioitinh.Text = "Mô Tả"
        '
        'lbl_tenkh
        '
        Me.lbl_tenkh.AutoSize = True
        Me.lbl_tenkh.Location = New System.Drawing.Point(29, 93)
        Me.lbl_tenkh.Name = "lbl_tenkh"
        Me.lbl_tenkh.Size = New System.Drawing.Size(66, 13)
        Me.lbl_tenkh.TabIndex = 32
        Me.lbl_tenkh.Text = "Tên Loai SP"
        '
        'lbl_idkh
        '
        Me.lbl_idkh.AutoSize = True
        Me.lbl_idkh.Location = New System.Drawing.Point(30, 39)
        Me.lbl_idkh.Name = "lbl_idkh"
        Me.lbl_idkh.Size = New System.Drawing.Size(58, 13)
        Me.lbl_idkh.TabIndex = 34
        Me.lbl_idkh.Text = "ID Loại SP"
        '
        'bntxoa
        '
        Me.bntxoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntxoa.Location = New System.Drawing.Point(262, 225)
        Me.bntxoa.Name = "bntxoa"
        Me.bntxoa.Size = New System.Drawing.Size(75, 39)
        Me.bntxoa.TabIndex = 26
        Me.bntxoa.Text = "Xóa"
        Me.bntxoa.UseVisualStyleBackColor = True
        '
        'bntsua
        '
        Me.bntsua.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntsua.Location = New System.Drawing.Point(156, 225)
        Me.bntsua.Name = "bntsua"
        Me.bntsua.Size = New System.Drawing.Size(75, 39)
        Me.bntsua.TabIndex = 27
        Me.bntsua.Text = "Sửa"
        Me.bntsua.UseVisualStyleBackColor = True
        '
        'bntthem
        '
        Me.bntthem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntthem.Location = New System.Drawing.Point(51, 225)
        Me.bntthem.Name = "bntthem"
        Me.bntthem.Size = New System.Drawing.Size(75, 39)
        Me.bntthem.TabIndex = 28
        Me.bntthem.Text = "Thêm"
        Me.bntthem.UseVisualStyleBackColor = True
        '
        'txtmota
        '
        Me.txtmota.Location = New System.Drawing.Point(131, 150)
        Me.txtmota.Name = "txtmota"
        Me.txtmota.Size = New System.Drawing.Size(100, 20)
        Me.txtmota.TabIndex = 22
        '
        'txttenloaisp
        '
        Me.txttenloaisp.Location = New System.Drawing.Point(131, 90)
        Me.txttenloaisp.Name = "txttenloaisp"
        Me.txttenloaisp.Size = New System.Drawing.Size(100, 20)
        Me.txttenloaisp.TabIndex = 23
        '
        'txtidloaisp
        '
        Me.txtidloaisp.Location = New System.Drawing.Point(131, 36)
        Me.txtidloaisp.Name = "txtidloaisp"
        Me.txtidloaisp.Size = New System.Drawing.Size(100, 20)
        Me.txtidloaisp.TabIndex = 25
        '
        'lstloaisp
        '
        Me.lstloaisp.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.idloaisp, Me.tenloaisp, Me.mota})
        Me.lstloaisp.GridLines = True
        Me.lstloaisp.Location = New System.Drawing.Point(324, 12)
        Me.lstloaisp.Name = "lstloaisp"
        Me.lstloaisp.Size = New System.Drawing.Size(405, 192)
        Me.lstloaisp.TabIndex = 35
        Me.lstloaisp.UseCompatibleStateImageBehavior = False
        Me.lstloaisp.View = System.Windows.Forms.View.Details
        '
        'idloaisp
        '
        Me.idloaisp.Text = "ID Loại SP"
        Me.idloaisp.Width = 111
        '
        'tenloaisp
        '
        Me.tenloaisp.Text = "Tên Loại SP"
        Me.tenloaisp.Width = 122
        '
        'mota
        '
        Me.mota.Text = "Mô Tả"
        '
        'frmloaisp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(795, 420)
        Me.Controls.Add(Me.lstloaisp)
        Me.Controls.Add(Me.lbl_gioitinh)
        Me.Controls.Add(Me.lbl_tenkh)
        Me.Controls.Add(Me.lbl_idkh)
        Me.Controls.Add(Me.bntxoa)
        Me.Controls.Add(Me.bntsua)
        Me.Controls.Add(Me.bntthem)
        Me.Controls.Add(Me.txtmota)
        Me.Controls.Add(Me.txttenloaisp)
        Me.Controls.Add(Me.txtidloaisp)
        Me.Name = "frmloaisp"
        Me.Text = "Loại Sản Phẩm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_gioitinh As System.Windows.Forms.Label
    Friend WithEvents lbl_tenkh As System.Windows.Forms.Label
    Friend WithEvents lbl_idkh As System.Windows.Forms.Label
    Friend WithEvents bntxoa As System.Windows.Forms.Button
    Friend WithEvents bntsua As System.Windows.Forms.Button
    Friend WithEvents bntthem As System.Windows.Forms.Button
    Friend WithEvents txtmota As System.Windows.Forms.TextBox
    Friend WithEvents txttenloaisp As System.Windows.Forms.TextBox
    Friend WithEvents txtidloaisp As System.Windows.Forms.TextBox
    Friend WithEvents lstloaisp As System.Windows.Forms.ListView
    Friend WithEvents idloaisp As System.Windows.Forms.ColumnHeader
    Friend WithEvents tenloaisp As System.Windows.Forms.ColumnHeader
    Friend WithEvents mota As System.Windows.Forms.ColumnHeader
End Class
