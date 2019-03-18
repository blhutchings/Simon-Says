<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSimon
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSimon))
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnYellow = New System.Windows.Forms.Button()
        Me.btnBlue = New System.Windows.Forms.Button()
        Me.btnRed = New System.Windows.Forms.Button()
        Me.btnGreen = New System.Windows.Forms.Button()
        Me.lblCheetSheet = New System.Windows.Forms.Label()
        Me.TimerMainColorOn = New System.Windows.Forms.Timer(Me.components)
        Me.TimerMainColorOff = New System.Windows.Forms.Timer(Me.components)
        Me.lblHighScore = New System.Windows.Forms.Label()
        Me.TimerButtonPressOff = New System.Windows.Forms.Timer(Me.components)
        Me.Delay = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileNewGame = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileReset = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileCheatSheet = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblHighScoreVal = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblScoreVal = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnStart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.Location = New System.Drawing.Point(208, 359)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(150, 44)
        Me.btnStart.TabIndex = 10
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'btnYellow
        '
        Me.btnYellow.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.btnYellow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnYellow.Enabled = False
        Me.btnYellow.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnYellow.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.btnYellow.Location = New System.Drawing.Point(208, 203)
        Me.btnYellow.Name = "btnYellow"
        Me.btnYellow.Size = New System.Drawing.Size(150, 150)
        Me.btnYellow.TabIndex = 9
        Me.btnYellow.Tag = ""
        Me.btnYellow.UseVisualStyleBackColor = False
        '
        'btnBlue
        '
        Me.btnBlue.BackColor = System.Drawing.Color.Navy
        Me.btnBlue.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBlue.Enabled = False
        Me.btnBlue.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBlue.ForeColor = System.Drawing.Color.Navy
        Me.btnBlue.Location = New System.Drawing.Point(52, 203)
        Me.btnBlue.Name = "btnBlue"
        Me.btnBlue.Size = New System.Drawing.Size(150, 150)
        Me.btnBlue.TabIndex = 8
        Me.btnBlue.Tag = ""
        Me.btnBlue.UseVisualStyleBackColor = False
        '
        'btnRed
        '
        Me.btnRed.BackColor = System.Drawing.Color.DarkRed
        Me.btnRed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRed.Enabled = False
        Me.btnRed.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRed.ForeColor = System.Drawing.Color.DarkRed
        Me.btnRed.Location = New System.Drawing.Point(208, 47)
        Me.btnRed.Name = "btnRed"
        Me.btnRed.Size = New System.Drawing.Size(150, 150)
        Me.btnRed.TabIndex = 7
        Me.btnRed.Tag = ""
        Me.btnRed.UseVisualStyleBackColor = False
        '
        'btnGreen
        '
        Me.btnGreen.BackColor = System.Drawing.Color.DarkGreen
        Me.btnGreen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGreen.Enabled = False
        Me.btnGreen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGreen.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnGreen.Location = New System.Drawing.Point(52, 47)
        Me.btnGreen.Name = "btnGreen"
        Me.btnGreen.Size = New System.Drawing.Size(150, 150)
        Me.btnGreen.TabIndex = 6
        Me.btnGreen.Tag = ""
        Me.btnGreen.UseVisualStyleBackColor = False
        '
        'lblCheetSheet
        '
        Me.lblCheetSheet.AutoSize = True
        Me.lblCheetSheet.ForeColor = System.Drawing.Color.White
        Me.lblCheetSheet.Location = New System.Drawing.Point(358, 47)
        Me.lblCheetSheet.Name = "lblCheetSheet"
        Me.lblCheetSheet.Size = New System.Drawing.Size(36, 13)
        Me.lblCheetSheet.TabIndex = 11
        Me.lblCheetSheet.Text = "Order:"
        Me.lblCheetSheet.Visible = False
        '
        'TimerMainColorOn
        '
        Me.TimerMainColorOn.Interval = 200
        '
        'TimerMainColorOff
        '
        Me.TimerMainColorOff.Interval = 400
        '
        'lblHighScore
        '
        Me.lblHighScore.AutoSize = True
        Me.lblHighScore.BackColor = System.Drawing.Color.Black
        Me.lblHighScore.ForeColor = System.Drawing.Color.White
        Me.lblHighScore.Location = New System.Drawing.Point(49, 375)
        Me.lblHighScore.Name = "lblHighScore"
        Me.lblHighScore.Size = New System.Drawing.Size(60, 13)
        Me.lblHighScore.TabIndex = 12
        Me.lblHighScore.Text = "HighScore:"
        '
        'TimerButtonPressOff
        '
        Me.TimerButtonPressOff.Interval = 200
        '
        'Delay
        '
        Me.Delay.Interval = 500
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Black
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(410, 24)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileNewGame, Me.mnuFileReset, Me.mnuFileCheatSheet, Me.mnuFileExit})
        Me.mnuFile.ForeColor = System.Drawing.Color.White
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "File"
        '
        'mnuFileNewGame
        '
        Me.mnuFileNewGame.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.mnuFileNewGame.Name = "mnuFileNewGame"
        Me.mnuFileNewGame.Size = New System.Drawing.Size(206, 22)
        Me.mnuFileNewGame.Text = "New Game"
        '
        'mnuFileReset
        '
        Me.mnuFileReset.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.mnuFileReset.Name = "mnuFileReset"
        Me.mnuFileReset.Size = New System.Drawing.Size(206, 22)
        Me.mnuFileReset.Text = "Reset HighScore Counter"
        '
        'mnuFileCheatSheet
        '
        Me.mnuFileCheatSheet.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.mnuFileCheatSheet.Name = "mnuFileCheatSheet"
        Me.mnuFileCheatSheet.Size = New System.Drawing.Size(206, 22)
        Me.mnuFileCheatSheet.Text = "Enable CheatSheet"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(206, 22)
        Me.mnuFileExit.Text = "Exit"
        '
        'lblHighScoreVal
        '
        Me.lblHighScoreVal.AutoSize = True
        Me.lblHighScoreVal.BackColor = System.Drawing.Color.Black
        Me.lblHighScoreVal.ForeColor = System.Drawing.Color.White
        Me.lblHighScoreVal.Location = New System.Drawing.Point(115, 375)
        Me.lblHighScoreVal.Name = "lblHighScoreVal"
        Me.lblHighScoreVal.Size = New System.Drawing.Size(13, 13)
        Me.lblHighScoreVal.TabIndex = 14
        Me.lblHighScoreVal.Text = "0"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.BackColor = System.Drawing.Color.Black
        Me.lblScore.ForeColor = System.Drawing.Color.White
        Me.lblScore.Location = New System.Drawing.Point(49, 356)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(38, 13)
        Me.lblScore.TabIndex = 16
        Me.lblScore.Text = "Score:"
        '
        'lblScoreVal
        '
        Me.lblScoreVal.AutoSize = True
        Me.lblScoreVal.BackColor = System.Drawing.Color.Black
        Me.lblScoreVal.ForeColor = System.Drawing.Color.White
        Me.lblScoreVal.Location = New System.Drawing.Point(93, 356)
        Me.lblScoreVal.Name = "lblScoreVal"
        Me.lblScoreVal.Size = New System.Drawing.Size(13, 13)
        Me.lblScoreVal.TabIndex = 17
        Me.lblScoreVal.Text = "0"
        '
        'frmSimon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(410, 412)
        Me.Controls.Add(Me.lblScoreVal)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblHighScoreVal)
        Me.Controls.Add(Me.lblHighScore)
        Me.Controls.Add(Me.lblCheetSheet)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btnYellow)
        Me.Controls.Add(Me.btnBlue)
        Me.Controls.Add(Me.btnRed)
        Me.Controls.Add(Me.btnGreen)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmSimon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Simon"
        Me.TopMost = True
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents btnYellow As Button
    Friend WithEvents btnBlue As Button
    Friend WithEvents btnRed As Button
    Friend WithEvents btnGreen As Button
    Friend WithEvents lblCheetSheet As Label
    Friend WithEvents TimerMainColorOn As Timer
    Friend WithEvents TimerMainColorOff As Timer
    Friend WithEvents lblHighScore As Label
    Friend WithEvents TimerButtonPressOff As Timer
    Friend WithEvents Delay As Timer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileNewGame As ToolStripMenuItem
    Friend WithEvents mnuFileReset As ToolStripMenuItem
    Friend WithEvents mnuFileCheatSheet As ToolStripMenuItem
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents lblHighScoreVal As Label
    Friend WithEvents lblScore As Label
    Friend WithEvents lblScoreVal As Label
End Class
