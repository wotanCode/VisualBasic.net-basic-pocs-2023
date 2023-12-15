Imports System.Data.SqlClient

Public Class EditarTelefono
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
                        TextBox14_telefonoFijo.Text = reader("telefonoFijo").ToString()
                        TextBox15_telefonoMovil.Text = reader("telefonoMovil").ToString()
                        Button_Modificar.Enabled = True
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

    Private Sub ActualizarTelefonoEnBD(rut As String, nuevoTelefonoFijo As String, nuevoTelefonoMovil As String)
        Try
            ' Abrir la conexión a la base de datos
            abrirConexionBBDD()

            ' Modificar la consulta para actualizar solo los teléfonos
            Dim query As String = "UPDATE Persona SET telefonoFijo = @nuevoTelefonoFijo, telefonoMovil = @nuevoTelefonoMovil WHERE rut = @rut"

            ' Crear un nuevo comando SQL con la consulta y la conexión
            Using cmd As New SqlCommand(query, conexion)
                ' Configurar parámetros
                cmd.Parameters.AddWithValue("@rut", rut)
                cmd.Parameters.AddWithValue("@nuevoTelefonoFijo", nuevoTelefonoFijo)
                cmd.Parameters.AddWithValue("@nuevoTelefonoMovil", nuevoTelefonoMovil)

                ' Ejecutar la consulta
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            ' Mostrar un mensaje de error si ocurre alguna excepción
            MessageBox.Show("Error al actualizar el teléfono en la base de datos. Detalles del error: " & ex.Message)
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_Modificar.Click
        ' Obtener el RUT seleccionado
        Dim rutSeleccionado As String = TextBox1_rut.Text

        ' Obtener los nuevos teléfonos ingresados por el usuario
        Dim nuevoTelefonoFijo As String = TextBox14_telefonoFijo.Text
        Dim nuevoTelefonoMovil As String = TextBox15_telefonoMovil.Text

        ' Llamar al método para actualizar el teléfono en la base de datos
        ActualizarTelefonoEnBD(rutSeleccionado, nuevoTelefonoFijo, nuevoTelefonoMovil)

        ' Mensaje indicando que la actualización se realizó con éxito
        MessageBox.Show("Teléfono actualizado correctamente en la base de datos.")
    End Sub
End Class