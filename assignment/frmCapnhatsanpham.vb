Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmCapnhatsanpham
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=khangdnqps02996.mssql.somee.com;packet size=4096;user id=khangdnqps02996_SQLLogin_1;pwd=fs7sjenyhz;data source=khangdnqps02996.mssql.somee.com;persist security info=False;initial catalog=khangdnqps02996"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim xem As SqlDataAdapter = New SqlDataAdapter("select SAN_PHAM.MaSP as 'Mã sản phẩm', SAN_PHAM.TenSP as 'Tên sản phẩm', LOAI_SAN_PHAM.Maloai as 'Mã Loại', LOAI_SAN_PHAM.TenLoai as 'Tên Loại',SAN_PHAM.SoLuong as 'Số lượng' from SAN_PHAM inner join LOAI_SAN_PHAM on LOAI_SAN_PHAM.MaLoai = SAN_PHAM.MaLoai where SAN_PHAM.MaSP='" & txtMASP.Text & "'", connect)
        Try
            If txtMASP.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

            Else
                db.Clear()
                dgvSanpham.DataSource = Nothing
                xem.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvSanpham.DataSource = db.DefaultView
                    txtMASP.Text = Nothing

                Else
                    MessageBox.Show("Không tìm thấy")
                    txtMASP.Text = Nothing
                End If
            End If
            connect.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmCapnhatsanpham_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub dgvSanpham_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSanpham.CellContentClick
        Dim click As Integer = dgvSanpham.CurrentCell.RowIndex
        txtMASP.Text = dgvSanpham.Item(0, click).Value
        txtTENSP.Text = dgvSanpham.Item(1, click).Value
        txtMALOAI.Text = dgvSanpham.Item(2, click).Value
        txtTENLOAI.Text = dgvSanpham.Item(3, click).Value
        txtSOLUONG.Text = dgvSanpham.Item(4, click).Value
    End Sub
    'sự kiện làm mới
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim load As SqlDataAdapter = New SqlDataAdapter("select SAN_PHAM.MaSP as 'Mã sản phẩm', SAN_PHAM.TenSP as 'Tên sản phẩm', LOAI_SA_NPHAM.MaLoai as 'Mã Loại', LOAI_SAN_PHAM.TenLoai as 'Tên Loại', SAN_PHAM.SoLuong as 'Số lượng' from LOAI_SAN_PHAM inner join SAN_PHAM on LOAI_SAN_PHAM.MaLoai = SAN_PHAM.MaLoai", conn)

        conn.Open()
        load.Fill(db)
        dgvSanpham.DataSource = db.DefaultView
    End Sub
    Private Sub btnCapnhat_Click(sender As Object, e As EventArgs) Handles btnCapnhat.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim updatequery As String = "update SAN_PHAM set MaSP=@MaSP, TenSP=@TenSP, SoLuong=@SoLuong where MaSP=@MaSP update LOAI_SAN_PHAM set MaLoai=@MaLoai, MaSP=@MaSP,TenLoai=@TenLoai where MaSP=@MaSP"
        Dim addupdate As SqlCommand = New SqlCommand(updatequery, conn)
        conn.Open()
        Try
            txtMASP.Focus()
            If txtMASP.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtMASP.Focus()
                If txtTENSP.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtTENSP.Focus()
                    If txtMALOAI.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập mã loại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtMALOAI.Focus()
                        If txtSOLUONG.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập số lượng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            addupdate.Parameters.AddWithValue("@MaSP", txtMASP.Text)
                            addupdate.Parameters.AddWithValue("@TenSP", txtTENSP.Text)
                            addupdate.Parameters.AddWithValue("@MaLoai", txtMALOAI.Text)
                            addupdate.Parameters.AddWithValue("@TenLoai", txtTENLOAI.Text)
                            addupdate.Parameters.AddWithValue("@SoLuong", txtSOLUONG.Text)
                            addupdate.ExecuteNonQuery()
                            conn.Close() 'đóng kết nối
                            MessageBox.Show("Cập nhật thành công")
                            txtMASP.Text = Nothing
                            txtTENSP.Text = Nothing
                            txtMALOAI.Text = Nothing
                            txtTENLOAI.Text = Nothing
                            txtSOLUONG.Text = Nothing
                            End If
                        End If
                    End If
                End If
        Catch ex As Exception
            MessageBox.Show("Không thành công", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Sau khi cập nhật xong sẽ tự làm mới lại bảng
        db.Clear()
        dgvSanpham.DataSource = db
        dgvSanpham.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim delquery As String = "delete from SAN_PHAM where MaSP=@MaSP delete from LOAI_SAN_PHAM where MaSP=@MaSP"
        Dim delete As SqlCommand = New SqlCommand(delquery, conn)
        Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        conn.Open()
        Try
            If txtMASP.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                txtMASP.Focus()
            Else
                If resulft = Windows.Forms.DialogResult.Yes Then
                    delete.Parameters.AddWithValue("@MaSP", txtMASP.Text)
                    delete.ExecuteNonQuery()
                    conn.Close()
                    MessageBox.Show("Xóa thành công")
                    'Sau khi xóa thành công, tự động làm mới các khung textbox
                    txtMASP.Text = Nothing
                    txtTENSP.Text = Nothing
                    txtMALOAI.Text = Nothing
                    txtTENLOAI.Text = Nothing
                    txtSOLUONG.Text = Nothing
                    txtMASP.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Nhập đúng mã sản phẩm cần xóa", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'làm mới bảng
        db.Clear()
        dgvSanpham.DataSource = db
        dgvSanpham.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim query As String = "insert into SAN_PHAM values(@MaSP,@TenSP,@SoLuong) insert into LOAI_SAN_PHAM values(@MaLoai,@MaSP,@TenLoai)"
        Dim save As SqlCommand = New SqlCommand(query, conn)
        conn.Open()
        Try
            txtMASP.Focus()
            If txtMASP.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtMASP.Focus()
                If txtTENSP.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtTENSP.Focus()
                    If txtMALOAI.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập mã loại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtMALOAI.Focus()
                        If txtSOLUONG.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập số lượng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            save.Parameters.AddWithValue("@MaSP", txtMASP.Text)
                            save.Parameters.AddWithValue("@TenSP", txtTENSP.Text)
                            save.Parameters.AddWithValue("@MaLoai", txtMALOAI.Text)
                            save.Parameters.AddWithValue("@TenLoai", txtTENLOAI.Text)
                            save.Parameters.AddWithValue("@SoLuong", txtSOLUONG.Text)
                            save.ExecuteNonQuery()
                            MessageBox.Show("Lưu thành công")
                            'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
                            txtMASP.Text = Nothing
                            txtMALOAI.Text = Nothing
                            txtSOLUONG.Text = Nothing
                            txtTENSP.Text = Nothing
                            txtTENLOAI.Text = Nothing

                        End If
                    End If
                End If
            End If
        Catch ex As Exception  'Ngược lại báo lỗi
            MessageBox.Show("Không được trùng mã sản phẩm", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Làm mới lại bảng sau khi lưu thành công
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select SAN_PHAM.MaSP as 'Mã sản phẩm',SAN_PHAM.TenSP as 'Tên sản phẩm', LOAI_SAN_PHAM.MaLoai as 'Mã Loại', LOAI_SAN_PHAM.TenLoai as 'Tên Loại',SAN_PHAM.SoLuong as 'Số lượng' from SAN_PHAM inner join LOAI_SAN_PHAM on LOAI_SAN_PHAM.MaLoai = SAN_PHAM.MaLoai", conn)
        db.Clear()
        refesh.Fill(db)
        dgvSanpham.DataSource = db.DefaultView
    End Sub
End Class