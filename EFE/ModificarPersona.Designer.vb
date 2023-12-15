<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarPersona
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
        Label7 = New Label()
        GroupBox6 = New GroupBox()
        ComboBox_gruposanguineo = New ComboBox()
        Label9 = New Label()
        GroupBox5 = New GroupBox()
        Label6 = New Label()
        TextBox5_correoLaboral = New TextBox()
        Label20 = New Label()
        Label21 = New Label()
        TextBox14_telefonoFijo = New TextBox()
        TextBox15_telefonoMovil = New TextBox()
        Label5 = New Label()
        TextBox4_correoPersonal = New TextBox()
        GroupBox4 = New GroupBox()
        Label_direccionFacturacion = New Label()
        ComboBox5_comunaFacturacion = New ComboBox()
        Label24 = New Label()
        ComboBox6_regionFacturacion = New ComboBox()
        Label16 = New Label()
        Label17 = New Label()
        Label18 = New Label()
        TextBox10_calleFacturacion = New TextBox()
        GroupBox3 = New GroupBox()
        Label_direccionComercial = New Label()
        ComboBox3_comunaComercial = New ComboBox()
        Label23 = New Label()
        ComboBox4_regionComercial = New ComboBox()
        Label10 = New Label()
        Label13 = New Label()
        Label15 = New Label()
        TextBox9_calleComercial = New TextBox()
        GroupBox2 = New GroupBox()
        Label_direccionPersonal = New Label()
        Label22 = New Label()
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
        Button1 = New Button()
        buscarRut = New TextBox()
        Label19 = New Label()
        BuscarButton = New Button()
        Label25 = New Label()
        GroupBox6.SuspendLayout()
        GroupBox5.SuspendLayout()
        GroupBox4.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label7.Location = New Point(288, 341)
        Label7.Name = "Label7"
        Label7.Size = New Size(126, 15)
        Label7.TabIndex = 36
        Label7.Text = "(*): Datos obligatorios"
        ' 
        ' GroupBox6
        ' 
        GroupBox6.BackColor = Color.White
        GroupBox6.Controls.Add(ComboBox_gruposanguineo)
        GroupBox6.Controls.Add(Label9)
        GroupBox6.Location = New Point(561, 74)
        GroupBox6.Name = "GroupBox6"
        GroupBox6.Size = New Size(267, 83)
        GroupBox6.TabIndex = 35
        GroupBox6.TabStop = False
        GroupBox6.Text = "Datos adicionales"
        ' 
        ' ComboBox_gruposanguineo
        ' 
        ComboBox_gruposanguineo.Font = New Font("Segoe UI", 12F)
        ComboBox_gruposanguineo.FormattingEnabled = True
        ComboBox_gruposanguineo.Items.AddRange(New Object() {"O-", "O+", "A-", "A+", "B-", "B+", "AB-", "AB+"})
        ComboBox_gruposanguineo.Location = New Point(6, 43)
        ComboBox_gruposanguineo.Name = "ComboBox_gruposanguineo"
        ComboBox_gruposanguineo.Size = New Size(254, 29)
        ComboBox_gruposanguineo.TabIndex = 21
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(6, 19)
        Label9.Name = "Label9"
        Label9.Size = New Size(143, 21)
        Label9.TabIndex = 18
        Label9.Text = "Grupo Sanguineo"
        ' 
        ' GroupBox5
        ' 
        GroupBox5.BackColor = Color.White
        GroupBox5.Controls.Add(Label6)
        GroupBox5.Controls.Add(TextBox5_correoLaboral)
        GroupBox5.Controls.Add(Label20)
        GroupBox5.Controls.Add(Label21)
        GroupBox5.Controls.Add(TextBox14_telefonoFijo)
        GroupBox5.Controls.Add(TextBox15_telefonoMovil)
        GroupBox5.Controls.Add(Label5)
        GroupBox5.Controls.Add(TextBox4_correoPersonal)
        GroupBox5.Location = New Point(288, 74)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Size = New Size(267, 250)
        GroupBox5.TabIndex = 31
        GroupBox5.TabStop = False
        GroupBox5.Text = "Datos de contacto"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(6, 187)
        Label6.Name = "Label6"
        Label6.Size = New Size(213, 21)
        Label6.TabIndex = 25
        Label6.Text = "Correo electronico laboral:"
        ' 
        ' TextBox5_correoLaboral
        ' 
        TextBox5_correoLaboral.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox5_correoLaboral.Location = New Point(6, 211)
        TextBox5_correoLaboral.Name = "TextBox5_correoLaboral"
        TextBox5_correoLaboral.Size = New Size(254, 29)
        TextBox5_correoLaboral.TabIndex = 26
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
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(6, 131)
        Label5.Name = "Label5"
        Label5.Size = New Size(225, 21)
        Label5.TabIndex = 8
        Label5.Text = "Correo electronico personal:"
        ' 
        ' TextBox4_correoPersonal
        ' 
        TextBox4_correoPersonal.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox4_correoPersonal.Location = New Point(6, 155)
        TextBox4_correoPersonal.Name = "TextBox4_correoPersonal"
        TextBox4_correoPersonal.Size = New Size(254, 29)
        TextBox4_correoPersonal.TabIndex = 9
        ' 
        ' GroupBox4
        ' 
        GroupBox4.BackColor = Color.White
        GroupBox4.Controls.Add(Label_direccionFacturacion)
        GroupBox4.Controls.Add(ComboBox5_comunaFacturacion)
        GroupBox4.Controls.Add(Label24)
        GroupBox4.Controls.Add(ComboBox6_regionFacturacion)
        GroupBox4.Controls.Add(Label16)
        GroupBox4.Controls.Add(Label17)
        GroupBox4.Controls.Add(Label18)
        GroupBox4.Controls.Add(TextBox10_calleFacturacion)
        GroupBox4.Location = New Point(557, 374)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(267, 259)
        GroupBox4.TabIndex = 34
        GroupBox4.TabStop = False
        GroupBox4.Text = "Dirección de facturación"
        ' 
        ' Label_direccionFacturacion
        ' 
        Label_direccionFacturacion.AutoSize = True
        Label_direccionFacturacion.Font = New Font("Segoe UI", 7F, FontStyle.Bold)
        Label_direccionFacturacion.Location = New Point(6, 38)
        Label_direccionFacturacion.Name = "Label_direccionFacturacion"
        Label_direccionFacturacion.Size = New Size(17, 12)
        Label_direccionFacturacion.TabIndex = 42
        Label_direccionFacturacion.Text = "---"
        ' 
        ' ComboBox5_comunaFacturacion
        ' 
        ComboBox5_comunaFacturacion.Enabled = False
        ComboBox5_comunaFacturacion.Font = New Font("Segoe UI", 12F)
        ComboBox5_comunaFacturacion.FormattingEnabled = True
        ComboBox5_comunaFacturacion.Location = New Point(6, 168)
        ComboBox5_comunaFacturacion.Name = "ComboBox5_comunaFacturacion"
        ComboBox5_comunaFacturacion.Size = New Size(254, 29)
        ComboBox5_comunaFacturacion.TabIndex = 21
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label24.Location = New Point(4, 19)
        Label24.Name = "Label24"
        Label24.Size = New Size(120, 19)
        Label24.TabIndex = 26
        Label24.Text = "Dirección actual:"
        ' 
        ' ComboBox6_regionFacturacion
        ' 
        ComboBox6_regionFacturacion.Font = New Font("Segoe UI", 12F)
        ComboBox6_regionFacturacion.FormattingEnabled = True
        ComboBox6_regionFacturacion.Items.AddRange(New Object() {"Arica y Parinacota", "Tarapacá", "Antofagasta", "Atacama", "Coquimbo", "Valparaíso", "Metropolitana de Santiago", "Libertador General Bernardo O'Higgins", "Maule", "Ñuble", "Biobío", "Araucanía", "Los Ríos", "Los Lagos", "Aysén del General Carlos Ibáñez del Campo", "Magallanes y de la Antártica Chilena"})
        ComboBox6_regionFacturacion.Location = New Point(6, 109)
        ComboBox6_regionFacturacion.Name = "ComboBox6_regionFacturacion"
        ComboBox6_regionFacturacion.Size = New Size(254, 29)
        ComboBox6_regionFacturacion.TabIndex = 20
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.Location = New Point(6, 88)
        Label16.Name = "Label16"
        Label16.Size = New Size(64, 21)
        Label16.TabIndex = 6
        Label16.Text = "Región"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label17.Location = New Point(6, 144)
        Label17.Name = "Label17"
        Label17.Size = New Size(74, 21)
        Label17.TabIndex = 0
        Label17.Text = "Comuna"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label18.Location = New Point(6, 200)
        Label18.Name = "Label18"
        Label18.Size = New Size(161, 21)
        Label18.TabIndex = 2
        Label18.Text = "Calle y numeración."
        ' 
        ' TextBox10_calleFacturacion
        ' 
        TextBox10_calleFacturacion.Enabled = False
        TextBox10_calleFacturacion.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox10_calleFacturacion.Location = New Point(6, 224)
        TextBox10_calleFacturacion.Name = "TextBox10_calleFacturacion"
        TextBox10_calleFacturacion.Size = New Size(254, 29)
        TextBox10_calleFacturacion.TabIndex = 3
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = Color.White
        GroupBox3.Controls.Add(Label_direccionComercial)
        GroupBox3.Controls.Add(ComboBox3_comunaComercial)
        GroupBox3.Controls.Add(Label23)
        GroupBox3.Controls.Add(ComboBox4_regionComercial)
        GroupBox3.Controls.Add(Label10)
        GroupBox3.Controls.Add(Label13)
        GroupBox3.Controls.Add(Label15)
        GroupBox3.Controls.Add(TextBox9_calleComercial)
        GroupBox3.Location = New Point(284, 374)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(267, 259)
        GroupBox3.TabIndex = 33
        GroupBox3.TabStop = False
        GroupBox3.Text = "Dirección comercial"
        ' 
        ' Label_direccionComercial
        ' 
        Label_direccionComercial.AutoSize = True
        Label_direccionComercial.Font = New Font("Segoe UI", 7F, FontStyle.Bold)
        Label_direccionComercial.Location = New Point(10, 38)
        Label_direccionComercial.Name = "Label_direccionComercial"
        Label_direccionComercial.Size = New Size(17, 12)
        Label_direccionComercial.TabIndex = 41
        Label_direccionComercial.Text = "---"
        ' 
        ' ComboBox3_comunaComercial
        ' 
        ComboBox3_comunaComercial.Enabled = False
        ComboBox3_comunaComercial.Font = New Font("Segoe UI", 12F)
        ComboBox3_comunaComercial.FormattingEnabled = True
        ComboBox3_comunaComercial.Location = New Point(6, 168)
        ComboBox3_comunaComercial.Name = "ComboBox3_comunaComercial"
        ComboBox3_comunaComercial.Size = New Size(254, 29)
        ComboBox3_comunaComercial.TabIndex = 21
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label23.Location = New Point(6, 19)
        Label23.Name = "Label23"
        Label23.Size = New Size(120, 19)
        Label23.TabIndex = 24
        Label23.Text = "Dirección actual:"
        ' 
        ' ComboBox4_regionComercial
        ' 
        ComboBox4_regionComercial.Font = New Font("Segoe UI", 12F)
        ComboBox4_regionComercial.FormattingEnabled = True
        ComboBox4_regionComercial.Items.AddRange(New Object() {"Arica y Parinacota", "Tarapacá", "Antofagasta", "Atacama", "Coquimbo", "Valparaíso", "Metropolitana de Santiago", "Libertador General Bernardo O'Higgins", "Maule", "Ñuble", "Biobío", "Araucanía", "Los Ríos", "Los Lagos", "Aysén del General Carlos Ibáñez del Campo", "Magallanes y de la Antártica Chilena"})
        ComboBox4_regionComercial.Location = New Point(6, 112)
        ComboBox4_regionComercial.Name = "ComboBox4_regionComercial"
        ComboBox4_regionComercial.Size = New Size(254, 29)
        ComboBox4_regionComercial.TabIndex = 20
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(6, 88)
        Label10.Name = "Label10"
        Label10.Size = New Size(64, 21)
        Label10.TabIndex = 6
        Label10.Text = "Región"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(6, 144)
        Label13.Name = "Label13"
        Label13.Size = New Size(74, 21)
        Label13.TabIndex = 0
        Label13.Text = "Comuna"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(6, 200)
        Label15.Name = "Label15"
        Label15.Size = New Size(161, 21)
        Label15.TabIndex = 2
        Label15.Text = "Calle y numeración."
        ' 
        ' TextBox9_calleComercial
        ' 
        TextBox9_calleComercial.Enabled = False
        TextBox9_calleComercial.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox9_calleComercial.Location = New Point(6, 224)
        TextBox9_calleComercial.Name = "TextBox9_calleComercial"
        TextBox9_calleComercial.Size = New Size(254, 29)
        TextBox9_calleComercial.TabIndex = 3
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.White
        GroupBox2.Controls.Add(Label_direccionPersonal)
        GroupBox2.Controls.Add(Label22)
        GroupBox2.Controls.Add(ComboBox2_comunaPersonal)
        GroupBox2.Controls.Add(ComboBox1_regionPersonal)
        GroupBox2.Controls.Add(Label11)
        GroupBox2.Controls.Add(Label12)
        GroupBox2.Controls.Add(Label14)
        GroupBox2.Controls.Add(TextBox12_callePersonal)
        GroupBox2.Location = New Point(11, 374)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(267, 259)
        GroupBox2.TabIndex = 32
        GroupBox2.TabStop = False
        GroupBox2.Text = "Dirección personal"
        ' 
        ' Label_direccionPersonal
        ' 
        Label_direccionPersonal.AutoSize = True
        Label_direccionPersonal.Font = New Font("Segoe UI", 7F, FontStyle.Bold)
        Label_direccionPersonal.Location = New Point(7, 38)
        Label_direccionPersonal.Name = "Label_direccionPersonal"
        Label_direccionPersonal.Size = New Size(17, 12)
        Label_direccionPersonal.TabIndex = 40
        Label_direccionPersonal.Text = "---"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label22.Location = New Point(6, 19)
        Label22.Name = "Label22"
        Label22.Size = New Size(120, 19)
        Label22.TabIndex = 22
        Label22.Text = "Dirección actual:"
        ' 
        ' ComboBox2_comunaPersonal
        ' 
        ComboBox2_comunaPersonal.Enabled = False
        ComboBox2_comunaPersonal.Font = New Font("Segoe UI", 12F)
        ComboBox2_comunaPersonal.FormattingEnabled = True
        ComboBox2_comunaPersonal.Location = New Point(6, 168)
        ComboBox2_comunaPersonal.Name = "ComboBox2_comunaPersonal"
        ComboBox2_comunaPersonal.Size = New Size(254, 29)
        ComboBox2_comunaPersonal.TabIndex = 21
        ' 
        ' ComboBox1_regionPersonal
        ' 
        ComboBox1_regionPersonal.Font = New Font("Segoe UI", 12F)
        ComboBox1_regionPersonal.FormattingEnabled = True
        ComboBox1_regionPersonal.Items.AddRange(New Object() {"Arica y Parinacota", "Tarapacá", "Antofagasta", "Atacama", "Coquimbo", "Valparaíso", "Metropolitana de Santiago", "Libertador General Bernardo O'Higgins", "Maule", "Ñuble", "Biobío", "Araucanía", "Los Ríos", "Los Lagos", "Aysén del General Carlos Ibáñez del Campo", "Magallanes y de la Antártica Chilena"})
        ComboBox1_regionPersonal.Location = New Point(6, 112)
        ComboBox1_regionPersonal.Name = "ComboBox1_regionPersonal"
        ComboBox1_regionPersonal.Size = New Size(254, 29)
        ComboBox1_regionPersonal.TabIndex = 20
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(7, 88)
        Label11.Name = "Label11"
        Label11.Size = New Size(64, 21)
        Label11.TabIndex = 6
        Label11.Text = "Región"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(7, 144)
        Label12.Name = "Label12"
        Label12.Size = New Size(74, 21)
        Label12.TabIndex = 0
        Label12.Text = "Comuna"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(6, 200)
        Label14.Name = "Label14"
        Label14.Size = New Size(161, 21)
        Label14.TabIndex = 2
        Label14.Text = "Calle y numeración."
        ' 
        ' TextBox12_callePersonal
        ' 
        TextBox12_callePersonal.Enabled = False
        TextBox12_callePersonal.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox12_callePersonal.Location = New Point(7, 224)
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
        GroupBox1.Location = New Point(11, 74)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(267, 294)
        GroupBox1.TabIndex = 30
        GroupBox1.TabStop = False
        GroupBox1.Text = "Datos personales"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(6, 19)
        Label4.Name = "Label4"
        Label4.Size = New Size(68, 21)
        Label4.TabIndex = 6
        Label4.Text = "RUT: (*)"
        ' 
        ' TextBox4_apellido2
        ' 
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
        Label1.Size = New Size(100, 21)
        Label1.TabIndex = 0
        Label1.Text = "Nombre: (*)"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(6, 187)
        Label8.Name = "Label8"
        Label8.Size = New Size(171, 21)
        Label8.TabIndex = 15
        Label8.Text = "Apellido materno: (*)"
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
        Label2.Size = New Size(166, 21)
        Label2.TabIndex = 2
        Label2.Text = "Apellido paterno: (*)"
        ' 
        ' TextBox2_nombre
        ' 
        TextBox2_nombre.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2_nombre.Location = New Point(6, 99)
        TextBox2_nombre.Name = "TextBox2_nombre"
        TextBox2_nombre.Size = New Size(254, 29)
        TextBox2_nombre.TabIndex = 7
        ' 
        ' TextBox3_apellido1
        ' 
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
        Label3.Size = New Size(175, 21)
        Label3.TabIndex = 4
        Label3.Text = "Fecha Nacimiento: (*)"
        ' 
        ' DateTimePicker1_fechaNacimiento
        ' 
        DateTimePicker1_fechaNacimiento.Location = New Point(6, 267)
        DateTimePicker1_fechaNacimiento.Name = "DateTimePicker1_fechaNacimiento"
        DateTimePicker1_fechaNacimiento.Size = New Size(254, 23)
        DateTimePicker1_fechaNacimiento.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.LimeGreen
        Button1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(563, 163)
        Button1.Name = "Button1"
        Button1.Size = New Size(261, 201)
        Button1.TabIndex = 29
        Button1.Text = "Modificar"
        Button1.TextImageRelation = TextImageRelation.ImageBeforeText
        Button1.UseVisualStyleBackColor = False
        ' 
        ' buscarRut
        ' 
        buscarRut.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        buscarRut.Location = New Point(12, 34)
        buscarRut.Name = "buscarRut"
        buscarRut.Size = New Size(206, 33)
        buscarRut.TabIndex = 37
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label19.Location = New Point(12, 14)
        Label19.Name = "Label19"
        Label19.Size = New Size(78, 17)
        Label19.TabIndex = 38
        Label19.Text = "Ingrese Rut"
        ' 
        ' BuscarButton
        ' 
        BuscarButton.AutoSizeMode = AutoSizeMode.GrowAndShrink
        BuscarButton.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BuscarButton.Location = New Point(224, 14)
        BuscarButton.Name = "BuscarButton"
        BuscarButton.Size = New Size(115, 53)
        BuscarButton.TabIndex = 39
        BuscarButton.Text = "Buscar"
        BuscarButton.UseVisualStyleBackColor = True
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Location = New Point(96, 16)
        Label25.Name = "Label25"
        Label25.Size = New Size(117, 15)
        Label25.TabIndex = 40
        Label25.Text = "Formato: 12345678-9"
        ' 
        ' ModificarPersona
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(833, 645)
        Controls.Add(Label25)
        Controls.Add(BuscarButton)
        Controls.Add(Label19)
        Controls.Add(buscarRut)
        Controls.Add(Label7)
        Controls.Add(GroupBox6)
        Controls.Add(GroupBox5)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Button1)
        Name = "ModificarPersona"
        Text = "ModificarPersona"
        GroupBox6.ResumeLayout(False)
        GroupBox6.PerformLayout()
        GroupBox5.ResumeLayout(False)
        GroupBox5.PerformLayout()
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

    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents ComboBox_gruposanguineo As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox5_correoLaboral As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents TextBox14_telefonoFijo As TextBox
    Friend WithEvents TextBox15_telefonoMovil As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox4_correoPersonal As TextBox
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
    Friend WithEvents Button1 As Button
    Friend WithEvents buscarRut As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents BuscarButton As Button
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label_direccionFacturacion As Label
    Friend WithEvents Label_direccionComercial As Label
    Friend WithEvents Label_direccionPersonal As Label
    Friend WithEvents Label25 As Label
End Class
