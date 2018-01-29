namespace Footing
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
            this.cl = new System.Windows.Forms.Label();
            this.cn = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.Button();
            this.il = new System.Windows.Forms.Label();
            this.lengthl = new System.Windows.Forms.Label();
            this.bl = new System.Windows.Forms.Label();
            this.hl = new System.Windows.Forms.Label();
            this.ll = new System.Windows.Forms.Label();
            this.ltf = new System.Windows.Forms.TextBox();
            this.btf = new System.Windows.Forms.TextBox();
            this.htf = new System.Windows.Forms.TextBox();
            this.lotf = new System.Windows.Forms.TextBox();
            this.next = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cl
            // 
            this.cl.AutoSize = true;
            this.cl.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cl.Location = new System.Drawing.Point(12, 19);
            this.cl.Name = "cl";
            this.cl.Size = new System.Drawing.Size(160, 17);
            this.cl.TabIndex = 0;
            this.cl.Text = "Enter total number";
            // 
            // cn
            // 
            this.cn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cn.Location = new System.Drawing.Point(178, 16);
            this.cn.Name = "cn";
            this.cn.Size = new System.Drawing.Size(87, 24);
            this.cn.TabIndex = 1;
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(190, 61);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 2;
            this.start.Text = "START";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // il
            // 
            this.il.AutoSize = true;
            this.il.Enabled = false;
            this.il.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.il.Location = new System.Drawing.Point(12, 107);
            this.il.Name = "il";
            this.il.Size = new System.Drawing.Size(217, 17);
            this.il.TabIndex = 3;
            this.il.Text = "Fill up Coloumn and Beam field";
            // 
            // lengthl
            // 
            this.lengthl.AutoSize = true;
            this.lengthl.Enabled = false;
            this.lengthl.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthl.Location = new System.Drawing.Point(12, 133);
            this.lengthl.Name = "lengthl";
            this.lengthl.Size = new System.Drawing.Size(61, 17);
            this.lengthl.TabIndex = 4;
            this.lengthl.Text = "Length :";
            // 
            // bl
            // 
            this.bl.AutoSize = true;
            this.bl.Enabled = false;
            this.bl.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bl.Location = new System.Drawing.Point(12, 159);
            this.bl.Name = "bl";
            this.bl.Size = new System.Drawing.Size(61, 17);
            this.bl.TabIndex = 5;
            this.bl.Text = "b          :";
            // 
            // hl
            // 
            this.hl.AutoSize = true;
            this.hl.Enabled = false;
            this.hl.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hl.Location = new System.Drawing.Point(13, 189);
            this.hl.Name = "hl";
            this.hl.Size = new System.Drawing.Size(60, 17);
            this.hl.TabIndex = 6;
            this.hl.Text = "h          :";
            // 
            // ll
            // 
            this.ll.AutoSize = true;
            this.ll.Enabled = false;
            this.ll.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ll.Location = new System.Drawing.Point(13, 219);
            this.ll.Name = "ll";
            this.ll.Size = new System.Drawing.Size(49, 17);
            this.ll.TabIndex = 7;
            this.ll.Text = "Load :";
            // 
            // ltf
            // 
            this.ltf.Enabled = false;
            this.ltf.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.ltf.Location = new System.Drawing.Point(165, 126);
            this.ltf.Name = "ltf";
            this.ltf.Size = new System.Drawing.Size(100, 24);
            this.ltf.TabIndex = 8;
            this.ltf.Text = "0";
            // 
            // btf
            // 
            this.btf.Enabled = false;
            this.btf.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btf.Location = new System.Drawing.Point(165, 156);
            this.btf.Name = "btf";
            this.btf.Size = new System.Drawing.Size(100, 24);
            this.btf.TabIndex = 9;
            this.btf.Text = "0";
            // 
            // htf
            // 
            this.htf.Enabled = false;
            this.htf.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.htf.Location = new System.Drawing.Point(165, 186);
            this.htf.Name = "htf";
            this.htf.Size = new System.Drawing.Size(100, 24);
            this.htf.TabIndex = 10;
            this.htf.Text = "0";
            // 
            // lotf
            // 
            this.lotf.Enabled = false;
            this.lotf.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lotf.Location = new System.Drawing.Point(165, 216);
            this.lotf.Name = "lotf";
            this.lotf.Size = new System.Drawing.Size(100, 24);
            this.lotf.TabIndex = 11;
            this.lotf.Text = "0";
            // 
            // next
            // 
            this.next.Enabled = false;
            this.next.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.next.Location = new System.Drawing.Point(190, 256);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 23);
            this.next.TabIndex = 12;
            this.next.Text = "NEXT";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(284, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Size = new System.Drawing.Size(617, 339);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(546, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "RESULT SHEET";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 385);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.next);
            this.Controls.Add(this.lotf);
            this.Controls.Add(this.htf);
            this.Controls.Add(this.btf);
            this.Controls.Add(this.ltf);
            this.Controls.Add(this.ll);
            this.Controls.Add(this.hl);
            this.Controls.Add(this.bl);
            this.Controls.Add(this.lengthl);
            this.Controls.Add(this.il);
            this.Controls.Add(this.start);
            this.Controls.Add(this.cn);
            this.Controls.Add(this.cl);
            this.MaximumSize = new System.Drawing.Size(929, 423);
            this.MinimumSize = new System.Drawing.Size(929, 423);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cl;
        private System.Windows.Forms.TextBox cn;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label il;
        private System.Windows.Forms.Label lengthl;
        private System.Windows.Forms.Label bl;
        private System.Windows.Forms.Label hl;
        private System.Windows.Forms.Label ll;
        private System.Windows.Forms.TextBox ltf;
        private System.Windows.Forms.TextBox btf;
        private System.Windows.Forms.TextBox htf;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.TextBox lotf;
        public int cln;
        public int v;
        public Material[] ma;
        public string output;
        public int click;
        public string footing;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
    }
}

