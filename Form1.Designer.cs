
namespace gatcha
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_pickUp_stigma = new System.Windows.Forms.Label();
            this.label_pickUp_equip = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_equip_6 = new System.Windows.Forms.Label();
            this.label_equip_5 = new System.Windows.Forms.Label();
            this.label_equip_4 = new System.Windows.Forms.Label();
            this.label_equip_3 = new System.Windows.Forms.Label();
            this.label_equip_2 = new System.Windows.Forms.Label();
            this.label_equip_1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label_stigma_4 = new System.Windows.Forms.Label();
            this.label_stigma_3 = new System.Windows.Forms.Label();
            this.label_stigma_2 = new System.Windows.Forms.Label();
            this.label_stigma_1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label_count_money = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_count = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView_result = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.장비등록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_result)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_pickUp_stigma);
            this.groupBox1.Controls.Add(this.label_pickUp_equip);
            this.groupBox1.Location = new System.Drawing.Point(33, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "로테이션";
            // 
            // label_pickUp_stigma
            // 
            this.label_pickUp_stigma.AutoSize = true;
            this.label_pickUp_stigma.Location = new System.Drawing.Point(6, 60);
            this.label_pickUp_stigma.Name = "label_pickUp_stigma";
            this.label_pickUp_stigma.Size = new System.Drawing.Size(38, 12);
            this.label_pickUp_stigma.TabIndex = 1;
            this.label_pickUp_stigma.Text = "label2";
            // 
            // label_pickUp_equip
            // 
            this.label_pickUp_equip.AutoSize = true;
            this.label_pickUp_equip.Location = new System.Drawing.Point(6, 31);
            this.label_pickUp_equip.Name = "label_pickUp_equip";
            this.label_pickUp_equip.Size = new System.Drawing.Size(38, 12);
            this.label_pickUp_equip.TabIndex = 0;
            this.label_pickUp_equip.Text = "label1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_equip_6);
            this.groupBox2.Controls.Add(this.label_equip_5);
            this.groupBox2.Controls.Add(this.label_equip_4);
            this.groupBox2.Controls.Add(this.label_equip_3);
            this.groupBox2.Controls.Add(this.label_equip_2);
            this.groupBox2.Controls.Add(this.label_equip_1);
            this.groupBox2.Location = new System.Drawing.Point(239, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "비로테이션 무기";
            // 
            // label_equip_6
            // 
            this.label_equip_6.AutoSize = true;
            this.label_equip_6.Location = new System.Drawing.Point(134, 76);
            this.label_equip_6.Name = "label_equip_6";
            this.label_equip_6.Size = new System.Drawing.Size(38, 12);
            this.label_equip_6.TabIndex = 7;
            this.label_equip_6.Text = "label4";
            // 
            // label_equip_5
            // 
            this.label_equip_5.AutoSize = true;
            this.label_equip_5.Location = new System.Drawing.Point(134, 46);
            this.label_equip_5.Name = "label_equip_5";
            this.label_equip_5.Size = new System.Drawing.Size(38, 12);
            this.label_equip_5.TabIndex = 6;
            this.label_equip_5.Text = "label5";
            // 
            // label_equip_4
            // 
            this.label_equip_4.AutoSize = true;
            this.label_equip_4.Location = new System.Drawing.Point(134, 17);
            this.label_equip_4.Name = "label_equip_4";
            this.label_equip_4.Size = new System.Drawing.Size(38, 12);
            this.label_equip_4.TabIndex = 5;
            this.label_equip_4.Text = "label6";
            // 
            // label_equip_3
            // 
            this.label_equip_3.AutoSize = true;
            this.label_equip_3.Location = new System.Drawing.Point(6, 76);
            this.label_equip_3.Name = "label_equip_3";
            this.label_equip_3.Size = new System.Drawing.Size(38, 12);
            this.label_equip_3.TabIndex = 4;
            this.label_equip_3.Text = "label3";
            // 
            // label_equip_2
            // 
            this.label_equip_2.AutoSize = true;
            this.label_equip_2.Location = new System.Drawing.Point(6, 46);
            this.label_equip_2.Name = "label_equip_2";
            this.label_equip_2.Size = new System.Drawing.Size(38, 12);
            this.label_equip_2.TabIndex = 3;
            this.label_equip_2.Text = "label2";
            // 
            // label_equip_1
            // 
            this.label_equip_1.AutoSize = true;
            this.label_equip_1.Location = new System.Drawing.Point(6, 17);
            this.label_equip_1.Name = "label_equip_1";
            this.label_equip_1.Size = new System.Drawing.Size(38, 12);
            this.label_equip_1.TabIndex = 2;
            this.label_equip_1.Text = "label1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label_stigma_4);
            this.groupBox3.Controls.Add(this.label_stigma_3);
            this.groupBox3.Controls.Add(this.label_stigma_2);
            this.groupBox3.Controls.Add(this.label_stigma_1);
            this.groupBox3.Location = new System.Drawing.Point(515, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(261, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "비로테이션 성흔";
            // 
            // label_stigma_4
            // 
            this.label_stigma_4.AutoSize = true;
            this.label_stigma_4.Location = new System.Drawing.Point(127, 60);
            this.label_stigma_4.Name = "label_stigma_4";
            this.label_stigma_4.Size = new System.Drawing.Size(38, 12);
            this.label_stigma_4.TabIndex = 6;
            this.label_stigma_4.Text = "label4";
            // 
            // label_stigma_3
            // 
            this.label_stigma_3.AutoSize = true;
            this.label_stigma_3.Location = new System.Drawing.Point(127, 29);
            this.label_stigma_3.Name = "label_stigma_3";
            this.label_stigma_3.Size = new System.Drawing.Size(38, 12);
            this.label_stigma_3.TabIndex = 5;
            this.label_stigma_3.Text = "label3";
            // 
            // label_stigma_2
            // 
            this.label_stigma_2.AutoSize = true;
            this.label_stigma_2.Location = new System.Drawing.Point(6, 60);
            this.label_stigma_2.Name = "label_stigma_2";
            this.label_stigma_2.Size = new System.Drawing.Size(38, 12);
            this.label_stigma_2.TabIndex = 4;
            this.label_stigma_2.Text = "label2";
            // 
            // label_stigma_1
            // 
            this.label_stigma_1.AutoSize = true;
            this.label_stigma_1.Location = new System.Drawing.Point(6, 29);
            this.label_stigma_1.Name = "label_stigma_1";
            this.label_stigma_1.Size = new System.Drawing.Size(38, 12);
            this.label_stigma_1.TabIndex = 3;
            this.label_stigma_1.Text = "label1";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label_count_money);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label_count);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Location = new System.Drawing.Point(33, 133);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(743, 71);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "뽑기";
            // 
            // label_count_money
            // 
            this.label_count_money.AutoSize = true;
            this.label_count_money.Location = new System.Drawing.Point(685, 17);
            this.label_count_money.Name = "label_count_money";
            this.label_count_money.Size = new System.Drawing.Size(38, 12);
            this.label_count_money.TabIndex = 5;
            this.label_count_money.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(622, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "소모 수정";
            // 
            // label_count
            // 
            this.label_count.AutoSize = true;
            this.label_count.Location = new System.Drawing.Point(563, 17);
            this.label_count.Name = "label_count";
            this.label_count.Size = new System.Drawing.Size(38, 12);
            this.label_count.TabIndex = 3;
            this.label_count.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(500, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "시행 횟수";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(386, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(351, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "10회 뽑기";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(360, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "1회 뽑기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView_result);
            this.groupBox5.Location = new System.Drawing.Point(33, 210);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(743, 229);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "결과";
            // 
            // dataGridView_result
            // 
            this.dataGridView_result.AutoGenerateColumns = false;
            this.dataGridView_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_result.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.rareDataGridViewTextBoxColumn});
            this.dataGridView_result.DataSource = this.itemBindingSource1;
            this.dataGridView_result.Location = new System.Drawing.Point(3, 17);
            this.dataGridView_result.Name = "dataGridView_result";
            this.dataGridView_result.RowTemplate.Height = 23;
            this.dataGridView_result.Size = new System.Drawing.Size(734, 206);
            this.dataGridView_result.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.장비등록ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 장비등록ToolStripMenuItem
            // 
            this.장비등록ToolStripMenuItem.Name = "장비등록ToolStripMenuItem";
            this.장비등록ToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.장비등록ToolStripMenuItem.Text = "장비 등록";
            this.장비등록ToolStripMenuItem.Click += new System.EventHandler(this.장비등록ToolStripMenuItem_Click);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // rareDataGridViewTextBoxColumn
            // 
            this.rareDataGridViewTextBoxColumn.DataPropertyName = "rare";
            this.rareDataGridViewTextBoxColumn.HeaderText = "rare";
            this.rareDataGridViewTextBoxColumn.Name = "rareDataGridViewTextBoxColumn";
            // 
            // itemBindingSource1
            // 
            this.itemBindingSource1.DataSource = typeof(gatcha.Item);
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(gatcha.Item);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_result)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label_pickUp_stigma;
        private System.Windows.Forms.Label label_pickUp_equip;
        private System.Windows.Forms.Label label_equip_6;
        private System.Windows.Forms.Label label_equip_5;
        private System.Windows.Forms.Label label_equip_4;
        private System.Windows.Forms.Label label_equip_3;
        private System.Windows.Forms.Label label_equip_2;
        private System.Windows.Forms.Label label_equip_1;
        private System.Windows.Forms.Label label_stigma_4;
        private System.Windows.Forms.Label label_stigma_3;
        private System.Windows.Forms.Label label_stigma_2;
        private System.Windows.Forms.Label label_stigma_1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label_count_money;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_count;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView_result;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rareDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource itemBindingSource1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 장비등록ToolStripMenuItem;
    }
}

