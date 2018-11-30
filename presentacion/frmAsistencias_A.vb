Public Class frmAsistencia_A


    Private dt As New DataTable

    Private Property asis As Integer

    Private Sub frmAsistencias_A_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
        txtnum_asistencia.Focus()


    End Sub

    Public Sub limpiar()
        btnguardar.Visible = True
        txtid_asistencia.Text = ""
        txtid_alumno.Text = ""
        txtnombre_alumno.Text = ""
        txtid_materia.Text = ""
        txtnombre_materia.Text = ""
        txtnum_asistencia.Text = " "



        txtfecha_asistencia.Text = ""
        txtestado.Text = ""
        txtnum_asistencia.Focus()





    End Sub


    Private Sub mostrar()
        Try
            Dim func As New fasistencia_a
            dt = func.mostrar
            datalistado.Columns.Item("eliminar").Visible = False


            If dt.Rows.Count <> 0 Then
                datalistado.DataSource = dt
                txtbuscar_Aistencia.Enabled = True
                datalistado.ColumnHeadersVisible = True
                inexistente.Visible = False
                ocultar_columnas()

            Else
                datalistado.DataSource = Nothing
                txtbuscar_Aistencia.Enabled = False
                datalistado.ColumnHeadersVisible = False
                inexistente.Visible = True
                ocultar_columnas()



            End If

        Catch ex As Exception
            MsgBox(ex.Message)


        End Try

        btnnuevo.Visible = True

        buscar()



    End Sub





    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))
            'dv.RowFilter = cbocampo.Text + "like'" + txtbuscar_Aistencia.Text + "%'"
            dv.RowFilter = String.Format(cbocampo.Text) & " like '%" & txtbuscar_Aistencia.Text & "%'"

            If dv.Count <> 0 Then
                inexistente.Visible = False
                datalistado.DataSource = dv
                ocultar_columnas()
            Else
                inexistente.Visible = True
                datalistado.DataSource = Nothing



            End If


        Catch ex As Exception

            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ocultar_columnas()

        datalistado.Columns(1).Visible = True
        datalistado.Columns(2).Visible = True
        datalistado.Columns(4).Visible = True
    End Sub



    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        Call limpiar()
        Call mostrar()

    End Sub





    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click

        If Me.ValidateChildren = True And txtnum_asistencia.Text <> "" Then
            Try
                Dim dtq As New vasistencia_a
                Dim func As New fasistencia_a

                'kll
                'dtq.gidasistencia = txtid_asistencia.Text
                dtq.gidalumno = txtid_alumno.Text
                dtq.gnombre_alumno = txtnombre_alumno.Text

                dtq.gidmateria = txtid_materia.Text
                dtq.gnombre_materia = txtnombre_materia.Text
                dtq.gnum_asistencia = txtnum_asistencia.Text
                dtq.gfecha_asistencia = txtfecha_asistencia.Value
                dtq.gasistencia = txtestado.Text









                If func.insertar(dtq) Then
                    MessageBox.Show("Asistencia fue registrado correctamente", "guardando datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()

                    limpiar()
                Else
                    MessageBox.Show("Asistencia  no fue registrado ingrese de nuevo", "guardando datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar()

                    limpiar()

                End If



            Catch ex As Exception
                MsgBox(ex.Message)

            End Try


        Else
            MessageBox.Show("falta ingresar algunos datos", "guardando datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub



    Private Sub datalistado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellClick
        txtid_asistencia.Text = datalistado.SelectedCells.Item(1).Value
        txtnum_asistencia.Text = datalistado.SelectedCells.Item(6).Value
        txtid_alumno.Text = datalistado.SelectedCells.Item(2).Value
        txtnombre_alumno.Text = datalistado.SelectedCells.Item(3).Value
        txtid_materia.Text = datalistado.SelectedCells.Item(4).Value
        txtnombre_materia.Text = datalistado.SelectedCells.Item(5).Value
        'si funciona
        txtestado.Text = datalistado.SelectedCells.Item(8).Value
        '
        txtfecha_asistencia.Text = datalistado.SelectedCells.Item(7).Value

        'txtid_asistencia = datalistado.SelectedCells.Item(1).Value

        'asis = datalistado.SelectedCells.Item(8).Value
        'If asis > 3 Then
        'MessageBox.Show("nesecita pagar matricula")
        'End If
        If Me.ValidateChildren = True And txtnum_asistencia.Text <> "" Then

            Dim asis As Integer
            asis = txtnum_asistencia.Text
            If asis > 3 Then
                MessageBox.Show("tiene que pagar matricula")
            End If
       


        End If



        btneditar.Visible = True
        btnguardar.Visible = False

        'btnguardar.Visible = True

   End Sub
    'MODIFIQUE
    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        Dim resul As DialogResult
        resul = MessageBox.Show("realmente deseas editar los datos de asistencia?", "modificando registro ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)


        If resul = DialogResult.OK Then


            'MessageBox.Show("ENTRE")
            If Me.ValidateChildren = True And txtid_alumno.Text <> "" And txtnombre_alumno.Text <> "" And txtid_materia.Text <> "" And txtnombre_materia.Text <> "" And txtnum_asistencia.Text <> "" And txtfecha_asistencia.Text <> "" And txtestado.Text <> "" Then
                'If Me.ValidateChildren = True And txtnum_asistencia.Text <> "" Then
                Try

                    Dim dts As New vasistencia_a
                    Dim func As New fasistencia_a


                    'MessageBox.Show("ENTRE")
                    dts.gidasistencia = txtid_asistencia.Text
                    dts.gidalumno = txtid_alumno.Text
                    dts.gnombre_alumno = txtnombre_alumno.Text

                    dts.gidmateria = txtid_materia.Text
                    dts.gnombre_materia = txtnombre_materia.Text
                    dts.gnum_asistencia = txtnum_asistencia.Text
                    dts.gfecha_asistencia = txtfecha_asistencia.Value
                    dts.gasistencia = txtestado.Text

                    If func.editar(dts) Then


                        MessageBox.Show("asistencia fue modificada correctamente", "modificando registros ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                    Else
                        MessageBox.Show("asistencia  no fue modificada correctamente", "modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        mostrar()
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
            datalistado.Columns.Item("eliminar").Visible = True
        Else
            datalistado.Columns.Item("eliminar").Visible = False

        End If
    End Sub

    Private Sub datalistado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentClick
        If e.ColumnIndex = Me.datalistado.Columns.Item("eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.datalistado.Rows(e.RowIndex).Cells("eliminar")
            chkcell.Value = Not chkcell.Value

        End If
    End Sub






    'Private Sub datalistado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick

    '    If txtflag.Text = "1" Then
    '        frmdetalle_venta.txtidproducto.Text = datalistado.SelectedCells.Item(1).Value

    '        frmdetalle_venta.txtnombre_producto.Text = datalistado.SelectedCells.Item(4).Value
    '        frmdetalle_venta.txtstock.Text = datalistado.SelectedCells.Item(6).Value

    '        frmdetalle_venta.txtprecioxu.Text = datalistado.SelectedCells.Item(8).Value



    '        Me.Close()


    '    End If
    'End Sub












    Private Sub btnbuscar_alumno_Click(sender As Object, e As EventArgs) Handles btnbuscar_alumno.Click

        frmclases.ShowDialog()
    End Sub

    Private Sub btnbuscar_materia_Click(sender As Object, e As EventArgs)
        frmmateriass.txtflag.Text = "1"
        frmmateriass.ShowDialog()
    End Sub

    Private Sub txtbuscar_Aistencia_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar_Aistencia.TextChanged
        Call buscar()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim result As DialogResult
        result = MessageBox.Show("realmente quieres eliminar la Asistencia seleccionados", "eliminando registros ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In datalistado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("eliminar").Value)
                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("idAsistencia").Value)
                        Dim vdb As New vasistencia_a
                        Dim func As New fasistencia_a
                        vdb.gidasistencia = onekey

                        If func.eliminar(vdb) Then
                        Else
                            MessageBox.Show(" Asistencia  no fue seleccionados", "eliminando registros ", MessageBoxButtons.OK, MessageBoxIcon.Information)


                        End If
                    End If
                Next

                Call mostrar()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


        Else
            MessageBox.Show("cancelando eliminacion de registros ", "eliminando registros ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call mostrar()

        End If

        Call limpiar()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As DialogResult
        result = MessageBox.Show("realmente quieres eliminar las asistencia seleccionados", "eliminando registros ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In datalistado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("eliminar").Value)
                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("idAsistencia").Value)
                        Dim vdb As New vasistencia_a
                        Dim func As New fasistencia_a
                        vdb.gidasistencia = onekey

                        If func.eliminar(vdb) Then
                        Else
                            MessageBox.Show(" asistencia no fue seleccionados", "eliminando registros ", MessageBoxButtons.OK, MessageBoxIcon.Information)


                        End If
                    End If
                Next

                Call mostrar()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


        Else
            MessageBox.Show("cancelando eliminacion de registros ", "eliminando registros ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call mostrar()

        End If

        Call limpiar()

    End Sub



    'Private Sub btneditar_Click(sender As Object, e As EventArgs)
    '    Dim resul As DialogResult
    '    resul = MessageBox.Show("realmente deseas editar los datos de la Asistencia ?", "modificando registro ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)


    '    If resul = DialogResult.OK Then



    '        If Me.ValidateChildren = True And txtnum_asistencia.Text <> "" Then
    '            Try

    '                Dim dts As New vasistencia_a
    '                Dim func As New fasistencia_a


    '                dts.gidasistencia = txtid_asistencia.Text
    '                dts.gidalumno = txtid_alumno.Text
    '                dts.gidmateria = txtid_materia.Text
    '                dts.gnum_asistencia = txtnum_asistencia.Text
    '                dts.gfecha_asistencia = txtfecha_asistencia.Value
    '                dts.gdescripcion = txtestado.Text









    '                If func.editar(dts) Then
    '                    MessageBox.Show("Asistencia fue modificado correctamente", "modificando registros ", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                    mostrar()
    '                    limpiar()
    '                Else
    '                    MessageBox.Show("Asistencia   no fue modificado intente de nuevo", "modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                    mostrar()
    '                    limpiar()

    '                End If



    '            Catch ex As Exception
    '                MsgBox(ex.Message)

    '            End Try


    '        Else
    '            MessageBox.Show("falta ingresar algunos datos", "modificando datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        End If
    '    End If

    'End Sub


    Private Sub txtid_alumno_TextChanged(sender As Object, e As EventArgs) Handles txtid_alumno.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub txtnum_asistencia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtnum_asistencia.SelectedIndexChanged

    End Sub

    Private Sub txtid_asistencia_TextChanged(sender As Object, e As EventArgs) Handles txtid_asistencia.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class