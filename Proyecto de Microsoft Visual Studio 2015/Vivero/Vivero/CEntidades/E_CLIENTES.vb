Public Class E_CLIENTES
    Private _id_cliente As Integer
    Private _apellido As String
    Private _nombre As String
    Private _DNI As Integer
    Private _email As String
    Private _telefono As String
    Private _direccion As String
    Private _provincia As String
    Private _localidad As String
    Private _eliminado As String

    Public Overridable Property FACTURAS As ICollection(Of FACTURAS) = New HashSet(Of FACTURAS)

    Public Sub New(ByVal aux_id_cliente, ByVal aux_apellido, ByVal aux_nombre, ByVal aux_DNI, ByVal aux_email, ByVal aux_telefono, ByVal aux_direccion, ByVal aux_provincia, ByVal aux_localidad, ByVal aux_eliminado)

        Me.Id_Cliente() = aux_id_cliente
        Me.Apellido() = aux_apellido
        Me.Nombre() = aux_nombre
        Me.DNI() = aux_DNI
        Me.Email() = aux_email
        Me.Telefono() = aux_telefono
        Me.Direccion() = aux_direccion
        Me.Provincia() = aux_provincia
        Me.Localidad() = aux_localidad
        Me.Eliminado() = aux_eliminado

    End Sub

    Public Property Id_Cliente() As Integer
        Get
            Return Me._id_cliente
        End Get
        Set(ByVal aux_id_cliente As Integer)
            Me._id_cliente = aux_id_cliente
        End Set
    End Property

    Public Property Apellido() As String
        Get
            Return Me._apellido
        End Get
        Set(ByVal aux_apellido As String)
            Me._apellido = aux_apellido
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return Me._nombre
        End Get
        Set(ByVal aux_nombre As String)
            Me._nombre = aux_nombre
        End Set
    End Property

    Public Property DNI() As Integer
        Get
            Return Me._DNI
        End Get
        Set(ByVal aux_DNI As Integer)
            Me._DNI = aux_DNI
        End Set
    End Property

    Public Property Email() As String
        Get
            Return Me._email
        End Get
        Set(ByVal aux_email As String)
            Me._email = aux_email
        End Set
    End Property

    Public Property Telefono() As String
        Get
            Return Me._telefono
        End Get
        Set(ByVal aux_telefono As String)
            Me._telefono = aux_telefono
        End Set
    End Property

    Public Property Direccion() As String
        Get
            Return Me._direccion
        End Get
        Set(ByVal aux_direccion As String)
            Me._direccion = aux_direccion
        End Set
    End Property

    Public Property Provincia() As String
        Get
            Return Me._provincia
        End Get
        Set(ByVal aux_provincia As String)
            Me._provincia = aux_provincia
        End Set
    End Property

    Public Property Localidad() As String
        Get
            Return Me._localidad
        End Get
        Set(ByVal aux_localidad As String)
            Me._localidad = aux_localidad
        End Set
    End Property

    Public Property Eliminado() As String
        Get
            Return Me._eliminado
        End Get
        Set(ByVal aux_eliminado As String)
            Me._eliminado = aux_eliminado
        End Set
    End Property
End Class
