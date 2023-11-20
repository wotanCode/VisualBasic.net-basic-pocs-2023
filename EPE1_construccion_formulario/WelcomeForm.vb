Public Class WelcomeForm
    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Close()
    End Sub

    Private Sub GithubToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GithubToolStripMenuItem.Click
        Dim psi As New ProcessStartInfo("cmd", "/c start https://www.github.com/wotanCode")
        psi.CreateNoWindow = True
        psi.UseShellExecute = False
        psi.RedirectStandardOutput = True
        Dim process As New Process() With {.StartInfo = psi}
        process.Start()
    End Sub

    Private Sub ButtonAccessCalculator_Click(sender As Object, e As EventArgs) Handles ButtonAccessCalculator.Click
        Dim calculatorForm As New CalculatorForm()
        calculatorForm.Show()
    End Sub

    Private Sub ButtonAccessCalendary_Click(sender As Object, e As EventArgs) Handles ButtonAccessCalendary.Click
        Dim calendaryForm As New CalendaryForm()
        calendaryForm.Show()
    End Sub

    Private Sub ButtonAccessLista_Click(sender As Object, e As EventArgs) Handles ButtonAccessLista.Click
        Dim listForm As New ListForm()
        listForm.Show()
    End Sub

    Private Sub AcercaDelAutorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDelAutorToolStripMenuItem.Click
        Dim about As New About()
        about.Show()
    End Sub
End Class
