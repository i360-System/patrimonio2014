﻿Imports System.Data.OleDb

Public Class W_Emissioni

    Private Sub W_EmissioniBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles W_EmissioniBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.W_EmissioniBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet2)

    End Sub

    Private Sub W_Emissioni_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.W_EmissioniDettaglio'. È possibile spostarla o rimuoverla se necessario.
        Me.W_EmissioniDettaglioTableAdapter.Fill(Me.IMMOBILIDataSet2.W_EmissioniDettaglio)
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.W_Emissioni'. È possibile spostarla o rimuoverla se necessario.
        Me.W_EmissioniTableAdapter.Fill(Me.IMMOBILIDataSet2.W_Emissioni)
        CreaCombo("Immobili", "SELECT Immobile, (Immobile + ' - ' + Denominazione) AS DescrizioneImmobile FROM Immobili", ImmobileComboBox, "DescrizioneImmobile", "Immobile")
        CreaCombo("Anagrafiche", "SELECT Anagrafica, (Anagrafica + ' - ' + Nominativo1) AS DescrizioneProprietario FROM Anagrafiche WHERE Immobile='" & ImmobileComboBox.Text & "'", AnagraficaComboBox, "DescrizioneProprietario", "Anagrafica")
        CreaCombo("Y_Gestioni", "SELECT Gestione, (CStr(Gestione) + ' - ' + Descrizione1) AS DescrizioneGestione FROM Y_Gestioni WHERE Immobile='" & ImmobileComboBox.Text & "'", GestioneComboBox, "DescrizioneGestione", "Gestione")
        CreaCombo("ContiFinanziari", "SELECT Conto, (Conto + ' - ' + Banca) AS DescrizioneBanca FROM ContiFinanziari WHERE Conto='" & ContoComboBox.Text & "'", ContoComboBox, "DescrizioneBanca", "Conto")

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

    Private Sub GestioneComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles GestioneComboBox.SelectedIndexChanged
        GestioneComboBox.Text = GestioneComboBox.SelectedValue

    End Sub

    Private Sub AnagraficaComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles AnagraficaComboBox.SelectedIndexChanged
        AnagraficaComboBox.Text = AnagraficaComboBox.SelectedValue

    End Sub

    Private Sub ContoComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ContoComboBox.SelectedIndexChanged
        ContoComboBox.Text = ContoComboBox.SelectedValue

    End Sub
End Class