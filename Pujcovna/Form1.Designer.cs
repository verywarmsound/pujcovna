namespace Pujcovna
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
            this.skladGrid = new System.Windows.Forms.DataGridView();
            this.zakazniciGrid = new System.Windows.Forms.DataGridView();
            this.vypujcenoGrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.skladGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazniciGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vypujcenoGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // skladGrid
            // 
            this.skladGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.skladGrid.Location = new System.Drawing.Point(12, 15);
            this.skladGrid.Name = "skladGrid";
            this.skladGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.skladGrid.Size = new System.Drawing.Size(388, 259);
            this.skladGrid.TabIndex = 0;
            // 
            // zakazniciGrid
            // 
            this.zakazniciGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zakazniciGrid.Location = new System.Drawing.Point(406, 15);
            this.zakazniciGrid.Name = "zakazniciGrid";
            this.zakazniciGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.zakazniciGrid.Size = new System.Drawing.Size(385, 259);
            this.zakazniciGrid.TabIndex = 1;
            this.zakazniciGrid.SelectionChanged += new System.EventHandler(this.zakazniciGrid_SelectionChanged);
            // 
            // vypujcenoGrid
            // 
            this.vypujcenoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vypujcenoGrid.Location = new System.Drawing.Point(177, 280);
            this.vypujcenoGrid.Name = "vypujcenoGrid";
            this.vypujcenoGrid.Size = new System.Drawing.Size(614, 150);
            this.vypujcenoGrid.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Vypůjčit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Vrátit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 354);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Nový zákaznik";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 442);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.vypujcenoGrid);
            this.Controls.Add(this.zakazniciGrid);
            this.Controls.Add(this.skladGrid);
            this.Name = "Form1";
            this.Text = "Půjčovna";
            ((System.ComponentModel.ISupportInitialize)(this.skladGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazniciGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vypujcenoGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView skladGrid;
        private System.Windows.Forms.DataGridView zakazniciGrid;
        private System.Windows.Forms.DataGridView vypujcenoGrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

