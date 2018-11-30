Imports System.Data.SqlClient


Public Class fmateria

    Inherits conexion
    Dim cmd As New SqlCommand  'para enviar peticiones ala base de datos


    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_materias")
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

    Public Function insertar(ByVal dts As vmateria) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_materias")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn


            cmd.Parameters.AddWithValue("@nombre_materias", dts.gnombre_materia)



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



    Public Function editar(ByVal dts As vmateria) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_materias")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idmateria", dts.gidmateria)
            cmd.Parameters.AddWithValue("@nombre_materias", dts.gnombre_materia)



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


    Public Function eliminar(ByVal dts As vmateria) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_materias")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@idmateria", SqlDbType.NVarChar, 50).Value = dts.gidmateria

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
