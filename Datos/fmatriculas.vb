Imports System.Data.SqlClient

Public Class fmatriculas

    Inherits conexion
    Dim cmd As New SqlCommand  'para enviar peticiones ala base de datos


    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_matricula")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing




            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing

        Finally
            desconectado()





        End Try

    End Function

    Public Function insertar(ByVal dts As vmatricula) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_matriculas")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn


            cmd.Parameters.AddWithValue("@idalumno", dts.gidalumno)
            'add
            cmd.Parameters.AddWithValue("@nombre_alumno", dts.gnombre_alumno)

            cmd.Parameters.AddWithValue("@idmateria", dts.gidmateria)
            'add
            cmd.Parameters.AddWithValue("@nombre_materia", dts.gnombre_materia)

            cmd.Parameters.AddWithValue("@fecha_matricula", dts.gf_matricula)
            cmd.Parameters.AddWithValue("@tipo_documento", dts.gtipo_documento)
            cmd.Parameters.AddWithValue("@numero_documento", dts.gnumero_documento)

            cmd.Parameters.AddWithValue("@pago_matricula", dts.gpago_matricula)


            If cmd.ExecuteNonQuery Then
                Return True

            End If
            Return False

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()

        End Try

    End Function


    Public Function editar(ByVal dts As vmatricula) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_matricula")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idmatricula", dts.gidmatricula)

            cmd.Parameters.AddWithValue("@idalumno", dts.gidalumno)
            'add
            cmd.Parameters.AddWithValue("@nombre_alumno", dts.gnombre_alumno)

            cmd.Parameters.AddWithValue("@idmateria", dts.gidmateria)

            'add
            cmd.Parameters.AddWithValue("@nombre_materia", dts.gnombre_materia)

            cmd.Parameters.AddWithValue("@fecha_matricula", dts.gf_matricula)
            cmd.Parameters.AddWithValue("@tipo_documento", dts.gtipo_documento)
            cmd.Parameters.AddWithValue("@numero_documento", dts.gnumero_documento)

            cmd.Parameters.AddWithValue("@pago_matricula", dts.gpago_matricula)


            If cmd.ExecuteNonQuery Then
                Return True

            End If
            Return False

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()

        End Try

    End Function



    Public Function eliminar(ByVal dts As vmatricula) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_matricula")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@idmatricula", SqlDbType.NVarChar, 50).Value = dts.gidmatricula

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

    End Function






    'Public Function aumentar_stock(ByVal dts As vmatricula) As Boolean
    '    Try
    '        conectado()
    '        cmd = New SqlCommand("aumentar_stock")
    '        cmd.CommandType = CommandType.StoredProcedure
    '        cmd.Connection = cnn

    '        cmd.Parameters.AddWithValue("@idproducto", dts.gidproducto)

    '        cmd.Parameters.AddWithValue("@cantidad", dts.gcantidad)


    '        If cmd.ExecuteNonQuery Then
    '            Return True

    '        End If
    '        Return False

    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '        Return False
    '    Finally
    '        desconectado()

    '    End Try

    'End Function



    'Public Function disminuir_stock(ByVal dts As vmatricula) As Boolean
    '    Try
    '        conectado()
    '        cmd = New SqlCommand("disminuir_stock")
    '        cmd.CommandType = CommandType.StoredProcedure
    '        cmd.Connection = cnn

    '        cmd.Parameters.AddWithValue("@idproducto", dts.gidproducto)

    '        cmd.Parameters.AddWithValue("@cantidad", dts.gcantidad)


    '        If cmd.ExecuteNonQuery Then
    '            Return True

    '        End If
    '        Return False

    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '        Return False
    '    Finally
    '        desconectado()

    '    End Try

    'End Function


End Class
