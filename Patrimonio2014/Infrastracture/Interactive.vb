Module Interactive

    Public Sub populate(ByRef frm As Form, ByVal rd As OleDb.OleDbDataReader)

        For Each Control As TextBox In frm.Controls

            While rd.Read
                Control.Text = rd.Item(Control.Name.ToString)
            End While

        Next

    End Sub

End Module



