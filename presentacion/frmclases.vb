Public Class frmclases




    Private dt As New DataTable




    Private Sub CBDIAOMES_SelectedValueChanged(sender As Object, e As EventArgs) Handles CBDIAOMES.SelectedValueChanged
        Dim index As Integer
        index = CBDIAOMES.SelectedIndex





        Select Case index
            Case 0
                txth.Enabled = True
                txthoras.Enabled = True

                txtdias.Enabled = True
                txtd.Enabled = False


                txtdias.Clear()
                txtd.Clear()
                txttotal_mes.Clear()


            Case 1


                txtdias.Enabled = True
                txtd.Enabled = True
                txth.Enabled = False
                txthoras.Enabled = False




                txtdias.Clear()
                txthoras.Clear()
                txth.Clear()


                Return

        End Select



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim index As Integer
        index = CBDIAOMES.SelectedIndex






        Select Case index

            Case 0
                txth.Enabled = True
                txthoras.Enabled = True

                txtdias.Enabled = True
                txtd.Enabled = False

                If Me.ValidateChildren = True And txtdias.Text <> "" And txthoras.Text <> "" And txth.Text <> "" Then

                    Dim total As Integer
                    total = (txthoras.Text * txth.Text) * txtdias.Text
                    txttotal_mes.Text = total
                Else

                    MessageBox.Show("falta ingresar algunos datos", "guardando datos", MessageBoxButtons.OK, MessageBoxIcon.Information)


                End If

            Case 1


                txtdias.Enabled = True
                txtd.Enabled = True
                txth.Enabled = False
                txthoras.Enabled = False
                If Me.ValidateChildren = True And txtdias.Text <> "" And txtd.Text <> "" Then

                    Dim total_m As Integer
                    total_m = (txtdias.Text * txtd.Text)
                    txttotal_mes.Text = total_m



                Else
                    MessageBox.Show("falta ingresar algunos datos", "guardando datos", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If


        End Select
    End Sub

    Private Sub frmclases_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
        ' ocultar_columnas()
        txtdias.Enabled = False
        txtd.Enabled = False
        txth.Enabled = False
        txthoras.Enabled = False

    End Sub



    Public Sub limpiar()
        btnguardar.Visible = True

        txtdias.Text = ""
        txthoras.Text = ""
        txtd.Text = ""
        txth.Text = ""
        ' txtidalumno.Text = ""
        txtid_alumno.Text = ""
        txtnombre_alumno.Text = ""
        ' txtidinstrumento.Text = ""
        txtid_materia.Text = ""
        txtnombre_materia.Text = ""
        txttotal_mes.Text = ""



    End Sub


    Private Sub mostrar()
        Try
            Dim func As New fclases
            dt = func.mostrar
            datalistado.Columns.Item("eliminar").Visible = False


            If dt.Rows.Count <> 0 Then
                datalistado.DataSource = dt
                'modificado
                txtbuscar.Enabled = True
                datalistado.ColumnHeadersVisible = True
                inexistente.Visible = False
            Else
                'modificado
                datalistado.DataSource = Nothing
                txtbuscar.Enabled = False
                datalistado.ColumnHeadersVisible = False
                inexistente.Visible = True



            End If

        Catch ex As Exception
            MsgBox(ex.Message)


        End Try



        buscar()



    End Sub


    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))
            'dv.RowFilter = cbocampo.Text + " like' " + txtbuscar.Text + "%'"


            dv.RowFilter = String.Format(cbocampo.Text) & " like '%" & txtbuscar.Text & "%'"

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
        datalistado.Columns(1).Visible = False
        datalistado.Columns(2).Visible = False
        datalistado.Columns(4).Visible = False
        datalistado.Columns(6).Visible = False
    End Sub






    Private Sub btnuevo_Click(sender As Object, e As EventArgs)
        Call limpiar()
        Call mostrar()
    End Sub

    Private Sub btnguardar_Click_1(sender As Object, e As EventArgs) Handles btnguardar.Click

        If Me.ValidateChildren = True And txtid_alumno.Text <> "" And txtnombre_alumno.Text <> "" And txtid_materia.Text <> "" And txtnombre_materia.Text <> "" And txtidmatricula.Text <> "" Then

            If Me.ValidateChildren = True And CBDIAOMES.SelectedIndex = 0 Then
                If Me.ValidateChildren = True And txtdias.Text <> "" And txthoras.Text <> "" And txth.Text <> "" And txttotal_mes.Text <> "" Then

                    Try
                        Dim dts As New vclases
                        Dim func As New fclases

                        dts.gidalumno = txtid_alumno.Text
                        dts.gnombre_alumno = txtnombre_alumno.Text
                        dts.gidmateria = txtid_materia.Text
                        dts.gnombre_materia = txtnombre_materia.Text
                        dts.gidmatricula = txtidmatricula.Text
                        dts.gtipoclases = ComboBox1.Text
                        dts.gpor = CBDIAOMES.Text
                        dts.gpagomensual = txttotal_mes.Text



                        If func.insertar(dts) Then


                            MessageBox.Show("Clase fue añadido corectamente ala venta ", "guardando datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            mostrar()
                            limpiar()
                            frminicio.mdiasistencias.Enabled = True



                        Else
                            MessageBox.Show("Clase no fue añadido corectamente ala venta", "guardando datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            mostrar()
                            limpiar()

                        End If



                    Catch ex As Exception
                        MsgBox(ex.Message)

                    End Try

                Else
                    MessageBox.Show("falta ingresar algunos datos", "guardando datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If



            ElseIf Me.ValidateChildren = True And CBDIAOMES.SelectedIndex = 1 Then
                If Me.ValidateChildren = True And txtdias.Text <> "" And txtd.Text <> "" And txttotal_mes.Text <> "" Then

                    Try
                        Dim dts As New vclases
                        Dim func As New fclases

                        dts.gidalumno = txtid_alumno.Text
                        '
                        dts.gnombre_alumno = txtnombre_alumno.Text


                        dts.gidmateria = txtid_materia.Text
                        '
                        dts.gnombre_materia = txtnombre_materia.Text

                        dts.gidmatricula = txtidmatricula.Text
                        dts.gtipoclases = ComboBox1.Text
                        dts.gpor = CBDIAOMES.Text
                        dts.gpagomensual = txttotal_mes.Text



                        If func.insertar(dts) Then


                            MessageBox.Show("Clase fue añadido corectamente ala venta ", "guardando datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            mostrar()
                            limpiar()
                            frminicio.mdiasistencias.Enabled = True


                        Else
                            MessageBox.Show("Clase no fue añadido corectamente ala venta", "guardando datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            mostrar()
                            limpiar()

                        End If



                    Catch ex As Exception
                        MsgBox(ex.Message)

                    End Try


                Else
                    MessageBox.Show("falta ingresar algunos datos", "guardando datos", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If
            Else

                MessageBox.Show("falta ingresar algunos datos", "guardando datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If


        Else
            MessageBox.Show("falta ingresar algunos datos", "guardando datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        buscar()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim result As DialogResult
        result = MessageBox.Show("realmente quieres eliminar las clases seleccionadas", "eliminando registros ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In datalistado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("eliminar").Value)
                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("IdClase").Value)
                        Dim vdb As New vclases
                        Dim func As New fclases
                        vdb.gidclases = onekey

                        If func.eliminar(vdb) Then
                        Else
                            MessageBox.Show(" clase  no fue seleccionados", "eliminando registros ", MessageBoxButtons.OK, MessageBoxIcon.Information)


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

    Private Sub datalistado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellClick
        txtid_alumno.Text = datalistado.SelectedCells.Item(2).Value
        txtnombre_alumno.Text = datalistado.SelectedCells.Item(3).Value
        txtid_materia.Text = datalistado.SelectedCells.Item(4).Value
        txtnombre_materia.Text = datalistado.SelectedCells.Item(5).Value
        txtidmatricula.Text = datalistado.SelectedCells.Item(6).Value
        ' txtfecha_matricula.Text = datalistado.SelectedCells.Item(7).Value

        ComboBox1.Text = datalistado.SelectedCells.Item(7).Value

        CBDIAOMES.Text = datalistado.SelectedCells.Item(8).Value
        ' txttotal_mes.Text = datalistado.SelectedCells.Item(10).Value

        txtdias.Enabled = False
        txtd.Enabled = False
        txth.Enabled = False
        txthoras.Enabled = False
        txttotal_mes.Enabled = False
        Button1.Enabled = False




    End Sub

    Private Sub datalistado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick

        frmAsistencia_A.txtid_alumno.Text = datalistado.SelectedCells.Item(2).Value
        frmAsistencia_A.txtnombre_alumno.Text = datalistado.SelectedCells.Item(3).Value

        frmAsistencia_A.txtid_materia.Text = datalistado.SelectedCells.Item(4).Value
        frmAsistencia_A.txtnombre_materia.Text = datalistado.SelectedCells.Item(5).Value

        frmAsistencia_A.btnguardar.Visible = True
        ' frmAsistencia_A.Show()
        frminicio.mdiasistencias.Enabled = True

        Me.Close()




    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub ComboBox1_Click(sender As Object, e As EventArgs) Handles ComboBox1.Click


    End Sub

    Private Sub ComboBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedValueChanged
        Dim index As Integer
        index = ComboBox1.SelectedIndex





        Select Case index
            Case 0
                txth.Enabled = False
                txthoras.Enabled = False

                txtdias.Enabled = False
                txtd.Enabled = False




            Case 1


                txtdias.Enabled = False
                txtd.Enabled = False
                txth.Enabled = False
                txthoras.Enabled = False






        End Select
    End Sub

    Private Sub txtid_alumno_TextChanged(sender As Object, e As EventArgs) Handles txtid_alumno.TextChanged

    End Sub

    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub txtfecha_matricula_ValueChanged(sender As Object, e As EventArgs) Handles txtfecha_matricula.ValueChanged

    End Sub

    Private Sub txtnombre_alumno_TextChanged(sender As Object, e As EventArgs) Handles txtnombre_alumno.TextChanged

    End Sub
    Private Sub txtnombre_materia_TextChanged(sender As Object, e As EventArgs) Handles txtid_materia.TextChanged

    End Sub


    Private Sub txttotal_mes_TextChanged(sender As Object, e As EventArgs) Handles txttotal_mes.TextChanged

    End Sub
End Class