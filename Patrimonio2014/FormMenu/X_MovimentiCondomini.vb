Public Class X_MovimentiCondomini

    Private Sub X_MovimentiCondominiBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.X_MovimentiCondominiBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet)

    End Sub

    Private Sub X_MovimentiCondomini_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet.X_MovimentiCondomini'. È possibile spostarla o rimuoverla se necessario.
        Me.X_MovimentiCondominiTableAdapter.Fill(Me.IMMOBILIDataSet.X_MovimentiCondomini)

    End Sub
End Class