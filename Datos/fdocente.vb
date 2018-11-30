Imports System.Data.SqlClient


Public Class fdocente

    Inherits conexion
    Dim cmd As SqlCommand  'para enviar peticiones ala base de datos


    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_docente")
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

    Public Function insertar(ByVal dts As vdocente) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_docentes")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn


            cmd.Parameters.AddWithValue("@nombres", dts.gnombres)
            cmd.Parameters.AddWithValue("@apellidos", dts.gapellidos)
            cmd.Parameters.AddWithValue("@especialidad", dts.gespecialidad)
            cmd.Parameters.AddWithValue("@telefono", dts.gtelefono)
            cmd.Parameters.AddWithValue("@dni", dts.gdni)


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


    Public Function editar(ByVal dts As vdocente) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_docentes")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@iddocente", dts.giddocente)
            cmd.Parameters.AddWithValue("@nombres", dts.gnombres)
            cmd.Parameters.AddWithValue("@apellidos", dts.gapellidos)
            cmd.Parameters.AddWithValue("@especialidad", dts.gespecialidad)
            cmd.Parameters.AddWithValue("@telefono", dts.gtelefono)
            cmd.Parameters.AddWithValue("@dni", dts.gdni)


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



    Public Function eliminar(ByVal dts As vdocente) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_docentes")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@iddocente", SqlDbType.NVarChar, 50).Value = dts.giddocente

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
