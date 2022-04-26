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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_activatestart = New System.Windows.Forms.Button()
        Me.btn_desktop_iexplore = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 587)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1254, 50)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btn_activatestart
        '
        Me.btn_activatestart.Location = New System.Drawing.Point(12, 587)
        Me.btn_activatestart.Name = "btn_activatestart"
        Me.btn_activatestart.Size = New System.Drawing.Size(91, 50)
        Me.btn_activatestart.TabIndex = 1
        Me.btn_activatestart.Text = "Start"
        Me.btn_activatestart.UseVisualStyleBackColor = True
        '
        'btn_desktop_iexplore
        '
        Me.btn_desktop_iexplore.Image = CType(resources.GetObject("btn_desktop_iexplore.Image"), System.Drawing.Image)
        Me.btn_desktop_iexplore.Location = New System.Drawing.Point(43, 24)
        Me.btn_desktop_iexplore.Name = "btn_desktop_iexplore"
        Me.btn_desktop_iexplore.Size = New System.Drawing.Size(75, 72)
        Me.btn_desktop_iexplore.TabIndex = 2
        Me.btn_desktop_iexplore.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Internet Explorer"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(1273, 649)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_desktop_iexplore)
        Me.Controls.Add(Me.btn_activatestart)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Windows 97"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_activatestart As Button
    Friend WithEvents btn_desktop_iexplore As Button
    Friend WithEvents Label1 As Label
End Class
