'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class TIPOS_DE_PRODUCTOS
    Public Property id_categoria As Byte
    Public Property id_tipo As Short
    Public Property tipo As String
    Public Property eliminado As String

    Public Overridable Property CATEGORIAS As CATEGORIAS
    Public Overridable Property PRODUCTOS As ICollection(Of PRODUCTOS) = New HashSet(Of PRODUCTOS)

End Class
