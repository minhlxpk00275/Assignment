
Imports System.Data
Imports System.Data.SqlClient
Public Class frmkhachhang

    Dim abc As New SqlConnection("Data Source=.;Initial Catalog=assignment;Integrated Security=True")
    Private Sub loaddata()
        abc.Open()
        Dim load As New SqlCommand("select * from KhachHang", abc)
        Dim data As New SqlDataAdapter(load)
        Dim data1 As New DataTable
        data.Fill(data1)
        abc.Close()
        lstkh.Items.Clear()
        Dim b As Integer
        For Each Row As DataRow In data1.Rows
            lstkh.Items.Add(Row("idkh").ToString())
            lstkh.Items(b).SubItems.Add(Row("tenkh").ToString())
            lstkh.Items(b).SubItems.Add(Row("gioitinh").ToString())
            lstkh.Items(b).SubItems.Add(Row("ngaysinh").ToString())
            lstkh.Items(b).SubItems.Add(Row("email").ToString())
            lstkh.Items(b).SubItems.Add(Row("diachi").ToString())
            lstkh.Items(b).SubItems.Add(Row("sdt").ToString())
            b += 1
        Next
    End Sub
    Private Sub FrmKhachhang_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loaddata()
    End Sub

    Private Sub ClearBox()
        txtidkh.Text = ""
        txttenkh.Text = ""
        txtgioitinh.Text = ""
        txtngaysinh.Text = ""
        txtemail.Text = ""
        txtdiachi.Text = ""
        txtsdt.Text = ""




    End Sub

    Private Sub lstkh_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstkh.SelectedIndexChanged
        If lstkh.SelectedItems.Count = 1 Then
            For Each lis As ListViewItem In lstkh.SelectedItems
                txtidkh.Text = lis.SubItems(0).Text
                txttenkh.Text = lis.SubItems(1).Text
                txtgioitinh.Text = lis.SubItems(2).Text
                txtngaysinh.Text = lis.SubItems(3).Text
                txtemail.Text = lis.SubItems(4).Text
                txtdiachi.Text = lis.SubItems(5).Text
                txtsdt.Text = lis.SubItems(6).Text

                bntxoa.Enabled = True
                bntsua.Enabled = True
            Next
        End If
    End Sub

    Private Sub txtBookName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtidkh.TextChanged, txttenkh.TextChanged, txtngaysinh.TextChanged, txtgioitinh.TextChanged, txtemail.TextChanged, txtdiachi.TextChanged, txtsdt.TextChanged
        If (txtidkh.Text.Trim = "") Then
            bntthem.Enabled = False


        Else
            bntthem.Enabled = True


        End If
    End Sub
    Private Function KiemTraThongTin() As Boolean

        If (txtidkh.Text.Trim = "") Then
            MessageBox.Show("Bạn vui lòng nhập mã khách hàng", "Thông báo")
            Return False
        ElseIf (txttenkh.Text.Trim = "") Then
            MessageBox.Show("Bạn vui lòng nhập tên khách hàng", "Thông báo")
            Return False
        ElseIf (txtdiachi.Text.Trim = "") Then
            MessageBox.Show("Bạn vui lòng nhập địa chỉ", "Thông báo")
            Return False
        ElseIf (txtsdt.Text.Trim = "") Then
            MessageBox.Show("Bạn chưa nhập số điện thoại", "Thông báo")
            Return False
        ElseIf (txtemail.Text.Trim = "") Then
            MessageBox.Show("Bạn chưa nhập email", "Thông báo")
            Return False
        ElseIf (txtngaysinh.Text.Trim = "") Then
            MessageBox.Show("Bạn chưa nhập ngay sinh", "Thông báo")
            Return False

        End If

        Return True
    End Function
    Private Sub bntthem_Click(sender As Object, e As EventArgs) Handles bntthem.Click
        If (KiemTraThongTin() = True) Then
            Try
                abc.Open()
                Dim idkh As String = txtidkh.Text
                Dim tenkh As String = txttenkh.Text
                Dim gioitinh As String = txtgioitinh.Text
                Dim ngaysinh As String = txtngaysinh.Text
                Dim email As String = txtemail.Text
                Dim diachi As String = txtdiachi.Text
                Dim sdt As String = txtsdt.Text

                Dim them As New SqlCommand("Insert into KhachHang(idkh,tenkh,gioitinh,ngaysinh,email,diachi,sdt) values('" + idkh + "' , N'" + tenkh + "','" + gioitinh + "' ,'" + ngaysinh + "', N'" + email + "',N'" + diachi + "','" + sdt + "' )", abc)
                them.ExecuteNonQuery()
                abc.Close()
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                loaddata()
            Catch ex As Exception
                MessageBox.Show("Thêm Không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            ClearBox()
        End If
    End Sub




    Private Sub frmkhachhang_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("Bạn có muốn thoát khỏi chương trình không ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "THOÁT") = MsgBoxResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub bntsua_Click(sender As Object, e As EventArgs) Handles bntsua.Click

        Try
            abc.Open()
            Dim idkh As String = txtidkh.Text
            Dim tenkh As String = txttenkh.Text
            Dim gioitinh As String = txtgioitinh.Text
            Dim ngaysinh As String = txtngaysinh.Text
            Dim email As String = txtemail.Text
            Dim diachi As String = txtdiachi.Text
            Dim sdt As String = txtsdt.Text

            Dim sua As New SqlCommand("update KhachHang set  tenkh = N'" + tenkh + "', gioitinh = '" + gioitinh + "', ngaysinh = '" + ngaysinh + "', email = '" + email + "', diachi = N'" + diachi + "', sdt = '" + sdt + "' where idkh = '" + idkh + "' ", abc)
            sua.ExecuteNonQuery()
            abc.Close()
            MessageBox.Show("Bạn có muốn sửa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            loaddata()
        Catch ex As Exception
            MessageBox.Show("Sửa Không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub



    Private Sub bntxoa_Click(sender As Object, e As EventArgs) Handles bntxoa.Click

        Try
            abc.Open()
            Dim idkh As String = txtidkh.Text
            Dim xoa As New SqlCommand("delete from KhachHang where idkh ='" + idkh + "'", abc)
            xoa.ExecuteNonQuery()
            abc.Close()
            MessageBox.Show("Có chắc là bạn muốn xóa hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            loaddata()
        Catch ex As Exception
            MessageBox.Show("Xóa Không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        bntsua.Enabled = False
        bntxoa.Enabled = False

    End Sub
End Class