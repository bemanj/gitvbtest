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
        Me.button_CreateNewEmployee = New System.Windows.Forms.Button()
        Me.SheldonButton = New System.Windows.Forms.Button()
        Me.FirstNameLabel1 = New System.Windows.Forms.Label()
        Me.LastNameTextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
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
        'SheldonButton
        '
        Me.SheldonButton.Location = New System.Drawing.Point(114, 91)
        Me.SheldonButton.Name = "SheldonButton"
        Me.SheldonButton.Size = New System.Drawing.Size(75, 23)
        Me.SheldonButton.TabIndex = 1
        Me.SheldonButton.Text = "Sheldon"
        Me.SheldonButton.UseVisualStyleBackColor = True
        '
        'FirstNameLabel1
        '
        Me.FirstNameLabel1.AutoSize = True
        Me.FirstNameLabel1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstNameLabel1.ForeColor = System.Drawing.Color.Purple
        Me.FirstNameLabel1.Location = New System.Drawing.Point(21, 67)
        Me.FirstNameLabel1.Name = "FirstNameLabel1"
        Me.FirstNameLabel1.Size = New System.Drawing.Size(75, 16)
        Me.FirstNameLabel1.TabIndex = 1
        Me.FirstNameLabel1.Text = "First Name"
        '
        'LastNameTextBox1
        '
        Me.LastNameTextBox1.Location = New System.Drawing.Point(102, 65)
        Me.LastNameTextBox1.Name = "LastNameTextBox1"
        Me.LastNameTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.LastNameTextBox1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(168, 226)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Benedict"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(102, 39)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Purple
        Me.Label3.Location = New System.Drawing.Point(21, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Last Name"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.SheldonButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LastNameTextBox1)
        Me.Controls.Add(Me.FirstNameLabel1)
        Me.Controls.Add(Me.button_CreateNewEmployee)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents button_CreateNewEmployee As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

    Friend WithEvents SheldonButton As System.Windows.Forms.Button
    Friend WithEvents FirstNameLabel1 As System.Windows.Forms.Label
    Friend WithEvents LastNameTextBox1 As System.Windows.Forms.TextBox

    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label


End Class
