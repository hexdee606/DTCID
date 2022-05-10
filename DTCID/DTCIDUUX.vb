Public Class DTCIDUUX
    Private TempLst As Integer
    Private Sub dtcidAutoCompleteCustomSource()
        Try
            Dim ctr, i As Integer
            ds.Clear()
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            dbDTCID.conn()
            cn.Open()
            str = "select * from DTCID"
            cmd = New OleDbCommand(str, cn)
            da.SelectCommand = cmd
            da.Fill(ds, "DTCID")
            ctr = ds.Tables("DTCID").Rows.Count - 1
            For i = 0 To ctr
                TB1.AutoCompleteCustomSource.Add(ds.Tables("DTCID").Rows(i)(1).ToString)
                TB2.AutoCompleteCustomSource.Add(ds.Tables("DTCID").Rows(i)(2).ToString)
                TB3.AutoCompleteCustomSource.Add(ds.Tables("DTCID").Rows(i)(3).ToString)
                TB4.AutoCompleteCustomSource.Add(ds.Tables("DTCID").Rows(i)(4).ToString)
            Next
            cn.Close()
        Catch ex As Exception
            ErrorMsg(ex)
        End Try
    End Sub

    Private Sub DTCIDFUX_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Enabled = False
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            dbDTCID.conn()
            cn.Open()

            str = "select * from DTCID"
            cmd = New OleDbCommand(str, cn)
            da.SelectCommand = cmd
            da.Fill(ds, "DTCID")
            Dim LastNo As Integer = 0
            LastNo = ds.Tables("DTCID").Rows.Count + 1
            TempLst = LastNo

            cn.Close()

            ClearTextBox(Me)

            dtcidAutoCompleteCustomSource()
            Me.Enabled = True
        Catch ex As Exception
            ErrorMsg(ex)
        End Try
    End Sub


    Private Sub B1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B1.Click
        Try
            Dim ctr, i As Integer
            ds.Clear()
            str = "select * from DTCID where FIRSTNAME = '" & TB1.Text & "' and LASTNAME = '" & TB2.Text & "' and MOBILENUMBER1 = '" & TB3.Text & "' or MOBILENUMBER2 = '" & TB4.Text & "'"
            cmd = New OleDbCommand(str, cn)
            da.SelectCommand = cmd
            da.Fill(ds, "DTCID")
            ctr = ds.Tables("DTCID").Rows.Count - 1

            For i = 0 To ctr
                If TB1.Text = ds.Tables("DTCID").Rows(i)(1).ToString And TB2.Text = ds.Tables("DTCID").Rows(i)(2).ToString Or TB3.Text = ds.Tables("DTCID").Rows(i)(3).ToString Then
                    L1.Text = "DTCID-REG-NO-" & ds.Tables("DTCID").Rows(i)(0).ToString
                    TB1.Text = ds.Tables("DTCID").Rows(i)(1).ToString
                    TB2.Text = ds.Tables("DTCID").Rows(i)(2).ToString
                    TB3.Text = ds.Tables("DTCID").Rows(i)(3).ToString
                    TB4.Text = ds.Tables("DTCID").Rows(i)(4).ToString
                    TB5.Text = ds.Tables("DTCID").Rows(i)(5).ToString
                    TB6.Text = ds.Tables("DTCID").Rows(i)(6).ToString
                    TB7.Text = ds.Tables("DTCID").Rows(i)(7).ToString
                    TB8.Text = ds.Tables("DTCID").Rows(i)(8).ToString
                    TB9.Text = ds.Tables("DTCID").Rows(i)(9).ToString
                    TB10.Text = ds.Tables("DTCID").Rows(i)(10).ToString
                    TB11.Text = ds.Tables("DTCID").Rows(i)(11).ToString
                    TB12.Text = ds.Tables("DTCID").Rows(i)(12).ToString
                    TB13.Text = ds.Tables("DTCID").Rows(i)(13).ToString
                    TB14.Text = ds.Tables("DTCID").Rows(i)(14).ToString
                    TB15.Text = ds.Tables("DTCID").Rows(i)(15).ToString
                    TB16.Text = ds.Tables("DTCID").Rows(i)(16).ToString
                    TB17.Text = ds.Tables("DTCID").Rows(i)(17).ToString
                    TB18.Text = ds.Tables("DTCID").Rows(i)(18).ToString
                    TB19.Text = ds.Tables("DTCID").Rows(i)(19).ToString
                    TB20.Text = ds.Tables("DTCID").Rows(i)(20).ToString
                    TB21.Text = ds.Tables("DTCID").Rows(i)(21).ToString
                    TB22.Text = ds.Tables("DTCID").Rows(i)(22).ToString
                    TB23.Text = ds.Tables("DTCID").Rows(i)(23).ToString
                    TB24.Text = ds.Tables("DTCID").Rows(i)(24).ToString
                Else
                    If ctr = TempLst Then
                        MsgBox("No information found.", MsgBoxStyle.Information, "DTCID SYSTEM [UXID:" & GenerateErrorID() & "]")
                    End If
                End If
            Next
        Catch ex As Exception
            ErrorMsg(ex)
        End Try
    End Sub

    Private Function CheckDataErr() As Integer
        Dim ctr, i As Integer
        ds.Clear()
        str = "select * from DTCID"
        cmd = New OleDbCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "DTCID")
        ctr = ds.Tables("DTCID").Rows.Count - 1

        For i = 0 To ctr
            If TB3.Text = ds.Tables("DTCID").Rows(i)(3).ToString Or TB4.Text = ds.Tables("DTCID").Rows(i)(4).ToString Then
                If TB1.Text = "" Or TB2.Text = "" Then
                    Return 2
                Else
                    Return 0
                End If
            Else
                Return 1
            End If
        Next
    End Function
    Private Sub B2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B2.Click
        Try
            If CheckDataErr() = 0 Then
                cn.Open()
                ds.Clear()
                str = "select * from DTCID where FIRSTNAME = '" & TB1.Text & "' and LASTNAME = '" & TB2.Text & "' and MOBILENUMBER1 = '" & TB3.Text & "'"
                cmd = New OleDbCommand(str, cn)
                da.SelectCommand = cmd
                da.Fill(ds, "DTCID")


                cmd.Connection = cn
                cmd.CommandText = "update DTCID set FIRSTNAME = '" & TB1.Text & "',LASTNAME = '" & TB2.Text & "',MOBILENUMBER1 = '" & TB3.Text & "',MOBILENUMBER2 = '" & TB4.Text & "',SHIRTLENGHT = '" & TB5.Text & "',SHIRTSHOULDER = '" & TB6.Text & "',SHIRTFULLBAHI = '" & TB7.Text & "',SHIRTHALFBAHI = '" & TB8.Text & "',SHIRTCUP = '" & TB9.Text & "',SHIRTCHEST = '" & TB10.Text & "',SHIRTSTOMACH = '" & TB11.Text & "',SHIRTSEAT = '" & TB12.Text & "',SHIRTCOLLER = '" & TB13.Text & "',SHIRTFORNT1 = '" & TB14.Text & "',SHIRTFORNT2 = '" & TB15.Text & "',SHIRTFORNT3 = '" & TB16.Text & "',SHIRTCOMMENTS = '" & TB17.Text & "',PANTLENGHT = '" & TB18.Text & "',PANTGHODA = '" & TB19.Text & "',PANTBOTTOM = '" & TB20.Text & "',PANTGHUTNA = '" & TB21.Text & "',PANTSEAT = '" & TB22.Text & "',PANTKAMAR = '" & TB23.Text & "',PANTCOMMENTS = '" & TB24.Text & "'" & "where FIRSTNAME = '" & TB1.Text & "' and LASTNAME = '" & TB2.Text & "'"
                cmd.ExecuteNonQuery()

                TB1.AutoCompleteCustomSource.Clear()
                TB2.AutoCompleteCustomSource.Clear()
                TB3.AutoCompleteCustomSource.Clear()
                TB4.AutoCompleteCustomSource.Clear()

                dtcidAutoCompleteCustomSource()

                MsgBox("Customer details successfully updated.", MsgBoxStyle.Information, "DTCID System [UXID: " & GenerateErrorID() & "]")
                ClearTextBox(Me)
                L1.Text = ""

                cn.Close()
            ElseIf CheckDataErr() = 1 Then
                MsgBox("Mobile number already listed in database.", MsgBoxStyle.Exclamation, "DTCID System [UXID:" & GenerateErrorID() & "]")
            ElseIf CheckDataErr() = 2 Then
                MsgBox("Make sure that you placed valid customer information", MsgBoxStyle.Exclamation, "DTCID System [UXID:" & GenerateErrorID() & "]")
            End If
        Catch ex As Exception
            ErrorMsg(ex)
        End Try
    End Sub

    Private Sub B3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B3.Click
        Me.Close()
    End Sub

    Private Sub B4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B4.Click
        ClearTextBox(Me)
        L1.Text = ""
        TB1.Focus()
    End Sub
End Class