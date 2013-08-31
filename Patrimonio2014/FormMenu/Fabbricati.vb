Public Class Fabbricati

    Private Sub FabbricatiBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles FabbricatiBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.FabbricatiBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet2)

    End Sub

    Private Sub Fabbricati_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.FabbricatiScale'. È possibile spostarla o rimuoverla se necessario.
        'Me.FabbricatiScaleTableAdapter.Fill(Me.IMMOBILIDataSet2.FabbricatiScale)
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.Fabbricati'. È possibile spostarla o rimuoverla se necessario.
        'Me.FabbricatiTableAdapter.Fill(Me.IMMOBILIDataSet2.Fabbricati)
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.FabbricatiDettaglio'. È possibile spostarla o rimuoverla se necessario.
        Me.FabbricatiDettaglioTableAdapter.Fill(Me.IMMOBILIDataSet2.FabbricatiDettaglio)
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.FabbricatiScale'. È possibile spostarla o rimuoverla se necessario.
        'Me.FabbricatiDettaglioTableAdapter.Fill(Me.IMMOBILIDataSet2.FabbricatiScale)
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.Fabbricati'. È possibile spostarla o rimuoverla se necessario.
        Me.FabbricatiTableAdapter.Fill(Me.IMMOBILIDataSet2.Fabbricati)

    End Sub
End Class