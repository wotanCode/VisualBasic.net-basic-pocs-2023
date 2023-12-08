Imports System.Data.SqlClient
Public Class IngresarAlumno
    ' Boton para ingresar alumnos segun los campos
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            ' Obtener los datos del formulario
            Dim nombre As String = TextBox1.Text
            Dim apellido As String = TextBox2.Text
            Dim rut As String = TextBox3.Text

            ' Llamar al stored procedure para insertar el nuevo alumno
            InsertarAlumno(rut, nombre, apellido)

            ' Mostrar un mensaje de éxito o realizar alguna acción adicional si es necesario
            MessageBox.Show("Alumno ingresado exitosamente.")

            ' Limpiar los campos después de la inserción
            LimpiarCampos()

        Catch ex As Exception
            MessageBox.Show("Error al ingresar el alumno. Detalles del error: " & ex.Message)
        End Try
    End Sub

    ' Función para insertar un nuevo alumno mediante un stored procedure
    Private Sub InsertarAlumno(rut As String, nombre As String, apellido As String)
        Try
            ' Abrir la conexión antes de ejecutar el comando
            abrirConexionBBDD()

            ' Obtener el próximo ID disponible pasando la conexión abierta
            Dim siguienteID As Integer = ObtenerSiguienteID(conexion)

            ' Crear y configurar el comando para ejecutar el stored procedure
            Dim cmd As New SqlCommand("InsertarAlumno", conexion)
            cmd.CommandType = CommandType.StoredProcedure

            ' Agregar parámetros al comando, incluyendo el ID obtenido
            cmd.Parameters.AddWithValue("@idAlumno", siguienteID)
            cmd.Parameters.AddWithValue("@rut", rut)
            cmd.Parameters.AddWithValue("@nombre", nombre)
            cmd.Parameters.AddWithValue("@apellido", apellido)

            ' Ejecutar el comando
            cmd.ExecuteNonQuery()

            ' Mostrar un mensaje de éxito o realizar alguna acción adicional si es necesario
            MessageBox.Show("Alumno ingresado exitosamente.")

            ' Limpiar los campos después de la inserción
            LimpiarCampos()

        Catch ex As Exception
            Throw New Exception("Error al insertar alumno en la base de datos. Detalles del error: " & ex.Message)
        Finally
            ' Cerrar la conexión después de ejecutar el comando
            cerrarConexionBBDD()
        End Try
    End Sub

    ' Función para obtener el próximo ID disponible
    Private Function ObtenerSiguienteID(conexion As SqlConnection) As Integer
        Dim siguienteID As Integer = 1 ' Valor predeterminado si no hay registros

        Try
            ' Consulta para obtener el máximo ID actual
            Dim query As String = "SELECT MAX(idAlumno) FROM Alumno"
            Dim cmd As New SqlCommand(query, conexion)

            ' No es necesario abrir la conexión aquí, ya que se espera que esté abierta cuando se llama a esta función
            Dim result As Object = cmd.ExecuteScalar()

            ' Incrementar el máximo ID obtenido
            If result IsNot DBNull.Value Then
                siguienteID = Convert.ToInt32(result) + 1
            End If

        Catch ex As Exception
            Throw New Exception("Error al obtener el próximo ID disponible. Detalles del error: " & ex.Message)
        End Try

        Return siguienteID
    End Function

    ' Función para limpiar los campos después de la inserción
    Private Sub LimpiarCampos()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub
End Class