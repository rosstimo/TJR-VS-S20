<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ListBoxForm
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
        Me.DataListBox = New System.Windows.Forms.ListBox()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameLabel = New System.Windows.Forms.Label()
        Me.LastNameLabel = New System.Windows.Forms.Label()
        Me.ExampleToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'DataListBox
        '
        Me.DataListBox.Font = New System.Drawing.Font("Consolas", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataListBox.FormattingEnabled = True
        Me.DataListBox.Location = New System.Drawing.Point(99, 32)
        Me.DataListBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataListBox.Name = "DataListBox"
        Me.DataListBox.Size = New System.Drawing.Size(404, 173)
        Me.DataListBox.TabIndex = 0
        Me.DataListBox.TabStop = False
        Me.ExampleToolTip.SetToolTip(Me.DataListBox, "List of Names")
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(173, 224)
        Me.AddButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(107, 61)
        Me.AddButton.TabIndex = 1
        Me.AddButton.Text = "&Add Item"
        Me.ExampleToolTip.SetToolTip(Me.AddButton, "Click Hereto Add The Name to The List Box!")
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(284, 224)
        Me.ClearButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(107, 61)
        Me.ClearButton.TabIndex = 2
        Me.ClearButton.Text = "&Clear All"
        Me.ExampleToolTip.SetToolTip(Me.ClearButton, "Clear The List Box")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Location = New System.Drawing.Point(395, 224)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(107, 61)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "E&xit"
        Me.ExampleToolTip.SetToolTip(Me.ExitButton, "Close The Program")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(99, 8)
        Me.FirstNameTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(168, 20)
        Me.FirstNameTextBox.TabIndex = 4
        Me.ExampleToolTip.SetToolTip(Me.FirstNameTextBox, "Enter a First Name")
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(335, 8)
        Me.LastNameTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(168, 20)
        Me.LastNameTextBox.TabIndex = 5
        Me.ExampleToolTip.SetToolTip(Me.LastNameTextBox, "Enter a Last Name")
        '
        'FirstNameLabel
        '
        Me.FirstNameLabel.AutoSize = True
        Me.FirstNameLabel.Location = New System.Drawing.Point(38, 8)
        Me.FirstNameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.FirstNameLabel.Name = "FirstNameLabel"
        Me.FirstNameLabel.Size = New System.Drawing.Size(57, 13)
        Me.FirstNameLabel.TabIndex = 6
        Me.FirstNameLabel.Text = "First Name"
        '
        'LastNameLabel
        '
        Me.LastNameLabel.AutoSize = True
        Me.LastNameLabel.Location = New System.Drawing.Point(273, 8)
        Me.LastNameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LastNameLabel.Name = "LastNameLabel"
        Me.LastNameLabel.Size = New System.Drawing.Size(58, 13)
        Me.LastNameLabel.TabIndex = 7
        Me.LastNameLabel.Text = "Last Name"
        '
        'ExampleToolTip
        '
        Me.ExampleToolTip.AutomaticDelay = 125
        Me.ExampleToolTip.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ExampleToolTip.IsBalloon = True
        '
        'ListBoxForm
        '
        Me.AcceptButton = Me.AddButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(533, 293)
        Me.Controls.Add(Me.LastNameLabel)
        Me.Controls.Add(Me.FirstNameLabel)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.DataListBox)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "ListBoxForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "List Box "
        Me.ExampleToolTip.SetToolTip(Me, "This is the main Form")
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataListBox As ListBox
    Friend WithEvents AddButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents FirstNameLabel As Label
    Friend WithEvents LastNameLabel As Label
    Friend WithEvents ExampleToolTip As ToolTip
End Class
