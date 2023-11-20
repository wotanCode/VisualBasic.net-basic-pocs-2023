<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalculatorForm
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
        ResultTextBox = New TextBox()
        ButtonNumber07 = New Button()
        ButtonNumber08 = New Button()
        ButtonNumber09 = New Button()
        ButtonDiv = New Button()
        ButtonMul = New Button()
        ButtonNumber06 = New Button()
        ButtonNumber05 = New Button()
        ButtonNumber04 = New Button()
        ButtonSub = New Button()
        ButtonNumber03 = New Button()
        ButtonNumber02 = New Button()
        ButtonNumber01 = New Button()
        ButtonAdd = New Button()
        ButtonResult = New Button()
        ButtonNumber00 = New Button()
        ButtonPoint = New Button()
        ButtonCE = New Button()
        SuspendLayout()
        ' 
        ' ResultTextBox
        ' 
        ResultTextBox.BackColor = Color.White
        ResultTextBox.Font = New Font("Segoe UI", 14F)
        ResultTextBox.Location = New Point(12, 12)
        ResultTextBox.Name = "ResultTextBox"
        ResultTextBox.ReadOnly = True
        ResultTextBox.Size = New Size(238, 32)
        ResultTextBox.TabIndex = 0
        ResultTextBox.Text = "0"
        ResultTextBox.TextAlign = HorizontalAlignment.Right
        ' 
        ' ButtonNumber07
        ' 
        ButtonNumber07.Font = New Font("Segoe UI", 20F)
        ButtonNumber07.Location = New Point(12, 50)
        ButtonNumber07.Name = "ButtonNumber07"
        ButtonNumber07.Size = New Size(55, 53)
        ButtonNumber07.TabIndex = 1
        ButtonNumber07.Text = "7"
        ButtonNumber07.UseVisualStyleBackColor = True
        ' 
        ' ButtonNumber08
        ' 
        ButtonNumber08.Font = New Font("Segoe UI", 20F)
        ButtonNumber08.Location = New Point(73, 50)
        ButtonNumber08.Name = "ButtonNumber08"
        ButtonNumber08.Size = New Size(55, 53)
        ButtonNumber08.TabIndex = 2
        ButtonNumber08.Text = "8"
        ButtonNumber08.UseVisualStyleBackColor = True
        ' 
        ' ButtonNumber09
        ' 
        ButtonNumber09.Font = New Font("Segoe UI", 20F)
        ButtonNumber09.Location = New Point(134, 50)
        ButtonNumber09.Name = "ButtonNumber09"
        ButtonNumber09.Size = New Size(55, 53)
        ButtonNumber09.TabIndex = 3
        ButtonNumber09.Text = "9"
        ButtonNumber09.UseVisualStyleBackColor = True
        ' 
        ' ButtonDiv
        ' 
        ButtonDiv.Font = New Font("Segoe UI", 20F)
        ButtonDiv.Location = New Point(195, 50)
        ButtonDiv.Name = "ButtonDiv"
        ButtonDiv.Size = New Size(55, 53)
        ButtonDiv.TabIndex = 4
        ButtonDiv.Text = "/"
        ButtonDiv.UseVisualStyleBackColor = True
        ' 
        ' ButtonMul
        ' 
        ButtonMul.Font = New Font("Segoe UI", 20F)
        ButtonMul.Location = New Point(195, 109)
        ButtonMul.Name = "ButtonMul"
        ButtonMul.Size = New Size(55, 53)
        ButtonMul.TabIndex = 8
        ButtonMul.Text = "x"
        ButtonMul.UseVisualStyleBackColor = True
        ' 
        ' ButtonNumber06
        ' 
        ButtonNumber06.Font = New Font("Segoe UI", 20F)
        ButtonNumber06.Location = New Point(134, 109)
        ButtonNumber06.Name = "ButtonNumber06"
        ButtonNumber06.Size = New Size(55, 53)
        ButtonNumber06.TabIndex = 7
        ButtonNumber06.Text = "6"
        ButtonNumber06.UseVisualStyleBackColor = True
        ' 
        ' ButtonNumber05
        ' 
        ButtonNumber05.Font = New Font("Segoe UI", 20F)
        ButtonNumber05.Location = New Point(73, 109)
        ButtonNumber05.Name = "ButtonNumber05"
        ButtonNumber05.Size = New Size(55, 53)
        ButtonNumber05.TabIndex = 6
        ButtonNumber05.Text = "5"
        ButtonNumber05.UseVisualStyleBackColor = True
        ' 
        ' ButtonNumber04
        ' 
        ButtonNumber04.Font = New Font("Segoe UI", 20F)
        ButtonNumber04.Location = New Point(12, 109)
        ButtonNumber04.Name = "ButtonNumber04"
        ButtonNumber04.Size = New Size(55, 53)
        ButtonNumber04.TabIndex = 5
        ButtonNumber04.Text = "4"
        ButtonNumber04.UseVisualStyleBackColor = True
        ' 
        ' ButtonSub
        ' 
        ButtonSub.Font = New Font("Segoe UI", 20F)
        ButtonSub.Location = New Point(195, 168)
        ButtonSub.Name = "ButtonSub"
        ButtonSub.Size = New Size(55, 53)
        ButtonSub.TabIndex = 12
        ButtonSub.Text = "-"
        ButtonSub.UseVisualStyleBackColor = True
        ' 
        ' ButtonNumber03
        ' 
        ButtonNumber03.Font = New Font("Segoe UI", 20F)
        ButtonNumber03.Location = New Point(134, 168)
        ButtonNumber03.Name = "ButtonNumber03"
        ButtonNumber03.Size = New Size(55, 53)
        ButtonNumber03.TabIndex = 11
        ButtonNumber03.Text = "3"
        ButtonNumber03.UseVisualStyleBackColor = True
        ' 
        ' ButtonNumber02
        ' 
        ButtonNumber02.Font = New Font("Segoe UI", 20F)
        ButtonNumber02.Location = New Point(73, 168)
        ButtonNumber02.Name = "ButtonNumber02"
        ButtonNumber02.Size = New Size(55, 53)
        ButtonNumber02.TabIndex = 10
        ButtonNumber02.Text = "2"
        ButtonNumber02.UseVisualStyleBackColor = True
        ' 
        ' ButtonNumber01
        ' 
        ButtonNumber01.Font = New Font("Segoe UI", 20F)
        ButtonNumber01.Location = New Point(12, 168)
        ButtonNumber01.Name = "ButtonNumber01"
        ButtonNumber01.Size = New Size(55, 53)
        ButtonNumber01.TabIndex = 9
        ButtonNumber01.Text = "1"
        ButtonNumber01.UseVisualStyleBackColor = True
        ' 
        ' ButtonAdd
        ' 
        ButtonAdd.Font = New Font("Segoe UI", 20F)
        ButtonAdd.Location = New Point(195, 227)
        ButtonAdd.Name = "ButtonAdd"
        ButtonAdd.Size = New Size(55, 53)
        ButtonAdd.TabIndex = 16
        ButtonAdd.Text = "+"
        ButtonAdd.UseVisualStyleBackColor = True
        ' 
        ' ButtonResult
        ' 
        ButtonResult.Font = New Font("Segoe UI", 20F)
        ButtonResult.Location = New Point(134, 227)
        ButtonResult.Name = "ButtonResult"
        ButtonResult.Size = New Size(55, 53)
        ButtonResult.TabIndex = 15
        ButtonResult.Text = "="
        ButtonResult.UseVisualStyleBackColor = True
        ' 
        ' ButtonNumber00
        ' 
        ButtonNumber00.Font = New Font("Segoe UI", 20F)
        ButtonNumber00.Location = New Point(73, 227)
        ButtonNumber00.Name = "ButtonNumber00"
        ButtonNumber00.Size = New Size(55, 53)
        ButtonNumber00.TabIndex = 14
        ButtonNumber00.Text = "0"
        ButtonNumber00.UseVisualStyleBackColor = True
        ' 
        ' ButtonPoint
        ' 
        ButtonPoint.Font = New Font("Segoe UI", 20F)
        ButtonPoint.Location = New Point(12, 227)
        ButtonPoint.Name = "ButtonPoint"
        ButtonPoint.Size = New Size(55, 53)
        ButtonPoint.TabIndex = 13
        ButtonPoint.Text = "."
        ButtonPoint.UseVisualStyleBackColor = True
        ' 
        ' ButtonCE
        ' 
        ButtonCE.Font = New Font("Segoe UI", 20F)
        ButtonCE.Location = New Point(12, 286)
        ButtonCE.Name = "ButtonCE"
        ButtonCE.Size = New Size(238, 53)
        ButtonCE.TabIndex = 17
        ButtonCE.Text = "CE"
        ButtonCE.UseVisualStyleBackColor = True
        ' 
        ' CalculatorForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MidnightBlue
        ClientSize = New Size(262, 354)
        Controls.Add(ButtonCE)
        Controls.Add(ButtonAdd)
        Controls.Add(ButtonResult)
        Controls.Add(ButtonNumber00)
        Controls.Add(ButtonPoint)
        Controls.Add(ButtonSub)
        Controls.Add(ButtonNumber03)
        Controls.Add(ButtonNumber02)
        Controls.Add(ButtonNumber01)
        Controls.Add(ButtonMul)
        Controls.Add(ButtonNumber06)
        Controls.Add(ButtonNumber05)
        Controls.Add(ButtonNumber04)
        Controls.Add(ButtonDiv)
        Controls.Add(ButtonNumber09)
        Controls.Add(ButtonNumber08)
        Controls.Add(ButtonNumber07)
        Controls.Add(ResultTextBox)
        Name = "CalculatorForm"
        Text = "Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ResultTextBox As TextBox
    Friend WithEvents ButtonNumber07 As Button
    Friend WithEvents ButtonNumber08 As Button
    Friend WithEvents ButtonNumber09 As Button
    Friend WithEvents ButtonDiv As Button
    Friend WithEvents ButtonMul As Button
    Friend WithEvents ButtonNumber06 As Button
    Friend WithEvents ButtonNumber05 As Button
    Friend WithEvents ButtonNumber04 As Button
    Friend WithEvents ButtonSub As Button
    Friend WithEvents ButtonNumber03 As Button
    Friend WithEvents ButtonNumber02 As Button
    Friend WithEvents ButtonNumber01 As Button
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents ButtonResult As Button
    Friend WithEvents ButtonNumber00 As Button
    Friend WithEvents ButtonPoint As Button
    Friend WithEvents ButtonCE As Button
End Class
