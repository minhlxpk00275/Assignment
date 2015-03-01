<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmkhachhang
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
        Me.lstkh = New System.Windows.Forms.ListView()
        Me.idkh = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tenkh = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.gioitinh = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ngaysinh = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.email = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.diachi = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.sdt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtidkh = New System.Windows.Forms.TextBox()
        Me.txtdiachi = New System.Windows.Forms.TextBox()
        Me.txttenkh = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtgioitinh = New System.Windows.Forms.TextBox()
        Me.txtsdt = New System.Windows.Forms.TextBox()
        Me.bntthem = New System.Windows.Forms.Button()
        Me.bntsua = New System.Windows.Forms.Button()
        Me.bntxoa = New System.Windows.Forms.Button()
        Me.lbl_idkh = New System.Windows.Forms.Label()
        Me.lbl_tenkh = New System.Windows.Forms.Label()
        Me.lbl_gioitinh = New System.Windows.Forms.Label()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.lbl_sdt = New System.Windows.Forms.Label()
        Me.lbl_diachi = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtngaysinh = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lstkh
        '
        Me.lstkh.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.idkh, Me.tenkh, Me.gioitinh, Me.ngaysinh, Me.email, Me.diachi, Me.sdt})
        Me.lstkh.FullRowSelect = True
        Me.lstkh.GridLines = True
        Me.lstkh.Location = New System.Drawing.Point(406, 38)
        Me.lstkh.Name = "lstkh"
        Me.lstkh.Size = New System.Drawing.Size(469, 253)
        Me.lstkh.TabIndex = 0
        Me.lstkh.UseCompatibleStateImageBehavior = False
        Me.lstkh.View = System.Windows.Forms.View.Details
        '
        'idkh
        '
        Me.idkh.Text = "ID KH"
        '
        'tenkh
        '
        Me.tenkh.Text = "Tên KH"
        '
        'gioitinh
        '
        Me.gioitinh.Text = "Giới Tinh"
        '
        'ngaysinh
        '
        Me.ngaysinh.Text = "Ngay Sinh"
        Me.ngaysinh.Width = 82
        '
        'email
        '
        Me.email.Text = "Email"
        Me.email.Width = 64
        '
        'diachi
        '
        Me.diachi.DisplayIndex = 6
        Me.diachi.Text = "Dia Chi"
        '
        'sdt
        '
        Me.sdt.DisplayIndex = 5
        Me.sdt.Text = "SDT"
        Me.sdt.Width = 62
        '
        'txtidkh
        '
        Me.txtidkh.Location = New System.Drawing.Point(64, 42)
        Me.txtidkh.Name = "txtidkh"
        Me.txtidkh.Size = New System.Drawing.Size(100, 20)
        Me.txtidkh.TabIndex = 1
        '
        'txtdiachi
        '
        Me.txtdiachi.Location = New System.Drawing.Point(259, 42)
        Me.txtdiachi.Name = "txtdiachi"
        Me.txtdiachi.Size = New System.Drawing.Size(100, 20)
        Me.txtdiachi.TabIndex = 1
        '
        'txttenkh
        '
        Me.txttenkh.Location = New System.Drawing.Point(64, 99)
        Me.txttenkh.Name = "txttenkh"
        Me.txttenkh.Size = New System.Drawing.Size(100, 20)
        Me.txttenkh.TabIndex = 1
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(259, 96)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(100, 20)
        Me.txtemail.TabIndex = 1
        '
        'txtgioitinh
        '
        Me.txtgioitinh.Location = New System.Drawing.Point(64, 153)
        Me.txtgioitinh.Name = "txtgioitinh"
        Me.txtgioitinh.Size = New System.Drawing.Size(100, 20)
        Me.txtgioitinh.TabIndex = 1
        '
        'txtsdt
        '
        Me.txtsdt.Location = New System.Drawing.Point(259, 153)
        Me.txtsdt.Name = "txtsdt"
        Me.txtsdt.Size = New System.Drawing.Size(100, 20)
        Me.txtsdt.TabIndex = 1
        '
        'bntthem
        '
        Me.bntthem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntthem.Location = New System.Drawing.Point(37, 238)
        Me.bntthem.Name = "bntthem"
        Me.bntthem.Size = New System.Drawing.Size(75, 39)
        Me.bntthem.TabIndex = 2
        Me.bntthem.Text = "Thêm"
        Me.bntthem.UseVisualStyleBackColor = True
        '
        'bntsua
        '
        Me.bntsua.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntsua.Location = New System.Drawing.Point(142, 238)
        Me.bntsua.Name = "bntsua"
        Me.bntsua.Size = New System.Drawing.Size(75, 39)
        Me.bntsua.TabIndex = 2
        Me.bntsua.Text = "Sửa"
        Me.bntsua.UseVisualStyleBackColor = True
        '
        'bntxoa
        '
        Me.bntxoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntxoa.Location = New System.Drawing.Point(248, 238)
        Me.bntxoa.Name = "bntxoa"
        Me.bntxoa.Size = New System.Drawing.Size(75, 39)
        Me.bntxoa.TabIndex = 2
        Me.bntxoa.Text = "Xóa"
        Me.bntxoa.UseVisualStyleBackColor = True
        '
        'lbl_idkh
        '
        Me.lbl_idkh.AutoSize = True
        Me.lbl_idkh.Location = New System.Drawing.Point(13, 42)
        Me.lbl_idkh.Name = "lbl_idkh"
        Me.lbl_idkh.Size = New System.Drawing.Size(36, 13)
        Me.lbl_idkh.TabIndex = 3
        Me.lbl_idkh.Text = "ID KH"
        '
        'lbl_tenkh
        '
        Me.lbl_tenkh.AutoSize = True
        Me.lbl_tenkh.Location = New System.Drawing.Point(12, 96)
        Me.lbl_tenkh.Name = "lbl_tenkh"
        Me.lbl_tenkh.Size = New System.Drawing.Size(44, 13)
        Me.lbl_tenkh.TabIndex = 3
        Me.lbl_tenkh.Text = "Tên KH"
        '
        'lbl_gioitinh
        '
        Me.lbl_gioitinh.AutoSize = True
        Me.lbl_gioitinh.Location = New System.Drawing.Point(12, 160)
        Me.lbl_gioitinh.Name = "lbl_gioitinh"
        Me.lbl_gioitinh.Size = New System.Drawing.Size(51, 13)
        Me.lbl_gioitinh.TabIndex = 3
        Me.lbl_gioitinh.Text = "Giới Tính"
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Location = New System.Drawing.Point(196, 99)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(32, 13)
        Me.lbl_email.TabIndex = 3
        Me.lbl_email.Text = "Email"
        '
        'lbl_sdt
        '
        Me.lbl_sdt.AutoSize = True
        Me.lbl_sdt.Location = New System.Drawing.Point(196, 160)
        Me.lbl_sdt.Name = "lbl_sdt"
        Me.lbl_sdt.Size = New System.Drawing.Size(29, 13)
        Me.lbl_sdt.TabIndex = 3
        Me.lbl_sdt.Text = "SDT"
        '
        'lbl_diachi
        '
        Me.lbl_diachi.AutoSize = True
        Me.lbl_diachi.Location = New System.Drawing.Point(196, 42)
        Me.lbl_diachi.Name = "lbl_diachi"
        Me.lbl_diachi.Size = New System.Drawing.Size(41, 13)
        Me.lbl_diachi.TabIndex = 3
        Me.lbl_diachi.Text = "Địa Chỉ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 205)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Ngay Sinh"
        '
        'txtngaysinh
        '
        Me.txtngaysinh.Location = New System.Drawing.Point(64, 205)
        Me.txtngaysinh.Name = "txtngaysinh"
        Me.txtngaysinh.Size = New System.Drawing.Size(100, 20)
        Me.txtngaysinh.TabIndex = 4
        '
        'frmkhachhang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(884, 322)
        Me.Controls.Add(Me.txtngaysinh)
        Me.Controls.Add(Me.lbl_sdt)
        Me.Controls.Add(Me.lbl_email)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_gioitinh)
        Me.Controls.Add(Me.lbl_tenkh)
        Me.Controls.Add(Me.lbl_diachi)
        Me.Controls.Add(Me.lbl_idkh)
        Me.Controls.Add(Me.bntxoa)
        Me.Controls.Add(Me.bntsua)
        Me.Controls.Add(Me.bntthem)
        Me.Controls.Add(Me.txtsdt)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.txtgioitinh)
        Me.Controls.Add(Me.txttenkh)
        Me.Controls.Add(Me.txtdiachi)
        Me.Controls.Add(Me.txtidkh)
        Me.Controls.Add(Me.lstkh)
        Me.Name = "frmkhachhang"
        Me.Text = "Khách hàng"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstkh As System.Windows.Forms.ListView
    Friend WithEvents idkh As System.Windows.Forms.ColumnHeader
    Friend WithEvents tenkh As System.Windows.Forms.ColumnHeader
    Friend WithEvents gioitinh As System.Windows.Forms.ColumnHeader
    Friend WithEvents email As System.Windows.Forms.ColumnHeader
    Friend WithEvents ngaysinh As System.Windows.Forms.ColumnHeader
    Friend WithEvents sdt As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtidkh As System.Windows.Forms.TextBox
    Friend WithEvents txtdiachi As System.Windows.Forms.TextBox
    Friend WithEvents txttenkh As System.Windows.Forms.TextBox
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents txtgioitinh As System.Windows.Forms.TextBox
    Friend WithEvents txtsdt As System.Windows.Forms.TextBox
    Friend WithEvents bntthem As System.Windows.Forms.Button
    Friend WithEvents bntsua As System.Windows.Forms.Button
    Friend WithEvents bntxoa As System.Windows.Forms.Button
    Friend WithEvents lbl_idkh As System.Windows.Forms.Label
    Friend WithEvents lbl_tenkh As System.Windows.Forms.Label
    Friend WithEvents lbl_gioitinh As System.Windows.Forms.Label
    Friend WithEvents lbl_email As System.Windows.Forms.Label
    Friend WithEvents lbl_sdt As System.Windows.Forms.Label
    Friend WithEvents lbl_diachi As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents diachi As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtngaysinh As System.Windows.Forms.TextBox
End Class
