Public Class X_Fatture

    Private Sub X_FattureBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles X_FattureBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.X_FattureBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet2)

    End Sub

    Private Sub X_Fatture_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.X_FattureDettaglio'. È possibile spostarla o rimuoverla se necessario.
        Me.X_FattureDettaglioTableAdapter.Fill(Me.IMMOBILIDataSet2.X_FattureDettaglio)
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.X_Fatture'. È possibile spostarla o rimuoverla se necessario.
        Me.X_FattureTableAdapter.Fill(Me.IMMOBILIDataSet2.X_Fatture)

    End Sub
End Class