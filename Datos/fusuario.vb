
Imports System.Data.SqlClient


Public Class fusuario


    Inherits conexion
    Dim cmd As New SqlCommand




    Public Function validar_usuario(ByVal dts As vusuario)
        Try
            conectado()
            cmd = New SqlCommand("validar_usuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@login", dts.glogin)
            cmd.Parameters.AddWithValue("@password", dts.gpassword)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader

            If dr.HasRows = True Then
                Return True
            Else
                Return False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()



        End Try

    End Function




    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_usuarios")
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

    Public Function insertar(ByVal dts As vusuario) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_usuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn


            cmd.Parameters.AddWithValue("@nombre_usuario", dts.gnombre)
            cmd.Parameters.AddWithValue("@apellido_usuario", dts.gapellido)
            cmd.Parameters.AddWithValue("@dni_usuario", dts.gdni)
            cmd.Parameters.AddWithValue("@direccion_usuario", dts.gdireccion)
            cmd.Parameters.AddWithValue("@telefono_usuario", dts.gtelefono)
            cmd.Parameters.AddWithValue("@login_usuario", dts.glogin)
            cmd.Parameters.AddWithValue("@password_usuario", dts.gpassword)
            cmd.Parameters.AddWithValue("@acceso_usuario", dts.gacceso)



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




    Public Function editar(ByVal dts As vusuario) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_usuarios")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idusuario", dts.gidusuario)
            cmd.Parameters.AddWithValue("@nombre_usuario", dts.gnombre)
            cmd.Parameters.AddWithValue("@apellido_usuario", dts.gapellido)
            cmd.Parameters.AddWithValue("@dni_usuario", dts.gdni)
            cmd.Parameters.AddWithValue("@direccion_usuario", dts.gdireccion)
            cmd.Parameters.AddWithValue("@telefono_usuario", dts.gtelefono)
            cmd.Parameters.AddWithValue("@login_usuario", dts.glogin)
            cmd.Parameters.AddWithValue("@password_usuario", dts.gpassword)
            cmd.Parameters.AddWithValue("@acceso_usuario", dts.gacceso)

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



    Public Function eliminar(ByVal dts As vusuario) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_usuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@idusuario", SqlDbType.NVarChar, 50).Value = dts.gidusuario

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
