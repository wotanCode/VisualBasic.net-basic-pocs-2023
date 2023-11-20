Public Class CalculatorForm
    Dim Operacion As String
    Dim Valor2 As Nullable(Of Double) = Nothing
    Dim ValorResultado As Nullable(Of Double) = Nothing
    Dim Bandera As Boolean

    'Evaluamos si debemos concatenar los 0
    Private Sub DeterminarConcatenar()
        If Bandera = True Then
            ResultTextBox.Text = ""
            Bandera = False
        ElseIf ResultTextBox.Text = "0" Then
            ResultTextBox.Text = ""
        End If
    End Sub

    'Sub rutina para hacer la operacion
    Public Sub EvaluayHazOperacion()
        Bandera = True
        Valor2 = Val(ResultTextBox.Text)
        If ValorResultado IsNot Nothing Then
            Select Case Operacion
                Case "+"
                    ValorResultado = ValorResultado + Valor2
                Case "-"
                    ValorResultado -= Valor2
                Case "x"
                    ValorResultado *= Valor2
                Case "/"
                    ValorResultado /= Valor2
            End Select
            ResultTextBox.Text = ValorResultado
        Else
            ValorResultado = Valor2
        End If
    End Sub

    'Reset de todo
    Private Sub ButtonCE_Click(sender As Object, e As EventArgs) Handles ButtonCE.Click
        ResultTextBox.Text = String.Empty
        Operacion = String.Empty
        Valor2 = Nothing
        ValorResultado = Nothing
    End Sub

    'Agregamos el numero al textBox
    Private Sub NumeroButtonClick(sender As Object, e As EventArgs) Handles ButtonNumber00.Click, ButtonNumber01.Click, ButtonNumber02.Click, ButtonNumber03.Click, ButtonNumber04.Click, ButtonNumber05.Click, ButtonNumber06.Click, ButtonNumber07.Click, ButtonNumber08.Click, ButtonNumber09.Click
        Dim NumberAddingValue = DirectCast(sender, Button)
        DeterminarConcatenar()
        ResultTextBox.Text &= NumberAddingValue.Text
    End Sub

    'Agregamos el punto decimal
    Private Sub ButtonPoint_Click(sender As Object, e As EventArgs) Handles ButtonPoint.Click
        DeterminarConcatenar()
        If InStr(ResultTextBox.Text, ".", CompareMethod.Text) = 0 Then
            ResultTextBox.Text &= "."
        End If
    End Sub

    'Agregamos Operación
    Private Sub ButtonOperation_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click, ButtonSub.Click, ButtonMul.Click, ButtonDiv.Click
        Dim OperationValue = DirectCast(sender, Button)
        EvaluayHazOperacion()
        Operacion = OperationValue.Text
    End Sub

    'Hacemos la operación con el boton de = y limpiamos la variable Operacion
    Private Sub ButtonResult_Click(sender As Object, e As EventArgs) Handles ButtonResult.Click
        EvaluayHazOperacion()
        Operacion = ""
    End Sub
End Class