Imports System.Data.OleDb

Public Class Form4
    Dim strUsername As String
    Dim strDesc As String
    Dim decPrice As Decimal
    Public decTotal As Decimal
    Dim strCategory As String
    Public intCart As Integer

    Private Sub btnPC_Click(sender As Object, e As EventArgs) Handles btnPC.Click
        Dim intCount As Integer
        strCategory = "PC Case"
        strUsername = Form3.strUNF3

        If (radPC1.Checked = True) Then
            strDesc = "ASUS A21 mATX Casing – Black"
            decPrice = 220.0
        ElseIf (radPC2.Checked = True) Then
            strDesc = "Ronaldo Gaming Casing"
            decPrice = 700.0
        ElseIf (radPC3.Checked = True) Then
            strDesc = "MONTECH SKY ONE MINI"
            decPrice = 180.0
        ElseIf (radPC4.Checked = True) Then
            strDesc = "HYTE Revolt 3 ITX"
            decPrice = 240.0
        Else
            Return
        End If

        If (IsNumeric(txtPC.Text)) Then
            intCount = Val(txtPC.Text)
        Else
            MsgBox("Enter quantity", vbOK, "Caution")
        End If

        insertIntoAccess(intCount)
        ClearTemp()
    End Sub

    Private Sub btnMB_Click(sender As Object, e As EventArgs) Handles btnMB.Click
        Dim intCount As Integer
        strCategory = "Motherboard"
        strUsername = Form3.strUNF3

        If (radMB1.Checked = True) Then
            strDesc = "ASROCK B450M Steel Legend AM4"
            decPrice = 400.0
        ElseIf (radMB2.Checked = True) Then
            strDesc = "ASROCK B550M ITX/AC AM4"
            decPrice = 630.0
        ElseIf (radMB3.Checked = True) Then
            strDesc = "GIGABYTE AMD B450M K AM4"
            decPrice = 470.0
        ElseIf (radMB4.Checked = True) Then
            strDesc = "MSi AMD B550M K AM4"
            decPrice = 400.0
        Else
            Return
        End If

        If (IsNumeric(txtMB.Text)) Then
            intCount = Val(txtMB.Text)
        Else
            MsgBox("Enter quantity", vbOK, "Caution")
        End If

        insertIntoAccess(intCount)
        ClearTemp()
    End Sub

    Private Sub btnCP_Click(sender As Object, e As EventArgs) Handles btnCP.Click
        Dim intCount As Integer
        strCategory = "Processor"
        strUsername = Form3.strUNF3

        If (radCP1.Checked = True) Then
            strDesc = "AMD Ryzen 5 6000"
            decPrice = 650.0
        ElseIf (radCP2.Checked = True) Then
            strDesc = "AMD Ryzen 7 6000"
            decPrice = 850.0
        ElseIf (radCP3.Checked = True) Then
            strDesc = "AMD Ryzen 9 6000"
            decPrice = 1500.0
        ElseIf (radCP4.Checked = True) Then
            strDesc = "AMD Ryzen ThreadRipper 7000"
            decPrice = 2400.0
        Else
            Return
        End If

        If (IsNumeric(txtCP.Text)) Then
            intCount = Val(txtCP.Text)
        Else
            MsgBox("Enter quantity", vbOK, "Caution")
        End If

        insertIntoAccess(intCount)
        ClearTemp()
    End Sub

    Private Sub btnPS_Click(sender As Object, e As EventArgs) Handles btnPS.Click
        Dim intCount As Integer
        strCategory = "Power Supply"
        strUsername = Form3.strUNF3

        If (radPS1.Checked = True) Then
            strDesc = "1st Player NGDP"
            decPrice = 800.0
        ElseIf (radPS2.Checked = True) Then
            strDesc = "GIGABYTE P850GM"
            decPrice = 700.0
        ElseIf (radPS3.Checked = True) Then
            strDesc = "COOLER MASTER V SFX GOLD 550W"
            decPrice = 500.0
        ElseIf (radPS4.Checked = True) Then
            strDesc = "Segotep RP650"
            decPrice = 450.0
        Else
            Return
        End If

        If (IsNumeric(txtPS.Text)) Then
            intCount = Val(txtPS.Text)
        Else
            MsgBox("Enter quantity", vbOK, "Caution")
        End If

        insertIntoAccess(intCount)
        ClearTemp()
    End Sub

    Private Sub btnGP_Click(sender As Object, e As EventArgs) Handles btnGP.Click
        Dim intCount As Integer
        strCategory = "Graphic Card"
        strUsername = Form3.strUNF3

        If (radGP1.Checked = True) Then
            strDesc = "ASROCK AMD Radeon 8000"
            decPrice = 800.0
        ElseIf (radGP2.Checked = True) Then
            strDesc = "GIGABYTE GTX 1080 Ti"
            decPrice = 1300.0
        ElseIf (radGP3.Checked = True) Then
            strDesc = "ZOTAC RTX 3060"
            decPrice = 1500.0
        ElseIf (radGP4.Checked = True) Then
            strDesc = "MSi GTX 750 Ti"
            decPrice = 250.0
        Else
            Return
        End If

        If (IsNumeric(txtGP.Text)) Then
            intCount = Val(txtGP.Text)
        Else
            MsgBox("Enter quantity", vbOK, "Caution")
        End If

        insertIntoAccess(intCount)
        ClearTemp()
    End Sub

    Private Sub btnR_Click(sender As Object, e As EventArgs) Handles btnR.Click
        Dim intCount As Integer
        strCategory = "RAM"
        strUsername = Form3.strUNF3

        If (radR1.Checked = True) Then
            strDesc = "KINGSTON Fury Beast"
            decPrice = 490.0
        ElseIf (radR2.Checked = True) Then
            strDesc = "ADATA XPG Spectrix D50"
            decPrice = 380.0
        ElseIf (radR3.Checked = True) Then
            strDesc = "CORSAIR VENGEANCE RGB"
            decPrice = 420.0
        ElseIf (radR4.Checked = True) Then
            strDesc = "PNY XLR8"
            decPrice = 550.0
        Else
            Return
        End If

        If (IsNumeric(txtR.Text)) Then
            intCount = Val(txtR.Text)
        Else
            MsgBox("Enter quantity", vbOK, "Caution")
        End If

        insertIntoAccess(intCount)
        ClearTemp()
    End Sub
    Private Sub imgCart_Click(sender As Object, e As EventArgs) Handles imgCart.Click
        Form5.lstCart.Items.Add(String.Format("{0,-5}{1,-38}{2,-15}", "     ", "TOTAL", FormatCurrency(decTotal)))
        Me.Hide()
        Form5.Show()
    End Sub

    Private Sub insertIntoAccess(intCount As Integer)
        For x As Integer = 1 To intCount
            Dim strCommand As String = "insert into itemsale ([username] , [item_desc] , [item_price] , [item_category]) values ('" & strUsername & "', '" & strDesc & "', '" & decPrice & "', '" & strCategory & "')"
            Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\VisualStudioProject\GroupProj\GroupProj\LoginInfo.accdb")
            Dim cmd As New OleDbCommand(strCommand, conn)
            conn.Open()

            cmd.Parameters.Add(New OleDbParameter("username", CType(strUsername, String)))
            cmd.Parameters.Add(New OleDbParameter("item_desc", CType(strDesc, String)))
            cmd.Parameters.Add(New OleDbParameter("item_price", CDec(decPrice)))
            cmd.Parameters.Add(New OleDbParameter("item_category", CType(strCategory, String)))

            decTotal = decTotal + decPrice
            lblCart.Text = intCart
            Try
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                conn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            intCart = intCart + 1
            Form5.lstCart.Items.Add(String.Format("{0,-3}{1,-40}{2,-15}{3,-15}", intCart, strDesc, FormatCurrency(decPrice), strCategory))
        Next

        lblCart.Text = intCart
    End Sub
    Private Sub ClearTemp()
        radPC1.Checked = False
        radPC2.Checked = False
        radPC3.Checked = False
        radPC4.Checked = False
        txtPC.Text = Nothing

        radMB1.Checked = False
        radMB2.Checked = False
        radMB3.Checked = False
        radMB4.Checked = False
        txtMB.Text = Nothing

        radCP1.Checked = False
        radCP2.Checked = False
        radCP3.Checked = False
        radCP4.Checked = False
        txtCP.Text = Nothing

        radPS1.Checked = False
        radPS2.Checked = False
        radPS3.Checked = False
        radPS4.Checked = False
        txtPS.Text = Nothing

        radGP1.Checked = False
        radGP2.Checked = False
        radGP3.Checked = False
        radGP4.Checked = False
        txtGP.Text = Nothing

        radR1.Checked = False
        radR2.Checked = False
        radR3.Checked = False
        radR4.Checked = False
        txtR.Text = Nothing
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub
    Private Sub CartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CartToolStripMenuItem.Click
        Form5.lstCart.Items.Add(String.Format("{0,-5}{1,-38}{2,-15}", "     ", "TOTAL", FormatCurrency(decTotal)))
        Me.Hide()
        Form5.Show()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form5.lstCart.Items.Add(String.Format("{0,-3}{1,-40}{2,-15}{3,-15}", "NO", "ITEM", "PRICE", "CATEGORY"))

    End Sub

    Private Sub lblCart_Click(sender As Object, e As EventArgs) Handles lblCart.Click

    End Sub
End Class