Public Class W_Ritenute

    Private Sub W_RitenuteBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.W_RitenuteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet)

    End Sub

    Private Sub W_Ritenute_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet.W_Ritenute'. È possibile spostarla o rimuoverla se necessario.
        Me.W_RitenuteTableAdapter.Fill(Me.IMMOBILIDataSet.W_Ritenute)
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet.W_Ritenute'. È possibile spostarla o rimuoverla se necessario.
        Me.W_RitenuteTableAdapter.Fill(Me.IMMOBILIDataSet.W_Ritenute)

    End Sub

    Private Sub W_RitenuteBindingNavigatorSaveItem_Click_1(sender As System.Object, e As System.EventArgs) Handles W_RitenuteBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.W_RitenuteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet)

    End Sub
End Class