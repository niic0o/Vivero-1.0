Public Class N_CATEGORIAS

    Dim D_categoria As D_CATEGORIAS = New D_CATEGORIAS

    Function agregar_categoria(ByVal aux_categoria As String) As Boolean

        Dim E_una_categoria = New CATEGORIAS()
        Dim no As String = "NO"

        With E_una_categoria
            .categoria() = aux_categoria
            .eliminado() = no
        End With

        Dim D_una_categoria = New D_CATEGORIAS
        Dim agregar As Boolean = D_una_categoria.Dguardar_categoria(E_una_categoria)
        If agregar Then
            Return True
        Else
            Return False
        End If

    End Function


    Public Sub cargarCBO(ByVal aux_combobox As ComboBox)
        Dim D_categorias As D_CATEGORIAS = New D_CATEGORIAS

        Dim lista_categorias = D_categorias.D_getCategoriasAll()

        With aux_combobox
            .DataSource = lista_categorias
            .DisplayMember = "categoria"
            .ValueMember = "id_categoria"
            .SelectedValue = -1
        End With

    End Sub

    Public Sub cargarCBO_inactivos(ByVal aux_combobox As ComboBox)
        Dim D_categorias As D_CATEGORIAS = New D_CATEGORIAS

        Dim lista_categorias = D_categorias.D_getCategoriasAll_inactivos()

        With aux_combobox
            .DataSource = lista_categorias
            .DisplayMember = "categoria"
            .ValueMember = "id_categoria"
            .SelectedValue = -1
        End With

    End Sub

    Public Sub cargarCBO_solo_activos(ByVal aux_combobox As ComboBox)
        Dim D_categorias As D_CATEGORIAS = New D_CATEGORIAS

        Dim lista_categorias = D_categorias.D_getCategoriasAll_solo_activos()

        With aux_combobox
            .DataSource = lista_categorias
            .DisplayMember = "categoria"
            .ValueMember = "id_categoria"
            .SelectedValue = -1
        End With

    End Sub



    Public Function borrar_categoria(ByVal aux_id_c As Byte) As Boolean
        Dim agregar As Boolean = D_categoria.D_borrar_categoria(aux_id_c)
        If agregar Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function activar_categoria(ByVal aux_id_c As Byte) As Boolean
        Dim agregar As Boolean = D_categoria.D_activar_categoria(aux_id_c)
        If agregar Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub cargarGrid(ByVal grid As DataGridView)

        D_categoria.D_getCategorias_All(grid)
        grid.ClearSelection()
    End Sub

    Public Sub cargarGrid_inactivos(ByVal grid As DataGridView)

        D_categoria.D_getCategorias_All_inactivos(grid)
        grid.ClearSelection()
    End Sub

    Public Sub cargarGrid_solo_activos(ByVal grid As DataGridView)

        D_categoria.D_getCategorias_All_solo_activos(grid)
        grid.ClearSelection()
    End Sub

    Function Modificar_Categoria(ByVal p_id_categoria As Byte,
                            ByVal p_categoria As String)

        'ByVal p_eliminado As String


        Dim ocategoria = New CATEGORIAS
        With ocategoria
            .id_categoria = p_id_categoria
            '.categoria = p_categoria
            .categoria = p_categoria
            '.tipo = p_tipo
            '.eliminado = p_eliminado



        End With

        Dim agregar = D_categoria.DModificarCategoria(ocategoria)
        If agregar Then
            Return True
        Else
            Return False
        End If

    End Function
End Class
