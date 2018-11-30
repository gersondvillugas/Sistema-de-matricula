﻿Imports System.ComponentModel

Public Class frmDocentes

    Private dt As New DataTable

    Private Sub frmDocentes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtidcliente.ReadOnly = True
        txtnombre.Focus()




        mostrar()

    End Sub



    Public Sub limpiar()
        btnguardar.Visible = True
        btneditar.Visible = False
        txtnombre.Text = ""
        txtapellidos.Text = ""
        txtdireccion.Text = ""
        txttelefono.Text = ""
        txtdni.Text = ""
        txtidcliente.Text = ""
        txtnombre.Focus()



    End Sub


    Private Sub mostrar()
        Try
            Dim func As New fdocente
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

        btnnuevo.Visible = True
        btneditar.Visible = False
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

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()

    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        Call limpiar()
        Call mostrar()

    End Sub


    Private Sub txtnombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtnombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "ingrese el nombre del docente porfavor")
        End If
    End Sub




    Private Sub txtdireccion_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtdireccion.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "ingrese la especialidad del docente porfavor")
        End If
    End Sub

    Private Sub txttelefono_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txttelefono.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "ingrese el telefono del docente porfavor")
        End If
    End Sub



    Private Sub txtdni_Validating(sender As Object, e As CancelEventArgs) Handles txtdni.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "ingrese el dni del docente porfavor")
        End If
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If Me.ValidateChildren = True And txtnombre.Text <> "" And txtapellidos.Text <> "" And txtdireccion.Text <> "" And txttelefono.Text <> "" And txtdni.Text <> "" Then
            Try
                Dim dts As New vdocente
                Dim func As New fdocente
                dts.gnombres = txtnombre.Text
                dts.gapellidos = txtapellidos.Text
                dts.gespecialidad = txtdireccion.Text
                dts.gtelefono = txttelefono.Text
                dts.gdni = txtdni.Text

                If func.insertar(dts) Then
                    MessageBox.Show("docente registrado correctamente", "guardando datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("docente no fue registrado ingrese de nuevo", "guardando datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        txtidcliente.Text = datalistado.SelectedCells.Item(1).Value
        txtnombre.Text = datalistado.SelectedCells.Item(2).Value
        txtapellidos.Text = datalistado.SelectedCells.Item(3).Value
        txtdireccion.Text = datalistado.SelectedCells.Item(4).Value
        txttelefono.Text = datalistado.SelectedCells.Item(5).Value

        txtdni.Text = datalistado.SelectedCells.Item(6).Value


        btneditar.Visible = True
        btnguardar.Visible = False

    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        Dim resul As DialogResult
        resul = MessageBox.Show("realmente deseas editar los datos del docente ?", "modificando registro ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)


        If resul = DialogResult.OK Then




            If Me.ValidateChildren = True And txtnombre.Text <> "" And txtapellidos.Text <> "" And txtdireccion.Text <> "" And txttelefono.Text <> "" And txtdni.Text <> "" And txtidcliente.Text <> "" Then
                Try
                    Dim dts As New vdocente
                    Dim func As New fdocente

                    dts.giddocente = txtidcliente.Text
                    dts.gnombres = txtnombre.Text
                    dts.gapellidos = txtapellidos.Text
                    dts.gespecialidad = txtdireccion.Text
                    dts.gtelefono = txttelefono.Text
                    dts.gdni = txtdni.Text

                    If func.editar(dts) Then
                        MessageBox.Show("docente modificado correctamente", "modificando registros ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                    Else
                        MessageBox.Show("docente no fue modificado intente de nuevo", "modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As DialogResult
        result = MessageBox.Show("realmente quieres eliminar los docentes seleccionados", "eliminando registros ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In datalistado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("eliminar").Value)
                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("idDocente").Value)
                        Dim vdb As New vdocente
                        Dim func As New fdocente
                        vdb.giddocente = onekey

                        If func.eliminar(vdb) Then
                        Else
                            MessageBox.Show(" docentes no fue seleccionados", "eliminando registros ", MessageBoxButtons.OK, MessageBoxIcon.Information)


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

    Private Sub datalistado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick


        If txtflag.Text = "1" Then
            frmAlumnos.txtiddocente.Text = datalistado.SelectedCells.Item(1).Value
            frmAlumnos.txtnombre_docente.Text = datalistado.SelectedCells.Item(2).Value

            Me.Close()

        End If
    End Sub

    Private Sub txtapellidos_Validating(sender As Object, e As CancelEventArgs) Handles txtapellidos.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "ingrese el apellidos del docente porfavor")
        End If
    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        Call buscar()

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class