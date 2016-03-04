Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmDieuchinhKH
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=khangdnqps02996.mssql.somee.com;packet size=4096;user id=khangdnqps02996_SQLLogin_1;pwd=fs7sjenyhz;data source=khangdnqps02996.mssql.somee.com;persist security info=False;initial catalog=khangdnqps02996"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub frmDieuchinhKH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim load As SqlDataAdapter = New SqlDataAdapter("select MaKH as 'Mã KH' ,TenKH as 'Tên Khách Hàng', DiaChi as 'Địa chỉ', SDT as 'SĐT' from KHACH_HANG", conn)

        conn.Open()
        load.Fill(db)
        dgvKH.DataSource = db.DefaultView
    End Sub
    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim xem As SqlDataAdapter = New SqlDataAdapter("select MaKH as 'Mã KH' ,TenKH as 'Tên Khách Hàng', DiaChi as 'Địa chỉ', SDT as 'SĐT', from KHACH_HANG where MaKH=N'" & txtMaKH.Text & "'", connect)
        Try
            If txtMaKH.Text = "" Then
                MessageBox.Show("Bạn cần nhập MaKH", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

            Else
                db.Clear()
                dgvKH.DataSource = Nothing
                xem.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvKH.DataSource = db.DefaultView
                    txtMaKH.Text = Nothing
                    btnXoa.Enabled = True
                Else
                    MessageBox.Show("Không tìm thấy")
                    txtMaKH.Text = Nothing
                End If
            End If
            connect.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgvKH_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKH.CellContentClick
        Dim click As Integer = dgvKH.CurrentCell.RowIndex
        txtMaKH.Text = dgvKH.Item(0, click).Value
        txtTenkh.Text = dgvKH.Item(1, click).Value
        txtAdd.Text = dgvKH.Item(2, click).Value
        txtSDT.Text = dgvKH.Item(3, click).Value



    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim query As String = "insert into KHACH_HANG values(@MaKH,@TenKH,@DiaChi,@SDT)"
        Dim save As SqlCommand = New SqlCommand(query, conn)
        conn.Open()
        Try
            txtMaKH.Focus()
            If txtMaKH.Text = "" Then
                MessageBox.Show("Bạn chưa nhập Mã Khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtMaKH.Focus()
                If txtTenkh.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                        txtAdd.Focus()
                        If txtSDT.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập số điện thoại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                           
                            save.Parameters.AddWithValue("@MaKH", txtMaKH.Text)
                            save.Parameters.AddWithValue("@TenKH", txtTenkh.Text)
                            save.Parameters.AddWithValue("@DiaChi", txtAdd.Text)
                                save.Parameters.AddWithValue("@SDT", txtSDT.Text)

                                save.ExecuteNonQuery()
                                MessageBox.Show("Lưu thành công")
                                'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
                                txtMaKH.Text = Nothing
                                txtTenkh.Text = Nothing
                            txtAdd.Text = Nothing
                                txtSDT.Text = Nothing


                            End If
                        End If
                    End If

        Catch ex As Exception  'Ngược lại báo lỗi
            MessageBox.Show("Không được trùng mã khách hàng", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Làm mới lại bảng sau khi lưu thành công
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MaKH as 'Mã KH' ,TenKH as 'Tên Khách Hàng', DiaChi as 'Địa chỉ', SDT as 'SĐT' from KHACH_HANG", conn)
        db.Clear()
        refesh.Fill(db)
        dgvKH.DataSource = db.DefaultView
    End Sub

    
    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim delquery As String = "delete from KHACH_HANG where MaKH=@MaKH"
        Dim delete As SqlCommand = New SqlCommand(delquery, conn)
        Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        conn.Open()
        Try
            If txtMaKH.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                txtMaKH.Focus()
            Else
                If resulft = Windows.Forms.DialogResult.Yes Then
                    delete.Parameters.AddWithValue("@MaKH", txtMaKH.Text)
                    delete.ExecuteNonQuery()
                    conn.Close()
                    MessageBox.Show("Xóa thành công")
                    'Sau khi xóa thành công, tự động làm mới các khung textbox, combox và date....
                    txtMaKH.Text = Nothing
                    txtTenkh.Text = Nothing
                    txtAdd.Text = Nothing
                    txtSDT.Text = Nothing

                    txtMaKH.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Nhập đúng mã khách hàng cần xóa", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'làm mới bảng
        db.Clear()
        dgvKH.DataSource = db
        dgvKH.DataSource = Nothing
        LoadData()
    End Sub
    'sự kiện làm mới
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim load As SqlDataAdapter = New SqlDataAdapter("select MaKH as 'Mã KH' ,TenKH as 'Tên Khách Hàng', DiaChi as 'Địa chỉ', SDT as 'SĐT' from KHACH_HANG", conn)

        conn.Open()
        load.Fill(db)
        dgvKH.DataSource = db.DefaultView
    End Sub

    Private Sub btnCapnhat_Click(sender As Object, e As EventArgs) Handles btnCapnhat.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim updatequery As String = "update KHACH_HANG set MaKH=@MaKH, TenKH=@TenKH, DiaChi=@DiaChi, SDT=@SDT where MaKH=@MaKH"
        Dim addupdate As SqlCommand = New SqlCommand(updatequery, conn)
        conn.Open()
        Try
            txtMaKH.Focus()
            If txtMaKH.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtMaKH.Focus()
                If txtTenkh.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtTenkh.Focus()
                    If txtAdd.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập địa chỉ khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtAdd.Focus()
                        If txtSDT.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập số điện thoại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            
                               
                                addupdate.Parameters.AddWithValue("@MaKH", txtMaKH.Text)
                                addupdate.Parameters.AddWithValue("@TenKH", txtTenkh.Text)
                                addupdate.Parameters.AddWithValue("@DiaChi", txtAdd.Text)
                                addupdate.Parameters.AddWithValue("@SDT", txtSDT.Text)

                                addupdate.ExecuteNonQuery()
                                conn.Close() 'đóng kết nối
                                MessageBox.Show("Cập nhật thành công")
                                txtMaKH.Text = Nothing
                                txtTenkh.Text = Nothing
                                txtAdd.Text = Nothing
                                txtSDT.Text = Nothing

                                End If
                            End If
                        End If
                    End If

        Catch ex As Exception
            MessageBox.Show("Không thành công", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Sau khi cập nhật xong sẽ tự làm mới lại bảng
        db.Clear()
        dgvKH.DataSource = db
        dgvKH.DataSource = Nothing
        LoadData()
    End Sub
End Class