<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WelcomeForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        CloseButton = New Button()
        Panel1 = New Panel()
        MenuStrip1 = New MenuStrip()
        GithubToolStripMenuItem = New ToolStripMenuItem()
        AyudaToolStripMenuItem = New ToolStripMenuItem()
        AcercaDelAutorToolStripMenuItem = New ToolStripMenuItem()
        ButtonAccessCalculator = New Button()
        ButtonAccessCalendary = New Button()
        ButtonAccessLista = New Button()
        Label1 = New Label()
        Panel1.SuspendLayout()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' CloseButton
        ' 
        CloseButton.FlatAppearance.BorderSize = 0
        CloseButton.FlatStyle = FlatStyle.Flat
        CloseButton.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        CloseButton.Location = New Point(274, 12)
        CloseButton.Name = "CloseButton"
        CloseButton.Size = New Size(47, 44)
        CloseButton.TabIndex = 0
        CloseButton.Text = "X"
        CloseButton.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(MenuStrip1)
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(0, 327)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(333, 47)
        Panel1.TabIndex = 1
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.White
        MenuStrip1.Dock = DockStyle.Bottom
        MenuStrip1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MenuStrip1.Items.AddRange(New ToolStripItem() {GithubToolStripMenuItem, AyudaToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 18)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(333, 29)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' GithubToolStripMenuItem
        ' 
        GithubToolStripMenuItem.Image = My.Resources.Resources.signo_de_github
        GithubToolStripMenuItem.Name = "GithubToolStripMenuItem"
        GithubToolStripMenuItem.Size = New Size(190, 25)
        GithubToolStripMenuItem.Text = "Github del proyecto"
        ' 
        ' AyudaToolStripMenuItem
        ' 
        AyudaToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AcercaDelAutorToolStripMenuItem})
        AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        AyudaToolStripMenuItem.Size = New Size(71, 25)
        AyudaToolStripMenuItem.Text = "Ayuda"
        ' 
        ' AcercaDelAutorToolStripMenuItem
        ' 
        AcercaDelAutorToolStripMenuItem.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        AcercaDelAutorToolStripMenuItem.Name = "AcercaDelAutorToolStripMenuItem"
        AcercaDelAutorToolStripMenuItem.Size = New Size(175, 22)
        AcercaDelAutorToolStripMenuItem.Text = "Acerca del Autor"
        ' 
        ' ButtonAccessCalculator
        ' 
        ButtonAccessCalculator.BackColor = Color.RoyalBlue
        ButtonAccessCalculator.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonAccessCalculator.ForeColor = Color.White
        ButtonAccessCalculator.Location = New Point(12, 78)
        ButtonAccessCalculator.Name = "ButtonAccessCalculator"
        ButtonAccessCalculator.Size = New Size(309, 75)
        ButtonAccessCalculator.TabIndex = 2
        ButtonAccessCalculator.Text = "CALCULADORA"
        ButtonAccessCalculator.UseVisualStyleBackColor = False
        ' 
        ' ButtonAccessCalendary
        ' 
        ButtonAccessCalendary.BackColor = Color.RoyalBlue
        ButtonAccessCalendary.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonAccessCalendary.ForeColor = Color.White
        ButtonAccessCalendary.Location = New Point(12, 159)
        ButtonAccessCalendary.Name = "ButtonAccessCalendary"
        ButtonAccessCalendary.Size = New Size(309, 75)
        ButtonAccessCalendary.TabIndex = 3
        ButtonAccessCalendary.Text = "CALENDARIO"
        ButtonAccessCalendary.UseVisualStyleBackColor = False
        ' 
        ' ButtonAccessLista
        ' 
        ButtonAccessLista.BackColor = Color.RoyalBlue
        ButtonAccessLista.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonAccessLista.ForeColor = Color.White
        ButtonAccessLista.Location = New Point(12, 240)
        ButtonAccessLista.Name = "ButtonAccessLista"
        ButtonAccessLista.Size = New Size(309, 75)
        ButtonAccessLista.TabIndex = 4
        ButtonAccessLista.Text = "LISTA"
        ButtonAccessLista.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Malgun Gothic", 12F, FontStyle.Bold)
        Label1.Location = New Point(12, 54)
        Label1.Name = "Label1"
        Label1.Size = New Size(271, 21)
        Label1.TabIndex = 5
        Label1.Text = "CONSTRUCCIÓN DE FORMULARIO"
        ' 
        ' WelcomeForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(333, 374)
        Controls.Add(Label1)
        Controls.Add(ButtonAccessLista)
        Controls.Add(ButtonAccessCalendary)
        Controls.Add(ButtonAccessCalculator)
        Controls.Add(CloseButton)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        MainMenuStrip = MenuStrip1
        Name = "WelcomeForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "EPE1 Construcción Formulario"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CloseButton As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GithubToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDelAutorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ButtonAccessCalculator As Button
    Friend WithEvents ButtonAccessCalendary As Button
    Friend WithEvents ButtonAccessLista As Button
    Friend WithEvents Label1 As Label

End Class
