namespace LinqTo_Example
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnExample = new System.Windows.Forms.Button();
            this.btnWhere = new System.Windows.Forms.Button();
            this.btnJoin = new System.Windows.Forms.Button();
            this.btnGroupBy = new System.Windows.Forms.Button();
            this.btnDistinct = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnFirstOrDefault = new System.Windows.Forms.Button();
            this.btnOrderByDesc = new System.Windows.Forms.Button();
            this.btnContains = new System.Windows.Forms.Button();
            this.btnOrderBy = new System.Windows.Forms.Button();
            this.btnAny = new System.Windows.Forms.Button();
            this.btnStartsWith = new System.Windows.Forms.Button();
            this.btnEndsWith = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnSkip = new System.Windows.Forms.Button();
            this.btnTake = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 343);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(757, 359);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnExample
            // 
            this.btnExample.Location = new System.Drawing.Point(30, 26);
            this.btnExample.Name = "btnExample";
            this.btnExample.Size = new System.Drawing.Size(152, 61);
            this.btnExample.TabIndex = 1;
            this.btnExample.Text = "Select";
            this.btnExample.UseVisualStyleBackColor = true;
            this.btnExample.Click += new System.EventHandler(this.btnExample_Click);
            // 
            // btnWhere
            // 
            this.btnWhere.Location = new System.Drawing.Point(225, 26);
            this.btnWhere.Name = "btnWhere";
            this.btnWhere.Size = new System.Drawing.Size(168, 61);
            this.btnWhere.TabIndex = 2;
            this.btnWhere.Text = "Where";
            this.btnWhere.UseVisualStyleBackColor = true;
            this.btnWhere.Click += new System.EventHandler(this.btnWhere_Click);
            // 
            // btnJoin
            // 
            this.btnJoin.Location = new System.Drawing.Point(450, 26);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(166, 61);
            this.btnJoin.TabIndex = 3;
            this.btnJoin.Text = "Join";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // btnGroupBy
            // 
            this.btnGroupBy.Location = new System.Drawing.Point(650, 26);
            this.btnGroupBy.Name = "btnGroupBy";
            this.btnGroupBy.Size = new System.Drawing.Size(162, 61);
            this.btnGroupBy.TabIndex = 4;
            this.btnGroupBy.Text = "GroupBy";
            this.btnGroupBy.UseVisualStyleBackColor = true;
            this.btnGroupBy.Click += new System.EventHandler(this.btnGroupBy_Click);
            // 
            // btnDistinct
            // 
            this.btnDistinct.Location = new System.Drawing.Point(850, 26);
            this.btnDistinct.Name = "btnDistinct";
            this.btnDistinct.Size = new System.Drawing.Size(151, 61);
            this.btnDistinct.TabIndex = 5;
            this.btnDistinct.Text = "Distinct";
            this.btnDistinct.UseVisualStyleBackColor = true;
            this.btnDistinct.Click += new System.EventHandler(this.btnDistinct_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(838, 343);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(342, 356);
            this.listBox1.TabIndex = 6;
            // 
            // btnFirstOrDefault
            // 
            this.btnFirstOrDefault.Location = new System.Drawing.Point(1036, 26);
            this.btnFirstOrDefault.Name = "btnFirstOrDefault";
            this.btnFirstOrDefault.Size = new System.Drawing.Size(144, 61);
            this.btnFirstOrDefault.TabIndex = 7;
            this.btnFirstOrDefault.Text = "FirstOrDefault";
            this.btnFirstOrDefault.UseVisualStyleBackColor = true;
            this.btnFirstOrDefault.Click += new System.EventHandler(this.btnFirstOrDefault_Click);
            // 
            // btnOrderByDesc
            // 
            this.btnOrderByDesc.Location = new System.Drawing.Point(30, 110);
            this.btnOrderByDesc.Name = "btnOrderByDesc";
            this.btnOrderByDesc.Size = new System.Drawing.Size(152, 70);
            this.btnOrderByDesc.TabIndex = 8;
            this.btnOrderByDesc.Text = "OrderbyDescending";
            this.btnOrderByDesc.UseVisualStyleBackColor = true;
            this.btnOrderByDesc.Click += new System.EventHandler(this.btnOrderByDesc_Click);
            // 
            // btnContains
            // 
            this.btnContains.Location = new System.Drawing.Point(225, 110);
            this.btnContains.Name = "btnContains";
            this.btnContains.Size = new System.Drawing.Size(168, 70);
            this.btnContains.TabIndex = 9;
            this.btnContains.Text = "Contains";
            this.btnContains.UseVisualStyleBackColor = true;
            this.btnContains.Click += new System.EventHandler(this.btnContains_Click);
            // 
            // btnOrderBy
            // 
            this.btnOrderBy.Location = new System.Drawing.Point(450, 110);
            this.btnOrderBy.Name = "btnOrderBy";
            this.btnOrderBy.Size = new System.Drawing.Size(166, 70);
            this.btnOrderBy.TabIndex = 10;
            this.btnOrderBy.Text = "OrderBy";
            this.btnOrderBy.UseVisualStyleBackColor = true;
            this.btnOrderBy.Click += new System.EventHandler(this.btnOrderBy_Click);
            // 
            // btnAny
            // 
            this.btnAny.Location = new System.Drawing.Point(650, 110);
            this.btnAny.Name = "btnAny";
            this.btnAny.Size = new System.Drawing.Size(162, 70);
            this.btnAny.TabIndex = 11;
            this.btnAny.Text = "Any";
            this.btnAny.UseVisualStyleBackColor = true;
            this.btnAny.Click += new System.EventHandler(this.btnAny_Click);
            // 
            // btnStartsWith
            // 
            this.btnStartsWith.Location = new System.Drawing.Point(850, 110);
            this.btnStartsWith.Name = "btnStartsWith";
            this.btnStartsWith.Size = new System.Drawing.Size(152, 70);
            this.btnStartsWith.TabIndex = 12;
            this.btnStartsWith.Text = "StartsWith";
            this.btnStartsWith.UseVisualStyleBackColor = true;
            this.btnStartsWith.Click += new System.EventHandler(this.btnStartsWith_Click);
            // 
            // btnEndsWith
            // 
            this.btnEndsWith.Location = new System.Drawing.Point(1036, 110);
            this.btnEndsWith.Name = "btnEndsWith";
            this.btnEndsWith.Size = new System.Drawing.Size(144, 70);
            this.btnEndsWith.TabIndex = 13;
            this.btnEndsWith.Text = "EndsWith";
            this.btnEndsWith.UseVisualStyleBackColor = true;
            this.btnEndsWith.Click += new System.EventHandler(this.btnEndsWith_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(30, 216);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(152, 62);
            this.btnCount.TabIndex = 14;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(450, 216);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(166, 62);
            this.btnSum.TabIndex = 15;
            this.btnSum.Text = "Sum";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(225, 216);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(168, 62);
            this.btnFind.TabIndex = 16;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnMax
            // 
            this.btnMax.Location = new System.Drawing.Point(650, 216);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(162, 62);
            this.btnMax.TabIndex = 17;
            this.btnMax.Text = "Max";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnSkip
            // 
            this.btnSkip.Location = new System.Drawing.Point(849, 216);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(152, 62);
            this.btnSkip.TabIndex = 18;
            this.btnSkip.Text = "Skip";
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // btnTake
            // 
            this.btnTake.Location = new System.Drawing.Point(1036, 216);
            this.btnTake.Name = "btnTake";
            this.btnTake.Size = new System.Drawing.Size(144, 62);
            this.btnTake.TabIndex = 19;
            this.btnTake.Text = "Take";
            this.btnTake.UseVisualStyleBackColor = true;
            this.btnTake.Click += new System.EventHandler(this.btnTake_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 744);
            this.Controls.Add(this.btnTake);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnEndsWith);
            this.Controls.Add(this.btnStartsWith);
            this.Controls.Add(this.btnAny);
            this.Controls.Add(this.btnOrderBy);
            this.Controls.Add(this.btnContains);
            this.Controls.Add(this.btnOrderByDesc);
            this.Controls.Add(this.btnFirstOrDefault);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnDistinct);
            this.Controls.Add(this.btnGroupBy);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.btnWhere);
            this.Controls.Add(this.btnExample);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnExample;
        private System.Windows.Forms.Button btnWhere;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.Button btnGroupBy;
        private System.Windows.Forms.Button btnDistinct;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnFirstOrDefault;
        private System.Windows.Forms.Button btnOrderByDesc;
        private System.Windows.Forms.Button btnContains;
        private System.Windows.Forms.Button btnOrderBy;
        private System.Windows.Forms.Button btnAny;
        private System.Windows.Forms.Button btnStartsWith;
        private System.Windows.Forms.Button btnEndsWith;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Button btnTake;
    }
}

