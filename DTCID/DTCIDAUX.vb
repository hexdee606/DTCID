Public Class DTCIDAUX

    Private Sub DTCIDAUX_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Text = "DTCID About"
            PB1.Image = Image.FromFile(Directory.GetCurrentDirectory & "/Public/Pictures/Logo/DTCID.png")
            L1.Text = "  " & "DTCID - DIGITAL TAILOR CUSTOMER INFORMATION DATABASE SYSTEM" & vbNewLine & "  " & "VERSION : " & Me.ProductVersion & "(BETA)" & vbNewLine & "  " & "(C) 2019 - 2022 DIPEN CHAVAN." & vbNewLine & "  " & "ALL RIGHTS RESERVED."
            Dim read As New IO.StreamReader(Directory.GetCurrentDirectory & "/Public/Files/About/Info.txt")
            RTB1.Text = read.ReadToEnd()
            read.Close()
        Catch ex As Exception
            ErrorMsg(ex)
        End Try
    End Sub

End Class