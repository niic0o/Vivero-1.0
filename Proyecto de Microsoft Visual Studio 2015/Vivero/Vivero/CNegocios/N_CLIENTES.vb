Public Class N_CLIENTES
    Dim objcliente As D_CLIENTES = New D_CLIENTES

    Function agregar_cliente(ByVal aux_apellido As String, ByVal aux_nombre As String, ByVal aux_dni As Integer, ByVal aux_email As String, ByVal aux_tel As String, ByVal aux_dir As String, ByVal aux_prov As String, ByVal aux_loc As String) As Boolean

        Dim E_un_cliente = New CLIENTES()
        Dim no As String = "NO"

        With E_un_cliente
            .apellido() = aux_apellido
            .nombre() = aux_nombre
            .DNI() = aux_dni
            .email() = aux_email
            .telefono() = aux_tel
            .direccion() = aux_dir
            .provincia() = aux_prov
            .localidad() = aux_loc
            .eliminado() = no
        End With

        Dim D_un_cliente = New D_CLIENTES
        Dim agregar As Boolean = D_un_cliente.Dguardar_cliente(E_un_cliente)
        If agregar Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub cargarGrid(ByVal grid As DataGridView)

        Dim clientes As D_CLIENTES = New D_CLIENTES
        clientes.D_getClientesAll(grid)
        grid.ClearSelection()

    End Sub

    Public Sub cargarGrid_inactivos(ByVal grid As DataGridView)

        Dim clientes As D_CLIENTES = New D_CLIENTES
        clientes.D_getClientesAll_inactivos(grid)
        grid.ClearSelection()

    End Sub

    Public Sub cargarGrid_activos_inactivos(ByVal grid As DataGridView)

        Dim clientes As D_CLIENTES = New D_CLIENTES
        clientes.D_getClientesAll_activos_inactivos(grid)
        grid.ClearSelection()

    End Sub

    Public Sub BuscarNombre1(ByVal ape As String, ByVal grid As DataGridView)
        Dim objcliente = New D_CLIENTES
        objcliente.Buscar_Nombre1(ape, grid)
        grid.ClearSelection()
    End Sub

    Public Sub BuscarDNI1(ByVal dni As Integer, ByVal grid As DataGridView)
        Dim objcliente = New D_CLIENTES
        objcliente.Buscar_DNI1(dni, grid)
        grid.ClearSelection()
    End Sub

    Public Sub BuscarNombre1_inactivos(ByVal ape As String, ByVal grid As DataGridView)
        Dim objcliente = New D_CLIENTES
        objcliente.Buscar_Nombre1_inactivos(ape, grid)
        grid.ClearSelection()
    End Sub

    Public Sub BuscarDNI1_inactivos(ByVal dni As Integer, ByVal grid As DataGridView)
        Dim objcliente = New D_CLIENTES
        objcliente.Buscar_DNI1_inactivos(dni, grid)
        grid.ClearSelection()
    End Sub

    Public Sub BuscarNombre1_activos_inactivos(ByVal ape As String, ByVal grid As DataGridView)
        Dim objcliente = New D_CLIENTES
        objcliente.Buscar_Nombre1_activos_inactivos(ape, grid)
        grid.ClearSelection()
    End Sub

    Public Sub BuscarDNI1_activos_inactivos(ByVal dni As Integer, ByVal grid As DataGridView)
        Dim objcliente = New D_CLIENTES
        objcliente.Buscar_DNI1_activos_inactivos(dni, grid)
        grid.ClearSelection()
    End Sub

    Function Modificar_Cliente(ByVal p_id_cliente As Integer,
                             ByVal p_dni As Integer,
                             ByVal p_apellido As String,
                             ByVal p_nombre As String,
                             ByVal p_email As String,
                             ByVal p_telefono As String,
                             ByVal p_direccion As String,
                             ByVal p_provincia As String,
                             ByVal p_localidad As String
                             )
        Dim oCliente = New CLIENTES
        With oCliente
            .id_cliente = p_id_cliente
            .DNI = p_dni
            .apellido = p_apellido
            .nombre = p_nombre
            .email = p_email
            .telefono = p_telefono
            .direccion = p_direccion
            .provincia = p_provincia
            .localidad = p_localidad


        End With

        Dim agregar = objcliente.DModificarCliente(oCliente)
        If agregar Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Sub cargarGridHabilitados(ByVal grid As DataGridView)

        Dim client As D_CLIENTES = New D_CLIENTES
        grid.DataSource = client.Listar_CLHabilitados()
        grid.ClearSelection()
    End Sub

    Public Sub cargarGridInhabilitados(ByVal grid As DataGridView)

        Dim client As D_CLIENTES = New D_CLIENTES
        grid.DataSource = client.Listar_CLInhabilitados()
        grid.ClearSelection()
    End Sub

    Public Function borrar_cliente(ByVal aux_id As Integer) As Boolean
        Dim agregar As Boolean = objcliente.D_borrar_cliente(aux_id)
        If agregar Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function activar_cliente(ByVal aux_id As Integer) As Boolean
        Dim agregar As Boolean = objcliente.D_activar_cliente(aux_id)
        If agregar Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
