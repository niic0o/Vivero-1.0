Public Class D_CLIENTES
    Dim ctx As DB_VIVEROEntities = New DB_VIVEROEntities

    Function Dguardar_cliente(ByVal e As CLIENTES) As Boolean
        Try
            ctx.CLIENTES.Add(e)
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function D_getClientesAll(ByVal grid As DataGridView)
        Try
            Using ctx As New DB_VIVEROEntities
                Dim objetoMostrar = (From q In ctx.CLIENTES
                                     Where q.eliminado = "NO"
                                     Select Id_cliente = q.id_cliente,
                                         DNI = q.DNI,
                                         Apellido = q.apellido,
                                         Nombre = q.nombre,
                                         Email = q.email,
                                         Telefono = q.telefono,
                                         Direccion = q.direccion,
                                         Provincia = q.provincia,
                                         Localidad = q.localidad,
                                         Eliminado = q.eliminado
                                         ).ToList
                grid.DataSource = objetoMostrar
                grid.Columns(0).Visible = False
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Function Buscar_Nombre1(ByVal ape As String, grid As DataGridView)
        Try
            Using ctx As New DB_VIVEROEntities
                Dim listaCliente = (From q In ctx.CLIENTES
                                    Where (q.apellido.StartsWith(ape) = True) And q.eliminado = "NO"
                                    Select Id_cliente = q.id_cliente,
                                         DNI = q.DNI,
                                         Apellido = q.apellido,
                                         Nombre = q.nombre,
                                         Email = q.email,
                                         Telefono = q.telefono,
                                         Direccion = q.direccion,
                                         Provincia = q.provincia,
                                         Localidad = q.localidad,
                                        Eliminado = q.eliminado
                                         ).ToList

                If listaCliente.Count <> 0 Then
                    grid.DataSource = listaCliente
                    grid.Columns(0).Visible = False
                Else
                    D_getClientesAll(grid)
                End If
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Function Buscar_DNI1(ByVal aux_dni As Integer, grid As DataGridView)
        Try
            Using ctx As New DB_VIVEROEntities
                Dim listaCliente = (From q In ctx.CLIENTES
                                    Where (q.DNI = aux_dni) And q.eliminado = "NO"
                                    Select Id_cliente = q.id_cliente,
                                         DNI = q.DNI,
                                         Apellido = q.apellido,
                                         Nombre = q.nombre,
                                         Email = q.email,
                                         Telefono = q.telefono,
                                         Direccion = q.direccion,
                                         Provincia = q.provincia,
                                         Localidad = q.localidad,
                                         Eliminado = q.eliminado
                                         ).ToList

                If listaCliente.Count <> 0 Then
                    grid.DataSource = listaCliente
                    grid.Columns(0).Visible = False
                Else
                    D_getClientesAll(grid)
                End If
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function DModificarCliente(ByVal objCliente As CLIENTES)
        Try
            Using ctx As New DB_VIVEROEntities

                Dim objetomodif = (From c In ctx.CLIENTES
                                   Where c.id_cliente = objCliente.id_cliente
                                   Select c).First
                ' Objeto Cliente a       Objeto Cliente obtenido
                '    Modificar              del form Modificar
                objetomodif.apellido = objCliente.apellido
                objetomodif.nombre = objCliente.nombre
                objetomodif.DNI = objCliente.DNI
                objetomodif.email = objCliente.email
                objetomodif.telefono = objCliente.telefono
                objetomodif.direccion = objCliente.direccion
                objetomodif.provincia = objCliente.provincia
                objetomodif.localidad = objCliente.localidad

                ctx.SaveChanges()
            End Using
            Return True
            MsgBox("La operación falló, verifique que esa persona no se encuentre registrada en el sistema", MsgBoxStyle.Critical, "Error al guardar los datos")
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function D_borrar_cliente(ByVal aux_id As Integer)
        Try
            Using ctx As New DB_VIVEROEntities
                Dim objetoBorrar = (From q In ctx.CLIENTES
                                    Where q.id_cliente = aux_id
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

    Public Function D_activar_cliente(ByVal aux_id As Integer)
        Try
            Using ctx As New DB_VIVEROEntities
                Dim objetoBorrar = (From q In ctx.CLIENTES
                                    Where q.id_cliente = aux_id
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

    Function Listar_CLHabilitados() As List(Of CLIENTES)
        Dim listaCliente = (From c In ctx.CLIENTES Where c.eliminado = "si" Select c).ToList
        Return listaCliente
    End Function

    Function Listar_CLInhabilitados() As List(Of CLIENTES)
        Dim listaCliente = (From c In ctx.CLIENTES Where c.eliminado = "no" Select c).ToList
        Return listaCliente
    End Function

    '''' eliminados
    Public Function D_getClientesAll_inactivos(ByVal grid As DataGridView)
        Try
            Using ctx As New DB_VIVEROEntities
                Dim objetoMostrar = (From q In ctx.CLIENTES
                                     Where q.eliminado = "SI"
                                     Select Id_cliente = q.id_cliente,
                                         DNI = q.DNI,
                                         Apellido = q.apellido,
                                         Nombre = q.nombre,
                                         Email = q.email,
                                         Telefono = q.telefono,
                                         Direccion = q.direccion,
                                         Provincia = q.provincia,
                                         Localidad = q.localidad,
                                         Eliminado = q.eliminado
                                         ).ToList
                grid.DataSource = objetoMostrar
                grid.Columns(0).Visible = False
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Function Buscar_Nombre1_inactivos(ByVal ape As String, grid As DataGridView)
        Try
            Using ctx As New DB_VIVEROEntities
                Dim listaCliente = (From q In ctx.CLIENTES
                                    Where (q.apellido.StartsWith(ape) = True) And q.eliminado = "SI"
                                    Select Id_cliente = q.id_cliente,
                                         DNI = q.DNI,
                                         Apellido = q.apellido,
                                         Nombre = q.nombre,
                                         Email = q.email,
                                         Telefono = q.telefono,
                                         Direccion = q.direccion,
                                         Provincia = q.provincia,
                                         Localidad = q.localidad,
                                        Eliminado = q.eliminado
                                         ).ToList

                If listaCliente.Count <> 0 Then
                    grid.DataSource = listaCliente
                    grid.Columns(0).Visible = False
                Else
                    D_getClientesAll_inactivos(grid)
                End If
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Function Buscar_DNI1_inactivos(ByVal aux_dni As Integer, grid As DataGridView)
        Try
            Using ctx As New DB_VIVEROEntities
                Dim listaCliente = (From q In ctx.CLIENTES
                                    Where (q.DNI = aux_dni) And q.eliminado = "SI"
                                    Select Id_cliente = q.id_cliente,
                                         DNI = q.DNI,
                                         Apellido = q.apellido,
                                         Nombre = q.nombre,
                                         Email = q.email,
                                         Telefono = q.telefono,
                                         Direccion = q.direccion,
                                         Provincia = q.provincia,
                                         Localidad = q.localidad,
                                         Eliminado = q.eliminado
                                         ).ToList

                If listaCliente.Count <> 0 Then
                    grid.DataSource = listaCliente
                    grid.Columns(0).Visible = False
                Else
                    D_getClientesAll_inactivos(grid)
                End If
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    '''' activos e inactivos
    Public Function D_getClientesAll_activos_inactivos(ByVal grid As DataGridView)
        Try
            Using ctx As New DB_VIVEROEntities
                Dim objetoMostrar = (From q In ctx.CLIENTES
                                     Select Id_cliente = q.id_cliente,
                                         DNI = q.DNI,
                                         Apellido = q.apellido,
                                         Nombre = q.nombre,
                                         Email = q.email,
                                         Telefono = q.telefono,
                                         Direccion = q.direccion,
                                         Provincia = q.provincia,
                                         Localidad = q.localidad,
                                         Eliminado = q.eliminado
                                         ).ToList
                grid.DataSource = objetoMostrar
                grid.Columns(0).Visible = False
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Function Buscar_Nombre1_activos_inactivos(ByVal ape As String, grid As DataGridView)
        Try
            Using ctx As New DB_VIVEROEntities
                Dim listaCliente = (From q In ctx.CLIENTES
                                    Where (q.apellido.StartsWith(ape) = True)
                                    Select Id_cliente = q.id_cliente,
                                         DNI = q.DNI,
                                         Apellido = q.apellido,
                                         Nombre = q.nombre,
                                         Email = q.email,
                                         Telefono = q.telefono,
                                         Direccion = q.direccion,
                                         Provincia = q.provincia,
                                         Localidad = q.localidad,
                                        Eliminado = q.eliminado
                                         ).ToList

                If listaCliente.Count <> 0 Then
                    grid.DataSource = listaCliente
                    grid.Columns(0).Visible = False
                Else
                    D_getClientesAll_activos_inactivos(grid)
                End If
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Function Buscar_DNI1_activos_inactivos(ByVal aux_dni As Integer, grid As DataGridView)
        Try
            Using ctx As New DB_VIVEROEntities
                Dim listaCliente = (From q In ctx.CLIENTES
                                    Where (q.DNI = aux_dni)
                                    Select Id_cliente = q.id_cliente,
                                         DNI = q.DNI,
                                         Apellido = q.apellido,
                                         Nombre = q.nombre,
                                         Email = q.email,
                                         Telefono = q.telefono,
                                         Direccion = q.direccion,
                                         Provincia = q.provincia,
                                         Localidad = q.localidad,
                                         Eliminado = q.eliminado
                                         ).ToList

                If listaCliente.Count <> 0 Then
                    grid.DataSource = listaCliente
                    grid.Columns(0).Visible = False
                Else
                    D_getClientesAll_activos_inactivos(grid)
                End If
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function
End Class
