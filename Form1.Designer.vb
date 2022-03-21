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
        Me.cmdClick = New System.Windows.Forms.Button()
        Me.lblEnter = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdClick
        '
        Me.cmdClick.Location = New System.Drawing.Point(242, 90)
        Me.cmdClick.Name = "cmdClick"
        Me.cmdClick.Size = New System.Drawing.Size(100, 23)
        Me.cmdClick.TabIndex = 0
        Me.cmdClick.Text = "CLICK HERE"
        Me.cmdClick.UseVisualStyleBackColor = True
        '
        'lblEnter
        '
        Me.lblEnter.AutoSize = True
        Me.lblEnter.Location = New System.Drawing.Point(65, 46)
        Me.lblEnter.Name = "lblEnter"
        Me.lblEnter.Size = New System.Drawing.Size(94, 15)
        Me.lblEnter.TabIndex = 1
        Me.lblEnter.Text = "Enter your name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(191, 46)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(212, 23)
        Me.txtName.TabIndex = 2
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(65, 156)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(42, 15)
        Me.lblResult.TabIndex = 3
        Me.lblResult.Text = "Result:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 252)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblEnter)
        Me.Controls.Add(Me.cmdClick)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdClick As Button
    Friend WithEvents lblEnter As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblResult As Label
End Class
