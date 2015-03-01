Imports System.Data
Imports System.Data.SqlClient

Public Class frmsanpham
    Dim data As New SqlConnection("Data Source=.;Initial Catalog=assignment;Integrated Security=True")
    Private Sub chaydulieu()
        data.Open()
        Dim load As New SqlCommand("select * from SanPham", data)
        Dim sqldata As New SqlDataAdapter(load)
        Dim sqldatatabel As New DataTable
        sqldata.Fill(sqldatatabel)
        data.Close()
        lstsp.Items.Clear()
        Dim a As Integer
        For Each Row As DataRow In sqldatatabel.Rows
            lstsp.Items.Add(Row("idsp").ToString())
            lstsp.Items(a).SubItems.Add(Row("tensp").ToString())
            lstsp.Items(a).SubItems.Add(Row("hangsp").ToString())
            lstsp.Items(a).SubItems.Add(Row("gia").ToString())
            lstsp.Items(a).SubItems.Add(Row("mota").ToString())
            lstsp.Items(a).SubItems.Add(Row("idloaisp").ToString())
            a += 1
        Next
    End Sub

    Private Sub bntthem_Click(sender As Object, e As EventArgs) Handles bntthem.Click
        If (KiemTraThongTin() = True) Then
            Try
                data.Open()
                Dim idsp As String = txtidsp.Text
                Dim tensp As String = txttensp.Text
                Dim hangsp As String = txthangsp.Text
                Dim gia As String = txtgia.Text
                Dim mota As String = txtmota.Text
                Dim idloaisp As String = txtidloaisp.Text
                Dim them As New SqlCommand("Insert into SanPham(idsp,tensp,hangsp,gia,mota,idloaisp) values('" + idsp + "' , '" + tensp + "', '" + hangsp + "' ,'" + gia + "','" + mota + "','" + idloaisp + "')", data)
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
        txtidsp.Text = ""
        txttensp.Text = ""
        txthangsp.Text = ""
        txtgia.Text = ""
        txtmota.Text = ""
        txtidloaisp.Text = ""
    End Sub
    Private Sub lstsp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstsp.SelectedIndexChanged
        If lstsp.SelectedItems.Count = 1 Then
            For Each lis As ListViewItem In lstsp.SelectedItems
                txtidsp.Text = lis.SubItems(0).Text
                txttensp.Text = lis.SubItems(1).Text
                txthangsp.Text = lis.SubItems(2).Text
                txtgia.Text = lis.SubItems(3).Text
                txtmota.Text = lis.SubItems(4).Text
                txtidloaisp.Text = lis.SubItems(5).Text
                bntxoa.Enabled = True
                bntsua.Enabled = True
            Next
        End If
    End Sub
    Private Sub bntxoa_Click(sender As Object, e As EventArgs) Handles bntxoa.Click

        Try
            data.Open()
            Dim idsp As String = txtidsp.Text
            Dim xoa As New SqlCommand("delete from SanPham where idsp ='" + idsp + "'", data)
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
            Dim idsp As String = txtidsp.Text
            Dim tensp As String = txttensp.Text
            Dim hangsp As String = txthangsp.Text
            Dim gia As String = txtgia.Text
            Dim mota As String = txtmota.Text
            Dim idloaisp As String = txtidloaisp.Text
            Dim sua As New SqlCommand("update SanPham set tensp = '" + tensp + "', hangsp= '" + hangsp + "' , gia= '" + gia + "', mota= '" + mota + "', idloaisp= '" + idloaisp + "'  where idsp = '" + idsp + "'", data)
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
    'Hàm ki?m tra thông tin. N?u thông tin d?y d? th́ tr? v? là True, ngu?c l?i False 
    Private Function KiemTraThongTin() As Boolean

        If (txtidsp.Text.Trim = "") Then
            MessageBox.Show("Bạn vui lònng nhập mă sp", "Thông báo")
            Return False
        ElseIf (txttensp.Text.Trim = "") Then
            MessageBox.Show("Bạn vui lònng nhập mă công to", "Thông báo")
            Return False
        ElseIf (txthangsp.Text.Trim = "") Then
            MessageBox.Show("Bạn vui lònng nhập  (KW)", "Thông báo")
            Return False
        ElseIf (txtgia.Text.Trim = "") Then
            MessageBox.Show("Bạn vui lònng nhập", "Thông báo")
            Return False
        ElseIf (txtmota.Text.Trim = "") Then
            MessageBox.Show("Bạn vui lònng nhập", "Thông báo")
            Return False
        ElseIf (txtidloaisp.Text.Trim = "") Then
            MessageBox.Show("Bạn vui lònng nhập", "Thông báo")
            Return False
        End If

        Return True
    End Function
    Private Sub txtBookName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtidsp.TextChanged, txtidsp.TextChanged, txtidsp.TextChanged
        If (txtidsp.Text.Trim = "") Then
            bntthem.Enabled = False
        Else
            bntthem.Enabled = True
        End If
    End Sub





End Class