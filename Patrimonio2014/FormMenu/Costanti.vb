Public Class Costanti

    Private Sub CostantiBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles CostantiBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CostantiBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet2)

    End Sub

    Private Sub Costanti_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.CostantiDettaglio'. È possibile spostarla o rimuoverla se necessario.
        Me.CostantiDettaglioTableAdapter.Fill(Me.IMMOBILIDataSet2.CostantiDettaglio)
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.Costanti'. È possibile spostarla o rimuoverla se necessario.
        Me.CostantiTableAdapter.Fill(Me.IMMOBILIDataSet2.Costanti)

    End Sub
End Class