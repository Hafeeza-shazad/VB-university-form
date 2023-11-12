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
        Me.studentinformationGroupBox = New System.Windows.Forms.GroupBox()
        Me.PhoneMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.MajorTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneLabel = New System.Windows.Forms.Label()
        Me.MajorLabel = New System.Windows.Forms.Label()
        Me.Namelabel = New System.Windows.Forms.Label()
        Me.outputLabel = New System.Windows.Forms.Label()
        Me.outputTextBox = New System.Windows.Forms.TextBox()
        Me.MessageCheckBox = New System.Windows.Forms.CheckBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.Displaybutton = New System.Windows.Forms.Button()
        Me.BackgroundGroupBox = New System.Windows.Forms.GroupBox()
        Me.GreenRadioButton = New System.Windows.Forms.RadioButton()
        Me.BlueRadioButton = New System.Windows.Forms.RadioButton()
        Me.RedRadioButton = New System.Windows.Forms.RadioButton()
        Me.GrayRadioButton = New System.Windows.Forms.RadioButton()
        Me.TextGroupBox = New System.Windows.Forms.GroupBox()
        Me.whiteRadioButton = New System.Windows.Forms.RadioButton()
        Me.blackRadioButton = New System.Windows.Forms.RadioButton()
        Me.SnowPictureBox = New System.Windows.Forms.PictureBox()
        Me.SunPictureBox = New System.Windows.Forms.PictureBox()
        Me.studentinformationGroupBox.SuspendLayout()
        Me.BackgroundGroupBox.SuspendLayout()
        Me.TextGroupBox.SuspendLayout()
        CType(Me.SnowPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SunPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'studentinformationGroupBox
        '
        Me.studentinformationGroupBox.Controls.Add(Me.PhoneMaskedTextBox)
        Me.studentinformationGroupBox.Controls.Add(Me.MajorTextBox)
        Me.studentinformationGroupBox.Controls.Add(Me.NameTextBox)
        Me.studentinformationGroupBox.Controls.Add(Me.PhoneLabel)
        Me.studentinformationGroupBox.Controls.Add(Me.MajorLabel)
        Me.studentinformationGroupBox.Controls.Add(Me.Namelabel)
        Me.studentinformationGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.studentinformationGroupBox.Name = "studentinformationGroupBox"
        Me.studentinformationGroupBox.Size = New System.Drawing.Size(571, 141)
        Me.studentinformationGroupBox.TabIndex = 0
        Me.studentinformationGroupBox.TabStop = False
        Me.studentinformationGroupBox.Text = "Student Information"
        '
        'PhoneMaskedTextBox
        '
        Me.PhoneMaskedTextBox.Location = New System.Drawing.Point(81, 96)
        Me.PhoneMaskedTextBox.Name = "PhoneMaskedTextBox"
        Me.PhoneMaskedTextBox.Size = New System.Drawing.Size(321, 22)
        Me.PhoneMaskedTextBox.TabIndex = 5
        Me.PhoneMaskedTextBox.Text = "(254)123-4567"
        '
        'MajorTextBox
        '
        Me.MajorTextBox.Location = New System.Drawing.Point(81, 69)
        Me.MajorTextBox.Name = "MajorTextBox"
        Me.MajorTextBox.Size = New System.Drawing.Size(468, 22)
        Me.MajorTextBox.TabIndex = 4
        Me.MajorTextBox.Text = "BBIT"
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(81, 39)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(468, 22)
        Me.NameTextBox.TabIndex = 3
        Me.NameTextBox.Text = "Monica Ross"
        '
        'PhoneLabel
        '
        Me.PhoneLabel.AutoSize = True
        Me.PhoneLabel.Location = New System.Drawing.Point(15, 99)
        Me.PhoneLabel.Name = "PhoneLabel"
        Me.PhoneLabel.Size = New System.Drawing.Size(49, 16)
        Me.PhoneLabel.TabIndex = 2
        Me.PhoneLabel.Text = "Phone:"
        '
        'MajorLabel
        '
        Me.MajorLabel.AutoSize = True
        Me.MajorLabel.Location = New System.Drawing.Point(15, 72)
        Me.MajorLabel.Name = "MajorLabel"
        Me.MajorLabel.Size = New System.Drawing.Size(44, 16)
        Me.MajorLabel.TabIndex = 1
        Me.MajorLabel.Text = "Major:"
        '
        'Namelabel
        '
        Me.Namelabel.AutoSize = True
        Me.Namelabel.Location = New System.Drawing.Point(15, 39)
        Me.Namelabel.Name = "Namelabel"
        Me.Namelabel.Size = New System.Drawing.Size(47, 16)
        Me.Namelabel.TabIndex = 0
        Me.Namelabel.Text = "Name:"
        '
        'outputLabel
        '
        Me.outputLabel.AutoSize = True
        Me.outputLabel.Location = New System.Drawing.Point(23, 170)
        Me.outputLabel.Name = "outputLabel"
        Me.outputLabel.Size = New System.Drawing.Size(48, 16)
        Me.outputLabel.TabIndex = 2
        Me.outputLabel.Text = "Output:"
        '
        'outputTextBox
        '
        Me.outputTextBox.Location = New System.Drawing.Point(93, 170)
        Me.outputTextBox.Multiline = True
        Me.outputTextBox.Name = "outputTextBox"
        Me.outputTextBox.Size = New System.Drawing.Size(490, 114)
        Me.outputTextBox.TabIndex = 3
        '
        'MessageCheckBox
        '
        Me.MessageCheckBox.AutoSize = True
        Me.MessageCheckBox.Location = New System.Drawing.Point(93, 309)
        Me.MessageCheckBox.Name = "MessageCheckBox"
        Me.MessageCheckBox.Size = New System.Drawing.Size(128, 20)
        Me.MessageCheckBox.TabIndex = 4
        Me.MessageCheckBox.Text = "Message visible"
        Me.MessageCheckBox.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.Cyan
        Me.ExitButton.Location = New System.Drawing.Point(592, 372)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(97, 49)
        Me.ExitButton.TabIndex = 5
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'ResetButton
        '
        Me.ResetButton.BackColor = System.Drawing.Color.Cyan
        Me.ResetButton.Location = New System.Drawing.Point(459, 370)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(102, 51)
        Me.ResetButton.TabIndex = 6
        Me.ResetButton.Text = "Reset"
        Me.ResetButton.UseVisualStyleBackColor = False
        '
        'Displaybutton
        '
        Me.Displaybutton.BackColor = System.Drawing.Color.Cyan
        Me.Displaybutton.Location = New System.Drawing.Point(323, 370)
        Me.Displaybutton.Name = "Displaybutton"
        Me.Displaybutton.Size = New System.Drawing.Size(104, 51)
        Me.Displaybutton.TabIndex = 7
        Me.Displaybutton.Text = "Display Message"
        Me.Displaybutton.UseVisualStyleBackColor = False
        '
        'BackgroundGroupBox
        '
        Me.BackgroundGroupBox.Controls.Add(Me.GreenRadioButton)
        Me.BackgroundGroupBox.Controls.Add(Me.BlueRadioButton)
        Me.BackgroundGroupBox.Controls.Add(Me.RedRadioButton)
        Me.BackgroundGroupBox.Controls.Add(Me.GrayRadioButton)
        Me.BackgroundGroupBox.Location = New System.Drawing.Point(602, 30)
        Me.BackgroundGroupBox.Name = "BackgroundGroupBox"
        Me.BackgroundGroupBox.Size = New System.Drawing.Size(186, 142)
        Me.BackgroundGroupBox.TabIndex = 8
        Me.BackgroundGroupBox.TabStop = False
        Me.BackgroundGroupBox.Text = "Background"
        '
        'GreenRadioButton
        '
        Me.GreenRadioButton.AutoSize = True
        Me.GreenRadioButton.Location = New System.Drawing.Point(6, 101)
        Me.GreenRadioButton.Name = "GreenRadioButton"
        Me.GreenRadioButton.Size = New System.Drawing.Size(65, 20)
        Me.GreenRadioButton.TabIndex = 13
        Me.GreenRadioButton.TabStop = True
        Me.GreenRadioButton.Text = "Green"
        Me.GreenRadioButton.UseVisualStyleBackColor = True
        '
        'BlueRadioButton
        '
        Me.BlueRadioButton.AutoSize = True
        Me.BlueRadioButton.Location = New System.Drawing.Point(6, 75)
        Me.BlueRadioButton.Name = "BlueRadioButton"
        Me.BlueRadioButton.Size = New System.Drawing.Size(55, 20)
        Me.BlueRadioButton.TabIndex = 14
        Me.BlueRadioButton.TabStop = True
        Me.BlueRadioButton.Text = "Blue"
        Me.BlueRadioButton.UseVisualStyleBackColor = True
        '
        'RedRadioButton
        '
        Me.RedRadioButton.AutoSize = True
        Me.RedRadioButton.Location = New System.Drawing.Point(6, 49)
        Me.RedRadioButton.Name = "RedRadioButton"
        Me.RedRadioButton.Size = New System.Drawing.Size(54, 20)
        Me.RedRadioButton.TabIndex = 15
        Me.RedRadioButton.TabStop = True
        Me.RedRadioButton.Text = "Red"
        Me.RedRadioButton.UseVisualStyleBackColor = True
        '
        'GrayRadioButton
        '
        Me.GrayRadioButton.AutoSize = True
        Me.GrayRadioButton.Location = New System.Drawing.Point(6, 23)
        Me.GrayRadioButton.Name = "GrayRadioButton"
        Me.GrayRadioButton.Size = New System.Drawing.Size(57, 20)
        Me.GrayRadioButton.TabIndex = 10
        Me.GrayRadioButton.TabStop = True
        Me.GrayRadioButton.Text = "Gray"
        Me.GrayRadioButton.UseVisualStyleBackColor = True
        '
        'TextGroupBox
        '
        Me.TextGroupBox.Controls.Add(Me.whiteRadioButton)
        Me.TextGroupBox.Controls.Add(Me.blackRadioButton)
        Me.TextGroupBox.Location = New System.Drawing.Point(602, 178)
        Me.TextGroupBox.Name = "TextGroupBox"
        Me.TextGroupBox.Size = New System.Drawing.Size(186, 106)
        Me.TextGroupBox.TabIndex = 9
        Me.TextGroupBox.TabStop = False
        Me.TextGroupBox.Text = "Text color"
        '
        'whiteRadioButton
        '
        Me.whiteRadioButton.AutoSize = True
        Me.whiteRadioButton.Location = New System.Drawing.Point(6, 63)
        Me.whiteRadioButton.Name = "whiteRadioButton"
        Me.whiteRadioButton.Size = New System.Drawing.Size(62, 20)
        Me.whiteRadioButton.TabIndex = 11
        Me.whiteRadioButton.TabStop = True
        Me.whiteRadioButton.Text = "White"
        Me.whiteRadioButton.UseVisualStyleBackColor = True
        '
        'blackRadioButton
        '
        Me.blackRadioButton.AutoSize = True
        Me.blackRadioButton.Location = New System.Drawing.Point(6, 37)
        Me.blackRadioButton.Name = "blackRadioButton"
        Me.blackRadioButton.Size = New System.Drawing.Size(62, 20)
        Me.blackRadioButton.TabIndex = 12
        Me.blackRadioButton.TabStop = True
        Me.blackRadioButton.Text = "Black"
        Me.blackRadioButton.UseVisualStyleBackColor = True
        '
        'SnowPictureBox
        '
        Me.SnowPictureBox.Image = CType(resources.GetObject("SnowPictureBox.Image"), System.Drawing.Image)
        Me.SnowPictureBox.Location = New System.Drawing.Point(140, 356)
        Me.SnowPictureBox.Name = "SnowPictureBox"
        Me.SnowPictureBox.Size = New System.Drawing.Size(110, 73)
        Me.SnowPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SnowPictureBox.TabIndex = 10
        Me.SnowPictureBox.TabStop = False
        Me.SnowPictureBox.Visible = False
        '
        'SunPictureBox
        '
        Me.SunPictureBox.Image = CType(resources.GetObject("SunPictureBox.Image"), System.Drawing.Image)
        Me.SunPictureBox.Location = New System.Drawing.Point(12, 356)
        Me.SunPictureBox.Name = "SunPictureBox"
        Me.SunPictureBox.Size = New System.Drawing.Size(100, 73)
        Me.SunPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SunPictureBox.TabIndex = 11
        Me.SunPictureBox.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 450)
        Me.Controls.Add(Me.SunPictureBox)
        Me.Controls.Add(Me.SnowPictureBox)
        Me.Controls.Add(Me.TextGroupBox)
        Me.Controls.Add(Me.BackgroundGroupBox)
        Me.Controls.Add(Me.Displaybutton)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.MessageCheckBox)
        Me.Controls.Add(Me.outputTextBox)
        Me.Controls.Add(Me.outputLabel)
        Me.Controls.Add(Me.studentinformationGroupBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.studentinformationGroupBox.ResumeLayout(False)
        Me.studentinformationGroupBox.PerformLayout()
        Me.BackgroundGroupBox.ResumeLayout(False)
        Me.BackgroundGroupBox.PerformLayout()
        Me.TextGroupBox.ResumeLayout(False)
        Me.TextGroupBox.PerformLayout()
        CType(Me.SnowPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SunPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents studentinformationGroupBox As GroupBox
    Friend WithEvents PhoneMaskedTextBox As MaskedTextBox
    Friend WithEvents MajorTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents PhoneLabel As Label
    Friend WithEvents MajorLabel As Label
    Friend WithEvents Namelabel As Label
    Friend WithEvents outputLabel As Label
    Friend WithEvents outputTextBox As TextBox
    Friend WithEvents MessageCheckBox As CheckBox
    Friend WithEvents ExitButton As Button
    Friend WithEvents ResetButton As Button
    Friend WithEvents Displaybutton As Button
    Friend WithEvents BackgroundGroupBox As GroupBox
    Friend WithEvents TextGroupBox As GroupBox

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles TextGroupBox.Enter

    End Sub

    Friend WithEvents GrayRadioButton As RadioButton
    Friend WithEvents whiteRadioButton As RadioButton
    Friend WithEvents blackRadioButton As RadioButton
    Friend WithEvents GreenRadioButton As RadioButton
    Friend WithEvents BlueRadioButton As RadioButton
    Friend WithEvents RedRadioButton As RadioButton



    Friend WithEvents SnowPictureBox As PictureBox
    Friend WithEvents SunPictureBox As PictureBox
    Public Property GrayBackGroundColor As Color

    Private Sub Displaybutton_Click(sender As Object, e As EventArgs) Handles Displaybutton.Click
        'Store output message to the output textbox using implicit line continuation
        outputTextBox.Text =
            "My name: " & NameTextBox.Text & ControlChars.NewLine &
            "Major: " & MajorTextBox.Text & ControlChars.NewLine &
            "Local phone: " & PhoneMaskedTextBox.Text

    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        'Clear the input and output TextBox and MaskedTextBox controls - 
        'This code shows use of the Clear method, String.Empty value, and
        'empty double quote marks        
        NameTextBox.Clear()
        MajorTextBox.Text = String.Empty
        PhoneMaskedTextBox.Clear()
        outputTextBox.Text = ""
        'Reset the form's BackColor to gray 
        'and ForeColor to black
        GrayRadioButton.Checked = True
        blackRadioButton.Checked = True
        'Reset the message display CheckBox control to checked
        MessageCheckBox.Checked = True
        'Turn on the sun and turn off the snow
        SunPictureBox.Visible = True
        SnowPictureBox.Visible = False
        'Set focus to first TextBox
        NameTextBox.Focus()

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        'Exit the form
        Me.Close()

    End Sub

    Private Sub SnowPictureBox_Click(sender As Object, e As EventArgs) Handles SnowPictureBox.Click
        'Turn the snow into the sun
        SnowPictureBox.Visible = False
        SunPictureBox.Visible = True

    End Sub

    Private Sub SunPictureBox_Click(sender As Object, e As EventArgs) Handles SunPictureBox.Click
        'Turn the sun into the snow
        SnowPictureBox.Visible = True
        SunPictureBox.Visible = False

    End Sub

    Private Sub GrayRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles GrayRadioButton.CheckedChanged
        'Set the backcolor of the form to the default gray
        Me.BackColor = GrayBackGroundColor

    End Sub

    Private Sub RedRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles RedRadioButton.CheckedChanged
        'Set the backcolor of the form
        Me.BackColor = Color.Red

    End Sub

    Private Sub BlueRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles BlueRadioButton.CheckedChanged
        'Set the backcolor of the form
        Me.BackColor = Color.Blue

    End Sub

    Private Sub GreenRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles GreenRadioButton.CheckedChanged
        'Set the backcolor of the form
        Me.BackColor = Color.Green

    End Sub

    Private Sub whiteRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles whiteRadioButton.CheckedChanged
        'Set form's text color
        Me.ForeColor = Color.White

    End Sub

    Private Sub blackRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles blackRadioButton.CheckedChanged
        'Set form's text color
        Me.ForeColor = Color.Black

    End Sub

    Private Sub MessageCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles MessageCheckBox.CheckedChanged
        'Make the OutputTextBox and OutputLabel invisible 
        outputTextBox.Visible = MessageCheckBox.Checked
        outputLabel.Visible = MessageCheckBox.Checked

    End Sub
    Private Sub StudentInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Assign background color to module-level variable
        GrayBackGroundColor = Me.BackColor
    End Sub

End Class
