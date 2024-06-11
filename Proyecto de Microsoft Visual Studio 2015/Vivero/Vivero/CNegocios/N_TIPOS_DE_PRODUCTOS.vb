Public Class N_TIPOS_DE_PRODUCTOS

    Dim d_tipos As D_TIPOS_DE_PRODUCTOS = New D_TIPOS_DE_PRODUCTOS

    Function agregar_tipo(ByVal aux_id_categoria As Byte, ByVal aux_tipo As String) As Boolean
        Dim E_un_tipo = New TIPOS_DE_PRODUCTOS()
        Dim no As String = "NO"

        With E_un_tipo
            .id_categoria = aux_id_categoria
            .tipo() = aux_tipo
            .eliminado() = no
        End With

        Dim D_un_tipo = New D_TIPOS_DE_PRODUCTOS
        Dim agregar As Boolean = D_un_tipo.Dguardar_tipo(E_un_tipo)
        If agregar Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Sub cargarDataGrid(ByVal grid As DataGridView)

        Dim tipos As D_TIPOS_DE_PRODUCTOS = New D_TIPOS_DE_PRODUCTOS
        tipos.D_getTiposAll(grid)
        grid.ClearSelection()
    End Sub

    Public Sub cargarDataGrid_inactivos(ByVal grid As DataGridView)

        Dim tipos As D_TIPOS_DE_PRODUCTOS = New D_TIPOS_DE_PRODUCTOS
        tipos.D_getTiposAll_inactivos(grid)
        grid.ClearSelection()
    End Sub

    Public Sub cargarDataGrid_activo_inactivo(ByVal grid As DataGridView)

        Dim tipos As D_TIPOS_DE_PRODUCTOS = New D_TIPOS_DE_PRODUCTOS
        tipos.D_getTiposAll_activo_inactivo(grid)
        grid.ClearSelection()
    End Sub

    Public Sub cargarCBO(ByVal aux_combobox As ComboBox, ByVal aux_id_categoria As Byte)
        Dim D_tipos As D_TIPOS_DE_PRODUCTOS = New D_TIPOS_DE_PRODUCTOS

        D_tipos.D_getTiposAll_byCategoria(aux_combobox, aux_id_categoria)

    End Sub

    Public Sub cargarCBO_inactivos(ByVal aux_combobox As ComboBox, ByVal aux_id_categoria As Byte)
        Dim D_tipos As D_TIPOS_DE_PRODUCTOS = New D_TIPOS_DE_PRODUCTOS

        D_tipos.D_getTiposAll_byCategoria_inactivos(aux_combobox, aux_id_categoria)

    End Sub

    Public Sub cargarCBO_activo_inactivo(ByVal aux_combobox As ComboBox, ByVal aux_id_categoria As Byte)
        Dim D_tipos As D_TIPOS_DE_PRODUCTOS = New D_TIPOS_DE_PRODUCTOS

        D_tipos.D_getTiposAll_byCategoria_activo_inactivo(aux_combobox, aux_id_categoria)

    End Sub

    Function Modificar_Tipo(ByVal p_id_categoria As Byte,
                           ByVal p_id_tipo As Short,
                           ByVal categoria As String,
                             ByVal p_tipo As String)
        'ByVal p_eliminado As String


        Dim oTipoprod = New TIPOS_DE_PRODUCTOS
        With oTipoprod
            .id_categoria = p_id_categoria
            .id_tipo = p_id_tipo
            .tipo = p_tipo
            '.eliminado = p_eliminado

        End With

        Dim agregar = d_tipos.DModificarTipo(oTipoprod)
        If agregar Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function borrar_tipos(ByVal aux_id_c As Byte, ByVal aux_id_t As Short) As Boolean
        Dim agregar As Boolean = d_tipos.D_borrar_tipo(aux_id_c, aux_id_t)
        If agregar Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function activar_tipos(ByVal aux_id_c As Byte, ByVal aux_id_t As Short) As Boolean
        Dim agregar As Boolean = d_tipos.D_activar_tipo(aux_id_c, aux_id_t)
        If agregar Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
