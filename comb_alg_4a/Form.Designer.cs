namespace comb_alg_4a
{
    partial class Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbElems = new System.Windows.Forms.TextBox();
            this.tbExactAlg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbGreedAlg = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbSum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // tbElems
            // 
            this.tbElems.Location = new System.Drawing.Point(8, 25);
            this.tbElems.Name = "tbElems";
            this.tbElems.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbElems.Size = new System.Drawing.Size(240, 20);
            this.tbElems.TabIndex = 0;
            this.tbElems.TextChanged += new System.EventHandler(this.tbElems_TextChanged);
            this.tbElems.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbElems_KeyPress);
            // 
            // tbExactAlg
            // 
            this.tbExactAlg.Enabled = false;
            this.tbExactAlg.Location = new System.Drawing.Point(8, 80);
            this.tbExactAlg.Multiline = true;
            this.tbExactAlg.Name = "tbExactAlg";
            this.tbExactAlg.ReadOnly = true;
            this.tbExactAlg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbExactAlg.Size = new System.Drawing.Size(240, 103);
            this.tbExactAlg.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите элементы множества (через пробел):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Точный алгоритм:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Жадный алгоритм:";
            // 
            // tbGreedAlg
            // 
            this.tbGreedAlg.Enabled = false;
            this.tbGreedAlg.Location = new System.Drawing.Point(260, 80);
            this.tbGreedAlg.Multiline = true;
            this.tbGreedAlg.Name = "tbGreedAlg";
            this.tbGreedAlg.ReadOnly = true;
            this.tbGreedAlg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbGreedAlg.Size = new System.Drawing.Size(194, 103);
            this.tbGreedAlg.TabIndex = 5;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgv.Location = new System.Drawing.Point(8, 204);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(446, 82);
            this.dgv.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Точный алгоритм";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Жадный алгоритм";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // tbSum
            // 
            this.tbSum.Location = new System.Drawing.Point(261, 25);
            this.tbSum.Name = "tbSum";
            this.tbSum.Size = new System.Drawing.Size(100, 20);
            this.tbSum.TabIndex = 7;
            this.tbSum.TextChanged += new System.EventHandler(this.tbSum_TextChanged);
            this.tbSum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbElems_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Искомая сумма:";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(379, 23);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 9;
            this.btnRun.Text = "Запустить";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 295);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbSum);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.tbGreedAlg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbExactAlg);
            this.Controls.Add(this.tbElems);
            this.MaximizeBox = false;
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Перебор и жадный алгоритмы";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbElems;
        private System.Windows.Forms.TextBox tbExactAlg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbGreedAlg;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox tbSum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

