Public Class AnagraficaStudio

    Private Sub AnagraficaStudioBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.AnagraficaStudioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet)

    End Sub

    Private Sub AnagraficaStudio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet.AnagraficaStudio'. È possibile spostarla o rimuoverla se necessario.
        Me.AnagraficaStudioTableAdapter.Fill(Me.IMMOBILIDataSet.AnagraficaStudio)

    End Sub

    Private Sub Denominazione1Label_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class