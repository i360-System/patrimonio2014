Public Class X_Causali

    Private Sub X_CausaliBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles X_CausaliBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.X_CausaliBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet2)

    End Sub

    Private Sub X_Causali_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.X_Causali'. È possibile spostarla o rimuoverla se necessario.
        Me.X_CausaliTableAdapter.Fill(Me.IMMOBILIDataSet2.X_Causali)

    End Sub
End Class