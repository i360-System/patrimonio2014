Public Class X_Causali

    Private Sub X_CausaliBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.X_CausaliBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet.X_Causali'. È possibile spostarla o rimuoverla se necessario.
        Me.X_CausaliTableAdapter.Fill(Me.IMMOBILIDataSet.X_Causali)

    End Sub
End Class