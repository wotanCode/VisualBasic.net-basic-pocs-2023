Imports System.Data.SqlClient

Public Class Form1

    'Esta subrutina muestra la lista de alumnos con sus notas
    Sub MostrarLista()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrirConexionBBDD()
            da = New SqlDataAdapter("ObtenerDatosAlumnosYNotas", conexion)
            da.Fill(dt)
            DataGridView1_ListaAlumnos.DataSource = dt

            cerrarConexionBBDD()
        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Al iniciar la aplicación se conecta muestra automaticamente  la lista de alumnos.
    Private Sub UsuariosOk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'al nniciar el form muestra la data
        MostrarLista()
    End Sub

    'Con este boton ingresamos al formulario donde se ingresa un alumno nuevo.
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1_ingresarAlumnoFormOpen.Click
        Dim ingresarAlumnoForm As New IngresarAlumno()
        ingresarAlumnoForm.Show()
    End Sub

    'Click al boton para recargar la lista inicial
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        MostrarLista()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ingresarNotaForm As New IngresarNota()
        ingresarNotaForm.Show()
    End Sub
End Class
