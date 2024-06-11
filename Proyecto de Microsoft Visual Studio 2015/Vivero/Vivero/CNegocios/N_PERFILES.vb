Public Class N_PERFILES
    Dim D_perfiles As D_PERFILES = New D_PERFILES
    Public Sub cargarCBO(ByVal aux_combobox As ComboBox)
        Dim D_perfiles As D_PERFILES = New D_PERFILES

        D_perfiles.D_getPerfilesAll(aux_combobox)

    End Sub
End Class
