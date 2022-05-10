Public Class DTCIDNUX
    Private CloseME As Boolean = True

    Private Sub DTCIDNUX_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" & IO.Directory.GetCurrentDirectory & "\Private\dbDTCID.accdb"
            cn.Open()
            cmd = New OleDb.OleDbCommand("Select COUNT(*) FROM DTCID", cn)
            L1.Text = "DTCID-REG-NO-" & (cmd.ExecuteScalar() + 1)
            Me.Text = "DTCID SYSTEM | NEW CUSTOMER INFORMATION"
            cmd.Dispose()
            cn.Close()
            cn.Dispose()
        Catch ex As Exception
            ErrorMsg(ex)
        End Try
    End Sub

    Private Sub B1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B1.Click
        Try
            ClearTextBox(Me)
            TB1.Focus()
        Catch ex As Exception
            ErrorMsg(ex)
        End Try
    End Sub

    Private Sub B3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B3.Click
        Me.Close()
    End Sub

    Private Sub DTCIDNUX_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If CloseME = False Then
            e.Cancel = True
            MsgBox("Please wait DTCID is busy for doing some work.", MsgBoxStyle.Exclamation, "DTCID SYSTEM [UXID:" & GenerateErrorID() & "]")
        Else
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            cn.Dispose()
        End If
    End Sub

    Private Sub B2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B2.Click
        Try
            If TB1.Text = "" Or TB2.Text = "" Or TB3.Text = "" Then
                MsgBox("Make sure that you placed valid customer information", MsgBoxStyle.Exclamation, "DTCID System [UXID:" & GenerateErrorID() & "]")
            Else
                B1.Enabled = False
                B2.Enabled = False
                B3.Enabled = False
                CloseME = False

                cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" & IO.Directory.GetCurrentDirectory & "\Private\dbDTCID.accdb"
                Dim ctr, i As Integer
                Dim che As Integer = 0
                Dim mhe As Integer = 0

                ds.Clear()

                If cn.State = ConnectionState.Open Then
                    cn.Close()
                End If
                cn.Open()

                str = "select * from DTCID"
                cmd = New OleDbCommand(str, cn)
                da.SelectCommand = cmd
                da.Fill(ds, "DTCID")
                ctr = ds.Tables("DTCID").Rows.Count - 1

                For i = 0 To ctr
                    If ds.Tables("DTCID").Rows(i)(3).ToString = TB3.Text Then
                        che = 1
                    End If
                Next

                cn.Close()

                If che = 1 Then
                    MsgBox("Mobile number already listed in database.", MsgBoxStyle.Exclamation, "DTCID System [UXID:" & GenerateErrorID() & "]")
                Else

                    If cn.State = ConnectionState.Open Then
                        cn.Close()
                    End If
                    cn.Open()

                    Dim str As String
                    str = "insert into DTCID([FIRSTNAME],[LASTNAME],[MOBILENUMBER1],[MOBILENUMBER2],[SHIRTLENGHT],[SHIRTSHOULDER],[SHIRTFULLBAHI],[SHIRTHALFBAHI],[SHIRTCUP],[SHIRTCHEST],[SHIRTSTOMACH], [SHIRTSEAT],[SHIRTCOLLER],[SHIRTFORNT1],[SHIRTFORNT2],[SHIRTFORNT3],[SHIRTCOMMENTS],[PANTLENGHT],[PANTGHODA],[PANTBOTTOM],[PANTGHUTNA],[PANTSEAT],[PANTKAMAR],[PANTCOMMENTS]) values(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)"
                    Dim cmd As OleDbCommand = New OleDbCommand(str, cn)
                    cmd.Parameters.Add(New OleDbParameter("FIRSTNAME", CType(TB1.Text, String)))
                    cmd.Parameters.Add(New OleDbParameter("LASTNAME", CType(TB2.Text, String)))
                    cmd.Parameters.Add(New OleDbParameter("MOBILENUMBER1", CType(TB3.Text, String)))
                    cmd.Parameters.Add(New OleDbParameter("MOBILENUMBER2", CType(TB4.Text, String)))
                    cmd.Parameters.Add(New OleDbParameter("SHIRTLENGHT", CType(TB5.Text, String)))
                    cmd.Parameters.Add(New OleDbParameter("SHIRTSHOULDER", CType(TB6.Text, String)))
                    cmd.Parameters.Add(New OleDbParameter("SHIRTFULLBAHI", CType(TB7.Text, String)))
                    cmd.Parameters.Add(New OleDbParameter("SHIRTHALFBAHI", CType(TB8.Text, String)))
                    cmd.Parameters.Add(New OleDbParameter("SHIRTCUP", CType(TB9.Text, String)))
                    cmd.Parameters.Add(New OleDbParameter("SHIRTCHEST", CType(TB10.Text, String)))
                    cmd.Parameters.Add(New OleDbParameter("SHIRTSTOMACH", CType(TB11.Text, String)))
                    cmd.Parameters.Add(New OleDbParameter("SHIRTSEAT", CType(TB12.Text, String)))
                    cmd.Parameters.Add(New OleDbParameter("SHIRTCOLLER", CType(TB13.Text, String)))
                    cmd.Parameters.Add(New OleDbParameter("SHIRTFORNT1", CType(TB14.Text, String)))
                    cmd.Parameters.Add(New OleDbParameter("SHIRTFORNT2", CType(TB15.Text, String)))
                    cmd.Parameters.Add(New OleDbParameter("SHIRTFORNT3", CType(TB16.Text, String)))
                    cmd.Parameters.Add(New OleDbParameter("SHIRTCOMMENTS", CType(TB17.Text, String)))
                    cmd.Parameters.Add(New OleDbParameter("PANTLENGHT", CType(TB18.Text, String)))
                    cmd.Parameters.Add(New OleDbParameter("PANTGHODA", CType(TB19.Text, String)))
                    cmd.Parameters.Add(New OleDbParameter("PANTBOTTOM", CType(TB20.Text, String)))
                    cmd.Parameters.Add(New OleDbParameter("PANTGHUTNA", CType(TB21.Text, String)))
                    cmd.Parameters.Add(New OleDbParameter("PANTSEAT", CType(TB22.Text, String)))
                    cmd.Parameters.Add(New OleDbParameter("PANTKAMAR", CType(TB23.Text, String)))
                    cmd.Parameters.Add(New OleDbParameter("PANTCOMMENTS", CType(TB24.Text, String)))

                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    cn.Close()

                    ClearTextBox(Me)
                    MsgBox("Customer Details Successfully added.", MsgBoxStyle.Information, "DTCID Systam [UXID:" & GenerateErrorID() & "]")
                End If
                B1.Enabled = True
                B2.Enabled = True
                B3.Enabled = True
                CloseME = True

                cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" & IO.Directory.GetCurrentDirectory & "\Private\dbDTCID.accdb"
                cn.Open()
                cmd = New OleDb.OleDbCommand("Select COUNT(*) FROM DTCID", cn)
                L1.Text = "DTCID-REG-NO-" & (cmd.ExecuteScalar() + 1)
                cmd.Dispose()
                cn.Close()
                cn.Dispose()
            End If
        Catch ex As Exception
            ErrorMsg(ex)
        End Try
    End Sub
End Class