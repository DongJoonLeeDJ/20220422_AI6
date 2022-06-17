namespace Lotto
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
            this.lotto_button = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Label();
            this.num2 = new System.Windows.Forms.Label();
            this.num3 = new System.Windows.Forms.Label();
            this.num5 = new System.Windows.Forms.Label();
            this.num6 = new System.Windows.Forms.Label();
            this.num4 = new System.Windows.Forms.Label();
            this.bonus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.center_panel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.result_box = new System.Windows.Forms.TextBox();
            this.search_button = new System.Windows.Forms.Button();
            this.fixed_label2 = new System.Windows.Forms.Label();
            this.search_number_box = new System.Windows.Forms.TextBox();
            this.mid_panel = new System.Windows.Forms.Panel();
            this.won_label = new System.Windows.Forms.Label();
            this.match_num_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.match_bonus_num_label = new System.Windows.Forms.Label();
            this.match_label = new System.Windows.Forms.Label();
            this.grade_number_label = new System.Windows.Forms.Label();
            this.grade_label = new System.Windows.Forms.Label();
            this.money_label = new System.Windows.Forms.Label();
            this.used_money_label = new System.Windows.Forms.Label();
            this.fixed_comment = new System.Windows.Forms.Label();
            this.top_panel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.center_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.mid_panel.SuspendLayout();
            this.top_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lotto_button
            // 
            this.lotto_button.BackColor = System.Drawing.Color.Brown;
            this.lotto_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.lotto_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lotto_button.Location = new System.Drawing.Point(3, 3);
            this.lotto_button.Name = "lotto_button";
            this.lotto_button.Size = new System.Drawing.Size(44, 44);
            this.lotto_button.TabIndex = 0;
            this.lotto_button.Text = "start";
            this.lotto_button.UseVisualStyleBackColor = false;
            this.lotto_button.Click += new System.EventHandler(this.lotto_button_Click);
            // 
            // num1
            // 
            this.num1.BackColor = System.Drawing.Color.White;
            this.num1.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold);
            this.num1.Location = new System.Drawing.Point(3, 57);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(64, 50);
            this.num1.TabIndex = 1;
            this.num1.Text = "00";
            this.num1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num2
            // 
            this.num2.BackColor = System.Drawing.Color.White;
            this.num2.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold);
            this.num2.Location = new System.Drawing.Point(89, 57);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(64, 50);
            this.num2.TabIndex = 1;
            this.num2.Text = "00";
            this.num2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num3
            // 
            this.num3.BackColor = System.Drawing.Color.White;
            this.num3.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold);
            this.num3.Location = new System.Drawing.Point(175, 57);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(64, 50);
            this.num3.TabIndex = 1;
            this.num3.Text = "00";
            this.num3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num5
            // 
            this.num5.BackColor = System.Drawing.Color.White;
            this.num5.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold);
            this.num5.Location = new System.Drawing.Point(347, 57);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(64, 50);
            this.num5.TabIndex = 1;
            this.num5.Text = "00";
            this.num5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num6
            // 
            this.num6.BackColor = System.Drawing.Color.White;
            this.num6.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold);
            this.num6.Location = new System.Drawing.Point(433, 57);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(64, 50);
            this.num6.TabIndex = 1;
            this.num6.Text = "00";
            this.num6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num4
            // 
            this.num4.BackColor = System.Drawing.Color.White;
            this.num4.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold);
            this.num4.Location = new System.Drawing.Point(261, 57);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(64, 50);
            this.num4.TabIndex = 1;
            this.num4.Text = "00";
            this.num4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bonus
            // 
            this.bonus.BackColor = System.Drawing.Color.White;
            this.bonus.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold);
            this.bonus.Location = new System.Drawing.Point(590, 57);
            this.bonus.Name = "bonus";
            this.bonus.Size = new System.Drawing.Size(64, 50);
            this.bonus.TabIndex = 1;
            this.bonus.Text = "00";
            this.bonus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(519, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "+";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // center_panel
            // 
            this.center_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.center_panel.Controls.Add(this.panel1);
            this.center_panel.Controls.Add(this.mid_panel);
            this.center_panel.Controls.Add(this.top_panel);
            this.center_panel.Location = new System.Drawing.Point(12, 12);
            this.center_panel.Name = "center_panel";
            this.center_panel.Size = new System.Drawing.Size(662, 476);
            this.center_panel.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.result_box);
            this.panel1.Controls.Add(this.search_button);
            this.panel1.Controls.Add(this.fixed_label2);
            this.panel1.Controls.Add(this.search_number_box);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 403);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 73);
            this.panel1.TabIndex = 3;
            // 
            // result_box
            // 
            this.result_box.Cursor = System.Windows.Forms.Cursors.Default;
            this.result_box.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.result_box.Location = new System.Drawing.Point(252, 6);
            this.result_box.Name = "result_box";
            this.result_box.Size = new System.Drawing.Size(406, 57);
            this.result_box.TabIndex = 2;
            this.result_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // search_button
            // 
            this.search_button.BackColor = System.Drawing.Color.Brown;
            this.search_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.search_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_button.Location = new System.Drawing.Point(196, 9);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(50, 50);
            this.search_button.TabIndex = 1;
            this.search_button.Text = "조회";
            this.search_button.UseVisualStyleBackColor = false;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // fixed_label2
            // 
            this.fixed_label2.AutoSize = true;
            this.fixed_label2.BackColor = System.Drawing.Color.White;
            this.fixed_label2.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.fixed_label2.ForeColor = System.Drawing.Color.Black;
            this.fixed_label2.Location = new System.Drawing.Point(131, 9);
            this.fixed_label2.Name = "fixed_label2";
            this.fixed_label2.Size = new System.Drawing.Size(59, 50);
            this.fixed_label2.TabIndex = 1;
            this.fixed_label2.Text = "차";
            // 
            // search_number_box
            // 
            this.search_number_box.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.search_number_box.Location = new System.Drawing.Point(3, 6);
            this.search_number_box.Name = "search_number_box";
            this.search_number_box.Size = new System.Drawing.Size(125, 57);
            this.search_number_box.TabIndex = 0;
            // 
            // mid_panel
            // 
            this.mid_panel.BackColor = System.Drawing.Color.Gray;
            this.mid_panel.Controls.Add(this.won_label);
            this.mid_panel.Controls.Add(this.match_num_label);
            this.mid_panel.Controls.Add(this.label2);
            this.mid_panel.Controls.Add(this.match_bonus_num_label);
            this.mid_panel.Controls.Add(this.match_label);
            this.mid_panel.Controls.Add(this.grade_number_label);
            this.mid_panel.Controls.Add(this.grade_label);
            this.mid_panel.Controls.Add(this.money_label);
            this.mid_panel.Controls.Add(this.used_money_label);
            this.mid_panel.Controls.Add(this.bonus);
            this.mid_panel.Controls.Add(this.fixed_comment);
            this.mid_panel.Controls.Add(this.label1);
            this.mid_panel.Controls.Add(this.num5);
            this.mid_panel.Controls.Add(this.num4);
            this.mid_panel.Controls.Add(this.num1);
            this.mid_panel.Controls.Add(this.num6);
            this.mid_panel.Controls.Add(this.num2);
            this.mid_panel.Controls.Add(this.num3);
            this.mid_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mid_panel.Location = new System.Drawing.Point(0, 50);
            this.mid_panel.Name = "mid_panel";
            this.mid_panel.Size = new System.Drawing.Size(662, 426);
            this.mid_panel.TabIndex = 2;
            // 
            // won_label
            // 
            this.won_label.AutoSize = true;
            this.won_label.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.won_label.Location = new System.Drawing.Point(608, 120);
            this.won_label.Name = "won_label";
            this.won_label.Size = new System.Drawing.Size(50, 50);
            this.won_label.TabIndex = 4;
            this.won_label.Text = "\\";
            // 
            // match_num_label
            // 
            this.match_num_label.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.match_num_label.Location = new System.Drawing.Point(381, 266);
            this.match_num_label.Name = "match_num_label";
            this.match_num_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.match_num_label.Size = new System.Drawing.Size(125, 50);
            this.match_num_label.TabIndex = 11;
            this.match_num_label.Text = "null개";
            this.match_num_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(496, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 50);
            this.label2.TabIndex = 10;
            this.label2.Text = "+";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // match_bonus_num_label
            // 
            this.match_bonus_num_label.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.match_bonus_num_label.Location = new System.Drawing.Point(538, 266);
            this.match_bonus_num_label.Name = "match_bonus_num_label";
            this.match_bonus_num_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.match_bonus_num_label.Size = new System.Drawing.Size(125, 50);
            this.match_bonus_num_label.TabIndex = 9;
            this.match_bonus_num_label.Text = "null개";
            this.match_bonus_num_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // match_label
            // 
            this.match_label.AutoSize = true;
            this.match_label.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.match_label.Location = new System.Drawing.Point(4, 266);
            this.match_label.Name = "match_label";
            this.match_label.Size = new System.Drawing.Size(306, 50);
            this.match_label.TabIndex = 8;
            this.match_label.Text = "맞춘 번호 개수 : ";
            // 
            // grade_number_label
            // 
            this.grade_number_label.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.grade_number_label.Location = new System.Drawing.Point(538, 193);
            this.grade_number_label.Name = "grade_number_label";
            this.grade_number_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grade_number_label.Size = new System.Drawing.Size(125, 50);
            this.grade_number_label.TabIndex = 7;
            this.grade_number_label.Text = "null등";
            this.grade_number_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grade_label
            // 
            this.grade_label.AutoSize = true;
            this.grade_label.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.grade_label.Location = new System.Drawing.Point(3, 193);
            this.grade_label.Name = "grade_label";
            this.grade_label.Size = new System.Drawing.Size(256, 50);
            this.grade_label.TabIndex = 6;
            this.grade_label.Text = "당신의 등수 : ";
            // 
            // money_label
            // 
            this.money_label.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.money_label.Location = new System.Drawing.Point(261, 120);
            this.money_label.Name = "money_label";
            this.money_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.money_label.Size = new System.Drawing.Size(358, 50);
            this.money_label.TabIndex = 5;
            this.money_label.Text = "0000000000000000";
            this.money_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // used_money_label
            // 
            this.used_money_label.AutoSize = true;
            this.used_money_label.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.used_money_label.Location = new System.Drawing.Point(3, 120);
            this.used_money_label.Name = "used_money_label";
            this.used_money_label.Size = new System.Drawing.Size(269, 50);
            this.used_money_label.TabIndex = 3;
            this.used_money_label.Text = "당신이 쓴 돈 : ";
            // 
            // fixed_comment
            // 
            this.fixed_comment.AutoSize = true;
            this.fixed_comment.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.fixed_comment.Location = new System.Drawing.Point(3, 3);
            this.fixed_comment.Name = "fixed_comment";
            this.fixed_comment.Size = new System.Drawing.Size(307, 50);
            this.fixed_comment.TabIndex = 0;
            this.fixed_comment.Text = "당신이 뽑은 번호";
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.Color.Silver;
            this.top_panel.Controls.Add(this.button1);
            this.top_panel.Controls.Add(this.lotto_button);
            this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(662, 50);
            this.top_panel.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Brown;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(614, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(678, 500);
            this.Controls.Add(this.center_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.center_panel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mid_panel.ResumeLayout(false);
            this.mid_panel.PerformLayout();
            this.top_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button lotto_button;
        private System.Windows.Forms.Label num1;
        private System.Windows.Forms.Label num2;
        private System.Windows.Forms.Label num3;
        private System.Windows.Forms.Label num5;
        private System.Windows.Forms.Label num6;
        private System.Windows.Forms.Label num4;
        private System.Windows.Forms.Label bonus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel center_panel;
        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Panel mid_panel;
        private System.Windows.Forms.Label fixed_comment;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label fixed_label2;
        private System.Windows.Forms.TextBox search_number_box;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.TextBox result_box;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label used_money_label;
        private System.Windows.Forms.Label won_label;
        private System.Windows.Forms.Label money_label;
        private System.Windows.Forms.Label grade_label;
        private System.Windows.Forms.Label grade_number_label;
        private System.Windows.Forms.Label match_label;
        private System.Windows.Forms.Label match_bonus_num_label;
        private System.Windows.Forms.Label match_num_label;
        private System.Windows.Forms.Label label2;
    }
}

