Public Class W_Emissioni

    Private Sub W_EmissioniBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles W_EmissioniBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.W_EmissioniBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet2)

    End Sub

    Private Sub W_Emissioni_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.W_EmissioniDettaglio'. È possibile spostarla o rimuoverla se necessario.
        Me.W_EmissioniDettaglioTableAdapter.Fill(Me.IMMOBILIDataSet2.W_EmissioniDettaglio)
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.W_Emissioni'. È possibile spostarla o rimuoverla se necessario.
        Me.W_EmissioniTableAdapter.Fill(Me.IMMOBILIDataSet2.W_Emissioni)

    End Sub
End Class