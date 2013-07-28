Public Class Fornitori

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        'controllo istanza
        Dim ric As New ToolBarComune
        Dim dr = ric.Ricerca(Me)
    End Sub




    Private Sub FornitoriBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FornitoriBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.FornitoriBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet1)

    End Sub

    Private Sub Fornitori_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet1.Fornitori'. È possibile spostarla o rimuoverla se necessario.
        Me.FornitoriTableAdapter1.Fill(Me.IMMOBILIDataSet1.Fornitori)
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet.Fornitori'. È possibile spostarla o rimuoverla se necessario.


    End Sub
End Class