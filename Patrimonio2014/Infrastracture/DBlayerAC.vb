Module DBlayerAC

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
    Public Function ExQuery(ByVal strsql As String, ByVal param() As String, ByVal nomePar As String) As OleDb.OleDbDataReader

        Try

            Dim index As Integer
            initConnectionString()
            Dim oleDbCn As New OleDb.OleDbConnection(connectionString)
            Dim dr As OleDb.OleDbDataReader

            Using CMD As New OleDb.OleDbCommand(strsql, oleDbCn)
                With CMD
                    'Definizione / Assegnazione
                    For Each par As String In param(index)
                        .Parameters.Add(nomePar, OleDb.OleDbType.VarChar).Value = param.ToString
                        index = index + 1
                    Next
                    If oleDbCn.State Then oleDbCn.Open()
                    dr = .ExecuteReader()
                    oleDbCn.Close()
                    CMD.Dispose() : oleDbCn.Dispose()
                End With
            End Using
            Return dr

        Catch ex As Exception

            MsgBox(ex.ToString())

        End Try

    End Function
    'Function ExQuery()

    'End Function
    Public Sub openCon()

        Dim oleDbCn As New OleDb.OleDbConnection()

    End Sub

End Module




