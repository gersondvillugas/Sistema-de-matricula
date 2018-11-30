
Imports System.Data.SqlClient
Public Class fasistencia_a

    Inherits conexion
    Dim cmd As New SqlCommand  'para enviar peticiones ala base de datos


    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_asistencia_a")
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




    Public Function insertar(ByVal dts As vasistencia_a) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_asistencia_a")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn



            'cmd.Parameters.AddWithValue("idas)
            cmd.Parameters.AddWithValue("@idalumno", dts.gidalumno)
            cmd.Parameters.AddWithValue("@nombre_alumno", dts.gnombre_alumno)
            cmd.Parameters.AddWithValue("@idmateria", dts.gidmateria)
            cmd.Parameters.AddWithValue("@nombre_materia", dts.gnombre_materia)

            cmd.Parameters.AddWithValue("@numero_asistencia", dts.gnum_asistencia)
            cmd.Parameters.AddWithValue("@fecha_asistencia ", dts.gfecha_asistencia)
            cmd.Parameters.AddWithValue("@asistencia", dts.gasistencia)






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


    Public Function editar(ByVal dts As vasistencia_a) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_asistencia_a")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idAsistencia", dts.gidasistencia)
            cmd.Parameters.AddWithValue("@idmateria", dts.gidmateria)
            cmd.Parameters.AddWithValue("@nombre_materia", dts.gnombre_materia)

            cmd.Parameters.AddWithValue("@idalumno", dts.gidalumno)
            cmd.Parameters.AddWithValue("@nombre_alumno", dts.gnombre_alumno)

            cmd.Parameters.AddWithValue("@numero_asistencia", dts.gnum_asistencia)
            cmd.Parameters.AddWithValue("@fecha_asistencia", dts.gfecha_asistencia)
            cmd.Parameters.AddWithValue("@asistencia", dts.gasistencia)



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



    Public Function eliminar(ByVal dts As vasistencia_a) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_asistencia_a")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@idAsistencia", SqlDbType.NVarChar, 50).Value = dts.gidasistencia

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
