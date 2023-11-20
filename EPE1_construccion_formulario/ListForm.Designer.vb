<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListForm
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
        CheckedListBox1 = New CheckedListBox()
        ListView1 = New ListView()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' CheckedListBox1
        ' 
        CheckedListBox1.FormattingEnabled = True
        CheckedListBox1.Items.AddRange(New Object() {"Hacer la Tarea de .net", "Limpiar el cuarto", "Estudiar Javascript", "Ser todo un Campeon", "Terminar curso de NextJs", "Terminar curso de Angular", "Finalizar proyecto Java"})
        CheckedListBox1.Location = New Point(12, 33)
        CheckedListBox1.Name = "CheckedListBox1"
        CheckedListBox1.Size = New Size(175, 130)
        CheckedListBox1.TabIndex = 0
        ' 
        ' ListView1
        ' 
        ListView1.Location = New Point(193, 33)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(201, 130)
        ListView1.TabIndex = 1
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.List
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(85, 21)
        Label1.TabIndex = 2
        Label1.Text = "Pendientes"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(193, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 21)
        Label2.TabIndex = 3
        Label2.Text = "Finalizados"
        ' 
        ' ListForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(406, 174)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(ListView1)
        Controls.Add(CheckedListBox1)
        Name = "ListForm"
        Text = "Lista de Tareas"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
