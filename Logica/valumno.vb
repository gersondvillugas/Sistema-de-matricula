Public Class valumno
    Dim idalumno, iddocente As Integer
    Dim nombre, apellido, dni, telefono, nivel As String

    Dim fecha_vencimiento As Date
    Dim imagen() As Byte

    Public Property gidalumno
        Get
            Return idalumno
        End Get
        Set(ByVal value)
            idalumno = value


        End Set
    End Property

    Public Property giddocente
        Get
            Return iddocente

        End Get
        Set(ByVal value)
            iddocente = value


        End Set
    End Property


    Public Property gnombre
        Get
            Return nombre

        End Get
        Set(ByVal value)
            nombre = value


        End Set
    End Property

    Public Property gapellido
        Get
            Return apellido

        End Get
        Set(ByVal value)
            apellido = value


        End Set
    End Property

    Public Property gdni
        Get
            Return dni
        End Get
        Set(ByVal value)

            dni = value

        End Set
    End Property

    Public Property gtelefono
        Get
            Return telefono
        End Get
        Set(ByVal value)

            telefono = value


        End Set
    End Property


    Public Property gnivel
        Get
            Return nivel
        End Get
        Set(ByVal value)
            nivel = value


        End Set
    End Property


    Public Property gfecha_vencimiento
        Get
            Return fecha_vencimiento
        End Get
        Set(ByVal value)
            fecha_vencimiento = value

        End Set
    End Property



    Public Property gimagen
        Get
            Return imagen

        End Get
        Set(ByVal value)
            imagen = value

        End Set
    End Property



    Public Sub New()

    End Sub

    Public Sub New(ByVal idalumno As Integer, ByVal iddocente As Integer, ByVal nombre As String, ByVal apellido As String, ByVal dni As String, ByVal telefono As String, ByVal nivel As String, ByVal fecha_vencimiento As Date, ByVal imagen() As Byte)
        gidalumno = idalumno
        giddocente = iddocente
        gnombre = nombre
        gapellido = apellido
        gdni = dni
        gtelefono = telefono
        gnivel = nivel
        gfecha_vencimiento = fecha_vencimiento
        gimagen = imagen
    End Sub



End Class
