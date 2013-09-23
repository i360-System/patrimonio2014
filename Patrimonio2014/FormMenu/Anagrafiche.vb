﻿Imports System.Data.OleDb

Public Class Anagrafiche

    ' Dim full_name As String

    ' Private Property rderDepto As Object

    ' Private Property cmdDepto As Object

    Private Sub AnagraficheBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles AnagraficheBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AnagraficheBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet2)

    End Sub

    Private Sub Anagrafiche_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.Immobili'. È possibile spostarla o rimuoverla se necessario.
        Me.ImmobiliTableAdapter.Fill(Me.IMMOBILIDataSet2.Immobili)
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.Anagrafiche'. È possibile spostarla o rimuoverla se necessario.
        Me.AnagraficheTableAdapter.Fill(Me.IMMOBILIDataSet2.Anagrafiche)
        'popolazione del combo immobili
        CreaCombo("Immobili", "SELECT Immobile, (Immobile + ' - ' + Denominazione) AS DescrizioneImmobile FROM Immobili", ImmobileComboBox, "DescrizioneImmobile", "Immobile")
    End Sub

    Private Sub DataNascitaLabel_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub CreaCombo(ByVal NomeTab As String, ByVal query As String, ByRef combo As ComboBox, DisplayMember As String, ValueMember As String)
        Dim cn As New OleDbConnection(My.Settings.IMMOBILIConnectionString.ToString)
        cn.Open()

        Dim command As New OleDbCommand(query, cn)
        Dim da As New OleDbDataAdapter
        da.SelectCommand = command
        Try
            Dim ds As New DataSet(NomeTab)
            ds.Clear()
            ds.Tables.Add(NomeTab)
            da.Fill(ds, NomeTab)

            combo.DisplayMember = DisplayMember
            combo.ValueMember = ValueMember
            combo.DataSource = ds.Tables(NomeTab)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        cn.Close()
    End Sub

    Private Sub ImmobileComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ImmobileComboBox.SelectedIndexChanged
        ImmobileComboBox.Text = ImmobileComboBox.SelectedValue
    End Sub
End Class