namespace 单链表_第二周
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
            this.pBox_slist = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_slistcount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rb_rear1 = new System.Windows.Forms.RadioButton();
            this.rb_head1 = new System.Windows.Forms.RadioButton();
            this.bt_clear = new System.Windows.Forms.Button();
            this.bt_create = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_nextnode = new System.Windows.Forms.Button();
            this.bt_headnode = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_num2 = new System.Windows.Forms.TextBox();
            this.bt_rangedelete = new System.Windows.Forms.Button();
            this.tb_num1 = new System.Windows.Forms.TextBox();
            this.bt_upside = new System.Windows.Forms.Button();
            this.bt_rangefind = new System.Windows.Forms.Button();
            this.bt_random = new System.Windows.Forms.Button();
            this.bt_insert = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.tb_modify = new System.Windows.Forms.TextBox();
            this.rb_insert0 = new System.Windows.Forms.RadioButton();
            this.rb_insertn = new System.Windows.Forms.RadioButton();
            this.rb_insert2 = new System.Windows.Forms.RadioButton();
            this.rb_insert1 = new System.Windows.Forms.RadioButton();
            this.bt_find = new System.Windows.Forms.Button();
            this.bt_modify = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_next = new System.Windows.Forms.TextBox();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.tb_data = new System.Windows.Forms.TextBox();
            this.btn_getLength = new System.Windows.Forms.Button();
            this.btn_reverse = new System.Windows.Forms.Button();
            this.tbRStart = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbREnd = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_slist)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pBox_slist
            // 
            this.pBox_slist.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pBox_slist.Location = new System.Drawing.Point(0, 12);
            this.pBox_slist.Name = "pBox_slist";
            this.pBox_slist.Size = new System.Drawing.Size(693, 618);
            this.pBox_slist.TabIndex = 0;
            this.pBox_slist.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_slistcount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rb_rear1);
            this.groupBox1.Controls.Add(this.rb_head1);
            this.groupBox1.Controls.Add(this.bt_clear);
            this.groupBox1.Controls.Add(this.bt_create);
            this.groupBox1.Location = new System.Drawing.Point(699, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 141);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "初始化";
            // 
            // tb_slistcount
            // 
            this.tb_slistcount.Location = new System.Drawing.Point(67, 63);
            this.tb_slistcount.Name = "tb_slistcount";
            this.tb_slistcount.Size = new System.Drawing.Size(79, 25);
            this.tb_slistcount.TabIndex = 11;
            this.tb_slistcount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "(1~99)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "个数";
            // 
            // rb_rear1
            // 
            this.rb_rear1.AutoSize = true;
            this.rb_rear1.Location = new System.Drawing.Point(121, 25);
            this.rb_rear1.Name = "rb_rear1";
            this.rb_rear1.Size = new System.Drawing.Size(73, 19);
            this.rb_rear1.TabIndex = 8;
            this.rb_rear1.Text = "尾插法";
            this.rb_rear1.UseVisualStyleBackColor = true;
            // 
            // rb_head1
            // 
            this.rb_head1.AutoSize = true;
            this.rb_head1.Checked = true;
            this.rb_head1.Location = new System.Drawing.Point(15, 25);
            this.rb_head1.Name = "rb_head1";
            this.rb_head1.Size = new System.Drawing.Size(73, 19);
            this.rb_head1.TabIndex = 7;
            this.rb_head1.TabStop = true;
            this.rb_head1.Text = "头插法";
            this.rb_head1.UseVisualStyleBackColor = true;
            // 
            // bt_clear
            // 
            this.bt_clear.Location = new System.Drawing.Point(121, 102);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(86, 33);
            this.bt_clear.TabIndex = 6;
            this.bt_clear.Text = "清空";
            this.bt_clear.UseVisualStyleBackColor = true;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // bt_create
            // 
            this.bt_create.Location = new System.Drawing.Point(15, 102);
            this.bt_create.Name = "bt_create";
            this.bt_create.Size = new System.Drawing.Size(86, 33);
            this.bt_create.TabIndex = 5;
            this.bt_create.Text = "初始化";
            this.bt_create.UseVisualStyleBackColor = true;
            this.bt_create.Click += new System.EventHandler(this.bt_create_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_nextnode);
            this.groupBox2.Controls.Add(this.bt_headnode);
            this.groupBox2.Location = new System.Drawing.Point(699, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 61);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "结点移动";
            // 
            // bt_nextnode
            // 
            this.bt_nextnode.Location = new System.Drawing.Point(121, 22);
            this.bt_nextnode.Name = "bt_nextnode";
            this.bt_nextnode.Size = new System.Drawing.Size(82, 29);
            this.bt_nextnode.TabIndex = 7;
            this.bt_nextnode.Text = "下一结点";
            this.bt_nextnode.UseVisualStyleBackColor = true;
            this.bt_nextnode.Click += new System.EventHandler(this.bt_nextnode_Click);
            // 
            // bt_headnode
            // 
            this.bt_headnode.Location = new System.Drawing.Point(15, 22);
            this.bt_headnode.Name = "bt_headnode";
            this.bt_headnode.Size = new System.Drawing.Size(82, 29);
            this.bt_headnode.TabIndex = 6;
            this.bt_headnode.Text = "头结点";
            this.bt_headnode.UseVisualStyleBackColor = true;
            this.bt_headnode.Click += new System.EventHandler(this.bt_headnode_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tb_num2);
            this.groupBox3.Controls.Add(this.bt_rangedelete);
            this.groupBox3.Controls.Add(this.tb_num1);
            this.groupBox3.Controls.Add(this.bt_upside);
            this.groupBox3.Controls.Add(this.bt_rangefind);
            this.groupBox3.Controls.Add(this.bt_random);
            this.groupBox3.Controls.Add(this.bt_insert);
            this.groupBox3.Controls.Add(this.bt_delete);
            this.groupBox3.Controls.Add(this.tb_modify);
            this.groupBox3.Controls.Add(this.rb_insert0);
            this.groupBox3.Controls.Add(this.rb_insertn);
            this.groupBox3.Controls.Add(this.rb_insert2);
            this.groupBox3.Controls.Add(this.rb_insert1);
            this.groupBox3.Controls.Add(this.bt_find);
            this.groupBox3.Controls.Add(this.bt_modify);
            this.groupBox3.Location = new System.Drawing.Point(699, 226);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(218, 276);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "结点操作";
            // 
            // tb_num2
            // 
            this.tb_num2.Location = new System.Drawing.Point(121, 238);
            this.tb_num2.Name = "tb_num2";
            this.tb_num2.Size = new System.Drawing.Size(79, 25);
            this.tb_num2.TabIndex = 22;
            this.tb_num2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bt_rangedelete
            // 
            this.bt_rangedelete.Location = new System.Drawing.Point(15, 202);
            this.bt_rangedelete.Name = "bt_rangedelete";
            this.bt_rangedelete.Size = new System.Drawing.Size(82, 31);
            this.bt_rangedelete.TabIndex = 19;
            this.bt_rangedelete.Text = "范围删除";
            this.bt_rangedelete.UseVisualStyleBackColor = true;
            this.bt_rangedelete.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_num1
            // 
            this.tb_num1.Location = new System.Drawing.Point(121, 207);
            this.tb_num1.Name = "tb_num1";
            this.tb_num1.Size = new System.Drawing.Size(79, 25);
            this.tb_num1.TabIndex = 20;
            this.tb_num1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bt_upside
            // 
            this.bt_upside.Location = new System.Drawing.Point(15, 165);
            this.bt_upside.Name = "bt_upside";
            this.bt_upside.Size = new System.Drawing.Size(82, 31);
            this.bt_upside.TabIndex = 18;
            this.bt_upside.Text = "倒置";
            this.bt_upside.UseVisualStyleBackColor = true;
            this.bt_upside.Click += new System.EventHandler(this.bt_upside_Click);
            // 
            // bt_rangefind
            // 
            this.bt_rangefind.Location = new System.Drawing.Point(15, 237);
            this.bt_rangefind.Name = "bt_rangefind";
            this.bt_rangefind.Size = new System.Drawing.Size(82, 31);
            this.bt_rangefind.TabIndex = 21;
            this.bt_rangefind.Text = "范围查找";
            this.bt_rangefind.UseVisualStyleBackColor = true;
            this.bt_rangefind.Click += new System.EventHandler(this.bt_rangefind_Click);
            // 
            // bt_random
            // 
            this.bt_random.Location = new System.Drawing.Point(121, 165);
            this.bt_random.Name = "bt_random";
            this.bt_random.Size = new System.Drawing.Size(82, 31);
            this.bt_random.TabIndex = 20;
            this.bt_random.Text = "随机初始";
            this.bt_random.UseVisualStyleBackColor = true;
            this.bt_random.Click += new System.EventHandler(this.bt_random_Click);
            // 
            // bt_insert
            // 
            this.bt_insert.Location = new System.Drawing.Point(121, 126);
            this.bt_insert.Name = "bt_insert";
            this.bt_insert.Size = new System.Drawing.Size(82, 29);
            this.bt_insert.TabIndex = 17;
            this.bt_insert.Text = "插入";
            this.bt_insert.UseVisualStyleBackColor = true;
            this.bt_insert.Click += new System.EventHandler(this.bt_insert_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(15, 126);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(82, 29);
            this.bt_delete.TabIndex = 16;
            this.bt_delete.Text = "删除";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // tb_modify
            // 
            this.tb_modify.Location = new System.Drawing.Point(67, 86);
            this.tb_modify.Name = "tb_modify";
            this.tb_modify.Size = new System.Drawing.Size(79, 25);
            this.tb_modify.TabIndex = 12;
            this.tb_modify.Text = " ";
            this.tb_modify.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rb_insert0
            // 
            this.rb_insert0.AutoSize = true;
            this.rb_insert0.Checked = true;
            this.rb_insert0.Location = new System.Drawing.Point(15, 101);
            this.rb_insert0.Name = "rb_insert0";
            this.rb_insert0.Size = new System.Drawing.Size(43, 19);
            this.rb_insert0.TabIndex = 15;
            this.rb_insert0.TabStop = true;
            this.rb_insert0.Text = "头";
            this.rb_insert0.UseVisualStyleBackColor = true;
            // 
            // rb_insertn
            // 
            this.rb_insertn.AutoSize = true;
            this.rb_insertn.Location = new System.Drawing.Point(160, 101);
            this.rb_insertn.Name = "rb_insertn";
            this.rb_insertn.Size = new System.Drawing.Size(43, 19);
            this.rb_insertn.TabIndex = 14;
            this.rb_insertn.Text = "尾";
            this.rb_insertn.UseVisualStyleBackColor = true;
            // 
            // rb_insert2
            // 
            this.rb_insert2.AutoSize = true;
            this.rb_insert2.Location = new System.Drawing.Point(160, 76);
            this.rb_insert2.Name = "rb_insert2";
            this.rb_insert2.Size = new System.Drawing.Size(43, 19);
            this.rb_insert2.TabIndex = 13;
            this.rb_insert2.Text = "后";
            this.rb_insert2.UseVisualStyleBackColor = true;
            // 
            // rb_insert1
            // 
            this.rb_insert1.AutoSize = true;
            this.rb_insert1.Location = new System.Drawing.Point(15, 76);
            this.rb_insert1.Name = "rb_insert1";
            this.rb_insert1.Size = new System.Drawing.Size(43, 19);
            this.rb_insert1.TabIndex = 12;
            this.rb_insert1.Text = "前";
            this.rb_insert1.UseVisualStyleBackColor = true;
            // 
            // bt_find
            // 
            this.bt_find.Location = new System.Drawing.Point(121, 34);
            this.bt_find.Name = "bt_find";
            this.bt_find.Size = new System.Drawing.Size(82, 29);
            this.bt_find.TabIndex = 8;
            this.bt_find.Text = "查找";
            this.bt_find.UseVisualStyleBackColor = true;
            this.bt_find.Click += new System.EventHandler(this.bt_find_Click);
            // 
            // bt_modify
            // 
            this.bt_modify.Location = new System.Drawing.Point(15, 34);
            this.bt_modify.Name = "bt_modify";
            this.bt_modify.Size = new System.Drawing.Size(82, 29);
            this.bt_modify.TabIndex = 7;
            this.bt_modify.Text = "修改";
            this.bt_modify.UseVisualStyleBackColor = true;
            this.bt_modify.Click += new System.EventHandler(this.bt_modify_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.tb_next);
            this.groupBox4.Controls.Add(this.tb_address);
            this.groupBox4.Controls.Add(this.tb_data);
            this.groupBox4.Location = new System.Drawing.Point(699, 508);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(218, 124);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "显示";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "next";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "地址";
            // 
            // tb_next
            // 
            this.tb_next.Location = new System.Drawing.Point(94, 94);
            this.tb_next.Name = "tb_next";
            this.tb_next.Size = new System.Drawing.Size(99, 25);
            this.tb_next.TabIndex = 15;
            this.tb_next.Text = "       ";
            this.tb_next.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(94, 20);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(99, 25);
            this.tb_address.TabIndex = 14;
            this.tb_address.Text = "    ";
            this.tb_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_data
            // 
            this.tb_data.Location = new System.Drawing.Point(94, 58);
            this.tb_data.Name = "tb_data";
            this.tb_data.Size = new System.Drawing.Size(99, 25);
            this.tb_data.TabIndex = 13;
            this.tb_data.Text = "    ";
            this.tb_data.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_getLength
            // 
            this.btn_getLength.Font = new System.Drawing.Font("宋体", 12F);
            this.btn_getLength.Location = new System.Drawing.Point(923, 37);
            this.btn_getLength.Name = "btn_getLength";
            this.btn_getLength.Size = new System.Drawing.Size(181, 33);
            this.btn_getLength.TabIndex = 7;
            this.btn_getLength.Text = "获取长度";
            this.btn_getLength.UseVisualStyleBackColor = true;
            this.btn_getLength.Click += new System.EventHandler(this.btn_getLength_Click);
            // 
            // btn_reverse
            // 
            this.btn_reverse.Font = new System.Drawing.Font("宋体", 12F);
            this.btn_reverse.Location = new System.Drawing.Point(923, 213);
            this.btn_reverse.Name = "btn_reverse";
            this.btn_reverse.Size = new System.Drawing.Size(181, 33);
            this.btn_reverse.TabIndex = 8;
            this.btn_reverse.Text = "指定范围元素逆转";
            this.btn_reverse.UseVisualStyleBackColor = true;
            this.btn_reverse.Click += new System.EventHandler(this.btn_reverse_Click);
            // 
            // tbRStart
            // 
            this.tbRStart.Location = new System.Drawing.Point(1045, 146);
            this.tbRStart.Name = "tbRStart";
            this.tbRStart.Size = new System.Drawing.Size(59, 25);
            this.tbRStart.TabIndex = 13;
            this.tbRStart.Text = " ";
            this.tbRStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(920, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "逆转的开始位置";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(920, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "逆转的结束位置";
            // 
            // tbREnd
            // 
            this.tbREnd.Location = new System.Drawing.Point(1045, 185);
            this.tbREnd.Name = "tbREnd";
            this.tbREnd.Size = new System.Drawing.Size(59, 25);
            this.tbREnd.TabIndex = 19;
            this.tbREnd.Text = " ";
            this.tbREnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 12F);
            this.button1.Location = new System.Drawing.Point(923, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 33);
            this.button1.TabIndex = 20;
            this.button1.Text = "所有元素逆转";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1135, 631);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbREnd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbRStart);
            this.Controls.Add(this.btn_reverse);
            this.Controls.Add(this.btn_getLength);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pBox_slist);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " 单链表_26组";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBox_slist)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBox_slist;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rb_rear1;
        private System.Windows.Forms.RadioButton rb_head1;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.Button bt_create;
        private System.Windows.Forms.TextBox tb_slistcount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_nextnode;
        private System.Windows.Forms.Button bt_headnode;
        private System.Windows.Forms.RadioButton rb_insert0;
        private System.Windows.Forms.RadioButton rb_insertn;
        private System.Windows.Forms.RadioButton rb_insert2;
        private System.Windows.Forms.RadioButton rb_insert1;
        private System.Windows.Forms.Button bt_find;
        private System.Windows.Forms.Button bt_modify;
        private System.Windows.Forms.Button bt_upside;
        private System.Windows.Forms.Button bt_insert;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.TextBox tb_modify;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_next;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.TextBox tb_data;
        private System.Windows.Forms.Button bt_rangedelete;
        private System.Windows.Forms.Button bt_random;
        private System.Windows.Forms.Button bt_rangefind;
        private System.Windows.Forms.TextBox tb_num1;
        private System.Windows.Forms.TextBox tb_num2;
        private System.Windows.Forms.Button btn_getLength;
        private System.Windows.Forms.Button btn_reverse;
        private System.Windows.Forms.TextBox tbRStart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbREnd;
        private System.Windows.Forms.Button button1;
    }
}

