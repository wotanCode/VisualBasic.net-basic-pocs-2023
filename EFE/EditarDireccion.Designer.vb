<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarDireccion
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
        BuscarButton = New Button()
        Label19 = New Label()
        buscarRut = New TextBox()
        GroupBox4 = New GroupBox()
        ComboBox5_comunaFacturacion = New ComboBox()
        ComboBox6_regionFacturacion = New ComboBox()
        Label16 = New Label()
        Label17 = New Label()
        Label18 = New Label()
        TextBox10_calleFacturacion = New TextBox()
        GroupBox3 = New GroupBox()
        ComboBox3_comunaComercial = New ComboBox()
        ComboBox4_regionComercial = New ComboBox()
        Label10 = New Label()
        Label13 = New Label()
        Label15 = New Label()
        TextBox9_calleComercial = New TextBox()
        GroupBox2 = New GroupBox()
        ComboBox2_comunaPersonal = New ComboBox()
        ComboBox1_regionPersonal = New ComboBox()
        Label11 = New Label()
        Label12 = New Label()
        Label14 = New Label()
        TextBox12_callePersonal = New TextBox()
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
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Button_modificar = New Button()
        Label25 = New Label()
        Label_direccionFacturacion = New Label()
        Label_direccionComercial = New Label()
        Label_direccionPersonal = New Label()
        GroupBox4.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' BuscarButton
        ' 
        BuscarButton.AutoSizeMode = AutoSizeMode.GrowAndShrink
        BuscarButton.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BuscarButton.Location = New Point(224, 8)
        BuscarButton.Name = "BuscarButton"
        BuscarButton.Size = New Size(115, 53)
        BuscarButton.TabIndex = 42
        BuscarButton.Text = "Buscar"
        BuscarButton.UseVisualStyleBackColor = True
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label19.Location = New Point(12, 8)
        Label19.Name = "Label19"
        Label19.Size = New Size(78, 17)
        Label19.TabIndex = 41
        Label19.Text = "Ingrese Rut"
        ' 
        ' buscarRut
        ' 
        buscarRut.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        buscarRut.Location = New Point(12, 28)
        buscarRut.Name = "buscarRut"
        buscarRut.Size = New Size(206, 33)
        buscarRut.TabIndex = 40
        ' 
        ' GroupBox4
        ' 
        GroupBox4.BackColor = Color.White
        GroupBox4.Controls.Add(ComboBox5_comunaFacturacion)
        GroupBox4.Controls.Add(ComboBox6_regionFacturacion)
        GroupBox4.Controls.Add(Label16)
        GroupBox4.Controls.Add(Label17)
        GroupBox4.Controls.Add(Label18)
        GroupBox4.Controls.Add(TextBox10_calleFacturacion)
        GroupBox4.Location = New Point(558, 367)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(267, 191)
        GroupBox4.TabIndex = 45
        GroupBox4.TabStop = False
        GroupBox4.Text = "Dirección de facturación"
        ' 
        ' ComboBox5_comunaFacturacion
        ' 
        ComboBox5_comunaFacturacion.Enabled = False
        ComboBox5_comunaFacturacion.Font = New Font("Segoe UI", 12F)
        ComboBox5_comunaFacturacion.FormattingEnabled = True
        ComboBox5_comunaFacturacion.Location = New Point(6, 99)
        ComboBox5_comunaFacturacion.Name = "ComboBox5_comunaFacturacion"
        ComboBox5_comunaFacturacion.Size = New Size(254, 29)
        ComboBox5_comunaFacturacion.TabIndex = 21
        ' 
        ' ComboBox6_regionFacturacion
        ' 
        ComboBox6_regionFacturacion.Font = New Font("Segoe UI", 12F)
        ComboBox6_regionFacturacion.FormattingEnabled = True
        ComboBox6_regionFacturacion.Items.AddRange(New Object() {"Arica y Parinacota", "Tarapacá", "Antofagasta", "Atacama", "Coquimbo", "Valparaíso", "Metropolitana de Santiago", "Libertador General Bernardo O'Higgins", "Maule", "Ñuble", "Biobío", "Araucanía", "Los Ríos", "Los Lagos", "Aysén del General Carlos Ibáñez del Campo", "Magallanes y de la Antártica Chilena"})
        ComboBox6_regionFacturacion.Location = New Point(6, 40)
        ComboBox6_regionFacturacion.Name = "ComboBox6_regionFacturacion"
        ComboBox6_regionFacturacion.Size = New Size(254, 29)
        ComboBox6_regionFacturacion.TabIndex = 20
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.Location = New Point(6, 19)
        Label16.Name = "Label16"
        Label16.Size = New Size(64, 21)
        Label16.TabIndex = 6
        Label16.Text = "Región"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label17.Location = New Point(6, 75)
        Label17.Name = "Label17"
        Label17.Size = New Size(74, 21)
        Label17.TabIndex = 0
        Label17.Text = "Comuna"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label18.Location = New Point(6, 131)
        Label18.Name = "Label18"
        Label18.Size = New Size(161, 21)
        Label18.TabIndex = 2
        Label18.Text = "Calle y numeración."
        ' 
        ' TextBox10_calleFacturacion
        ' 
        TextBox10_calleFacturacion.Enabled = False
        TextBox10_calleFacturacion.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox10_calleFacturacion.Location = New Point(6, 155)
        TextBox10_calleFacturacion.Name = "TextBox10_calleFacturacion"
        TextBox10_calleFacturacion.Size = New Size(254, 29)
        TextBox10_calleFacturacion.TabIndex = 3
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = Color.White
        GroupBox3.Controls.Add(ComboBox3_comunaComercial)
        GroupBox3.Controls.Add(ComboBox4_regionComercial)
        GroupBox3.Controls.Add(Label10)
        GroupBox3.Controls.Add(Label13)
        GroupBox3.Controls.Add(Label15)
        GroupBox3.Controls.Add(TextBox9_calleComercial)
        GroupBox3.Location = New Point(285, 367)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(267, 191)
        GroupBox3.TabIndex = 44
        GroupBox3.TabStop = False
        GroupBox3.Text = "Dirección comercial"
        ' 
        ' ComboBox3_comunaComercial
        ' 
        ComboBox3_comunaComercial.Enabled = False
        ComboBox3_comunaComercial.Font = New Font("Segoe UI", 12F)
        ComboBox3_comunaComercial.FormattingEnabled = True
        ComboBox3_comunaComercial.Location = New Point(6, 99)
        ComboBox3_comunaComercial.Name = "ComboBox3_comunaComercial"
        ComboBox3_comunaComercial.Size = New Size(254, 29)
        ComboBox3_comunaComercial.TabIndex = 21
        ' 
        ' ComboBox4_regionComercial
        ' 
        ComboBox4_regionComercial.Font = New Font("Segoe UI", 12F)
        ComboBox4_regionComercial.FormattingEnabled = True
        ComboBox4_regionComercial.Items.AddRange(New Object() {"Arica y Parinacota", "Tarapacá", "Antofagasta", "Atacama", "Coquimbo", "Valparaíso", "Metropolitana de Santiago", "Libertador General Bernardo O'Higgins", "Maule", "Ñuble", "Biobío", "Araucanía", "Los Ríos", "Los Lagos", "Aysén del General Carlos Ibáñez del Campo", "Magallanes y de la Antártica Chilena"})
        ComboBox4_regionComercial.Location = New Point(6, 40)
        ComboBox4_regionComercial.Name = "ComboBox4_regionComercial"
        ComboBox4_regionComercial.Size = New Size(254, 29)
        ComboBox4_regionComercial.TabIndex = 20
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(6, 19)
        Label10.Name = "Label10"
        Label10.Size = New Size(64, 21)
        Label10.TabIndex = 6
        Label10.Text = "Región"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(6, 75)
        Label13.Name = "Label13"
        Label13.Size = New Size(74, 21)
        Label13.TabIndex = 0
        Label13.Text = "Comuna"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(6, 131)
        Label15.Name = "Label15"
        Label15.Size = New Size(161, 21)
        Label15.TabIndex = 2
        Label15.Text = "Calle y numeración."
        ' 
        ' TextBox9_calleComercial
        ' 
        TextBox9_calleComercial.Enabled = False
        TextBox9_calleComercial.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox9_calleComercial.Location = New Point(6, 155)
        TextBox9_calleComercial.Name = "TextBox9_calleComercial"
        TextBox9_calleComercial.Size = New Size(254, 29)
        TextBox9_calleComercial.TabIndex = 3
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.White
        GroupBox2.Controls.Add(ComboBox2_comunaPersonal)
        GroupBox2.Controls.Add(ComboBox1_regionPersonal)
        GroupBox2.Controls.Add(Label11)
        GroupBox2.Controls.Add(Label12)
        GroupBox2.Controls.Add(Label14)
        GroupBox2.Controls.Add(TextBox12_callePersonal)
        GroupBox2.Location = New Point(12, 367)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(267, 191)
        GroupBox2.TabIndex = 43
        GroupBox2.TabStop = False
        GroupBox2.Text = "Dirección personal"
        ' 
        ' ComboBox2_comunaPersonal
        ' 
        ComboBox2_comunaPersonal.Enabled = False
        ComboBox2_comunaPersonal.Font = New Font("Segoe UI", 12F)
        ComboBox2_comunaPersonal.FormattingEnabled = True
        ComboBox2_comunaPersonal.Location = New Point(6, 99)
        ComboBox2_comunaPersonal.Name = "ComboBox2_comunaPersonal"
        ComboBox2_comunaPersonal.Size = New Size(254, 29)
        ComboBox2_comunaPersonal.TabIndex = 21
        ' 
        ' ComboBox1_regionPersonal
        ' 
        ComboBox1_regionPersonal.Font = New Font("Segoe UI", 12F)
        ComboBox1_regionPersonal.FormattingEnabled = True
        ComboBox1_regionPersonal.Items.AddRange(New Object() {"Arica y Parinacota", "Tarapacá", "Antofagasta", "Atacama", "Coquimbo", "Valparaíso", "Metropolitana de Santiago", "Libertador General Bernardo O'Higgins", "Maule", "Ñuble", "Biobío", "Araucanía", "Los Ríos", "Los Lagos", "Aysén del General Carlos Ibáñez del Campo", "Magallanes y de la Antártica Chilena"})
        ComboBox1_regionPersonal.Location = New Point(6, 40)
        ComboBox1_regionPersonal.Name = "ComboBox1_regionPersonal"
        ComboBox1_regionPersonal.Size = New Size(254, 29)
        ComboBox1_regionPersonal.TabIndex = 20
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(6, 19)
        Label11.Name = "Label11"
        Label11.Size = New Size(64, 21)
        Label11.TabIndex = 6
        Label11.Text = "Región"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(6, 75)
        Label12.Name = "Label12"
        Label12.Size = New Size(74, 21)
        Label12.TabIndex = 0
        Label12.Text = "Comuna"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(6, 131)
        Label14.Name = "Label14"
        Label14.Size = New Size(161, 21)
        Label14.TabIndex = 2
        Label14.Text = "Calle y numeración."
        ' 
        ' TextBox12_callePersonal
        ' 
        TextBox12_callePersonal.Enabled = False
        TextBox12_callePersonal.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox12_callePersonal.Location = New Point(6, 155)
        TextBox12_callePersonal.Name = "TextBox12_callePersonal"
        TextBox12_callePersonal.Size = New Size(254, 29)
        TextBox12_callePersonal.TabIndex = 3
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
        GroupBox1.Location = New Point(12, 67)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(267, 294)
        GroupBox1.TabIndex = 46
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
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(291, 67)
        Label5.Name = "Label5"
        Label5.Size = New Size(168, 17)
        Label5.TabIndex = 47
        Label5.Text = "Dirección personal actual:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(291, 110)
        Label6.Name = "Label6"
        Label6.Size = New Size(174, 17)
        Label6.TabIndex = 49
        Label6.Text = "Dirección comercial actual:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(291, 153)
        Label7.Name = "Label7"
        Label7.Size = New Size(184, 17)
        Label7.TabIndex = 51
        Label7.Text = "Dirección facturación actual:"
        ' 
        ' Button_modificar
        ' 
        Button_modificar.BackColor = Color.DarkSeaGreen
        Button_modificar.Enabled = False
        Button_modificar.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button_modificar.Location = New Point(435, 222)
        Button_modificar.Name = "Button_modificar"
        Button_modificar.Size = New Size(238, 106)
        Button_modificar.TabIndex = 53
        Button_modificar.Text = "Modificar"
        Button_modificar.UseVisualStyleBackColor = False
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Location = New Point(96, 9)
        Label25.Name = "Label25"
        Label25.Size = New Size(117, 15)
        Label25.TabIndex = 54
        Label25.Text = "Formato: 12345678-9"
        ' 
        ' Label_direccionFacturacion
        ' 
        Label_direccionFacturacion.AutoSize = True
        Label_direccionFacturacion.Font = New Font("Segoe UI", 7F, FontStyle.Bold)
        Label_direccionFacturacion.Location = New Point(291, 176)
        Label_direccionFacturacion.Name = "Label_direccionFacturacion"
        Label_direccionFacturacion.Size = New Size(17, 12)
        Label_direccionFacturacion.TabIndex = 57
        Label_direccionFacturacion.Text = "---"
        ' 
        ' Label_direccionComercial
        ' 
        Label_direccionComercial.AutoSize = True
        Label_direccionComercial.Font = New Font("Segoe UI", 7F, FontStyle.Bold)
        Label_direccionComercial.Location = New Point(291, 127)
        Label_direccionComercial.Name = "Label_direccionComercial"
        Label_direccionComercial.Size = New Size(17, 12)
        Label_direccionComercial.TabIndex = 56
        Label_direccionComercial.Text = "---"
        ' 
        ' Label_direccionPersonal
        ' 
        Label_direccionPersonal.AutoSize = True
        Label_direccionPersonal.Font = New Font("Segoe UI", 7F, FontStyle.Bold)
        Label_direccionPersonal.Location = New Point(291, 84)
        Label_direccionPersonal.Name = "Label_direccionPersonal"
        Label_direccionPersonal.Size = New Size(17, 12)
        Label_direccionPersonal.TabIndex = 55
        Label_direccionPersonal.Text = "---"
        ' 
        ' EditarDireccion
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(861, 566)
        Controls.Add(Label_direccionFacturacion)
        Controls.Add(Label_direccionComercial)
        Controls.Add(Label_direccionPersonal)
        Controls.Add(Label25)
        Controls.Add(Button_modificar)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(GroupBox1)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(BuscarButton)
        Controls.Add(Label19)
        Controls.Add(buscarRut)
        Name = "EditarDireccion"
        Text = "EditarDireccion"
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BuscarButton As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents buscarRut As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents ComboBox5_comunaFacturacion As ComboBox
    Friend WithEvents ComboBox6_regionFacturacion As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents TextBox10_calleFacturacion As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ComboBox3_comunaComercial As ComboBox
    Friend WithEvents ComboBox4_regionComercial As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBox9_calleComercial As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ComboBox2_comunaPersonal As ComboBox
    Friend WithEvents ComboBox1_regionPersonal As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox12_callePersonal As TextBox
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
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button_modificar As Button
    Friend WithEvents Label25 As Label
    Friend WithEvents Label_direccionFacturacion As Label
    Friend WithEvents Label_direccionComercial As Label
    Friend WithEvents Label_direccionPersonal As Label
End Class
