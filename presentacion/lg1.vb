Public Class lg1
    Private Sub lg1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Public Sub limpiar()
        txtnombre.Clear()
        txtapellido.Clear()
        txtdireccion.Clear()
        txtdni.Clear()
        txtlogin.Clear()
        txtpassword.Clear()
        txttelefono.Clear()

        txtnombre.Focus()






    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        login.Show()
        Hide()
    End Sub

    Private Sub btnenviar_Click(sender As Object, e As EventArgs) Handles btnenviar.Click
        If Me.ValidateChildren = True And txtnombre.Text <> "" And txtapellido.Text <> "" And txtdireccion.Text <> "" And txttelefono.Text <> "" And txtdni.Text <> "" And txtlogin.Text <> " " And txtpassword.Text <> " " Then
            Try
                Dim dts As New vusuario
                Dim func As New fusuario
                dts.gnombre = txtnombre.Text
                dts.gapellido = txtapellido.Text
                dts.gdni = txtdni.Text

                dts.gdireccion = txtdireccion.Text
                dts.gtelefono = txttelefono.Text
                dts.glogin = txtlogin.Text
                dts.gpassword = txtpassword.Text
                dts.gacceso = cboacceso.Text


                If func.insertar(dts) Then
                    MessageBox.Show("Usuario registrado correctamente", "guardando datos", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    limpiar()
                Else
                    MessageBox.Show("Usuario no fue registrado ingrese de nuevo", "guardando datos", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    limpiar()

                End If



            Catch ex As Exception
                MsgBox(ex.Message)

            End Try


        Else
            MessageBox.Show("falta ingresar algunos datos", "guardando datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End

    End Sub

    Private Sub txtnombre_TextChanged(sender As Object, e As EventArgs) Handles txtnombre.TextChanged

    End Sub
End Class