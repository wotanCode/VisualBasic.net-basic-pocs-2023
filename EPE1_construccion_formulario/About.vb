Public Class About
    Private Sub GithubToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GithubToolStripMenuItem.Click
        Dim psi As New ProcessStartInfo("cmd", "/c start https://www.github.com/wotanCode")
        psi.CreateNoWindow = True
        psi.UseShellExecute = False
        psi.RedirectStandardOutput = True
        Dim process As New Process() With {.StartInfo = psi}
        process.Start()
    End Sub

    Private Sub LinkedinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LinkedinToolStripMenuItem.Click
        Dim psi As New ProcessStartInfo("cmd", "/c start https://www.linkedin.com/in/pedro-yanez/")
        psi.CreateNoWindow = True
        psi.UseShellExecute = False
        psi.RedirectStandardOutput = True
        Dim process As New Process() With {.StartInfo = psi}
        process.Start()
    End Sub

    Private Sub InstagramToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstagramToolStripMenuItem.Click
        Dim psi As New ProcessStartInfo("cmd", "/c start https://www.instagram.com/pedroelhumano")
        psi.CreateNoWindow = True
        psi.UseShellExecute = False
        psi.RedirectStandardOutput = True
        Dim process As New Process() With {.StartInfo = psi}
        process.Start()
    End Sub
End Class