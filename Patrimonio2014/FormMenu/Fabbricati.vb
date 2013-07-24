Public Class Fabbricati

    Private Sub FabbricatiBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.FabbricatiBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet)

    End Sub

    Private Sub Fabbricati_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet.Scale'. È possibile spostarla o rimuoverla se necessario.
        Me.ScaleTableAdapter.Fill(Me.IMMOBILIDataSet.Scale)
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet.Fabbricati'. È possibile spostarla o rimuoverla se necessario.
        Me.FabbricatiTableAdapter.Fill(Me.IMMOBILIDataSet.Fabbricati)

    End Sub
End Class