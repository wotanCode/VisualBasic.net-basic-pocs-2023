Public Class CalendaryForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        ' Validar que ambos campos existan
        If String.IsNullOrEmpty(TextBoxActividad.Text) Then
            MessageBox.Show("Por favor, ingresa una actividad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Validar que la fecha seleccionada sea mayor a la fecha actual
        Dim fechaSeleccionada As Date = calendaryDate.SelectionRange.End
        Dim fechaActual As Date = DateTime.Now

        If fechaSeleccionada <= fechaActual Then
            MessageBox.Show("La fecha seleccionada debe ser mayor a la fecha actual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Si pasa ambas validaciones, asignar los valores a las etiquetas
        LabelNombreActividad.Text = TextBoxActividad.Text
        LabelFechaActividad.Text = fechaSeleccionada.ToString
    End Sub
End Class