Public Class About
    ' Este método se ejecuta cuando se hace clic en la opción del menú "GithubToolStripMenuItem".
    Private Sub GithubToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GithubToolStripMenuItem.Click
        ' Se crea una nueva instancia de ProcessStartInfo para iniciar un proceso que abre la URL del perfil de GitHub.
        Dim psi As New ProcessStartInfo("cmd", "/c start https://www.github.com/wotanCode")
        psi.CreateNoWindow = True ' No se crea una ventana de consola.
        psi.UseShellExecute = False ' No se utiliza el shell del sistema operativo.
        psi.RedirectStandardOutput = True ' La salida estándar se redirige para su posterior lectura.
        Dim process As New Process() With {.StartInfo = psi} ' Se crea un nuevo proceso con la información de inicio especificada.
        process.Start() ' Se inicia el proceso para abrir la URL.
    End Sub

    ' Este método se ejecuta cuando se hace clic en la opción del menú "LinkedinToolStripMenuItem".
    Private Sub LinkedinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LinkedinToolStripMenuItem.Click
        ' Se crea una nueva instancia de ProcessStartInfo para iniciar un proceso que abre la URL del perfil de LinkedIn.
        Dim psi As New ProcessStartInfo("cmd", "/c start https://www.linkedin.com/in/pedro-yanez/")
        psi.CreateNoWindow = True ' No se crea una ventana de consola.
        psi.UseShellExecute = False ' No se utiliza el shell del sistema operativo.
        psi.RedirectStandardOutput = True ' La salida estándar se redirige para su posterior lectura.
        Dim process As New Process() With {.StartInfo = psi} ' Se crea un nuevo proceso con la información de inicio especificada.
        process.Start() ' Se inicia el proceso para abrir la URL.
    End Sub

    ' Este método se ejecuta cuando se hace clic en la opción del menú "InstagramToolStripMenuItem".
    Private Sub InstagramToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstagramToolStripMenuItem.Click
        ' Se crea una nueva instancia de ProcessStartInfo para iniciar un proceso que abre la URL del perfil de Instagram.
        Dim psi As New ProcessStartInfo("cmd", "/c start https://www.instagram.com/pedroelhumano")
        psi.CreateNoWindow = True ' No se crea una ventana de consola.
        psi.UseShellExecute = False ' No se utiliza el shell del sistema operativo.
        psi.RedirectStandardOutput = True ' La salida estándar se redirige para su posterior lectura.
        Dim process As New Process() With {.StartInfo = psi} ' Se crea un nuevo proceso con la información de inicio especificada.
        process.Start() ' Se inicia el proceso para abrir la URL.
    End Sub
End Class
