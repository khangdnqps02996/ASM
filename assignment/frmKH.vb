Imports System.Data.SqlClient
Imports System.Data
Public Class frmKH
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=khangdnqps02996.mssql.somee.com;packet size=4096;user id=khangdnqps02996_SQLLogin_1;pwd=fs7sjenyhz;data source=khangdnqps02996.mssql.somee.com;persist security info=False;initial catalog=khangdnqps02996"
    Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub btnXem_Click(sender As Object, e As EventArgs) Handles btnXem.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim xem As SqlDataAdapter = New SqlDataAdapter("select MaKH as 'Mã KH' ,TenKH as 'Tên Khách Hàng', DiaChi as 'Địa chỉ', SDT as 'SĐT' from KHACH_HANG where MaKH='" & txtMAKH.Text & "'", connect)
        Try
            If txtMAKH.Text = "" Then
                MessageBox.Show("Bạn cần nhập MaKH", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
          
            Else
                db.Clear()
                dgvXemkh.DataSource = Nothing
                xem.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvXemkh.DataSource = db.DefaultView
                    txtMAKH.Text = Nothing
                Else
                    MessageBox.Show("Không tìm thấy")
                    txtMAKH.Text = Nothing
                End If
            End If
            connect.Close()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub btnXemall_Click(sender As Object, e As EventArgs) Handles btnXemall.Click
        Dim hienthi As New Class1
        dgvXemkh.DataSource = hienthi.Loadkhachang.Tables(0)
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub

    Private Sub frmKH_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class