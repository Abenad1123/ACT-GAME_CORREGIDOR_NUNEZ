<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class game_main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(game_main))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.wam_btn = New System.Windows.Forms.PictureBox()
        Me.rps_btn = New System.Windows.Forms.PictureBox()
        Me.mch_btn = New System.Windows.Forms.PictureBox()
        Me.etm_btn = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.wam_btn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rps_btn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mch_btn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.etm_btn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.5!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.5!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.wam_btn, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.rps_btn, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.mch_btn, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.etm_btn, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1902, 1033)
        Me.TableLayoutPanel1.TabIndex = 20
        '
        'wam_btn
        '
        Me.wam_btn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wam_btn.Image = Global.ACT_GAME_CORREGIDOR_NUÑEZ.My.Resources.Resources.whackamole_icon_256
        Me.wam_btn.Location = New System.Drawing.Point(1093, 541)
        Me.wam_btn.Margin = New System.Windows.Forms.Padding(0)
        Me.wam_btn.Name = "wam_btn"
        Me.wam_btn.Size = New System.Drawing.Size(523, 335)
        Me.wam_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.wam_btn.TabIndex = 4
        Me.wam_btn.TabStop = False
        '
        'rps_btn
        '
        Me.rps_btn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rps_btn.Image = Global.ACT_GAME_CORREGIDOR_NUÑEZ.My.Resources.Resources.rockpaperscissors_icon_256
        Me.rps_btn.Location = New System.Drawing.Point(285, 541)
        Me.rps_btn.Margin = New System.Windows.Forms.Padding(0)
        Me.rps_btn.Name = "rps_btn"
        Me.rps_btn.Size = New System.Drawing.Size(523, 335)
        Me.rps_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.rps_btn.TabIndex = 3
        Me.rps_btn.TabStop = False
        '
        'mch_btn
        '
        Me.mch_btn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mch_btn.Image = Global.ACT_GAME_CORREGIDOR_NUÑEZ.My.Resources.Resources.mathchallenge_icon_256
        Me.mch_btn.Location = New System.Drawing.Point(285, 206)
        Me.mch_btn.Margin = New System.Windows.Forms.Padding(0)
        Me.mch_btn.Name = "mch_btn"
        Me.mch_btn.Size = New System.Drawing.Size(523, 335)
        Me.mch_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.mch_btn.TabIndex = 2
        Me.mch_btn.TabStop = False
        '
        'etm_btn
        '
        Me.etm_btn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.etm_btn.Image = Global.ACT_GAME_CORREGIDOR_NUÑEZ.My.Resources.Resources.evadethemissles_icon_256
        Me.etm_btn.Location = New System.Drawing.Point(1093, 206)
        Me.etm_btn.Margin = New System.Windows.Forms.Padding(0)
        Me.etm_btn.Name = "etm_btn"
        Me.etm_btn.Size = New System.Drawing.Size(523, 335)
        Me.etm_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.etm_btn.TabIndex = 0
        Me.etm_btn.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label1, 5)
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 50.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1896, 206)
        Me.Label1.TabIndex = 1
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'game_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.BackgroundImage = Global.ACT_GAME_CORREGIDOR_NUÑEZ.My.Resources.Resources.abedadi
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1902, 1033)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "game_main"
        Me.Text = "De La Salle Santiago Zobel - Games"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.wam_btn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rps_btn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mch_btn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.etm_btn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents etm_btn As PictureBox
    Friend WithEvents wam_btn As PictureBox
    Friend WithEvents rps_btn As PictureBox
    Friend WithEvents mch_btn As PictureBox
    Friend WithEvents Label1 As Label
End Class
