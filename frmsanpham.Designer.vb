<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsanpham
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
        Me.lstsp = New System.Windows.Forms.ListView()
        Me.idsp = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tensp = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.hangsp = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.gia = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mota = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.idloaisp = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lbl_sdt = New System.Windows.Forms.Label()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.lbl_gioitinh = New System.Windows.Forms.Label()
        Me.lbl_tenkh = New System.Windows.Forms.Label()
        Me.lbl_diachi = New System.Windows.Forms.Label()
        Me.lbl_idkh = New System.Windows.Forms.Label()
        Me.bntxoa = New System.Windows.Forms.Button()
        Me.bntsua = New System.Windows.Forms.Button()
        Me.bntthem = New System.Windows.Forms.Button()
        Me.txtidloaisp = New System.Windows.Forms.TextBox()
        Me.txtmota = New System.Windows.Forms.TextBox()
        Me.txthangsp = New System.Windows.Forms.TextBox()
        Me.txttensp = New System.Windows.Forms.TextBox()
        Me.txtgia = New System.Windows.Forms.TextBox()
        Me.txtidsp = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lstsp
        '
        Me.lstsp.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.idsp, Me.tensp, Me.hangsp, Me.gia, Me.mota, Me.idloaisp})
        Me.lstsp.FullRowSelect = True
        Me.lstsp.GridLines = True
        Me.lstsp.Location = New System.Drawing.Point(439, 45)
        Me.lstsp.Name = "lstsp"
        Me.lstsp.Size = New System.Drawing.Size(408, 182)
        Me.lstsp.TabIndex = 0
        Me.lstsp.UseCompatibleStateImageBehavior = False
        Me.lstsp.View = System.Windows.Forms.View.Details
        '
        'idsp
        '
        Me.idsp.Text = "ID SP"
        '
        'tensp
        '
        Me.tensp.Text = "Tên SP"
        '
        'hangsp
        '
        Me.hangsp.Text = "Hãng SP"
        '
        'gia
        '
        Me.gia.Text = "Giá"
        '
        'mota
        '
        Me.mota.Text = "Mô Tả"
        '
        'idloaisp
        '
        Me.idloaisp.Text = "ID Loại SP"
        Me.idloaisp.Width = 67
        '
        'lbl_sdt
        '
        Me.lbl_sdt.AutoSize = True
        Me.lbl_sdt.Location = New System.Drawing.Point(211, 136)
        Me.lbl_sdt.Name = "lbl_sdt"
        Me.lbl_sdt.Size = New System.Drawing.Size(58, 13)
        Me.lbl_sdt.TabIndex = 13
        Me.lbl_sdt.Text = "ID Loai SP"
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Location = New System.Drawing.Point(211, 75)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(38, 13)
        Me.lbl_email.TabIndex = 14
        Me.lbl_email.Text = "Mo Ta"
        '
        'lbl_gioitinh
        '
        Me.lbl_gioitinh.AutoSize = True
        Me.lbl_gioitinh.Location = New System.Drawing.Point(27, 136)
        Me.lbl_gioitinh.Name = "lbl_gioitinh"
        Me.lbl_gioitinh.Size = New System.Drawing.Size(50, 13)
        Me.lbl_gioitinh.TabIndex = 15
        Me.lbl_gioitinh.Text = "Hang SP"
        '
        'lbl_tenkh
        '
        Me.lbl_tenkh.AutoSize = True
        Me.lbl_tenkh.Location = New System.Drawing.Point(27, 72)
        Me.lbl_tenkh.Name = "lbl_tenkh"
        Me.lbl_tenkh.Size = New System.Drawing.Size(43, 13)
        Me.lbl_tenkh.TabIndex = 16
        Me.lbl_tenkh.Text = "Tên SP"
        '
        'lbl_diachi
        '
        Me.lbl_diachi.AutoSize = True
        Me.lbl_diachi.Location = New System.Drawing.Point(211, 18)
        Me.lbl_diachi.Name = "lbl_diachi"
        Me.lbl_diachi.Size = New System.Drawing.Size(23, 13)
        Me.lbl_diachi.TabIndex = 17
        Me.lbl_diachi.Text = "Gia"
        '
        'lbl_idkh
        '
        Me.lbl_idkh.AutoSize = True
        Me.lbl_idkh.Location = New System.Drawing.Point(28, 18)
        Me.lbl_idkh.Name = "lbl_idkh"
        Me.lbl_idkh.Size = New System.Drawing.Size(35, 13)
        Me.lbl_idkh.TabIndex = 18
        Me.lbl_idkh.Text = "ID SP"
        '
        'bntxoa
        '
        Me.bntxoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntxoa.Location = New System.Drawing.Point(260, 204)
        Me.bntxoa.Name = "bntxoa"
        Me.bntxoa.Size = New System.Drawing.Size(75, 39)
        Me.bntxoa.TabIndex = 10
        Me.bntxoa.Text = "Xóa"
        Me.bntxoa.UseVisualStyleBackColor = True
        '
        'bntsua
        '
        Me.bntsua.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntsua.Location = New System.Drawing.Point(154, 204)
        Me.bntsua.Name = "bntsua"
        Me.bntsua.Size = New System.Drawing.Size(75, 39)
        Me.bntsua.TabIndex = 11
        Me.bntsua.Text = "Sửa"
        Me.bntsua.UseVisualStyleBackColor = True
        '
        'bntthem
        '
        Me.bntthem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntthem.Location = New System.Drawing.Point(49, 204)
        Me.bntthem.Name = "bntthem"
        Me.bntthem.Size = New System.Drawing.Size(75, 39)
        Me.bntthem.TabIndex = 12
        Me.bntthem.Text = "Thêm"
        Me.bntthem.UseVisualStyleBackColor = True
        '
        'txtidloaisp
        '
        Me.txtidloaisp.Location = New System.Drawing.Point(274, 129)
        Me.txtidloaisp.Name = "txtidloaisp"
        Me.txtidloaisp.Size = New System.Drawing.Size(100, 20)
        Me.txtidloaisp.TabIndex = 4
        '
        'txtmota
        '
        Me.txtmota.Location = New System.Drawing.Point(274, 72)
        Me.txtmota.Name = "txtmota"
        Me.txtmota.Size = New System.Drawing.Size(100, 20)
        Me.txtmota.TabIndex = 5
        '
        'txthangsp
        '
        Me.txthangsp.Location = New System.Drawing.Point(79, 129)
        Me.txthangsp.Name = "txthangsp"
        Me.txthangsp.Size = New System.Drawing.Size(100, 20)
        Me.txthangsp.TabIndex = 6
        '
        'txttensp
        '
        Me.txttensp.Location = New System.Drawing.Point(79, 72)
        Me.txttensp.Name = "txttensp"
        Me.txttensp.Size = New System.Drawing.Size(100, 20)
        Me.txttensp.TabIndex = 7
        '
        'txtgia
        '
        Me.txtgia.Location = New System.Drawing.Point(274, 18)
        Me.txtgia.Name = "txtgia"
        Me.txtgia.Size = New System.Drawing.Size(100, 20)
        Me.txtgia.TabIndex = 8
        '
        'txtidsp
        '
        Me.txtidsp.Location = New System.Drawing.Point(79, 18)
        Me.txtidsp.Name = "txtidsp"
        Me.txtidsp.Size = New System.Drawing.Size(100, 20)
        Me.txtidsp.TabIndex = 9
        '
        'frmsanpham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(859, 261)
        Me.Controls.Add(Me.lbl_sdt)
        Me.Controls.Add(Me.lbl_email)
        Me.Controls.Add(Me.lbl_gioitinh)
        Me.Controls.Add(Me.lbl_tenkh)
        Me.Controls.Add(Me.lbl_diachi)
        Me.Controls.Add(Me.lbl_idkh)
        Me.Controls.Add(Me.bntxoa)
        Me.Controls.Add(Me.bntsua)
        Me.Controls.Add(Me.bntthem)
        Me.Controls.Add(Me.txtidloaisp)
        Me.Controls.Add(Me.txtmota)
        Me.Controls.Add(Me.txthangsp)
        Me.Controls.Add(Me.txttensp)
        Me.Controls.Add(Me.txtgia)
        Me.Controls.Add(Me.txtidsp)
        Me.Controls.Add(Me.lstsp)
        Me.Name = "frmsanpham"
        Me.Text = "Sản Phẩm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstsp As System.Windows.Forms.ListView
    Friend WithEvents idsp As System.Windows.Forms.ColumnHeader
    Friend WithEvents tensp As System.Windows.Forms.ColumnHeader
    Friend WithEvents hangsp As System.Windows.Forms.ColumnHeader
    Friend WithEvents gia As System.Windows.Forms.ColumnHeader
    Friend WithEvents mota As System.Windows.Forms.ColumnHeader
    Friend WithEvents idloaisp As System.Windows.Forms.ColumnHeader
    Friend WithEvents lbl_sdt As System.Windows.Forms.Label
    Friend WithEvents lbl_email As System.Windows.Forms.Label
    Friend WithEvents lbl_gioitinh As System.Windows.Forms.Label
    Friend WithEvents lbl_tenkh As System.Windows.Forms.Label
    Friend WithEvents lbl_diachi As System.Windows.Forms.Label
    Friend WithEvents lbl_idkh As System.Windows.Forms.Label
    Friend WithEvents bntxoa As System.Windows.Forms.Button
    Friend WithEvents bntsua As System.Windows.Forms.Button
    Friend WithEvents bntthem As System.Windows.Forms.Button
    Friend WithEvents txtidloaisp As System.Windows.Forms.TextBox
    Friend WithEvents txtmota As System.Windows.Forms.TextBox
    Friend WithEvents txthangsp As System.Windows.Forms.TextBox
    Friend WithEvents txttensp As System.Windows.Forms.TextBox
    Friend WithEvents txtgia As System.Windows.Forms.TextBox
    Friend WithEvents txtidsp As System.Windows.Forms.TextBox
End Class
