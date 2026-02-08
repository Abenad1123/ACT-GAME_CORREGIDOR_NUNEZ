<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mathchallenge_settings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mathchallenge_settings))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.go_back = New System.Windows.Forms.ToolStripMenuItem()
        Me.GamesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.rockpaperscissors_btn = New System.Windows.Forms.ToolStripMenuItem()
        Me.evadethemissiles_btn = New System.Windows.Forms.ToolStripMenuItem()
        Me.whackamole_btn = New System.Windows.Forms.ToolStripMenuItem()
        Me.mathchallenge_btn = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.go_back, Me.GamesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1000, 28)
        Me.MenuStrip1.TabIndex = 21
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 28)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 14
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.13744!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.080569!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1000, 534)
        Me.TableLayoutPanel1.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label3, 3)
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(203, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(594, 59)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "SETTINGS"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'go_back
        '
        Me.go_back.Image = Global.ACT_GAME_CORREGIDOR_NUÑEZ.My.Resources.Resources.home_icon
        Me.go_back.Name = "go_back"
        Me.go_back.Size = New System.Drawing.Size(97, 24)
        Me.go_back.Text = "Go back"
        '
        'GamesToolStripMenuItem
        '
        Me.GamesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.rockpaperscissors_btn, Me.evadethemissiles_btn, Me.whackamole_btn, Me.mathchallenge_btn})
        Me.GamesToolStripMenuItem.Image = Global.ACT_GAME_CORREGIDOR_NUÑEZ.My.Resources.Resources.game_icon
        Me.GamesToolStripMenuItem.Name = "GamesToolStripMenuItem"
        Me.GamesToolStripMenuItem.Size = New System.Drawing.Size(88, 24)
        Me.GamesToolStripMenuItem.Text = "Games"
        '
        'rockpaperscissors_btn
        '
        Me.rockpaperscissors_btn.Image = Global.ACT_GAME_CORREGIDOR_NUÑEZ.My.Resources.Resources.rockpaperscissors_icon
        Me.rockpaperscissors_btn.Name = "rockpaperscissors_btn"
        Me.rockpaperscissors_btn.Size = New System.Drawing.Size(226, 26)
        Me.rockpaperscissors_btn.Text = "Rock, Paper, Scissors"
        '
        'evadethemissiles_btn
        '
        Me.evadethemissiles_btn.Image = Global.ACT_GAME_CORREGIDOR_NUÑEZ.My.Resources.Resources.evadeamissile_icon
        Me.evadethemissiles_btn.Name = "evadethemissiles_btn"
        Me.evadethemissiles_btn.Size = New System.Drawing.Size(226, 26)
        Me.evadethemissiles_btn.Text = "Evade the Missle"
        '
        'whackamole_btn
        '
        Me.whackamole_btn.Image = Global.ACT_GAME_CORREGIDOR_NUÑEZ.My.Resources.Resources.whackamole_icon
        Me.whackamole_btn.Name = "whackamole_btn"
        Me.whackamole_btn.Size = New System.Drawing.Size(226, 26)
        Me.whackamole_btn.Text = "Whack a Mole"
        '
        'mathchallenge_btn
        '
        Me.mathchallenge_btn.Image = Global.ACT_GAME_CORREGIDOR_NUÑEZ.My.Resources.Resources.mathchallenge_icon
        Me.mathchallenge_btn.Name = "mathchallenge_btn"
        Me.mathchallenge_btn.Size = New System.Drawing.Size(226, 26)
        Me.mathchallenge_btn.Text = "Math Challenge"
        '
        'mathchallenge_settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 562)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "mathchallenge_settings"
        Me.Text = "De La Salle Santiago Zobel - Games"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents go_back As ToolStripMenuItem
    Friend WithEvents GamesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents rockpaperscissors_btn As ToolStripMenuItem
    Friend WithEvents evadethemissiles_btn As ToolStripMenuItem
    Friend WithEvents whackamole_btn As ToolStripMenuItem
    Friend WithEvents mathchallenge_btn As ToolStripMenuItem
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label3 As Label
End Class
