<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.button_CreateNewEmployee = New System.Windows.Forms.Button()
        Me.Alorica_PictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.Alorica_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(47, 61)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'button_CreateNewEmployee
        '
        Me.button_CreateNewEmployee.Location = New System.Drawing.Point(12, 226)
        Me.button_CreateNewEmployee.Name = "button_CreateNewEmployee"
        Me.button_CreateNewEmployee.Size = New System.Drawing.Size(118, 24)
        Me.button_CreateNewEmployee.TabIndex = 0
        Me.button_CreateNewEmployee.Text = "New Employee"
        Me.button_CreateNewEmployee.UseVisualStyleBackColor = True
        '
        'Alorica_PictureBox
        '
        Me.Alorica_PictureBox.BackgroundImage = CType(resources.GetObject("Alorica_PictureBox.BackgroundImage"), System.Drawing.Image)
        Me.Alorica_PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Alorica_PictureBox.Location = New System.Drawing.Point(171, 23)
        Me.Alorica_PictureBox.Name = "Alorica_PictureBox"
        Me.Alorica_PictureBox.Size = New System.Drawing.Size(75, 68)
        Me.Alorica_PictureBox.TabIndex = 1
        Me.Alorica_PictureBox.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.Alorica_PictureBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.button_CreateNewEmployee)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Alorica_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents button_CreateNewEmployee As System.Windows.Forms.Button
    Friend WithEvents Alorica_PictureBox As System.Windows.Forms.PictureBox

End Class
