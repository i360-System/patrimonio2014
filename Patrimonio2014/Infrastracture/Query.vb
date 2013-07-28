Public Class Query

    Private Structure sintassiSQL
        Shared sel As String = "Select "
        Shared fro As String = "From "
        Shared wher As String = " Where "
        Shared an As String = " And "
        Shared asterisco = " * "
        Shared ug As String = " = "
        Shared at As String = "@"
        Shared ij As String = " INNER JOIN "
        Shared parameters As String = " ? "
    End Structure

    ''' <summary>
    ''' Metodo dinamico di cotruzione della query di select
    ''' </summary>
    ''' <param name="param"></param>
    ''' <param name="tab"></param>
    ''' <remarks></remarks>
    Public Function QuerySelect(ByVal param() As String, ByVal tab() As String, ByVal colum() As String, ByRef frm As Form) As OleDb.OleDbDataReader

        Dim strSql As String = ""
        Dim nomePar As New List(Of String)
        Dim indParam As Integer

        strSql = sintassiSQL.sel & sintassiSQL.asterisco & sintassiSQL.fro & tab(indParam).ToString
        If tab.Count > 1 Then 'innerjoin
        End If

        Try
            If IsNothing(param) Then

                'eseguo query
                MsgBox("")

            Else

                strSql = strSql & sintassiSQL.wher

                For Each c In colum

                    If indParam > 0 Then strSql = strSql & sintassiSQL.an
                    strSql = strSql & c.ToString & sintassiSQL.ug
                    'nomePar.Add(sintassiSQL.parameters & c.ToString)
                    strSql = strSql & sintassiSQL.parameters
                    indParam = indParam + 1

                Next

                Return DBlayerAC.ExQuery(strSql, param, frm)

            End If

        Catch ex As Exception

            MsgBox(ex.ToString)

        End Try

    End Function
End Class
