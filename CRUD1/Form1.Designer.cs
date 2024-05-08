namespace CRUD1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNAME = new System.Windows.Forms.TextBox();
            this.txtROLLNO = new System.Windows.Forms.TextBox();
            this.txtCOURSE = new System.Windows.Forms.TextBox();
            this.btnINSERT = new System.Windows.Forms.Button();
            this.btnUPDATE = new System.Windows.Forms.Button();
            this.btnDELETE = new System.Windows.Forms.Button();
            this.btnCLEAR = new System.Windows.Forms.Button();
            this.btnEXIT = new System.Windows.Forms.Button();
            this.btnSHOWALL = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtFIND = new System.Windows.Forms.TextBox();
            this.lblFIND = new System.Windows.Forms.Label();
            this.btnFIND = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "NAME :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "ROLL NO :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(125, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "COURSE :";
            // 
            // txtNAME
            // 
            this.txtNAME.Location = new System.Drawing.Point(227, 135);
            this.txtNAME.Name = "txtNAME";
            this.txtNAME.Size = new System.Drawing.Size(246, 20);
            this.txtNAME.TabIndex = 3;
            // 
            // txtROLLNO
            // 
            this.txtROLLNO.Location = new System.Drawing.Point(227, 91);
            this.txtROLLNO.Name = "txtROLLNO";
            this.txtROLLNO.Size = new System.Drawing.Size(246, 20);
            this.txtROLLNO.TabIndex = 4;
            // 
            // txtCOURSE
            // 
            this.txtCOURSE.Location = new System.Drawing.Point(227, 178);
            this.txtCOURSE.Name = "txtCOURSE";
            this.txtCOURSE.Size = new System.Drawing.Size(246, 20);
            this.txtCOURSE.TabIndex = 5;
            // 
            // btnINSERT
            // 
            this.btnINSERT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnINSERT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnINSERT.Location = new System.Drawing.Point(533, 91);
            this.btnINSERT.Name = "btnINSERT";
            this.btnINSERT.Size = new System.Drawing.Size(102, 31);
            this.btnINSERT.TabIndex = 6;
            this.btnINSERT.Text = "INSERT";
            this.btnINSERT.UseVisualStyleBackColor = false;
            this.btnINSERT.Click += new System.EventHandler(this.btnINSERT_Click);
            // 
            // btnUPDATE
            // 
            this.btnUPDATE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnUPDATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUPDATE.Location = new System.Drawing.Point(680, 91);
            this.btnUPDATE.Name = "btnUPDATE";
            this.btnUPDATE.Size = new System.Drawing.Size(102, 31);
            this.btnUPDATE.TabIndex = 7;
            this.btnUPDATE.Text = "UPDATE";
            this.btnUPDATE.UseVisualStyleBackColor = false;
            this.btnUPDATE.Click += new System.EventHandler(this.btnUPDATE_Click);
            // 
            // btnDELETE
            // 
            this.btnDELETE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnDELETE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDELETE.Location = new System.Drawing.Point(821, 91);
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Size = new System.Drawing.Size(102, 31);
            this.btnDELETE.TabIndex = 8;
            this.btnDELETE.Text = "DELETE";
            this.btnDELETE.UseVisualStyleBackColor = false;
            this.btnDELETE.Click += new System.EventHandler(this.btnDELETE_Click);
            // 
            // btnCLEAR
            // 
            this.btnCLEAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCLEAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCLEAR.Location = new System.Drawing.Point(680, 157);
            this.btnCLEAR.Name = "btnCLEAR";
            this.btnCLEAR.Size = new System.Drawing.Size(102, 31);
            this.btnCLEAR.TabIndex = 9;
            this.btnCLEAR.Text = "CLEAR";
            this.btnCLEAR.UseVisualStyleBackColor = false;
            this.btnCLEAR.Click += new System.EventHandler(this.btnCLEAR_Click);
            // 
            // btnEXIT
            // 
            this.btnEXIT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnEXIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEXIT.Location = new System.Drawing.Point(821, 157);
            this.btnEXIT.Name = "btnEXIT";
            this.btnEXIT.Size = new System.Drawing.Size(102, 31);
            this.btnEXIT.TabIndex = 10;
            this.btnEXIT.Text = "EXIT";
            this.btnEXIT.UseVisualStyleBackColor = false;
            this.btnEXIT.Click += new System.EventHandler(this.btnEXIT_Click);
            // 
            // btnSHOWALL
            // 
            this.btnSHOWALL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSHOWALL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSHOWALL.Location = new System.Drawing.Point(533, 157);
            this.btnSHOWALL.Name = "btnSHOWALL";
            this.btnSHOWALL.Size = new System.Drawing.Size(102, 31);
            this.btnSHOWALL.TabIndex = 11;
            this.btnSHOWALL.Text = "SHOW ALL";
            this.btnSHOWALL.UseVisualStyleBackColor = false;
            this.btnSHOWALL.Click += new System.EventHandler(this.btnSHOWALL_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(127, 281);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(796, 150);
            this.dataGridView1.TabIndex = 12;
            // 
            // txtFIND
            // 
            this.txtFIND.Location = new System.Drawing.Point(465, 237);
            this.txtFIND.Name = "txtFIND";
            this.txtFIND.Size = new System.Drawing.Size(246, 20);
            this.txtFIND.TabIndex = 14;
            // 
            // lblFIND
            // 
            this.lblFIND.AutoSize = true;
            this.lblFIND.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFIND.Location = new System.Drawing.Point(280, 237);
            this.lblFIND.Name = "lblFIND";
            this.lblFIND.Size = new System.Drawing.Size(161, 22);
            this.lblFIND.TabIndex = 13;
            this.lblFIND.Text = "FIND BY ROLL NO:";
            // 
            // btnFIND
            // 
            this.btnFIND.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnFIND.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFIND.Location = new System.Drawing.Point(751, 231);
            this.btnFIND.Name = "btnFIND";
            this.btnFIND.Size = new System.Drawing.Size(102, 31);
            this.btnFIND.TabIndex = 15;
            this.btnFIND.Text = "FIND";
            this.btnFIND.UseVisualStyleBackColor = false;
            this.btnFIND.Click += new System.EventHandler(this.btnFIND_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 493);
            this.Controls.Add(this.btnFIND);
            this.Controls.Add(this.txtFIND);
            this.Controls.Add(this.lblFIND);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSHOWALL);
            this.Controls.Add(this.btnEXIT);
            this.Controls.Add(this.btnCLEAR);
            this.Controls.Add(this.btnDELETE);
            this.Controls.Add(this.btnUPDATE);
            this.Controls.Add(this.btnINSERT);
            this.Controls.Add(this.txtCOURSE);
            this.Controls.Add(this.txtROLLNO);
            this.Controls.Add(this.txtNAME);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNAME;
        private System.Windows.Forms.TextBox txtROLLNO;
        private System.Windows.Forms.TextBox txtCOURSE;
        private System.Windows.Forms.Button btnINSERT;
        private System.Windows.Forms.Button btnUPDATE;
        private System.Windows.Forms.Button btnDELETE;
        private System.Windows.Forms.Button btnCLEAR;
        private System.Windows.Forms.Button btnEXIT;
        private System.Windows.Forms.Button btnSHOWALL;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtFIND;
        private System.Windows.Forms.Label lblFIND;
        private System.Windows.Forms.Button btnFIND;
    }
}

