Public Class Fabbricati

    Private Sub FabbricatiBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles FabbricatiBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.FabbricatiBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet2)

    End Sub

    Private Sub Fabbricati_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.FabbricatiDettaglio1'. È possibile spostarla o rimuoverla se necessario.
        Me.FabbricatiDettaglio1TableAdapter.Fill(Me.IMMOBILIDataSet2.FabbricatiDettaglio1)
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.Fabbricati'. È possibile spostarla o rimuoverla se necessario.
        Me.FabbricatiTableAdapter.Fill(Me.IMMOBILIDataSet2.Fabbricati)

    End Sub
End Class