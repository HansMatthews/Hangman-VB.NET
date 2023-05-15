Imports System.IO

Public Class Form1

    Private random As New Random()
    Private question As String
    Private answer As String
    Private misses As Integer = 0
    Private score As Integer = 0
    Private usedAnswers As New List(Of String)()

    Private Sub InitializeGame()
        Dim questions As String() = File.ReadAllLines("E:\Visual Basic\Hanggaroo\Words\Categories.txt")

        Dim famousYoutubers As List(Of String) = File.ReadAllLines("E:\Visual Basic\Hanggaroo\Words\FAMOUS YOUTUBER.txt").ToList()
        Dim somewhereInEurope As List(Of String) = File.ReadAllLines("E:\Visual Basic\Hanggaroo\Words\SOMEWHERE IN EUROPE.txt").ToList()
        Dim luxuryBrands As List(Of String) = File.ReadAllLines("E:\Visual Basic\Hanggaroo\Words\LUXURY BRAND.txt").ToList()
        Dim edsheeransong As List(Of String) = File.ReadAllLines("E:\Visual Basic\Hanggaroo\Words\ED SHEERAN SONG.txt").ToList()
        Dim romancedramamovie As List(Of String) = File.ReadAllLines("E:\Visual Basic\Hanggaroo\Words\A ROMANCE DRAMA MOVIE.txt").ToList()

        question = questions(random.Next(questions.Length))
        lblQuestion.Text = question

        If question = "FAMOUS YOUTUBER" Then
            answer = GetUniqueAnswer(famousYoutubers)
        ElseIf question = "SOMEWHERE IN EUROPE" Then
            answer = GetUniqueAnswer(somewhereInEurope)
        ElseIf question = "LUXURY BRAND" Then
            answer = GetUniqueAnswer(luxuryBrands)
        ElseIf question = "ED SHEERAN SONG" Then
            answer = GetUniqueAnswer(edsheeransong)
        ElseIf question = "A ROMANCE DRAMA MOVIE" Then
            answer = GetUniqueAnswer(romancedramamovie)
        End If

        If lblQuestion.Text = "YOU BEAT THE GAME" Then
            DisableKeys()
            usedAnswers.Clear()
        End If

        LetterInitializer(answer)
    End Sub

    Private Function GetUniqueAnswer(ByVal answerList As List(Of String)) As String
        Dim availableAnswers = answerList.Except(usedAnswers).ToList()

        If availableAnswers.Count > 0 Then
            Dim uniqueAnswer As String = availableAnswers(random.Next(availableAnswers.Count))
            usedAnswers.Add(uniqueAnswer)
            Return uniqueAnswer
        Else
            lblQuestion.Text = "YOU BEAT THE GAME"
        End If

        Return ""
    End Function

    Private Sub start()

        InitializeGame()
        btnInitialize.Text = "RESET"
        EnableKeys()
        ResetScore()
        usedAnswers.Clear()

    End Sub

    Private Sub GiveUp()

        If MessageBox.Show("Are you sure you want to reset the game?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            While pnlGuessLetters.Controls.OfType(Of Label)().Any()
                pnlGuessLetters.Controls.Remove(pnlGuessLetters.Controls.OfType(Of Label)().First())
            End While

            DisableKeys()
            UpdateStat()
            ResetLife()
            Tally()
            ClearLetters()
            lblQuestion.Text = ""
            btnInitialize.Text = "START"

        End If

    End Sub

    Private Sub btnInitialize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInitialize.Click

        If btnInitialize.Text = "START" Then
            start()

        ElseIf btnInitialize.Text = "RESET" Then
            GiveUp()

        End If
    End Sub

    Private Sub ClearLetters()

        While pnlGuessLetters.Controls.Count > 0
            pnlGuessLetters.Controls.RemoveAt(0)
        End While

    End Sub

    Private Sub LetterInitializer(ByVal answer As String)

        For Each lbl As Label In pnlGuessLetters.Controls.OfType(Of Label)()
            pnlGuessLetters.Controls.Remove(lbl)
            lbl.Dispose()
        Next

        Dim labels As New List(Of Label)
        Dim labelWidth As Integer = 30
        Dim totalWidth As Integer = answer.Length * (labelWidth + 5)
        Dim x As Integer = (pnlGuessLetters.Width - totalWidth) \ 2

        For i As Integer = 0 To answer.Length - 1
            Dim c As Char = answer(i)
            Dim lbl As New Label()
            lbl.Text = If(c = " ", " ", "_")
            lbl.Font = New Font("Arial", 14)
            lbl.TextAlign = ContentAlignment.MiddleCenter
            lbl.AutoSize = False
            lbl.Width = labelWidth
            lbl.Height = 30
            lbl.BorderStyle = BorderStyle.FixedSingle
            lbl.Location = New Point(x + i * (labelWidth + 5), 0)
            pnlGuessLetters.Controls.Add(lbl)

            lbl.Tag = c
        Next
    End Sub

    Private Sub HandleLetterButtonClick(ByVal letter As Char)
        Dim correctGuess As Boolean = False

        For Each lbl As Label In pnlGuessLetters.Controls.OfType(Of Label)()
            If lbl.Tag = letter Then
                lbl.Text = letter
                correctGuess = True
            End If
        Next

        If Not correctGuess Then
            misses += 1
            lblAttempts.Text = misses & " / " & 5
            If misses >= 5 Then
                If MessageBox.Show("Your naiveness made an expense to one's life. Take note of that.", "YOU LOSE", MessageBoxButtons.OK, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                    DisableKeys()
                    ClearLetters()
                    Tally()
                    lblQuestion.Text = ""
                    btnInitialize.Text = "START"
                End If
            End If
        Else
            If pnlGuessLetters.Controls.OfType(Of Label)().All(Function(lbl) lbl.Text <> "_") Then
                ScoreBoard()

                If MessageBox.Show("Congratulations! You've guessed the word.", "YOU'RE RIGHT!", MessageBoxButtons.OK, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                    EnableKeys()
                    ClearLetters()
                    lblQuestion.Text = ""
                    InitializeGame()
                    btnInitialize.Text = "RESET"
                End If
            End If
        End If
    End Sub

    Private Sub Tally()

        Dim NewScore As Integer

        NewScore = score
        lblScore.Text = NewScore

        TopScore()

    End Sub

    Private Sub ScoreBoard()

        score += 10
        lblScore.Text = score

    End Sub

    Private Sub ResetScore()

        score = 0
        lblScore.Text = score

    End Sub

    Private Sub TopScore()

        Dim newScore As Integer = Integer.Parse(lblScore.Text)

        If newScore > My.Settings.TopScore Then

            My.Settings.PlayerName = InputBox("You had the highest score! Please input your name:")
            lblPlayer.Text = My.Settings.PlayerName

            My.Settings.TopScore = newScore
            My.Settings.Save()

            score = 0
            UpdateStat()

        End If

    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.F1 Then
            My.Settings.TopScore = 0
            My.Settings.PlayerName = "-"
            My.Settings.Save()

            lblHighScore.Text = 0
            lblPlayer.Text = "-"
            score = 0
            lblScore.Text = score
        End If

        If e.KeyCode = Keys.A Then
            Dim letter As Char = "A"
            Call LetterButton_Click(btnA, e)
        End If

        If e.KeyCode = Keys.B Then
            Dim letter As Char = "B"
            Call LetterButton_Click(btnB, e)
        End If

        If e.KeyCode = Keys.C Then
            Dim letter As Char = "C"
            Call LetterButton_Click(btnC, e)
        End If

        If e.KeyCode = Keys.D Then
            Dim letter As Char = "D"
            Call LetterButton_Click(btnD, e)
        End If

        If e.KeyCode = Keys.E Then
            Dim letter As Char = "E"
            Call LetterButton_Click(btnE, e)
        End If

        If e.KeyCode = Keys.F Then
            Dim letter As Char = "F"
            Call LetterButton_Click(btnF, e)
        End If

        If e.KeyCode = Keys.G Then
            Dim letter As Char = "G"
            Call LetterButton_Click(btnG, e)
        End If

        If e.KeyCode = Keys.H Then
            Dim letter As Char = "H"
            Call LetterButton_Click(btnH, e)
        End If

        If e.KeyCode = Keys.I Then
            Dim letter As Char = "I"
            Call LetterButton_Click(btnI, e)
        End If

        If e.KeyCode = Keys.J Then
            Dim letter As Char = "J"
            Call LetterButton_Click(btnJ, e)
        End If

        If e.KeyCode = Keys.K Then
            Dim letter As Char = "K"
            Call LetterButton_Click(btnK, e)
        End If

        If e.KeyCode = Keys.L Then
            Dim letter As Char = "L"
            Call LetterButton_Click(btnL, e)
        End If

        If e.KeyCode = Keys.M Then
            Dim letter As Char = "M"
            Call LetterButton_Click(btnM, e)
        End If

        If e.KeyCode = Keys.N Then
            Dim letter As Char = "N"
            Call LetterButton_Click(btnN, e)
        End If

        If e.KeyCode = Keys.O Then
            Dim letter As Char = "O"
            Call LetterButton_Click(btnO, e)
        End If

        If e.KeyCode = Keys.P Then
            Dim letter As Char = "P"
            Call LetterButton_Click(btnP, e)
        End If

        If e.KeyCode = Keys.Q Then
            Dim letter As Char = "Q"
            Call LetterButton_Click(btnQ, e)
        End If

        If e.KeyCode = Keys.R Then
            Dim letter As Char = "R"
            Call LetterButton_Click(btnR, e)
        End If

        If e.KeyCode = Keys.S Then
            Dim letter As Char = "S"
            Call LetterButton_Click(btnS, e)
        End If

        If e.KeyCode = Keys.T Then
            Dim letter As Char = "T"
            Call LetterButton_Click(btnT, e)
        End If

        If e.KeyCode = Keys.U Then
            Dim letter As Char = "U"
            Call LetterButton_Click(btnU, e)
        End If

        If e.KeyCode = Keys.V Then
            Dim letter As Char = "V"
            Call LetterButton_Click(btnV, e)
        End If

        If e.KeyCode = Keys.W Then
            Dim letter As Char = "W"
            Call LetterButton_Click(btnW, e)
        End If

        If e.KeyCode = Keys.X Then
            Dim letter As Char = "X"
            Call LetterButton_Click(btnX, e)
        End If

        If e.KeyCode = Keys.Y Then
            Dim letter As Char = "Y"
            Call LetterButton_Click(btnY, e)
        End If

        If e.KeyCode = Keys.Z Then
            Dim letter As Char = "Z"
            Call LetterButton_Click(btnZ, e)
        End If

    End Sub

    Private Sub LetterButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnA.Click, btnB.Click, btnC.Click, btnD.Click, btnE.Click, btnF.Click, btnG.Click, btnH.Click, btnI.Click, btnJ.Click, btnK.Click, btnL.Click, btnM.Click, btnN.Click, btnO.Click, btnP.Click, btnQ.Click, btnR.Click, btnS.Click, btnT.Click, btnU.Click, btnV.Click, btnW.Click, btnX.Click, btnY.Click, btnZ.Click
        Dim btn As Button = CType(sender, Button)
        Dim letter As Char = btn.Text(0)
        btn.Enabled = False

        HandleLetterButtonClick(letter)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DisableKeys()
        SetTabStopForControls(Me, False)
        Me.ActiveControl = Nothing

        UpdateStat()

    End Sub

    Private Sub UpdateStat()

        lblHighScore.Text = My.Settings.TopScore.ToString()
        lblPlayer.Text = My.Settings.PlayerName.ToString()

    End Sub

    Private Sub SetTabStopForControls(ByVal container As Control, ByVal tabStop As Boolean)
        For Each control As Control In container.Controls
            control.TabStop = tabStop

            If control.HasChildren Then
                SetTabStopForControls(control, tabStop)
            End If
        Next
    End Sub

    Private Sub DisableKeys()

        For Each ctrl As Control In pnlLetters.Controls
            If TypeOf ctrl Is Button Then
                ctrl.Enabled = False
                misses = 0
            End If
        Next
    End Sub

    Private Sub EnableKeys()

        For Each ctrl As Control In pnlLetters.Controls
            If TypeOf ctrl Is Button Then
                ctrl.Enabled = True
                misses = 0
            End If
        Next
    End Sub

    Private Sub ResetLife()

        lblAttempts.Text = 0 & " / 5"
    End Sub
End Class