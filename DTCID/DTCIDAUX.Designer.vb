<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DTCIDAUX
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DTCIDAUX))
        Me.PB1 = New System.Windows.Forms.PictureBox
        Me.L1 = New System.Windows.Forms.Label
        Me.L2 = New System.Windows.Forms.Label
        Me.RTB1 = New System.Windows.Forms.RichTextBox
        CType(Me.PB1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PB1
        '
        Me.PB1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PB1.Location = New System.Drawing.Point(0, 0)
        Me.PB1.Name = "PB1"
        Me.PB1.Size = New System.Drawing.Size(784, 150)
        Me.PB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PB1.TabIndex = 0
        Me.PB1.TabStop = False
        '
        'L1
        '
        Me.L1.Dock = System.Windows.Forms.DockStyle.Top
        Me.L1.Location = New System.Drawing.Point(0, 150)
        Me.L1.Name = "L1"
        Me.L1.Size = New System.Drawing.Size(784, 80)
        Me.L1.TabIndex = 4
        Me.L1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.L1.UseCompatibleTextRendering = True
        '
        'L2
        '
        Me.L2.Dock = System.Windows.Forms.DockStyle.Top
        Me.L2.Location = New System.Drawing.Point(0, 230)
        Me.L2.Name = "L2"
        Me.L2.Size = New System.Drawing.Size(784, 20)
        Me.L2.TabIndex = 5
        Me.L2.Text = "  License Agreement : "
        Me.L2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.L2.UseCompatibleTextRendering = True
        '
        'RTB1
        '
        Me.RTB1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.RTB1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RTB1.ForeColor = System.Drawing.Color.White
        Me.RTB1.Location = New System.Drawing.Point(0, 253)
        Me.RTB1.Name = "RTB1"
        Me.RTB1.ReadOnly = True
        Me.RTB1.ShowSelectionMargin = True
        Me.RTB1.Size = New System.Drawing.Size(784, 196)
        Me.RTB1.TabIndex = 6
        Me.RTB1.Text = ""
        '
        'DTCIDAUX
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.RTB1)
        Me.Controls.Add(Me.L2)
        Me.Controls.Add(Me.L1)
        Me.Controls.Add(Me.PB1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(800, 500)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 500)
        Me.Name = "DTCIDAUX"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "DTCIDAUX"
        CType(Me.PB1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PB1 As System.Windows.Forms.PictureBox
    Friend WithEvents L1 As System.Windows.Forms.Label
    Friend WithEvents L2 As System.Windows.Forms.Label
    Friend WithEvents RTB1 As System.Windows.Forms.RichTextBox
End Class
