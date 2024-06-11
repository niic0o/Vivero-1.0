Public Class D_CATEGORIAS

    Dim ctx As DB_VIVEROEntities = New DB_VIVEROEntities

    Function Dguardar_categoria(ByVal e As CATEGORIAS) As Boolean
        Try
            ctx.CATEGORIAS.Add(e)
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    'List es una coleccion de objetos, de tipo Categorias, cada objeto contendra un registro de la tabla, van a estar indexados asi que ojo con las posiciones.
    Function D_getCategoriasAll() As List(Of CATEGORIAS)
        Dim TablaCategorias = (From c In ctx.CATEGORIAS Select c).ToList

        Dim Lista_Categorias = New List(Of CATEGORIAS)
        For Each registro In TablaCategorias
            Dim una_fila As CATEGORIAS = New CATEGORIAS
            'relleno la lista vacia, con la lista traida de la bdd
            'relleno solo con los datos que quiero usar
            una_fila.id_categoria = registro.id_categoria
            una_fila.categoria = registro.categoria
            una_fila.eliminado = registro.eliminado
            Lista_Categorias.Add(una_fila)
        Next
        Return Lista_Categorias

    End Function

    Function D_getCategoriasAll_inactivos() As List(Of CATEGORIAS)
        Dim TablaCategorias = (From c In ctx.CATEGORIAS Select c).ToList

        Dim Lista_Categorias = New List(Of CATEGORIAS)
        For Each registro In TablaCategorias
            If registro.eliminado = "SI" Then
                Dim una_fila As CATEGORIAS = New CATEGORIAS
                una_fila.id_categoria = registro.id_categoria
                una_fila.categoria = registro.categoria
                una_fila.eliminado = registro.eliminado
                Lista_Categorias.Add(una_fila)
            End If
        Next
        Return Lista_Categorias

    End Function

    Function D_getCategoriasAll_solo_activos() As List(Of CATEGORIAS)
        Dim TablaCategorias = (From c In ctx.CATEGORIAS Select c).ToList

        Dim Lista_Categorias = New List(Of CATEGORIAS)
        For Each registro In TablaCategorias
            If registro.eliminado = "NO" Then
                Dim una_fila As CATEGORIAS = New CATEGORIAS
                una_fila.id_categoria = registro.id_categoria
                una_fila.categoria = registro.categoria
                una_fila.eliminado = registro.eliminado
                Lista_Categorias.Add(una_fila)
            End If
        Next
        Return Lista_Categorias

    End Function

    Public Function D_borrar_categoria(ByVal aux_id As Byte)
        Try
            Using ctx As New DB_VIVEROEntities
                Dim objetoBorrar = (From q In ctx.CATEGORIAS
                                    Where q.id_categoria = aux_id
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

    Public Function D_activar_categoria(ByVal aux_id As Byte)
        Try
            Using ctx As New DB_VIVEROEntities
                Dim objetoBorrar = (From q In ctx.CATEGORIAS
                                    Where q.id_categoria = aux_id
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

    Public Function D_getCategorias_All(ByVal grid As DataGridView)
        Try
            Using ctx As New DB_VIVEROEntities
                Dim objetoMostrar = (From q In ctx.CATEGORIAS
                                     Select Id_categoria = q.id_categoria,
                                                 Categoria = q.categoria,
                                         Eliminado = q.eliminado).ToList
                grid.DataSource = objetoMostrar
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function D_getCategorias_All_inactivos(ByVal grid As DataGridView)
        Try
            Using ctx As New DB_VIVEROEntities
                Dim objetoMostrar = (From q In ctx.CATEGORIAS
                                     Where q.eliminado = "SI"
                                     Select Id_categoria = q.id_categoria,
                                                 Categoria = q.categoria,
                                         Eliminado = q.eliminado).ToList
                grid.DataSource = objetoMostrar
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function D_getCategorias_All_solo_activos(ByVal grid As DataGridView)
        Try
            Using ctx As New DB_VIVEROEntities
                Dim objetoMostrar = (From q In ctx.CATEGORIAS
                                     Where q.eliminado = "NO"
                                     Select Id_categoria = q.id_categoria,
                                                 Categoria = q.categoria,
                                         Eliminado = q.eliminado).ToList
                grid.DataSource = objetoMostrar
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function DModificarCategoria(ByVal objcat As CATEGORIAS)
        Try
            Using ctx As New DB_VIVEROEntities
                Dim objetomodif = (From c In ctx.CATEGORIAS
                                   Where c.id_categoria = objcat.id_categoria
                                   Select c).First

                ' Objeto Cliente a       Objeto Cliente obtenido
                '    Modificar              del form Modificar
                objetomodif.id_categoria = objcat.id_categoria
                objetomodif.categoria = objcat.categoria
                'objetomodif.eliminado = objcat.eliminado               
                ctx.SaveChanges()
            End Using
            Return True

        Catch ex As Exception

            Return False
        End Try
    End Function
End Class
