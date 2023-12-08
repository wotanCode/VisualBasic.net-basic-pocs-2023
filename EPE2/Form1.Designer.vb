<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        DataGridView1_ListaAlumnos = New DataGridView()
        Label1 = New Label()
        Button1_ingresarAlumnoFormOpen = New Button()
        Button1 = New Button()
        Button2 = New Button()
        CType(DataGridView1_ListaAlumnos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1_ListaAlumnos
        ' 
        DataGridView1_ListaAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1_ListaAlumnos.Location = New Point(12, 39)
        DataGridView1_ListaAlumnos.Name = "DataGridView1_ListaAlumnos"
        DataGridView1_ListaAlumnos.Size = New Size(943, 569)
        DataGridView1_ListaAlumnos.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(138, 21)
        Label1.TabIndex = 1
        Label1.Text = "Lista de alumnos"
        ' 
        ' Button1_ingresarAlumnoFormOpen
        ' 
        Button1_ingresarAlumnoFormOpen.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button1_ingresarAlumnoFormOpen.Location = New Point(12, 614)
        Button1_ingresarAlumnoFormOpen.Name = "Button1_ingresarAlumnoFormOpen"
        Button1_ingresarAlumnoFormOpen.Size = New Size(125, 59)
        Button1_ingresarAlumnoFormOpen.TabIndex = 2
        Button1_ingresarAlumnoFormOpen.Text = "Insertar Alumno"
        Button1_ingresarAlumnoFormOpen.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(156, 9)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 3
        Button1.Text = "Actualizar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button2.Location = New Point(156, 614)
        Button2.Name = "Button2"
        Button2.Size = New Size(125, 59)
        Button2.TabIndex = 4
        Button2.Text = "Ingresar Nota"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1005, 685)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Button1_ingresarAlumnoFormOpen)
        Controls.Add(Label1)
        Controls.Add(DataGridView1_ListaAlumnos)
        Name = "Form1"
        Text = "NOTAS ALUMNOS"
        CType(DataGridView1_ListaAlumnos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1_ListaAlumnos As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1_ingresarAlumnoFormOpen As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button

End Class
