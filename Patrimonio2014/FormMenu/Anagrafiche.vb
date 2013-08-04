Public Class Anagrafiche

    Private Sub AnagraficheBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.AnagraficheBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet.Z_TestoSollecito'. È possibile spostarla o rimuoverla se necessario.
        Me.Z_TestoSollecitoTableAdapter.Fill(Me.IMMOBILIDataSet.Z_TestoSollecito)
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet.Anagrafiche'. È possibile spostarla o rimuoverla se necessario.
        Me.AnagraficheTableAdapter.Fill(Me.IMMOBILIDataSet.Anagrafiche)
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet.Anagrafiche'. È possibile spostarla o rimuoverla se necessario.
        Me.AnagraficheTableAdapter.Fill(Me.IMMOBILIDataSet.Anagrafiche)

    End Sub

    Private Sub AnagraficheBindingNavigatorSaveItem_Click_1(sender As System.Object, e As System.EventArgs) Handles AnagraficheBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AnagraficheBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet)

    End Sub

    Private Sub AnagraficaCollegata_Layout(sender As Object, e As System.Windows.Forms.LayoutEventArgs)

    End Sub
End Class