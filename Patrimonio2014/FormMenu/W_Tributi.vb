Public Class W_Tributi

    Private Sub W_TributiBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles W_TributiBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.W_TributiBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet2)

    End Sub

    Private Sub W_Tributi_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.W_Tributi'. È possibile spostarla o rimuoverla se necessario.
        Me.W_TributiTableAdapter.Fill(Me.IMMOBILIDataSet2.W_Tributi)

    End Sub
End Class