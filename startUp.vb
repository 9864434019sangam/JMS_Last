Public Class startUp
    Private Sub startUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.pbar.Value = pbar.Value + 1
        If pbar.Value >= 100 Then
            Timer1.Stop()
            Form1.Show()
            Me.Hide()

        End If
    End Sub
End Class