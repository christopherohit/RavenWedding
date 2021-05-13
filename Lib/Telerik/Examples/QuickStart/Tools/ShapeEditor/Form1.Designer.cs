namespace Telerik.Examples.WinControls.Tools.ShapeEditor
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radDropDownList1 = new Telerik.WinControls.UI.RadDropDownList();
            this.editShapeButton1 = new Telerik.WinControls.UI.RadButton();
            this.customShape1 = new Telerik.WinControls.CustomShape(this.components);
            this.customShape2 = new Telerik.WinControls.CustomShape(this.components);
            this.customShape3 = new Telerik.WinControls.CustomShape(this.components);
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.radGroupShape = new Telerik.WinControls.UI.RadGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editShapeButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.radPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupShape)).BeginInit();
            this.radGroupShape.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupShape);
            this.settingsPanel.Location = new System.Drawing.Point(0, 1);
            this.settingsPanel.Size = new System.Drawing.Size(200, 735);
            this.settingsPanel.ThemeName = "ControlDefault";
            this.settingsPanel.Controls.SetChildIndex(this.radGroupShape, 0);
            // 
            // radButton1
            // 
            this.radButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radButton1.Location = new System.Drawing.Point(137, 50);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(130, 114);
            this.radButton1.TabIndex = 0;
            this.radButton1.Text = "Button";
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).Text = "Button";
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).EnableHighlight = false;
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).EnableBorderHighlight = false;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButton1.GetChildAt(0).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radButton1.GetChildAt(0).GetChildAt(2))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            // 
            // radDropDownList1
            // 
            this.radDropDownList1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radDropDownList1.DropDownSizingMode = ((Telerik.WinControls.UI.SizingMode)((Telerik.WinControls.UI.SizingMode.RightBottom | Telerik.WinControls.UI.SizingMode.UpDown)));
            this.radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radDropDownList1.Location = new System.Drawing.Point(5, 36);
            this.radDropDownList1.MaxDropDownItems = 6;
            this.radDropDownList1.Name = "radDropDownList1";
            this.radDropDownList1.Size = new System.Drawing.Size(170, 20);
            this.radDropDownList1.TabIndex = 6;
            // 
            // editShapeButton1
            // 
            this.editShapeButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.editShapeButton1.Location = new System.Drawing.Point(5, 65);
            this.editShapeButton1.Name = "editShapeButton1";
            this.editShapeButton1.Size = new System.Drawing.Size(170, 23);
            this.editShapeButton1.TabIndex = 10;
            this.editShapeButton1.Text = "Edit Shape";
            // 
            // customShape1
            // 
            this.customShape1.AsString = "0,0,0,0:";
            // 
            // customShape2
            // 
            this.customShape2.AsString = "0,0,224,128:0,0,False,0,0,0,0,0:224,0,False,0,0,0,0,0:192,96,False,0,0,0,0,0:32,1" +
    "28,False,0,0,0,0,0:";
            // 
            // customShape3
            // 
            this.customShape3.AsString = "0,0,192,128:0,32,True,64,0,128,0,0:192,0,False,0,0,0,0,0:192,96,True,128,128,64,1" +
    "28,0:0,128,False,0,0,0,0,0:";
            // 
            // radPanel2
            // 
            this.radPanel2.Controls.Add(this.radButton1);
            this.radPanel2.Location = new System.Drawing.Point(0, 0);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(404, 215);
            this.radPanel2.TabIndex = 19;
            // 
            // radGroupShape
            // 
            this.radGroupShape.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupShape.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupShape.Controls.Add(this.radDropDownList1);
            this.radGroupShape.Controls.Add(this.editShapeButton1);
            this.radGroupShape.FooterText = "";
            this.radGroupShape.HeaderText = "Shape Options";
            this.radGroupShape.Location = new System.Drawing.Point(10, 3);
            this.radGroupShape.Name = "radGroupShape";
            this.radGroupShape.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupShape.Size = new System.Drawing.Size(180, 116);
            this.radGroupShape.TabIndex = 0;
            this.radGroupShape.Text = "Shape Options";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.radPanel2);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(2040, 1157);
            this.Controls.SetChildIndex(this.radPanel2, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editShapeButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            this.radPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupShape)).EndInit();
            this.radGroupShape.ResumeLayout(false);
            this.radGroupShape.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadDropDownList radDropDownList1;
        private Telerik.WinControls.UI.RadButton editShapeButton1;
        private Telerik.WinControls.CustomShape customShape1;
        private Telerik.WinControls.CustomShape customShape2;
        private Telerik.WinControls.CustomShape customShape3;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private Telerik.WinControls.UI.RadGroupBox radGroupShape;
	}
}