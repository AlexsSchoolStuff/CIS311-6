'------------------------------------------------------------
'-                File Name : frmChild.vb                   - 
'-                Part of Project: As06                     -
'------------------------------------------------------------
'-                Written By: Alex Buckstiegel              -
'-                Written On: 02-25-20                      -
'------------------------------------------------------------
'- File Purpose:                                            -
'- This file contains the code for the child MDI forms
'------------------------------------------------------------
'- Program Purpose:                                         -
'- MDI form calculator      -
'------------------------------------------------------------
'- Global Variable Dictionary (alphabetically):             -
'- lastTyped - TextBox object that saves the last box entered
'- convertedUnits - Boolean to check if a unit has been converted
'- ListShapes - Enum of all the shapes in the same order as
'- the indexes in the listbox
'------------------------------------------------------------


Imports System.ComponentModel
Imports System.Math

Public Class frmChild
    Dim lastTyped As TextBox
    Dim convertUnits As Boolean = False
    'Enum of all the shapes
    Enum ListShapes
        Rectangle
        Square
        RTriangle
        Circle
        Cube
        Sphere
        Cylinder
        Cone
    End Enum
    '------------------------------------------------------------
    '-                Subprogram Name: frmChild_Load            -
    '------------------------------------------------------------
    '-                Written By: Alex Buckstiegel              -
    '-                Written On: 02-25-20                      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called when the form loads. It sets the
    '– default values for the text boxes and radio buuttons
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------

    Private Sub frmChild_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lastTyped = txtVar1
        txtVar1.Text = "0"
        txtVar2.Text = "0"
        txtVar3.Text = "0"
        radInches.Checked = True
    End Sub

    'Next bit down is all the code for update the labels correctly
    '------------------------------------------------------------
    '-                Subprogram Name: invisiibleAllInputs            -
    '------------------------------------------------------------
    '-                Written By: Alex Buckstiegel              -
    '-                Written On: 02-25-20                      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called to make all the inputs invisible
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Public Sub invisibleAllInputs()
        lblVar1.Visible = False
        lblVar2.Visible = False
        lblVar3.Visible = False
        txtVar1.Visible = False
        txtVar2.Visible = False
        txtVar3.Visible = False
    End Sub
    '------------------------------------------------------------
    '-                Subprogram Name: ShowLength               -
    '------------------------------------------------------------
    '-                Written By: Alex Buckstiegel              -
    '-                Written On: 02-25-20                      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called to set the labels to show 'length'
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Public Sub ShowLength()
        lblVar1.Text = "Length"
        lblVar1.Visible = True
        txtVar1.Visible = True
    End Sub

    '------------------------------------------------------------
    '-                Subprogram Name: ShowWidth               -
    '------------------------------------------------------------
    '-                Written By: Alex Buckstiegel              -
    '-                Written On: 02-25-20                      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called to set the labels to show 'width'
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Public Sub ShowWidth()
        lblVar2.Text = "Width"
        lblVar2.Visible = True
        txtVar2.Visible = True
    End Sub
    '------------------------------------------------------------
    '-                Subprogram Name: ShowBase              -
    '------------------------------------------------------------
    '-                Written By: Alex Buckstiegel              -
    '-                Written On: 02-25-20                      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called to set the labels to show 'Base'
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Public Sub ShowBase()
        lblVar1.Text = "Base"
        lblVar1.Visible = True
        txtVar1.Visible = True
    End Sub
    '------------------------------------------------------------
    '-                Subprogram Name: ShowHeight               -
    '------------------------------------------------------------
    '-                Written By: Alex Buckstiegel              -
    '-                Written On: 02-25-20                      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called to set the labels to show 'Height'
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Public Sub ShowHeight()
        lblVar2.Text = "Height"
        lblVar2.Visible = True
        txtVar2.Visible = True
    End Sub
    '------------------------------------------------------------
    '-                Subprogram Name: ShowRadius               -
    '------------------------------------------------------------
    '-                Written By: Alex Buckstiegel              -
    '-                Written On: 02-25-20                      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called to set the labels to show 'radius'
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Public Sub ShowRadius()
        lblVar1.Text = "Radius"
        lblVar1.Visible = True
        txtVar1.Visible = True
    End Sub
    '------------------------------------------------------------
    '-                Subprogram Name: ShowLWH              -
    '------------------------------------------------------------
    '-                Written By: Alex Buckstiegel              -
    '-                Written On: 02-25-20                      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called to set the labels to show 'length'
    '- 'width', and 'height'
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Public Sub ShowLWH()
        lblVar1.Text = "Length"
        lblVar2.Text = "Width"
        lblVar3.Text = "Height"
        lblVar1.Visible = True
        lblVar2.Visible = True
        lblVar3.Visible = True
        txtVar1.Visible = True
        txtVar2.Visible = True
        txtVar3.Visible = True
    End Sub

    'Updates the labels and also the pictures, I just didn't want to rename it
    'It also updates the names of the lstFormulas to the shape

    '------------------------------------------------------------
    '-                Subprogram Name: updateInputLabels               -
    '------------------------------------------------------------
    '-                Written By: Alex Buckstiegel              -
    '-                Written On: 02-25-20                      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called to update the labels, pictures, 
    '- as well as change the names in lstFormulas to match the shape
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Public Sub updateInputLabels()
        If lstShapes.SelectedIndex = ListShapes.Rectangle Then
            picImages.Image = Image.FromFile("..\..\Resources\rectangle.jpg")
            ShowLength()
            ShowWidth()
            lstFormulas.Items.Clear()
            lstFormulas.Items.Add("Perimeter")
            lstFormulas.Items.Add("Area")
        ElseIf lstShapes.SelectedIndex = ListShapes.Square Then
            picImages.Image = Image.FromFile("..\..\Resources\square.jpg")
            ShowLength()
            lstFormulas.Items.Clear()
            lstFormulas.Items.Add("Perimeter")
            lstFormulas.Items.Add("Area")
        ElseIf lstShapes.SelectedIndex = ListShapes.RTriangle Then
            picImages.Image = Image.FromFile("..\..\Resources\triangle.jpg")
            ShowBase()
            ShowHeight()
            lstFormulas.Items.Clear()
            lstFormulas.Items.Add("Perimeter")
            lstFormulas.Items.Add("Area")
        ElseIf lstShapes.SelectedIndex = ListShapes.Circle Then
            picImages.Image = Image.FromFile("..\..\Resources\circle.jpg")
            ShowRadius()
            lstFormulas.Items.Clear()
            lstFormulas.Items.Add("Circumfrence")
            lstFormulas.Items.Add("Area")
        ElseIf lstShapes.SelectedIndex = ListShapes.Cube Then
            picImages.Image = Image.FromFile("..\..\Resources\cube.jpg")
            ShowLWH()
            lstFormulas.Items.Clear()
            lstFormulas.Items.Add("Surface Area")
            lstFormulas.Items.Add("Volume")
        ElseIf lstShapes.SelectedIndex = ListShapes.Sphere Then
            picImages.Image = Image.FromFile("..\..\Resources\sphere.jpg")
            ShowRadius()
            lstFormulas.Items.Clear()
            lstFormulas.Items.Add("Surface Area")
            lstFormulas.Items.Add("Volume")
        ElseIf lstShapes.SelectedIndex = ListShapes.Cylinder Then
            picImages.Image = Image.FromFile("..\..\Resources\cylinder.jpg")
            ShowRadius()
            ShowHeight()
            lstFormulas.Items.Clear()
            lstFormulas.Items.Add("Surface Area")
            lstFormulas.Items.Add("Volume")
        ElseIf lstShapes.SelectedIndex = ListShapes.Cone Then
            picImages.Image = Image.FromFile("..\..\Resources\cone.jpg")
            ShowRadius()
            ShowHeight()
            lstFormulas.Items.Clear()
            lstFormulas.Items.Add("Surface Area")
            lstFormulas.Items.Add("Volume")
        End If
    End Sub
    '------------------------------------------------------------
    '-                Subprogram Name: lstShapes_SelectedIndexChanged
    '------------------------------------------------------------
    '-                Written By: Alex Buckstiegel              -
    '-                Written On: 02-25-20                      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called when the user changes which shape
    '- is selected. It clears the error provider, sets the correct
    '- inputs to be visible, and sets the formula to index 0
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------

    Private Sub lstShapes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstShapes.SelectedIndexChanged
        ErrorProvider1.Clear()
        invisibleAllInputs()
        picImages.Visible = True
        updateInputLabels()
        lstFormulas.SelectedIndex = 0
    End Sub


    '------------------------------------------------------------
    '-                Subprogram Name: ensureInputs            -
    '------------------------------------------------------------
    '-                Written By: Alex Buckstiegel              -
    '-                Written On: 02-25-20                      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called during some calculations. It makes
    '- sure that there is a valid inputs, and invalid inputs are
    '- changed to 0 and the user is alerted
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Public Sub ensureInputs()
        If txtVar1.Text = "" Or Not IsNumeric(txtVar1.Text) Then
            ErrorProvider1.SetError(btnCalc, "Invalid Character changed to 0")
            txtVar1.Text = "0"
        End If
        If txtVar2.Text = "" Or Not IsNumeric(txtVar2.Text) Then
            ErrorProvider1.SetError(btnCalc, "Invalid Character changed to 0")
            txtVar2.Text = "0"
        End If
        If txtVar3.Text = "" Or Not IsNumeric(txtVar3.Text) Then
            ErrorProvider1.SetError(btnCalc, "Invalid Character changed to 0")
            txtVar3.Text = "0"
        End If
    End Sub
    '------------------------------------------------------------
    '-                Subprogram Name: RunCalcs            -
    '------------------------------------------------------------
    '-                Written By: Alex Buckstiegel              -
    '-                Written On: 02-25-20                      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is calledto calculate all the answers
    '- It gathers the inputs and calls the corresponding 
    '- math functions from Module1
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------

    Public Sub RunCalcs()

        Dim input1, input2, input3
        If txtVar1.Visible Then
            input1 = CSng(txtVar1.Text)
        End If
        If txtVar2.Visible Then
            input2 = CSng(txtVar2.Text)
        End If
        If txtVar3.Visible Then
            input3 = CSng(txtVar3.Text)
        End If
        Const PorSA = 0 'Perimeter or Surface Area or Circumfrence
        Const AorV = 1  'Area or Volume
        Dim selectedFormula As Integer = lstFormulas.SelectedIndex
        Select Case lstShapes.SelectedIndex
            Case ListShapes.Rectangle
                If selectedFormula = PorSA Then
                    lblOutput.Text = calcRectangleP(input1, input2)
                ElseIf selectedFormula = AorV Then
                    lblOutput.Text = calcRectangleA(input1, input2)
                End If

            Case ListShapes.Square
                If selectedFormula = PorSA Then
                    lblOutput.Text = calcSquareP(input1)
                ElseIf selectedFormula = AorV Then
                    lblOutput.Text = calcSquareA(input1)
                End If
            Case ListShapes.RTriangle
                If selectedFormula = PorSA Then
                    lblOutput.Text = calcTriangleP(input1, input2)
                ElseIf selectedFormula = AorV Then
                    lblOutput.Text = calcTriangleA(input1, input2)
                End If
            Case ListShapes.Circle
                If selectedFormula = PorSA Then
                    lblOutput.Text = calcCircleC(input1)
                ElseIf selectedFormula = AorV Then
                    lblOutput.Text = calcCircleA(input1)
                End If
            Case ListShapes.Cube
                If selectedFormula = PorSA Then
                    lblOutput.Text = calcCubeSA(input1, input2, input3)
                ElseIf selectedFormula = AorV Then
                    lblOutput.Text = calcCubeV(input1, input2, input3)
                End If
            Case ListShapes.Sphere
                If selectedFormula = PorSA Then
                    lblOutput.Text = calcSphereSA(input1)
                ElseIf selectedFormula = AorV Then
                    lblOutput.Text = calcSphereV(input1)
                End If
            Case ListShapes.Cylinder
                If selectedFormula = PorSA Then
                    lblOutput.Text = calcCylinderSA(input1, input2)
                ElseIf selectedFormula = AorV Then
                    lblOutput.Text = calcCylinderV(input1, input2)
                End If
            Case ListShapes.Cone
                If selectedFormula = PorSA Then
                    lblOutput.Text = calcConeSA(input1, input2)
                ElseIf selectedFormula = AorV Then
                    lblOutput.Text = calcConeV(input1, input2)
                End If
        End Select
    End Sub

    '------------------------------------------------------------
    '-                Subprogram Name: btlCalc_Click            -
    '------------------------------------------------------------
    '-                Written By: Alex Buckstiegel              -
    '-                Written On: 02-25-20                      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called to calculate the values. It clears
    '- the errorProvider, ensures inputs, and then runs the calcs
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btlCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ErrorProvider1.Clear()
        ensureInputs()
        runCalcs()


    End Sub

    '------------------------------------------------------------
    '-                Subprogram Name: frmChildClosing          -
    '------------------------------------------------------------
    '-                Written By: Alex Buckstiegel              -
    '-                Written On: 02-25-20                      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called when the form is closing, and 
    '- if the form is dirty asks the user if they're sure they
    '- want to close the forms
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- answer - integer that holds the answer to the msgbox                                                -
    '------------------------------------------------------------
    Private Sub frmChild_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If (txtVar1.Text = "" Or txtVar1.Text = "0") And (txtVar2.Text = "" Or txtVar2.Text = "0") And (txtVar3.Text = "" Or txtVar3.Text = "0") Then
            e.Cancel = False
        Else
            Dim answer As Integer
            answer = MsgBox("Are you sure you want to close?", vbQuestion + vbYesNo + vbDefaultButton2, "Close?")
            If answer = vbYes Then
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If


    End Sub

    '------------------------------------------------------------
    '-                Subprogram Name: txtVar1_enter            -
    '------------------------------------------------------------
    '-                Written By: Alex Buckstiegel              -
    '-                Written On: 02-25-20                      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called when the user enters txtVar1
    '- and sets the lastTyped to this textbox
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (none)                                              -
    '------------------------------------------------------------
    Private Sub txtVar1_Enter(sender As Object, e As EventArgs) Handles txtVar1.Enter
        lastTyped = txtVar1
    End Sub

    '------------------------------------------------------------
    '-                Subprogram Name: txtVar1_enter            -
    '------------------------------------------------------------
    '-                Written By: Alex Buckstiegel              -
    '-                Written On: 02-25-20                      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called when the user enters txtVar2
    '- and sets the lastTyped to this textbox
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (none)                                              -
    '------------------------------------------------------------
    Private Sub txtVar2_Enter(sender As Object, e As EventArgs) Handles txtVar2.Enter
        lastTyped = txtVar2
    End Sub

    '------------------------------------------------------------
    '-                Subprogram Name: txtVar1_enter            -
    '------------------------------------------------------------
    '-                Written By: Alex Buckstiegel              -
    '-                Written On: 02-25-20                      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called when the user enters txtVar3
    '- and sets the lastTyped to this textbox
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (none)                                              -
    '------------------------------------------------------------
    Private Sub txtVar3_Enter(sender As Object, e As EventArgs) Handles txtVar3.Enter
        lastTyped = txtVar3
    End Sub

    '------------------------------------------------------------
    '-                Subprogram Name: btn1-9,0,._Click         -
    '------------------------------------------------------------
    '-                Written By: Alex Buckstiegel              -
    '-                Written On: 02-25-20                      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- The following subroutines add their corresponding symbol
    '- into the lastTyped textbox
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (none)                                              -
    '------------------------------------------------------------
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        lastTyped.Text = lastTyped.Text + "1"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        lastTyped.Text = lastTyped.Text + "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        lastTyped.Text = lastTyped.Text + "3"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        lastTyped.Text = lastTyped.Text + "4"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        lastTyped.Text = lastTyped.Text + "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        lastTyped.Text = lastTyped.Text + "6"
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        lastTyped.Text = lastTyped.Text + "7"
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        lastTyped.Text = lastTyped.Text + "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        lastTyped.Text = lastTyped.Text + "9"
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        lastTyped.Text = lastTyped.Text + "0"
    End Sub

    Private Sub btnDecimal_Click(sender As Object, e As EventArgs) Handles btnDecimal.Click
        lastTyped.Text = lastTyped.Text + "."
    End Sub

    '------------------------------------------------------------
    '-                Subprogram Name: radCentimeters_CheckedChanged
    '------------------------------------------------------------
    '-                Written By: Alex Buckstiegel              -
    '-                Written On: 02-25-20                      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called when the user changes the units
    '- to centimeters and then changes what was inputed to 
    '- centimeters and re-calculates the data
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (none)                                              -
    '------------------------------------------------------------
    Private Sub radCentimeters_CheckedChanged(sender As Object, e As EventArgs) Handles radCentimeters.CheckedChanged
        If radCentimeters.Checked Then
            If txtVar1.Text <> "" Then
                txtVar1.Text = txtVar1.Text * 2.54
            End If
            If txtVar2.Text <> "" Then
                txtVar2.Text = txtVar2.Text * 2.54
            End If
            If txtVar3.Text <> "" Then
                txtVar3.Text = txtVar3.Text * 2.54
            End If
        End If
        runCalcs()

    End Sub

    '------------------------------------------------------------
    '-                Subprogram Name: radInches_CheckedChanged
    '------------------------------------------------------------
    '-                Written By: Alex Buckstiegel              -
    '-                Written On: 02-25-20                      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called when the user changes the units
    '- to inches and then changes what was inputed to 
    '- inches and re-calculates the data
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (none)                                              -
    '------------------------------------------------------------
    Private Sub radInches_CheckedChanged(sender As Object, e As EventArgs) Handles radInches.CheckedChanged
        If radInches.Checked Then
            If txtVar1.Text <> "" Then
                txtVar1.Text = txtVar1.Text * (1 / 2.54)
            End If
            If txtVar2.Text <> "" Then
                txtVar2.Text = txtVar2.Text * (1 / 2.54)
            End If
            If txtVar3.Text <> "" Then
                txtVar3.Text = txtVar3.Text * (1 / 2.54)
            End If
        End If
        runCalcs()
    End Sub
End Class