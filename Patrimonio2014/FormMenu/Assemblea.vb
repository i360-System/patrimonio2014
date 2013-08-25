Public Class Assemblea

    Private Sub AssembleaBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles AssembleaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AssembleaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet2)

    End Sub

    Private Sub Assemblea_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.AssembleaDettaglio'. È possibile spostarla o rimuoverla se necessario.
        Me.AssembleaDettaglioTableAdapter.Fill(Me.IMMOBILIDataSet2.AssembleaDettaglio)
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.Assemblea'. È possibile spostarla o rimuoverla se necessario.
        Me.AssembleaTableAdapter.Fill(Me.IMMOBILIDataSet2.Assemblea)

    End Sub
End Class