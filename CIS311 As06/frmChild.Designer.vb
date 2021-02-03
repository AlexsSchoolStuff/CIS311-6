<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmChild
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
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.grpUnits = New System.Windows.Forms.GroupBox()
        Me.radCentimeters = New System.Windows.Forms.RadioButton()
        Me.radInches = New System.Windows.Forms.RadioButton()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnClearEverything = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btnDecimal = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.picImages = New System.Windows.Forms.PictureBox()
        Me.lstShapes = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstFormulas = New System.Windows.Forms.ListBox()
        Me.lblVar1 = New System.Windows.Forms.Label()
        Me.lblVar2 = New System.Windows.Forms.Label()
        Me.lblVar3 = New System.Windows.Forms.Label()
        Me.txtVar1 = New System.Windows.Forms.TextBox()
        Me.txtVar2 = New System.Windows.Forms.TextBox()
        Me.txtVar3 = New System.Windows.Forms.TextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.grpUnits.SuspendLayout()
        CType(Me.picImages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Location = New System.Drawing.Point(204, 135)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(0, 13)
        Me.lblOutput.TabIndex = 0
        '
        'grpUnits
        '
        Me.grpUnits.Controls.Add(Me.radCentimeters)
        Me.grpUnits.Controls.Add(Me.radInches)
        Me.grpUnits.Location = New System.Drawing.Point(200, 208)
        Me.grpUnits.Name = "grpUnits"
        Me.grpUnits.Size = New System.Drawing.Size(223, 54)
        Me.grpUnits.TabIndex = 1
        Me.grpUnits.TabStop = False
        Me.grpUnits.Text = "Units"
        '
        'radCentimeters
        '
        Me.radCentimeters.AutoSize = True
        Me.radCentimeters.Location = New System.Drawing.Point(125, 20)
        Me.radCentimeters.Name = "radCentimeters"
        Me.radCentimeters.Size = New System.Drawing.Size(95, 17)
        Me.radCentimeters.TabIndex = 1
        Me.radCentimeters.Text = "radCentimeters"
        Me.radCentimeters.UseVisualStyleBackColor = True
        '
        'radInches
        '
        Me.radInches.AutoSize = True
        Me.radInches.Location = New System.Drawing.Point(7, 20)
        Me.radInches.Name = "radInches"
        Me.radInches.Size = New System.Drawing.Size(72, 17)
        Me.radInches.TabIndex = 0
        Me.radInches.Text = "radInches"
        Me.radInches.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(200, 269)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(104, 40)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "C"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnClearEverything
        '
        Me.btnClearEverything.Location = New System.Drawing.Point(319, 269)
        Me.btnClearEverything.Name = "btnClearEverything"
        Me.btnClearEverything.Size = New System.Drawing.Size(104, 40)
        Me.btnClearEverything.TabIndex = 3
        Me.btnClearEverything.Text = "CE"
        Me.btnClearEverything.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.Location = New System.Drawing.Point(200, 315)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(60, 54)
        Me.btn7.TabIndex = 4
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.Location = New System.Drawing.Point(281, 315)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(60, 54)
        Me.btn8.TabIndex = 5
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.Location = New System.Drawing.Point(360, 315)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(60, 54)
        Me.btn9.TabIndex = 6
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Location = New System.Drawing.Point(360, 386)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(60, 54)
        Me.btn6.TabIndex = 9
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(281, 386)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(60, 54)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Location = New System.Drawing.Point(200, 386)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(60, 54)
        Me.btn4.TabIndex = 7
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(360, 455)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(60, 54)
        Me.btn3.TabIndex = 12
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(281, 455)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(60, 54)
        Me.btn2.TabIndex = 11
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(200, 455)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(60, 54)
        Me.btn1.TabIndex = 10
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btnDecimal
        '
        Me.btnDecimal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDecimal.Location = New System.Drawing.Point(360, 526)
        Me.btnDecimal.Name = "btnDecimal"
        Me.btnDecimal.Size = New System.Drawing.Size(60, 54)
        Me.btnDecimal.TabIndex = 13
        Me.btnDecimal.Text = "."
        Me.btnDecimal.UseVisualStyleBackColor = True
        '
        'btn0
        '
        Me.btn0.Location = New System.Drawing.Point(200, 526)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(141, 54)
        Me.btn0.TabIndex = 14
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(453, 221)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(65, 358)
        Me.btnCalc.TabIndex = 15
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'picImages
        '
        Me.picImages.Image = Global.CIS311_As06.My.Resources.Resources.triangle
        Me.picImages.Location = New System.Drawing.Point(603, 228)
        Me.picImages.Name = "picImages"
        Me.picImages.Size = New System.Drawing.Size(500, 313)
        Me.picImages.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picImages.TabIndex = 16
        Me.picImages.TabStop = False
        Me.picImages.Visible = False
        '
        'lstShapes
        '
        Me.lstShapes.FormattingEnabled = True
        Me.lstShapes.Items.AddRange(New Object() {"2D - Rectangle", "2D - Square", "2D - Right Triangle", "2D - Circle", "3D - Cube", "3D - Sphere", "3D - Cylinder", "3D - Cone"})
        Me.lstShapes.Location = New System.Drawing.Point(12, 280)
        Me.lstShapes.Name = "lstShapes"
        Me.lstShapes.Size = New System.Drawing.Size(152, 69)
        Me.lstShapes.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 261)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Shape"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 436)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Formula"
        '
        'lstFormulas
        '
        Me.lstFormulas.FormattingEnabled = True
        Me.lstFormulas.Items.AddRange(New Object() {"Pick a shape first!"})
        Me.lstFormulas.Location = New System.Drawing.Point(16, 455)
        Me.lstFormulas.Name = "lstFormulas"
        Me.lstFormulas.Size = New System.Drawing.Size(152, 69)
        Me.lstFormulas.TabIndex = 19
        '
        'lblVar1
        '
        Me.lblVar1.AutoSize = True
        Me.lblVar1.Location = New System.Drawing.Point(639, 51)
        Me.lblVar1.Name = "lblVar1"
        Me.lblVar1.Size = New System.Drawing.Size(39, 13)
        Me.lblVar1.TabIndex = 21
        Me.lblVar1.Text = "Label3"
        Me.lblVar1.Visible = False
        '
        'lblVar2
        '
        Me.lblVar2.AutoSize = True
        Me.lblVar2.Location = New System.Drawing.Point(639, 75)
        Me.lblVar2.Name = "lblVar2"
        Me.lblVar2.Size = New System.Drawing.Size(39, 13)
        Me.lblVar2.TabIndex = 22
        Me.lblVar2.Text = "Label4"
        Me.lblVar2.Visible = False
        '
        'lblVar3
        '
        Me.lblVar3.AutoSize = True
        Me.lblVar3.Location = New System.Drawing.Point(639, 102)
        Me.lblVar3.Name = "lblVar3"
        Me.lblVar3.Size = New System.Drawing.Size(39, 13)
        Me.lblVar3.TabIndex = 23
        Me.lblVar3.Text = "Label5"
        Me.lblVar3.Visible = False
        '
        'txtVar1
        '
        Me.txtVar1.Location = New System.Drawing.Point(695, 51)
        Me.txtVar1.Name = "txtVar1"
        Me.txtVar1.Size = New System.Drawing.Size(301, 20)
        Me.txtVar1.TabIndex = 24
        Me.txtVar1.Text = "0"
        Me.txtVar1.Visible = False
        '
        'txtVar2
        '
        Me.txtVar2.Location = New System.Drawing.Point(695, 75)
        Me.txtVar2.Name = "txtVar2"
        Me.txtVar2.Size = New System.Drawing.Size(301, 20)
        Me.txtVar2.TabIndex = 25
        Me.txtVar2.Text = "0"
        Me.txtVar2.Visible = False
        '
        'txtVar3
        '
        Me.txtVar3.Location = New System.Drawing.Point(695, 102)
        Me.txtVar3.Name = "txtVar3"
        Me.txtVar3.Size = New System.Drawing.Size(301, 20)
        Me.txtVar3.TabIndex = 26
        Me.txtVar3.Text = "0"
        Me.txtVar3.Visible = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmChild
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.txtVar3)
        Me.Controls.Add(Me.txtVar2)
        Me.Controls.Add(Me.txtVar1)
        Me.Controls.Add(Me.lblVar3)
        Me.Controls.Add(Me.lblVar2)
        Me.Controls.Add(Me.lblVar1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstFormulas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstShapes)
        Me.Controls.Add(Me.picImages)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.btn0)
        Me.Controls.Add(Me.btnDecimal)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btnClearEverything)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.grpUnits)
        Me.Controls.Add(Me.lblOutput)
        Me.Name = "frmChild"
        Me.Text = "Form2"
        Me.grpUnits.ResumeLayout(False)
        Me.grpUnits.PerformLayout()
        CType(Me.picImages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblOutput As Label
    Friend WithEvents grpUnits As GroupBox
    Friend WithEvents radCentimeters As RadioButton
    Friend WithEvents radInches As RadioButton
    Friend WithEvents btnClear As Button
    Friend WithEvents btnClearEverything As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btnDecimal As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents btnCalc As Button
    Friend WithEvents picImages As PictureBox
    Friend WithEvents lstShapes As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lstFormulas As ListBox
    Friend WithEvents lblVar1 As Label
    Friend WithEvents lblVar2 As Label
    Friend WithEvents lblVar3 As Label
    Friend WithEvents txtVar1 As TextBox
    Friend WithEvents txtVar2 As TextBox
    Friend WithEvents txtVar3 As TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
