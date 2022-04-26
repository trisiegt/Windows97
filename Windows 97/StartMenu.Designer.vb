<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartMenu
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
        Me.btn_off = New System.Windows.Forms.Button()
        Me.btn_ie = New System.Windows.Forms.Button()
        Me.btn_mspaint = New System.Windows.Forms.Button()
        Me.btn_hxd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_off
        '
        Me.btn_off.Location = New System.Drawing.Point(69, 319)
        Me.btn_off.Name = "btn_off"
        Me.btn_off.Size = New System.Drawing.Size(75, 23)
        Me.btn_off.TabIndex = 0
        Me.btn_off.Text = "Off"
        Me.btn_off.UseVisualStyleBackColor = True
        '
        'btn_ie
        '
        Me.btn_ie.Location = New System.Drawing.Point(12, 12)
        Me.btn_ie.Name = "btn_ie"
        Me.btn_ie.Size = New System.Drawing.Size(75, 61)
        Me.btn_ie.TabIndex = 1
        Me.btn_ie.Text = "Internet" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Explorer" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btn_ie.UseVisualStyleBackColor = True
        '
        'btn_mspaint
        '
        Me.btn_mspaint.Location = New System.Drawing.Point(6, 79)
        Me.btn_mspaint.Name = "btn_mspaint"
        Me.btn_mspaint.Size = New System.Drawing.Size(81, 70)
        Me.btn_mspaint.TabIndex = 2
        Me.btn_mspaint.Text = "Paint"
        Me.btn_mspaint.UseVisualStyleBackColor = True
        '
        'btn_hxd
        '
        Me.btn_hxd.Location = New System.Drawing.Point(11, 163)
        Me.btn_hxd.Name = "btn_hxd"
        Me.btn_hxd.Size = New System.Drawing.Size(75, 70)
        Me.btn_hxd.TabIndex = 3
        Me.btn_hxd.Text = "HxD"
        Me.btn_hxd.UseVisualStyleBackColor = True
        '
        'StartMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(154, 342)
        Me.Controls.Add(Me.btn_hxd)
        Me.Controls.Add(Me.btn_mspaint)
        Me.Controls.Add(Me.btn_ie)
        Me.Controls.Add(Me.btn_off)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "StartMenu"
        Me.Text = "Hover Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_off As Button
    Friend WithEvents btn_ie As Button
    Friend WithEvents btn_mspaint As Button
    Friend WithEvents btn_hxd As Button
End Class
