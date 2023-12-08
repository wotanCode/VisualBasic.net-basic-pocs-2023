<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ingresarNota
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
        ComboBox1 = New ComboBox()
        Label1 = New Label()
        ComboBox2_curso = New ComboBox()
        Label2 = New Label()
        Label3 = New Label()
        ComboBox3_asignatura = New ComboBox()
        Label4 = New Label()
        ComboBox4_control = New ComboBox()
        TextBox1 = New TextBox()
        Label5 = New Label()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(12, 52)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(297, 23)
        ComboBox1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(136, 20)
        Label1.TabIndex = 1
        Label1.Text = "Selecciona Alumno"
        ' 
        ' ComboBox2_curso
        ' 
        ComboBox2_curso.FormattingEnabled = True
        ComboBox2_curso.Items.AddRange(New Object() {"A1", "A2", "B1", "B2", "C1"})
        ComboBox2_curso.Location = New Point(12, 101)
        ComboBox2_curso.Name = "ComboBox2_curso"
        ComboBox2_curso.Size = New Size(297, 23)
        ComboBox2_curso.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(12, 78)
        Label2.Name = "Label2"
        Label2.Size = New Size(121, 20)
        Label2.TabIndex = 3
        Label2.Text = "Selecciona Curso"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(12, 127)
        Label3.Name = "Label3"
        Label3.Size = New Size(155, 20)
        Label3.TabIndex = 5
        Label3.Text = "Selecciona Asignatura"
        ' 
        ' ComboBox3_asignatura
        ' 
        ComboBox3_asignatura.FormattingEnabled = True
        ComboBox3_asignatura.Items.AddRange(New Object() {"Álgebra", "Geometría", "Historia", "Biología", "Química"})
        ComboBox3_asignatura.Location = New Point(12, 150)
        ComboBox3_asignatura.Name = "ComboBox3_asignatura"
        ComboBox3_asignatura.Size = New Size(297, 23)
        ComboBox3_asignatura.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(12, 176)
        Label4.Name = "Label4"
        Label4.Size = New Size(133, 20)
        Label4.TabIndex = 7
        Label4.Text = "Selecciona Control"
        ' 
        ' ComboBox4_control
        ' 
        ComboBox4_control.FormattingEnabled = True
        ComboBox4_control.Items.AddRange(New Object() {"10", "15", "18", "20", "25"})
        ComboBox4_control.Location = New Point(12, 199)
        ComboBox4_control.Name = "ComboBox4_control"
        ComboBox4_control.Size = New Size(297, 23)
        ComboBox4_control.TabIndex = 6
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(109, 248)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(91, 225)
        Label5.Name = "Label5"
        Label5.Size = New Size(136, 20)
        Label5.TabIndex = 9
        Label5.Text = "Ingresa calificación"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(12, 310)
        Button1.Name = "Button1"
        Button1.Size = New Size(297, 75)
        Button1.TabIndex = 10
        Button1.Text = "INGRESAR NOTA"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' IngresarNota
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(325, 397)
        Controls.Add(Button1)
        Controls.Add(Label5)
        Controls.Add(TextBox1)
        Controls.Add(Label4)
        Controls.Add(ComboBox4_control)
        Controls.Add(Label3)
        Controls.Add(ComboBox3_asignatura)
        Controls.Add(Label2)
        Controls.Add(ComboBox2_curso)
        Controls.Add(Label1)
        Controls.Add(ComboBox1)
        Name = "IngresarNota"
        Text = "Ingresar Nota"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox2_curso As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox3_asignatura As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox4_control As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
End Class
