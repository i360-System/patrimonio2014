Public Class Y_GestioniUnita

    Private Sub Y_GestioniUnitaBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles Y_GestioniUnitaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Y_GestioniUnitaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet2)

    End Sub

    Private Sub Y_GestioniUnita_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.Y_GestioniUnitaDettaglio'. È possibile spostarla o rimuoverla se necessario.
        Me.Y_GestioniUnitaDettaglioTableAdapter.Fill(Me.IMMOBILIDataSet2.Y_GestioniUnitaDettaglio)
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.Y_GestioniUnita'. È possibile spostarla o rimuoverla se necessario.
        Me.Y_GestioniUnitaTableAdapter.Fill(Me.IMMOBILIDataSet2.Y_GestioniUnita)

    End Sub
End Class