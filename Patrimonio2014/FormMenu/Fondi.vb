﻿Public Class Fondi

    Private Sub FondiBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.FondiBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet)

    End Sub

    Private Sub Fondi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet.Fondi'. È possibile spostarla o rimuoverla se necessario.
        Me.FondiTableAdapter.Fill(Me.IMMOBILIDataSet.Fondi)

    End Sub
End Class