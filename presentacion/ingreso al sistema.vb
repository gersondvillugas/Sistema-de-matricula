Public Class ingreso_al_sistema

    Dim contador As Integer

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Timer1.Enabled = True
        If contador < 100 Then
            ProgressBar1.Value = contador
            contador = contador + 1

            Label1.Text = "Se esta cargando al " & ProgressBar1.Value & "%"

        Else
            Timer1.Enabled = False
            Me.Hide()
            login.Show()

        End If
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

        ProgressBar1.Value = 0.0
        ProgressBar1.Maximum = 100.0
        Timer1.Interval = 100
        Timer1.Enabled = True


    End Sub

    Private Sub ingreso_al_sistema_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class