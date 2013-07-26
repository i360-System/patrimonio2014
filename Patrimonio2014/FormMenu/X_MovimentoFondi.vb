Public Class X_MovimentoFondi

    Private Sub X_MovimentiFondiBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.X_MovimentiFondiBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet)

    End Sub

    Private Sub X_MovimentoFondi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet.X_MovimentiFondi'. È possibile spostarla o rimuoverla se necessario.
        Me.X_MovimentiFondiTableAdapter.Fill(Me.IMMOBILIDataSet.X_MovimentiFondi)

    End Sub
End Class