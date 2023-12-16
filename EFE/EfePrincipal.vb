Public Class EfePrincipal

    ' Maneja el evento de clic en el menú "Salir"
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close() ' Cierra la aplicación
    End Sub

    ' Maneja el evento de clic en el menú "Acerca de"
    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        ' Muestra un cuadro de mensaje con información sobre el creador y su perfil de LinkedIn
        MsgBox("Creado por Pedro Yanez. Recuerda agregarme en Linkedin para mantener contacto! -> /in/pedro-yanez")
    End Sub

    ' Maneja el evento de clic en el menú "Agregar Persona"
    Private Sub AgregarPersonaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarPersonaToolStripMenuItem.Click
        ' Crea una nueva instancia del formulario AgregarPersona y lo muestra
        Dim agregarPersona As New AgregarPersona()
        agregarPersona.Show()
    End Sub

    ' Maneja el evento de clic en el menú "Modificar Persona"
    Private Sub ModificarPersonaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarPersonaToolStripMenuItem.Click
        ' Crea una nueva instancia del formulario ModificarPersona y lo muestra
        Dim modificarPersona As New ModificarPersona()
        modificarPersona.Show()
    End Sub

    ' Maneja el evento de clic en el menú "Eliminar Persona"
    Private Sub EliminarPersonaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarPersonaToolStripMenuItem.Click
        ' Crea una nueva instancia del formulario EliminarPersona y lo muestra
        Dim eliminarPersona As New EliminarPersona()
        eliminarPersona.Show()
    End Sub

    ' Maneja el evento de clic en el menú "Direcciones"
    Private Sub DireccionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DireccionesToolStripMenuItem.Click
        ' Crea una nueva instancia del formulario EditarDireccion y lo muestra
        Dim editarDireccion As New EditarDireccion()
        editarDireccion.Show()
    End Sub

    ' Maneja el evento de clic en el menú "Teléfonos"
    Private Sub TeléfonosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TeléfonosToolStripMenuItem.Click
        ' Crea una nueva instancia del formulario EditarTelefono y lo muestra
        Dim editarTelefono As New EditarTelefono()
        editarTelefono.Show()
    End Sub

    ' Maneja el evento de clic en el menú "Correos"
    Private Sub CorreosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CorreosToolStripMenuItem.Click
        ' Crea una nueva instancia del formulario Correos y lo muestra
        Dim correos As New Correos()
        correos.Show()
    End Sub
End Class
