Public Class X_MovimentiCondomini

    Private Sub X_MovimentiCondominiBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles X_MovimentiCondominiBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.X_MovimentiCondominiBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet2)

    End Sub

    Private Sub X_MovimentiCondomini_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.X_MovimentiCondomini'. È possibile spostarla o rimuoverla se necessario.
        Me.X_MovimentiCondominiTableAdapter.Fill(Me.IMMOBILIDataSet2.X_MovimentiCondomini)

    End Sub
End Class