using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Telerik.WinControls.Enumerations;
using Telerik.Examples.WinControls.Properties;
using Telerik.Data.Expressions;
using System.IO;
using System.Reflection;
using System.Globalization;
using System.Threading;

namespace Telerik.Examples.WinControls.GridView.ManipulateData.Expressions
{
	public partial class Form1 : ExamplesForm
	{
		#region Fields
		private const int InitialRowsNum = 5;
		private List<Bitmap> bitmaps = new List<Bitmap>();

		private int columnNum;
		private string[] columnTypes = new string[] {
			"NumericText",
			"Decimal",
			"DateTime",
			"CheckBox",
			"CustomExpression"
		};
		#endregion

		public Form1()
		{
			InitializeComponent();
            this.radGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
			ExpressionContext.Context = new CustomExpressionContext();
			LoadExpressionFunctionListFromExternalXML();
		}
        
        private void LoadExpressionFunctionListFromExternalXML()
		{
			string path = "Telerik.Examples.WinControls.GridView.Expressions.ExpressionItemsListData.xml";
			Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(path);
			RadExpressionEditorForm.ExpressionItemsList.LoadFromXML(stream);
		}

		private void CreateBitmaps()
		{
			Bitmap bmp = new Bitmap(Resources.msoffice_menu_blog);
			bmp.MakeTransparent(Color.Magenta);
			bitmaps.Add(bmp);

			bmp = new Bitmap(Resources.msoffice_menu_digitalsignature);
			bmp.MakeTransparent(Color.Magenta);
			bitmaps.Add(bmp);

			bmp = new Bitmap(Resources.msoffice_menu_documentworkspace);
			bmp.MakeTransparent(Color.Magenta);
			bitmaps.Add(bmp);

			bmp = new Bitmap(Resources.msoffice_menu_encryptdocument);
			bmp.MakeTransparent(Color.Magenta);
			bitmaps.Add(bmp);
		}

		private void SetPreferences()
		{
			this.radGridView1.MasterTemplate.EnableSorting = true;
			this.SelectedControl = this.radGridView1;
		}

		private void InitializeGrid()
		{
			for (int i = 0; i < this.columnTypes.Length; i++)
			{
				AppendNewColumn(this.columnTypes[i], false);
			}

			GridViewDecimalColumn radiusColumn = new GridViewDecimalColumn();
			radiusColumn.Name = "Radius";
			radiusColumn.HeaderText = "Radius";            
			this.radGridView1.Columns.Insert(4, radiusColumn);


			this.radGridView1.Columns["DateTime"].FormatString = "{0:d}";
			this.radGridView1.Columns["DateTime"].TextAlignment =  ContentAlignment.MiddleRight;
			CreateBitmaps();
			GridViewRowInfo rowInfo = this.radGridView1.Rows.AddNew();
			rowInfo.Cells[0].Value = "7432";
			rowInfo.Cells[1].Value = 23;
			rowInfo.Cells[2].Value = DateTime.Now;
			rowInfo.Cells[3].Value = true;
			rowInfo.Cells[4].Value = 12.37;

			rowInfo = this.radGridView1.Rows.AddNew();
			rowInfo.Cells[0].Value = "890";
			rowInfo.Cells[1].Value = 574;
			rowInfo.Cells[2].Value = DateTime.Now.AddMonths(-10);
			rowInfo.Cells[3].Value = true;
			rowInfo.Cells[4].Value = 5.63;

			rowInfo = this.radGridView1.Rows.AddNew();
			rowInfo.Cells[0].Value = "5435";
			rowInfo.Cells[1].Value = 23444;
			rowInfo.Cells[2].Value = DateTime.Now.AddDays(45);
			rowInfo.Cells[3].Value = true;
			rowInfo.Cells[4].Value = 37.12;

			rowInfo = this.radGridView1.Rows.AddNew();
			rowInfo.Cells[0].Value = "132323";
			rowInfo.Cells[1].Value = 3455;
			rowInfo.Cells[2].Value = DateTime.Now.AddMonths(34);
			rowInfo.Cells[3].Value = true;
			rowInfo.Cells[4].Value = 23.54;

			this.radGridView1.RowCount = 4;
			this.radGridView1.CurrentRow = this.radGridView1.Rows[0];

			this.radGridView1.ShowGroupPanel = false;
			this.radGridView1.EnableGrouping = false;
			this.radGridView1.MasterTemplate.AllowAddNewRow = false;

			this.radGridView1.Columns["CustomExpression"].Expression = "ROUND(PI() * POWER(Radius, 2) + Decimal)";
		}

		private GridViewDataColumn AppendNewColumn(string columnType, bool numberInTheHeader)
		{
			GridViewDataColumn newColumn = null;
			switch (columnType)
			{
				case "NumericText":
					newColumn = new GridViewMaskBoxColumn();
					((GridViewMaskBoxColumn)newColumn).Mask = "f";
					newColumn.Name = "NumericText";
					newColumn.EnableExpressionEditor = true;
					break;
				case "Decimal":
					newColumn = new GridViewDecimalColumn();
					newColumn.Name = "Decimal";
					newColumn.DataType = typeof(Decimal);
					break;
				case "DateTime":
					newColumn = new GridViewDateTimeColumn();
					newColumn.Name = "DateTime";
					newColumn.DataType = typeof(DateTime);
					break;
				case "CheckBox":
					newColumn = new GridViewCheckBoxColumn();
					newColumn.Name = "CheckBox";
					newColumn.EnableExpressionEditor = true;
					break;
				case "CustomExpression":
					newColumn = new GridViewDecimalColumn();
					newColumn.EnableExpressionEditor = true;
					newColumn.Name = "CustomExpression";
					newColumn.HeaderText = "Custom Expression";
					newColumn.Width = 80;					
					break;
			}
		
			if (numberInTheHeader)
			{
				newColumn.HeaderText = (this.columnNum++).ToString() + " - " + columnType;
			}
			else
			{
				newColumn.HeaderText = columnType;
			}

			this.radGridView1.Columns.Add(newColumn);

			return newColumn;
		}

		#region Event Handlers

        protected override void OnHandleDestroyed(EventArgs e)
        {
            for (int i = 0; i < bitmaps.Count; i++)
            {
                bitmaps[i].Dispose();
            }

            bitmaps.Clear();

            base.OnHandleDestroyed(e);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            SetPreferences();
            InitializeGrid();

            this.radRadioCheckExpr1.ToggleState = ToggleState.On;
            this.radRadioNumExpr1.ToggleState = ToggleState.On;

            CultureInfo info = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            this.radRadioCheckExpr2.Text = string.Format("DateTime > #{0}#", System.DateTime.Now.AddDays(60).ToShortDateString());
            Thread.CurrentThread.CurrentCulture = info;
        }

		private void radButtonExprEditor_Click(object sender, System.EventArgs e)
		{
			RadExpressionEditorForm.Show(this.radGridView1, this.radGridView1.Columns[5]);
		}

		private void radCheckBox1_ToggleStateChanged(object sender, StateChangedEventArgs args)
		{
			this.radGridView1.MasterTemplate.AllowAddNewRow = args.ToggleState == ToggleState.On;
		}

		private void radRadioNumExpr1_ToggleStateChanged(object sender, StateChangedEventArgs args)
		{
			if (this.radGridView1.Columns.Contains("NumericText"))
			{
				if (this.radRadioNumExpr1.ToggleState == ToggleState.On)
				{
					this.radGridView1.Columns["NumericText"].Expression = this.radRadioNumExpr1.Text;
				}

				if (this.radRadioNumExpr2.ToggleState == ToggleState.On)
				{
					this.radGridView1.Columns["NumericText"].Expression = this.radRadioNumExpr2.Text;
				}

				if (this.radRadioAverage.ToggleState == ToggleState.On)
				{
					this.radGridView1.Columns["NumericText"].Expression = this.radRadioAverage.Text;
				}
			}
		}

		private void radRadioCheckExpr1_ToggleStateChanged(object sender, StateChangedEventArgs args)
		{
			if (this.radGridView1.Columns.Contains("CheckBox"))
			{
				if (this.radRadioCheckExpr1.ToggleState == ToggleState.On)
				{
					this.radGridView1.Columns["CheckBox"].Expression = this.radRadioCheckExpr1.Text;
				}

				if (this.radRadioCheckExpr2.ToggleState == ToggleState.On)
				{
					this.radGridView1.Columns["CheckBox"].Expression = this.radRadioCheckExpr2.Text;
				}
			}
		}

        #endregion


         
        protected override void WireEvents()
        {
            this.radRadioAverage.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioNumExpr1_ToggleStateChanged);
            this.radRadioNumExpr2.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioNumExpr1_ToggleStateChanged);
            this.radRadioNumExpr1.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioNumExpr1_ToggleStateChanged);
            this.radRadioCheckExpr1.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioCheckExpr1_ToggleStateChanged);
            this.radButtonExprEditor.Click += new System.EventHandler(this.radButtonExprEditor_Click);
        }
	}
}
