Public Class X_Fatture

    Private Sub X_FattureBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.X_FattureBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet)

    End Sub

    Private Sub X_Fatture_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet.X_FattureDettaglio'. È possibile spostarla o rimuoverla se necessario.
        Me.X_FattureDettaglioTableAdapter.Fill(Me.IMMOBILIDataSet.X_FattureDettaglio)
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet.X_Fatture'. È possibile spostarla o rimuoverla se necessario.
        Me.X_FattureTableAdapter.Fill(Me.IMMOBILIDataSet.X_Fatture)

    End Sub
End Class