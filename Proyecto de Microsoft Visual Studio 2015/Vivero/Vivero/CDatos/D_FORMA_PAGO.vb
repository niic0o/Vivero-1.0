Public Class D_FORMA_PAGO
    Dim ctx As DB_VIVEROEntities = New DB_VIVEROEntities

    Public Function D_getFormaPagoAll(ByVal aux_combobox As ComboBox)
        Try
            Using ctx As New DB_VIVEROEntities
                Dim objetoMostrar = (From q In ctx.FORMAS_DE_PAGO
                                     Select id_fdepago = q.id_FdePago,
                                            FdePago = q.FdePago).ToList
                With aux_combobox
                    .DataSource = objetoMostrar
                    .DisplayMember = "FdePago"
                    .ValueMember = "Id_FdePago"
                    .SelectedValue = -1
                End With
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
