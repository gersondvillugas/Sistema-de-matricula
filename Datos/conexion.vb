
Imports System.Data.SqlClient        'importando la libreria para sql server

Public Class conexion

    Protected cnn As New SqlConnection
    Public idusuario As Integer



    'funcion para conectar ala base de datos
    Protected Function conectado()
        Try
            cnn = New SqlConnection("Data Source=DESKTOP-QVCRCH4; Initial Catalog=bdregistro_alumnos;Integrated Security=true")
            cnn.Open()
            Return True

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False

        End Try
    End Function




    'funcion para desconectar ala base de datos

    Protected Function desconectado()
        Try
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
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
