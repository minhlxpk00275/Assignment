Imports System.Data
Imports System.Data.SqlClient

Public Class frmchitiethd
    Dim data As New SqlConnection("Data Source=.;Initial Catalog=assignment;Integrated Security=True")
    Private Sub chaydulieu()
        data.Open()
        Dim load As New SqlCommand("select * from ChiTietHD", data)
        Dim sqldata As New SqlDataAdapter(load)
        Dim sqldatatabel As New DataTable
        sqldata.Fill(sqldatatabel)
        data.Close()
        lstcthd.Items.Clear()
        Dim a As Integer
        For Each Row As DataRow In sqldatatabel.Rows
            lstcthd.Items.Add(Row("idcthd").ToString())
            lstcthd.Items(a).SubItems.Add(Row("tensp").ToString())
            lstcthd.Items(a).SubItems.Add(Row("soluong").ToString())
            lstcthd.Items(a).SubItems.Add(Row("ngayxuat").ToString())
            lstcthd.Items(a).SubItems.Add(Row("mota").ToString())
            lstcthd.Items(a).SubItems.Add(Row("idhd").ToString())
            a += 1
        Next
    End Sub

    Private Sub bntthem_Click(sender As Object, e As EventArgs) Handles bntthem.Click
        If (KiemTraThongTin() = True) Then
            Try
                data.Open()
                Dim idcthd As String = txtidcthd.Text
                Dim tensp As String = txttensp.Text
                Dim soluong As String = txtsoluong.Text
                Dim ngayxuat As String = txtngayxuat.Text
                Dim mota As String = txtmota.Text
                Dim idhd As String = txtidhd.Text
                Dim them As New SqlCommand("Insert into ChitietHD(idcthd,tensp,soluong,ngayxuat,mota,idhd) values('" + idcthd + "' , '" + tensp + "', '" + soluong + "' ,'" + ngayxuat + "','" + mota + "','" + idhd + "')", data)
                them.ExecuteNonQuery()
                data.Close()
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                chaydulieu()
            Catch ex As Exception
                MessageBox.Show("Thêm Không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            ClearBox()
        End If
    End Sub
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        chaydulieu()
    End Sub

    Private Sub frmkhachhang_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("Bạn có muốn thoát khỏi chương trình không ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "THOÁT") = MsgBoxResult.No Then
            e.Cancel = True
        End If
    End Sub


    Private Sub ClearBox()
        txtidcthd.Text = ""
        txttensp.Text = ""
        txtsoluong.Text = ""
        txtngayxuat.Text = ""
        txtmota.Text = ""
        txtidhd.Text = ""
    End Sub
    Private Sub lstcthd_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstcthd.SelectedIndexChanged
        If lstcthd.SelectedItems.Count = 1 Then
            For Each lis As ListViewItem In lstcthd.SelectedItems
                txtidcthd.Text = lis.SubItems(0).Text
                txttensp.Text = lis.SubItems(1).Text
                txtsoluong.Text = lis.SubItems(2).Text
                txtngayxuat.Text = lis.SubItems(3).Text
                txtmota.Text = lis.SubItems(4).Text
                txtidhd.Text = lis.SubItems(5).Text
                bntxoa.Enabled = True
                bntsua.Enabled = True
            Next
        End If
    End Sub
    Private Sub bntxoa_Click(sender As Object, e As EventArgs) Handles bntxoa.Click

        Try
            data.Open()
            Dim idcthd As String = txtidcthd.Text
            Dim xoa As New SqlCommand("delete from ChitietHD where idcthd ='" + idcthd + "'", data)
            xoa.ExecuteNonQuery()
            data.Close()
            Dim dialogResult As DialogResult = MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If (dialogResult = Windows.Forms.DialogResult.Yes) Then
                chaydulieu()
            End If
        Catch ex As Exception
            MessageBox.Show("Xóa Không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        bntsua.Enabled = False
        bntxoa.Enabled = False

    End Sub

    Private Sub bntsua_Click(sender As Object, e As EventArgs) Handles bntsua.Click
        Try
            data.Open()
            Dim idcthd As String = txtidcthd.Text
            Dim tensp As String = txttensp.Text
            Dim soluong As String = txtsoluong.Text
            Dim ngayxuat As String = txtngayxuat.Text
            Dim mota As String = txtmota.Text
            Dim idhd As String = txtidhd.Text
            Dim sua As New SqlCommand("update ChitietHD set tensp = '" + tensp + "', soluong= '" + soluong + "' , ngayxuat= '" + ngayxuat + "', mota= '" + mota + "', idhd= '" + idhd + "'  where idcthd = '" + idcthd + "'", data)
            sua.ExecuteNonQuery()
            data.Close()
            Dim dialogResult As DialogResult = MessageBox.Show("Bạn có muốn sửa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If (dialogResult = Windows.Forms.DialogResult.Yes) Then
                chaydulieu()
            End If
        Catch ex As Exception
            MessageBox.Show("Sửa Không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'Hàm kiểm tra thông tin. Nếu thông tin đầy đủ thì trả về là True, ngược lại False 
    Private Function KiemTraThongTin() As Boolean

        If (txtidcthd.Text.Trim = "") Then
            MessageBox.Show("Bạn vui lònng nhập mă sp", "Thông báo")
            Return False
        ElseIf (txttensp.Text.Trim = "") Then
            MessageBox.Show("Bạn vui lònng nhập mă công to", "Thông báo")
            Return False
        ElseIf (txtsoluong.Text.Trim = "") Then
            MessageBox.Show("Bạn vui lònng nhập  (KW)", "Thông báo")
            Return False
        ElseIf (txtngayxuat.Text.Trim = "") Then
            MessageBox.Show("Bạn vui lònng nhập", "Thông báo")
            Return False
        ElseIf (txtmota.Text.Trim = "") Then
            MessageBox.Show("Bạn vui lònng nhập", "Thông báo")
            Return False
        ElseIf (txtidhd.Text.Trim = "") Then
            MessageBox.Show("Bạn vui lònng nhập", "Thông báo")
            Return False
        End If

        Return True
    End Function
    Private Sub txtBookName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtidcthd.TextChanged, txtidcthd.TextChanged, txtidcthd.TextChanged
        If (txtidcthd.Text.Trim = "") Then
            bntthem.Enabled = False
        Else
            bntthem.Enabled = True
        End If
    End Sub





End Class