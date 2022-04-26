<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class iexplore
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
        Me.tb_iexplore_url = New System.Windows.Forms.TextBox()
        Me.lbl_iexplore_rick = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tb_iexplore_url
        '
        Me.tb_iexplore_url.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.tb_iexplore_url.Location = New System.Drawing.Point(11, 7)
        Me.tb_iexplore_url.Name = "tb_iexplore_url"
        Me.tb_iexplore_url.ReadOnly = True
        Me.tb_iexplore_url.Size = New System.Drawing.Size(777, 23)
        Me.tb_iexplore_url.TabIndex = 0
        Me.tb_iexplore_url.Text = "trisiegt.co"
        '
        'lbl_iexplore_rick
        '
        Me.lbl_iexplore_rick.AutoSize = True
        Me.lbl_iexplore_rick.Location = New System.Drawing.Point(115, 122)
        Me.lbl_iexplore_rick.Name = "lbl_iexplore_rick"
        Me.lbl_iexplore_rick.Size = New System.Drawing.Size(150, 60)
        Me.lbl_iexplore_rick.TabIndex = 1
        Me.lbl_iexplore_rick.Text = "Never gonna give you up," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Never gonna let you down," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Never gonna run around," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and" &
    " desert you" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'iexplore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl_iexplore_rick)
        Me.Controls.Add(Me.tb_iexplore_url)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "iexplore"
        Me.Text = "Internet Explorer 6"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tb_iexplore_url As TextBox
    Friend WithEvents lbl_iexplore_rick As Label
End Class
