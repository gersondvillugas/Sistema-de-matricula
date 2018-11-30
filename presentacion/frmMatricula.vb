
Imports System.ComponentModel

Public Class frmMatricula



    Private dt As New DataTable

    Private Sub frmMatricula_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()

        'If Me.ValidateChildren() = True And t Then


        'End If
    End Sub


    Public Sub limpiar()
        btnguardar.Visible = True
        txtidalumno.Text = ""
        txtnombre_alumno.Text = ""
        txtidinstrumento.Text = ""
        txtnombre_instrumento.Text = ""


        txtnum_documento.Text = ""
        txtpago_matricula.Text = ""
        txtidmatricula.Text = ""



    End Sub


    Private Sub mostrar()
        Try
            Dim func As New fmatriculas
            dt = func.mostrar
            datalistado.Columns.Item("eliminar").Visible = False


            If dt.Rows.Count <> 0 Then
                datalistado.DataSource = dt
                txtbuscar.Enabled = True
                datalistado.ColumnHeadersVisible = True
                inexistente.Visible = False
            Else
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
            'dv.RowFilter = cbocampo.Text + "like'" + txtbuscar.Text + "%'"
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
    End Sub



    Private Sub btnnuevo_Click(sender As Object, e As EventArgs)
        Call limpiar()
        Call mostrar()

    End Sub





    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If Me.ValidateChildren = True And cbtipo_documento.Text <> "" And txtpago_matricula.Text <> "" Then
            Try
                Dim dts As New vmatricula
                Dim func As New fmatriculas
                'pista1

                dts.gidalumno = txtidalumno.Text
                '
                dts.gnombre_alumno = txtnombre_alumno.Text
                dts.gidmateria = txtidinstrumento.Text
                '
                dts.gnombre_materia = txtnombre_instrumento.Text

                dts.gf_matricula = txtfecha.Value
                dts.gtipo_documento = cbtipo_documento.Text
                dts.gnumero_documento = txtnum_documento.Text
                dts.gpago_matricula = txtpago_matricula.Text





                If func.insertar(dts) Then
                    MessageBox.Show("Matricula fue registrado correctamente", "guardando datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("Matricula  no fue registrado ingrese de nuevo", "guardando datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        txtidmatricula.Text = datalistado.SelectedCells.Item(8).Value
        txtidalumno.Text = datalistado.SelectedCells.Item(1).Value
        'mo
        'txtnombre_alumno.Text = datalistado.SelectedCells.Item(2).Value
        'fecha->3 numero-de-dni->4 nose->2
        'txtidinstrumento.Text = datalistado.SelectedCells.Item(6).Value
       ' txtnombre_instrumento.Text = datalistado.SelectedCells.Item(5).Value
        'txtfecha.Text = datalistado.SelectedCells.Item(6).Value
        cbtipo_documento.Text = datalistado.SelectedCells.Item(9).Value

       'txtnum_documento.Text = datalistado.SelectedCells.Item(8).Value
        txtpago_matricula.Text = datalistado.SelectedCells.Item(7).Value







        btnguardar.Visible = False

    End Sub

    'Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
    '    Dim resul As DialogResult
    '    resul = MessageBox.Show("realmente deseas editar los datos del producto ?", "modificando registro ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)


    '    If resul = DialogResult Then



    '        If Me.ValidateChildren = True And txtnombre.Text <> "" And txtdescripcion.Text <> "" And txtstock.Text <> "" And txtprecio_compra.Text <> "" And txtprecio_venta.Text <> "" And txtidproducto.Text <> "" Then
    '            Try

    '                Dim dts As New vproducto
    '                Dim func As New fproducto


    '                dts.gidproducto = txtidproducto.Text
    '                dts.gnombre = txtnombre.Text
    '                dts.gidcategoria = txtidcategoria.Text
    '                dts.gdescripcion = txtdescripcion.Text
    '                dts.gstock = txtstock.Text
    '                dts.gprecio_compra = txtprecio_compra.Text
    '                dts.gprecio_venta = txtprecio_venta.Text
    '                dts.gfecha_vencimiento = fecha_vencimiento1.Value


    '                Dim ms As New IO.MemoryStream()
    '                If Not imagen.Image Is Nothing Then
    '                    imagen.Image.Save(ms, imagen.Image.RawFormat)
    '                Else
    '                    imagen.Image = My.Resources.descarga1
    '                    imagen.Image.Save(ms, imagen.Image.RawFormat)
    '                End If
    '                dts.gimagen = ms.GetBuffer


    '                If func.editar(dts) Then
    '                    MessageBox.Show("producto fue modificado correctamente", "modificando registros ", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                    mostrar()
    '                    limpiar()
    '                Else
    '                    MessageBox.Show("producto  no fue modificado intente de nuevo", "modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As DialogResult
        result = MessageBox.Show("realmente quieres eliminar las matriculas seleccionados", "eliminando registros ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In datalistado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("eliminar").Value)
                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("idMatricula").Value)
                        Dim vdb As New vmatricula
                        Dim func As New fmatriculas
                        vdb.gidmatricula = onekey

                        If func.eliminar(vdb) Then
                        Else
                            MessageBox.Show("matricula no fue seleccionados", "eliminando registros ", MessageBoxButtons.OK, MessageBoxIcon.Information)


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







    'Private Sub datalistado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick

    '    If txtflag.Text = "1" Then
    '        frmdetalle_venta.txtidproducto.Text = datalistado.SelectedCells.Item(1).Value

    '        frmdetalle_venta.txtnombre_producto.Text = datalistado.SelectedCells.Item(4).Value
    '        frmdetalle_venta.txtstock.Text = datalistado.SelectedCells.Item(6).Value

    '        frmdetalle_venta.txtprecioxu.Text = datalistado.SelectedCells.Item(8).Value



    '        Me.Close()


    '    End If
    'End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        Call buscar()

    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs)

        frmclases.Show()

    End Sub






    Private Sub btnbuscar_materia_Click(sender As Object, e As EventArgs) Handles btnbuscar_materia.Click
        frmmateriass.txtflag.Text = "1"
        frmmateriass.ShowDialog()
        frminicio.smdimaterias.Enabled = True

    End Sub


    Private Sub txtpago_matricula_Validating(sender As Object, e As CancelEventArgs) Handles txtpago_matricula.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "ingrese el pago de la matricula, Porfavor")
        End If
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click


        cargar_detalle()
        frmclases.limpiar()
        frminicio.mdiclases.Enabled = True



    End Sub

    Private Sub cargar_detalle()
        'bien
        frmclases.txtid_alumno.Text = datalistado.SelectedCells.Item(1).Value
        '           
        frmclases.txtnombre_alumno.Text = datalistado.SelectedCells.Item(2).Value
        'id materia
        frmclases.txtid_materia.Text = datalistado.SelectedCells.Item(3).Value
        '
        frmclases.txtnombre_materia.Text = datalistado.SelectedCells.Item(4).Value
        'bien 
        frmclases.txtidmatricula.Text = datalistado.SelectedCells.Item(8).Value
        '  frmclases.txtfecha_matricula.Text = datalistado.SelectedCells.Item(6).Value


        frmclases.ShowDialog()
        Hide()

    End Sub

    Private Sub dlg_Enter(sender As Object, e As EventArgs) Handles dlg.Enter

    End Sub


    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class