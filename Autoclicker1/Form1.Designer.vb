<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Run = New System.Windows.Forms.Button()
        Me.autotick = New System.Windows.Forms.Timer(Me.components)
        Me.Kill = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Run
        '
        Me.Run.Location = New System.Drawing.Point(12, 12)
        Me.Run.Name = "Run"
        Me.Run.Size = New System.Drawing.Size(96, 23)
        Me.Run.TabIndex = 0
        Me.Run.Text = "Start"
        Me.Run.UseVisualStyleBackColor = True
        '
        'autotick
        '
        '
        'Kill
        '
        Me.Kill.Enabled = False
        Me.Kill.Location = New System.Drawing.Point(12, 41)
        Me.Kill.Name = "Kill"
        Me.Kill.Size = New System.Drawing.Size(96, 23)
        Me.Kill.TabIndex = 1
        Me.Kill.Text = "Stop"
        Me.Kill.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 70)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(70, 20)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = "100"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(88, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ms"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(120, 103)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Kill)
        Me.Controls.Add(Me.Run)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(136, 142)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(136, 142)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Autoclicker"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Run As Button
    Friend WithEvents autotick As Timer
    Friend WithEvents Kill As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
End Class
