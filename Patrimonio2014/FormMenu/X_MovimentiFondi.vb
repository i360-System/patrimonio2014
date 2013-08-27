Public Class X_MovimentiFondi

    Private Sub X_MovimentiFondiBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles X_MovimentiFondiBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.X_MovimentiFondiBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet2)

    End Sub

    Private Sub X_MovimentiFondi_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.X_MovimentiFondi'. È possibile spostarla o rimuoverla se necessario.
        Me.X_MovimentiFondiTableAdapter.Fill(Me.IMMOBILIDataSet2.X_MovimentiFondi)

    End Sub
End Class