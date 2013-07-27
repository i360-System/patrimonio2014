Public Class X_Spese

    Private Sub X_SpeseBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.X_SpeseBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet)

    End Sub

    Private Sub X_Spese_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet.X_SpeseDescrizioni'. È possibile spostarla o rimuoverla se necessario.
        Me.X_SpeseDescrizioniTableAdapter.Fill(Me.IMMOBILIDataSet.X_SpeseDescrizioni)
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet.X_Spese'. È possibile spostarla o rimuoverla se necessario.
        Me.X_SpeseTableAdapter.Fill(Me.IMMOBILIDataSet.X_Spese)

    End Sub
End Class