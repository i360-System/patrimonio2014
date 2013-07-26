Public Class Z_TestoSollecito

    Private Sub Z_TestoSollecitoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Z_TestoSollecitoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet)

    End Sub

    Private Sub Z_TestoSollecito_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet.Z_TestoSollecito'. È possibile spostarla o rimuoverla se necessario.
        Me.Z_TestoSollecitoTableAdapter.Fill(Me.IMMOBILIDataSet.Z_TestoSollecito)

    End Sub
End Class