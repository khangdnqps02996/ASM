Public Class frmMain

    Private Sub ThêmSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmSảnPhẩmToolStripMenuItem.Click
        frmCapnhatsanpham.Show()
    End Sub

    Private Sub XemKhácHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XemKhácHàngToolStripMenuItem.Click
        frmKH.Show()
    End Sub

    Private Sub ChỉnhSữaKHToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChỉnhSữaKHToolStripMenuItem.Click
        frmDieuchinhKH.Show()
    End Sub

    Private Sub XemSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XemSảnPhẩmToolStripMenuItem.Click
        frmXemsanpham.Show()
    End Sub

    Private Sub LoạiSànPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class
