<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.KhácHàngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChỉnhSữaKHToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XemKhácHàngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SảnPhẩmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThêmSảnPhẩmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XemSảnPhẩmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LiênHệToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GiớiThiệuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KhácHàngToolStripMenuItem
        '
        Me.KhácHàngToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChỉnhSữaKHToolStripMenuItem, Me.XemKhácHàngToolStripMenuItem})
        Me.KhácHàngToolStripMenuItem.Name = "KhácHàngToolStripMenuItem"
        Me.KhácHàngToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.KhácHàngToolStripMenuItem.Text = "Khác hàng"
        '
        'ChỉnhSữaKHToolStripMenuItem
        '
        Me.ChỉnhSữaKHToolStripMenuItem.Name = "ChỉnhSữaKHToolStripMenuItem"
        Me.ChỉnhSữaKHToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.ChỉnhSữaKHToolStripMenuItem.Text = "Cập nhật KH"
        '
        'XemKhácHàngToolStripMenuItem
        '
        Me.XemKhácHàngToolStripMenuItem.Name = "XemKhácHàngToolStripMenuItem"
        Me.XemKhácHàngToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.XemKhácHàngToolStripMenuItem.Text = "Xem khác hàng"
        '
        'SảnPhẩmToolStripMenuItem
        '
        Me.SảnPhẩmToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThêmSảnPhẩmToolStripMenuItem, Me.XemSảnPhẩmToolStripMenuItem})
        Me.SảnPhẩmToolStripMenuItem.Name = "SảnPhẩmToolStripMenuItem"
        Me.SảnPhẩmToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.SảnPhẩmToolStripMenuItem.Text = "Sản phẩm"
        '
        'ThêmSảnPhẩmToolStripMenuItem
        '
        Me.ThêmSảnPhẩmToolStripMenuItem.Name = "ThêmSảnPhẩmToolStripMenuItem"
        Me.ThêmSảnPhẩmToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ThêmSảnPhẩmToolStripMenuItem.Text = "Cập nhật SP"
        '
        'XemSảnPhẩmToolStripMenuItem
        '
        Me.XemSảnPhẩmToolStripMenuItem.Name = "XemSảnPhẩmToolStripMenuItem"
        Me.XemSảnPhẩmToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.XemSảnPhẩmToolStripMenuItem.Text = "Xem sản phẩm"
        '
        'LiênHệToolStripMenuItem
        '
        Me.LiênHệToolStripMenuItem.Name = "LiênHệToolStripMenuItem"
        Me.LiênHệToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.LiênHệToolStripMenuItem.Text = "Liên hệ"
        '
        'GiớiThiệuToolStripMenuItem
        '
        Me.GiớiThiệuToolStripMenuItem.Name = "GiớiThiệuToolStripMenuItem"
        Me.GiớiThiệuToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.GiớiThiệuToolStripMenuItem.Text = "Giới thiệu"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KhácHàngToolStripMenuItem, Me.SảnPhẩmToolStripMenuItem, Me.LiênHệToolStripMenuItem, Me.GiớiThiệuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(570, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 38)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(537, 167)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(101, 222)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(369, 37)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ĐIỆN TOÁN ĐÁM MÂY"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 283)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Điện toán đám mây"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents KhácHàngToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChỉnhSữaKHToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents XemKhácHàngToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SảnPhẩmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThêmSảnPhẩmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents XemSảnPhẩmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LiênHệToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GiớiThiệuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
