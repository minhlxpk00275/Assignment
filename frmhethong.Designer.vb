<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_hethong
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.QuanLyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DangNhapToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThoatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KhachHangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SanPhamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoaiSanPhamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThanhToanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HoaDonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChiTietHoaDonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuanLyToolStripMenuItem, Me.KhachHangToolStripMenuItem, Me.SanPhamToolStripMenuItem, Me.LoaiSanPhamToolStripMenuItem, Me.ThanhToanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(649, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'QuanLyToolStripMenuItem
        '
        Me.QuanLyToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DangNhapToolStripMenuItem, Me.ThoatToolStripMenuItem})
        Me.QuanLyToolStripMenuItem.Name = "QuanLyToolStripMenuItem"
        Me.QuanLyToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.QuanLyToolStripMenuItem.Text = "Quản Lý"
        '
        'DangNhapToolStripMenuItem
        '
        Me.DangNhapToolStripMenuItem.Name = "DangNhapToolStripMenuItem"
        Me.DangNhapToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.DangNhapToolStripMenuItem.Text = "Đăng Nhập"
        '
        'ThoatToolStripMenuItem
        '
        Me.ThoatToolStripMenuItem.Name = "ThoatToolStripMenuItem"
        Me.ThoatToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.ThoatToolStripMenuItem.Text = "Thoát"
        '
        'KhachHangToolStripMenuItem
        '
        Me.KhachHangToolStripMenuItem.Name = "KhachHangToolStripMenuItem"
        Me.KhachHangToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.KhachHangToolStripMenuItem.Text = "Khách Hàng"
        '
        'SanPhamToolStripMenuItem
        '
        Me.SanPhamToolStripMenuItem.Name = "SanPhamToolStripMenuItem"
        Me.SanPhamToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.SanPhamToolStripMenuItem.Text = "Sản Phẩm"
        '
        'LoaiSanPhamToolStripMenuItem
        '
        Me.LoaiSanPhamToolStripMenuItem.Name = "LoaiSanPhamToolStripMenuItem"
        Me.LoaiSanPhamToolStripMenuItem.Size = New System.Drawing.Size(97, 20)
        Me.LoaiSanPhamToolStripMenuItem.Text = "Loại Sản Phẩm"
        '
        'ThanhToanToolStripMenuItem
        '
        Me.ThanhToanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HoaDonToolStripMenuItem, Me.ChiTietHoaDonToolStripMenuItem})
        Me.ThanhToanToolStripMenuItem.Name = "ThanhToanToolStripMenuItem"
        Me.ThanhToanToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.ThanhToanToolStripMenuItem.Text = "Thanh Toán"
        '
        'HoaDonToolStripMenuItem
        '
        Me.HoaDonToolStripMenuItem.Name = "HoaDonToolStripMenuItem"
        Me.HoaDonToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.HoaDonToolStripMenuItem.Text = "Hóa Đơn"
        '
        'ChiTietHoaDonToolStripMenuItem
        '
        Me.ChiTietHoaDonToolStripMenuItem.Name = "ChiTietHoaDonToolStripMenuItem"
        Me.ChiTietHoaDonToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ChiTietHoaDonToolStripMenuItem.Text = "Chi Tiết Hóa Đơn"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.minhlxpk00275_assignment.My.Resources.Resources.Business_feature
        Me.PictureBox1.Location = New System.Drawing.Point(111, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(426, 247)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'frm_hethong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(649, 300)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm_hethong"
        Me.Text = "Hệ Thống"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DangNhapToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThoatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KhachHangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SanPhamToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoaiSanPhamToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThanhToanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HoaDonToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChiTietHoaDonToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuanLyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
