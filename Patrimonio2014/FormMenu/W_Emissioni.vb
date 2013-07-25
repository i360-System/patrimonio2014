Public Class W_Emissioni

    Private Sub W_EmissioniBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.W_EmissioniBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet)

    End Sub

    Private Sub W_Emissioni_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet.W_EmissioniDettaglio'. È possibile spostarla o rimuoverla se necessario.
        Me.W_EmissioniDettaglioTableAdapter.Fill(Me.IMMOBILIDataSet.W_EmissioniDettaglio)
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet.W_Emissioni'. È possibile spostarla o rimuoverla se necessario.
        Me.W_EmissioniTableAdapter.Fill(Me.IMMOBILIDataSet.W_Emissioni)

    End Sub
End Class