<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.gamescreen = New System.Windows.Forms.Panel()
        Me.animation = New System.Windows.Forms.Timer(Me.components)
        Me.ground = New System.Windows.Forms.Timer(Me.components)
        Me.jumptimer = New System.Windows.Forms.Timer(Me.components)
        Me.coin = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'gamescreen
        '
        Me.gamescreen.BackColor = System.Drawing.Color.Black
        Me.gamescreen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gamescreen.Location = New System.Drawing.Point(0, 0)
        Me.gamescreen.Name = "gamescreen"
        Me.gamescreen.Size = New System.Drawing.Size(800, 600)
        Me.gamescreen.TabIndex = 0
        '
        'animation
        '
        Me.animation.Enabled = True
        '
        'ground
        '
        Me.ground.Enabled = True
        Me.ground.Interval = 1
        '
        'jumptimer
        '
        Me.jumptimer.Enabled = True
        Me.jumptimer.Interval = 1
        '
        'coin
        '
        Me.coin.Enabled = True
        Me.coin.Interval = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.gamescreen)
        Me.MinimumSize = New System.Drawing.Size(816, 639)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Snic ze he... you know..."
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gamescreen As Panel
    Friend WithEvents animation As Timer
    Friend WithEvents ground As Timer
    Friend WithEvents jumptimer As Timer
    Friend WithEvents coin As Timer
End Class
