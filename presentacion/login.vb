Public Class login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        lg1.Show()


    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        lbhora.Text = TimeOfDay

    End Sub

    Private Sub txtusuario_TextChanged(sender As Object, e As EventArgs) Handles txtusuario.TextChanged
        '  If Len(txtusuario.Text) <> 0 Then
        'btningresar.Enabled = True



        ' Else
        'btningresar.Enabled = False
        'MsgBox("ingrese un usuario porfavor", MsgBoxStyle.Information, "aviso")

        ' End If
    End Sub

    Private Sub txtp_TextChanged(sender As Object, e As EventArgs) Handles txtp.TextChanged
        '' If Len(txtp.Text) <> 0 Then
        'btningresar.Enabled = True
        '


        ' Else
        ' btningresar.Enabled = False
        '    MsgBox("ingrese una contraseña", MsgBoxStyle.Information, "aviso")

        ' End If
    End Sub

    Private Sub btningresar_Click(sender As Object, e As EventArgs) Handles btningresar.Click


        Try

            Dim dts As New vusuario
            Dim func As New fusuario

            dts.glogin = txtusuario.Text
            dts.gpassword = txtp.Text



            If func.validar_usuario(dts) = True Then
                frminicio.Show()
                Me.Hide()
            Else
                MsgBox("ingrese nuevamente sus datos correctos ", MsgBoxStyle.Information, "acceso denegado al sistema ")
                txtp.Clear()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        'Module1.agregarusuario = txtusuario.Text



        'Me.Hide()
        'frminicio.Show()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbhora.Text = TimeOfDay


    End Sub


End Class