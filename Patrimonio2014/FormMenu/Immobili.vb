Public Class Immobili

    Private Sub ImmobiliBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ImmobiliBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet)

    End Sub

    Private Sub Immobili_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet.Immobili'. È possibile spostarla o rimuoverla se necessario.
        Me.ImmobiliTableAdapter.Fill(Me.IMMOBILIDataSet.Immobili)
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet.Immobili'. È possibile spostarla o rimuoverla se necessario.
        'Me.ImmobiliTableAdapter.Fill(Me.IMMOBILIDataSet.Immobili)

    End Sub

    Private Sub ImmobiliBindingNavigatorSaveItem_Click_1(sender As System.Object, e As System.EventArgs) Handles ImmobiliBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ImmobiliBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet)

    End Sub

    Private Sub CodiceFiscaleLabel1_Click(sender As System.Object, e As System.EventArgs)

    End Sub
End Class