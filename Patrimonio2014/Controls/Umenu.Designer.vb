<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Umenu
    Inherits System.Windows.Forms.UserControl

    'UserControl esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Termina")
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Opzioni")
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("File", New System.Windows.Forms.TreeNode() {TreeNode17, TreeNode18})
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Movimentazione")
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Preventivi")
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Avvisi")
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Convocazioni")
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Consuntivi")
        Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Nodo3")
        Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fornitori")
        Dim TreeNode27 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Nodo5")
        Dim TreeNode28 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Archivi", New System.Windows.Forms.TreeNode() {TreeNode25, TreeNode26, TreeNode27})
        Dim TreeNode29 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ritenute d'acconto")
        Dim TreeNode30 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Informazioni sul software")
        Dim TreeNode31 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Informazioni sulla licenza")
        Dim TreeNode32 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Info", New System.Windows.Forms.TreeNode() {TreeNode30, TreeNode31})
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Right
        Me.TreeView1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView1.Location = New System.Drawing.Point(16, 0)
        Me.TreeView1.Name = "TreeView1"
        TreeNode17.Name = "Termina"
        TreeNode17.Text = "Termina"
        TreeNode18.Name = "Opzioni"
        TreeNode18.Text = "Opzioni"
        TreeNode19.Name = "File"
        TreeNode19.Text = "File"
        TreeNode20.Name = "Movimentazione"
        TreeNode20.Text = "Movimentazione"
        TreeNode21.Name = "Preventivi"
        TreeNode21.Text = "Preventivi"
        TreeNode22.Name = "Avvisi"
        TreeNode22.Text = "Avvisi"
        TreeNode23.Name = "Convocazioni"
        TreeNode23.Text = "Convocazioni"
        TreeNode24.Name = "Consuntivi"
        TreeNode24.Text = "Consuntivi"
        TreeNode25.Name = "Nodo3"
        TreeNode25.Text = "Nodo3"
        TreeNode26.Name = "Fornitori"
        TreeNode26.Text = "Fornitori"
        TreeNode27.Name = "Nodo5"
        TreeNode27.Text = "Nodo5"
        TreeNode28.Name = "Archivi"
        TreeNode28.Text = "Archivi"
        TreeNode29.Name = "Ritenute d'acconto"
        TreeNode29.Text = "Ritenute d'acconto"
        TreeNode30.Name = "Informazioni sul software"
        TreeNode30.Text = "Informazioni sul software"
        TreeNode31.Name = "Informazioni sulla licenza"
        TreeNode31.Text = "Informazioni sulla licenza"
        TreeNode32.Name = "Info"
        TreeNode32.Text = "Info"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode19, TreeNode20, TreeNode21, TreeNode22, TreeNode23, TreeNode24, TreeNode28, TreeNode29, TreeNode32})
        Me.TreeView1.Size = New System.Drawing.Size(140, 372)
        Me.TreeView1.TabIndex = 4
        '
        'Umenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TreeView1)
        Me.Name = "Umenu"
        Me.Size = New System.Drawing.Size(156, 372)
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents TreeView1 As System.Windows.Forms.TreeView

End Class
