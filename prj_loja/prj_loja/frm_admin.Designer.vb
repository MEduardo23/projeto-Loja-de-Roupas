<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_admin
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_admin))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ESTOQUEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GERENCIAMENTOCONTASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RELATÓRIOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaDeVendasPorCódigoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaDeEstoqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbl_usuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbl_data = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbl_hora = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Gill Sans MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ESTOQUEToolStripMenuItem, Me.GERENCIAMENTOCONTASToolStripMenuItem, Me.RELATÓRIOSToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(708, 31)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ESTOQUEToolStripMenuItem
        '
        Me.ESTOQUEToolStripMenuItem.Image = CType(resources.GetObject("ESTOQUEToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ESTOQUEToolStripMenuItem.Name = "ESTOQUEToolStripMenuItem"
        Me.ESTOQUEToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.ESTOQUEToolStripMenuItem.Size = New System.Drawing.Size(116, 25)
        Me.ESTOQUEToolStripMenuItem.Text = "&ESTOQUE"
        Me.ESTOQUEToolStripMenuItem.ToolTipText = "Estoque"
        '
        'GERENCIAMENTOCONTASToolStripMenuItem
        '
        Me.GERENCIAMENTOCONTASToolStripMenuItem.Image = CType(resources.GetObject("GERENCIAMENTOCONTASToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GERENCIAMENTOCONTASToolStripMenuItem.Name = "GERENCIAMENTOCONTASToolStripMenuItem"
        Me.GERENCIAMENTOCONTASToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.GERENCIAMENTOCONTASToolStripMenuItem.Size = New System.Drawing.Size(254, 25)
        Me.GERENCIAMENTOCONTASToolStripMenuItem.Text = "&GERENCIAMENTO CONTAS"
        Me.GERENCIAMENTOCONTASToolStripMenuItem.ToolTipText = "Manutenção"
        '
        'RELATÓRIOSToolStripMenuItem
        '
        Me.RELATÓRIOSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListaDeClientesToolStripMenuItem, Me.ListaDeVendasPorCódigoToolStripMenuItem, Me.ListaDeEstoqueToolStripMenuItem})
        Me.RELATÓRIOSToolStripMenuItem.Image = CType(resources.GetObject("RELATÓRIOSToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RELATÓRIOSToolStripMenuItem.Name = "RELATÓRIOSToolStripMenuItem"
        Me.RELATÓRIOSToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.RELATÓRIOSToolStripMenuItem.Size = New System.Drawing.Size(140, 25)
        Me.RELATÓRIOSToolStripMenuItem.Text = "&RELATÓRIOS"
        '
        'ListaDeClientesToolStripMenuItem
        '
        Me.ListaDeClientesToolStripMenuItem.Name = "ListaDeClientesToolStripMenuItem"
        Me.ListaDeClientesToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ListaDeClientesToolStripMenuItem.Size = New System.Drawing.Size(330, 26)
        Me.ListaDeClientesToolStripMenuItem.Text = "Lista de Clientes"
        '
        'ListaDeVendasPorCódigoToolStripMenuItem
        '
        Me.ListaDeVendasPorCódigoToolStripMenuItem.Name = "ListaDeVendasPorCódigoToolStripMenuItem"
        Me.ListaDeVendasPorCódigoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F5), System.Windows.Forms.Keys)
        Me.ListaDeVendasPorCódigoToolStripMenuItem.Size = New System.Drawing.Size(330, 26)
        Me.ListaDeVendasPorCódigoToolStripMenuItem.Text = "Lista de Vendas por Código"
        '
        'ListaDeEstoqueToolStripMenuItem
        '
        Me.ListaDeEstoqueToolStripMenuItem.Name = "ListaDeEstoqueToolStripMenuItem"
        Me.ListaDeEstoqueToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F6), System.Windows.Forms.Keys)
        Me.ListaDeEstoqueToolStripMenuItem.Size = New System.Drawing.Size(330, 26)
        Me.ListaDeEstoqueToolStripMenuItem.Text = "Lista de Estoque"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lbl_usuario, Me.ToolStripStatusLabel2, Me.lbl_data, Me.ToolStripStatusLabel3, Me.lbl_hora})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 325)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(708, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(117, 17)
        Me.ToolStripStatusLabel1.Text = "NOME DO USUÁRIO:"
        '
        'lbl_usuario
        '
        Me.lbl_usuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_usuario.ForeColor = System.Drawing.Color.White
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(119, 17)
        Me.lbl_usuario.Text = "ToolStripStatusLabel2"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolStripStatusLabel2.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(38, 17)
        Me.ToolStripStatusLabel2.Text = "DATA:"
        '
        'lbl_data
        '
        Me.lbl_data.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_data.ForeColor = System.Drawing.Color.White
        Me.lbl_data.Name = "lbl_data"
        Me.lbl_data.Size = New System.Drawing.Size(119, 17)
        Me.lbl_data.Text = "ToolStripStatusLabel3"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolStripStatusLabel3.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(43, 17)
        Me.ToolStripStatusLabel3.Text = "HORA:"
        '
        'lbl_hora
        '
        Me.lbl_hora.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_hora.ForeColor = System.Drawing.Color.White
        Me.lbl_hora.Name = "lbl_hora"
        Me.lbl_hora.Size = New System.Drawing.Size(119, 17)
        Me.lbl_hora.Text = "ToolStripStatusLabel4"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(246, 105)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(216, 136)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'frm_admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(708, 347)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frm_admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MENU ADMINISTRADOR"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ESTOQUEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GERENCIAMENTOCONTASToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RELATÓRIOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListaDeClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListaDeVendasPorCódigoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbl_usuario As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbl_data As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbl_hora As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ListaDeEstoqueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
