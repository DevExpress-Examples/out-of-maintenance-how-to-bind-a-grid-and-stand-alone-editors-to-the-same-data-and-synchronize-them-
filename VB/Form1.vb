Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace SyncStandaloneEditor
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		Friend PanelControl1 As DevExpress.XtraEditors.PanelControl
		Friend DataNavigator1 As DevExpress.XtraEditors.DataNavigator
		Friend TextEdit1 As DevExpress.XtraEditors.TextEdit
		Friend SpinEdit1 As DevExpress.XtraEditors.SpinEdit
		Friend Label3 As System.Windows.Forms.Label
		Friend Label2 As System.Windows.Forms.Label
		Friend Label1 As System.Windows.Forms.Label
		Friend MemoEdit1 As DevExpress.XtraEditors.MemoEdit
		Friend colName As DevExpress.XtraGrid.Columns.GridColumn
		Friend GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Friend colID As DevExpress.XtraGrid.Columns.GridColumn
		Friend GridControl1 As DevExpress.XtraGrid.GridControl
		Friend DataColumn2 As System.Data.DataColumn
		Friend DataColumn3 As System.Data.DataColumn
		Friend DataTable1 As System.Data.DataTable
		Friend DataColumn1 As System.Data.DataColumn
		Friend DataSet1 As System.Data.DataSet
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.DataNavigator1 = New DevExpress.XtraEditors.DataNavigator()
			Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
			Me.SpinEdit1 = New DevExpress.XtraEditors.SpinEdit()
			Me.Label3 = New System.Windows.Forms.Label()
			Me.Label2 = New System.Windows.Forms.Label()
			Me.Label1 = New System.Windows.Forms.Label()
			Me.MemoEdit1 = New DevExpress.XtraEditors.MemoEdit()
			Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.DataColumn2 = New System.Data.DataColumn()
			Me.DataColumn3 = New System.Data.DataColumn()
			Me.DataTable1 = New System.Data.DataTable()
			Me.DataColumn1 = New System.Data.DataColumn()
			Me.DataSet1 = New System.Data.DataSet()
			CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.PanelControl1.SuspendLayout()
			CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' PanelControl1
			' 
			Me.PanelControl1.Controls.Add(Me.DataNavigator1)
			Me.PanelControl1.Controls.Add(Me.TextEdit1)
			Me.PanelControl1.Controls.Add(Me.SpinEdit1)
			Me.PanelControl1.Controls.Add(Me.Label3)
			Me.PanelControl1.Controls.Add(Me.Label2)
			Me.PanelControl1.Controls.Add(Me.Label1)
			Me.PanelControl1.Controls.Add(Me.MemoEdit1)
			Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
			Me.PanelControl1.Name = "PanelControl1"
			Me.PanelControl1.Size = New System.Drawing.Size(440, 120)
			Me.PanelControl1.TabIndex = 5
			' 
			' DataNavigator1
			' 
			Me.DataNavigator1.Location = New System.Drawing.Point(8, 88)
			Me.DataNavigator1.Name = "DataNavigator1"
			Me.DataNavigator1.Size = New System.Drawing.Size(222, 24)
			Me.DataNavigator1.TabIndex = 7
			Me.DataNavigator1.Text = "DataNavigator1"
			' 
			' TextEdit1
			' 
			Me.TextEdit1.EditValue = "TextEdit1"
			Me.TextEdit1.Location = New System.Drawing.Point(80, 48)
			Me.TextEdit1.Name = "TextEdit1"
			Me.TextEdit1.Size = New System.Drawing.Size(100, 20)
			Me.TextEdit1.TabIndex = 6
			' 
			' SpinEdit1
			' 
			Me.SpinEdit1.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.SpinEdit1.Location = New System.Drawing.Point(80, 16)
			Me.SpinEdit1.Name = "SpinEdit1"
			Me.SpinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.SpinEdit1.Size = New System.Drawing.Size(100, 20)
			Me.SpinEdit1.TabIndex = 5
			' 
			' Label3
			' 
			Me.Label3.Location = New System.Drawing.Point(208, 16)
			Me.Label3.Name = "Label3"
			Me.Label3.Size = New System.Drawing.Size(48, 24)
			Me.Label3.TabIndex = 4
			Me.Label3.Text = "Notes:"
			' 
			' Label2
			' 
			Me.Label2.Location = New System.Drawing.Point(8, 48)
			Me.Label2.Name = "Label2"
			Me.Label2.Size = New System.Drawing.Size(48, 16)
			Me.Label2.TabIndex = 3
			Me.Label2.Text = "Name:"
			' 
			' Label1
			' 
			Me.Label1.Location = New System.Drawing.Point(8, 16)
			Me.Label1.Name = "Label1"
			Me.Label1.Size = New System.Drawing.Size(48, 16)
			Me.Label1.TabIndex = 2
			Me.Label1.Text = "ID:"
			' 
			' MemoEdit1
			' 
			Me.MemoEdit1.EditValue = "MemoEdit1"
			Me.MemoEdit1.Location = New System.Drawing.Point(264, 16)
			Me.MemoEdit1.Name = "MemoEdit1"
			Me.MemoEdit1.Size = New System.Drawing.Size(168, 96)
			Me.MemoEdit1.TabIndex = 1
			' 
			' colName
			' 
			Me.colName.Caption = "Name"
			Me.colName.FieldName = "Name"
			Me.colName.Name = "colName"
			Me.colName.Visible = True
			Me.colName.VisibleIndex = 1
			' 
			' GridView1
			' 
			Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colID, Me.colName})
			Me.GridView1.GridControl = Me.GridControl1
			Me.GridView1.Name = "GridView1"
			' 
			' colID
			' 
			Me.colID.Caption = "ID"
			Me.colID.FieldName = "ID"
			Me.colID.Name = "colID"
			Me.colID.Visible = True
			Me.colID.VisibleIndex = 0
			' 
			' GridControl1
			' 
			Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.GridControl1.Location = New System.Drawing.Point(0, 120)
			Me.GridControl1.MainView = Me.GridView1
			Me.GridControl1.Name = "GridControl1"
			Me.GridControl1.Size = New System.Drawing.Size(440, 218)
			Me.GridControl1.TabIndex = 4
			Me.GridControl1.UseEmbeddedNavigator = True
			Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.GridView1})
			' 
			' DataColumn2
			' 
			Me.DataColumn2.ColumnName = "Name"
			' 
			' DataColumn3
			' 
			Me.DataColumn3.ColumnName = "Notes"
			' 
			' DataTable1
			' 
			Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() { Me.DataColumn1, Me.DataColumn2, Me.DataColumn3})
			Me.DataTable1.TableName = "Table1"
			' 
			' DataColumn1
			' 
			Me.DataColumn1.ColumnName = "ID"
			Me.DataColumn1.DataType = GetType(Integer)
			' 
			' DataSet1
			' 
			Me.DataSet1.DataSetName = "NewDataSet"
			Me.DataSet1.Locale = New System.Globalization.CultureInfo("en-US")
			Me.DataSet1.Tables.AddRange(New System.Data.DataTable() { Me.DataTable1})
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(440, 338)
			Me.Controls.Add(Me.GridControl1)
			Me.Controls.Add(Me.PanelControl1)
			Me.Name = "Form1"
			Me.Text = "How to bind a grid and stand alone editors to the same data and synchronize them"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.PanelControl1.ResumeLayout(False)
			CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		Private Sub FillDataTable()
			For i As Integer = 1 To 10
				DataTable1.Rows.Add(New Object() {i, "Item " & i.ToString(), "Custom notes for Item " & i.ToString()})
			Next i
		End Sub

		Private Sub DataBind()
			' You can bind controls at design-time instead of using this code
			GridControl1.DataSource = DataSet1
			GridControl1.DataMember = "Table1"

			SpinEdit1.DataBindings.Add("EditValue", DataSet1, "Table1.ID")
			TextEdit1.DataBindings.Add("EditValue", DataSet1, "Table1.Name")
			MemoEdit1.DataBindings.Add("EditValue", DataSet1, "Table1.Notes")

			DataNavigator1.DataSource = DataSet1
			DataNavigator1.DataMember = "Table1"
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			FillDataTable()
			DataBind()
		End Sub
	End Class
End Namespace
