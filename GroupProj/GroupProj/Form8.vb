Public Class Form8
    Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.Click
        End
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Me.Hide()
        Form3.Show()
        Form3.txtPassword.Clear()
        Form3.txtUsername.Clear()
        Form3.radAdmin.Checked = False
        Form3.radCustomer.Checked = False
    End Sub
End Class