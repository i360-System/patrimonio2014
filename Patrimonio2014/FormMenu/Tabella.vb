Public Class Tabella

    Private Sub TabellaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.TabellaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet)

    End Sub

    Private Sub Tabella_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet.TabellaDettaglio'. È possibile spostarla o rimuoverla se necessario.
        Me.TabellaDettaglioTableAdapter.Fill(Me.IMMOBILIDataSet.TabellaDettaglio)
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet.Tabella'. È possibile spostarla o rimuoverla se necessario.
        Me.TabellaTableAdapter.Fill(Me.IMMOBILIDataSet.Tabella)

    End Sub
End Class