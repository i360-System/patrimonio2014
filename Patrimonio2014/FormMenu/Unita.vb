Imports System.Data.OleDb

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
        CreaCombo("Immobili", "SELECT Immobile, (Immobile + ' - ' + Denominazione) AS DescrizioneImmobile FROM Immobili", ImmobileComboBox, "DescrizioneImmobile", "Immobile")
        CreaCombo("Fabbricati", "SELECT Fabbricato, (CStr(Fabbricato) + ' - ' + Descrizione) AS DescrizioneFabbricato FROM Fabbricati WHERE Immobile='" & ImmobileComboBox.Text & "'", FabbricatoComboBox, "DescrizioneFabbricato", "Fabbricato")
        CreaCombo("FabbricatiDettaglio", "SELECT Scala, (CStr(Scala) + ' - ' + Descrizione) AS DescrizioneScala FROM FabbricatiDettaglio WHERE Immobile='" & ImmobileComboBox.Text & "' AND Fabbricato=" & FabbricatoComboBox.Text, "DescrizioneScala", "Scala")
        CreaCombo("Anagrafiche", "SELECT Anagrafica, (Anagrafica + ' - ' + Nominativo1) AS DescrizioneProprietario FROM Anagrafiche WHERE Immobile='" & ImmobileComboBox.Text & "'", ProprietarioComboBox, "DescrizioneProprietario", "Anagrafica")
        CreaCombo("Anagrafiche", "SELECT Anagrafica, (Anagrafica + ' - ' + Nominativo1) AS DescrizioneInquilino FROM Anagrafiche WHERE Immobile='" & ImmobileComboBox.Text & "'", InquilinoComboBox, "DescrizioneInquilino", "Anagrafica")

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

    Private Sub FabbricatoComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles FabbricatoComboBox.SelectedIndexChanged
        FabbricatoComboBox.Text = FabbricatoComboBox.SelectedValue

    End Sub

    Private Sub ScalaComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ScalaComboBox.SelectedIndexChanged
        ScalaComboBox.Text = ScalaComboBox.SelectedValue

    End Sub

    Private Sub ProprietarioComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ProprietarioComboBox.SelectedIndexChanged
        ProprietarioComboBox.Text = ProprietarioComboBox.SelectedValue

    End Sub

    Private Sub InquilinoComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles InquilinoComboBox.SelectedIndexChanged
        InquilinoComboBox.Text = InquilinoComboBox.SelectedValue

    End Sub

    Private Sub CreaCombo(p1 As String, p2 As String, p3 As String, p4 As String)
        Throw New NotImplementedException
    End Sub

End Class