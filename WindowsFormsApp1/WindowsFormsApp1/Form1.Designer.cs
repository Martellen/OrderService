namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.selectFileButton = new System.Windows.Forms.Button();
            this.selectedFilesLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clientIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numberOfOrdersByNameIdInput = new System.Windows.Forms.TextBox();
            this.averageValueOfOrdersIdInput = new System.Windows.Forms.TextBox();
            this.listOfOrdersIdInput = new System.Windows.Forms.TextBox();
            this.totalValueOfOrdersIdInput = new System.Windows.Forms.TextBox();
            this.numberOfOrdersIdInput = new System.Windows.Forms.TextBox();
            this.numericUpDown7 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raportDetailsGroup = new System.Windows.Forms.GroupBox();
            this.averageValueOfOrdersLabel = new System.Windows.Forms.Label();
            this.totalValueOfOrdersLabel = new System.Windows.Forms.Label();
            this.numberOfOrdersLabel = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.saveTableToCSV = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.raportDetailsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectFileButton
            // 
            this.selectFileButton.Location = new System.Drawing.Point(12, 27);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(75, 37);
            this.selectFileButton.TabIndex = 0;
            this.selectFileButton.Text = "Select Files";
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // selectedFilesLabel
            // 
            this.selectedFilesLabel.AutoSize = true;
            this.selectedFilesLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.selectedFilesLabel.Location = new System.Drawing.Point(6, 16);
            this.selectedFilesLabel.Name = "selectedFilesLabel";
            this.selectedFilesLabel.Size = new System.Drawing.Size(85, 13);
            this.selectedFilesLabel.TabIndex = 1;
            this.selectedFilesLabel.Text = "No selected files";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.selectedFilesLabel);
            this.groupBox1.Location = new System.Drawing.Point(93, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 37);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Files";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientIdColumn,
            this.requestIdColumn,
            this.nameColumn,
            this.quantityColumn,
            this.priceColumn});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(13, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(543, 191);
            this.dataGridView1.TabIndex = 3;
            // 
            // clientIdColumn
            // 
            this.clientIdColumn.HeaderText = "clientId";
            this.clientIdColumn.Name = "clientIdColumn";
            // 
            // requestIdColumn
            // 
            this.requestIdColumn.HeaderText = "requestId";
            this.requestIdColumn.Name = "requestIdColumn";
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "name";
            this.nameColumn.Name = "nameColumn";
            // 
            // quantityColumn
            // 
            this.quantityColumn.HeaderText = "quantity";
            this.quantityColumn.Name = "quantityColumn";
            // 
            // priceColumn
            // 
            this.priceColumn.HeaderText = "price";
            this.priceColumn.Name = "priceColumn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numberOfOrdersByNameIdInput);
            this.groupBox2.Controls.Add(this.averageValueOfOrdersIdInput);
            this.groupBox2.Controls.Add(this.listOfOrdersIdInput);
            this.groupBox2.Controls.Add(this.totalValueOfOrdersIdInput);
            this.groupBox2.Controls.Add(this.numberOfOrdersIdInput);
            this.groupBox2.Controls.Add(this.numericUpDown7);
            this.groupBox2.Controls.Add(this.numericUpDown6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(13, 362);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(543, 202);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Generate reports";
            // 
            // numberOfOrdersByNameIdInput
            // 
            this.numberOfOrdersByNameIdInput.Location = new System.Drawing.Point(433, 140);
            this.numberOfOrdersByNameIdInput.Name = "numberOfOrdersByNameIdInput";
            this.numberOfOrdersByNameIdInput.Size = new System.Drawing.Size(104, 20);
            this.numberOfOrdersByNameIdInput.TabIndex = 31;
            // 
            // averageValueOfOrdersIdInput
            // 
            this.averageValueOfOrdersIdInput.Location = new System.Drawing.Point(432, 110);
            this.averageValueOfOrdersIdInput.Name = "averageValueOfOrdersIdInput";
            this.averageValueOfOrdersIdInput.Size = new System.Drawing.Size(105, 20);
            this.averageValueOfOrdersIdInput.TabIndex = 30;
            // 
            // listOfOrdersIdInput
            // 
            this.listOfOrdersIdInput.Location = new System.Drawing.Point(432, 80);
            this.listOfOrdersIdInput.Name = "listOfOrdersIdInput";
            this.listOfOrdersIdInput.Size = new System.Drawing.Size(105, 20);
            this.listOfOrdersIdInput.TabIndex = 29;
            // 
            // totalValueOfOrdersIdInput
            // 
            this.totalValueOfOrdersIdInput.Location = new System.Drawing.Point(432, 50);
            this.totalValueOfOrdersIdInput.Name = "totalValueOfOrdersIdInput";
            this.totalValueOfOrdersIdInput.Size = new System.Drawing.Size(105, 20);
            this.totalValueOfOrdersIdInput.TabIndex = 28;
            // 
            // numberOfOrdersIdInput
            // 
            this.numberOfOrdersIdInput.Location = new System.Drawing.Point(432, 20);
            this.numberOfOrdersIdInput.Name = "numberOfOrdersIdInput";
            this.numberOfOrdersIdInput.Size = new System.Drawing.Size(105, 20);
            this.numberOfOrdersIdInput.TabIndex = 27;
            // 
            // numericUpDown7
            // 
            this.numericUpDown7.DecimalPlaces = 2;
            this.numericUpDown7.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown7.Location = new System.Drawing.Point(432, 170);
            this.numericUpDown7.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numericUpDown7.Name = "numericUpDown7";
            this.numericUpDown7.Size = new System.Drawing.Size(105, 20);
            this.numericUpDown7.TabIndex = 26;
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.DecimalPlaces = 2;
            this.numericUpDown6.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown6.Location = new System.Drawing.Point(299, 170);
            this.numericUpDown6.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(105, 20);
            this.numericUpDown6.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(410, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "to";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(271, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "from";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(395, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "for Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(395, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "for Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(395, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "for Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(395, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "for Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(395, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "for Id";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(7, 170);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(258, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "Orders in range";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.OrdersInRangeClick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(7, 140);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(382, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Number of orders sorted by name";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.OrdersByNameClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(7, 110);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(382, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Average value of order";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.AverageValueOfOrdersClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(7, 80);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(382, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "List of orders";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ListOrdersClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(382, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Total value of orders";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ValueOfOrdersClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(382, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Number of orders";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.NumberOfOrdersClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(52, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // raportDetailsGroup
            // 
            this.raportDetailsGroup.Controls.Add(this.averageValueOfOrdersLabel);
            this.raportDetailsGroup.Controls.Add(this.totalValueOfOrdersLabel);
            this.raportDetailsGroup.Controls.Add(this.numberOfOrdersLabel);
            this.raportDetailsGroup.Location = new System.Drawing.Point(13, 269);
            this.raportDetailsGroup.Name = "raportDetailsGroup";
            this.raportDetailsGroup.Size = new System.Drawing.Size(382, 87);
            this.raportDetailsGroup.TabIndex = 6;
            this.raportDetailsGroup.TabStop = false;
            this.raportDetailsGroup.Text = "Report details";
            // 
            // averageValueOfOrdersLabel
            // 
            this.averageValueOfOrdersLabel.AutoSize = true;
            this.averageValueOfOrdersLabel.Location = new System.Drawing.Point(7, 65);
            this.averageValueOfOrdersLabel.Name = "averageValueOfOrdersLabel";
            this.averageValueOfOrdersLabel.Size = new System.Drawing.Size(290, 13);
            this.averageValueOfOrdersLabel.TabIndex = 2;
            this.averageValueOfOrdersLabel.Text = "Report \"average value of order\" was not generated by user.";
            // 
            // totalValueOfOrdersLabel
            // 
            this.totalValueOfOrdersLabel.AutoSize = true;
            this.totalValueOfOrdersLabel.Location = new System.Drawing.Point(7, 43);
            this.totalValueOfOrdersLabel.Name = "totalValueOfOrdersLabel";
            this.totalValueOfOrdersLabel.Size = new System.Drawing.Size(276, 13);
            this.totalValueOfOrdersLabel.TabIndex = 1;
            this.totalValueOfOrdersLabel.Text = "Report \"total value of orders\" was not generated by user.";
            // 
            // numberOfOrdersLabel
            // 
            this.numberOfOrdersLabel.AutoSize = true;
            this.numberOfOrdersLabel.Location = new System.Drawing.Point(7, 20);
            this.numberOfOrdersLabel.Name = "numberOfOrdersLabel";
            this.numberOfOrdersLabel.Size = new System.Drawing.Size(262, 13);
            this.numberOfOrdersLabel.TabIndex = 0;
            this.numberOfOrdersLabel.Text = "Report \"number of orders\" was not generated by user.";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(401, 312);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(155, 44);
            this.button7.TabIndex = 7;
            this.button7.Text = "Save report detial to .csv";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.saveRaportDetailsToCSVClick);
            // 
            // saveTableToCSV
            // 
            this.saveTableToCSV.Location = new System.Drawing.Point(401, 269);
            this.saveTableToCSV.Name = "saveTableToCSV";
            this.saveTableToCSV.Size = new System.Drawing.Size(155, 44);
            this.saveTableToCSV.TabIndex = 8;
            this.saveTableToCSV.Text = "Save report table to .csv";
            this.saveTableToCSV.UseVisualStyleBackColor = true;
            this.saveTableToCSV.Click += new System.EventHandler(this.saveTableToCSVClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 576);
            this.Controls.Add(this.saveTableToCSV);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.raportDetailsGroup);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.selectFileButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(585, 615);
            this.MinimumSize = new System.Drawing.Size(585, 615);
            this.Name = "Form1";
            this.Text = "Order Service";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.raportDetailsGroup.ResumeLayout(false);
            this.raportDetailsGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectFileButton;
        private System.Windows.Forms.Label selectedFilesLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown numericUpDown7;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.GroupBox raportDetailsGroup;
        private System.Windows.Forms.Label numberOfOrdersLabel;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button saveTableToCSV;
        private System.Windows.Forms.Label averageValueOfOrdersLabel;
        private System.Windows.Forms.Label totalValueOfOrdersLabel;
        private System.Windows.Forms.TextBox numberOfOrdersIdInput;
        private System.Windows.Forms.TextBox totalValueOfOrdersIdInput;
        private System.Windows.Forms.TextBox listOfOrdersIdInput;
        private System.Windows.Forms.TextBox averageValueOfOrdersIdInput;
        private System.Windows.Forms.TextBox numberOfOrdersByNameIdInput;
    }
}

