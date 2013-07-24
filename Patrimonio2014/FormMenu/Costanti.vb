Public Class Costanti

    Private Sub CostantiBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.CostantiBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet)

    End Sub

    Private Sub Costanti_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet.CostantiDettaglio'. È possibile spostarla o rimuoverla se necessario.
        Me.CostantiDettaglioTableAdapter.Fill(Me.IMMOBILIDataSet.CostantiDettaglio)
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet.Costanti'. È possibile spostarla o rimuoverla se necessario.
        Me.CostantiTableAdapter.Fill(Me.IMMOBILIDataSet.Costanti)

    End Sub
End Class