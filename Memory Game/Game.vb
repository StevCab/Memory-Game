Public Class Game
    Dim StringLength As Integer = 4
    Dim ArrayOutNumbers(StringLength), ArrayInNumbers(StringLength) As Integer
    Dim Count, CountGO, Input, CountIn, RC, LC, UC, DC, temp, hp1, hp2, p1corect, p2correct As Integer
    Dim Multi, StartIn As Boolean
    Dim Turn1 As Boolean = True


    Private Sub Start_Click(sender As Object, e As EventArgs) Handles Start.Click
        Array.Clear(ArrayOutNumbers, 0, ArrayOutNumbers.Length)
        GenerateString()


        StartIn = False
        Count = 0
        CountGO = 0
        SequenceNum.Text = StringLength
        InputNumUpto1.Text = 0

        CountIn = 0
        ArrowTimer.Start()


    End Sub

    Sub GenerateString()
        Dim Random As New Random

        For i = 0 To (StringLength - 1)
            ArrayOutNumbers(i) = Random.Next(1, 5)
        Next



    End Sub

    Private Sub ArrowTimer_Tick(sender As Object, e As EventArgs) Handles ArrowTimer.Tick
        'Resets arrows
        ArrowBox1.Image = My.Resources.UpArrow1
        ArrowBox2.Image = My.Resources.DownArrow1
        ArrowBox3.Image = My.Resources.ArrowRight1
        ArrowBox4.Image = My.Resources.ArrowLeft1
        ArrowBox1.Hide()
        ArrowBox2.Hide()
        ArrowBox3.Hide()
        ArrowBox4.Hide()

        'If reached max, sequence stop
        If Count = StringLength + 1 Then
            ArrowBox1.Hide()
            ArrowBox2.Hide()
            ArrowBox3.Hide()
            ArrowBox4.Hide()
            ArrowTimer.Stop()
            UserInput()

        Else
            'If there are duplicate
            If ArrayOutNumbers(Count) = temp Then
                'Select what duplicate arrow to show
                If temp = 1 Then
                    'Count of current Up arrows in sequence hashed to a value
                    Select Case UC Mod 2
                        Case 1
                            ArrowBox1.Image = My.Resources.UpArrow2
                        Case 0
                            ArrowBox1.Image = My.Resources.UpArrow3
                    End Select
                    UC += 1
                ElseIf temp = 2 Then
                    Select Case DC Mod 2
                        Case 1
                            ArrowBox2.Image = My.Resources.DownArrow2
                        Case 0
                            ArrowBox2.Image = My.Resources.DownArrow3
                    End Select
                    DC += 1
                ElseIf temp = 3 Then
                    Select Case RC Mod 2
                        Case 1
                            ArrowBox3.Image = My.Resources.ArrowRight2
                        Case 0
                            ArrowBox3.Image = My.Resources.ArrowRight3
                    End Select
                    RC += 1
                ElseIf temp = 4 Then
                    Select Case LC Mod 2
                        Case 1
                            ArrowBox4.Image = My.Resources.ArrowLeft2
                        Case 0
                            ArrowBox4.Image = My.Resources.ArrowLeft3
                    End Select
                    LC += 1
                End If
            Else
                'If there are no duplicates in sequence, counts are reset
                DC = 0
                UC = 0
                LC = 0
                RC = 0
            End If

            If ArrayOutNumbers(Count) = 1 Then
                ArrowBox4.Hide()
                ArrowBox2.Hide()
                ArrowBox3.Hide()
                ArrowBox1.Show()
                temp = 1

            ElseIf ArrayOutNumbers(Count) = 2 Then

                ArrowBox4.Hide()
                ArrowBox1.Hide()
                ArrowBox3.Hide()
                ArrowBox2.Show()
                temp = 2

            ElseIf ArrayOutNumbers(Count) = 3 Then

                ArrowBox4.Hide()
                ArrowBox2.Hide()
                ArrowBox1.Hide()
                ArrowBox3.Show()
                temp = 3

            ElseIf ArrayOutNumbers(Count) = 4 Then

                ArrowBox1.Hide()
                ArrowBox2.Hide()
                ArrowBox3.Hide()
                ArrowBox4.Show()
                temp = 4

            End If

            Count += 1
        End If



    End Sub

    Private Sub ArrowBox3_Click(sender As Object, e As EventArgs) Handles ArrowBox3.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub ArrowBox1_Click(sender As Object, e As EventArgs) Handles ArrowBox1.Click

    End Sub



    Private Sub ArrowBox2_Click(sender As Object, e As EventArgs) Handles ArrowBox2.Click

    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RIGHT1_Click(sender As Object, e As EventArgs) Handles RIGHT1.Click
        If StartIn = False Then



        Else
            If Turn1 = True Then

                If CountIn = StringLength - 1 Then
                    InputNumUpto1.Text = StringLength
                    ArrayInNumbers(StringLength - 1) = 3


                    System.Threading.Thread.Sleep(500)
                    Check()
                Else

                    ArrayInNumbers(CountIn) = 3

                    CountIn += 1
                    InputNumUpto1.Text += 1




                End If
            Else
            End If
        End If
    End Sub

    Private Sub LEFT1_Click(sender As Object, e As EventArgs) Handles LEFT1.Click
        If StartIn = False Then



        Else
            If Turn1 = True Then

                If CountIn = StringLength - 1 Then
                    InputNumUpto1.Text = StringLength
                    ArrayInNumbers(StringLength - 1) = 4


                    System.Threading.Thread.Sleep(500)
                    Check()
                Else

                    ArrayInNumbers(CountIn) = 4

                    CountIn += 1
                    InputNumUpto1.Text += 1




                End If
            Else
            End If
        End If
    End Sub

    Private Sub GOLab_Click(sender As Object, e As EventArgs) Handles GOLab.Click

    End Sub

    Private Sub SequenceNum_Click(sender As Object, e As EventArgs) Handles SequenceNum.Click

    End Sub

    Private Sub ArrowBox4_Click(sender As Object, e As EventArgs) Handles ArrowBox4.Click

    End Sub

    Private Sub InputNumUpto1_Click(sender As Object, e As EventArgs) Handles InputNumUpto1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgBox("Are you sure you want to exit?", vbYesNo + vbQuestion, "Exit") = vbYes Then
            Me.Hide()
            Memory_Game.Menu.Show()
        ElseIf vbNo Then
        End If

    End Sub

    Private Sub UP2_Click(sender As Object, e As EventArgs) Handles UP2.Click
        If StartIn = False Then



        Else
            If Turn1 = False Then

                If CountIn = StringLength - 1 Then
                    InputNumUpto1.Text = StringLength
                    ArrayInNumbers(StringLength - 1) = 1


                    System.Threading.Thread.Sleep(500)
                    Check()
                Else

                    ArrayInNumbers(CountIn) = 1

                    CountIn += 1
                    InputNumUpto1.Text += 1




                End If
            Else
            End If
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub DOWN2_Click(sender As Object, e As EventArgs) Handles DOWN2.Click
        If StartIn = False Then



        Else
            If Turn1 = False Then

                If CountIn = StringLength - 1 Then
                    InputNumUpto1.Text = StringLength
                    ArrayInNumbers(StringLength - 1) = 2


                    System.Threading.Thread.Sleep(500)
                    Check()
                Else

                    ArrayInNumbers(CountIn) = 2

                    CountIn += 1
                    InputNumUpto1.Text += 1




                End If
            Else
            End If
        End If
    End Sub

    Private Sub LEFT2_Click(sender As Object, e As EventArgs) Handles LEFT2.Click
        If StartIn = False Then



        Else
            If Turn1 = False Then

                If CountIn = StringLength - 1 Then
                    InputNumUpto1.Text = StringLength
                    ArrayInNumbers(StringLength - 1) = 4


                    System.Threading.Thread.Sleep(500)
                    Check()
                Else

                    ArrayInNumbers(CountIn) = 4

                    CountIn += 1
                    InputNumUpto1.Text += 1




                End If
            Else
            End If
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles P1Box.Click

    End Sub

    Private Sub RIGHT2_Click(sender As Object, e As EventArgs) Handles RIGHT2.Click
        If StartIn = False Then



        Else
            If Turn1 = False Then

                If CountIn = StringLength - 1 Then
                    InputNumUpto1.Text = StringLength
                    ArrayInNumbers(StringLength - 1) = 3


                    System.Threading.Thread.Sleep(500)
                    Check()
                Else

                    ArrayInNumbers(CountIn) = 3

                    CountIn += 1
                    InputNumUpto1.Text += 1




                End If
            Else
            End If
        End If
    End Sub

    Private Sub DOWN1_Click(sender As Object, e As EventArgs) Handles DOWN1.Click
        If StartIn = False Then



        Else
            If Turn1 = True Then

                If CountIn = StringLength - 1 Then
                    InputNumUpto1.Text = StringLength
                    ArrayInNumbers(StringLength - 1) = 2


                    System.Threading.Thread.Sleep(500)
                    Check()
                Else

                    ArrayInNumbers(CountIn) = 2

                    CountIn += 1
                    InputNumUpto1.Text += 1




                End If
            Else
            End If
        End If
    End Sub

    Private Sub UP1_Click(sender As Object, e As EventArgs) Handles UP1.Click
        If StartIn = False Then



        Else
            If Turn1 = True Then

                If CountIn = StringLength - 1 Then
                    InputNumUpto1.Text = StringLength
                    ArrayInNumbers(StringLength - 1) = 1


                    System.Threading.Thread.Sleep(500)
                    Check()
                Else

                    ArrayInNumbers(CountIn) = 1

                    CountIn += 1
                    InputNumUpto1.Text += 1




                End If
            Else
            End If
        End If
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GOTimer_Tick(sender As Object, e As EventArgs) Handles GOTimer.Tick
        GOLab.Show()
        CountGO += 1

        If CountGO = 2 Then
            GOLab.Hide()
            GOTimer.Stop()
            StartIn = True
        End If

    End Sub

    Sub UserInput()
        CountIn = 0
        GOTimer.Start()





























    End Sub

    Sub Check()
        Dim score As Integer
        score = 0
        For i = 0 To StringLength - 1
            If ArrayInNumbers(i) = ArrayOutNumbers(i) Then
                score += 1
            Else
                score = score
            End If
        Next
        If Turn1 = True Then
            p1corect += score
        Else

        End If
        Battle(score)




    End Sub

    Function CalculateMyHealth(ByRef score As Integer)
        Dim h As Integer

        If Multi = True Then
            h = score * 1
            Return h
        Else
            h = ((StringLength * 10) / (score * 10))
            Return h
        End If



    End Function
    Function CalculateOpHealth(ByRef score As Integer)
        Dim h As Integer

        If Multi = True Then
            h = ((StringLength * 10) / (score * 10))
            Return h
        Else
            h = score * 1
            Return h
        End If




    End Function

    Sub Battle(ByRef score As Integer)
        If Multi = True Then

            If Turn1 = True Then
                '(animation)



                hp1 = CalculateMyHealth(score)
                hp2 = hp2 - CalculateOpHealth(score)
            Else

                'animation2
                hp2 = CalculateMyHealth(score)
                hp1 = hp1 - CalculateOpHealth(score)

            End If
        Else
            hp1 = hp1 - CalculateMyHealth(score) + 2
        End If



    End Sub

    Sub AssignValues()





    End Sub

End Class
