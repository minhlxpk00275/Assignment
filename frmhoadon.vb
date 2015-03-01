Imports System.Data
Imports System.Data.SqlClient

Public Class frmhoadon
    Dim data As New SqlConnection("Data Source=.;Initial Catalog=assignment;Integrated Security=True")
    Private Sub chaydulieu()
        data.Open()
        Dim load As New SqlCommand("select * from HoaDon", data)
        Dim sqldata As New SqlDataAdapter(load)
        Dim sqldatatabel As New DataTable
        sqldata.Fill(sqldatatabel)
        data.Close()
        lsthd.Items.Clear()
        Dim a As Integer
        For Each Row As DataRow In sqldatatabel.Rows
            lsthd.Items.Add(Row("idhd").ToString())
            lsthd.Items(a).SubItems.Add(Row("idsp").ToString())
            lsthd.Items(a).SubItems.Add(Row("idkh").ToString())
            lsthd.Items(a).SubItems.Add(Row("ngayxuat").ToString())
            lsthd.Items(a).SubItems.Add(Row("tongtien").ToString())
            lsthd.Items(a).SubItems.Add(Row("mota").ToString())
            a += 1
        Next
    End Sub

    Private Sub bntthem_Click(sender As Object, e As EventArgs) Handles bntthem.Click
        If (KiemTraThongTin() = True) Then
            Try
                data.Open()
                Dim idhd As String = txtidhd.Text
                Dim idsp As String = txtidsp.Text
                Dim idkh As String = txtidkh.Text
                Dim ngayxuat As String = txtngayxuat.Text
                Dim tongtien As String = txttongtien.Text
                Dim mota As String = txtmota.Text
                Dim them As New SqlCommand("Insert into HoaDon(idhd,idsp,idkh,ngayxuat,tongtien,mota,) values('" + idhd + "' , '" + idsp + "', '" + idkh + "' ,'" + ngayxuat + "','" + tongtien + "','" + mota + "')", data)
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
        txtidhd.Text = ""
        txtidsp.Text = ""
        txtidkh.Text = ""
        txtngayxuat.Text = ""
        txttongtien.Text = ""
        txtmota.Text = ""
    End Sub
    Private Sub lsthd_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsthd.SelectedIndexChanged
        If lsthd.SelectedItems.Count = 1 Then
            For Each lis As ListViewItem In lsthd.SelectedItems
                txtidhd.Text = lis.SubItems(0).Text
                txtidsp.Text = lis.SubItems(1).Text
                txtidkh.Text = lis.SubItems(2).Text
                txtngayxuat.Text = lis.SubItems(3).Text
                txttongtien.Text = lis.SubItems(4).Text
                txtmota.Text = lis.SubItems(5).Text
                bntxoa.Enabled = True
                bntsua.Enabled = True
            Next
        End If
    End Sub
    Private Sub bntxoa_Click(sender As Object, e As EventArgs) Handles bntxoa.Click

        Try
            data.Open()
            Dim idhd As String = txtidhd.Text
            Dim xoa As New SqlCommand("delete from HoaDon where idhd ='" + idhd + "'", data)
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
            Dim idhd As String = txtidhd.Text
            Dim idsp As String = txtidsp.Text
            Dim idkh As String = txtidkh.Text
            Dim ngayxuat As String = txtngayxuat.Text
            Dim tongtien As String = txttongtien.Text
            Dim mota As String = txtidhd.Text
            Dim sua As New SqlCommand("update HoaDon set idsp = '" + idsp + "', tongtien= '" + tongtien + "' , ngayxuat= '" + ngayxuat + "', mota= '" + mota + "', idkh= '" + idkh + "'  where idhd = '" + idhd + "'", data)
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

        If (txtidhd.Text.Trim = "") Then
            MessageBox.Show("Bạn vui lònng nhập mă sp", "Thông báo")
            Return False
        ElseIf (txtidsp.Text.Trim = "") Then
            MessageBox.Show("Bạn vui lònng nhập mă công to", "Thông báo")
            Return False
        ElseIf (txtidkh.Text.Trim = "") Then
            MessageBox.Show("Bạn vui lònng nhập  (KW)", "Thông báo")
            Return False
        ElseIf (txtngayxuat.Text.Trim = "") Then
            MessageBox.Show("Bạn vui lònng nhập", "Thông báo")
            Return False
        ElseIf (txttongtien.Text.Trim = "") Then
            MessageBox.Show("Bạn vui lònng nhập", "Thông báo")
            Return False
        ElseIf (txtmota.Text.Trim = "") Then
            MessageBox.Show("Bạn vui lònng nhập", "Thông báo")
            Return False
        End If

        Return True
    End Function
    Private Sub txtBookName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtidhd.TextChanged, txtidhd.TextChanged, txtidhd.TextChanged
        If (txtidhd.Text.Trim = "") Then
            bntthem.Enabled = False
        Else
            bntthem.Enabled = True
        End If
    End Sub





End Class