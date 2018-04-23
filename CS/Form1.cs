using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace SyncStandaloneEditor
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form {
		internal DevExpress.XtraEditors.PanelControl PanelControl1;
		internal DevExpress.XtraEditors.DataNavigator DataNavigator1;
		internal DevExpress.XtraEditors.TextEdit TextEdit1;
		internal DevExpress.XtraEditors.SpinEdit SpinEdit1;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label1;
		internal DevExpress.XtraEditors.MemoEdit MemoEdit1;
		internal DevExpress.XtraGrid.Columns.GridColumn colName;
		internal DevExpress.XtraGrid.Views.Grid.GridView GridView1;
		internal DevExpress.XtraGrid.Columns.GridColumn colID;
		internal DevExpress.XtraGrid.GridControl GridControl1;
		internal System.Data.DataColumn DataColumn2;
		internal System.Data.DataColumn DataColumn3;
		internal System.Data.DataTable DataTable1;
		internal System.Data.DataColumn DataColumn1;
		internal System.Data.DataSet DataSet1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing ) {
			if( disposing ) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.PanelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.DataNavigator1 = new DevExpress.XtraEditors.DataNavigator();
            this.TextEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.SpinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.MemoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridControl1 = new DevExpress.XtraGrid.GridControl();
            this.DataColumn2 = new System.Data.DataColumn();
            this.DataColumn3 = new System.Data.DataColumn();
            this.DataTable1 = new System.Data.DataTable();
            this.DataColumn1 = new System.Data.DataColumn();
            this.DataSet1 = new System.Data.DataSet();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl1)).BeginInit();
            this.PanelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpinEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelControl1
            // 
            this.PanelControl1.Controls.Add(this.DataNavigator1);
            this.PanelControl1.Controls.Add(this.TextEdit1);
            this.PanelControl1.Controls.Add(this.SpinEdit1);
            this.PanelControl1.Controls.Add(this.Label3);
            this.PanelControl1.Controls.Add(this.Label2);
            this.PanelControl1.Controls.Add(this.Label1);
            this.PanelControl1.Controls.Add(this.MemoEdit1);
            this.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelControl1.Location = new System.Drawing.Point(0, 0);
            this.PanelControl1.Name = "PanelControl1";
            this.PanelControl1.Size = new System.Drawing.Size(440, 120);
            this.PanelControl1.TabIndex = 5;
            // 
            // DataNavigator1
            // 
            this.DataNavigator1.Location = new System.Drawing.Point(8, 88);
            this.DataNavigator1.Name = "DataNavigator1";
            this.DataNavigator1.Size = new System.Drawing.Size(222, 24);
            this.DataNavigator1.TabIndex = 7;
            this.DataNavigator1.Text = "DataNavigator1";
            // 
            // TextEdit1
            // 
            this.TextEdit1.EditValue = "TextEdit1";
            this.TextEdit1.Location = new System.Drawing.Point(80, 48);
            this.TextEdit1.Name = "TextEdit1";
            this.TextEdit1.Size = new System.Drawing.Size(100, 20);
            this.TextEdit1.TabIndex = 6;
            // 
            // SpinEdit1
            // 
            this.SpinEdit1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.SpinEdit1.Location = new System.Drawing.Point(80, 16);
            this.SpinEdit1.Name = "SpinEdit1";
            this.SpinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.SpinEdit1.Size = new System.Drawing.Size(100, 20);
            this.SpinEdit1.TabIndex = 5;
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(208, 16);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(48, 24);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "Notes:";
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(8, 48);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(48, 16);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "Name:";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(8, 16);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(48, 16);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "ID:";
            // 
            // MemoEdit1
            // 
            this.MemoEdit1.EditValue = "MemoEdit1";
            this.MemoEdit1.Location = new System.Drawing.Point(264, 16);
            this.MemoEdit1.Name = "MemoEdit1";
            this.MemoEdit1.Size = new System.Drawing.Size(168, 96);
            this.MemoEdit1.TabIndex = 1;
            // 
            // colName
            // 
            this.colName.Caption = "Name";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            // 
            // GridView1
            // 
            this.GridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colName});
            this.GridView1.GridControl = this.GridControl1;
            this.GridView1.Name = "GridView1";
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // GridControl1
            // 
            this.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridControl1.Location = new System.Drawing.Point(0, 120);
            this.GridControl1.MainView = this.GridView1;
            this.GridControl1.Name = "GridControl1";
            this.GridControl1.Size = new System.Drawing.Size(440, 218);
            this.GridControl1.TabIndex = 4;
            this.GridControl1.UseEmbeddedNavigator = true;
            this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridView1});
            // 
            // DataColumn2
            // 
            this.DataColumn2.ColumnName = "Name";
            // 
            // DataColumn3
            // 
            this.DataColumn3.ColumnName = "Notes";
            // 
            // DataTable1
            // 
            this.DataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.DataColumn1,
            this.DataColumn2,
            this.DataColumn3});
            this.DataTable1.TableName = "Table1";
            // 
            // DataColumn1
            // 
            this.DataColumn1.ColumnName = "ID";
            this.DataColumn1.DataType = typeof(int);
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "NewDataSet";
            this.DataSet1.Locale = new System.Globalization.CultureInfo("en-US");
            this.DataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.DataTable1});
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(440, 338);
            this.Controls.Add(this.GridControl1);
            this.Controls.Add(this.PanelControl1);
            this.Name = "Form1";
            this.Text = "How to bind a grid and stand alone editors to the same data and synchronize them";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl1)).EndInit();
            this.PanelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpinEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.Run(new Form1());
		}

		void FillDataTable() {
			for(int i = 1; i <= 10; i++)
				DataTable1.Rows.Add(new Object[] {i, "Item " + i.ToString(), "Custom notes for Item " + i.ToString()});
		}

		void DataBind() {
			// You can bind controls at design-time instead of using this code
			GridControl1.DataSource = DataSet1;
			GridControl1.DataMember = "Table1";

			SpinEdit1.DataBindings.Add("EditValue", DataSet1, "Table1.ID");
			TextEdit1.DataBindings.Add("EditValue", DataSet1, "Table1.Name");
			MemoEdit1.DataBindings.Add("EditValue", DataSet1, "Table1.Notes");

			DataNavigator1.DataSource = DataSet1;
			DataNavigator1.DataMember = "Table1";
		}

		private void Form1_Load(object sender, System.EventArgs e) {
			FillDataTable();
			DataBind();
		}
	}
}
