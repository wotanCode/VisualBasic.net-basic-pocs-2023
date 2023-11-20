Public Class WelcomeForm

    'Este método se ejecuta cuando se hace clic en el botón "CloseButton".
    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Close()
    End Sub

    'Este método se ejecuta cuando se selecciona la opción del menú "GithubToolStripMenuItem". Abre el navegador y se dirige al repositorio
    Private Sub GithubToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GithubToolStripMenuItem.Click
        Dim psi As New ProcessStartInfo("cmd", "/c start https://github.com/wotanCode/VisualBasic.net-basic-practices/tree/main/EPE1_construccion_formulario")
        psi.CreateNoWindow = True
        psi.UseShellExecute = False
        psi.RedirectStandardOutput = True
        Dim process As New Process() With {.StartInfo = psi}
        process.Start()
    End Sub

    'Este método se ejecuta cuando se hace clic en el botón "ButtonAccessCalculator". Abre el formulario de la calculadora.
    Private Sub ButtonAccessCalculator_Click(sender As Object, e As EventArgs) Handles ButtonAccessCalculator.Click
        Dim calculatorForm As New CalculatorForm()
        calculatorForm.Show()
    End Sub

    'Este método se ejecuta cuando se hace clic en el botón "ButtonAccessCalendary". Abre el formulario del calendario.
    Private Sub ButtonAccessCalendary_Click(sender As Object, e As EventArgs) Handles ButtonAccessCalendary.Click
        Dim calendaryForm As New CalendaryForm()
        calendaryForm.Show()
    End Sub

    'Este método se ejecuta cuando se hace clic en el botón "ButtonAccessLista". Accede al formulario de la lista de tareas
    Private Sub ButtonAccessLista_Click(sender As Object, e As EventArgs) Handles ButtonAccessLista.Click
        Dim listForm As New ListForm()
        listForm.Show()
    End Sub

    'Este método se ejecuta cuando se selecciona la opción del menú "AcercaDelAutorToolStripMenuItem". Accede al formulario donde se muestra información acerca del desarrollador
    Private Sub AcercaDelAutorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDelAutorToolStripMenuItem.Click
        Dim about As New About()
        about.Show()
    End Sub
End Class
