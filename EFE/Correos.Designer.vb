﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Correos
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
        Button_Modificar = New Button()
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
        Label6 = New Label()
        TextBox5_correoLaboral = New TextBox()
        Label5 = New Label()
        TextBox4_correoPersonal = New TextBox()
        GroupBox1.SuspendLayout()
        GroupBox5.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button_Modificar
        ' 
        Button_Modificar.BackColor = Color.DarkSeaGreen
        Button_Modificar.Enabled = False
        Button_Modificar.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button_Modificar.Location = New Point(285, 213)
        Button_Modificar.Name = "Button_Modificar"
        Button_Modificar.Size = New Size(267, 147)
        Button_Modificar.TabIndex = 58
        Button_Modificar.Text = "Modificar:"
        Button_Modificar.UseVisualStyleBackColor = False
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
        GroupBox1.Location = New Point(12, 66)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(267, 294)
        GroupBox1.TabIndex = 56
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
        BuscarButton.Location = New Point(224, 7)
        BuscarButton.Name = "BuscarButton"
        BuscarButton.Size = New Size(115, 53)
        BuscarButton.TabIndex = 55
        BuscarButton.Text = "Buscar"
        BuscarButton.UseVisualStyleBackColor = True
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label19.Location = New Point(12, 7)
        Label19.Name = "Label19"
        Label19.Size = New Size(78, 17)
        Label19.TabIndex = 54
        Label19.Text = "Ingrese Rut"
        ' 
        ' buscarRut
        ' 
        buscarRut.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        buscarRut.Location = New Point(12, 27)
        buscarRut.Name = "buscarRut"
        buscarRut.Size = New Size(206, 33)
        buscarRut.TabIndex = 53
        ' 
        ' GroupBox5
        ' 
        GroupBox5.BackColor = Color.White
        GroupBox5.Controls.Add(Label6)
        GroupBox5.Controls.Add(TextBox5_correoLaboral)
        GroupBox5.Controls.Add(Label5)
        GroupBox5.Controls.Add(TextBox4_correoPersonal)
        GroupBox5.Location = New Point(285, 66)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Size = New Size(267, 141)
        GroupBox5.TabIndex = 59
        GroupBox5.TabStop = False
        GroupBox5.Text = "Datos de contacto"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(6, 75)
        Label6.Name = "Label6"
        Label6.Size = New Size(213, 21)
        Label6.TabIndex = 25
        Label6.Text = "Correo electronico laboral:"
        ' 
        ' TextBox5_correoLaboral
        ' 
        TextBox5_correoLaboral.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox5_correoLaboral.Location = New Point(7, 99)
        TextBox5_correoLaboral.Name = "TextBox5_correoLaboral"
        TextBox5_correoLaboral.Size = New Size(254, 29)
        TextBox5_correoLaboral.TabIndex = 26
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(6, 19)
        Label5.Name = "Label5"
        Label5.Size = New Size(225, 21)
        Label5.TabIndex = 8
        Label5.Text = "Correo electronico personal:"
        ' 
        ' TextBox4_correoPersonal
        ' 
        TextBox4_correoPersonal.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox4_correoPersonal.Location = New Point(6, 43)
        TextBox4_correoPersonal.Name = "TextBox4_correoPersonal"
        TextBox4_correoPersonal.Size = New Size(254, 29)
        TextBox4_correoPersonal.TabIndex = 9
        ' 
        ' Correos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(557, 365)
        Controls.Add(GroupBox5)
        Controls.Add(Button_Modificar)
        Controls.Add(GroupBox1)
        Controls.Add(BuscarButton)
        Controls.Add(Label19)
        Controls.Add(buscarRut)
        Name = "Correos"
        Text = "Correos"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox5.ResumeLayout(False)
        GroupBox5.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button_Modificar As Button
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
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox5_correoLaboral As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox4_correoPersonal As TextBox
End Class
