Imports System.Data.SqlClient

Public Class EliminarPersona

    Private Sub BuscarPersona(rutABuscar As String)
        Try
            ' Abrir la conexión a la base de datos
            abrirConexionBBDD()

            ' Modificar la consulta para buscar por RUT
            Dim query As String = "SELECT * FROM Persona WHERE rut = @rut"

            ' Crear un nuevo comando SQL con la consulta y la conexión
            Using cmd As New SqlCommand(query, conexion)
                ' Configurar parámetro
                cmd.Parameters.AddWithValue("@rut", rutABuscar)

                ' Ejecutar la consulta y obtener un lector de datos
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    ' Verificar si se encontró un registro
                    If reader.Read() Then
                        ' Llenar los campos con los datos obtenidos
                        TextBox1_rut.Text = reader("rut").ToString()
                        TextBox2_nombre.Text = reader("nombreCompleto").ToString()
                        TextBox3_apellido1.Text = reader("apellidoPaterno").ToString()
                        TextBox4_apellido2.Text = reader("apellidoMaterno").ToString()
                        DateTimePicker1_fechaNacimiento.Text = reader("fechaNacimiento").ToString()
                        Button_eliminar.Enabled = True
                    Else
                        ' Si no se encontró un registro, puedes mostrar un mensaje indicando que no se encontró.
                        MessageBox.Show("No se encontró ninguna persona con el RUT proporcionado.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            ' Mostrar un mensaje de error si ocurre alguna excepción
            MessageBox.Show("Error al buscar en la base de datos. Detalles del error: " & ex.Message)
        Finally
            ' Cerrar la conexión a la base de datos
            cerrarConexionBBDD()
        End Try
    End Sub
    Private Sub BuscarButton_Click(sender As Object, e As EventArgs) Handles BuscarButton.Click
        ' Obtener el RUT a buscar desde el TextBox
        Dim rutABuscar As String = buscarRut.Text

        ' Llamar a la función que busca en la base de datos y llena los campos
        BuscarPersona(rutABuscar)
    End Sub

    Private Sub Button_eliminar_Click(sender As Object, e As EventArgs) Handles Button_eliminar.Click
        ' Obtener el RUT a eliminar desde el TextBox
        Dim rutAEliminar As String = TextBox1_rut.Text

        ' Verificar si el RUT está presente antes de intentar eliminar
        If Not String.IsNullOrEmpty(rutAEliminar) Then
            Try
                ' Abrir la conexión a la base de datos
                abrirConexionBBDD()

                ' Modificar la consulta para eliminar por RUT
                Dim query As String = "DELETE FROM Persona WHERE rut = @rut"

                ' Crear un nuevo comando SQL con la consulta y la conexión
                Using cmd As New SqlCommand(query, conexion)
                    ' Configurar parámetro
                    cmd.Parameters.AddWithValue("@rut", rutAEliminar)

                    ' Ejecutar la consulta
                    cmd.ExecuteNonQuery()

                    ' Mostrar mensaje de éxito
                    MessageBox.Show("Usuario eliminado correctamente.")

                    ' Limpiar campos después de eliminar
                    TextBox1_rut.Text = ""
                    TextBox2_nombre.Text = ""
                    TextBox3_apellido1.Text = ""
                    TextBox4_apellido2.Text = ""
                    DateTimePicker1_fechaNacimiento.Value = DateTime.Now
                End Using
            Catch ex As Exception
                ' Mostrar un mensaje de error si ocurre alguna excepción
                MessageBox.Show("Error al eliminar en la base de datos. Detalles del error: " & ex.Message)
            Finally
                ' Cerrar la conexión a la base de datos
                cerrarConexionBBDD()
            End Try
        Else
            ' Mostrar mensaje indicando que el RUT es inválido
            MessageBox.Show("RUT inválido. Por favor, realice una búsqueda antes de intentar eliminar.")
        End If
    End Sub
End Class