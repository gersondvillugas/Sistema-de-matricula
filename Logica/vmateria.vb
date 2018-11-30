Public Class vmateria



    Dim idmateria As Integer
    Dim nombre_materia As String


    Public Property gidmateria
        Get
            Return idmateria

        End Get
        Set(ByVal value)
            idmateria = value


        End Set
    End Property


    Public Property gnombre_materia
        Get
            Return nombre_materia

        End Get
        Set(ByVal value)
            nombre_materia = value


        End Set
    End Property



    Public Sub New()

    End Sub


    Public Sub New(ByVal idmateria As Integer, ByVal nombre_materia As String)
        gidmateria = idmateria
        gnombre_materia = nombre_materia

    End Sub
End Class
