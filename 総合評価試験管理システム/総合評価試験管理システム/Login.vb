Public Class frmGETS0001

    Private Sub f_Exit_Click(sender As Object, e As EventArgs) Handles f_Exit.Click
        Me.Close()
    End Sub

    Private Sub CheckStaffCode(sender As Object, e As EventArgs) Handles f_StaffCode.TextChanged
        f_StaffName.Text = f_StaffCode.Text
    End Sub
End Class
