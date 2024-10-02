Imports System.Data.OleDb

Public Class Form3
    Public strUNF3 As String
    Public strEmailF3 As String
    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\VisualStudioProject\GroupProj\GroupProj\LoginInfo.accdb")
        Dim role As String = ""
        If (radAdmin.Checked = True) Then
            role = "admin"
        ElseIf (radCustomer.Checked = True) Then
            role = "customer"
        End If

        Dim cmd As New OleDbCommand("SELECT * FROM LoginInfo WHERE username = '" & txtUsername.Text & "' AND password = '" & txtPassword.Text & "' AND role = '" & role & "'", conn)
        Dim user As String = ""
        Dim pass As String = ""
        Dim roles As String = ""
        conn.Open()

        Dim sdr As OleDbDataReader = cmd.ExecuteReader()

        If (sdr.Read() = True) Then

            user = sdr("username")
            pass = sdr("password")
            roles = sdr("role")
            strUNF3 = user
            strEmailF3 = sdr("email")
            MessageBox.Show("Login Succesful")
            Me.Hide()
            If (roles = "admin") Then
                Form12.Show()
            ElseIf (roles = "customer") Then
                Form4.Show()
            End If
        Else
            MessageBox.Show("Information inserted was wrong")
        End If
        conn.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Form2.Show()
        Form2.txtUn.Text = ""
        Form2.txtPW.Text = ""
        Form2.txtEmail.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (txtPassword.UseSystemPasswordChar = False) Then
            txtPassword.UseSystemPasswordChar = True
        Else
            txtPassword.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub
End Class