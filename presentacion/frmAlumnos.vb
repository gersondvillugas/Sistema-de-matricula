Public Class frmAlumnos
    Private dt As New DataTable



    Public Sub limpiar()
        btnguardar.Visible = True
        btneditar.Visible = False
        txtnombre.Text = ""
        txtnivel.Text = ""
        txtapellido.Text = ""
        txtdni.Text = ""
        txttelefono.Text = ""
        txtidalumno.Text = ""

        imagen.Image = Nothing
        imagen.BackgroundImage = My.Resources.descarga
        imagen.SizeMode = PictureBoxSizeMode.StretchImage

    End Sub


    Private Sub ver()
        Try
            Dim func As New falumno
            dt = func.mostrar
            listado.Columns.Item("eliminar").Visible = False


            If dt.Rows.Count <> 0 Then
                listado.DataSource = dt
                txtbuscar.Enabled = True
                listado.ColumnHeadersVisible = True
                inexistente.Visible = False


            Else
                listado.DataSource = Nothing
                txtbuscar.Enabled = False
                listado.ColumnHeadersVisible = False
                inexistente.Visible = True



            End If

        Catch ex As Exception
            MsgBox(ex.Message)


        End Try

        btnnuevo.Visible = True
        btneditar.Visible = False
        buscar()



    End Sub


    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))
            'dv.RowFilter = cbocampo.Text + " like '" + txtbuscar.Text + "%'"
            dv.RowFilter = String.Format(cbocampo.Text) & " like '%" & txtbuscar.Text & "%'"

            If dv.Count <> 0 Then
                inexistente.Visible = False
                listado.DataSource = dv
                ocultar_columnas()
            Else
                inexistente.Visible = True
                listado.DataSource = Nothing



            End If


        Catch ex As Exception

            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ocultar_columnas()
        listado.Columns(1).Visible = False
        listado.Columns(2).Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()

    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        Call limpiar()
        Call ver()

    End Sub


    Private Sub txtnombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtnombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "ingrese el nombre del alumno porfavor")
        End If
    End Sub




    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If Me.ValidateChildren = True And txtnombre.Text <> "" And txtnivel.Text <> "" And txtapellido.Text <> "" And txtdni.Text <> "" And txttelefono.Text <> "" Then
            Try
                Dim dts As New valumno
                Dim func As New falumno

                dts.giddocente = txtiddocente.Text
                dts.gnombre = txtnombre.Text

                dts.gnivel = txtnivel.Text
                dts.gapellido = txtapellido.Text
                dts.gdni = txtdni.Text
                dts.gtelefono = txttelefono.Text
                dts.gfecha_vencimiento = Convert.ToDateTime(Me.fecha_vencimiento1.Value)


                Dim ms As New IO.MemoryStream()
                If Not imagen.Image Is Nothing Then
                    imagen.Image.Save(ms, imagen.Image.RawFormat)
                Else
                    imagen.Image = My.Resources.descarga1
                    imagen.Image.Save(ms, imagen.Image.RawFormat)
                End If
                dts.gimagen = ms.GetBuffer


                If func.insertar(dts) Then
                    MessageBox.Show("el alumno fue registrado correctamente", "guardando datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call ver()
                    Call limpiar()
                Else
                    MessageBox.Show("el alumno  no fue registrado ingrese de nuevo", "guardando datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Call ver()
                    Call limpiar()

                End If



            Catch ex As Exception
                MsgBox(ex.Message)

            End Try


        Else
            MessageBox.Show("falta ingresar algunos datos", "guardando datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub



    Private Sub datalistado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles listado.CellClick
        txtidalumno.Text = listado.SelectedCells.Item(1).Value
        txtiddocente.Text = listado.SelectedCells.Item(2).Value
        ' txtnombre_docente.Text = listado.SelectedCells.Item(3).Value
        txtnombre.Text = listado.SelectedCells.Item(3).Value
        txtnivel.Text = listado.SelectedCells.Item(7).Value
        txtapellido.Text = listado.SelectedCells.Item(4).Value
        txtdni.Text = listado.SelectedCells.Item(5).Value

        txttelefono.Text = listado.SelectedCells.Item(6).Value
     '  txtfecha_vencimiento.Text = listado.SelectedCells.Item(8).Value


        'imagen.BackgroundImage = Nothing
        'Dim b() As Byte = listado.SelectedCells.Item(10).Value
        'Dim ms As New IO.MemoryStream(b)
        'imagen.Image = Image.FromStream(ms)

        'magen.SizeMode = PictureBoxSizeMode.StretchImage




        btneditar.Visible = True
        btnguardar.Visible = False

    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        Dim resul As DialogResult
        resul = MessageBox.Show("realmente deseas editar los datos del alumno ?", "modificando registro ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)


        If resul = DialogResult.OK Then



            If Me.ValidateChildren = True And txtnombre.Text <> "" And txtnivel.Text <> "" And txtapellido.Text <> "" And txtdni.Text <> "" And txttelefono.Text <> "" And txtidalumno.Text <> "" Then
                Try

                    Dim dts As New valumno
                    Dim func As New falumno


                    dts.gidalumno = txtidalumno.Text
                    dts.gnombre = txtnombre.Text
                    dts.giddocente = txtiddocente.Text

                    dts.gapellido = txtapellido.Text
                    dts.gdni = txtdni.Text
                    dts.gtelefono = txttelefono.Text
                    dts.gnivel = txtnivel.Text
                    dts.gfecha_vencimiento = fecha_vencimiento1.Value


                    Dim ms As New IO.MemoryStream()
                    If Not imagen.Image Is Nothing Then
                        imagen.Image.Save(ms, imagen.Image.RawFormat)
                    Else
                        imagen.Image = My.Resources.descarga1
                        imagen.Image.Save(ms, imagen.Image.RawFormat)
                    End If
                    dts.gimagen = ms.GetBuffer


                    If func.editar(dts) Then
                        MessageBox.Show("Alumno fue modificado correctamente", "modificando registros ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Call ver()
                        limpiar()
                    Else
                        MessageBox.Show("Alumno  no fue modificado intente de nuevo", "modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        ver()
                        limpiar()

                    End If



                Catch ex As Exception
                    MsgBox(ex.Message)

                End Try


            Else
                MessageBox.Show("falta ingresar algunos datos", "modificando datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

    End Sub

    Private Sub cbeliminar_CheckedChanged(sender As Object, e As EventArgs) Handles cbeliminar.CheckedChanged


        If cbeliminar.CheckState = CheckState.Checked Then
            listado.Columns.Item("eliminar").Visible = True
        Else
            listado.Columns.Item("eliminar").Visible = False

        End If
    End Sub

    Private Sub datalistado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles listado.CellContentClick
        If e.ColumnIndex = Me.listado.Columns.Item("eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.listado.Rows(e.RowIndex).Cells("eliminar")
            chkcell.Value = Not chkcell.Value

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As DialogResult
        result = MessageBox.Show("realmente quieres eliminar los Alumnos seleccionados", "eliminando registros ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In listado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("eliminar").Value)
                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("idAlumno").Value)
                        Dim vdb As New valumno
                        Dim func As New falumno
                        vdb.gidalumno = onekey

                        If func.eliminar(vdb) Then
                        Else
                            MessageBox.Show(" Alumno  no fue seleccionados", "eliminando registros ", MessageBoxButtons.OK, MessageBoxIcon.Information)


                        End If
                    End If
                Next

                Call ver()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


        Else
            MessageBox.Show("cancelando eliminacion de registros ", "eliminando registros ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call ver()

        End If

        Call limpiar()

    End Sub



    Private Sub btncargar_Click(sender As Object, e As EventArgs) Handles btncargar.Click
        If dlgs.ShowDialog() = DialogResult.OK Then
            imagen.BackgroundImage = Nothing
            imagen.Image = New Bitmap(dlgs.FileName)
            imagen.SizeMode = PictureBoxSizeMode.StretchImage



        End If
    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        imagen.Image = Nothing
        imagen.BackgroundImage = My.Resources.descarga
        imagen.SizeMode = PictureBoxSizeMode.StretchImage

    End Sub

    Private Sub btnbuscar_categoria_Click(sender As Object, e As EventArgs) Handles btnbuscar_categoria.Click
        frmDocentes.txtflag.Text = "1"
        frmDocentes.ShowDialog()
        frminicio.smdiregistrodocentes.Enabled = True


    End Sub

    Private Sub datalistado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles listado.CellDoubleClick

        If txtflag.Text = "1" Then
            frmMatricula.txtidalumno.Text = listado.SelectedCells.Item(1).Value

            frmMatricula.txtnombre_alumno.Text = listado.SelectedCells.Item(4).Value


            frmMatricula.txtnum_documento.Text = listado.SelectedCells.Item(5).Value


            frmMatricula.txtfecha.Text = listado.SelectedCells.Item(9).Value

            frmAsistencia_A.txtid_alumno.Text = listado.SelectedCells.Item(1).Value

            frmAsistencia_A.txtnombre_alumno.Text = listado.SelectedCells.Item(4).Value


            'frmMatricula.txtnum_documento.Text = listado.SelectedCells.Item(6).Value
            frmMatricula.txtpago_matricula.Text = listado.SelectedCells.Item(8).Value

            frmAsistencia_A.btnguardar.Visible = True


            Me.Close()


        End If
    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        Call buscar()

    End Sub

    Private Sub frmAlumnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ver()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


        Call cargar_detalle()
        frminicio.mdimatriculas.Enabled = True


    End Sub
    Private Sub cargar_detalle()
        frmMatricula.txtidalumno.Text = listado.SelectedCells.Item(1).Value
        'modifique 2 x 4
        frmMatricula.txtnombre_alumno.Text = listado.SelectedCells.Item(4).Value
     '   frmMatricula.txtfecha.Text = listado.SelectedCells.Item(9).Value
        frmMatricula.txtnum_documento.Text = listado.SelectedCells.Item(6).Value

        frmMatricula.ShowDialog()
        Hide()


    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub dlg_Enter(sender As Object, e As EventArgs) Handles dlg.Enter

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub
End Class