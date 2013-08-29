Public Class Y_Gestioni

    Private Sub Y_GestioniBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles Y_GestioniBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Y_GestioniBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet2)

    End Sub

    Private Sub Y_Gestioni_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.Y_GestioniDettaglio'. È possibile spostarla o rimuoverla se necessario.
        Me.Y_GestioniDettaglioTableAdapter.Fill(Me.IMMOBILIDataSet2.Y_GestioniDettaglio)
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.Y_Gestioni'. È possibile spostarla o rimuoverla se necessario.
        Me.Y_GestioniTableAdapter.Fill(Me.IMMOBILIDataSet2.Y_Gestioni)

    End Sub
End Class