<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarTelefono
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
        GroupBox1 = New GroupBox()
        Label4 = New Label()
        TextBox4_apellido2 = New TextBox()
        Label1 = New Label()
        Label8 = New Label()
        TextBox1_rut = New TextBox()
        Label2 = New Label()
        TextBox2_nombre = New TextBox()
        TextBox3_apellido1 = New TextBox()
        Label3 = New Label()
        DateTimePicker1_fechaNacimiento = New DateTimePicker()
        BuscarButton = New Button()
        Label19 = New Label()
        buscarRut = New TextBox()
        GroupBox5 = New GroupBox()
        Label20 = New Label()
        Label21 = New Label()
        TextBox14_telefonoFijo = New TextBox()
        TextBox15_telefonoMovil = New TextBox()
        Button_Modificar = New Button()
        Label25 = New Label()
        GroupBox1.SuspendLayout()
        GroupBox5.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.White
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(TextBox4_apellido2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(TextBox1_rut)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(TextBox2_nombre)
        GroupBox1.Controls.Add(TextBox3_apellido1)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(DateTimePicker1_fechaNacimiento)
        GroupBox1.Location = New Point(12, 68)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(267, 294)
        GroupBox1.TabIndex = 50
        GroupBox1.TabStop = False
        GroupBox1.Text = "Datos personales"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(6, 19)
        Label4.Name = "Label4"
        Label4.Size = New Size(45, 21)
        Label4.TabIndex = 6
        Label4.Text = "RUT:"
        ' 
        ' TextBox4_apellido2
        ' 
        TextBox4_apellido2.Enabled = False
        TextBox4_apellido2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox4_apellido2.Location = New Point(6, 211)
        TextBox4_apellido2.Name = "TextBox4_apellido2"
        TextBox4_apellido2.Size = New Size(254, 29)
        TextBox4_apellido2.TabIndex = 16
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(6, 75)
        Label1.Name = "Label1"
        Label1.Size = New Size(77, 21)
        Label1.TabIndex = 0
        Label1.Text = "Nombre:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(6, 187)
        Label8.Name = "Label8"
        Label8.Size = New Size(148, 21)
        Label8.TabIndex = 15
        Label8.Text = "Apellido materno:"
        ' 
        ' TextBox1_rut
        ' 
        TextBox1_rut.Enabled = False
        TextBox1_rut.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1_rut.Location = New Point(6, 43)
        TextBox1_rut.Name = "TextBox1_rut"
        TextBox1_rut.Size = New Size(254, 29)
        TextBox1_rut.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(6, 131)
        Label2.Name = "Label2"
        Label2.Size = New Size(143, 21)
        Label2.TabIndex = 2
        Label2.Text = "Apellido paterno:"
        ' 
        ' TextBox2_nombre
        ' 
        TextBox2_nombre.Enabled = False
        TextBox2_nombre.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2_nombre.Location = New Point(6, 99)
        TextBox2_nombre.Name = "TextBox2_nombre"
        TextBox2_nombre.Size = New Size(254, 29)
        TextBox2_nombre.TabIndex = 7
        ' 
        ' TextBox3_apellido1
        ' 
        TextBox3_apellido1.Enabled = False
        TextBox3_apellido1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox3_apellido1.Location = New Point(6, 155)
        TextBox3_apellido1.Name = "TextBox3_apellido1"
        TextBox3_apellido1.Size = New Size(254, 29)
        TextBox3_apellido1.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(6, 243)
        Label3.Name = "Label3"
        Label3.Size = New Size(152, 21)
        Label3.TabIndex = 4
        Label3.Text = "Fecha Nacimiento:"
        ' 
        ' DateTimePicker1_fechaNacimiento
        ' 
        DateTimePicker1_fechaNacimiento.Enabled = False
        DateTimePicker1_fechaNacimiento.Location = New Point(6, 267)
        DateTimePicker1_fechaNacimiento.Name = "DateTimePicker1_fechaNacimiento"
        DateTimePicker1_fechaNacimiento.Size = New Size(254, 23)
        DateTimePicker1_fechaNacimiento.TabIndex = 5
        ' 
        ' BuscarButton
        ' 
        BuscarButton.AutoSizeMode = AutoSizeMode.GrowAndShrink
        BuscarButton.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BuscarButton.Location = New Point(224, 9)
        BuscarButton.Name = "BuscarButton"
        BuscarButton.Size = New Size(115, 53)
        BuscarButton.TabIndex = 49
        BuscarButton.Text = "Buscar"
        BuscarButton.UseVisualStyleBackColor = True
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label19.Location = New Point(12, 9)
        Label19.Name = "Label19"
        Label19.Size = New Size(78, 17)
        Label19.TabIndex = 48
        Label19.Text = "Ingrese Rut"
        ' 
        ' buscarRut
        ' 
        buscarRut.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        buscarRut.Location = New Point(12, 29)
        buscarRut.Name = "buscarRut"
        buscarRut.Size = New Size(206, 33)
        buscarRut.TabIndex = 47
        ' 
        ' GroupBox5
        ' 
        GroupBox5.BackColor = Color.White
        GroupBox5.Controls.Add(Label20)
        GroupBox5.Controls.Add(Label21)
        GroupBox5.Controls.Add(TextBox14_telefonoFijo)
        GroupBox5.Controls.Add(TextBox15_telefonoMovil)
        GroupBox5.Location = New Point(285, 68)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Size = New Size(267, 141)
        GroupBox5.TabIndex = 51
        GroupBox5.TabStop = False
        GroupBox5.Text = "Contacto telefonico:"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label20.Location = New Point(6, 19)
        Label20.Name = "Label20"
        Label20.Size = New Size(111, 21)
        Label20.TabIndex = 6
        Label20.Text = "Telefono fijo:"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label21.Location = New Point(6, 75)
        Label21.Name = "Label21"
        Label21.Size = New Size(129, 21)
        Label21.TabIndex = 0
        Label21.Text = "Telefono movil:"
        ' 
        ' TextBox14_telefonoFijo
        ' 
        TextBox14_telefonoFijo.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox14_telefonoFijo.Location = New Point(6, 43)
        TextBox14_telefonoFijo.Name = "TextBox14_telefonoFijo"
        TextBox14_telefonoFijo.Size = New Size(254, 29)
        TextBox14_telefonoFijo.TabIndex = 1
        ' 
        ' TextBox15_telefonoMovil
        ' 
        TextBox15_telefonoMovil.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox15_telefonoMovil.Location = New Point(6, 99)
        TextBox15_telefonoMovil.Name = "TextBox15_telefonoMovil"
        TextBox15_telefonoMovil.Size = New Size(254, 29)
        TextBox15_telefonoMovil.TabIndex = 7
        ' 
        ' Button_Modificar
        ' 
        Button_Modificar.BackColor = Color.DarkSeaGreen
        Button_Modificar.Enabled = False
        Button_Modificar.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button_Modificar.Location = New Point(285, 215)
        Button_Modificar.Name = "Button_Modificar"
        Button_Modificar.Size = New Size(267, 147)
        Button_Modificar.TabIndex = 52
        Button_Modificar.Text = "Modificar:"
        Button_Modificar.UseVisualStyleBackColor = False
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Location = New Point(87, 9)
        Label25.Name = "Label25"
        Label25.Size = New Size(117, 15)
        Label25.TabIndex = 53
        Label25.Text = "Formato: 12345678-9"
        ' 
        ' EditarTelefono
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(562, 372)
        Controls.Add(Label25)
        Controls.Add(Button_Modificar)
        Controls.Add(GroupBox5)
        Controls.Add(GroupBox1)
        Controls.Add(BuscarButton)
        Controls.Add(Label19)
        Controls.Add(buscarRut)
        Name = "EditarTelefono"
        Text = "EditarTelefono"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox5.ResumeLayout(False)
        GroupBox5.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4_apellido2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox1_rut As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2_nombre As TextBox
    Friend WithEvents TextBox3_apellido1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker1_fechaNacimiento As DateTimePicker
    Friend WithEvents BuscarButton As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents buscarRut As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents TextBox14_telefonoFijo As TextBox
    Friend WithEvents TextBox15_telefonoMovil As TextBox
    Friend WithEvents Button_Modificar As Button
    Friend WithEvents Label25 As Label
End Class
