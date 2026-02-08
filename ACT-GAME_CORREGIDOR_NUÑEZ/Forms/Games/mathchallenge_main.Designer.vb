<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mathchallenge_main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mathchallenge_main))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.go_back = New System.Windows.Forms.ToolStripMenuItem()
        Me.GamesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.rockpaperscissors_btn = New System.Windows.Forms.ToolStripMenuItem()
        Me.evadethemissiles_btn = New System.Windows.Forms.ToolStripMenuItem()
        Me.whackamole_btn = New System.Windows.Forms.ToolStripMenuItem()
        Me.mathchallenge_btn = New System.Windows.Forms.ToolStripMenuItem()
        Me.settings = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.heart3 = New System.Windows.Forms.PictureBox()
        Me.heart2 = New System.Windows.Forms.PictureBox()
        Me.heart1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.heart3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.heart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.heart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.go_back, Me.GamesToolStripMenuItem, Me.settings})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1902, 28)
        Me.MenuStrip1.TabIndex = 20
        Me.MenuStrip1.Text = "MenuStrip1"
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
        'settings
        '
        Me.settings.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.settings.Image = Global.ACT_GAME_CORREGIDOR_NUÑEZ.My.Resources.Resources.settings_icon
        Me.settings.Name = "settings"
        Me.settings.Size = New System.Drawing.Size(96, 24)
        Me.settings.Text = "Settings"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.ColumnCount = 9
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.039443!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.43385!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.395236!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.43385!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.395236!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.43385!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.395236!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.43385!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.039443!))
        Me.TableLayoutPanel1.Controls.Add(Me.Button2, 3, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Button3, 5, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Button4, 7, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox1, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 28)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.63682!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.49751!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.78607!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.64677!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.258706!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.965272!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1902, 1005)
        Me.TableLayoutPanel1.TabIndex = 24
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(569, 873)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(306, 77)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(1021, 873)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(306, 77)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(1473, 873)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(306, 77)
        Me.Button4.TabIndex = 22
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(117, 873)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(306, 77)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label1, 3)
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei Light", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(569, 763)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(758, 107)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Question"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.PictureBox1, 5)
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.ACT_GAME_CORREGIDOR_NUÑEZ.My.Resources.Resources._12
        Me.PictureBox1.Location = New System.Drawing.Point(429, 130)
        Me.PictureBox1.Name = "PictureBox1"
        Me.TableLayoutPanel1.SetRowSpan(Me.PictureBox1, 2)
        Me.PictureBox1.Size = New System.Drawing.Size(1038, 630)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 6
        Me.TableLayoutPanel1.SetColumnSpan(Me.TableLayoutPanel2, 4)
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.heart3, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.heart2, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.heart1, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(426, 0)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(904, 127)
        Me.TableLayoutPanel2.TabIndex = 23
        '
        'heart3
        '
        Me.heart3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.heart3.Image = CType(resources.GetObject("heart3.Image"), System.Drawing.Image)
        Me.heart3.Location = New System.Drawing.Point(581, 13)
        Me.heart3.Margin = New System.Windows.Forms.Padding(0)
        Me.heart3.Name = "heart3"
        Me.heart3.Size = New System.Drawing.Size(100, 100)
        Me.heart3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.heart3.TabIndex = 3
        Me.heart3.TabStop = False
        '
        'heart2
        '
        Me.heart2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.heart2.Image = CType(resources.GetObject("heart2.Image"), System.Drawing.Image)
        Me.heart2.Location = New System.Drawing.Point(473, 13)
        Me.heart2.Margin = New System.Windows.Forms.Padding(0)
        Me.heart2.Name = "heart2"
        Me.heart2.Size = New System.Drawing.Size(100, 100)
        Me.heart2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.heart2.TabIndex = 2
        Me.heart2.TabStop = False
        '
        'heart1
        '
        Me.heart1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.heart1.Image = CType(resources.GetObject("heart1.Image"), System.Drawing.Image)
        Me.heart1.Location = New System.Drawing.Point(365, 13)
        Me.heart1.Margin = New System.Windows.Forms.Padding(0)
        Me.heart1.Name = "heart1"
        Me.heart1.Size = New System.Drawing.Size(100, 100)
        Me.heart1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.heart1.TabIndex = 0
        Me.heart1.TabStop = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift Condensed", 40.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(207, 33)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0, 20, 0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 81)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "LIVES"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'mathchallenge_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1902, 1033)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "mathchallenge_main"
        Me.Text = "De La Salle Santiago Zobel - Games"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.heart3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.heart2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.heart1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents settings As ToolStripMenuItem
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents heart3 As PictureBox
    Friend WithEvents heart2 As PictureBox
    Friend WithEvents heart1 As PictureBox
    Friend WithEvents Label2 As Label
End Class
