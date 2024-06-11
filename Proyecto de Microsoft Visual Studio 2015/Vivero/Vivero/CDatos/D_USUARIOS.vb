Public Class D_USUARIOS

    Dim ctx As DB_VIVEROEntities = New DB_VIVEROEntities

    Function Dguardar_usuario(ByVal e As USUARIOS) As Boolean
        Try
            ctx.USUARIOS.Add(e)
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            MsgBox("La operación falló, verifique que esa persona no se encuentre registrada en el sistema", MsgBoxStyle.Critical, "Error al guardar los datos")
            Return False
        End Try

    End Function

    Public Function D_getUsuariosAll(ByVal grid As DataGridView)
        Try
            Using ctx As New DB_VIVEROEntities
                Dim objetoMostrar = (From q In ctx.USUARIOS
                                     Where q.eliminado = "NO"
                                     Select Id_perfil = q.PERFILES.id_perfil,
                                         Perfil = q.PERFILES.perfil,
                                         Id_usuario = q.id_usuario,
                                         DNI = q.DNI,
                                         Apellido = q.apellido,
                                         Nombre = q.nombre,
                                         Fecha_nac = q.fecha_nac,
                                         Fecha_ingreso = q.fecha_ingreso,
                                         Username = q.username,
                                         Contraseña = q.contraseña,
                                         Direccion = q.direccion,
                                         Telefono = q.telefono,
                                         Email = q.email,
                                         Eliminado = q.eliminado
                             ).ToList
                grid.DataSource = objetoMostrar
                grid.Columns(0).Visible = False
                grid.Columns(2).Visible = False
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function D_getUsuariosAll_inactivos(ByVal grid As DataGridView)
        Try
            Using ctx As New DB_VIVEROEntities
                Dim objetoMostrar = (From q In ctx.USUARIOS
                                     Where q.eliminado = "SI"
                                     Select Id_perfil = q.PERFILES.id_perfil,
                                         Perfil = q.PERFILES.perfil,
                                         Id_usuario = q.id_usuario,
                                         DNI = q.DNI,
                                         Apellido = q.apellido,
                                         Nombre = q.nombre,
                                         Fecha_nac = q.fecha_nac,
                                         Fecha_ingreso = q.fecha_ingreso,
                                         Username = q.username,
                                         Contraseña = q.contraseña,
                                         Direccion = q.direccion,
                                         Telefono = q.telefono,
                                         Email = q.email,
                                         Eliminado = q.eliminado
                             ).ToList
                grid.DataSource = objetoMostrar
                grid.Columns(0).Visible = False
                grid.Columns(2).Visible = False
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Function Buscar_Nombre1(ByVal ape As String, grid As DataGridView)
        Try
            Using ctx As New DB_VIVEROEntities
                Dim listaUsuarios = (From q In ctx.USUARIOS
                                     Where (q.apellido.StartsWith(ape) = True) And q.eliminado = "NO"
                                     Select Id_perfil = q.PERFILES.id_perfil,
                                         Perfil = q.PERFILES.perfil,
                                         Id_usuario = q.id_usuario,
                                         DNI = q.DNI,
                                         Apellido = q.apellido,
                                         Nombre = q.nombre,
                                         Fecha_nac = q.fecha_nac,
                                         Fecha_ingreso = q.fecha_ingreso,
                                         Username = q.username,
                                         Contraseña = q.contraseña,
                                         Direccion = q.direccion,
                                         Telefono = q.telefono,
                                         Email = q.email,
                                         Eliminado = q.eliminado
                                         ).ToList

                If listaUsuarios.Count <> 0 Then
                    grid.DataSource = listaUsuarios
                    grid.Columns(0).Visible = False
                    grid.Columns(2).Visible = False
                Else
                    D_getUsuariosAll(grid)
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
                Dim listaUsuarios = (From q In ctx.USUARIOS
                                     Where (q.DNI = aux_dni) And q.eliminado = "NO"
                                     Select Id_perfil = q.PERFILES.id_perfil,
                                         Perfil = q.PERFILES.perfil,
                                         Id_usuario = q.id_usuario,
                                         DNI = q.DNI,
                                         Apellido = q.apellido,
                                         Nombre = q.nombre,
                                         Fecha_nac = q.fecha_nac,
                                         Fecha_ingreso = q.fecha_ingreso,
                                         Username = q.username,
                                         Contraseña = q.contraseña,
                                         Direccion = q.direccion,
                                         Telefono = q.telefono,
                                         Email = q.email,
                                         Eliminado = q.eliminado
                                         ).ToList

                If listaUsuarios.Count <> 0 Then
                    grid.DataSource = listaUsuarios
                    grid.Columns(0).Visible = False
                    grid.Columns(2).Visible = False
                Else
                    D_getUsuariosAll(grid)
                End If
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function DModificarUsuario(ByVal D_un_usuario As USUARIOS, ByVal p_nuevo_perfil As Byte)
        Try
            Using ctx As New DB_VIVEROEntities
                Dim objetomodif = (From c In ctx.USUARIOS
                                   Where c.id_usuario = D_un_usuario.id_usuario And c.id_perfil = D_un_usuario.id_perfil
                                   Select c).First


                ' Objeto Cliente a       Objeto Cliente obtenido
                '    Modificar              del form Modificar
                objetomodif.id_perfil = p_nuevo_perfil
                objetomodif.DNI = D_un_usuario.DNI
                objetomodif.apellido = D_un_usuario.apellido
                objetomodif.nombre = D_un_usuario.nombre
                objetomodif.fecha_ingreso = D_un_usuario.fecha_ingreso
                objetomodif.username = D_un_usuario.username
                objetomodif.contraseña = D_un_usuario.contraseña
                objetomodif.direccion = D_un_usuario.direccion
                objetomodif.telefono = D_un_usuario.telefono
                objetomodif.email = D_un_usuario.email




                ctx.SaveChanges()
            End Using
            Return True

        Catch ex As Exception
            MsgBox("La operación falló, verifique que esa persona no se encuentre registrada en el sistema", MsgBoxStyle.Critical, "Error al guardar los datos")
            Return False
        End Try
    End Function

    Public Function D_borrar_usuario(ByVal aux_id_perfil As Byte, ByVal aux_id_usuario As Short)
        Try
            Using ctx As New DB_VIVEROEntities
                Dim objetoBorrar = (From q In ctx.USUARIOS
                                    Where q.id_perfil = aux_id_perfil And q.id_usuario = aux_id_usuario
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

    Public Function D_activar_usuario(ByVal aux_id_perfil As Byte, ByVal aux_id_usuario As Short)
        Try
            Using ctx As New DB_VIVEROEntities
                Dim objetoBorrar = (From q In ctx.USUARIOS
                                    Where q.id_perfil = aux_id_perfil And q.id_usuario = aux_id_usuario
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

    Public Function Verificar_Usuario(ByVal aux_username As String, ByVal aux_password As String)
        Try
            Using ctx As New DB_VIVEROEntities
                Dim objetoVerificar = (From q In ctx.USUARIOS
                                       Where (q.username = aux_username And q.contraseña = aux_password) And q.eliminado = "NO"
                                       Select q).First()

            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function Verificar_Perfil(ByVal aux_username As String, ByVal aux_password As String, ByVal aux_usuario As USUARIOS)
        Try
            Using ctx As New DB_VIVEROEntities
                Dim objetoVerificar = (From q In ctx.USUARIOS
                                       Where (q.username = aux_username And q.contraseña = aux_password)
                                       Select q).First()
                aux_usuario = objetoVerificar
                Return aux_usuario
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Function Buscar_Nombre1_inactivos(ByVal ape As String, grid As DataGridView)
        Try
            Using ctx As New DB_VIVEROEntities
                Dim listaUsuarios = (From q In ctx.USUARIOS
                                     Where (q.apellido.StartsWith(ape) = True) And q.eliminado = "SI"
                                     Select Id_perfil = q.PERFILES.id_perfil,
                                         Perfil = q.PERFILES.perfil,
                                         Id_usuario = q.id_usuario,
                                         DNI = q.DNI,
                                         Apellido = q.apellido,
                                         Nombre = q.nombre,
                                         Fecha_nac = q.fecha_nac,
                                         Fecha_ingreso = q.fecha_ingreso,
                                         Username = q.username,
                                         Contraseña = q.contraseña,
                                         Direccion = q.direccion,
                                         Telefono = q.telefono,
                                         Email = q.email,
                                         Eliminado = q.eliminado
                                         ).ToList

                If listaUsuarios.Count <> 0 Then
                    grid.DataSource = listaUsuarios
                    grid.Columns(0).Visible = False
                    grid.Columns(2).Visible = False
                Else
                    D_getUsuariosAll_inactivos(grid)
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
                Dim listaUsuarios = (From q In ctx.USUARIOS
                                     Where (q.DNI = aux_dni) And q.eliminado = "SI"
                                     Select Id_perfil = q.PERFILES.id_perfil,
                                         Perfil = q.PERFILES.perfil,
                                         Id_usuario = q.id_usuario,
                                         DNI = q.DNI,
                                         Apellido = q.apellido,
                                         Nombre = q.nombre,
                                         Fecha_nac = q.fecha_nac,
                                         Fecha_ingreso = q.fecha_ingreso,
                                         Username = q.username,
                                         Contraseña = q.contraseña,
                                         Direccion = q.direccion,
                                         Telefono = q.telefono,
                                         Email = q.email,
                                         Eliminado = q.eliminado
                                         ).ToList

                If listaUsuarios.Count <> 0 Then
                    grid.DataSource = listaUsuarios
                    grid.Columns(0).Visible = False
                    grid.Columns(2).Visible = False
                Else
                    D_getUsuariosAll_inactivos(grid)
                End If
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function D_getUsuariosAll_activos_inactivos(ByVal grid As DataGridView)
        Try
            Using ctx As New DB_VIVEROEntities
                Dim objetoMostrar = (From q In ctx.USUARIOS
                                     Select Id_perfil = q.PERFILES.id_perfil,
                                         Perfil = q.PERFILES.perfil,
                                         Id_usuario = q.id_usuario,
                                         DNI = q.DNI,
                                         Apellido = q.apellido,
                                         Nombre = q.nombre,
                                         Fecha_nac = q.fecha_nac,
                                         Fecha_ingreso = q.fecha_ingreso,
                                         Username = q.username,
                                         Contraseña = q.contraseña,
                                         Direccion = q.direccion,
                                         Telefono = q.telefono,
                                         Email = q.email,
                                         Eliminado = q.eliminado
                             ).ToList
                grid.DataSource = objetoMostrar
                grid.Columns(0).Visible = False
                grid.Columns(2).Visible = False
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Function Buscar_Nombre1_activos_inactivos(ByVal ape As String, grid As DataGridView)
        Try
            Using ctx As New DB_VIVEROEntities
                Dim listaUsuarios = (From q In ctx.USUARIOS
                                     Where (q.apellido.StartsWith(ape) = True)
                                     Select Id_perfil = q.PERFILES.id_perfil,
                                         Perfil = q.PERFILES.perfil,
                                         Id_usuario = q.id_usuario,
                                         DNI = q.DNI,
                                         Apellido = q.apellido,
                                         Nombre = q.nombre,
                                         Fecha_nac = q.fecha_nac,
                                         Fecha_ingreso = q.fecha_ingreso,
                                         Username = q.username,
                                         Contraseña = q.contraseña,
                                         Direccion = q.direccion,
                                         Telefono = q.telefono,
                                         Email = q.email,
                                         Eliminado = q.eliminado
                                         ).ToList

                If listaUsuarios.Count <> 0 Then
                    grid.DataSource = listaUsuarios
                    grid.Columns(0).Visible = False
                    grid.Columns(2).Visible = False
                Else
                    D_getUsuariosAll_activos_inactivos(grid)
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
                Dim listaUsuarios = (From q In ctx.USUARIOS
                                     Where (q.DNI = aux_dni)
                                     Select Id_perfil = q.PERFILES.id_perfil,
                                         Perfil = q.PERFILES.perfil,
                                         Id_usuario = q.id_usuario,
                                         DNI = q.DNI,
                                         Apellido = q.apellido,
                                         Nombre = q.nombre,
                                         Fecha_nac = q.fecha_nac,
                                         Fecha_ingreso = q.fecha_ingreso,
                                         Username = q.username,
                                         Contraseña = q.contraseña,
                                         Direccion = q.direccion,
                                         Telefono = q.telefono,
                                         Email = q.email,
                                         Eliminado = q.eliminado
                                         ).ToList

                If listaUsuarios.Count <> 0 Then
                    grid.DataSource = listaUsuarios
                    grid.Columns(0).Visible = False
                    grid.Columns(2).Visible = False
                Else
                    D_getUsuariosAll_activos_inactivos(grid)
                End If
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function
End Class
