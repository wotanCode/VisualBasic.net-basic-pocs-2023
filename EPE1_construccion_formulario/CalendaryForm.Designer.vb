<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalendaryForm
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
        calendaryDate = New MonthCalendar()
        Label1 = New Label()
        Label2 = New Label()
        TextBoxActividad = New TextBox()
        LabelNombreActividad = New Label()
        btnAgregar = New Button()
        LabelFechaActividad = New Label()
        SuspendLayout()
        ' 
        ' calendaryDate
        ' 
        calendaryDate.Font = New Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        calendaryDate.Location = New Point(37, 112)
        calendaryDate.Name = "calendaryDate"
        calendaryDate.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(264, 25)
        Label1.TabIndex = 2
        Label1.Text = "Selecciona la fecha de tu cita"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(18, 88)
        Label2.Name = "Label2"
        Label2.Size = New Size(130, 15)
        Label2.TabIndex = 3
        Label2.Text = "Nombre de la actividad"
        ' 
        ' TextBoxActividad
        ' 
        TextBoxActividad.Font = New Font("Segoe UI", 16F)
        TextBoxActividad.Location = New Point(18, 49)
        TextBoxActividad.Name = "TextBoxActividad"
        TextBoxActividad.Size = New Size(288, 36)
        TextBoxActividad.TabIndex = 4
        ' 
        ' LabelNombreActividad
        ' 
        LabelNombreActividad.AutoSize = True
        LabelNombreActividad.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelNombreActividad.Location = New Point(37, 348)
        LabelNombreActividad.Name = "LabelNombreActividad"
        LabelNombreActividad.Size = New Size(0, 25)
        LabelNombreActividad.TabIndex = 5
        ' 
        ' btnAgregar
        ' 
        btnAgregar.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAgregar.Location = New Point(111, 286)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(87, 50)
        btnAgregar.TabIndex = 6
        btnAgregar.Text = "Agregar"
        btnAgregar.UseVisualStyleBackColor = True
        ' 
        ' LabelFechaActividad
        ' 
        LabelFechaActividad.AutoSize = True
        LabelFechaActividad.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelFechaActividad.Location = New Point(37, 387)
        LabelFechaActividad.Name = "LabelFechaActividad"
        LabelFechaActividad.Size = New Size(0, 25)
        LabelFechaActividad.TabIndex = 7
        ' 
        ' CalendaryForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(328, 453)
        Controls.Add(LabelFechaActividad)
        Controls.Add(btnAgregar)
        Controls.Add(LabelNombreActividad)
        Controls.Add(TextBoxActividad)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(calendaryDate)
        Name = "CalendaryForm"
        Text = "Calendario"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents calendaryDate As MonthCalendar
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxActividad As TextBox
    Friend WithEvents LabelNombreActividad As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents LabelFechaActividad As Label
End Class
