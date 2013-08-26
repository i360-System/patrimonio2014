Public Class Immobili

    Private Sub ImmobiliBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles ImmobiliBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ImmobiliBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet2)

    End Sub

    Private Sub Immobili_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.Immobili'. È possibile spostarla o rimuoverla se necessario.
        Me.ImmobiliTableAdapter.Fill(Me.IMMOBILIDataSet2.Immobili)

    End Sub
End Class