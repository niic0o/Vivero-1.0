Imports System.Data.SqlClient

Public Class Backup
    Private Sub btnbackup_Click(sender As Object, e As EventArgs) Handles btnbackup.Click
        If MsgBox("¿Desea realizar copia de seguridad?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton1, "Gestión de Base de Datos") = MsgBoxResult.Yes Then

            Dim NOMBRE_BACKUP As String = "DB_VIVERO_" & Now.Day & "_" & Now.Month & "_" & Now.Year & "__" & Now.Hour & "_" & Now.Minute & "_" & ".bak"

            Dim CONEXION As SqlConnection = New SqlConnection(My.Settings.DB_VIVERO_conexion)

            Dim DEStinO_BACKUP As String = "C:\Nico UNNE\Clases virtuales 2021\Taller de Programación II (2021)\Microsoft Visual Studio 2015\Base de Datos\Backup\"

            Dim CMD As New SqlCommand("BACKUP DATABASE DB_VIVERO TO DISK='" & DEStinO_BACKUP & " " & NOMBRE_BACKUP & "' ", CONEXION)

            Try
                CONEXION.Open()
                CMD.ExecuteNonQuery()
                MsgBox("Back up realizado con exito", MsgBoxStyle.OkOnly + MsgBoxStyle.DefaultButton1 + MessageBoxIcon.Information)
            Catch EX As Exception
                MsgBox("ERROR AL GENERAR BACKUP", MsgBoxStyle.OkOnly + MsgBoxStyle.DefaultButton1 + MessageBoxIcon.Information)
            End Try
            CONEXION.Close()
        End If

    End Sub
End Class