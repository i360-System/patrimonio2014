Public Class W_Ritenute

    Private Sub W_RitenuteBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles W_RitenuteBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.W_RitenuteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet2)

    End Sub

    Private Sub W_Ritenute_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.W_Ritenute'. È possibile spostarla o rimuoverla se necessario.
        Me.W_RitenuteTableAdapter.Fill(Me.IMMOBILIDataSet2.W_Ritenute)

    End Sub
End Class