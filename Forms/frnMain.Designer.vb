<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.btnFolderOne = New System.Windows.Forms.Button()
        Me.btnFolderTwo = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.pgbFile = New System.Windows.Forms.ProgressBar()
        Me.btnMergeRightCopy = New System.Windows.Forms.Button()
        Me.btnMergeLeftCopy = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.pgbTotal = New System.Windows.Forms.ProgressBar()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.lblDirectoryOne = New System.Windows.Forms.Label()
        Me.lblDirectoryTwo = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTotalPercent = New System.Windows.Forms.Label()
        Me.btnPauseResume = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnClearDir2 = New System.Windows.Forms.Button()
        Me.btnClearDir1 = New System.Windows.Forms.Button()
        Me.lblPctFile = New System.Windows.Forms.Label()
        Me.lblPctTotal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnFolderOne
        '
        Me.btnFolderOne.Location = New System.Drawing.Point(27, 28)
        Me.btnFolderOne.Name = "btnFolderOne"
        Me.btnFolderOne.Size = New System.Drawing.Size(229, 58)
        Me.btnFolderOne.TabIndex = 0
        Me.btnFolderOne.Text = "Get Directory"
        Me.btnFolderOne.UseVisualStyleBackColor = True
        '
        'btnFolderTwo
        '
        Me.btnFolderTwo.Location = New System.Drawing.Point(1102, 38)
        Me.btnFolderTwo.Name = "btnFolderTwo"
        Me.btnFolderTwo.Size = New System.Drawing.Size(222, 58)
        Me.btnFolderTwo.TabIndex = 1
        Me.btnFolderTwo.Text = "Get Directory"
        Me.btnFolderTwo.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 41
        Me.ListBox1.Location = New System.Drawing.Point(27, 423)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(614, 291)
        Me.ListBox1.TabIndex = 2
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 41
        Me.ListBox2.Location = New System.Drawing.Point(1102, 413)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(614, 291)
        Me.ListBox2.TabIndex = 3
        '
        'pgbFile
        '
        Me.pgbFile.Location = New System.Drawing.Point(27, 939)
        Me.pgbFile.Name = "pgbFile"
        Me.pgbFile.Size = New System.Drawing.Size(1592, 58)
        Me.pgbFile.TabIndex = 4
        '
        'btnMergeRightCopy
        '
        Me.btnMergeRightCopy.Location = New System.Drawing.Point(27, 735)
        Me.btnMergeRightCopy.Name = "btnMergeRightCopy"
        Me.btnMergeRightCopy.Size = New System.Drawing.Size(229, 58)
        Me.btnMergeRightCopy.TabIndex = 5
        Me.btnMergeRightCopy.Text = "Copy -->"
        Me.btnMergeRightCopy.UseVisualStyleBackColor = True
        '
        'btnMergeLeftCopy
        '
        Me.btnMergeLeftCopy.Location = New System.Drawing.Point(1102, 735)
        Me.btnMergeLeftCopy.Name = "btnMergeLeftCopy"
        Me.btnMergeLeftCopy.Size = New System.Drawing.Size(229, 58)
        Me.btnMergeLeftCopy.TabIndex = 6
        Me.btnMergeLeftCopy.Text = "<-- Copy"
        Me.btnMergeLeftCopy.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(411, 735)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(222, 58)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "Move -->"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(1494, 735)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(222, 58)
        Me.Button6.TabIndex = 8
        Me.Button6.Text = "<-- Move"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1744, 25)
        Me.ToolStrip1.TabIndex = 9
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'pgbTotal
        '
        Me.pgbTotal.Location = New System.Drawing.Point(27, 1062)
        Me.pgbTotal.Name = "pgbTotal"
        Me.pgbTotal.Size = New System.Drawing.Size(1592, 58)
        Me.pgbTotal.TabIndex = 10
        '
        'lblDirectoryOne
        '
        Me.lblDirectoryOne.Location = New System.Drawing.Point(27, 149)
        Me.lblDirectoryOne.Name = "lblDirectoryOne"
        Me.lblDirectoryOne.Size = New System.Drawing.Size(606, 271)
        Me.lblDirectoryOne.TabIndex = 12
        Me.lblDirectoryOne.Text = "Directory Path"
        '
        'lblDirectoryTwo
        '
        Me.lblDirectoryTwo.Location = New System.Drawing.Point(1102, 149)
        Me.lblDirectoryTwo.Name = "lblDirectoryTwo"
        Me.lblDirectoryTwo.Size = New System.Drawing.Size(614, 261)
        Me.lblDirectoryTwo.TabIndex = 13
        Me.lblDirectoryTwo.Text = "Directory Path"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 895)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(197, 41)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "File's Percent:"
        '
        'lblTotalPercent
        '
        Me.lblTotalPercent.AutoSize = True
        Me.lblTotalPercent.Location = New System.Drawing.Point(27, 1018)
        Me.lblTotalPercent.Name = "lblTotalPercent"
        Me.lblTotalPercent.Size = New System.Drawing.Size(195, 41)
        Me.lblTotalPercent.TabIndex = 16
        Me.lblTotalPercent.Text = "Total Percent:"
        '
        'btnPauseResume
        '
        Me.btnPauseResume.Location = New System.Drawing.Point(757, 423)
        Me.btnPauseResume.Name = "btnPauseResume"
        Me.btnPauseResume.Size = New System.Drawing.Size(229, 58)
        Me.btnPauseResume.TabIndex = 17
        Me.btnPauseResume.Text = "Pause"
        Me.btnPauseResume.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(764, 656)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(222, 58)
        Me.btnCancel.TabIndex = 18
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnClearDir2
        '
        Me.btnClearDir2.Location = New System.Drawing.Point(1483, 38)
        Me.btnClearDir2.Name = "btnClearDir2"
        Me.btnClearDir2.Size = New System.Drawing.Size(222, 58)
        Me.btnClearDir2.TabIndex = 19
        Me.btnClearDir2.Text = "Clear Directory"
        Me.btnClearDir2.UseVisualStyleBackColor = True
        '
        'btnClearDir1
        '
        Me.btnClearDir1.Location = New System.Drawing.Point(412, 28)
        Me.btnClearDir1.Name = "btnClearDir1"
        Me.btnClearDir1.Size = New System.Drawing.Size(229, 58)
        Me.btnClearDir1.TabIndex = 20
        Me.btnClearDir1.Text = "Clear Directory"
        Me.btnClearDir1.UseVisualStyleBackColor = True
        '
        'lblPctFile
        '
        Me.lblPctFile.AutoSize = True
        Me.lblPctFile.Location = New System.Drawing.Point(1625, 947)
        Me.lblPctFile.Name = "lblPctFile"
        Me.lblPctFile.Size = New System.Drawing.Size(59, 41)
        Me.lblPctFile.TabIndex = 21
        Me.lblPctFile.Text = "0%"
        '
        'lblPctTotal
        '
        Me.lblPctTotal.AutoSize = True
        Me.lblPctTotal.Location = New System.Drawing.Point(1625, 1070)
        Me.lblPctTotal.Name = "lblPctTotal"
        Me.lblPctTotal.Size = New System.Drawing.Size(59, 41)
        Me.lblPctTotal.TabIndex = 22
        Me.lblPctTotal.Text = "0%"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(17.0!, 41.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1744, 1142)
        Me.Controls.Add(Me.lblPctTotal)
        Me.Controls.Add(Me.lblPctFile)
        Me.Controls.Add(Me.btnClearDir1)
        Me.Controls.Add(Me.btnClearDir2)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnPauseResume)
        Me.Controls.Add(Me.lblTotalPercent)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblDirectoryTwo)
        Me.Controls.Add(Me.lblDirectoryOne)
        Me.Controls.Add(Me.pgbTotal)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.btnMergeLeftCopy)
        Me.Controls.Add(Me.btnMergeRightCopy)
        Me.Controls.Add(Me.pgbFile)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btnFolderTwo)
        Me.Controls.Add(Me.btnFolderOne)
        Me.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Path Merge"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnFolderOne As Button
    Friend WithEvents btnFolderTwo As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents pgbFile As ProgressBar
    Friend WithEvents btnMergeRightCopy As Button
    Friend WithEvents btnMergeLeftCopy As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents pgbTotal As ProgressBar
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblDirectoryOne As Label
    Friend WithEvents lblDirectoryTwo As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTotalPercent As Label
    Friend WithEvents btnPauseResume As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnClearDir2 As Button
    Friend WithEvents btnClearDir1 As Button
    Friend WithEvents lblPctFile As Label
    Friend WithEvents lblPctTotal As Label
End Class
