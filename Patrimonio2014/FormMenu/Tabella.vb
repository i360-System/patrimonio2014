Public Class Tabella

    Private Sub TabellaBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles TabellaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TabellaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet2)

    End Sub

    Private Sub Tabella_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.TabellaDettaglio'. È possibile spostarla o rimuoverla se necessario.
        Me.TabellaDettaglioTableAdapter.Fill(Me.IMMOBILIDataSet2.TabellaDettaglio)
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.Tabella'. È possibile spostarla o rimuoverla se necessario.
        Me.TabellaTableAdapter.Fill(Me.IMMOBILIDataSet2.Tabella)

    End Sub
End Class