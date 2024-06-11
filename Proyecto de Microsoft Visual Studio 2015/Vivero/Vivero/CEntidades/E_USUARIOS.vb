Public Class E_USUARIOS
    Private _id_perfil As Byte
    Private _id_usuario As Short
    Private _DNI As Integer
    Private _apellido As String
    Private _nombre As String
    Private _fecha_nac As Date
    Private _fecha_ingreso As Date
    Private _username As String
    Private _contraseña As String
    Private _direccion As String
    Private _telefono As String
    Private _email As String
    Private _eliminado As String

    Public Sub New(ByVal idperfil As Byte, ByVal idusuario As Short, ByVal dni As Integer, ByVal ape As String, ByVal nom As String, ByVal fechnac As Date, ByVal fechaingreso As Date, ByVal usuario As String, ByVal contra As String, ByVal dir As String, ByVal tel As String, ByVal email As String, ByVal elim As String)
        id_perfil = idperfil
        id_usuario = idusuario
        dni = dni
        apellido = ape
        nombre = nom
        fecha_nac = fechnac
        fecha_ingreso = fechaingreso
        username = usuario
        contraseña = contra
        direccion = dir
        telefono = tel
        email = email
        eliminado = elim
    End Sub


    Public Property id_perfil As Byte
        Get
            Return _id_perfil

        End Get

        Set(ByVal value As Byte)
            _id_perfil = value
        End Set
    End Property

    Public Property id_usuario As Short
        Get
            Return _id_usuario

        End Get

        Set(ByVal value As Short)
            _id_usuario = value
        End Set
    End Property

    Public Property dni As Integer
        Get
            Return _DNI

        End Get

        Set(ByVal value As Integer)
            _DNI = value
        End Set
    End Property

    Public Property apellido As String
        Get
            Return _apellido
        End Get

        Set(ByVal value As String)
            _apellido = value
        End Set
    End Property

    Public Property nombre As String
        Get
            Return _nombre

        End Get

        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Public Property fecha_nac As Date
        Get
            Return _fecha_nac

        End Get

        Set(ByVal value As Date)
            _fecha_nac = value
        End Set
    End Property

    Public Property fecha_ingreso As Date
        Get
            Return _fecha_ingreso

        End Get

        Set(ByVal value As Date)
            _fecha_ingreso = value
        End Set
    End Property

    Public Property username As String
        Get
            Return _username

        End Get

        Set(ByVal value As String)
            _username = value
        End Set
    End Property

    Public Property contraseña As String
        Get
            Return _contraseña

        End Get

        Set(ByVal value As String)
            _contraseña = value
        End Set
    End Property

    Public Property direccion As String
        Get
            Return _direccion

        End Get

        Set(ByVal value As String)
            _direccion = value
        End Set
    End Property

    Public Property telefono As String
        Get
            Return _telefono

        End Get

        Set(ByVal value As String)
            _telefono = value
        End Set
    End Property

    Public Property email As String
        Get
            Return _email

        End Get

        Set(ByVal value As String)
            _email = value
        End Set
    End Property

    Public Property eliminado As String
        Get
            Return _eliminado

        End Get

        Set(ByVal value As String)
            _eliminado = value
        End Set
    End Property

    Public Overridable Property PERFILES As PERFILES
    Public Overridable Property FACTURAS As ICollection(Of FACTURAS) = New HashSet(Of FACTURAS)
End Class
