Public Class RadForm1
    Dim randommake, mode As Byte
    Public mySelectedPic As Telerik.WinControls.UI.RadPictureBox

    Private Sub RadForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mode = 1
        Call PickMode()
    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        Randomize()
        Do
            randommake = Rnd() * 6
        Loop Until randommake <> 0
        Call PickPicture(1)
        Call PickBackground(randommake, mySelectedPic)
        If mode <> 1 Then
            Dim cir As Byte
            For cir = 2 To mode
                Randomize()
                Do
                    randommake = Rnd() * 6
                Loop Until randommake <> 0
                Call PickPicture(cir)
                Call PickBackground(randommake, mySelectedPic)
            Next
        End If
    End Sub
    Sub PickBackground(e As Byte, myRealPic As Telerik.WinControls.UI.RadPictureBox)
        Select Case e
            Case Is = 1
                With myRealPic
                    .Image = My.Resources.DICE1
                End With
            Case Is = 2
                With myRealPic
                    .Image = My.Resources.DICE2
                End With
            Case Is = 3
                With myRealPic
                    .Image = My.Resources.DICE3
                End With
            Case Is = 4
                With myRealPic
                    .Image = My.Resources.DICE4
                End With
            Case Is = 5
                With myRealPic
                    .Image = My.Resources.DICE5
                End With
            Case Is = 6
                With myRealPic
                    .Image = My.Resources.DICE6
                End With
        End Select
    End Sub

    Private Sub NumericUpDown2_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown2.ValueChanged
        mode = NumericUpDown2.Value
        Call PickMode()
    End Sub

    Sub PickPicture(ap As Byte)
        Select Case ap
            Case Is = 1
                mySelectedPic = RadPictureBox1
            Case Is = 2
                mySelectedPic = RadPictureBox2
            Case Is = 3
                mySelectedPic = RadPictureBox3
            Case Is = 4
                mySelectedPic = RadPictureBox4
            Case Is = 5
                mySelectedPic = RadPictureBox5
            Case Is = 6
                mySelectedPic = RadPictureBox6
        End Select
    End Sub


    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        ShapedForm1.Show()
        LinkLabel1.LinkVisited = True
    End Sub

    Sub PickMode()
        Dim a, b, c, d, e, f As Point
        Select Case mode
            Case Is = 1
                a.X = 104
                a.Y = 54
                RadPictureBox1.Visible = True
                RadPictureBox2.Visible = False
                RadPictureBox3.Visible = False
                RadPictureBox4.Visible = False
                RadPictureBox5.Visible = False
                RadPictureBox6.Visible = False
                RadPictureBox1.Location = a
            Case Is = 2
                a.X = 37
                a.Y = 55
                b.X = 170
                b.Y = 55
                RadPictureBox1.Visible = True
                RadPictureBox2.Visible = True
                RadPictureBox3.Visible = False
                RadPictureBox4.Visible = False
                RadPictureBox5.Visible = False
                RadPictureBox6.Visible = False
                RadPictureBox1.Location = a
                RadPictureBox2.Location = b
            Case Is = 3
                c.X = 104
                c.Y = 105
                a.X = 37
                a.Y = 15
                b.X = 170
                b.Y = 15
                RadPictureBox1.Visible = True
                RadPictureBox2.Visible = True
                RadPictureBox3.Visible = True
                RadPictureBox4.Visible = False
                RadPictureBox5.Visible = False
                RadPictureBox6.Visible = False
                RadPictureBox1.Location = a
                RadPictureBox2.Location = b
                RadPictureBox3.Location = c
            Case Is = 4
                c.X = 39
                c.Y = 105
                d.X = 172
                d.Y = 105
                a.X = 37
                a.Y = 15
                b.X = 170
                b.Y = 15
                RadPictureBox1.Visible = True
                RadPictureBox2.Visible = True
                RadPictureBox3.Visible = True
                RadPictureBox4.Visible = True
                RadPictureBox5.Visible = False
                RadPictureBox6.Visible = False
                RadPictureBox1.Location = a
                RadPictureBox2.Location = b
                RadPictureBox3.Location = c
                RadPictureBox4.Location = d
            Case Is = 5
                c.X = 14
                c.Y = 105
                d.X = 104
                d.Y = 105
                e.X = 196
                e.Y = 105
                a.X = 37
                a.Y = 15
                b.X = 170
                b.Y = 15
                RadPictureBox1.Visible = True
                RadPictureBox2.Visible = True
                RadPictureBox3.Visible = True
                RadPictureBox4.Visible = True
                RadPictureBox5.Visible = True
                RadPictureBox6.Visible = False
                RadPictureBox1.Location = a
                RadPictureBox2.Location = b
                RadPictureBox3.Location = c
                RadPictureBox4.Location = d
                RadPictureBox5.Location = e
            Case Is = 6
                a.X = 14
                a.Y = 15
                b.X = 105
                b.Y = 15
                c.X = 196
                c.Y = 15
                d.X = 14
                d.Y = 105
                e.X = 104
                e.Y = 105
                f.X = 196
                f.Y = 105
                RadPictureBox1.Visible = True
                RadPictureBox2.Visible = True
                RadPictureBox3.Visible = True
                RadPictureBox4.Visible = True
                RadPictureBox5.Visible = True
                RadPictureBox6.Visible = True
                RadPictureBox1.Location = a
                RadPictureBox2.Location = b
                RadPictureBox3.Location = c
                RadPictureBox4.Location = d
                RadPictureBox5.Location = e
                RadPictureBox6.Location = f
        End Select
    End Sub
End Class
