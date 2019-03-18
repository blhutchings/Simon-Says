'Simon Says
'Created By: Ben Hutchings
'Created: 2019-03-13
'Last Modified: 2019-03-13/2:39AM
Public Class frmSimon
    'Arrays Variables
    Dim IntSimonsMemory(0) As Integer
    Dim IntCheck(0) As Integer
    'Cheat Sheet Variables
    Dim CheatSheet As String
    Dim CheatSheetOrder As String
    Dim CheatSheetEnabled As Boolean = False
    'Counters
    Dim StageCounter As Integer
    Dim Counter As Integer
    Dim TimerCounter As Integer
    'Declaired Variables
    Dim HighScore As Integer
    Dim GameInProgress As Boolean
    Dim generator As New Random
    '****************************************************
    'Starts The Game
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        btnStart.Text = "--------"
        ReDim IntSimonsMemory(0)
        ReDim IntCheck(0)
        GameInProgress = True
        StageCounter = 0
        Counter = 0
        HighScore = 0
        TimerCounter = 0
        lblCheetSheet.Text = "Order:"
        lblScoreVal.Text = "0"
        btnBlue.Enabled = True
        btnRed.Enabled = True
        btnYellow.Enabled = True
        btnGreen.Enabled = True
        btnStart.Enabled = False
        IntSimonsMemory(0) = generator.Next(0, 4)
        TimerMainColorOn.Start()

        'Cheat Sheet Start
        If IntSimonsMemory(0) = 0 Then
            CheatSheet = "Green"
        End If
        If IntSimonsMemory(0) = 1 Then
            CheatSheet = "Red"
        End If
        If IntSimonsMemory(0) = 2 Then
            CheatSheet = "Blue"
        End If
        If IntSimonsMemory(0) = 3 Then
            CheatSheet = "Yellow"
        End If
        CheatSheetOrder = 1
        lblCheetSheet.Text += Environment.NewLine & CheatSheetOrder & ": " & CheatSheet
    End Sub
    '****************************************************
    'Responses depending what button is clicked
    Private Sub btnGreen_Click(sender As Object, e As EventArgs) Handles btnGreen.Click
        IntCheck(StageCounter) = 0
        btnGreen.BackColor = Color.LimeGreen
        StageCounter += 1
        'Plays Sound Effect
        PlayGreen()
        'Changes color back to default
        TimerButtonPressOff.Start()
        'Check if clicked button is correct
        Call Check()
    End Sub
    Private Sub btnRed_Click(sender As Object, e As EventArgs) Handles btnRed.Click
        IntCheck(StageCounter) = 1
        btnRed.BackColor = Color.Red
        StageCounter += 1
        PlayRed()
        TimerButtonPressOff.Start()
        Call Check()
    End Sub
    Private Sub btnBlue_Click(sender As Object, e As EventArgs) Handles btnBlue.Click
        IntCheck(StageCounter) = 2
        btnBlue.BackColor = Color.Blue
        StageCounter += 1
        PlayBlue()
        TimerButtonPressOff.Start()
        Call Check()
    End Sub
    Private Sub btnYellow_Click(sender As Object, e As EventArgs) Handles btnYellow.Click
        IntCheck(StageCounter) = 3
        btnYellow.BackColor = Color.Yellow
        StageCounter += 1
        PlayYellow()
        TimerButtonPressOff.Start()
        Call Check()
    End Sub
    '************************************************* 
    'Checks if button clicks is right
    Private Sub Check()
        If IntSimonsMemory(Counter) = IntCheck(Counter) Then
            If Counter = IntSimonsMemory.Length - 1 Then
                Counter = 0
                'If counter gets to top of array, another stage is added
                Call NextStage(Counter)
            Else
                Counter += 1
            End If
        Else
            btnBlue.Enabled = False
            btnRed.Enabled = False
            btnYellow.Enabled = False
            btnGreen.Enabled = False
            btnStart.Enabled = True
            btnStart.Text = "Retry"
            GameInProgress = False
            PlayFail()
        End If

    End Sub
    '***********************************************************
    'Makes arrays larger and adds new random number
    Private Sub NextStage(Counter As Integer)
        ReDim Preserve IntSimonsMemory(IntSimonsMemory.Length)
        ReDim IntCheck(IntCheck.Length)
        IntSimonsMemory(IntSimonsMemory.Length - 1) = generator.Next(0, 4)
        'Cheat Sheet Part 2
        If IntSimonsMemory(IntSimonsMemory.Length - 1) = 0 Then
            CheatSheet = "Green"
        End If
        If IntSimonsMemory(IntSimonsMemory.Length - 1) = 1 Then
            CheatSheet = "Red"
        End If
        If IntSimonsMemory(IntSimonsMemory.Length - 1) = 2 Then
            CheatSheet = "Blue"
        End If
        If IntSimonsMemory(IntSimonsMemory.Length - 1) = 3 Then
            CheatSheet = "Yellow"
        End If
        CheatSheetOrder += 1
        lblCheetSheet.Text += Environment.NewLine & CheatSheetOrder & ": " & CheatSheet
        StageCounter = 0
        TimerCounter = 0
        HighScore += 1
        lblScoreVal.Text = CStr(HighScore)
        'Keeps highscore
        If HighScore > Val(lblHighScoreVal.Text) Then
            lblHighScoreVal.Text = HighScore
        End If
        'Disables buttons until order is complete
        btnGreen.Enabled = False
        btnRed.Enabled = False
        btnBlue.Enabled = False
        btnYellow.Enabled = False
        Delay.Start()
    End Sub
    '*********************************************************
    'Timer logic (Not going to bother explaining)
    Private Sub TimerMainColorOn_Tick(sender As Object, e As EventArgs) Handles TimerMainColorOn.Tick
        If TimerCounter < IntSimonsMemory.Length Then
            If IntSimonsMemory(TimerCounter) = 0 Then
                btnGreen.BackColor = Color.LimeGreen
                btnGreen.ForeColor = Color.LimeGreen
                PlayGreen()
                TimerMainColorOn.Stop()
                TimerMainColorOff.Start()
            End If
            If IntSimonsMemory(TimerCounter) = 1 Then
                btnRed.BackColor = Color.Red
                btnRed.ForeColor = Color.Red
                PlayRed()
                TimerMainColorOn.Stop()
                TimerMainColorOff.Start()
            End If
            If IntSimonsMemory(TimerCounter) = 2 Then
                btnBlue.BackColor = Color.Blue
                btnBlue.ForeColor = Color.Blue
                PlayBlue()
                TimerMainColorOn.Stop()
                TimerMainColorOff.Start()
            End If
            If IntSimonsMemory(TimerCounter) = 3 Then
                btnYellow.BackColor = Color.Yellow
                btnYellow.ForeColor = Color.Yellow
                PlayYellow()
                TimerMainColorOn.Stop()
                TimerMainColorOff.Start()
            End If
            TimerCounter += 1
        Else
            btnGreen.Enabled = True
            btnRed.Enabled = True
            btnBlue.Enabled = True
            btnYellow.Enabled = True
            TimerMainColorOn.Stop()
            TimerMainColorOff.Stop()
        End If
    End Sub

    Private Sub TimerMainColorOff_Tick(sender As Object, e As EventArgs) Handles TimerMainColorOff.Tick
        btnGreen.BackColor = Color.DarkGreen
        btnRed.BackColor = Color.DarkRed
        btnBlue.BackColor = Color.Navy
        btnYellow.BackColor = Color.DarkGoldenrod
        btnGreen.ForeColor = Color.DarkGreen
        btnRed.ForeColor = Color.DarkRed
        btnBlue.ForeColor = Color.Navy
        btnYellow.ForeColor = Color.DarkGoldenrod
        TimerMainColorOff.Stop()
        TimerMainColorOn.Start()
    End Sub

    Private Sub TimerButtonPressOff_Tick(sender As Object, e As EventArgs) Handles TimerButtonPressOff.Tick
        If btnGreen.BackColor = Color.LimeGreen Then
            btnGreen.BackColor = Color.DarkGreen
        End If
        If btnRed.BackColor = Color.Red Then
            btnRed.BackColor = Color.DarkRed
        End If
        If btnBlue.BackColor = Color.Blue Then
            btnBlue.BackColor = Color.Navy
        End If
        If btnYellow.BackColor = Color.Yellow Then
            btnYellow.BackColor = Color.DarkGoldenrod
        End If
        TimerButtonPressOff.Stop()
    End Sub

    Private Sub Delay_Tick(sender As Object, e As EventArgs) Handles Delay.Tick
        TimerMainColorOn.Start()
        Delay.Stop()
    End Sub

    '*******************************************************
    'Audio Files
    Sub PlayGreen()
        My.Computer.Audio.Play(My.Resources.Audio.Green,
            AudioPlayMode.Background)
    End Sub
    Sub PlayRed()
        My.Computer.Audio.Play(My.Resources.Audio.Red,
            AudioPlayMode.Background)
    End Sub
    Sub PlayBlue()
        My.Computer.Audio.Play(My.Resources.Audio.Blue1,
            AudioPlayMode.Background)
    End Sub
    Sub PlayYellow()
        My.Computer.Audio.Play(My.Resources.Audio.Yellow,
            AudioPlayMode.Background)
    End Sub
    Sub PlayFail()
        My.Computer.Audio.Play(My.Resources.Audio.Fail,
            AudioPlayMode.Background)
    End Sub
    '*******************************************
    'Menu Bar

    'Enables Cheat Sheet
    Private Sub mnuFileCheatSheet_Click(sender As Object, e As EventArgs) Handles mnuFileCheatSheet.Click
        If CheatSheetEnabled = False Then
            lblCheetSheet.Visible = True
            mnuFileCheatSheet.Text = "Disable CheatSheet"
            CheatSheetEnabled = True
        Else
            lblCheetSheet.Visible = False
            mnuFileCheatSheet.Text = "Enable CheatSheet"
            CheatSheetEnabled = False
        End If

    End Sub
    'GameStart
    Private Sub mnuFileNewGame_Click(sender As Object, e As EventArgs) Handles mnuFileNewGame.Click
        btnStart.Text = "--------"
        ReDim IntSimonsMemory(0)
        ReDim IntCheck(0)
        GameInProgress = True
        StageCounter = 0
        Counter = 0
        HighScore = 0
        TimerCounter = 0
        lblCheetSheet.Text = "Order:"
        lblScoreVal.Text = "0"
        IntSimonsMemory(0) = generator.Next(0, 4)
        TimerMainColorOn.Start()

        'Cheat Sheet Start
        If IntSimonsMemory(0) = 0 Then
            CheatSheet = "Green"
        End If
        If IntSimonsMemory(0) = 1 Then
            CheatSheet = "Red"
        End If
        If IntSimonsMemory(0) = 2 Then
            CheatSheet = "Blue"
        End If
        If IntSimonsMemory(0) = 3 Then
            CheatSheet = "Yellow"
        End If
        CheatSheetOrder = 1
        lblCheetSheet.Text += Environment.NewLine & CheatSheetOrder & ": " & CheatSheet
    End Sub

    Private Sub mnuFileReset_Click(sender As Object, e As EventArgs) Handles mnuFileReset.Click
        If GameInProgress = False Then
            lblHighScoreVal.Text = "0"
        End If
    End Sub

    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        Close()
    End Sub
End Class
