<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmXemsanpham
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMASP = New System.Windows.Forms.TextBox()
        Me.btnXem = New System.Windows.Forms.Button()
        Me.btnXemall = New System.Windows.Forms.Button()
        Me.dgvXemsp = New System.Windows.Forms.DataGridView()
        Me.btnDong = New System.Windows.Forms.Button()
        CType(Me.dgvXemsp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã SP"
        '
        'txtMASP
        '
        Me.txtMASP.Location = New System.Drawing.Point(58, 10)
        Me.txtMASP.Name = "txtMASP"
        Me.txtMASP.Size = New System.Drawing.Size(160, 20)
        Me.txtMASP.TabIndex = 1
        '
        'btnXem
        '
        Me.btnXem.Location = New System.Drawing.Point(94, 51)
        Me.btnXem.Name = "btnXem"
        Me.btnXem.Size = New System.Drawing.Size(75, 23)
        Me.btnXem.TabIndex = 2
        Me.btnXem.Text = "Xem"
        Me.btnXem.UseVisualStyleBackColor = True
        '
        'btnXemall
        '
        Me.btnXemall.Location = New System.Drawing.Point(205, 51)
        Me.btnXemall.Name = "btnXemall"
        Me.btnXemall.Size = New System.Drawing.Size(75, 23)
        Me.btnXemall.TabIndex = 2
        Me.btnXemall.Text = "Xem tất cả"
        Me.btnXemall.UseVisualStyleBackColor = True
        '
        'dgvXemsp
        '
        Me.dgvXemsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvXemsp.Location = New System.Drawing.Point(19, 101)
        Me.dgvXemsp.Name = "dgvXemsp"
        Me.dgvXemsp.Size = New System.Drawing.Size(570, 239)
        Me.dgvXemsp.TabIndex = 3
        '
        'btnDong
        '
        Me.btnDong.Location = New System.Drawing.Point(321, 50)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(75, 23)
        Me.btnDong.TabIndex = 4
        Me.btnDong.Text = "Đóng"
        Me.btnDong.UseVisualStyleBackColor = True
        '
        'frmXemsanpham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(601, 352)
        Me.Controls.Add(Me.btnDong)
        Me.Controls.Add(Me.dgvXemsp)
        Me.Controls.Add(Me.btnXemall)
        Me.Controls.Add(Me.btnXem)
        Me.Controls.Add(Me.txtMASP)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmXemsanpham"
        Me.Text = "Xem sản phẩm"
        CType(Me.dgvXemsp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMASP As System.Windows.Forms.TextBox
    Friend WithEvents btnXem As System.Windows.Forms.Button
    Friend WithEvents btnXemall As System.Windows.Forms.Button
    Friend WithEvents dgvXemsp As System.Windows.Forms.DataGridView
    Friend WithEvents btnDong As System.Windows.Forms.Button
End Class
