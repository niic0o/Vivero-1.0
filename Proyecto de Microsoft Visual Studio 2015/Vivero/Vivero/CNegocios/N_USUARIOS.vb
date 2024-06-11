Public Class N_USUARIOS
    Dim D_un_usuario As D_USUARIOS = New D_USUARIOS


    Function agregar_usuario(ByVal aux_id_perfil As Byte, ByVal aux_DNI As Integer, ByVal aux_apellido As String, ByVal aux_nombre As String, ByVal aux_fecha_nac As Date, ByVal aux_fecha_ingreso As Date, ByVal aux_username As String, ByVal aux_contraseña As String, ByVal aux_direccion As String, ByVal aux_tel As String, ByVal aux_email As String) As Boolean

        Dim E_un_usuario = New USUARIOS()
        Dim no As String = "NO"

        With E_un_usuario
            .id_perfil() = aux_id_perfil
            .DNI() = aux_DNI
            .apellido() = aux_apellido
            .nombre() = aux_nombre
            .fecha_nac() = aux_fecha_nac
            .fecha_ingreso() = aux_fecha_ingreso
            .username() = aux_username
            .contraseña() = aux_contraseña
            .direccion() = aux_direccion
            .telefono() = aux_tel
            .email() = aux_email
            .eliminado() = no
        End With

        Dim D_un_usuario = New D_USUARIOS
        Dim agregar As Boolean = D_un_usuario.Dguardar_usuario(E_un_usuario)
        If agregar Then
            Return True
        Else
            Return False
        End If
    End Function


    Public Sub cargarGrid(ByVal grid As DataGridView)

        Dim usuarios As D_USUARIOS = New D_USUARIOS
        usuarios.D_getUsuariosAll(grid)
        grid.ClearSelection()
    End Sub

    Public Sub cargarGrid_inactivos(ByVal grid As DataGridView)

        Dim usuarios As D_USUARIOS = New D_USUARIOS
        usuarios.D_getUsuariosAll_inactivos(grid)
        grid.ClearSelection()
    End Sub

    Public Sub cargarGrid_activos_inactivos(ByVal grid As DataGridView)

        Dim usuarios As D_USUARIOS = New D_USUARIOS
        usuarios.D_getUsuariosAll_activos_inactivos(grid)
        grid.ClearSelection()
    End Sub

    Function Modificar_Usuario(ByVal p_nuevo_perfil As Byte,
                              ByVal p_id_perfil As Byte,
                               ByVal p_id_usuario As Integer,
                             ByVal p_dni As Integer,
                             ByVal p_apellido As String,
                             ByVal p_nombre As String,
                               ByVal p_fecha_nac As Date,
                               ByVal p_fecha_ingreso As Date,
                               ByVal p_username As String,
                               ByVal p_contraseña As String,
                               ByVal p_direccion As String,
                               ByVal p_telefono As String,
                             ByVal p_email As String)


        Dim oUsuarios = New USUARIOS
        With oUsuarios
            .id_perfil = p_id_perfil
            .id_usuario = p_id_usuario
            .DNI = p_dni
            .apellido = p_apellido
            .nombre = p_nombre
            .fecha_nac = p_fecha_nac
            .fecha_ingreso = p_fecha_ingreso
            .username = p_username
            .contraseña = p_contraseña
            .direccion = p_direccion
            .telefono = p_telefono
            .email = p_email


        End With

        Dim agregar = D_un_usuario.DModificarUsuario(oUsuarios, p_nuevo_perfil)
        If agregar Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Sub BuscarNombre1(ByVal ape As String, ByVal grid As DataGridView)
        Dim objusuario As D_USUARIOS = New D_USUARIOS
        objusuario.Buscar_Nombre1(ape, grid)
        grid.ClearSelection()
    End Sub

    Public Sub BuscarDNI1(ByVal dni As Integer, ByVal grid As DataGridView)
        Dim objusuario = New D_USUARIOS
        objusuario.Buscar_DNI1(dni, grid)
        grid.ClearSelection()
    End Sub

    Public Sub BuscarNombre1_inactivos(ByVal ape As String, ByVal grid As DataGridView)
        Dim objusuario As D_USUARIOS = New D_USUARIOS
        objusuario.Buscar_Nombre1_inactivos(ape, grid)
        grid.ClearSelection()
    End Sub

    Public Sub BuscarDNI1_inactivos(ByVal dni As Integer, ByVal grid As DataGridView)
        Dim objusuario = New D_USUARIOS
        objusuario.Buscar_DNI1_inactivos(dni, grid)
        grid.ClearSelection()
    End Sub

    Public Sub BuscarNombre1_activos_inactivos(ByVal ape As String, ByVal grid As DataGridView)
        Dim objusuario As D_USUARIOS = New D_USUARIOS
        objusuario.Buscar_Nombre1_activos_inactivos(ape, grid)
        grid.ClearSelection()
    End Sub

    Public Sub BuscarDNI1_activos_inactivos(ByVal dni As Integer, ByVal grid As DataGridView)
        Dim objusuario = New D_USUARIOS
        objusuario.Buscar_DNI1_activos_inactivos(dni, grid)
        grid.ClearSelection()
    End Sub

    Public Function borrar_usuario(ByVal aux_id_perfil As Byte, ByVal aux_id_usuario As Short) As Boolean
        Dim agregar As Boolean = D_un_usuario.D_borrar_usuario(aux_id_perfil, aux_id_usuario)
        If agregar Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function activar_usuario(ByVal aux_id_perfil As Byte, ByVal aux_id_usuario As Short) As Boolean
        Dim agregar As Boolean = D_un_usuario.D_activar_usuario(aux_id_perfil, aux_id_usuario)
        If agregar Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function Verificar_Usuario(ByVal aux_user As String, ByVal aux_pass As String) As Boolean
        Dim verificar As Boolean = D_un_usuario.Verificar_Usuario(aux_user, aux_pass)
        If verificar Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function Verificar_Perfil(ByVal aux_username As String, ByVal aux_password As String)
        Dim e_un_usuario As USUARIOS = New USUARIOS
        e_un_usuario = D_un_usuario.Verificar_Perfil(aux_username, aux_password, e_un_usuario)
        Return e_un_usuario
    End Function
End Class
