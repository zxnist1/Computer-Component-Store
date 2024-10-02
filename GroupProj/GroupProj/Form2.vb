Imports System.Data.Common
Imports System.Data.OleDb

Public Class Form2
    Private Sub btnSign_Click(sender As Object, e As EventArgs) Handles btnSign.Click
        Dim strUserName As String
        Dim strPassword As String
        Dim strRole As String = "customer"
        Dim strEmail As String
        Dim strCommand As String

        strEmail = txtEmail.Text
        strPassword = txtPW.Text
        strUserName = txtUn.Text


        If (txtEmail.Text = Nothing Or txtUn.Text = Nothing Or txtPW.Text = Nothing) Then
            MsgBox("Please insert value", vbOKOnly & vbExclamation, "Error")
            Return
        End If

        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\VisualStudioProject\GroupProj\GroupProj\\LoginInfo.accdb")
        strCommand = "insert into LoginInfo ([username] , [password] , [role] , [email]) values ('" & strUserName & "', '" & strPassword & "', '" & strRole & "', '" & strEmail & "')"
        Dim cmd As New OleDbCommand(strCommand, conn)
        conn.Open()

        cmd.Parameters.Add(New OleDbParameter("username", CType(strUserName, String)))
        cmd.Parameters.Add(New OleDbParameter("password", CType(strPassword, String)))
        cmd.Parameters.Add(New OleDbParameter("role", CType(strRole, String)))
        cmd.Parameters.Add(New OleDbParameter("email", CType(strEmail, String)))
        MsgBox("Result Saved")
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            conn.Close()
            Me.Hide()
            Form3.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub
End Class