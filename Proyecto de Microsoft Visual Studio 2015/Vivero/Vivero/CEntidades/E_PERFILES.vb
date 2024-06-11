Public Class E_PERFILES
    Private _id_perfil As Byte
    Private _perfil As String

    Public Sub New(ByVal idperfil As Byte, ByVal perfil As String)
        id_perfil = idperfil
        perfil = perfil

    End Sub

    Public Property id_perfil As Byte
        Get
            Return _id_perfil

        End Get

        Set(ByVal value As Byte)
            _id_perfil = value
        End Set
    End Property

    Public Property perfil As String
        Get
            Return _perfil

        End Get

        Set(ByVal value As String)
            _perfil = value
        End Set
    End Property

    Public Overridable Property USUARIOS As ICollection(Of USUARIOS) = New HashSet(Of USUARIOS)

End Class
