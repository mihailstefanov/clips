namespace WineDemo {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.colorComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sweetnessComboBox = new System.Windows.Forms.ComboBox();
            this.bodyComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.flavorComboBox = new System.Windows.Forms.ComboBox();
            this.sauceComboBox = new System.Windows.Forms.ComboBox();
            this.mainCourceComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.wineColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecWeightColumn = new Sample.DataGridViewProgressColumn();
            this.dataGridViewProgressColumn1 = new Sample.DataGridViewProgressColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // colorComboBox
            // 
            this.colorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorComboBox.FormattingEnabled = true;
            this.colorComboBox.Location = new System.Drawing.Point(122, 21);
            this.colorComboBox.Name = "colorComboBox";
            this.colorComboBox.Size = new System.Drawing.Size(121, 21);
            this.colorComboBox.TabIndex = 0;
            this.colorComboBox.SelectedValueChanged += new System.EventHandler(this.OnChange);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.sweetnessComboBox);
            this.groupBox1.Controls.Add(this.bodyComboBox);
            this.groupBox1.Controls.Add(this.colorComboBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 112);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Preferences";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sweetness:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Body:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Color:";
            // 
            // sweetnessComboBox
            // 
            this.sweetnessComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sweetnessComboBox.FormattingEnabled = true;
            this.sweetnessComboBox.Location = new System.Drawing.Point(122, 75);
            this.sweetnessComboBox.Name = "sweetnessComboBox";
            this.sweetnessComboBox.Size = new System.Drawing.Size(121, 21);
            this.sweetnessComboBox.TabIndex = 2;
            this.sweetnessComboBox.SelectedValueChanged += new System.EventHandler(this.OnChange);
            // 
            // bodyComboBox
            // 
            this.bodyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bodyComboBox.FormattingEnabled = true;
            this.bodyComboBox.Location = new System.Drawing.Point(122, 48);
            this.bodyComboBox.Name = "bodyComboBox";
            this.bodyComboBox.Size = new System.Drawing.Size(121, 21);
            this.bodyComboBox.TabIndex = 1;
            this.bodyComboBox.SelectedValueChanged += new System.EventHandler(this.OnChange);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.flavorComboBox);
            this.groupBox2.Controls.Add(this.sauceComboBox);
            this.groupBox2.Controls.Add(this.mainCourceComboBox);
            this.groupBox2.Location = new System.Drawing.Point(271, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 112);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Meal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Flavor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sauce:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Main Cource:";
            // 
            // flavorComboBox
            // 
            this.flavorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.flavorComboBox.FormattingEnabled = true;
            this.flavorComboBox.Location = new System.Drawing.Point(122, 75);
            this.flavorComboBox.Name = "flavorComboBox";
            this.flavorComboBox.Size = new System.Drawing.Size(121, 21);
            this.flavorComboBox.TabIndex = 2;
            this.flavorComboBox.SelectedValueChanged += new System.EventHandler(this.OnChange);
            // 
            // sauceComboBox
            // 
            this.sauceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sauceComboBox.FormattingEnabled = true;
            this.sauceComboBox.Location = new System.Drawing.Point(122, 48);
            this.sauceComboBox.Name = "sauceComboBox";
            this.sauceComboBox.Size = new System.Drawing.Size(121, 21);
            this.sauceComboBox.TabIndex = 1;
            this.sauceComboBox.SelectedValueChanged += new System.EventHandler(this.OnChange);
            // 
            // mainCourceComboBox
            // 
            this.mainCourceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mainCourceComboBox.FormattingEnabled = true;
            this.mainCourceComboBox.Location = new System.Drawing.Point(122, 21);
            this.mainCourceComboBox.Name = "mainCourceComboBox";
            this.mainCourceComboBox.Size = new System.Drawing.Size(121, 21);
            this.mainCourceComboBox.TabIndex = 0;
            this.mainCourceComboBox.SelectedValueChanged += new System.EventHandler(this.OnChange);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wineColumn,
            this.RecWeightColumn});
            this.dataGridView.Location = new System.Drawing.Point(12, 130);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(512, 311);
            this.dataGridView.TabIndex = 3;
            // 
            // wineColumn
            // 
            this.wineColumn.DataPropertyName = "WineName";
            this.wineColumn.HeaderText = "Wine";
            this.wineColumn.Name = "wineColumn";
            this.wineColumn.ReadOnly = true;
            // 
            // RecWeightColumn
            // 
            this.RecWeightColumn.DataPropertyName = "Certainty";
            this.RecWeightColumn.HeaderText = "Recommendation Weight";
            this.RecWeightColumn.Name = "RecWeightColumn";
            this.RecWeightColumn.ReadOnly = true;
            this.RecWeightColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RecWeightColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewProgressColumn1
            // 
            this.dataGridViewProgressColumn1.HeaderText = "Recommendation Weight";
            this.dataGridViewProgressColumn1.Name = "dataGridViewProgressColumn1";
            this.dataGridViewProgressColumn1.ReadOnly = true;
            this.dataGridViewProgressColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProgressColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewProgressColumn1.Width = 254;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 453);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "WineDemo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox colorComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox sweetnessComboBox;
        private System.Windows.Forms.ComboBox bodyComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox flavorComboBox;
        private System.Windows.Forms.ComboBox sauceComboBox;
        private System.Windows.Forms.ComboBox mainCourceComboBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private Sample.DataGridViewProgressColumn dataGridViewProgressColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn wineColumn;
        private Sample.DataGridViewProgressColumn RecWeightColumn;
    }
}

