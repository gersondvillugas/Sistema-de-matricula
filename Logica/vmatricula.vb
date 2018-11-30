Public Class vmatricula

    Dim idmatricula, idalumno, idmateria As Integer
    Dim f_matricula As Date
    Dim numero_documento, tipo_documento As String
    Dim pago_matricula As Double


    Public Property gidmatricula
        Get
            Return idmatricula
        End Get
        Set(ByVal value)

            idmatricula = value

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

    Public Property gf_matricula
        Get
            Return f_matricula
        End Get
        Set(ByVal value)

            f_matricula = value

        End Set
    End Property


    Public Property gtipo_documento
        Get
            Return tipo_documento
        End Get
        Set(ByVal value)

            tipo_documento = value

        End Set
    End Property


    Public Property gnumero_documento
        Get
            Return numero_documento
        End Get
        Set(ByVal value)
            numero_documento = value

        End Set
    End Property

    Public Property gpago_matricula
        Get
            Return pago_matricula
        End Get
        Set(ByVal value)
            pago_matricula = value

        End Set
    End Property

    Public Sub New()

    End Sub


    Public Sub New(ByVal idmatricula As Integer, ByVal idalumno As Integer, ByVal idmateria As Integer, ByVal fecha_matricul As Date, ByVal tipo_documento As String, ByVal numero_documento As String, ByVal pago_matricula As Double)
        gidmatricula = idmatricula
        gidalumno = idalumno
        gidmateria = idmateria
        gf_matricula = fecha_matricul
        gtipo_documento = tipo_documento
        gnumero_documento = numero_documento
        gpago_matricula = pago_matricula


    End Sub

    Property nombrealumno As String

    Property gnombre_alumno As String

    Property gnombre_materia As String

End Class
