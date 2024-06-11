Public Class E_FACTURAS
    Private _num_factura As Integer
    Private _fecha_y_hora As Date
    Private _id_vendedor As Short
    Private _id_FdePago As Byte
    Private _id_cliente As Integer
    Private _total As Double
    Private _anulado As String

    Public Overridable Property CLIENTES As CLIENTES

    Public Overridable Property FACTURAS_DETALLE As ICollection(Of FACTURAS_DETALLE) = New HashSet(Of FACTURAS_DETALLE)

    Public Sub New(ByVal numfactura As Integer, ByVal fyh As Date, ByVal idven As Short, ByVal idfdepago As Byte, ByVal idcliente As Integer, ByVal total As Double, ByVal anul As String)
        num_factura = numfactura
        fecha_y_hora = fyh
        id_vendedor = idven
        id_FdePago = idfdepago
        id_cliente = idcliente
        total = total
        anulado = anul
    End Sub
    Public Property num_factura As Integer
        Get
            Return _num_factura

        End Get

        Set(ByVal value As Integer)
            _num_factura = value
        End Set
    End Property

    Public Property fecha_y_hora As Date
        Get
            Return _fecha_y_hora

        End Get

        Set(ByVal value As Date)
            _fecha_y_hora = value
        End Set
    End Property

    Public Property id_vendedor As Short
        Get
            Return _id_vendedor

        End Get

        Set(ByVal value As Short)
            _id_vendedor = value
        End Set
    End Property

    Public Property id_FdePago As Byte
        Get
            Return _id_FdePago

        End Get

        Set(ByVal value As Byte)
            _id_FdePago = value
        End Set
    End Property

    Public Property id_cliente As Integer
        Get
            Return _id_cliente

        End Get

        Set(ByVal value As Integer)
            _id_cliente = value
        End Set
    End Property

    Public Property total As Double
        Get
            Return _total

        End Get

        Set(ByVal value As Double)
            _total = value
        End Set
    End Property

    Public Property anulado As String
        Get
            Return _anulado

        End Get

        Set(ByVal value As String)
            _anulado = value
        End Set
    End Property


    Public Overridable Property FORMAS_DE_PAGO As FORMAS_DE_PAGO
    Public Overridable Property USUARIOS As USUARIOS
End Class
