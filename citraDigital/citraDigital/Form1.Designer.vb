<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUtama
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.PropertiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistogramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GreyscaleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerahkanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GelapkanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahKontrasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KurangiKontrasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TampilkanHistogramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EffectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TajamkanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KaburkanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Putar90DerajatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.FlipHorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FlipVertikalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.EdgeDetectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 28)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(633, 419)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HistogramToolStripMenuItem, Me.EffectToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(633, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.ToolStripMenuItem1, Me.PropertiesToolStripMenuItem, Me.ToolStripMenuItem2, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(159, 26)
        Me.OpenToolStripMenuItem.Text = "&Open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(159, 26)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(156, 6)
        '
        'PropertiesToolStripMenuItem
        '
        Me.PropertiesToolStripMenuItem.Name = "PropertiesToolStripMenuItem"
        Me.PropertiesToolStripMenuItem.Size = New System.Drawing.Size(159, 26)
        Me.PropertiesToolStripMenuItem.Text = "Properties"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(156, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(159, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HistogramToolStripMenuItem
        '
        Me.HistogramToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GreyscaleToolStripMenuItem, Me.CerahkanToolStripMenuItem, Me.GelapkanToolStripMenuItem, Me.TambahKontrasToolStripMenuItem, Me.KurangiKontrasToolStripMenuItem, Me.ToolStripMenuItem3, Me.ResetToolStripMenuItem, Me.TampilkanHistogramToolStripMenuItem})
        Me.HistogramToolStripMenuItem.Name = "HistogramToolStripMenuItem"
        Me.HistogramToolStripMenuItem.Size = New System.Drawing.Size(93, 24)
        Me.HistogramToolStripMenuItem.Text = "Histogram"
        '
        'GreyscaleToolStripMenuItem
        '
        Me.GreyscaleToolStripMenuItem.Name = "GreyscaleToolStripMenuItem"
        Me.GreyscaleToolStripMenuItem.Size = New System.Drawing.Size(233, 26)
        Me.GreyscaleToolStripMenuItem.Text = "Greyscale"
        '
        'CerahkanToolStripMenuItem
        '
        Me.CerahkanToolStripMenuItem.Name = "CerahkanToolStripMenuItem"
        Me.CerahkanToolStripMenuItem.Size = New System.Drawing.Size(233, 26)
        Me.CerahkanToolStripMenuItem.Text = "Cerahkan"
        '
        'GelapkanToolStripMenuItem
        '
        Me.GelapkanToolStripMenuItem.Name = "GelapkanToolStripMenuItem"
        Me.GelapkanToolStripMenuItem.Size = New System.Drawing.Size(233, 26)
        Me.GelapkanToolStripMenuItem.Text = "Gelapkan"
        '
        'TambahKontrasToolStripMenuItem
        '
        Me.TambahKontrasToolStripMenuItem.Name = "TambahKontrasToolStripMenuItem"
        Me.TambahKontrasToolStripMenuItem.Size = New System.Drawing.Size(233, 26)
        Me.TambahKontrasToolStripMenuItem.Text = "Tambah Kontras"
        '
        'KurangiKontrasToolStripMenuItem
        '
        Me.KurangiKontrasToolStripMenuItem.Name = "KurangiKontrasToolStripMenuItem"
        Me.KurangiKontrasToolStripMenuItem.Size = New System.Drawing.Size(233, 26)
        Me.KurangiKontrasToolStripMenuItem.Text = "Kurangi Kontras"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(230, 6)
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(233, 26)
        Me.ResetToolStripMenuItem.Text = "Reset"
        '
        'TampilkanHistogramToolStripMenuItem
        '
        Me.TampilkanHistogramToolStripMenuItem.Name = "TampilkanHistogramToolStripMenuItem"
        Me.TampilkanHistogramToolStripMenuItem.Size = New System.Drawing.Size(233, 26)
        Me.TampilkanHistogramToolStripMenuItem.Text = "Tampilkan Histogram"
        '
        'EffectToolStripMenuItem
        '
        Me.EffectToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TajamkanToolStripMenuItem, Me.KaburkanToolStripMenuItem, Me.EdgeDetectionToolStripMenuItem, Me.Putar90DerajatToolStripMenuItem, Me.ToolStripMenuItem4, Me.FlipHorizontalToolStripMenuItem, Me.FlipVertikalToolStripMenuItem})
        Me.EffectToolStripMenuItem.Name = "EffectToolStripMenuItem"
        Me.EffectToolStripMenuItem.Size = New System.Drawing.Size(67, 24)
        Me.EffectToolStripMenuItem.Text = "Effects"
        '
        'TajamkanToolStripMenuItem
        '
        Me.TajamkanToolStripMenuItem.Name = "TajamkanToolStripMenuItem"
        Me.TajamkanToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.TajamkanToolStripMenuItem.Text = "Tajamkan"
        '
        'KaburkanToolStripMenuItem
        '
        Me.KaburkanToolStripMenuItem.Name = "KaburkanToolStripMenuItem"
        Me.KaburkanToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.KaburkanToolStripMenuItem.Text = "Kaburkan"
        '
        'Putar90DerajatToolStripMenuItem
        '
        Me.Putar90DerajatToolStripMenuItem.Name = "Putar90DerajatToolStripMenuItem"
        Me.Putar90DerajatToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.Putar90DerajatToolStripMenuItem.Text = "Putar 90 derajat"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(221, 6)
        '
        'FlipHorizontalToolStripMenuItem
        '
        Me.FlipHorizontalToolStripMenuItem.Name = "FlipHorizontalToolStripMenuItem"
        Me.FlipHorizontalToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.FlipHorizontalToolStripMenuItem.Text = "Flip Horizontal"
        '
        'FlipVertikalToolStripMenuItem
        '
        Me.FlipVertikalToolStripMenuItem.Name = "FlipVertikalToolStripMenuItem"
        Me.FlipVertikalToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.FlipVertikalToolStripMenuItem.Text = "Flip Vertikal"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'EdgeDetectionToolStripMenuItem
        '
        Me.EdgeDetectionToolStripMenuItem.Name = "EdgeDetectionToolStripMenuItem"
        Me.EdgeDetectionToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.EdgeDetectionToolStripMenuItem.Text = "Gaussian Blur"
        '
        'frmUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 447)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmUtama"
        Me.Text = "Pengolahan Citra"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents PropertiesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistogramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GreyscaleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerahkanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GelapkanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TambahKontrasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KurangiKontrasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EffectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents ResetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TampilkanHistogramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TajamkanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KaburkanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Putar90DerajatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripSeparator
    Friend WithEvents FlipHorizontalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FlipVertikalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EdgeDetectionToolStripMenuItem As ToolStripMenuItem
End Class
