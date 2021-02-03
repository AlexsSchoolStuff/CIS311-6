<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmParent
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindow = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindowCascade = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindowTileHorizontal = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindowTileVertical = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuWindow})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.MdiWindowListItem = Me.mnuWindow
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1869, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileNew, Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuFileNew
        '
        Me.mnuFileNew.Name = "mnuFileNew"
        Me.mnuFileNew.Size = New System.Drawing.Size(180, 22)
        Me.mnuFileNew.Text = "New"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(180, 22)
        Me.mnuFileExit.Text = "Exit"
        '
        'mnuWindow
        '
        Me.mnuWindow.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuWindowCascade, Me.TileToolStripMenuItem})
        Me.mnuWindow.Name = "mnuWindow"
        Me.mnuWindow.Size = New System.Drawing.Size(63, 20)
        Me.mnuWindow.Text = "&Window"
        '
        'mnuWindowCascade
        '
        Me.mnuWindowCascade.Name = "mnuWindowCascade"
        Me.mnuWindowCascade.Size = New System.Drawing.Size(118, 22)
        Me.mnuWindowCascade.Text = "Cascade"
        '
        'TileToolStripMenuItem
        '
        Me.TileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuWindowTileHorizontal, Me.mnuWindowTileVertical})
        Me.TileToolStripMenuItem.Name = "TileToolStripMenuItem"
        Me.TileToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.TileToolStripMenuItem.Text = "Tile"
        '
        'mnuWindowTileHorizontal
        '
        Me.mnuWindowTileHorizontal.Name = "mnuWindowTileHorizontal"
        Me.mnuWindowTileHorizontal.Size = New System.Drawing.Size(129, 22)
        Me.mnuWindowTileHorizontal.Text = "Horizontal"
        '
        'mnuWindowTileVertical
        '
        Me.mnuWindowTileVertical.Name = "mnuWindowTileVertical"
        Me.mnuWindowTileVertical.Size = New System.Drawing.Size(129, 22)
        Me.mnuWindowTileVertical.Text = "Vertical"
        '
        'frmParent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1869, 1006)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmParent"
        Me.Text = "Parent Form"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileNew As ToolStripMenuItem
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents mnuWindow As ToolStripMenuItem
    Friend WithEvents mnuWindowCascade As ToolStripMenuItem
    Friend WithEvents TileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuWindowTileHorizontal As ToolStripMenuItem
    Friend WithEvents mnuWindowTileVertical As ToolStripMenuItem
End Class
