Imports System
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Globalization
Imports Patrimonio2014.IMMOBILIDataSet1
Module Query

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
        Shared lik As String = " LIKE "
        Shared ap As String = "'"
        Shared per As String = " % "

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
                    nomePar.Add(sintassiSQL.at & c.ToString)
                    strSql = strSql & sintassiSQL.parameters
                    indParam = indParam + 1

                Next

                Return DBlayerAC.ExQuery(strSql, param, nomePar, frm)

            End If

        Catch ex As Exception

            MsgBox(ex.ToString)

        End Try

    End Function

    Public Function sel(ByRef frm As Object)
        Dim dt As New DataTable
        Dim flg As Boolean = True
        Dim col As New List(Of String)
        Dim val As New List(Of Object)

        For Each controllo As Object In frm.Controls 'inizia un
            'For Each con In controllo.controls


            If TypeOf controllo Is TextBox Then 'se il controllo è un

                'aggiungo il nome nel file
                If Not controllo.text = "" And Not (controllo.name = "") Then
                    val.Add(controllo.text.ToString)
                    col.Add(controllo.name)
                    flg = flg And False
                Else
                    flg = flg And True

                End If

            End If
        Next
        'Next
        If flg Then
            MsgBox(Message.Messaggi.InserireValore)
            Return Nothing
        End If


        If col.Count > 1 Then

            For Each c In frm.controls
                'Where anst.Field(
            Next

        Else

            'dt = frm.IMMOBILIDataSet1.AnagraficaStudio
            Dim selec = From anst In dt.AsEnumerable _
                        Where (anst.Field(Of String)(col(1).ToString) Like val(1)) _
                        Select anst
            Return selec
        End If




    End Function
   

    Public Function wherecond(ByVal frm As Object) As String
        Dim Str As String = Nothing
        Dim flg As Boolean = True
        For Each controllo As Object In frm.Controls 'inizia un
            'For Each con In controllo.controls


            If TypeOf controllo Is TextBox Then 'se il controllo è un

                'aggiungo il nome nel file
                If Not controllo.text = "" And Not (controllo.name = "") Then
                    If Not flg Then Str = Str & sintassiSQL.an
                    Str = Str & (controllo.name.ToString)
                    Str = Str & sintassiSQL.lik & sintassiSQL.ap & sintassiSQL.per
                    Str = Str & (controllo.text.ToString) & sintassiSQL.per & sintassiSQL.ap
                    flg = flg And False
                Else
                    flg = flg And True

                End If

            End If
        Next
        Return Str
    End Function
End Module
