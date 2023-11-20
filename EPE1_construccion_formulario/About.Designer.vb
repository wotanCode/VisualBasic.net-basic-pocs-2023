<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(About))
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        MenuStrip1 = New MenuStrip()
        GithubToolStripMenuItem = New ToolStripMenuItem()
        LinkedinToolStripMenuItem = New ToolStripMenuItem()
        InstagramToolStripMenuItem = New ToolStripMenuItem()
        Label2 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(347, 94)
        Label1.TabIndex = 0
        Label1.Text = "Este proyecto fue creado por Pedro Yanez para la asignatura de 'TALLER DE APLICACIONES PUNTO NET'. No olvides apoyar su trabajo y seguirlo en sus redes sociales."
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 106)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(168, 159)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.White
        MenuStrip1.Dock = DockStyle.None
        MenuStrip1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MenuStrip1.Items.AddRange(New ToolStripItem() {GithubToolStripMenuItem, LinkedinToolStripMenuItem, InstagramToolStripMenuItem})
        MenuStrip1.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow
        MenuStrip1.Location = New Point(205, 116)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(146, 108)
        MenuStrip1.TabIndex = 2
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' GithubToolStripMenuItem
        ' 
        GithubToolStripMenuItem.Image = My.Resources.Resources.signo_de_github
        GithubToolStripMenuItem.Name = "GithubToolStripMenuItem"
        GithubToolStripMenuItem.Size = New Size(139, 34)
        GithubToolStripMenuItem.Text = "Github"
        ' 
        ' LinkedinToolStripMenuItem
        ' 
        LinkedinToolStripMenuItem.Image = My.Resources.Resources.linkedin
        LinkedinToolStripMenuItem.Name = "LinkedinToolStripMenuItem"
        LinkedinToolStripMenuItem.Size = New Size(139, 34)
        LinkedinToolStripMenuItem.Text = "Linkedin"
        ' 
        ' InstagramToolStripMenuItem
        ' 
        InstagramToolStripMenuItem.Image = My.Resources.Resources.instagram
        InstagramToolStripMenuItem.Name = "InstagramToolStripMenuItem"
        InstagramToolStripMenuItem.Size = New Size(139, 34)
        InstagramToolStripMenuItem.Text = "Instagram"
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Segoe UI", 8.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(12, 268)
        Label2.Name = "Label2"
        Label2.Size = New Size(339, 55)
        Label2.TabIndex = 3
        Label2.Text = resources.GetString("Label2.Text")
        ' 
        ' About
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(363, 342)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "About"
        Text = "Acerca de..."
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GithubToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LinkedinToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InstagramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
End Class
