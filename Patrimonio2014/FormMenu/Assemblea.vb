Public Class Assemblea

    Private Sub AssembleaDettaglioBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.AssembleaDettaglioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet)

    End Sub

    Private Sub Assemblea_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet.AssembleaDettaglio'. È possibile spostarla o rimuoverla se necessario.
        Me.AssembleaDettaglioTableAdapter.Fill(Me.IMMOBILIDataSet.AssembleaDettaglio)
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet.Assemblea'. È possibile spostarla o rimuoverla se necessario.
        Me.AssembleaTableAdapter.Fill(Me.IMMOBILIDataSet.Assemblea)
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet.Assemblea'. È possibile spostarla o rimuoverla se necessario.
        Me.AssembleaTableAdapter.Fill(Me.IMMOBILIDataSet.Assemblea)
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet.AssembleaDettaglio'. È possibile spostarla o rimuoverla se necessario.
        Me.AssembleaDettaglioTableAdapter.Fill(Me.IMMOBILIDataSet.AssembleaDettaglio)

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub AssembleaBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.AssembleaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet)

    End Sub
End Class