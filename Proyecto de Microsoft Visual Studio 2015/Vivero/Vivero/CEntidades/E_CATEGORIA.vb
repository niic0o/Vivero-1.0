Public Class E_CATEGORIAS
    Private _id_categoria As Byte
    Private _categoria As String
    Private _eliminado As String

    Public Overridable Property TIPOS_DE_PRODUCTOS As ICollection(Of TIPOS_DE_PRODUCTOS) = New HashSet(Of TIPOS_DE_PRODUCTOS)

    Public Sub New(ByVal aux_id_categoria As Byte, ByVal aux_categoria As String, ByVal aux_eliminado As String)
        Me.Id_Categoria() = aux_id_categoria
        Me.Categoria() = aux_categoria
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

    Public Property Categoria() As String
        Get
            Return Me._categoria
        End Get
        Set(ByVal aux_categoria As String)
            Me._categoria = aux_categoria
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
