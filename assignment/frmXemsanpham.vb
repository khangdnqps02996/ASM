Imports System.Data.SqlClient
Imports System.Data.DataSet
Public Class frmXemsanpham
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=khangdnqps02996.mssql.somee.com;packet size=4096;user id=khangdnqps02996_SQLLogin_1;pwd=fs7sjenyhz;data source=khangdnqps02996.mssql.somee.com;persist security info=False;initial catalog=khangdnqps02996"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub btnXemall_Click(sender As Object, e As EventArgs) Handles btnXemall.Click

        Dim load As SqlDataAdapter = New SqlDataAdapter("select SAN_PHAM.MaSP as 'Mã sản phẩm',SAN_PHAM.TenSP as 'Tên sản phẩm', LOAI_SAN_PHAM.MaLoai as 'Mã Loại', LOAI_SAN_PHAM.TenLoai as 'Tên Loại',SAN_PHAM.SoLuong as 'Số lượng' from SAN_PHAM inner join LOAI_SAN_PHAM on LOAI_SAN_PHAM.MaLoai = SAN_PHAM.MaLoai", conn)

        conn.Open()
        load.Fill(db)
        dgvXemsp.DataSource = db.DefaultView
    End Sub

    Private Sub btnXem_Click(sender As Object, e As EventArgs) Handles btnXem.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim timkiem As SqlDataAdapter = New SqlDataAdapter("select SAN_PHAM.MaSP as 'Mã sản phẩm',SAN_PHAM.TenSP as 'Tên sản phẩm', LOAI_SAN_PHAM.MaLoai as 'Mã Loại', LOAI_SAN_PHAM.TenLoai as 'Tên Loại',SAN_PHAM.SoLuong as 'Số lượng' from SAN_PHAM inner join LOAI_SAN_PHAM on LOAI_SAN_PHAM.MaLoai = SAN_PHAM.MaLoai where SAN_PHAM.MaSP ='" & txtMASP.Text & "' ", connect)
        Try
            If txtMASP.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã sản phẩm", "Nhập thiếu", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                db.Clear()
                dgvXemsp.DataSource = Nothing
                timkiem.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvXemsp.DataSource = db.DefaultView
                    txtMASP.Text = Nothing
                Else
                    MessageBox.Show("Không tìm được")
                    txtMASP.Text = Nothing
                End If
            End If
            connect.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub

    Private Sub frmXemsanpham_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub dgvXemsp_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvXemsp.CellContentClick

    End Sub
End Class