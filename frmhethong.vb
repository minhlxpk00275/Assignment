Public Class frm_hethong

   

    Private Sub KhachHangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KhachHangToolStripMenuItem.Click
        frmkhachhang.Show()
    End Sub

    Private Sub SanPhamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SanPhamToolStripMenuItem.Click
        frmsanpham.Show()
    End Sub

    Private Sub LoaiSanPhamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoaiSanPhamToolStripMenuItem.Click
        frmloaisp.Show()
    End Sub

    Private Sub HoaDonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HoaDonToolStripMenuItem.Click
        frmhoadon.Show()
    End Sub

    Private Sub ChiTietHoaDonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChiTietHoaDonToolStripMenuItem.Click
        frmchitiethd.Show()
    End Sub

    Private Sub frm_hethong_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("Bạn có muốn thoát khỏi chương trình không ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "THOÁT") = MsgBoxResult.No Then
            e.Cancel = True
        End If
    End Sub

    
    Private Sub frm_hethong_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class