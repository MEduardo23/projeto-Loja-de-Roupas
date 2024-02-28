<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_relatorio_estoque
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.CadastroDataSet1 = New prj_loja.cadastroDataSet1()
        Me.TbestoqueBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_estoqueTableAdapter = New prj_loja.cadastroDataSet1TableAdapters.tb_estoqueTableAdapter()
        CType(Me.CadastroDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbestoqueBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.TbestoqueBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "prj_loja.Report2.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(859, 439)
        Me.ReportViewer1.TabIndex = 0
        '
        'CadastroDataSet1
        '
        Me.CadastroDataSet1.DataSetName = "cadastroDataSet1"
        Me.CadastroDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbestoqueBindingSource
        '
        Me.TbestoqueBindingSource.DataMember = "tb_estoque"
        Me.TbestoqueBindingSource.DataSource = Me.CadastroDataSet1
        '
        'Tb_estoqueTableAdapter
        '
        Me.Tb_estoqueTableAdapter.ClearBeforeFill = True
        '
        'frm_relatorio_estoque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 439)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frm_relatorio_estoque"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_relatorio_estoque"
        CType(Me.CadastroDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbestoqueBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents CadastroDataSet1 As prj_loja.cadastroDataSet1
    Friend WithEvents TbestoqueBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tb_estoqueTableAdapter As prj_loja.cadastroDataSet1TableAdapters.tb_estoqueTableAdapter
End Class
