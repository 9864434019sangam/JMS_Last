Public Class register
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub CheckBox_Upass_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Upass.CheckedChanged
        If CheckBox_Upass.Checked = True Then
            txt_Upassword.UseSystemPasswordChar = False
        Else
            txt_Upassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub CheckBox_Mpass_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Mpass.CheckedChanged
        If CheckBox_Mpass.Checked = True Then
            txt_maskedpass.UseSystemPasswordChar = False
        Else
            txt_maskedpass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
        Form1.Show()
    End Sub
End Class