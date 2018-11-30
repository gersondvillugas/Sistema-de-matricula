
Imports System.Data.SqlClient

Public Class falumno


    Inherits conexion
    Dim cmd As New SqlCommand  'para enviar peticiones ala base de datos


    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_alumnos")
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

    Public Function insertar(ByVal dts As valumno) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_alumno")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn


           cmd.Parameters.AddWithValue("@iddocente", dts.giddocente)
            cmd.Parameters.AddWithValue("@nombres", dts.gnombre)
            cmd.Parameters.AddWithValue("@apellidos", dts.gapellido)
            cmd.Parameters.AddWithValue("@dni", dts.gdni)
            cmd.Parameters.AddWithValue("@telefono", dts.gtelefono)

            cmd.Parameters.AddWithValue("@nivel", dts.gnivel)
           'cmd.Parameters.AddWithValue("@fecha_vencimiento ", dts.gfecha_vencimiento)
            'cmd.Parameters.AddWithValue("@imagen", dts.gimagen)



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


    Public Function editar(ByVal dts As valumno) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_alumnos")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idalumno", dts.gidalumno)
            cmd.Parameters.AddWithValue("@iddocente", dts.giddocente)
            cmd.Parameters.AddWithValue("@nombres", dts.gnombre)
            cmd.Parameters.AddWithValue("@apellidos", dts.gapellido)
            cmd.Parameters.AddWithValue("@dni", dts.gdni)
            cmd.Parameters.AddWithValue("@telefono ", dts.gtelefono)

            cmd.Parameters.AddWithValue("@nivel", dts.gnivel)
            cmd.Parameters.AddWithValue("@fecha_vencimiento ", dts.gfecha_vencimiento)
            ' cmd.Parameters.AddWithValue("@imagen", dts.gimagen)

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



    Public Function eliminar(ByVal dts As valumno) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_alumno")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@idalumno", SqlDbType.NVarChar, 50).Value = dts.gidalumno

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
