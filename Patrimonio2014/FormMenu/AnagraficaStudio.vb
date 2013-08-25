Public Class AnagraficaStudio

    Private Sub AnagraficaStudioBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.AnagraficaStudioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet2)

    End Sub


    Private Sub AnagraficaStudioBindingNavigatorSaveItem_Click_1(sender As System.Object, e As System.EventArgs) Handles AnagraficaStudioBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AnagraficaStudioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet2)

    End Sub

    Private Sub AnagraficaStudio_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.AnagraficaStudio'. È possibile spostarla o rimuoverla se necessario.
        Me.AnagraficaStudioTableAdapter.Fill(Me.IMMOBILIDataSet2.AnagraficaStudio)

    End Sub
End Class