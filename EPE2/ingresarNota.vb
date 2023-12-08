Imports System.Data.SqlClient
Public Class IngresarNota
    Private Sub ingresarNota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Al cargar el formulario, carga la lista de alumnos en el ComboBox
        CargarAlumnosEnComboBox()
        ' Cargar la lista de asignaturas en ComboBox3_asignatura
        CargarAsignaturasEnComboBox()
    End Sub

    ' Suponiendo que tienes una función ObtenerAlumnos que retorna un DataTable con los nombres de los alumnos
    Private Sub CargarAlumnosEnComboBox()
        Try
            abrirConexionBBDD()
            ' Modificar la consulta para incluir el campo 'rut'
            Dim query As String = "SELECT idAlumno, CONCAT(nombre, ' ', apellido, ' - ', rut) AS NombreCompleto FROM Alumno"
            Dim cmd As New SqlCommand(query, conexion)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)

            ' Configurar el ComboBox
            ComboBox1.DataSource = dataTable
            ComboBox1.DisplayMember = "NombreCompleto"
            ComboBox1.ValueMember = "idAlumno"

            cerrarConexionBBDD()
        Catch ex As Exception
            MessageBox.Show("Error al cargar la lista de alumnos. Detalles del error: " & ex.Message)
        End Try
    End Sub

    ' Cargar la lista de asignaturas en ComboBox3_asignatura
    Private Sub CargarAsignaturasEnComboBox()
        Try
            abrirConexionBBDD()
            Dim query As String = "SELECT idAsignatura, nombre FROM Asignatura"
            Dim cmd As New SqlCommand(query, conexion)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)

            ' Configurar el ComboBox3_asignatura
            ComboBox3_asignatura.DataSource = dataTable
            ComboBox3_asignatura.DisplayMember = "nombre"
            ComboBox3_asignatura.ValueMember = "idAsignatura"

            cerrarConexionBBDD()
        Catch ex As Exception
            MessageBox.Show("Error al cargar la lista de asignaturas. Detalles del error: " & ex.Message)
        End Try
    End Sub

    ' Evento que se ejecuta al hacer clic en el botón para guardar la nota
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            ' Obtener los datos del formulario
            Dim idAlumno As Integer = Convert.ToInt32(ComboBox1.SelectedValue)
            Dim nombreCurso As Integer = Convert.ToInt32(ComboBox2_curso.SelectedValue)
            Dim idAsignatura As Integer = Convert.ToInt32(ComboBox3_asignatura.SelectedValue)
            'Dim ponderacion As Integer = Convert.ToInt32(ComboBox4_control.SelectedValue)
            Dim ponderacion As Decimal = Convert.ToDecimal(ComboBox4_control.SelectedValue)

            Dim nota As Integer = Convert.ToInt32(TextBox1.Text)

            ' Verificar que el ID de asignatura sea válido
            If idAsignatura > 0 Then
                ' Llamar al stored procedure para insertar la nueva nota
                InsertarNota(idAlumno, idAsignatura, ponderacion, nombreCurso, nota)
                'Button2_Click(ponderacion)

                ' Mostrar un mensaje de éxito o realizar alguna acción adicional si es necesario
                MessageBox.Show("Nota ingresada exitosamente.")

                ' Limpiar los campos después de la inserción
                LimpiarCampos()
            Else
                MessageBox.Show("Seleccione una asignatura válida antes de ingresar la nota.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error al ingresar la nota. Detalles del error: " & ex.Message)
        End Try
    End Sub

    Private Sub InsertarNota(idAlumno As Integer, idAsignatura As Integer, ponderacion As Decimal, nombreCurso As String, nota As Integer)
        Try
            ' Obtener los próximos IDs disponibles (parche temporal)
            Dim siguienteIDNota As Integer = ObtenerSiguienteID("Nota")
            Dim siguienteIDControl As Integer = ObtenerSiguienteID("Control")
            Dim siguienteIDCurso As Integer = ObtenerSiguienteID("Curso")

            abrirConexionBBDD()

            ' Obtener la fecha actual
            Dim fechaActual As DateTime = DateTime.Now

            ' Insertar en la tabla Control
            Dim cmdControl As New SqlCommand("INSERT INTO Control (idControl, fecha, ponderacion) " &
                                          "VALUES (@idControl, @fecha, @ponderacion)", conexion)

            ' Agregar parámetros al comando para la tabla Control
            cmdControl.Parameters.AddWithValue("@idControl", siguienteIDControl)
            cmdControl.Parameters.AddWithValue("@fecha", fechaActual)
            cmdControl.Parameters.AddWithValue("@ponderacion", ponderacion)

            ' Ejecutar el comando para la tabla Control
            cmdControl.ExecuteNonQuery()

            ' Insertar en la tabla Curso
            Dim cmdCurso As New SqlCommand("INSERT INTO Curso (idCurso, nombreCurso) " &
                                       "VALUES (@idCurso, @nombreCurso)", conexion)

            ' Agregar parámetros al comando para la tabla Curso
            cmdCurso.Parameters.AddWithValue("@idCurso", siguienteIDCurso)
            cmdCurso.Parameters.AddWithValue("@nombreCurso", nombreCurso)

            ' Ejecutar el comando para la tabla Curso
            cmdCurso.ExecuteNonQuery()

            ' Insertar en la tabla Nota
            Dim cmdNota As New SqlCommand("INSERT INTO Nota (idNota, idAlumno, idAsignatura, idControl, idCurso, nota) " &
                                      "VALUES (@idNota, @idAlumno, @idAsignatura, @idControl, @idCurso, @nota)", conexion)

            ' Agregar parámetros al comando para la tabla Nota
            cmdNota.Parameters.AddWithValue("@idNota", siguienteIDNota)
            cmdNota.Parameters.AddWithValue("@idAlumno", idAlumno)
            cmdNota.Parameters.AddWithValue("@idAsignatura", idAsignatura)
            cmdNota.Parameters.AddWithValue("@idControl", siguienteIDControl)
            cmdNota.Parameters.AddWithValue("@idCurso", siguienteIDCurso)
            cmdNota.Parameters.AddWithValue("@nota", nota)

            ' Ejecutar el comando para la tabla Nota
            cmdNota.ExecuteNonQuery()

            ' Cerrar la conexión
            cerrarConexionBBDD()

        Catch ex As Exception
            Throw New Exception("Error al insertar nota en la base de datos. Detalles del error: " & ex.Message)
        Finally
            ' Cerrar la conexión fuera del bloque Try-Catch
            cerrarConexionBBDD()
        End Try
    End Sub

    ' Función para obtener el próximo ID disponible para una tabla específica (parche temporal)
    Private Function ObtenerSiguienteID(tabla As String) As Integer
        Dim siguienteID As Integer = 1 ' Valor predeterminado si no hay registros
        Try
            ' Determinar el nombre de la columna ID dinámicamente
            Dim columnaID As String = $"id{tabla}"

            ' Consulta para obtener el máximo ID de la tabla actual
            Dim query As String = $"SELECT MAX({columnaID}) FROM {tabla}"
            Dim cmd As New SqlCommand(query, conexion)
            abrirConexionBBDD()
            Dim result As Object = cmd.ExecuteScalar()

            ' Incrementar el máximo ID obtenido
            If result IsNot DBNull.Value Then
                siguienteID = Convert.ToInt32(result) + 1
            End If

            ' Cerrar la conexión
            cerrarConexionBBDD()

        Catch ex As Exception
            Throw New Exception($"Error al obtener el próximo ID de {tabla} disponible. Detalles del error: {ex.Message}")
        End Try

        Return siguienteID
    End Function

    ' Función para limpiar los campos después de la inserción
    Private Sub LimpiarCampos()
        ComboBox1.SelectedIndex = -1
        ComboBox2_curso.SelectedIndex = -1
        ComboBox3_asignatura.SelectedIndex = -1
        ComboBox4_control.SelectedIndex = -1
        TextBox1.Text = ""
    End Sub
End Class