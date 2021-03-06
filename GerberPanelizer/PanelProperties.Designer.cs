﻿namespace GerberCombinerBuilder
{
    partial class PanelProperties
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
            this.WidthBox = new System.Windows.Forms.NumericUpDown();
            this.HeightBox = new System.Windows.Forms.NumericUpDown();
            this.MarginBox = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.FillEmpty = new System.Windows.Forms.CheckBox();
            this.filloffsetbox = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.smoothoffsetbox = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.ExtraTabDrillDistance = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.WidthBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarginBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filloffsetbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smoothoffsetbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExtraTabDrillDistance)).BeginInit();
            this.SuspendLayout();
            // 
            // WidthBox
            // 
            this.WidthBox.DecimalPlaces = 2;
            this.WidthBox.Location = new System.Drawing.Point(187, 19);
            this.WidthBox.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.WidthBox.Name = "WidthBox";
            this.WidthBox.Size = new System.Drawing.Size(120, 22);
            this.WidthBox.TabIndex = 0;
            this.WidthBox.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // HeightBox
            // 
            this.HeightBox.DecimalPlaces = 2;
            this.HeightBox.Location = new System.Drawing.Point(187, 47);
            this.HeightBox.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.HeightBox.Name = "HeightBox";
            this.HeightBox.Size = new System.Drawing.Size(120, 22);
            this.HeightBox.TabIndex = 1;
            this.HeightBox.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // MarginBox
            // 
            this.MarginBox.DecimalPlaces = 2;
            this.MarginBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.MarginBox.Location = new System.Drawing.Point(187, 75);
            this.MarginBox.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.MarginBox.Name = "MarginBox";
            this.MarginBox.Size = new System.Drawing.Size(120, 22);
            this.MarginBox.TabIndex = 2;
            this.MarginBox.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Width";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Height";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Margin between boards";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(216, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(41, 332);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 28);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FillEmpty
            // 
            this.FillEmpty.AutoSize = true;
            this.FillEmpty.Location = new System.Drawing.Point(187, 111);
            this.FillEmpty.Name = "FillEmpty";
            this.FillEmpty.Size = new System.Drawing.Size(122, 21);
            this.FillEmpty.TabIndex = 9;
            this.FillEmpty.Text = "Fill empty area";
            this.FillEmpty.UseVisualStyleBackColor = true;
            // 
            // filloffsetbox
            // 
            this.filloffsetbox.DecimalPlaces = 2;
            this.filloffsetbox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.filloffsetbox.Location = new System.Drawing.Point(187, 142);
            this.filloffsetbox.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.filloffsetbox.Name = "filloffsetbox";
            this.filloffsetbox.Size = new System.Drawing.Size(120, 22);
            this.filloffsetbox.TabIndex = 10;
            this.filloffsetbox.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Fill offset for empty area";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Empty area smoothing";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // smoothoffsetbox
            // 
            this.smoothoffsetbox.DecimalPlaces = 2;
            this.smoothoffsetbox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.smoothoffsetbox.Location = new System.Drawing.Point(187, 170);
            this.smoothoffsetbox.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.smoothoffsetbox.Name = "smoothoffsetbox";
            this.smoothoffsetbox.Size = new System.Drawing.Size(120, 22);
            this.smoothoffsetbox.TabIndex = 12;
            this.smoothoffsetbox.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Extra distance for tabdrills";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ExtraTabDrillDistance
            // 
            this.ExtraTabDrillDistance.DecimalPlaces = 3;
            this.ExtraTabDrillDistance.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ExtraTabDrillDistance.Location = new System.Drawing.Point(187, 218);
            this.ExtraTabDrillDistance.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.ExtraTabDrillDistance.Name = "ExtraTabDrillDistance";
            this.ExtraTabDrillDistance.Size = new System.Drawing.Size(120, 22);
            this.ExtraTabDrillDistance.TabIndex = 14;
            this.ExtraTabDrillDistance.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // PanelProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 401);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ExtraTabDrillDistance);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.smoothoffsetbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.filloffsetbox);
            this.Controls.Add(this.FillEmpty);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MarginBox);
            this.Controls.Add(this.HeightBox);
            this.Controls.Add(this.WidthBox);
            this.Name = "PanelProperties";
            this.Text = "Panel Properties";
            ((System.ComponentModel.ISupportInitialize)(this.WidthBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarginBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filloffsetbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smoothoffsetbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExtraTabDrillDistance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown WidthBox;
        private System.Windows.Forms.NumericUpDown HeightBox;
        private System.Windows.Forms.NumericUpDown MarginBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox FillEmpty;
        private System.Windows.Forms.NumericUpDown filloffsetbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown smoothoffsetbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown ExtraTabDrillDistance;
    }
}