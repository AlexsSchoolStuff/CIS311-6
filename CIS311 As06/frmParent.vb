Imports System.ComponentModel

'------------------------------------------------------------
'-                File Name : frmParent.vb                  - 
'-                Part of Project: As06                     -
'------------------------------------------------------------
'-                Written By: Alex Buckstiegel              -
'-                Written On: 02-25-20                      -
'------------------------------------------------------------
'- File Purpose:                                            -
'- This file is the MDI parent and contains the code to 
'- create the new forms and to handle the menu at the top
'------------------------------------------------------------
'- Global Variable Dictionary (alphabetically):             -
'- count - its a counter
'------------------------------------------------------------


Public Class frmParent
    Dim count As Integer = 0


    '------------------------------------------------------------
    '-                Subprogram Name: mnuFilenew_Click         -
    '------------------------------------------------------------
    '-                Written By: Alex Buckstiegel              -
    '-                Written On: 02-25-20                      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is the file -> new button, and creates a –
    '- new calculator form
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- newChildForm - frmChild that creates the new forms       -
    '------------------------------------------------------------

    Private Sub mnuFileNew_Click(sender As Object, e As EventArgs) Handles mnuFileNew.Click
        Dim newChildForm As New frmChild()
        count += 1
        newChildForm.Name &= count
        newChildForm.Text = newChildForm.Name
        newChildForm.MdiParent = Me
        newChildForm.Show()
    End Sub


    '------------------------------------------------------------
    '-                Subprogram Name: mnuFileExit_Click        -
    '------------------------------------------------------------
    '-                Written By: Alex Buckstiegel              -
    '-                Written On: 02-25-20                      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is the file -> Exit button, and exits the-
    '- forms
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (none)                                                   -
    '------------------------------------------------------------
    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        Me.Close()
    End Sub

    '------------------------------------------------------------
    '-                Subprogram Name: mnuWindowCascade_Click   -
    '------------------------------------------------------------
    '-                Written By: Alex Buckstiegel              -
    '-                Written On: 02-25-20                      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine sorts the open forms into the cascade
    '- layout
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (none)                                                   -
    '------------------------------------------------------------
    Private Sub mnuWindowCascade_Click(sender As Object, e As EventArgs) Handles mnuWindowCascade.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    '------------------------------------------------------------
    '-                Subprogram Name: mnuWindowTileHorizontal_Click
    '------------------------------------------------------------
    '-                Written By: Alex Buckstiegel              -
    '-                Written On: 02-25-20                      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine sorts the open forms into the horizontal
    '- tile layout
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (none)                                                   -
    '------------------------------------------------------------
    Private Sub mnuWindowTileHorizontal_Click(sender As Object, e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    '------------------------------------------------------------
    '-                Subprogram Name: mnuWindowTileVertical_Click
    '------------------------------------------------------------
    '-                Written By: Alex Buckstiegel              -
    '-                Written On: 02-25-20                      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine sorts the open forms into the vertical
    '- tile layout
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (none)                                                   -
    '------------------------------------------------------------
    Private Sub mnuWindowTileVertical_Click(sender As Object, e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub
End Class