Imports System.Data.SqlClient
Public Class fclases


    Inherits conexion
    Dim cmd As New SqlCommand  'para enviar peticiones ala base de datos


    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_clase")
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

    Public Function insertar(ByVal dts As vclases) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_clase")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn


            cmd.Parameters.AddWithValue("@idalumno", dts.gidalumno)
            cmd.Parameters.AddWithValue("@nombre_alumno", dts.gnombre_alumno)
            cmd.Parameters.AddWithValue("@idmateria", dts.gidmateria)
            cmd.Parameters.AddWithValue("@nombre_materia", dts.gnombre_materia)
            cmd.Parameters.AddWithValue("@idmatricula", dts.gidmatricula)
            cmd.Parameters.AddWithValue("@tipoclases", dts.gtipoclases)
            cmd.Parameters.AddWithValue("@por", dts.gpor)
            cmd.Parameters.AddWithValue("@pago", dts.gpagomensual)



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


    'Public Function editar(ByVal dts As vclases) As Boolean
    '    Try
    '        conectado()
    '        cmd = New SqlCommand("editar_clases")
    '        cmd.CommandType = CommandType.StoredProcedure
    '        cmd.Connection = cnn

    '        cmd.Parameters.AddWithValue("@idclases", dts.gidclases)
    '        cmd.Parameters.AddWithValue("@idalumno", dts.gidalumno)
    '        cmd.Parameters.AddWithValue("@idmateria", dts.gidmateria)
    '        cmd.Parameters.AddWithValue("@idmatricula", dts.gidmatricula)
    '        cmd.Parameters.AddWithValue("@tipoclases", dts.gtipoclases)
    '        cmd.Parameters.AddWithValue("@por", dts.gpor)
    '          cmd.Parameters.AddWithValue("@pago", dts.gpagomensual)


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



    Public Function eliminar(ByVal dts As vclases) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_clases")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@idclases", SqlDbType.NVarChar, 50).Value = dts.gidclases

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
End Class
