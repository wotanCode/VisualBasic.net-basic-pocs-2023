<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EfePrincipal
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
        MenuStrip1 = New MenuStrip()
        ArchivoToolStripMenuItem = New ToolStripMenuItem()
        NuevoToolStripMenuItem = New ToolStripMenuItem()
        AgregarPersonaToolStripMenuItem = New ToolStripMenuItem()
        ModificarPersonaToolStripMenuItem = New ToolStripMenuItem()
        EliminarPersonaToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        SalirToolStripMenuItem = New ToolStripMenuItem()
        EdiciónToolStripMenuItem = New ToolStripMenuItem()
        DireccionesToolStripMenuItem = New ToolStripMenuItem()
        TeléfonosToolStripMenuItem = New ToolStripMenuItem()
        CorreosToolStripMenuItem = New ToolStripMenuItem()
        AyudaToolStripMenuItem = New ToolStripMenuItem()
        AcercaDeToolStripMenuItem = New ToolStripMenuItem()
        Label1 = New Label()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {ArchivoToolStripMenuItem, EdiciónToolStripMenuItem, AyudaToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(337, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ArchivoToolStripMenuItem
        ' 
        ArchivoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NuevoToolStripMenuItem, ToolStripSeparator1, SalirToolStripMenuItem})
        ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        ArchivoToolStripMenuItem.Size = New Size(60, 20)
        ArchivoToolStripMenuItem.Text = "Archivo"
        ' 
        ' NuevoToolStripMenuItem
        ' 
        NuevoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AgregarPersonaToolStripMenuItem, ModificarPersonaToolStripMenuItem, EliminarPersonaToolStripMenuItem})
        NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        NuevoToolStripMenuItem.Size = New Size(180, 22)
        NuevoToolStripMenuItem.Text = "Nuevo"
        ' 
        ' AgregarPersonaToolStripMenuItem
        ' 
        AgregarPersonaToolStripMenuItem.Name = "AgregarPersonaToolStripMenuItem"
        AgregarPersonaToolStripMenuItem.Size = New Size(180, 22)
        AgregarPersonaToolStripMenuItem.Text = "Agregar persona"
        ' 
        ' ModificarPersonaToolStripMenuItem
        ' 
        ModificarPersonaToolStripMenuItem.Name = "ModificarPersonaToolStripMenuItem"
        ModificarPersonaToolStripMenuItem.Size = New Size(180, 22)
        ModificarPersonaToolStripMenuItem.Text = "Modificar Persona"
        ' 
        ' EliminarPersonaToolStripMenuItem
        ' 
        EliminarPersonaToolStripMenuItem.Name = "EliminarPersonaToolStripMenuItem"
        EliminarPersonaToolStripMenuItem.Size = New Size(180, 22)
        EliminarPersonaToolStripMenuItem.Text = "Eliminar Persona"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(177, 6)
        ' 
        ' SalirToolStripMenuItem
        ' 
        SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        SalirToolStripMenuItem.Size = New Size(180, 22)
        SalirToolStripMenuItem.Text = "Salir"
        ' 
        ' EdiciónToolStripMenuItem
        ' 
        EdiciónToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {DireccionesToolStripMenuItem, TeléfonosToolStripMenuItem, CorreosToolStripMenuItem})
        EdiciónToolStripMenuItem.Name = "EdiciónToolStripMenuItem"
        EdiciónToolStripMenuItem.Size = New Size(58, 20)
        EdiciónToolStripMenuItem.Text = "Edición"
        ' 
        ' DireccionesToolStripMenuItem
        ' 
        DireccionesToolStripMenuItem.Name = "DireccionesToolStripMenuItem"
        DireccionesToolStripMenuItem.Size = New Size(180, 22)
        DireccionesToolStripMenuItem.Text = "Direcciones"
        ' 
        ' TeléfonosToolStripMenuItem
        ' 
        TeléfonosToolStripMenuItem.Name = "TeléfonosToolStripMenuItem"
        TeléfonosToolStripMenuItem.Size = New Size(180, 22)
        TeléfonosToolStripMenuItem.Text = "Teléfonos"
        ' 
        ' CorreosToolStripMenuItem
        ' 
        CorreosToolStripMenuItem.Name = "CorreosToolStripMenuItem"
        CorreosToolStripMenuItem.Size = New Size(180, 22)
        CorreosToolStripMenuItem.Text = "Correos"
        ' 
        ' AyudaToolStripMenuItem
        ' 
        AyudaToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AcercaDeToolStripMenuItem})
        AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        AyudaToolStripMenuItem.Size = New Size(53, 20)
        AyudaToolStripMenuItem.Text = "Ayuda"
        ' 
        ' AcercaDeToolStripMenuItem
        ' 
        AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        AcercaDeToolStripMenuItem.Size = New Size(180, 22)
        AcercaDeToolStripMenuItem.Text = "Acerca de..."
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Corbel", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(208, 300)
        Label1.Name = "Label1"
        Label1.Size = New Size(117, 14)
        Label1.TabIndex = 1
        Label1.Text = "Creado por Pedro Yanez"
        ' 
        ' EfePrincipal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(337, 323)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "EfePrincipal"
        Text = "EFE FINAL"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EdiciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DireccionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TeléfonosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CorreosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarPersonaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarPersonaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarPersonaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label

End Class
