Public Class E_FORMAS_DE_PAGO
    Private _id_FdePago As Byte
    Private _FdePago As String

    Public Sub New(ByVal idfpago As Byte, ByVal fpago As String)
        id_fdepago = idfpago
        FdePago = fpago
    End Sub

    Public Property id_fdepago As Byte
        Get
            Return _id_FdePago

        End Get

        Set(ByVal value As Byte)
            _id_FdePago = value
        End Set
    End Property

    Public Property FdePago As String
        Get
            Return _FdePago

        End Get

        Set(ByVal value As String)
            _FdePago = value
        End Set
    End Property

    Public Overridable Property FACTURAS As ICollection(Of FACTURAS) = New HashSet(Of FACTURAS)
End Class
