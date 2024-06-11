Public Class E_PRODUCTOS
    Private _id_categoria As Byte
    Private _id_tipo As Short
    Private _id_producto As Integer
    Private _nombre As String
    Private _descripcion As String
    Private _tamaño As String
    Private _disponible As String
    Private _stock_min As Byte
    Private _stock As Short
    Private _precio_lista As Double
    Private _precio_venta As Double
    Private _descuento As Byte
    Private _veces_vendido As Nullable(Of Integer)
    Private _eliminado As String

    Public Overridable Property FACTURAS_DETALLE As ICollection(Of FACTURAS_DETALLE) = New HashSet(Of FACTURAS_DETALLE)
    Public Overridable Property TIPOS_DE_PRODUCTOS As TIPOS_DE_PRODUCTOS

    Public Sub New()
    End Sub

    Public Sub New(ByVal aux_id_categoria, ByVal aux_id_tipo, ByVal aux_id_producto, ByVal aux_nombre, ByVal aux_descripcion, ByVal aux_tamaño, ByVal aux_disponible, ByVal aux_stock_min, ByVal aux_stock, ByVal aux_precio_lista, ByVal aux_precio_venta, ByVal aux_descuento, ByVal aux_veces_vendido, ByVal aux_eliminado)

        Me.Id_Categoria() = aux_id_categoria
        Me.Id_Tipo() = aux_id_tipo
        Me.Id_Producto() = aux_id_producto
        Me.Nombre() = aux_nombre
        Me.Descripcion() = aux_descripcion
        Me.Tamaño() = aux_tamaño
        Me.Disponible() = aux_disponible
        Me.Stock_Min() = aux_stock_min
        Me.Stock() = aux_stock
        Me.Precio_Lista() = aux_precio_lista
        Me.Precio_Venta() = aux_precio_venta
        Me.Descuento() = aux_descuento
        Me.Veces_Vendido() = aux_veces_vendido
        Me.Eliminado() = aux_eliminado

    End Sub

    Public Property Id_Categoria() As Byte
        Get
            Return Me._id_categoria
        End Get
        Set(aux_id_categoria As Byte)
            Me._id_categoria = aux_id_categoria
        End Set
    End Property

    Public Property Id_Tipo() As Short
        Get
            Return Me._id_tipo
        End Get
        Set(aux_id_tipo As Short)
            Me._id_tipo = aux_id_tipo
        End Set
    End Property

    Public Property Id_Producto() As Integer
        Get
            Return Me._id_producto
        End Get
        Set(aux_id_producto As Integer)
            Me._id_producto = aux_id_producto
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return Me._nombre
        End Get
        Set(aux_nombre As String)
            Me._nombre = aux_nombre
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return Me._descripcion
        End Get
        Set(aux_descripcion As String)
            Me._descripcion = aux_descripcion
        End Set
    End Property

    Public Property Tamaño() As String
        Get
            Return Me._tamaño
        End Get
        Set(aux_tamaño As String)
            Me._tamaño = aux_tamaño
        End Set
    End Property

    Public Property Disponible() As String
        Get
            Return Me._disponible
        End Get
        Set(aux_disponible As String)
            Me._disponible = aux_disponible
        End Set
    End Property

    Public Property Stock_Min() As Byte
        Get
            Return Me._stock_min
        End Get
        Set(aux_stock_min As Byte)
            Me._stock_min = aux_stock_min
        End Set
    End Property

    Public Property Stock() As Short
        Get
            Return Me._stock
        End Get
        Set(aux_stock As Short)
            Me._stock = aux_stock
        End Set
    End Property

    Public Property Precio_Lista() As Double
        Get
            Return Me._precio_lista
        End Get
        Set(aux_precio_lista As Double)
            Me._precio_lista = aux_precio_lista
        End Set
    End Property

    Public Property Precio_Venta() As Double
        Get
            Return Me._precio_venta
        End Get
        Set(aux_precio_venta As Double)
            Me._precio_venta = aux_precio_venta

        End Set
    End Property

    Public Property Descuento() As Byte
        Get
            Return Me._descuento
        End Get
        Set(aux_decuento As Byte)
            Me._descuento = aux_decuento
        End Set
    End Property

    Public Property Veces_Vendido() As Nullable(Of Integer)
        Get
            Return Me._veces_vendido
        End Get
        Set(aux_veces_vendido As Nullable(Of Integer))
            Me._veces_vendido = aux_veces_vendido
        End Set
    End Property

    Public Property Eliminado() As String
        Get
            Return Me._eliminado
        End Get
        Set(aux_eliminado As String)
            Me._eliminado = aux_eliminado
        End Set
    End Property
End Class
