<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DTCIDUX
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DTCIDUX))
        Me.BW1 = New System.ComponentModel.BackgroundWorker
        Me.CMS1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TSMI1 = New System.Windows.Forms.ToolStripMenuItem
        Me.TSMI2 = New System.Windows.Forms.ToolStripMenuItem
        Me.TSMI3 = New System.Windows.Forms.ToolStripMenuItem
        Me.TSS1 = New System.Windows.Forms.ToolStripSeparator
        Me.TSMI4 = New System.Windows.Forms.ToolStripMenuItem
        Me.TSS2 = New System.Windows.Forms.ToolStripSeparator
        Me.TSMI5 = New System.Windows.Forms.ToolStripMenuItem
        Me.SS1 = New System.Windows.Forms.StatusStrip
        Me.TSSL1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.TSSL2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.PB1 = New System.Windows.Forms.PictureBox
        Me.L2 = New System.Windows.Forms.Label
        Me.L1 = New System.Windows.Forms.Label
        Me.CMS1.SuspendLayout()
        Me.SS1.SuspendLayout()
        CType(Me.PB1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BW1
        '
        '
        'CMS1
        '
        Me.CMS1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.CMS1.DropShadowEnabled = False
        Me.CMS1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.CMS1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMI1, Me.TSMI2, Me.TSMI3, Me.TSS1, Me.TSMI4, Me.TSS2, Me.TSMI5})
        Me.CMS1.Name = "CMS1"
        Me.CMS1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.CMS1.Size = New System.Drawing.Size(304, 126)
        '
        'TSMI1
        '
        Me.TSMI1.ForeColor = System.Drawing.Color.White
        Me.TSMI1.Name = "TSMI1"
        Me.TSMI1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.TSMI1.Size = New System.Drawing.Size(303, 22)
        Me.TSMI1.Text = "ADD NEW CUSTOMER DETAILS"
        '
        'TSMI2
        '
        Me.TSMI2.ForeColor = System.Drawing.Color.White
        Me.TSMI2.Name = "TSMI2"
        Me.TSMI2.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.TSMI2.Size = New System.Drawing.Size(303, 22)
        Me.TSMI2.Text = "UPDATE CUSTOMER INFORMATION"
        '
        'TSMI3
        '
        Me.TSMI3.ForeColor = System.Drawing.Color.White
        Me.TSMI3.Name = "TSMI3"
        Me.TSMI3.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.TSMI3.Size = New System.Drawing.Size(303, 22)
        Me.TSMI3.Text = "FIND CUSTOMER INFORMATION"
        '
        'TSS1
        '
        Me.TSS1.ForeColor = System.Drawing.Color.White
        Me.TSS1.Name = "TSS1"
        Me.TSS1.Size = New System.Drawing.Size(300, 6)
        '
        'TSMI4
        '
        Me.TSMI4.ForeColor = System.Drawing.Color.White
        Me.TSMI4.Name = "TSMI4"
        Me.TSMI4.Size = New System.Drawing.Size(303, 22)
        Me.TSMI4.Text = "About DTCID"
        '
        'TSS2
        '
        Me.TSS2.ForeColor = System.Drawing.Color.White
        Me.TSS2.Name = "TSS2"
        Me.TSS2.Size = New System.Drawing.Size(300, 6)
        '
        'TSMI5
        '
        Me.TSMI5.ForeColor = System.Drawing.Color.White
        Me.TSMI5.Name = "TSMI5"
        Me.TSMI5.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.TSMI5.Size = New System.Drawing.Size(303, 22)
        Me.TSMI5.Text = "Exit"
        '
        'SS1
        '
        Me.SS1.AutoSize = False
        Me.SS1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.SS1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSSL1, Me.TSSL2})
        Me.SS1.Location = New System.Drawing.Point(0, 406)
        Me.SS1.Name = "SS1"
        Me.SS1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.SS1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.SS1.Size = New System.Drawing.Size(934, 30)
        Me.SS1.TabIndex = 6
        '
        'TSSL1
        '
        Me.TSSL1.Name = "TSSL1"
        Me.TSSL1.Size = New System.Drawing.Size(48, 25)
        Me.TSSL1.Text = "Status : "
        '
        'TSSL2
        '
        Me.TSSL2.AutoToolTip = True
        Me.TSSL2.Name = "TSSL2"
        Me.TSSL2.Size = New System.Drawing.Size(0, 25)
        '
        'PB1
        '
        Me.PB1.ContextMenuStrip = Me.CMS1
        Me.PB1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PB1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PB1.Location = New System.Drawing.Point(0, 0)
        Me.PB1.Margin = New System.Windows.Forms.Padding(4)
        Me.PB1.Name = "PB1"
        Me.PB1.Size = New System.Drawing.Size(934, 150)
        Me.PB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PB1.TabIndex = 3
        Me.PB1.TabStop = False
        '
        'L2
        '
        Me.L2.ContextMenuStrip = Me.CMS1
        Me.L2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.L2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.L2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.L2.Location = New System.Drawing.Point(0, 356)
        Me.L2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L2.Name = "L2"
        Me.L2.Size = New System.Drawing.Size(934, 50)
        Me.L2.TabIndex = 5
        Me.L2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.L2.UseCompatibleTextRendering = True
        '
        'L1
        '
        Me.L1.ContextMenuStrip = Me.CMS1
        Me.L1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.L1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.L1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.L1.Location = New System.Drawing.Point(0, 150)
        Me.L1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L1.Name = "L1"
        Me.L1.Size = New System.Drawing.Size(934, 206)
        Me.L1.TabIndex = 4
        Me.L1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.L1.UseCompatibleTextRendering = True
        '
        'DTCIDUX
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(934, 436)
        Me.ContextMenuStrip = Me.CMS1
        Me.Controls.Add(Me.L1)
        Me.Controls.Add(Me.L2)
        Me.Controls.Add(Me.PB1)
        Me.Controls.Add(Me.SS1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(950, 475)
        Me.Name = "DTCIDUX"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.CMS1.ResumeLayout(False)
        Me.SS1.ResumeLayout(False)
        Me.SS1.PerformLayout()
        CType(Me.PB1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BW1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents CMS1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents TSS1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TSMI3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMI2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMI1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMI4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSS2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SS1 As System.Windows.Forms.StatusStrip
    Friend WithEvents TSSL1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TSSL2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TSMI5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PB1 As System.Windows.Forms.PictureBox
    Friend WithEvents L2 As System.Windows.Forms.Label
    Friend WithEvents L1 As System.Windows.Forms.Label

End Class
