Public Class frm_login



    Private Sub bnt_ok_Click(sender As Object, e As EventArgs) Handles bntok.Click
        If txtpass.Text = "123456" And txtuser.Text = "admin" Then
            frm_hethong.Show()
            MessageBox.Show("Đăng nhập thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Me.Hide()
        Else
            MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        End If
    End Sub
    Private Sub Frmdangnhap_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        frm_hethong.Show()
        Me.Hide()
    End Sub
    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bntexit_Click(sender As Object, e As EventArgs) Handles bntexit.Click
        Close()
    End Sub
End Class
