<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Game
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
        Me.Start = New System.Windows.Forms.Button()
        Me.ArrowTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SequenceNum = New System.Windows.Forms.Label()
        Me.GOLab = New System.Windows.Forms.Label()
        Me.GOTimer = New System.Windows.Forms.Timer(Me.components)
        Me.InputNumUpto1 = New System.Windows.Forms.Label()
        Me.InputNumUpto2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.health1pc = New System.Windows.Forms.Label()
        Me.Health1 = New System.Windows.Forms.Label()
        Me.Health2 = New System.Windows.Forms.Label()
        Me.health2pc = New System.Windows.Forms.Label()
        Me.PlayerBox2 = New System.Windows.Forms.PictureBox()
        Me.PlayerBox1 = New System.Windows.Forms.PictureBox()
        Me.DOWN1 = New System.Windows.Forms.PictureBox()
        Me.UP1 = New System.Windows.Forms.PictureBox()
        Me.RIGHT1 = New System.Windows.Forms.PictureBox()
        Me.LEFT1 = New System.Windows.Forms.PictureBox()
        Me.DOWN2 = New System.Windows.Forms.PictureBox()
        Me.UP2 = New System.Windows.Forms.PictureBox()
        Me.RIGHT2 = New System.Windows.Forms.PictureBox()
        Me.LEFT2 = New System.Windows.Forms.PictureBox()
        Me.ArrowBox2 = New System.Windows.Forms.PictureBox()
        Me.ArrowBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ArrowBox3 = New System.Windows.Forms.PictureBox()
        Me.ArrowBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.P1Box = New System.Windows.Forms.PictureBox()
        Me.P2Box = New System.Windows.Forms.PictureBox()
        Me.LaserBox = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Correct1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Correct2 = New System.Windows.Forms.Label()
        CType(Me.PlayerBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DOWN1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UP1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RIGHT1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LEFT1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DOWN2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UP2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RIGHT2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LEFT2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArrowBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArrowBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArrowBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArrowBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.P1Box, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.P2Box, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LaserBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Start
        '
        Me.Start.Location = New System.Drawing.Point(1171, 12)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(91, 29)
        Me.Start.TabIndex = 1
        Me.Start.Text = "START"
        Me.Start.UseVisualStyleBackColor = True
        '
        'ArrowTimer
        '
        Me.ArrowTimer.Interval = 1000
        '
        'SequenceNum
        '
        Me.SequenceNum.AutoSize = True
        Me.SequenceNum.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SequenceNum.ForeColor = System.Drawing.Color.Magenta
        Me.SequenceNum.Location = New System.Drawing.Point(617, 647)
        Me.SequenceNum.Name = "SequenceNum"
        Me.SequenceNum.Size = New System.Drawing.Size(25, 31)
        Me.SequenceNum.TabIndex = 10
        Me.SequenceNum.Text = "0"
        '
        'GOLab
        '
        Me.GOLab.AutoSize = True
        Me.GOLab.Font = New System.Drawing.Font("Agency FB", 51.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GOLab.ForeColor = System.Drawing.Color.Lime
        Me.GOLab.Location = New System.Drawing.Point(579, 543)
        Me.GOLab.Name = "GOLab"
        Me.GOLab.Size = New System.Drawing.Size(115, 83)
        Me.GOLab.TabIndex = 15
        Me.GOLab.Text = "GO!"
        Me.GOLab.Visible = False
        '
        'GOTimer
        '
        Me.GOTimer.Interval = 1000
        '
        'InputNumUpto1
        '
        Me.InputNumUpto1.AutoSize = True
        Me.InputNumUpto1.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputNumUpto1.ForeColor = System.Drawing.Color.Magenta
        Me.InputNumUpto1.Location = New System.Drawing.Point(98, 646)
        Me.InputNumUpto1.Name = "InputNumUpto1"
        Me.InputNumUpto1.Size = New System.Drawing.Size(25, 31)
        Me.InputNumUpto1.TabIndex = 16
        Me.InputNumUpto1.Text = "0"
        '
        'InputNumUpto2
        '
        Me.InputNumUpto2.AutoSize = True
        Me.InputNumUpto2.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputNumUpto2.ForeColor = System.Drawing.Color.Magenta
        Me.InputNumUpto2.Location = New System.Drawing.Point(1139, 646)
        Me.InputNumUpto2.Name = "InputNumUpto2"
        Me.InputNumUpto2.Size = New System.Drawing.Size(25, 31)
        Me.InputNumUpto2.TabIndex = 17
        Me.InputNumUpto2.Text = "0"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 29)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "EXIT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(113, 558)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 28)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Label1"
        '
        'health1pc
        '
        Me.health1pc.AutoSize = True
        Me.health1pc.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.health1pc.ForeColor = System.Drawing.Color.Lime
        Me.health1pc.Location = New System.Drawing.Point(158, 555)
        Me.health1pc.Name = "health1pc"
        Me.health1pc.Size = New System.Drawing.Size(30, 31)
        Me.health1pc.TabIndex = 21
        Me.health1pc.Text = "%"
        '
        'Health1
        '
        Me.Health1.AutoSize = True
        Me.Health1.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Health1.ForeColor = System.Drawing.Color.Lime
        Me.Health1.Location = New System.Drawing.Point(120, 555)
        Me.Health1.Name = "Health1"
        Me.Health1.Size = New System.Drawing.Size(41, 31)
        Me.Health1.TabIndex = 22
        Me.Health1.Text = "100"
        '
        'Health2
        '
        Me.Health2.AutoSize = True
        Me.Health2.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Health2.ForeColor = System.Drawing.Color.Lime
        Me.Health2.Location = New System.Drawing.Point(1084, 556)
        Me.Health2.Name = "Health2"
        Me.Health2.Size = New System.Drawing.Size(41, 31)
        Me.Health2.TabIndex = 24
        Me.Health2.Text = "100"
        Me.Health2.Visible = False
        '
        'health2pc
        '
        Me.health2pc.AutoSize = True
        Me.health2pc.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.health2pc.ForeColor = System.Drawing.Color.Lime
        Me.health2pc.Location = New System.Drawing.Point(1122, 556)
        Me.health2pc.Name = "health2pc"
        Me.health2pc.Size = New System.Drawing.Size(30, 31)
        Me.health2pc.TabIndex = 23
        Me.health2pc.Text = "%"
        Me.health2pc.Visible = False
        '
        'PlayerBox2
        '
        Me.PlayerBox2.Image = Global.Memory_Game.My.Resources.Resources.red_image
        Me.PlayerBox2.Location = New System.Drawing.Point(1171, 551)
        Me.PlayerBox2.Name = "PlayerBox2"
        Me.PlayerBox2.Size = New System.Drawing.Size(81, 118)
        Me.PlayerBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PlayerBox2.TabIndex = 27
        Me.PlayerBox2.TabStop = False
        '
        'PlayerBox1
        '
        Me.PlayerBox1.Image = Global.Memory_Game.My.Resources.Resources.blue_image
        Me.PlayerBox1.Location = New System.Drawing.Point(11, 551)
        Me.PlayerBox1.Name = "PlayerBox1"
        Me.PlayerBox1.Size = New System.Drawing.Size(81, 118)
        Me.PlayerBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PlayerBox1.TabIndex = 26
        Me.PlayerBox1.TabStop = False
        '
        'DOWN1
        '
        Me.DOWN1.BackColor = System.Drawing.Color.Transparent
        Me.DOWN1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DOWN1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DOWN1.Image = Global.Memory_Game.My.Resources.Resources.DownArrow4
        Me.DOWN1.Location = New System.Drawing.Point(108, 442)
        Me.DOWN1.Name = "DOWN1"
        Me.DOWN1.Size = New System.Drawing.Size(80, 80)
        Me.DOWN1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DOWN1.TabIndex = 12
        Me.DOWN1.TabStop = False
        '
        'UP1
        '
        Me.UP1.BackColor = System.Drawing.Color.Transparent
        Me.UP1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UP1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UP1.Image = Global.Memory_Game.My.Resources.Resources.UpArrow4
        Me.UP1.Location = New System.Drawing.Point(108, 354)
        Me.UP1.Name = "UP1"
        Me.UP1.Size = New System.Drawing.Size(80, 80)
        Me.UP1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.UP1.TabIndex = 11
        Me.UP1.TabStop = False
        '
        'RIGHT1
        '
        Me.RIGHT1.BackColor = System.Drawing.Color.Transparent
        Me.RIGHT1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RIGHT1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RIGHT1.Image = Global.Memory_Game.My.Resources.Resources.ArrowRight4
        Me.RIGHT1.Location = New System.Drawing.Point(193, 404)
        Me.RIGHT1.Name = "RIGHT1"
        Me.RIGHT1.Size = New System.Drawing.Size(80, 80)
        Me.RIGHT1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RIGHT1.TabIndex = 14
        Me.RIGHT1.TabStop = False
        '
        'LEFT1
        '
        Me.LEFT1.BackColor = System.Drawing.Color.Transparent
        Me.LEFT1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LEFT1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LEFT1.Image = Global.Memory_Game.My.Resources.Resources.ArrowLeft4
        Me.LEFT1.Location = New System.Drawing.Point(22, 404)
        Me.LEFT1.Name = "LEFT1"
        Me.LEFT1.Size = New System.Drawing.Size(80, 80)
        Me.LEFT1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LEFT1.TabIndex = 13
        Me.LEFT1.TabStop = False
        '
        'DOWN2
        '
        Me.DOWN2.BackColor = System.Drawing.Color.Transparent
        Me.DOWN2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DOWN2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DOWN2.Image = Global.Memory_Game.My.Resources.Resources.DownArrow
        Me.DOWN2.Location = New System.Drawing.Point(1072, 442)
        Me.DOWN2.Name = "DOWN2"
        Me.DOWN2.Size = New System.Drawing.Size(80, 80)
        Me.DOWN2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DOWN2.TabIndex = 7
        Me.DOWN2.TabStop = False
        Me.DOWN2.Visible = False
        '
        'UP2
        '
        Me.UP2.BackColor = System.Drawing.Color.Transparent
        Me.UP2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UP2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UP2.Image = Global.Memory_Game.My.Resources.Resources.UpArrow
        Me.UP2.Location = New System.Drawing.Point(1072, 354)
        Me.UP2.Name = "UP2"
        Me.UP2.Size = New System.Drawing.Size(80, 80)
        Me.UP2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.UP2.TabIndex = 6
        Me.UP2.TabStop = False
        Me.UP2.Visible = False
        '
        'RIGHT2
        '
        Me.RIGHT2.BackColor = System.Drawing.Color.Transparent
        Me.RIGHT2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RIGHT2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RIGHT2.Image = Global.Memory_Game.My.Resources.Resources.ArrowRight
        Me.RIGHT2.Location = New System.Drawing.Point(1157, 404)
        Me.RIGHT2.Name = "RIGHT2"
        Me.RIGHT2.Size = New System.Drawing.Size(80, 80)
        Me.RIGHT2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RIGHT2.TabIndex = 9
        Me.RIGHT2.TabStop = False
        Me.RIGHT2.Visible = False
        '
        'LEFT2
        '
        Me.LEFT2.BackColor = System.Drawing.Color.Transparent
        Me.LEFT2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LEFT2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LEFT2.Image = Global.Memory_Game.My.Resources.Resources.ArrowLeft
        Me.LEFT2.Location = New System.Drawing.Point(986, 404)
        Me.LEFT2.Name = "LEFT2"
        Me.LEFT2.Size = New System.Drawing.Size(80, 80)
        Me.LEFT2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LEFT2.TabIndex = 8
        Me.LEFT2.TabStop = False
        Me.LEFT2.Visible = False
        '
        'ArrowBox2
        '
        Me.ArrowBox2.Image = Global.Memory_Game.My.Resources.Resources.DownArrow1
        Me.ArrowBox2.Location = New System.Drawing.Point(569, 147)
        Me.ArrowBox2.Name = "ArrowBox2"
        Me.ArrowBox2.Size = New System.Drawing.Size(118, 120)
        Me.ArrowBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ArrowBox2.TabIndex = 2
        Me.ArrowBox2.TabStop = False
        Me.ArrowBox2.Visible = False
        '
        'ArrowBox1
        '
        Me.ArrowBox1.Image = Global.Memory_Game.My.Resources.Resources.UpArrow1
        Me.ArrowBox1.Location = New System.Drawing.Point(569, 40)
        Me.ArrowBox1.Name = "ArrowBox1"
        Me.ArrowBox1.Size = New System.Drawing.Size(118, 120)
        Me.ArrowBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ArrowBox1.TabIndex = 0
        Me.ArrowBox1.TabStop = False
        Me.ArrowBox1.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Memory_Game.My.Resources.Resources.Screenbase1
        Me.PictureBox1.Location = New System.Drawing.Point(-4, 537)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1270, 160)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'ArrowBox3
        '
        Me.ArrowBox3.Image = Global.Memory_Game.My.Resources.Resources.ArrowRight1
        Me.ArrowBox3.Location = New System.Drawing.Point(669, 93)
        Me.ArrowBox3.Name = "ArrowBox3"
        Me.ArrowBox3.Size = New System.Drawing.Size(118, 120)
        Me.ArrowBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ArrowBox3.TabIndex = 4
        Me.ArrowBox3.TabStop = False
        Me.ArrowBox3.Visible = False
        '
        'ArrowBox4
        '
        Me.ArrowBox4.Image = Global.Memory_Game.My.Resources.Resources.ArrowLeft1
        Me.ArrowBox4.Location = New System.Drawing.Point(471, 93)
        Me.ArrowBox4.Name = "ArrowBox4"
        Me.ArrowBox4.Size = New System.Drawing.Size(118, 120)
        Me.ArrowBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ArrowBox4.TabIndex = 3
        Me.ArrowBox4.TabStop = False
        Me.ArrowBox4.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Memory_Game.My.Resources.Resources.ScreenTop
        Me.PictureBox2.Location = New System.Drawing.Point(1, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1262, 267)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 18
        Me.PictureBox2.TabStop = False
        '
        'P1Box
        '
        Me.P1Box.Image = Global.Memory_Game.My.Resources.Resources.blue_image
        Me.P1Box.Location = New System.Drawing.Point(292, 358)
        Me.P1Box.Name = "P1Box"
        Me.P1Box.Size = New System.Drawing.Size(187, 265)
        Me.P1Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.P1Box.TabIndex = 25
        Me.P1Box.TabStop = False
        '
        'P2Box
        '
        Me.P2Box.Image = Global.Memory_Game.My.Resources.Resources.red_image
        Me.P2Box.Location = New System.Drawing.Point(783, 358)
        Me.P2Box.Name = "P2Box"
        Me.P2Box.Size = New System.Drawing.Size(187, 265)
        Me.P2Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.P2Box.TabIndex = 28
        Me.P2Box.TabStop = False
        '
        'LaserBox
        '
        Me.LaserBox.Location = New System.Drawing.Point(472, 405)
        Me.LaserBox.Name = "LaserBox"
        Me.LaserBox.Size = New System.Drawing.Size(316, 78)
        Me.LaserBox.TabIndex = 29
        Me.LaserBox.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Cyan
        Me.Label2.Location = New System.Drawing.Point(210, 581)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 17)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Total Arrows Correct:"
        Me.Label2.Visible = False
        '
        'Correct1
        '
        Me.Correct1.AutoSize = True
        Me.Correct1.Font = New System.Drawing.Font("Agency FB", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Correct1.ForeColor = System.Drawing.Color.Cyan
        Me.Correct1.Location = New System.Drawing.Point(256, 605)
        Me.Correct1.Name = "Correct1"
        Me.Correct1.Size = New System.Drawing.Size(27, 35)
        Me.Correct1.TabIndex = 31
        Me.Correct1.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Cyan
        Me.Label4.Location = New System.Drawing.Point(937, 581)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 17)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Total Arrows Correct:"
        Me.Label4.Visible = False
        '
        'Correct2
        '
        Me.Correct2.AutoSize = True
        Me.Correct2.Font = New System.Drawing.Font("Agency FB", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Correct2.ForeColor = System.Drawing.Color.Cyan
        Me.Correct2.Location = New System.Drawing.Point(984, 605)
        Me.Correct2.Name = "Correct2"
        Me.Correct2.Size = New System.Drawing.Size(27, 35)
        Me.Correct2.TabIndex = 33
        Me.Correct2.Text = "0"
        '
        'Game
        '
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.Correct2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Correct1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LaserBox)
        Me.Controls.Add(Me.PlayerBox2)
        Me.Controls.Add(Me.PlayerBox1)
        Me.Controls.Add(Me.Health2)
        Me.Controls.Add(Me.health2pc)
        Me.Controls.Add(Me.Health1)
        Me.Controls.Add(Me.health1pc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.InputNumUpto2)
        Me.Controls.Add(Me.InputNumUpto1)
        Me.Controls.Add(Me.GOLab)
        Me.Controls.Add(Me.DOWN1)
        Me.Controls.Add(Me.UP1)
        Me.Controls.Add(Me.RIGHT1)
        Me.Controls.Add(Me.LEFT1)
        Me.Controls.Add(Me.SequenceNum)
        Me.Controls.Add(Me.DOWN2)
        Me.Controls.Add(Me.UP2)
        Me.Controls.Add(Me.RIGHT2)
        Me.Controls.Add(Me.LEFT2)
        Me.Controls.Add(Me.ArrowBox2)
        Me.Controls.Add(Me.ArrowBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ArrowBox3)
        Me.Controls.Add(Me.ArrowBox4)
        Me.Controls.Add(Me.Start)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.P1Box)
        Me.Controls.Add(Me.P2Box)
        Me.MaximizeBox = False
        Me.Name = "Game"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Memory Game"
        CType(Me.PlayerBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DOWN1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UP1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RIGHT1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LEFT1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DOWN2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UP2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RIGHT2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LEFT2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArrowBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArrowBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArrowBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArrowBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.P1Box, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.P2Box, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LaserBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ArrowBox1 As PictureBox
    Friend WithEvents Start As Button
    Friend WithEvents ArrowTimer As Timer
    Friend WithEvents ArrowBox2 As PictureBox
    Friend WithEvents ArrowBox4 As PictureBox
    Friend WithEvents ArrowBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DOWN2 As PictureBox
    Friend WithEvents UP2 As PictureBox
    Friend WithEvents RIGHT2 As PictureBox
    Friend WithEvents LEFT2 As PictureBox
    Friend WithEvents SequenceNum As Label
    Friend WithEvents DOWN1 As PictureBox
    Friend WithEvents UP1 As PictureBox
    Friend WithEvents RIGHT1 As PictureBox
    Friend WithEvents LEFT1 As PictureBox
    Friend WithEvents GOLab As Label
    Friend WithEvents GOTimer As Timer
    Friend WithEvents InputNumUpto1 As Label
    Friend WithEvents InputNumUpto2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents health1pc As Label
    Friend WithEvents Health1 As Label
    Friend WithEvents Health2 As Label
    Friend WithEvents health2pc As Label
    Friend WithEvents P1Box As PictureBox
    Friend WithEvents PlayerBox1 As PictureBox
    Friend WithEvents PlayerBox2 As PictureBox
    Friend WithEvents P2Box As PictureBox
    Friend WithEvents LaserBox As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Correct1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Correct2 As Label
End Class
