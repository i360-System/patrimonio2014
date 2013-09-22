﻿Imports System.Data.OleDb

Public Class Unita

    Private Sub UnitaBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles UnitaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UnitaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet2)

    End Sub

    Private Sub Unita_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.UnitaDettaglioMillesimi'. È possibile spostarla o rimuoverla se necessario.
        Me.UnitaDettaglioMillesimiTableAdapter.Fill(Me.IMMOBILIDataSet2.UnitaDettaglioMillesimi)
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.UnitaDettaglioAnagrafica'. È possibile spostarla o rimuoverla se necessario.
        Me.UnitaDettaglioAnagraficaTableAdapter.Fill(Me.IMMOBILIDataSet2.UnitaDettaglioAnagrafica)
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.UnitaDettaglioLetture'. È possibile spostarla o rimuoverla se necessario.
        Me.UnitaDettaglioLettureTableAdapter.Fill(Me.IMMOBILIDataSet2.UnitaDettaglioLetture)
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.UnitaDettaglio'. È possibile spostarla o rimuoverla se necessario.
        Me.UnitaDettaglioTableAdapter.Fill(Me.IMMOBILIDataSet2.UnitaDettaglio)
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.Unita'. È possibile spostarla o rimuoverla se necessario.
        Me.UnitaTableAdapter.Fill(Me.IMMOBILIDataSet2.Unita)
        CreaCombo("Immobili", "SELECT Immobile, (Immobile + ' - ' + Denominazione) AS DescrizioneImmobile FROM Immobili", ImmobileComboBox)

    End Sub
    Private Sub CreaCombo(ByVal NomeTab As String, ByVal query As String, ByRef combo As ComboBox)
        Dim cn As New OleDbConnection(My.Settings.IMMOBILIConnectionString.ToString)
        cn.Open()

        Dim command As New OleDbCommand(query, cn)
        Dim da As New OleDbDataAdapter
        da.SelectCommand = command

        Dim ds As New DataSet(NomeTab)
        ds.Clear()
        da.Fill(ds, NomeTab)

        combo.DisplayMember = "DescrizioneImmobile"
        combo.ValueMember = "Immobile"
        combo.DataSource = ds.Tables(NomeTab)
        cn.Close()
    End Sub

    Private Sub ImmobileComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ImmobileComboBox.SelectedIndexChanged
        ImmobileComboBox.Text = ImmobileComboBox.SelectedValue

    End Sub
End Class