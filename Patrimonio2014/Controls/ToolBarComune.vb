Public Class ToolBarComune
    Inherits Query

    ''' <summary>
    ''' Metodo di ricerca query
    ''' </summary>
    ''' <param name="frm">parametri e tabella</param>
    ''' <remarks></remarks>
    Public Function Ricerca(ByRef frm As Form) As OleDb.OleDbDataReader

        Dim indexparam As Integer
        Dim indextab As Integer
        Dim indexcol As Integer
        Dim param(), Tab(), colum() As String
        ReDim Preserve param(0)
        ReDim Preserve Tab(0)
        ReDim Preserve colum(0)
        'metodo set pulsanti barra

        For Each controllo As Object In frm.Controls 'inizia un
            For Each con In controllo.controls


                If TypeOf con Is TextBox Then 'se il controllo è un

                    'aggiungo il nome nel file
                    If Not con.text = "" Then


                        ReDim Preserve param(indexparam) : param(indexparam) = con.ToString
                        ReDim Preserve colum(indexcol) : colum(indexcol) = con.Name.ToString

                        indexparam = indexparam + 1
                        indexcol = indexcol + 1

                    End If

                End If
            Next
        Next

        ReDim Preserve Tab(indextab) : Tab(indextab) = frm.Name.ToString


        If indexparam > 0 Then

            Return QuerySelect(param, Tab, colum, frm) 'if >0 call query
        Else
            MsgBox(Messaggi.InserireValore)
            Return Nothing
        End If



    End Function

    ''' <summary>
    ''' Metodo di eliminazione di un record su database
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub elimina(ByRef frm As Form)

        Dim index As Integer
        Dim param(), Tab() As String

        'se pulsanti barra

        'Build query
        For Each tb As TextBox In frm.Controls.OfType(Of TextBox)()
            If Not IsNothing(tb) Then
                param(index) = tb.Name.ToString
                TAB(index) = frm.Name.ToString
                index = index + 1
            End If
        Next

    End Sub

    ''' <summary>
    ''' Metodo di update su database
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub aggiorna(ByRef frm As Form)

        Dim index As Integer
        Dim param(), Tab() As String

        'set pulsanti barra

        'build query
        For Each tb As TextBox In frm.Controls.OfType(Of TextBox)()
            If Not IsNothing(tb) Then
                param(index) = tb.Name.ToString
                TAB(index) = frm.Name.ToString
                index = index + 1
            End If
        Next

    End Sub

    

End Class
