Imports System.Data.OleDb

Public Class X_Spese

    Private Sub X_SpeseBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles X_SpeseBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.X_SpeseBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IMMOBILIDataSet2)

    End Sub

    Private Sub X_Spese_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.X_SpeseDescrizioni'. È possibile spostarla o rimuoverla se necessario.
        Me.X_SpeseDescrizioniTableAdapter.Fill(Me.IMMOBILIDataSet2.X_SpeseDescrizioni)
        'TODO: questa riga di codice carica i dati nella tabella 'IMMOBILIDataSet2.X_Spese'. È possibile spostarla o rimuoverla se necessario.
        Me.X_SpeseTableAdapter.Fill(Me.IMMOBILIDataSet2.X_Spese)
        CreaCombo("Immobili", "SELECT Immobile, (Immobile + ' - ' + Denominazione) AS DescrizioneImmobile FROM Immobili", ImmobileComboBox, "DescrizioneImmobile", "Immobile")
        CreaCombo("Y_Gestioni", "SELECT Gestione, (CStr(Gestione) + ' - ' + Descrizione1) AS DescrizioneGestione FROM Y_Gestioni WHERE Immobile='" & ImmobileComboBox.Text & "'", GestioneComboBox, "DescrizioneGestione", "Gestione")
        CreaCombo("Fabbricati", "SELECT Fabbricato, (CStr(Fabbricato) + ' - ' + Descrizione) AS DescrizioneFabbricato FROM Fabbricati WHERE Immobile='" & ImmobileComboBox.Text & "'", FabbricatoComboBox, "DescrizioneFabbricato", "Fabbricato")
        CreaCombo("FabbricatiDettaglio", "SELECT Scala, (CStr(Scala) + ' - ' + Descrizione) AS DescrizioneScala FROM FabbricatiDettaglio WHERE Immobile='" & ImmobileComboBox.Text & "' AND Fabbricato=" & FabbricatoComboBox.Text, "DescrizioneScala", "Scala")
        CreaCombo("Unita", "SELECT Unita, (Unita + ' - ' + Nominativo1) AS DescrizioneUnita FROM Unita WHERE Immobile='" & ImmobileComboBox.Text & "'", UnitaComboBox, "DescrizioneUnita", "Unita")
        'gruppo
        'spesa
        CreaCombo("Fornitori", "SELECT Fornitore, (Fornitore + ' - ' + Denominazione) AS DescrizioneFornitore FROM Fornitori", FornitoreComboBox, "DescrizioneFornitore", "Fornitore")
        CreaCombo("W_Tributi", "SELECT Tributo, (CStr(Tributo) + ' - ' + Descrizione) AS DescrizioneTributo FROM W_Tributi", TrattamentoComboBox, "DescrizioneTributo", "Tributo")

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

    Private Sub CreaCombo(p1 As String, p2 As String, p3 As String, p4 As String)
        Throw New NotImplementedException
    End Sub

    Private Sub FabbricatoComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles FabbricatoComboBox.SelectedIndexChanged
        FabbricatoComboBox.Text = FabbricatoComboBox.SelectedValue

    End Sub

    Private Sub ScalaComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ScalaComboBox.SelectedIndexChanged
        ScalaComboBox.Text = ScalaComboBox.SelectedValue

    End Sub

    Private Sub UnitaComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles UnitaComboBox.SelectedIndexChanged
        UnitaComboBox.Text = UnitaComboBox.SelectedValue

    End Sub

    Private Sub FornitoreComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles FornitoreComboBox.SelectedIndexChanged
        FornitoreComboBox.Text = FornitoreComboBox.SelectedValue

    End Sub

    Private Sub TrattamentoComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles TrattamentoComboBox.SelectedIndexChanged
        TrattamentoComboBox.Text = TrattamentoComboBox.SelectedValue

    End Sub
End Class