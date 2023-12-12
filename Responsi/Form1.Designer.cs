namespace Responsi
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            tbName = new TextBox();
            cbDep = new ComboBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btnInsert = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            dgv = new DataGridView();
            btnLoad = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(56, 95);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 0;
            label1.Text = "Nama Karyawan: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(66, 133);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 1;
            label2.Text = "Dep. Karyawan:";
            // 
            // tbName
            // 
            tbName.Location = new Point(161, 92);
            tbName.Name = "tbName";
            tbName.Size = new Size(240, 23);
            tbName.TabIndex = 2;
            // 
            // cbDep
            // 
            cbDep.FormattingEnabled = true;
            cbDep.Location = new Point(164, 130);
            cbDep.Name = "cbDep";
            cbDep.Size = new Size(237, 23);
            cbDep.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(56, 30);
            label3.Name = "label3";
            label3.Size = new Size(258, 37);
            label3.TabIndex = 4;
            label3.Text = "GOJEK TOKOPEDIA";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(457, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(154, 123);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "ID Departemen";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(17, 99);
            label8.Name = "label8";
            label8.Size = new Size(63, 15);
            label8.TabIndex = 10;
            label8.Text = "5 : Finance";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(17, 80);
            label7.Name = "label7";
            label7.Size = new Size(117, 15);
            label7.TabIndex = 9;
            label7.Text = "4 : Product Manager";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(17, 60);
            label6.Name = "label6";
            label6.Size = new Size(77, 15);
            label6.TabIndex = 8;
            label6.Text = "3 : Developer";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(17, 41);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 7;
            label5.Text = "2 : Engineer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(17, 22);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 6;
            label4.Text = "1 : HR";
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.MediumAquamarine;
            btnInsert.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsert.ForeColor = Color.DarkSlateGray;
            btnInsert.Location = new Point(66, 170);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(152, 79);
            btnInsert.TabIndex = 6;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Bisque;
            btnEdit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.SaddleBrown;
            btnEdit.Location = new Point(260, 170);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(160, 79);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.LightCoral;
            btnDelete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.Maroon;
            btnDelete.Location = new Point(457, 170);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(154, 79);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(66, 269);
            dgv.Name = "dgv";
            dgv.RowTemplate.Height = 25;
            dgv.Size = new Size(545, 201);
            dgv.TabIndex = 9;
            dgv.CellClick += dgv_CellClick;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(489, 489);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(122, 29);
            btnLoad.TabIndex = 10;
            btnLoad.Text = "Load Data";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(665, 530);
            Controls.Add(btnLoad);
            Controls.Add(dgv);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnInsert);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(cbDep);
            Controls.Add(tbName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbName;
        private ComboBox cbDep;
        private Label label3;
        private GroupBox groupBox1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnInsert;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView dgv;
        private Button btnLoad;
    }
}
