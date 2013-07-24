Public Class Anagrafiche

    Private Sub AnagraficheBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.AnagraficheBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet.Anagrafiche'. È possibile spostarla o rimuoverla se necessario.
        Me.AnagraficheTableAdapter.Fill(Me.IMMOBILIDataSet.Anagrafiche)

    End Sub
End Class