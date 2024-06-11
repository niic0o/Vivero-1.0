Public Class E_FACTURAS_DETALLE
    Private _num_factura As Integer
    Private _id_item As Byte
    Private _id_producto As Integer
    Private _cantidad As Short

    Public Sub New(ByVal numfactura As Integer, ByVal iditem As Byte, ByVal idproducto As Integer, ByVal cant As Short)
        num_factura = numfactura
        id_item = iditem
        id_producto = idproducto
        cantidad = cant
    End Sub



    Public Property num_factura As Integer
        Get
            Return _num_factura

        End Get

        Set(ByVal value As Integer)
            _num_factura = value
        End Set
    End Property

    Public Property id_item As Byte
        Get
            Return _id_item

        End Get

        Set(ByVal value As Byte)
            _id_item = value
        End Set
    End Property

    Public Property id_producto As Integer
        Get
            Return _id_producto

        End Get

        Set(ByVal value As Integer)
            _id_producto = value
        End Set
    End Property

    Public Property cantidad As Integer
        Get
            Return _cantidad

        End Get

        Set(ByVal value As Integer)
            _cantidad = value
        End Set
    End Property

    Public Overridable Property FACTURAS As FACTURAS
    Public Overridable Property PRODUCTOS As PRODUCTOS
End Class
