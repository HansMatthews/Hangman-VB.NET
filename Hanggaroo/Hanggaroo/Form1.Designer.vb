<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.pnlQuestion = New System.Windows.Forms.Panel
        Me.lblQuestion = New System.Windows.Forms.Label
        Me.pnlGuessLetters = New System.Windows.Forms.Panel
        Me.pnlLetters = New System.Windows.Forms.Panel
        Me.btnM = New System.Windows.Forms.Button
        Me.btnN = New System.Windows.Forms.Button
        Me.btnB = New System.Windows.Forms.Button
        Me.btnV = New System.Windows.Forms.Button
        Me.btnC = New System.Windows.Forms.Button
        Me.btnX = New System.Windows.Forms.Button
        Me.btnZ = New System.Windows.Forms.Button
        Me.btnL = New System.Windows.Forms.Button
        Me.btnK = New System.Windows.Forms.Button
        Me.btnJ = New System.Windows.Forms.Button
        Me.btnH = New System.Windows.Forms.Button
        Me.btnG = New System.Windows.Forms.Button
        Me.btnF = New System.Windows.Forms.Button
        Me.btnD = New System.Windows.Forms.Button
        Me.btnS = New System.Windows.Forms.Button
        Me.btnA = New System.Windows.Forms.Button
        Me.btnP = New System.Windows.Forms.Button
        Me.btnO = New System.Windows.Forms.Button
        Me.btnI = New System.Windows.Forms.Button
        Me.btnU = New System.Windows.Forms.Button
        Me.btnY = New System.Windows.Forms.Button
        Me.btnT = New System.Windows.Forms.Button
        Me.btnR = New System.Windows.Forms.Button
        Me.btnE = New System.Windows.Forms.Button
        Me.btnW = New System.Windows.Forms.Button
        Me.btnQ = New System.Windows.Forms.Button
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.btnInitialize = New System.Windows.Forms.Button
        Me.lblScore = New System.Windows.Forms.Label
        Me.lblHighScore = New System.Windows.Forms.Label
        Me.lblAttempts = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.label = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblPlayer = New System.Windows.Forms.Label
        Me.TableLayoutPanel1.SuspendLayout()
        Me.pnlQuestion.SuspendLayout()
        Me.pnlLetters.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.pnlQuestion, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.pnlGuessLetters, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.pnlLetters, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.56917!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.09878!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.10148!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.23057!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(784, 461)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'pnlQuestion
        '
        Me.pnlQuestion.Controls.Add(Me.lblQuestion)
        Me.pnlQuestion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlQuestion.Location = New System.Drawing.Point(3, 51)
        Me.pnlQuestion.Name = "pnlQuestion"
        Me.pnlQuestion.Size = New System.Drawing.Size(778, 118)
        Me.pnlQuestion.TabIndex = 1
        '
        'lblQuestion
        '
        Me.lblQuestion.BackColor = System.Drawing.Color.Transparent
        Me.lblQuestion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblQuestion.Location = New System.Drawing.Point(0, 0)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(778, 118)
        Me.lblQuestion.TabIndex = 0
        Me.lblQuestion.Text = "WELCOME TO HANGGAROO, KUNG SAAN MAMAMATAY ANG BUBU" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & """CLICK START ON THE TOP-LEF" & _
            "T SIDE"""
        Me.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlGuessLetters
        '
        Me.pnlGuessLetters.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGuessLetters.Location = New System.Drawing.Point(3, 175)
        Me.pnlGuessLetters.Name = "pnlGuessLetters"
        Me.pnlGuessLetters.Size = New System.Drawing.Size(778, 118)
        Me.pnlGuessLetters.TabIndex = 2
        '
        'pnlLetters
        '
        Me.pnlLetters.Controls.Add(Me.btnM)
        Me.pnlLetters.Controls.Add(Me.btnN)
        Me.pnlLetters.Controls.Add(Me.btnB)
        Me.pnlLetters.Controls.Add(Me.btnV)
        Me.pnlLetters.Controls.Add(Me.btnC)
        Me.pnlLetters.Controls.Add(Me.btnX)
        Me.pnlLetters.Controls.Add(Me.btnZ)
        Me.pnlLetters.Controls.Add(Me.btnL)
        Me.pnlLetters.Controls.Add(Me.btnK)
        Me.pnlLetters.Controls.Add(Me.btnJ)
        Me.pnlLetters.Controls.Add(Me.btnH)
        Me.pnlLetters.Controls.Add(Me.btnG)
        Me.pnlLetters.Controls.Add(Me.btnF)
        Me.pnlLetters.Controls.Add(Me.btnD)
        Me.pnlLetters.Controls.Add(Me.btnS)
        Me.pnlLetters.Controls.Add(Me.btnA)
        Me.pnlLetters.Controls.Add(Me.btnP)
        Me.pnlLetters.Controls.Add(Me.btnO)
        Me.pnlLetters.Controls.Add(Me.btnI)
        Me.pnlLetters.Controls.Add(Me.btnU)
        Me.pnlLetters.Controls.Add(Me.btnY)
        Me.pnlLetters.Controls.Add(Me.btnT)
        Me.pnlLetters.Controls.Add(Me.btnR)
        Me.pnlLetters.Controls.Add(Me.btnE)
        Me.pnlLetters.Controls.Add(Me.btnW)
        Me.pnlLetters.Controls.Add(Me.btnQ)
        Me.pnlLetters.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlLetters.Location = New System.Drawing.Point(3, 299)
        Me.pnlLetters.Name = "pnlLetters"
        Me.pnlLetters.Size = New System.Drawing.Size(778, 159)
        Me.pnlLetters.TabIndex = 3
        '
        'btnM
        '
        Me.btnM.Location = New System.Drawing.Point(493, 99)
        Me.btnM.Name = "btnM"
        Me.btnM.Size = New System.Drawing.Size(33, 31)
        Me.btnM.TabIndex = 25
        Me.btnM.Text = "M"
        Me.btnM.UseVisualStyleBackColor = True
        '
        'btnN
        '
        Me.btnN.Location = New System.Drawing.Point(454, 99)
        Me.btnN.Name = "btnN"
        Me.btnN.Size = New System.Drawing.Size(33, 31)
        Me.btnN.TabIndex = 24
        Me.btnN.Text = "N"
        Me.btnN.UseVisualStyleBackColor = True
        '
        'btnB
        '
        Me.btnB.Location = New System.Drawing.Point(415, 99)
        Me.btnB.Name = "btnB"
        Me.btnB.Size = New System.Drawing.Size(33, 31)
        Me.btnB.TabIndex = 23
        Me.btnB.Text = "B"
        Me.btnB.UseVisualStyleBackColor = True
        '
        'btnV
        '
        Me.btnV.Location = New System.Drawing.Point(376, 99)
        Me.btnV.Name = "btnV"
        Me.btnV.Size = New System.Drawing.Size(33, 31)
        Me.btnV.TabIndex = 22
        Me.btnV.Text = "V"
        Me.btnV.UseVisualStyleBackColor = True
        '
        'btnC
        '
        Me.btnC.Location = New System.Drawing.Point(337, 99)
        Me.btnC.Name = "btnC"
        Me.btnC.Size = New System.Drawing.Size(33, 31)
        Me.btnC.TabIndex = 21
        Me.btnC.Text = "C"
        Me.btnC.UseVisualStyleBackColor = True
        '
        'btnX
        '
        Me.btnX.Location = New System.Drawing.Point(298, 99)
        Me.btnX.Name = "btnX"
        Me.btnX.Size = New System.Drawing.Size(33, 31)
        Me.btnX.TabIndex = 20
        Me.btnX.Text = "X"
        Me.btnX.UseVisualStyleBackColor = True
        '
        'btnZ
        '
        Me.btnZ.Location = New System.Drawing.Point(259, 99)
        Me.btnZ.Name = "btnZ"
        Me.btnZ.Size = New System.Drawing.Size(33, 31)
        Me.btnZ.TabIndex = 19
        Me.btnZ.Text = "Z"
        Me.btnZ.UseVisualStyleBackColor = True
        '
        'btnL
        '
        Me.btnL.Location = New System.Drawing.Point(532, 62)
        Me.btnL.Name = "btnL"
        Me.btnL.Size = New System.Drawing.Size(33, 31)
        Me.btnL.TabIndex = 18
        Me.btnL.Text = "L"
        Me.btnL.UseVisualStyleBackColor = True
        '
        'btnK
        '
        Me.btnK.Location = New System.Drawing.Point(493, 62)
        Me.btnK.Name = "btnK"
        Me.btnK.Size = New System.Drawing.Size(33, 31)
        Me.btnK.TabIndex = 17
        Me.btnK.Text = "K"
        Me.btnK.UseVisualStyleBackColor = True
        '
        'btnJ
        '
        Me.btnJ.Location = New System.Drawing.Point(454, 62)
        Me.btnJ.Name = "btnJ"
        Me.btnJ.Size = New System.Drawing.Size(33, 31)
        Me.btnJ.TabIndex = 16
        Me.btnJ.Text = "J"
        Me.btnJ.UseVisualStyleBackColor = True
        '
        'btnH
        '
        Me.btnH.Location = New System.Drawing.Point(415, 62)
        Me.btnH.Name = "btnH"
        Me.btnH.Size = New System.Drawing.Size(33, 31)
        Me.btnH.TabIndex = 15
        Me.btnH.Text = "H"
        Me.btnH.UseVisualStyleBackColor = True
        '
        'btnG
        '
        Me.btnG.Location = New System.Drawing.Point(376, 62)
        Me.btnG.Name = "btnG"
        Me.btnG.Size = New System.Drawing.Size(33, 31)
        Me.btnG.TabIndex = 14
        Me.btnG.Text = "G"
        Me.btnG.UseVisualStyleBackColor = True
        '
        'btnF
        '
        Me.btnF.Location = New System.Drawing.Point(337, 62)
        Me.btnF.Name = "btnF"
        Me.btnF.Size = New System.Drawing.Size(33, 31)
        Me.btnF.TabIndex = 13
        Me.btnF.Text = "F"
        Me.btnF.UseVisualStyleBackColor = True
        '
        'btnD
        '
        Me.btnD.Location = New System.Drawing.Point(298, 62)
        Me.btnD.Name = "btnD"
        Me.btnD.Size = New System.Drawing.Size(33, 31)
        Me.btnD.TabIndex = 12
        Me.btnD.Text = "D"
        Me.btnD.UseVisualStyleBackColor = True
        '
        'btnS
        '
        Me.btnS.Location = New System.Drawing.Point(259, 62)
        Me.btnS.Name = "btnS"
        Me.btnS.Size = New System.Drawing.Size(33, 31)
        Me.btnS.TabIndex = 11
        Me.btnS.Text = "S"
        Me.btnS.UseVisualStyleBackColor = True
        '
        'btnA
        '
        Me.btnA.Location = New System.Drawing.Point(220, 62)
        Me.btnA.Name = "btnA"
        Me.btnA.Size = New System.Drawing.Size(33, 31)
        Me.btnA.TabIndex = 10
        Me.btnA.Text = "A"
        Me.btnA.UseVisualStyleBackColor = True
        '
        'btnP
        '
        Me.btnP.Location = New System.Drawing.Point(552, 25)
        Me.btnP.Name = "btnP"
        Me.btnP.Size = New System.Drawing.Size(33, 31)
        Me.btnP.TabIndex = 9
        Me.btnP.Text = "P"
        Me.btnP.UseVisualStyleBackColor = True
        '
        'btnO
        '
        Me.btnO.Location = New System.Drawing.Point(513, 25)
        Me.btnO.Name = "btnO"
        Me.btnO.Size = New System.Drawing.Size(33, 31)
        Me.btnO.TabIndex = 8
        Me.btnO.Text = "O"
        Me.btnO.UseVisualStyleBackColor = True
        '
        'btnI
        '
        Me.btnI.Location = New System.Drawing.Point(474, 25)
        Me.btnI.Name = "btnI"
        Me.btnI.Size = New System.Drawing.Size(33, 31)
        Me.btnI.TabIndex = 7
        Me.btnI.Text = "I"
        Me.btnI.UseVisualStyleBackColor = True
        '
        'btnU
        '
        Me.btnU.Location = New System.Drawing.Point(435, 25)
        Me.btnU.Name = "btnU"
        Me.btnU.Size = New System.Drawing.Size(33, 31)
        Me.btnU.TabIndex = 6
        Me.btnU.Text = "U"
        Me.btnU.UseVisualStyleBackColor = True
        '
        'btnY
        '
        Me.btnY.Location = New System.Drawing.Point(396, 25)
        Me.btnY.Name = "btnY"
        Me.btnY.Size = New System.Drawing.Size(33, 31)
        Me.btnY.TabIndex = 5
        Me.btnY.Text = "Y"
        Me.btnY.UseVisualStyleBackColor = True
        '
        'btnT
        '
        Me.btnT.Location = New System.Drawing.Point(357, 25)
        Me.btnT.Name = "btnT"
        Me.btnT.Size = New System.Drawing.Size(33, 31)
        Me.btnT.TabIndex = 4
        Me.btnT.Text = "T"
        Me.btnT.UseVisualStyleBackColor = True
        '
        'btnR
        '
        Me.btnR.Location = New System.Drawing.Point(318, 25)
        Me.btnR.Name = "btnR"
        Me.btnR.Size = New System.Drawing.Size(33, 31)
        Me.btnR.TabIndex = 3
        Me.btnR.Text = "R"
        Me.btnR.UseVisualStyleBackColor = True
        '
        'btnE
        '
        Me.btnE.Location = New System.Drawing.Point(279, 25)
        Me.btnE.Name = "btnE"
        Me.btnE.Size = New System.Drawing.Size(33, 31)
        Me.btnE.TabIndex = 2
        Me.btnE.Text = "E"
        Me.btnE.UseVisualStyleBackColor = True
        '
        'btnW
        '
        Me.btnW.Location = New System.Drawing.Point(240, 25)
        Me.btnW.Name = "btnW"
        Me.btnW.Size = New System.Drawing.Size(33, 31)
        Me.btnW.TabIndex = 1
        Me.btnW.Text = "W"
        Me.btnW.UseVisualStyleBackColor = True
        '
        'btnQ
        '
        Me.btnQ.Location = New System.Drawing.Point(201, 25)
        Me.btnQ.Name = "btnQ"
        Me.btnQ.Size = New System.Drawing.Size(33, 31)
        Me.btnQ.TabIndex = 0
        Me.btnQ.Text = "Q"
        Me.btnQ.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 5
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnInitialize, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblScore, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblHighScore, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblAttempts, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.label, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lblPlayer, 4, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(778, 42)
        Me.TableLayoutPanel2.TabIndex = 4
        '
        'btnInitialize
        '
        Me.btnInitialize.BackColor = System.Drawing.Color.Transparent
        Me.btnInitialize.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnInitialize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInitialize.Location = New System.Drawing.Point(3, 3)
        Me.btnInitialize.Name = "btnInitialize"
        Me.TableLayoutPanel2.SetRowSpan(Me.btnInitialize, 2)
        Me.btnInitialize.Size = New System.Drawing.Size(149, 36)
        Me.btnInitialize.TabIndex = 0
        Me.btnInitialize.Text = "START"
        Me.btnInitialize.UseVisualStyleBackColor = False
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.BackColor = System.Drawing.Color.Transparent
        Me.lblScore.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblScore.Location = New System.Drawing.Point(313, 0)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(149, 21)
        Me.lblScore.TabIndex = 2
        Me.lblScore.Text = "0"
        Me.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHighScore
        '
        Me.lblHighScore.AutoSize = True
        Me.lblHighScore.BackColor = System.Drawing.Color.Transparent
        Me.lblHighScore.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblHighScore.Location = New System.Drawing.Point(468, 0)
        Me.lblHighScore.Name = "lblHighScore"
        Me.lblHighScore.Size = New System.Drawing.Size(149, 21)
        Me.lblHighScore.TabIndex = 3
        Me.lblHighScore.Text = "0"
        Me.lblHighScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAttempts
        '
        Me.lblAttempts.AutoSize = True
        Me.lblAttempts.BackColor = System.Drawing.Color.Transparent
        Me.lblAttempts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblAttempts.Location = New System.Drawing.Point(158, 0)
        Me.lblAttempts.Name = "lblAttempts"
        Me.lblAttempts.Size = New System.Drawing.Size(149, 21)
        Me.lblAttempts.TabIndex = 1
        Me.lblAttempts.Text = "0 / 5"
        Me.lblAttempts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(313, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 21)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "SCORE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Dock = System.Windows.Forms.DockStyle.Fill
        Me.label.Location = New System.Drawing.Point(468, 21)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(149, 21)
        Me.label.TabIndex = 5
        Me.label.Text = "HIGHSCORE"
        Me.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(158, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 21)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "LIFE"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlayer
        '
        Me.lblPlayer.AutoSize = True
        Me.lblPlayer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPlayer.Location = New System.Drawing.Point(623, 0)
        Me.lblPlayer.Name = "lblPlayer"
        Me.TableLayoutPanel2.SetRowSpan(Me.lblPlayer, 2)
        Me.lblPlayer.Size = New System.Drawing.Size(152, 42)
        Me.lblPlayer.TabIndex = 7
        Me.lblPlayer.Text = "-"
        Me.lblPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(800, 500)
        Me.MinimumSize = New System.Drawing.Size(800, 500)
        Me.Name = "Form1"
        Me.Text = "HANGMAN"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.pnlQuestion.ResumeLayout(False)
        Me.pnlLetters.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnInitialize As System.Windows.Forms.Button
    Friend WithEvents pnlQuestion As System.Windows.Forms.Panel
    Friend WithEvents pnlGuessLetters As System.Windows.Forms.Panel
    Friend WithEvents pnlLetters As System.Windows.Forms.Panel
    Friend WithEvents btnP As System.Windows.Forms.Button
    Friend WithEvents btnO As System.Windows.Forms.Button
    Friend WithEvents btnI As System.Windows.Forms.Button
    Friend WithEvents btnU As System.Windows.Forms.Button
    Friend WithEvents btnY As System.Windows.Forms.Button
    Friend WithEvents btnT As System.Windows.Forms.Button
    Friend WithEvents btnR As System.Windows.Forms.Button
    Friend WithEvents btnE As System.Windows.Forms.Button
    Friend WithEvents btnW As System.Windows.Forms.Button
    Friend WithEvents btnQ As System.Windows.Forms.Button
    Friend WithEvents btnL As System.Windows.Forms.Button
    Friend WithEvents btnK As System.Windows.Forms.Button
    Friend WithEvents btnJ As System.Windows.Forms.Button
    Friend WithEvents btnH As System.Windows.Forms.Button
    Friend WithEvents btnG As System.Windows.Forms.Button
    Friend WithEvents btnF As System.Windows.Forms.Button
    Friend WithEvents btnD As System.Windows.Forms.Button
    Friend WithEvents btnS As System.Windows.Forms.Button
    Friend WithEvents btnA As System.Windows.Forms.Button
    Friend WithEvents btnM As System.Windows.Forms.Button
    Friend WithEvents btnN As System.Windows.Forms.Button
    Friend WithEvents btnB As System.Windows.Forms.Button
    Friend WithEvents btnV As System.Windows.Forms.Button
    Friend WithEvents btnC As System.Windows.Forms.Button
    Friend WithEvents btnX As System.Windows.Forms.Button
    Friend WithEvents btnZ As System.Windows.Forms.Button
    Friend WithEvents lblQuestion As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents lblHighScore As System.Windows.Forms.Label
    Friend WithEvents lblAttempts As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents label As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblPlayer As System.Windows.Forms.Label

End Class
