Public Class Z_TestoSollecito

    Private Sub Z_TestoSollecitoBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles Z_TestoSollecitoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Z_TestoSollecitoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet2)

    End Sub

    Private Sub Z_TestoSollecito_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.Z_TestoSollecito'. È possibile spostarla o rimuoverla se necessario.
        Me.Z_TestoSollecitoTableAdapter.Fill(Me.IMMOBILIDataSet2.Z_TestoSollecito)

    End Sub
End Class