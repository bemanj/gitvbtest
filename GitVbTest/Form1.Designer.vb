﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.button_CreateNewEmployee = New System.Windows.Forms.Button()
        '<<<<<<< HEAD
        Me.Label1 = New System.Windows.Forms.Label()
        '=======
        Me.SheldonButton = New System.Windows.Forms.Button()
        '>>>>>>> feature/sheldon_feature_1
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
        '<<<<<<< HEAD
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label Button"
        '=======
        'SheldonButton
        '
        Me.SheldonButton.Location = New System.Drawing.Point(47, 125)
        Me.SheldonButton.Name = "SheldonButton"
        Me.SheldonButton.Size = New System.Drawing.Size(75, 23)
        Me.SheldonButton.TabIndex = 1
        Me.SheldonButton.Text = "Sheldon"
        Me.SheldonButton.UseVisualStyleBackColor = True
        '>>>>>>> feature/sheldon_feature_1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        '<<<<<<< HEAD
        Me.Controls.Add(Me.Label1)
        '=======
        Me.Controls.Add(Me.SheldonButton)
        '>>>>>>> feature/sheldon_feature_1
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.button_CreateNewEmployee)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents button_CreateNewEmployee As System.Windows.Forms.Button
    '<<<<<<< HEAD
    Friend WithEvents Label1 As System.Windows.Forms.Label
    '=======
    Friend WithEvents SheldonButton As System.Windows.Forms.Button
    '>>>>>>> feature/sheldon_feature_1

End Class
