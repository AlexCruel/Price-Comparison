namespace Price_Comparison
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.openFileBtn1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.compareBtn = new System.Windows.Forms.Button();
            this.label_1C = new System.Windows.Forms.Label();
            this.label_Onliner = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileBtn1
            // 
            this.openFileBtn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.openFileBtn1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.openFileBtn1.Location = new System.Drawing.Point(41, 670);
            this.openFileBtn1.Name = "openFileBtn1";
            this.openFileBtn1.Size = new System.Drawing.Size(239, 50);
            this.openFileBtn1.TabIndex = 0;
            this.openFileBtn1.Text = "Открыть файл";
            this.openFileBtn1.UseVisualStyleBackColor = false;
            this.openFileBtn1.Click += new System.EventHandler(this.openFileBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(914, 262);
            this.dataGridView1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 373);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 33;
            this.dataGridView2.Size = new System.Drawing.Size(914, 264);
            this.dataGridView2.TabIndex = 3;
            // 
            // compareBtn
            // 
            this.compareBtn.BackColor = System.Drawing.Color.Yellow;
            this.compareBtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.compareBtn.Location = new System.Drawing.Point(653, 670);
            this.compareBtn.Name = "compareBtn";
            this.compareBtn.Size = new System.Drawing.Size(239, 49);
            this.compareBtn.TabIndex = 4;
            this.compareBtn.Text = "Сравнить цены";
            this.compareBtn.UseVisualStyleBackColor = false;
            this.compareBtn.Click += new System.EventHandler(this.compareBtn_Click);
            // 
            // label_1C
            // 
            this.label_1C.AutoSize = true;
            this.label_1C.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_1C.Location = new System.Drawing.Point(12, 9);
            this.label_1C.Name = "label_1C";
            this.label_1C.Size = new System.Drawing.Size(268, 25);
            this.label_1C.TabIndex = 5;
            this.label_1C.Text = "Данные по номенклатуре 1С";
            // 
            // label_Onliner
            // 
            this.label_Onliner.AutoSize = true;
            this.label_Onliner.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Onliner.Location = new System.Drawing.Point(12, 334);
            this.label_Onliner.Name = "label_Onliner";
            this.label_Onliner.Size = new System.Drawing.Size(310, 25);
            this.label_Onliner.TabIndex = 6;
            this.label_Onliner.Text = "Данные по номенклатуре Onliner";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 745);
            this.Controls.Add(this.label_Onliner);
            this.Controls.Add(this.label_1C);
            this.Controls.Add(this.compareBtn);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.openFileBtn1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Данные файла";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button openFileBtn1;
        private OpenFileDialog openFileDialog1;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Button compareBtn;
        private Label label_1C;
        private Label label_Onliner;
    }
}