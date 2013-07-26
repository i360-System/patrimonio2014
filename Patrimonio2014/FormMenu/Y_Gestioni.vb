Public Class Y_Gestioni

    Private Sub Y_GestioniBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Y_GestioniBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet)

    End Sub

    Private Sub Y_Gestioni_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet.Y_GestioniDettaglio'. È possibile spostarla o rimuoverla se necessario.
        Me.Y_GestioniDettaglioTableAdapter.Fill(Me.IMMOBILIDataSet.Y_GestioniDettaglio)
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet.Y_Gestioni'. È possibile spostarla o rimuoverla se necessario.
        Me.Y_GestioniTableAdapter.Fill(Me.IMMOBILIDataSet.Y_Gestioni)

    End Sub
End Class