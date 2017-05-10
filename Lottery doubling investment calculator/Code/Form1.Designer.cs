namespace 倍投计算器
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bt = new System.Windows.Forms.TextBox();
            this.ct = new System.Windows.Forms.TextBox();
            this.zj = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Out = new System.Windows.Forms.TextBox();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10F);
            this.label1.Location = new System.Drawing.Point(34, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "倍投期数";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10F);
            this.label2.Location = new System.Drawing.Point(204, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "初投资金";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10F);
            this.label3.Location = new System.Drawing.Point(374, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "中奖金额";
            // 
            // bt
            // 
            this.bt.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.bt.Location = new System.Drawing.Point(103, 21);
            this.bt.Name = "bt";
            this.bt.Size = new System.Drawing.Size(79, 21);
            this.bt.TabIndex = 3;
            this.bt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // ct
            // 
            this.ct.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.ct.Location = new System.Drawing.Point(273, 21);
            this.ct.Name = "ct";
            this.ct.Size = new System.Drawing.Size(79, 21);
            this.ct.TabIndex = 4;
            this.ct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // zj
            // 
            this.zj.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.zj.Location = new System.Drawing.Point(443, 21);
            this.zj.Name = "zj";
            this.zj.Size = new System.Drawing.Size(79, 21);
            this.zj.TabIndex = 5;
            this.zj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Out);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(662, 360);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "倍投计划";
            // 
            // Out
            // 
            this.Out.AcceptsReturn = true;
            this.Out.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Out.Location = new System.Drawing.Point(3, 17);
            this.Out.Multiline = true;
            this.Out.Name = "Out";
            this.Out.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Out.Size = new System.Drawing.Size(656, 340);
            this.Out.TabIndex = 0;
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.Location = new System.Drawing.Point(553, 20);
            this.skinButton1.MouseBack = null;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Radius = 20;
            this.skinButton1.Size = new System.Drawing.Size(75, 24);
            this.skinButton1.TabIndex = 8;
            this.skinButton1.Text = "计算";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.SkinButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 416);
            this.Controls.Add(this.skinButton1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.zj);
            this.Controls.Add(this.ct);
            this.Controls.Add(this.bt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(678, 455);
            this.Name = "Form1";
            this.Text = "彩票倍投计算器 v1.3";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bt;
        private System.Windows.Forms.TextBox ct;
        private System.Windows.Forms.TextBox zj;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Out;
        private CCWin.SkinControl.SkinButton skinButton1;
    }
}

