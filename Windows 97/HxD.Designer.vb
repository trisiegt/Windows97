<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HxD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HxD))
        Me.tb_hex = New System.Windows.Forms.TextBox()
        Me.tb_decoded_hex = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'tb_hex
        '
        Me.tb_hex.Location = New System.Drawing.Point(41, 37)
        Me.tb_hex.Multiline = True
        Me.tb_hex.Name = "tb_hex"
        Me.tb_hex.ReadOnly = True
        Me.tb_hex.Size = New System.Drawing.Size(552, 344)
        Me.tb_hex.TabIndex = 0
        Me.tb_hex.Text = resources.GetString("tb_hex.Text")
        '
        'tb_decoded_hex
        '
        Me.tb_decoded_hex.Location = New System.Drawing.Point(640, 35)
        Me.tb_decoded_hex.Multiline = True
        Me.tb_decoded_hex.Name = "tb_decoded_hex"
        Me.tb_decoded_hex.ReadOnly = True
        Me.tb_decoded_hex.Size = New System.Drawing.Size(157, 346)
        Me.tb_decoded_hex.TabIndex = 1
        Me.tb_decoded_hex.Text = "Never gonna give" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "you up" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Never gonna let" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "you down" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Never gonna run" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "around and " &
    "des-" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ert you."
        '
        'HxD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tb_decoded_hex)
        Me.Controls.Add(Me.tb_hex)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "HxD"
        Me.Text = "HxD"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tb_hex As TextBox
    Friend WithEvents tb_decoded_hex As TextBox
End Class
