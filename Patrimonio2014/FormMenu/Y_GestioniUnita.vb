Public Class Y_GestioniUnita

    Private Sub Y_GestioniUnitaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Y_GestioniUnitaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet)

    End Sub

    Private Sub Y_GestioniUnita_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet.Y_GestioniUnitaDettaglio'. È possibile spostarla o rimuoverla se necessario.
        Me.Y_GestioniUnitaDettaglioTableAdapter.Fill(Me.IMMOBILIDataSet.Y_GestioniUnitaDettaglio)
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet.Y_GestioniUnita'. È possibile spostarla o rimuoverla se necessario.
        Me.Y_GestioniUnitaTableAdapter.Fill(Me.IMMOBILIDataSet.Y_GestioniUnita)

    End Sub
End Class