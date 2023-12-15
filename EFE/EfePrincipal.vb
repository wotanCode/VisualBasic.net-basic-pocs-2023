Public Class EfePrincipal
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        MsgBox("Creado por Pedro Yanez. Recuerda agregarme en Linkedin para mantener contacto! -> /in/pedro-yanez")
    End Sub

    Private Sub AgregarPersonaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarPersonaToolStripMenuItem.Click
        Dim agregarPersona As New AgregarPersona()
        agregarPersona.Show()
    End Sub

    Private Sub ModificarPersonaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarPersonaToolStripMenuItem.Click
        Dim modificarPersona As New ModificarPersona()
        modificarPersona.Show()
    End Sub

    Private Sub EliminarPersonaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarPersonaToolStripMenuItem.Click
        Dim eliminarPersona As New EliminarPersona()
        eliminarPersona.Show()
    End Sub

    Private Sub DireccionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DireccionesToolStripMenuItem.Click
        Dim editarDireccion As New EditarDireccion()
        editarDireccion.Show()
    End Sub

    Private Sub TeléfonosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TeléfonosToolStripMenuItem.Click
        Dim editarTelefono As New EditarTelefono()
        editarTelefono.Show()
    End Sub

    Private Sub CorreosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CorreosToolStripMenuItem.Click
        Dim correos As New Correos()
        correos.Show()
    End Sub
End Class
