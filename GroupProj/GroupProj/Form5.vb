Imports System.Data.OleDb

Public Class Form5
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim startY As Integer = 180
        Dim intC As Integer

        e.Graphics.DrawString("DECEPTECH SDN BHD", New Font("Calisto MT", 12), Brushes.Black, 10, 20)
        e.Graphics.DrawString("Billed To: " & Form3.strUNF3, New Font("Lucida Console", 12), Brushes.Black, 10, 40)
        e.Graphics.DrawString("           " & Form3.strEmailF3, New Font("Lucida Console", 12), Brushes.Black, 10, 60)
        e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------------", New Font("Lucida Console", 12), Brushes.Black, 10, 80)



        For intC = 0 To lstCart.Items.Count - 1
            e.Graphics.DrawString(lstCart.Items(intC).ToString(), New Font("Lucida Console", 12), Brushes.Black, 10, startY)
            startY += 20
            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------------", New Font("Lucida Console", 12), Brushes.Black, 10, startY)
            startY += 20
        Next


    End Sub

    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub PreviewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreviewToolStripMenuItem.Click
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Dim strpayStatus As String = "Pending"
        Dim strCommand As String = "insert into customer([username] , [total_item] , [total_price] , [pay_status]) values ('" & Form3.strUNF3 & "', '" & Form4.intCart & "', '" & Form4.decTotal & "', '" & strpayStatus & "')"
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\VisualStudioProject\GroupProj\GroupProj\LoginInfo.accdb")
        Dim cmd As New OleDbCommand(strCommand, conn)
        conn.Open()

        cmd.Parameters.Add(New OleDbParameter("username", CType(Form3.strUNF3, String)))
        cmd.Parameters.Add(New OleDbParameter("item_desc", CType(Form4.intCart, String)))
        cmd.Parameters.Add(New OleDbParameter("item_price", CDec(Form4.decTotal)))
        cmd.Parameters.Add(New OleDbParameter("item_category", CType(strpayStatus, String)))

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



        PrintDocument1.Print()
        lstCart.Items.Clear()
        Form4.intCart = 0
        Form4.decTotal = 0.00
        Form4.lblCart.Text = 0
        Form8.Show()
        Me.Hide()
    End Sub
    Private Sub btnCart_Click(sender As Object, e As EventArgs) Handles btnCart.Click
        lstCart.Items.Clear()
        Form4.intCart = 0
        Form4.decTotal = 0.00
        Form4.lblCart.Text = 0

        Me.Hide()
        Form4.Show()
    End Sub

End Class