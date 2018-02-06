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
        Me.btnVirginia = New System.Windows.Forms.Button()
        Me.btnNC = New System.Windows.Forms.Button()
        Me.btnSC = New System.Windows.Forms.Button()
        Me.btnGeorgia = New System.Windows.Forms.Button()
        Me.btnAlabama = New System.Windows.Forms.Button()
        Me.btnFlorida = New System.Windows.Forms.Button()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnVirginia
        '
        Me.btnVirginia.Location = New System.Drawing.Point(25, 204)
        Me.btnVirginia.Name = "btnVirginia"
        Me.btnVirginia.Size = New System.Drawing.Size(75, 23)
        Me.btnVirginia.TabIndex = 0
        Me.btnVirginia.Text = "Virginia"
        Me.btnVirginia.UseVisualStyleBackColor = True
        '
        'btnNC
        '
        Me.btnNC.Location = New System.Drawing.Point(129, 204)
        Me.btnNC.Name = "btnNC"
        Me.btnNC.Size = New System.Drawing.Size(75, 23)
        Me.btnNC.TabIndex = 1
        Me.btnNC.Text = "North Carolina"
        Me.btnNC.UseVisualStyleBackColor = True
        '
        'btnSC
        '
        Me.btnSC.Location = New System.Drawing.Point(238, 204)
        Me.btnSC.Name = "btnSC"
        Me.btnSC.Size = New System.Drawing.Size(75, 23)
        Me.btnSC.TabIndex = 2
        Me.btnSC.Text = "South Carolina"
        Me.btnSC.UseVisualStyleBackColor = True
        '
        'btnGeorgia
        '
        Me.btnGeorgia.Location = New System.Drawing.Point(336, 204)
        Me.btnGeorgia.Name = "btnGeorgia"
        Me.btnGeorgia.Size = New System.Drawing.Size(75, 23)
        Me.btnGeorgia.TabIndex = 3
        Me.btnGeorgia.Text = "Georgia"
        Me.btnGeorgia.UseVisualStyleBackColor = True
        '
        'btnAlabama
        '
        Me.btnAlabama.Location = New System.Drawing.Point(456, 204)
        Me.btnAlabama.Name = "btnAlabama"
        Me.btnAlabama.Size = New System.Drawing.Size(75, 23)
        Me.btnAlabama.TabIndex = 4
        Me.btnAlabama.Text = "Alabama"
        Me.btnAlabama.UseVisualStyleBackColor = True
        '
        'btnFlorida
        '
        Me.btnFlorida.Location = New System.Drawing.Point(564, 204)
        Me.btnFlorida.Name = "btnFlorida"
        Me.btnFlorida.Size = New System.Drawing.Size(81, 23)
        Me.btnFlorida.TabIndex = 5
        Me.btnFlorida.Text = "Florida"
        Me.btnFlorida.UseVisualStyleBackColor = True
        '
        'lblDisplay
        '
        Me.lblDisplay.AutoSize = True
        Me.lblDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplay.Location = New System.Drawing.Point(286, 29)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(0, 24)
        Me.lblDisplay.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(691, 261)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.btnFlorida)
        Me.Controls.Add(Me.btnAlabama)
        Me.Controls.Add(Me.btnGeorgia)
        Me.Controls.Add(Me.btnSC)
        Me.Controls.Add(Me.btnNC)
        Me.Controls.Add(Me.btnVirginia)
        Me.Name = "Form1"
        Me.Text = "State Abbreviations"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnVirginia As Button
    Friend WithEvents btnNC As Button
    Friend WithEvents btnSC As Button
    Friend WithEvents btnGeorgia As Button
    Friend WithEvents btnAlabama As Button
    Friend WithEvents btnFlorida As Button
    Friend WithEvents lblDisplay As Label
End Class
