Public Class Immobili

    Private Sub ImmobiliBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ImmobiliBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet)

    End Sub

    Private Sub Immobili_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet.Immobili'. È possibile spostarla o rimuoverla se necessario.
        Me.ImmobiliTableAdapter.Fill(Me.IMMOBILIDataSet.Immobili)

    End Sub
End Class