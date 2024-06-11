Public Class D_PERFILES

    Dim ctx As DB_VIVEROEntities = New DB_VIVEROEntities


    Public Function D_getPerfilesAll(ByVal aux_combobox As ComboBox)
        Try
            Using ctx As New DB_VIVEROEntities
                Dim objetoMostrar = (From q In ctx.PERFILES
                                     Select Id_perfil = q.id_perfil,
                                            Perfil = q.perfil).ToList
                With aux_combobox
                    .DataSource = objetoMostrar
                    .DisplayMember = "Perfil"
                    .ValueMember = "Id_perfil"
                    .SelectedValue = -1
                End With
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
