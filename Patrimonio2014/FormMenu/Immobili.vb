﻿Imports System.Data.OleDb

Public Class Immobili

    Private Sub ImmobiliBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles ImmobiliBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ImmobiliBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet2)

    End Sub

    Private Sub Immobili_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.Immobili'. È possibile spostarla o rimuoverla se necessario.
        Me.ImmobiliTableAdapter.Fill(Me.IMMOBILIDataSet2.Immobili)
        CreaCombo("AnagraficaStudio", "SELECT Studio, (Studio + ' - ' + Denominazione1) AS DescrizioneStudio FROM AnagraficaStudio", StudioComboBox, "DescrizioneStudio", "Studio")
        CreaCombo("Gruppi", "SELECT Studio, (Tabella + ' - ' + Denominazione) AS DescrizioneGruppo FROM Gruppi", StudioComboBox, "DescrizioneGruppo", "Tabella")
        CreaCombo("PianoContiPreventivo", "SELECT PianoConti, (CStr(PianoConti) + ' - ' + Denominazione) AS DescrizionePreventivo FROM PianoContiPreventivo", PdcPreventivoComboBox, "DescrizionePreventivo", "PianoConti")
        CreaCombo("PianoContiConsuntivo", "SELECT PianoConti, (CStr(PianoConti) + ' - ' + Denominazione) AS DescrizioneConsuntivo FROM PianoContiConsuntivo", PdcConsuntivoComboBox, "DescrizioneConsuntivo", "PianoConti")
        CreaCombo("ContiFinanziari", "SELECT Conto, (CStr(Conto + ' - ' + Banca) AS DescrizioneBanca FROM ContiFinanziari WHERE Conto='" & ContoBancaComboBox.Text & "'", ContoBancaComboBox, "DescrizioneBanca", "Conto")
        CreaCombo("ContiFinanziari", "SELECT Conto, (CStr(Conto + ' - ' + Banca) AS DescrizioneCassa FROM ContiFinanziari WHERE Conto='" & ContoCassaComboBox.Text & "'", ContoCassaComboBox, "DescrizioneCassa", "Conto")
        CreaCombo("ContiFinanziari", "SELECT Conto, (CStr(Conto + ' - ' + Banca) AS DescrizioneAnticipi FROM ContiFinanziari WHERE Conto='" & ContoAnticipiComboBox.Text & "'", ContoAnticipiComboBox, "Descrizioneanticipi", "Conto")

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

    Private Sub StudioComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles StudioComboBox.SelectedIndexChanged
        StudioComboBox.Text = StudioComboBox.SelectedValue

    End Sub

    Private Sub GruppoSpesaComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles GruppoSpesaComboBox.SelectedIndexChanged
        GruppoSpesaComboBox.Text = GruppoSpesaComboBox.SelectedValue

    End Sub

    Private Sub PdcPreventivoComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles PdcPreventivoComboBox.SelectedIndexChanged
        PdcPreventivoComboBox.Text = PdcPreventivoComboBox.SelectedValue

    End Sub

    Private Sub PdcConsuntivoComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles PdcConsuntivoComboBox.SelectedIndexChanged
        PdcConsuntivoComboBox.Text = PdcConsuntivoComboBox.SelectedValue

    End Sub

    Private Sub ContoBancaComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ContoBancaComboBox.SelectedIndexChanged
        ContoBancaComboBox.Text = ContoBancaComboBox.SelectedValue

    End Sub

    Private Sub ContoCassaComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ContoCassaComboBox.SelectedIndexChanged
        ContoCassaComboBox.Text = ContoCassaComboBox.SelectedValue

    End Sub

    Private Sub ContoAnticipiComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ContoAnticipiComboBox.SelectedIndexChanged
        ContoAnticipiComboBox.Text = ContoAnticipiComboBox.SelectedValue

    End Sub
End Class