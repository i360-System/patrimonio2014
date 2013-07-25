Public Class W_Tributi

    Private Sub W_TributiBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.W_TributiBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet)

    End Sub

    Private Sub W_Tributi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet.W_Tributi'. È possibile spostarla o rimuoverla se necessario.
        Me.W_TributiTableAdapter.Fill(Me.IMMOBILIDataSet.W_Tributi)

    End Sub
End Class