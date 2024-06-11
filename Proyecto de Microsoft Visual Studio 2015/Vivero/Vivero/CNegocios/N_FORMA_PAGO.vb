Public Class N_FORMA_PAGO

    Dim D_forma_pago As D_FORMA_PAGO = New D_FORMA_PAGO

    Public Sub cargarCBO(ByVal aux_combobox As ComboBox)
        Dim D_FORMA_PAGO As D_FORMA_PAGO = New D_FORMA_PAGO
        D_FORMA_PAGO.D_getFormaPagoAll(aux_combobox)
    End Sub
End Class
