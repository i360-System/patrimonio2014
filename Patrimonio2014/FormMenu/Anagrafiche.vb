Public Class Anagrafiche

    Private Sub AnagraficheBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles AnagraficheBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AnagraficheBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet2)

    End Sub

    Private Sub Anagrafiche_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.Anagrafiche'. È possibile spostarla o rimuoverla se necessario.
        Me.AnagraficheTableAdapter.Fill(Me.IMMOBILIDataSet2.Anagrafiche)
        'popolazione del combo immobili

    End Sub

    Private Sub DataNascitaLabel_Click(sender As System.Object, e As System.EventArgs)

    End Sub
End Class