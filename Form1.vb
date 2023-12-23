Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Form1
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnregister1.Click
        Hide()
        register.Show()
    End Sub
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
End Class
