Public Class Form12
    Private Sub CustomerBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CustomerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LoginInfoDataSet)

    End Sub

    Private Sub CustomerBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles CustomerBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CustomerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LoginInfoDataSet)

    End Sub

    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LoginInfoDataSet.customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.LoginInfoDataSet.customer)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs)
        CustomerBindingSource.AddNew()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        CustomerBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(LoginInfoDataSet)
        MessageBox.Show("Information Saved")
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        CustomerBindingSource.RemoveCurrent()
        TableAdapterManager.UpdateAll(LoginInfoDataSet)
        MessageBox.Show("Information Removed")
    End Sub

    Private Sub btnUpD_Click(sender As Object, e As EventArgs) Handles btnUpD.Click
        Me.Validate()
        CustomerBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(LoginInfoDataSet)
        MessageBox.Show("Information Updated")
    End Sub

    Private Sub btnSea_Click(sender As Object, e As EventArgs) Handles btnSea.Click
        End
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Hide()
        Form3.Show()
        Form3.txtPassword.Clear()
        Form3.txtUsername.Clear()
        Form3.radAdmin.Checked = False
        Form3.radCustomer.Checked = False

    End Sub
End Class