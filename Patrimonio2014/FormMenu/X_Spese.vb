Public Class X_Spese

    Private Sub X_SpeseBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles X_SpeseBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.X_SpeseBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet2)

    End Sub

    Private Sub X_Spese_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.X_SpeseDescrizioni'. È possibile spostarla o rimuoverla se necessario.
        Me.X_SpeseDescrizioniTableAdapter.Fill(Me.IMMOBILIDataSet2.X_SpeseDescrizioni)
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.X_Spese'. È possibile spostarla o rimuoverla se necessario.
        Me.X_SpeseTableAdapter.Fill(Me.IMMOBILIDataSet2.X_Spese)

    End Sub
End Class