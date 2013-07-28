Module DBlayerAC
    Dim dr As OleDb.OleDbDataReader

    ''' <summary>
    ''' Metodo per leggere la string connection memorizzata su db
    ''' Viene gestita chiamando ogni volta l'inizializzazione della stringa 
    ''' in funzione del percorso del db, questo perchè se si cambia il path del db
    ''' viene automaticamente aggiornata la nuova stringa di connessione
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub initConnectionString()
        connectionString = My.Settings.StringaConnessione
    End Sub

    Public Property connectionString As String
        Get
            Return _connectString
        End Get
        Set(ByVal value As String)
            _connectString = value ' My.Settings.StringaConnessione
        End Set
    End Property
    Private _connectString As String

    ''' <summary>
    ''' Esecuzione della query, restituisce un OLEDBdatareader
    ''' </summary>
    ''' <param name="strsql"></param>
    ''' <param name="param"></param>
    ''' <param name="nomePar"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ExQuery(ByVal strsql As String, ByVal param() As String, ByRef frm As Form) As OleDb.OleDbDataReader

        Try

            Dim index As Integer
            initConnectionString()
            Dim oleDbCn As New OleDb.OleDbConnection(My.Settings.IMMOBILIConnectionString1)


            Using CMD As New OleDb.OleDbCommand(strsql, oleDbCn)
                With CMD
                    'Definizione / Assegnazione
                    For Each par As String In param
                        ' .Parameters.Add(nomePar(index), OleDb.OleDbType.VarChar).Value = param(index).ToString
                        .Parameters.Add(param(index).ToString)
                        index = index + 1
                    Next
                    If oleDbCn.State = 0 Then oleDbCn.Open()
                    dr = .ExecuteReader()

                End With

            End Using
            If Not IsNothing(dr) Then
                Interactive.populate(frm, dr)
            Else
                MsgBox(Message.Messaggi.ValoreNonPresenteRicerca)
            End If

            oleDbCn.Close()
        Catch ex As Exception

            MsgBox(ex.ToString())

            Return Nothing

        End Try



    End Function


End Module




