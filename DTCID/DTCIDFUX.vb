Public Class DTCIDFUX
    Private TempLst As Integer
    Private Sub B1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B1.Click
        ClearTextBox(Me)
        L1.Text = ""
        TB1.Focus()
    End Sub

    Private Function EmptyTxt() As Boolean
        If TB4.Text = "" Or TB4.Text = Nothing Then
            If TB3.Text = "" Or TB3.Text = Nothing Then
                If TB2.Text = "" Or TB2.Text = Nothing Then
                    If TB1.Text = "" Or TB1.Text = Nothing Then
                        Return True
                    Else
                        Return False
                    End If
                Else
                    Return False
                End If
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function

    Private Sub B2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B2.Click
        Try
            If TB1.Text = Nothing Or TB1.Text = "" Then
                MsgBox("Please enter First name", MsgBoxStyle.Exclamation, "DTCID System [UXID:" & GenerateErrorID() & "]")
            ElseIf TB2.Text = Nothing Or TB2.Text = "" Then
                MsgBox("Please enter Last name", MsgBoxStyle.Exclamation, "DTCID System [UXID:" & GenerateErrorID() & "]")
            ElseIf TB3.Text = Nothing Or TB3.Text = "" Then
                MsgBox("Please enter Mobile number", MsgBoxStyle.Exclamation, "DTCID System [UXID:" & GenerateErrorID() & "]")
            Else
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
            End If
        Catch ex As Exception
            ErrorMsg(ex)
        End Try
    End Sub

    Private Sub B3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B3.Click
        Me.Close()
    End Sub

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
            ClearTextBox(Me)
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
End Class