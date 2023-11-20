Public Class ListForm
    Private Sub CheckedListBox1_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles CheckedListBox1.ItemCheck
        ' Verificar si el elemento está siendo marcado o desmarcado
        If e.NewValue = CheckState.Checked Then
            ' Agregar el elemento al ListView
            ListView1.Items.Add(CheckedListBox1.Items(e.Index).ToString())
        Else
            ' Remover el elemento del ListView
            Dim itemToRemove As String = CheckedListBox1.Items(e.Index).ToString()
            For Each listItem As ListViewItem In ListView1.Items
                If listItem.Text = itemToRemove Then
                    ListView1.Items.Remove(listItem)
                    Exit For
                End If
            Next
        End If
    End Sub
End Class