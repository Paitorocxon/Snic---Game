Imports Toecramp_Engine.engine.rendering
Imports Toecramp_Engine.engine.physics
Imports System.ComponentModel

Public Class Form1

    Public isgame As Boolean = True
    Public coins As Integer = 0

    Public Isit As Boolean = True
    Public walk As Boolean = True

    Public grounding As Integer = 0

    Public l As Integer = 880

    Public render As New Toecramp_Engine.engine.rendering
    Public physic As New Toecramp_Engine.engine.physics
    Public sounds As New Toecramp_Engine.MultiSounds

    Public jumpbuffer As Integer = 0

    Public jumping As Boolean = 0
    Public jumpstate As Integer = 0

    Dim bgthread As New System.Threading.Thread(AddressOf r)
    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            Isit = False
        Else
            Isit = True
        End If
    End Sub

    Public Function r()
        While True
            If Isit Then
                render.ImageSize = gamescreen.Size
                render.re_initialize()

                render.clear()
                render.draw(My.Resources.background, 0, 0, 800, 400)
                render.draw(My.Resources.ground, 0 - grounding, 400, 800, 200)
                render.draw(My.Resources.ground, 800 - grounding, 400, 800, 200)

                render.draw(My.Resources.collision, l, 360, 32, 32)

                If walk = True Then
                    render.draw(My.Resources.snic, 200, 360 - jumpbuffer, My.Resources.snic.Width, My.Resources.snic.Height)
                Else
                    render.draw(My.Resources.snic_1, 200, 360 - jumpbuffer, My.Resources.snic.Width, My.Resources.snic.Height)
                End If

                Try
                    render.FPS_Label("Coins or what ever this is: " & coins)
                    render.render(gamescreen, render.ImageSize, render.ImageSize, 1)
                Catch ex As Exception
                    MsgBox("Game has crashed!")
                    End
                End Try
            End If
        End While
        Return 0
    End Function

    Private Sub animation_Tick(sender As Object, e As EventArgs) Handles animation.Tick
        If walk Then
            walk = False
        Else
            walk = True
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        sounds.AddSound("jump", "boing.mp3")
        bgthread.IsBackground = True
        bgthread.Start()
        My.Computer.Audio.Play(My.Resources.snic1, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        bgthread.Interrupt()
        bgthread.Abort()

    End Sub

    Private Sub ground_Tick(sender As Object, e As EventArgs) Handles ground.Tick
        grounding += 1
        If grounding = 800 Then
            grounding = 0
        End If
    End Sub


    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.Space
                jump()
        End Select
    End Sub

    Public Function jump()
        If Not jumping Then
            jumping = True
            sounds.Play("jump")
        End If
        Return 0
    End Function

    Private Sub jumptimer_Tick(sender As Object, e As EventArgs) Handles jumptimer.Tick
        If jumping Then
            If jumpstate = 0 Then
                If jumpbuffer <= 200 Then
                    jumpbuffer += 4
                Else
                    jumpstate = 1
                End If
            ElseIf jumpstate = 1 Then
                If jumpbuffer >= 0 Then
                    jumpbuffer -= 4
                Else
                    jumpstate = 0
                    jumping = False
                End If
            End If
        End If
    End Sub

    Private Sub coin_Tick(sender As Object, e As EventArgs) Handles coin.Tick
        If isgame Then
            l -= 2
            If l <= -100 Then
                l = 880
                coins += 1
            End If
        End If
    End Sub
End Class
