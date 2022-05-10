Public Class DTCIDUX

    Private Sub DTCIDUX_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Text = "DTCID - DIGITAL TAILOR CUSTOMER INFORMATION DATABASE SYSTEM"
            TSSL2.Text = "Please wait.."
            CMS1.Enabled = False
            BW1.RunWorkerAsync()
        Catch ex As Exception
            ErrorMsg(ex)
        End Try
    End Sub

    Private Sub BW1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BW1.DoWork
        Try
            PB1.Image = Image.FromFile(Directory.GetCurrentDirectory & "/Public/Pictures/Logo/DTCID.png")
            TSMI1.Image = Image.FromFile(Directory.GetCurrentDirectory & "/Public/icon/32x32/a.png")
            TSMI2.Image = Image.FromFile(Directory.GetCurrentDirectory & "/Public/icon/32x32/b.png")
            TSMI3.Image = Image.FromFile(Directory.GetCurrentDirectory & "/Public/icon/32x32/c.png")
            TSMI4.Image = Image.FromFile(Directory.GetCurrentDirectory & "/Public/icon/32x32/d.png")
            TSMI5.Image = Image.FromFile(Directory.GetCurrentDirectory & "/Public/icon/32x32/e.png")
        Catch ex As Exception
            ErrorMsg(ex)
        End Try
    End Sub

    Private Sub BW1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BW1.RunWorkerCompleted
        Try
            L1.Text = "ADD NEW CUSTOMER INFORMATION CTRL + N" & vbNewLine & "UPDATE CUSTOMER INFORMATION CTRL + U" & vbNewLine & "FIND CUTOMER INFORMATION CTRL + F" & vbNewLine & vbNewLine & "RIGHT MOUSE CLICK FOR MORE OPTION. "
            L2.Text = "DTCID - Digital Tailor Customer Information Database System by Chhagan Tailor, Dhule MH IND (Dipen Chavan) is licensed under a Creative Commons Zero v1.0 Universal."
            CMS1.Enabled = True
            TSSL2.Text = "Ready"
        Catch ex As Exception
            ErrorMsg(ex)
        End Try
    End Sub

    Private Sub TSMI1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMI1.Click
        DTCIDNUX.ShowDialog()
    End Sub

    Private Sub TSMI2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMI2.Click
        DTCIDUUX.ShowDialog()
    End Sub

    Private Sub TSMI3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMI3.Click
        DTCIDFUX.ShowDialog()
    End Sub

    Private Sub TSMI4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMI4.Click
        Try
            DTCIDAUX.ShowDialog()
        Catch ex As Exception
            ErrorMsg(ex)
        End Try
    End Sub

    Private Sub TSMI5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMI5.Click
        Application.Exit()
    End Sub
End Class
