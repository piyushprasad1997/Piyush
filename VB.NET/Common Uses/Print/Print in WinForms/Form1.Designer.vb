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
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.LoadFileMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintFileMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.printPreviewControl = New System.Windows.Forms.PrintPreviewControl()
        Me.PageUpDown = New System.Windows.Forms.NumericUpDown()
        Me.PageLb = New System.Windows.Forms.Label()
        Me.MenuStrip.SuspendLayout()
        CType(Me.PageUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadFileMenuItem, Me.PrintFileMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip.Size = New System.Drawing.Size(1045, 28)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip"
        '
        'LoadFileMenuItem
        '
        Me.LoadFileMenuItem.Name = "LoadFileMenuItem"
        Me.LoadFileMenuItem.Size = New System.Drawing.Size(54, 24)
        Me.LoadFileMenuItem.Text = "Load"
        '
        'PrintFileMenuItem
        '
        Me.PrintFileMenuItem.Name = "PrintFileMenuItem"
        Me.PrintFileMenuItem.Size = New System.Drawing.Size(51, 24)
        Me.PrintFileMenuItem.Text = "Print"
        '
        'printPreviewControl
        '
        Me.printPreviewControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.printPreviewControl.Location = New System.Drawing.Point(0, 65)
        Me.printPreviewControl.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.printPreviewControl.Name = "printPreviewControl"
        Me.printPreviewControl.Size = New System.Drawing.Size(1045, 441)
        Me.printPreviewControl.TabIndex = 9
        '
        'PageUpDown
        '
        Me.PageUpDown.Location = New System.Drawing.Point(71, 36)
        Me.PageUpDown.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PageUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.PageUpDown.Name = "PageUpDown"
        Me.PageUpDown.Size = New System.Drawing.Size(53, 22)
        Me.PageUpDown.TabIndex = 8
        Me.PageUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'PageLb
        '
        Me.PageLb.AutoSize = True
        Me.PageLb.Location = New System.Drawing.Point(16, 41)
        Me.PageLb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PageLb.Name = "PageLb"
        Me.PageLb.Size = New System.Drawing.Size(45, 17)
        Me.PageLb.TabIndex = 7
        Me.PageLb.Text = "Page:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1045, 506)
        Me.Controls.Add(Me.printPreviewControl)
        Me.Controls.Add(Me.PageUpDown)
        Me.Controls.Add(Me.PageLb)
        Me.Controls.Add(Me.MenuStrip)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Printing in Windows Forms application"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        CType(Me.PageUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents LoadFileMenuItem As ToolStripMenuItem
    Friend WithEvents PrintFileMenuItem As ToolStripMenuItem
    Private WithEvents printPreviewControl As PrintPreviewControl
    Private WithEvents PageUpDown As NumericUpDown
    Private WithEvents PageLb As Label
End Class
