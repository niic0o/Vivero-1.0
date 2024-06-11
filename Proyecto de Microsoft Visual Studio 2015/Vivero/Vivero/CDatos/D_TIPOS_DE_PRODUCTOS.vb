Public Class D_TIPOS_DE_PRODUCTOS
    Dim ctx As DB_VIVEROEntities = New DB_VIVEROEntities

    Function getTipos_byCategoria(ByVal id_categoria As Byte) As List(Of TIPOS_DE_PRODUCTOS)
        Dim listatipos = (From c In ctx.TIPOS_DE_PRODUCTOS
                          Where c.CATEGORIAS.eliminado = "NO" And c.id_categoria = id_categoria And c.eliminado = "NO"
                          Select c).ToList
        Return listatipos

    End Function

    Function getTipos_byCategoria_inactivos(ByVal id_categoria As Byte) As List(Of TIPOS_DE_PRODUCTOS)
        Dim listatipos = (From c In ctx.TIPOS_DE_PRODUCTOS
                          Where c.CATEGORIAS.eliminado = "NO" And c.id_categoria = id_categoria And c.eliminado = "SI"
                          Select c).ToList
        Return listatipos

    End Function

    Function getTipos_byCategoria_activo_inactivo(ByVal id_categoria As Byte) As List(Of TIPOS_DE_PRODUCTOS)
        Dim listatipos = (From c In ctx.TIPOS_DE_PRODUCTOS
                          Where c.CATEGORIAS.eliminado = "NO" And c.id_categoria = id_categoria
                          Select c).ToList
        Return listatipos

    End Function

    Function Dguardar_tipo(ByVal e As TIPOS_DE_PRODUCTOS) As Boolean
        Try
            ctx.TIPOS_DE_PRODUCTOS.Add(e)
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function D_getTiposAll(ByVal grid As DataGridView)
        Try
            Using ctx As New DB_VIVEROEntities
                Dim objetoMostrar = (From q In ctx.TIPOS_DE_PRODUCTOS
                                     Where q.CATEGORIAS.eliminado = "NO" And q.eliminado = "NO"
                                     Select Id_categoria = q.id_categoria,
                                                 Categoria = q.CATEGORIAS.categoria,
                                                 Id_tipo = q.id_tipo,
                                                 Tipo = q.tipo,
                                         Eliminado = q.eliminado).ToList
                grid.DataSource = objetoMostrar
                grid.Columns("Id_categoria").Visible = False
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function D_getTiposAll_inactivos(ByVal grid As DataGridView)
        Try
            Using ctx As New DB_VIVEROEntities
                Dim objetoMostrar = (From q In ctx.TIPOS_DE_PRODUCTOS
                                     Where q.CATEGORIAS.eliminado = "NO" And q.eliminado = "SI"
                                     Select Id_categoria = q.id_categoria,
                                                 Categoria = q.CATEGORIAS.categoria,
                                                 Id_tipo = q.id_tipo,
                                                 Tipo = q.tipo,
                                         Eliminado = q.eliminado).ToList
                grid.DataSource = objetoMostrar
                grid.Columns("Id_categoria").Visible = False
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function D_getTiposAll_activo_inactivo(ByVal grid As DataGridView)
        Try
            Using ctx As New DB_VIVEROEntities
                Dim objetoMostrar = (From q In ctx.TIPOS_DE_PRODUCTOS
                                     Where q.CATEGORIAS.eliminado = "NO"
                                     Select Id_categoria = q.id_categoria,
                                                 Categoria = q.CATEGORIAS.categoria,
                                                 Id_tipo = q.id_tipo,
                                                 Tipo = q.tipo,
                                         Eliminado = q.eliminado).ToList
                grid.DataSource = objetoMostrar
                grid.Columns("Id_categoria").Visible = False
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function D_getTiposAll_byCategoria(ByVal aux_cbo As ComboBox, ByVal aux_id_categoria As Byte)
        Try
            Using ctx As New DB_VIVEROEntities
                Dim objetoMostrar = (From q In ctx.TIPOS_DE_PRODUCTOS
                                     Where aux_id_categoria = q.id_categoria And q.eliminado = "NO"
                                     Select Id_categoria = q.id_categoria,
                                                 Categoria = q.CATEGORIAS.categoria,
                                                 Id_tipo = q.id_tipo,
                                                 Tipo = q.tipo,
                                         Eliminado = q.eliminado
                                         ).ToList
                With aux_cbo
                    .DataSource = objetoMostrar
                    .DisplayMember = "tipo"
                    .ValueMember = "id_tipo"
                    .SelectedValue = -1
                End With
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function D_getTiposAll_byCategoria_inactivos(ByVal aux_cbo As ComboBox, ByVal aux_id_categoria As Byte)
        Try
            Using ctx As New DB_VIVEROEntities
                Dim objetoMostrar = (From q In ctx.TIPOS_DE_PRODUCTOS
                                     Where q.CATEGORIAS.eliminado = "NO" And aux_id_categoria = q.id_categoria And q.eliminado = "SI"
                                     Select Id_categoria = q.id_categoria,
                                                 Categoria = q.CATEGORIAS.categoria,
                                                 Id_tipo = q.id_tipo,
                                                 Tipo = q.tipo,
                                         Eliminado = q.eliminado
                                         ).ToList
                With aux_cbo
                    .DataSource = objetoMostrar
                    .DisplayMember = "tipo"
                    .ValueMember = "id_tipo"
                    .SelectedValue = -1
                End With
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function D_getTiposAll_byCategoria_activo_inactivo(ByVal aux_cbo As ComboBox, ByVal aux_id_categoria As Byte)
        Try
            Using ctx As New DB_VIVEROEntities
                Dim objetoMostrar = (From q In ctx.TIPOS_DE_PRODUCTOS
                                     Where q.CATEGORIAS.eliminado = "NO" And aux_id_categoria = q.id_categoria
                                     Select Id_categoria = q.id_categoria,
                                                 Categoria = q.CATEGORIAS.categoria,
                                                 Id_tipo = q.id_tipo,
                                                 Tipo = q.tipo,
                                         Eliminado = q.eliminado
                                         ).ToList
                With aux_cbo
                    .DataSource = objetoMostrar
                    .DisplayMember = "tipo"
                    .ValueMember = "id_tipo"
                    .SelectedValue = -1
                End With
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    '  Function no_funciona_D_getTiposAll() As List(Of TIPOS_DE_PRODUCTOS)
    'Dim TablaTipos = (From c In ctx.TIPOS_DE_PRODUCTOS Select c.id_categoria, 'c.CATEGORIAS.categoria, c.id_tipo, c.tipo, c.eliminado).ToList
    '
    'Dim Lista_Tipos = New List(Of TIPOS_DE_PRODUCTOS)
    'For Each registro In TablaTipos
    ' Dim una_fila As TIPOS_DE_PRODUCTOS = New TIPOS_DE_PRODUCTOS
    '  Dim una_fila_ajena As CATEGORIAS = New CATEGORIAS
    '  'relleno la lista vacia, con la lista traida de la bdd
    ''relleno solo con los datos que quiero usar
    '        una_fila_ajena.id_categoria = registro.id_categoria
    '           una_fila_ajena.categoria = registro.categoria
    ' With una_fila
    ' .CATEGORIAS() = una_fila_ajena
    ''.CATEGORIAS.categoria = registro.categoria
    ''.CATEGORIAS.id_categoria() = registro.id_categoria
    '  '.CATEGORIAS.categoria() = registro.categoria
    ' .id_categoria() = registro.id_categoria
    ' .id_tipo = registro.id_tipo
    '.tipo = registro.tipo
    'End With
    '        Lista_Tipos.Add(una_fila)
    'Next
    'Return Lista_Tipos
    '
    'End Function

    Public Function D_borrar_tipo(ByVal aux_id_c As Byte, ByVal aux_id_t As Short)
        Try
            Using ctx As New DB_VIVEROEntities
                Dim objetoBorrar = (From q In ctx.TIPOS_DE_PRODUCTOS
                                    Where (q.id_categoria = aux_id_c And q.id_tipo = aux_id_t)
                                    Select q).First()

                If objetoBorrar.eliminado = "NO" Then
                    objetoBorrar.eliminado = "SI"
                    ctx.SaveChanges()
                Else
                    Return False
                End If

            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function D_activar_tipo(ByVal aux_id_c As Byte, ByVal aux_id_t As Short)
        Try
            Using ctx As New DB_VIVEROEntities
                Dim objetoBorrar = (From q In ctx.TIPOS_DE_PRODUCTOS
                                    Where (q.id_categoria = aux_id_c And q.id_tipo = aux_id_t)
                                    Select q).First()

                If objetoBorrar.eliminado = "SI" Then
                    objetoBorrar.eliminado = "NO"
                    ctx.SaveChanges()
                Else
                    Return False
                End If

            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function DModificarTipo(ByVal objTipo As TIPOS_DE_PRODUCTOS)
        Try
            Using ctx As New DB_VIVEROEntities
                Dim objetomodif = (From c In ctx.TIPOS_DE_PRODUCTOS
                                   Where c.id_categoria = objTipo.id_categoria
                                   Select c).First

                ' Objeto Cliente a       Objeto Cliente obtenido
                '    Modificar              del form Modificar
                'objetomodif.id_categoria = objTipo.id_categoria
                'objetomodif.id_tipo = objTipo.id_tipo
                objetomodif.tipo = objTipo.tipo
                'objetomodif.eliminado = objTipo.eliminado



                ctx.SaveChanges()
            End Using
            Return True

        Catch ex As Exception

            Return False
        End Try
    End Function

    'Public Function D_getTiposAll() As DataTable
    '
    'Using cnn As New SqlConnection(
    '      "Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=DB_VIVERO;Integrated 'Security=True")
    '
    'Dim sql As String =
    '       "Select p.id_categoria, p.id_tipo, p.tipo" &
    '       "FROM TIPOS_DE_PRODUCTOS p JOIN CATEGORIAS e" &
    '       "On p.id_categoria = e.id_categoria"
    '
    'Dim da As New SqlDataAdapter(sql, cnn)

    'Dim dt As New DataTable("TiposDeProductos_Personas")

    '        da.Fill(dt)

    'Return dt

    'End Using

    ' End Function

End Class
