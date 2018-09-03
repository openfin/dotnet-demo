namespace WinformsApp
{
    partial class OrderingTool
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.openFinStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.orderStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sharesUpDown = new System.Windows.Forms.NumericUpDown();
            this.orderTypeComboBox = new System.Windows.Forms.ComboBox();
            this.actionComboBox = new System.Windows.Forms.ComboBox();
            this.limitUpDown = new System.Windows.Forms.NumericUpDown();
            this.submitOrderButton = new System.Windows.Forms.Button();
            this.launchCalculatorButton = new System.Windows.Forms.Button();
            this.tickerComboBox = new System.Windows.Forms.ComboBox();
            this.statusStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sharesUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.limitUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFinStatusLabel,
            this.orderStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 264);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(309, 22);
            this.statusStrip.TabIndex = 0;
            // 
            // openFinStatusLabel
            // 
            this.openFinStatusLabel.Name = "openFinStatusLabel";
            this.openFinStatusLabel.Size = new System.Drawing.Size(127, 17);
            this.openFinStatusLabel.Text = "OpenFin Disconnected";
            // 
            // orderStatusLabel
            // 
            this.orderStatusLabel.Name = "orderStatusLabel";
            this.orderStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.42105F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.57895F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.sharesUpDown, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.orderTypeComboBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.actionComboBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.limitUpDown, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tickerComboBox, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(285, 214);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ticker";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Action";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Order Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Shares";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Limit";
            // 
            // sharesUpDown
            // 
            this.sharesUpDown.Location = new System.Drawing.Point(140, 129);
            this.sharesUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.sharesUpDown.Name = "sharesUpDown";
            this.sharesUpDown.Size = new System.Drawing.Size(120, 20);
            this.sharesUpDown.TabIndex = 6;
            // 
            // orderTypeComboBox
            // 
            this.orderTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orderTypeComboBox.FormattingEnabled = true;
            this.orderTypeComboBox.Items.AddRange(new object[] {
            "Market Order",
            "Limit Order"});
            this.orderTypeComboBox.Location = new System.Drawing.Point(140, 87);
            this.orderTypeComboBox.Name = "orderTypeComboBox";
            this.orderTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.orderTypeComboBox.TabIndex = 7;
            this.orderTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.orderTypeComboBox_SelectedIndexChanged);
            // 
            // actionComboBox
            // 
            this.actionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.actionComboBox.FormattingEnabled = true;
            this.actionComboBox.Items.AddRange(new object[] {
            "Buy",
            "Sell"});
            this.actionComboBox.Location = new System.Drawing.Point(140, 45);
            this.actionComboBox.Name = "actionComboBox";
            this.actionComboBox.Size = new System.Drawing.Size(121, 21);
            this.actionComboBox.TabIndex = 8;
            // 
            // limitUpDown
            // 
            this.limitUpDown.DecimalPlaces = 2;
            this.limitUpDown.Location = new System.Drawing.Point(140, 171);
            this.limitUpDown.Maximum = new decimal(new int[] {
            420,
            0,
            0,
            0});
            this.limitUpDown.Name = "limitUpDown";
            this.limitUpDown.Size = new System.Drawing.Size(120, 20);
            this.limitUpDown.TabIndex = 10;
            // 
            // submitOrderButton
            // 
            this.submitOrderButton.Location = new System.Drawing.Point(202, 233);
            this.submitOrderButton.Name = "submitOrderButton";
            this.submitOrderButton.Size = new System.Drawing.Size(95, 23);
            this.submitOrderButton.TabIndex = 2;
            this.submitOrderButton.Text = "Submit Order";
            this.submitOrderButton.UseVisualStyleBackColor = true;
            this.submitOrderButton.Click += new System.EventHandler(this.submitOrderButton_Click);
            // 
            // launchCalculatorButton
            // 
            this.launchCalculatorButton.Location = new System.Drawing.Point(12, 233);
            this.launchCalculatorButton.Name = "launchCalculatorButton";
            this.launchCalculatorButton.Size = new System.Drawing.Size(114, 23);
            this.launchCalculatorButton.TabIndex = 3;
            this.launchCalculatorButton.Text = "Launch Calculator";
            this.launchCalculatorButton.UseVisualStyleBackColor = true;
            this.launchCalculatorButton.Click += new System.EventHandler(this.launchCalculatorButton_Click);
            // 
            // tickerComboBox
            // 
            this.tickerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tickerComboBox.FormattingEnabled = true;
            this.tickerComboBox.Items.AddRange(new object[] {
            "APPL",
            "IBM",
            "MSFT",
            "CSCO",
            "SIRI",
            "VOGON"});
            this.tickerComboBox.Location = new System.Drawing.Point(140, 3);
            this.tickerComboBox.Name = "tickerComboBox";
            this.tickerComboBox.Size = new System.Drawing.Size(121, 21);
            this.tickerComboBox.TabIndex = 11;
            // 
            // OrderingTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 286);
            this.Controls.Add(this.launchCalculatorButton);
            this.Controls.Add(this.submitOrderButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "OrderingTool";
            this.Text = "Order Processing Tool";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sharesUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.limitUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel openFinStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel orderStatusLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown sharesUpDown;
        private System.Windows.Forms.ComboBox orderTypeComboBox;
        private System.Windows.Forms.ComboBox actionComboBox;
        private System.Windows.Forms.NumericUpDown limitUpDown;
        private System.Windows.Forms.Button submitOrderButton;
        private System.Windows.Forms.Button launchCalculatorButton;
        private System.Windows.Forms.ComboBox tickerComboBox;
    }
}

