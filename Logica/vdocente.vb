Public Class vdocente
    Dim iddocente As Integer
    Dim nombre, apellidos, especialidad, telefono, dni As String

    'GET AND SET

    Public Property giddocente
        Get
            Return iddocente
        End Get
        Set(ByVal value)
            iddocente = value

        End Set
    End Property


    Public Property gnombres

        Get
            Return nombre

        End Get
        Set(ByVal value)

            nombre = value

        End Set
    End Property


    Public Property gapellidos
        Get
            Return apellidos
        End Get
        Set(ByVal value)
            apellidos = value
        End Set
    End Property


    Public Property gespecialidad
        Get
            Return especialidad
        End Get
        Set(ByVal value)
            especialidad = value
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


    Public Property gdni
        Get
            Return dni
        End Get
        Set(ByVal value)
            dni = value
        End Set
    End Property



    'CONSTRUCTORES

    Public Sub New()

    End Sub


    Public Sub New(ByVal iddocente As Integer, ByVal nombres As String, ByVal apellidos As String, ByVal especialidad As String, ByVal telefono As String, ByVal dni As String)
        giddocente = iddocente
        gnombres = nombres
        gapellidos = apellidos
        gespecialidad = especialidad
        gtelefono = telefono
        gdni = dni

    End Sub
End Class
