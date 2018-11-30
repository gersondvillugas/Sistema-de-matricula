Public Class vasistencia_a

    Dim idasistencia, idmateria, idalumno, num_asistencia As Integer
    Dim fecha_asistencia As Date
    Dim asistencia, nombre_alumno, nombre_materia As String



    Public Property gidasistencia
        Get
            Return idasistencia

        End Get
        Set(ByVal value)
            idasistencia = value

        End Set
    End Property

    Public Property gnum_asistencia
        Get
            Return num_asistencia

        End Get
        Set(ByVal value)
            num_asistencia = value

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


    Public Property gidalumno
        Get
            Return idalumno

        End Get
        Set(ByVal value)
            idalumno = value

        End Set
    End Property




    Public Property gfecha_asistencia
        Get
            Return fecha_asistencia

        End Get
        Set(ByVal value)
            fecha_asistencia = value

        End Set
    End Property
    Public Property gnombre_alumno
        Get
            Return nombre_alumno

        End Get
        Set(ByVal value)
            nombre_alumno = value

        End Set
    End Property

    Public Property gasistencia
        Get
            Return asistencia

        End Get
        Set(ByVal value)
            asistencia = value

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

    Public Sub New(ByVal idasistencia As Integer, ByVal numero_asistencia As Integer, ByVal idmateria As Integer, ByVal idalumno As Integer, ByVal fecha_asistencia As Date, ByVal asistencia As String, ByVal nombre_materia As String, ByVal nombre_alumno As String)
        gidasistencia = idasistencia
        gidmateria = idmateria
        gnombre_materia = nombre_materia
        gidalumno = idalumno
        gnombre_alumno = nombre_alumno
        gfecha_asistencia = fecha_asistencia
        gasistencia = asistencia
        gnum_asistencia = numero_asistencia


    End Sub

    'modificado
    'Function gnombre_alumno() As Object
    '   Throw New NotImplementedException
    'End Function

    '  Function gnombre_materia() As Object
    '     Throw New NotImplementedException
    'End Function

    'Private Function nombre_alumno() As Object
    '   Throw New NotImplementedException
    'End Function

    ' Private Function nombre_materia() As Object
    '   Throw New NotImplementedException
    'End Function


End Class
