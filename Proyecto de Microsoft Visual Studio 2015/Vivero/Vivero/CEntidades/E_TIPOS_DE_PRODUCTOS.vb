Public Class E_TIPOS_DE_PRODUCTOS
    Private _id_categoria As Byte
    Private _id_tipo As Short
    Private _tipo As String
    Private _eliminado As String

    Public Overridable Property CATEGORIAS As CATEGORIAS
    Public Overridable Property PRODUCTOS As ICollection(Of PRODUCTOS) = New HashSet(Of PRODUCTOS)

    Public Sub New(ByVal aux_id_categoria, ByVal aux_id_tipo, ByVal aux_tipo, ByVal aux_eliminado)

        Me.Id_Categoria() = aux_id_categoria
        Me.Id_Tipo() = aux_id_tipo
        Me.Tipo() = aux_tipo
        Me.Eliminado() = aux_eliminado
    End Sub

    Public Property Id_Categoria() As Byte
        Get
            Return Me._id_categoria
        End Get
        Set(ByVal aux_id_categoria As Byte)
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

    Public Property Tipo() As String
        Get
            Return Me._tipo
        End Get
        Set(aux_tipo As String)
            Me._tipo = aux_tipo
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
