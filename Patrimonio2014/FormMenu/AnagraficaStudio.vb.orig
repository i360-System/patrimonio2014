Imports Patrimonio2014.IMMOBILIDataSet1

Public Class AnagraficaStudio

    'Private Sub AnagraficaStudioBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Me.Validate()
    '    Me.AnagraficaStudioBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet)

    'End Sub

    Private Sub AnagraficaStudio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet1.AnagraficaStudio'. È possibile spostarla o rimuoverla se necessario.

        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet.AnagraficaStudio'. È possibile spostarla o rimuoverla se necessario.
        If False Then

            'msgb
            'edy
            Me.AnagraficaStudioTableAdapter1.Fill(Me.IMMOBILIDataSet1.AnagraficaStudio)

            'claudio
            'Me.AnagraficaStudioTableAdapter.Fill(Me.IMMOBILIDataSet.AnagraficaStudio)

            'Me.AnagraficaStudioTableAdapter.Fill(Me.IMMOBILIDataSet.AnagraficaStudio)
            'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet.AnagraficaStudio'. È possibile spostarla o rimuoverla se necessario.
        'Me.AnagraficaStudioTableAdapter.Fill(Me.IMMOBILIDataSet.AnagraficaStudio)

            'edy
            Me.AnagraficaStudioTableAdapter1.Fill(Me.IMMOBILIDataSet1.AnagraficaStudio)
            'claudio
            'Me.AnagraficaStudioTableAdapter.Fill(Me.IMMOBILIDataSet.AnagraficaStudio)

        End If
    End Sub

    Private Sub Denominazione1Label_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Denominazione1TextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub AnagraficaStudioBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnagraficaStudioBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.AnagraficaStudioBindingSource.EndEdit()

            Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try



    End Sub

    Private Sub BindingNavigatorMoveNextItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorMoveNextItem.Click

    End Sub

    Private Sub AnagraficaStudio_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Validated

    End Sub

    Private Sub AnagraficaStudio_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Validating

    End Sub

    Private Sub AnagraficaStudioBindingNavigator_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles AnagraficaStudioBindingNavigator.Validated

    End Sub

    ''' <summary>
    ''' Ricerca
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        'ricerca
        'Dim p = Query.sel(Me)
        'If Not IsNothing(p) Then
        '    Dim dtbl As New DataTable
        '    For Each ahah As DataRow In p
        '        dtbl.ImportRow(ahah)
        '    Next
        Dim an As IMMOBILIDataSet1.AnagraficaStudioRow()
        Dim ad As New IMMOBILIDataSet1.AnagraficaStudioDataTable
        an = (Me.IMMOBILIDataSet1.AnagraficaStudio.Select(Query.wherecond(Me)))
        For Each c In an
            ad.ImportRow(c)
        Next
        Me.AnagraficaStudioTableAdapter1.Fill(ad)
        'End If
    End Sub
End Class