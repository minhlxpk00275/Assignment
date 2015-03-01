<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmhoadon
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
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_gioitinh = New System.Windows.Forms.Label()
        Me.lbl_tenkh = New System.Windows.Forms.Label()
        Me.lbl_diachi = New System.Windows.Forms.Label()
        Me.lbl_idkh = New System.Windows.Forms.Label()
        Me.bntxoa = New System.Windows.Forms.Button()
        Me.bntsua = New System.Windows.Forms.Button()
        Me.bntthem = New System.Windows.Forms.Button()
        Me.txtmota = New System.Windows.Forms.TextBox()
        Me.txtngayxuat = New System.Windows.Forms.TextBox()
        Me.txtidkh = New System.Windows.Forms.TextBox()
        Me.txtidsp = New System.Windows.Forms.TextBox()
        Me.txttongtien = New System.Windows.Forms.TextBox()
        Me.txtidhd = New System.Windows.Forms.TextBox()
        Me.lsthd = New System.Windows.Forms.ListView()
        Me.idhd = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.idsp = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.idkh = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ngayxuat = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tongtien = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mota = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Location = New System.Drawing.Point(197, 111)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(38, 13)
        Me.lbl_email.TabIndex = 20
        Me.lbl_email.Text = "Mô Tả"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 217)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Ngày Xuất"
        '
        'lbl_gioitinh
        '
        Me.lbl_gioitinh.AutoSize = True
        Me.lbl_gioitinh.Location = New System.Drawing.Point(13, 172)
        Me.lbl_gioitinh.Name = "lbl_gioitinh"
        Me.lbl_gioitinh.Size = New System.Drawing.Size(36, 13)
        Me.lbl_gioitinh.TabIndex = 18
        Me.lbl_gioitinh.Text = "ID KH"
        '
        'lbl_tenkh
        '
        Me.lbl_tenkh.AutoSize = True
        Me.lbl_tenkh.Location = New System.Drawing.Point(13, 108)
        Me.lbl_tenkh.Name = "lbl_tenkh"
        Me.lbl_tenkh.Size = New System.Drawing.Size(35, 13)
        Me.lbl_tenkh.TabIndex = 17
        Me.lbl_tenkh.Text = "ID SP"
        '
        'lbl_diachi
        '
        Me.lbl_diachi.AutoSize = True
        Me.lbl_diachi.Location = New System.Drawing.Point(197, 54)
        Me.lbl_diachi.Name = "lbl_diachi"
        Me.lbl_diachi.Size = New System.Drawing.Size(56, 13)
        Me.lbl_diachi.TabIndex = 16
        Me.lbl_diachi.Text = "Tổng Tiền"
        '
        'lbl_idkh
        '
        Me.lbl_idkh.AutoSize = True
        Me.lbl_idkh.Location = New System.Drawing.Point(14, 54)
        Me.lbl_idkh.Name = "lbl_idkh"
        Me.lbl_idkh.Size = New System.Drawing.Size(37, 13)
        Me.lbl_idkh.TabIndex = 15
        Me.lbl_idkh.Text = "ID HĐ"
        '
        'bntxoa
        '
        Me.bntxoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntxoa.Location = New System.Drawing.Point(249, 250)
        Me.bntxoa.Name = "bntxoa"
        Me.bntxoa.Size = New System.Drawing.Size(75, 39)
        Me.bntxoa.TabIndex = 14
        Me.bntxoa.Text = "Xóa"
        Me.bntxoa.UseVisualStyleBackColor = True
        '
        'bntsua
        '
        Me.bntsua.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntsua.Location = New System.Drawing.Point(143, 250)
        Me.bntsua.Name = "bntsua"
        Me.bntsua.Size = New System.Drawing.Size(75, 39)
        Me.bntsua.TabIndex = 13
        Me.bntsua.Text = "Sửa"
        Me.bntsua.UseVisualStyleBackColor = True
        '
        'bntthem
        '
        Me.bntthem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntthem.Location = New System.Drawing.Point(38, 250)
        Me.bntthem.Name = "bntthem"
        Me.bntthem.Size = New System.Drawing.Size(75, 39)
        Me.bntthem.TabIndex = 12
        Me.bntthem.Text = "Thêm"
        Me.bntthem.UseVisualStyleBackColor = True
        '
        'txtmota
        '
        Me.txtmota.Location = New System.Drawing.Point(260, 108)
        Me.txtmota.Name = "txtmota"
        Me.txtmota.Size = New System.Drawing.Size(100, 20)
        Me.txtmota.TabIndex = 9
        '
        'txtngayxuat
        '
        Me.txtngayxuat.Location = New System.Drawing.Point(65, 214)
        Me.txtngayxuat.Name = "txtngayxuat"
        Me.txtngayxuat.Size = New System.Drawing.Size(100, 20)
        Me.txtngayxuat.TabIndex = 8
        '
        'txtidkh
        '
        Me.txtidkh.Location = New System.Drawing.Point(65, 165)
        Me.txtidkh.Name = "txtidkh"
        Me.txtidkh.Size = New System.Drawing.Size(100, 20)
        Me.txtidkh.TabIndex = 7
        '
        'txtidsp
        '
        Me.txtidsp.Location = New System.Drawing.Point(65, 108)
        Me.txtidsp.Name = "txtidsp"
        Me.txtidsp.Size = New System.Drawing.Size(100, 20)
        Me.txtidsp.TabIndex = 6
        '
        'txttongtien
        '
        Me.txttongtien.Location = New System.Drawing.Point(260, 54)
        Me.txttongtien.Name = "txttongtien"
        Me.txttongtien.Size = New System.Drawing.Size(100, 20)
        Me.txttongtien.TabIndex = 5
        '
        'txtidhd
        '
        Me.txtidhd.Location = New System.Drawing.Point(65, 54)
        Me.txtidhd.Name = "txtidhd"
        Me.txtidhd.Size = New System.Drawing.Size(100, 20)
        Me.txtidhd.TabIndex = 11
        '
        'lsthd
        '
        Me.lsthd.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.idhd, Me.idsp, Me.idkh, Me.ngayxuat, Me.tongtien, Me.mota})
        Me.lsthd.FullRowSelect = True
        Me.lsthd.GridLines = True
        Me.lsthd.Location = New System.Drawing.Point(407, 50)
        Me.lsthd.Name = "lsthd"
        Me.lsthd.Size = New System.Drawing.Size(469, 253)
        Me.lsthd.TabIndex = 4
        Me.lsthd.UseCompatibleStateImageBehavior = False
        Me.lsthd.View = System.Windows.Forms.View.Details
        '
        'idhd
        '
        Me.idhd.Text = "ID HĐ"
        '
        'idsp
        '
        Me.idsp.Text = "ID SP"
        '
        'idkh
        '
        Me.idkh.Text = "ID KH"
        '
        'ngayxuat
        '
        Me.ngayxuat.Text = "Ngày Xuất"
        Me.ngayxuat.Width = 82
        '
        'tongtien
        '
        Me.tongtien.Text = "Tổng Tiền"
        Me.tongtien.Width = 64
        '
        'mota
        '
        Me.mota.Text = "Mô Tả"
        '
        'frmhoadon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(888, 437)
        Me.Controls.Add(Me.lbl_email)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_gioitinh)
        Me.Controls.Add(Me.lbl_tenkh)
        Me.Controls.Add(Me.lbl_diachi)
        Me.Controls.Add(Me.lbl_idkh)
        Me.Controls.Add(Me.bntxoa)
        Me.Controls.Add(Me.bntsua)
        Me.Controls.Add(Me.bntthem)
        Me.Controls.Add(Me.txtmota)
        Me.Controls.Add(Me.txtngayxuat)
        Me.Controls.Add(Me.txtidkh)
        Me.Controls.Add(Me.txtidsp)
        Me.Controls.Add(Me.txttongtien)
        Me.Controls.Add(Me.txtidhd)
        Me.Controls.Add(Me.lsthd)
        Me.Name = "frmhoadon"
        Me.Text = "Hóa Đơn"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_email As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_gioitinh As System.Windows.Forms.Label
    Friend WithEvents lbl_tenkh As System.Windows.Forms.Label
    Friend WithEvents lbl_diachi As System.Windows.Forms.Label
    Friend WithEvents lbl_idkh As System.Windows.Forms.Label
    Friend WithEvents bntxoa As System.Windows.Forms.Button
    Friend WithEvents bntsua As System.Windows.Forms.Button
    Friend WithEvents bntthem As System.Windows.Forms.Button
    Friend WithEvents txtmota As System.Windows.Forms.TextBox
    Friend WithEvents txtngayxuat As System.Windows.Forms.TextBox
    Friend WithEvents txtidkh As System.Windows.Forms.TextBox
    Friend WithEvents txtidsp As System.Windows.Forms.TextBox
    Friend WithEvents txttongtien As System.Windows.Forms.TextBox
    Friend WithEvents txtidhd As System.Windows.Forms.TextBox
    Friend WithEvents lsthd As System.Windows.Forms.ListView
    Friend WithEvents idhd As System.Windows.Forms.ColumnHeader
    Friend WithEvents idsp As System.Windows.Forms.ColumnHeader
    Friend WithEvents idkh As System.Windows.Forms.ColumnHeader
    Friend WithEvents ngayxuat As System.Windows.Forms.ColumnHeader
    Friend WithEvents tongtien As System.Windows.Forms.ColumnHeader
    Friend WithEvents mota As System.Windows.Forms.ColumnHeader
End Class
