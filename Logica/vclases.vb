

Public Class vclases
    Dim idclases, idalumno, idmateria, idmatricula As Integer
    Dim tipoclases, por, nombre_alumno, nombre_materia As String
    Dim pagomensual As Double

    Public Property gidclases
        Get
            Return idclases

        End Get
        Set(ByVal value)
            idclases = value


        End Set
    End Property

    Public Property gidalumno
        Get
            Return idalumno

        End Get
        Set(ByVal value)
            idalumno = value


        End Set
    End Property

    Public Property gidmateria
        Get
            Return idmateria

        End Get
        Set(ByVal value)
            idmateria = value


        End Set
    End Property


    Public Property gidmatricula
        Get
            Return idmatricula

        End Get
        Set(ByVal value)
            idmatricula = value


        End Set
    End Property
    Public Property gtipoclases
        Get
            Return tipoclases

        End Get
        Set(ByVal value)
            tipoclases = value


        End Set
    End Property

    Public Property gpor
        Get
            Return por

        End Get
        Set(ByVal value)
            por = value


        End Set
    End Property


    Public Property gpagomensual
        Get
            Return pagomensual

        End Get
        Set(ByVal value)
            pagomensual = value


        End Set
    End Property

    Property gnombre_alumno
        Get
            Return nombre_alumno

        End Get
        Set(ByVal value)
            nombre_alumno = value


        End Set
    End Property
    Property gnombre_materia
        Get
            Return nombre_materia

        End Get
        Set(ByVal value)
            nombre_materia = value


        End Set
    End Property
    Public Sub New()

    End Sub






    Public Sub New(ByVal idclases As Integer, ByVal idalumno As Integer, ByVal idmateria As Integer, ByVal idmatricula As Integer, ByVal tipoclases As String, ByVal por As String, ByVal pago As Double, nombre_alumno As String, nombre_materia As String)

        gidclases = idclases
        gidalumno = idalumno
        gnombre_alumno = nombre_alumno
        gidmateria = idmateria
        gnombre_materia = nombre_materia
        gidmatricula = idmatricula
        gtipoclases = tipoclases
        gpor = por
        gpagomensual = pago


    End Sub

  

End Class
