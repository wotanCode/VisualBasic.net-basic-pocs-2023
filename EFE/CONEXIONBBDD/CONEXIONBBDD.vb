Imports System.Data.SqlClient

Module CONEXIONBBDD
    Public conexion As New SqlConnection("Data Source=WOTAN\SQLEXPRESS;Initial Catalog=FINAL;Integrated Security=True")
    '                                               Nombre de la conexion              NombreDeLaBD        Modo autenticación de windows sin contraseña
    'Subrutina para abrir la BBDD
    Sub abrirConexionBBDD()
        If conexion.State = 0 Then
            conexion.Open()
        End If
    End Sub

    'Subrutina para cerrar la BBDD
    Sub cerrarConexionBBDD()
        If conexion.State = 1 Then
            conexion.Close()
        End If
    End Sub
End Module
