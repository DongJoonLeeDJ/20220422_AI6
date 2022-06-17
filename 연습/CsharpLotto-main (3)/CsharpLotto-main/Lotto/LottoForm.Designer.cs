namespace Lotto
{
    partial class LottoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LottoForm));
            this.lotto_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.center_panel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.result_box = new Lotto.RoundLabel();
            this.search_button = new System.Windows.Forms.Button();
            this.fixed_label2 = new System.Windows.Forms.Label();
            this.search_number_box = new System.Windows.Forms.TextBox();
            this.mid_panel = new System.Windows.Forms.Panel();
            this.num3 = new Lotto.RoundLabel();
            this.num5 = new Lotto.RoundLabel();
            this.bonus = new Lotto.RoundLabel();
            this.num6 = new Lotto.RoundLabel();
            this.num4 = new Lotto.RoundLabel();
            this.num2 = new Lotto.RoundLabel();
            this.num1 = new Lotto.RoundLabel();
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
            this.head_label = new System.Windows.Forms.Label();
            this.close_button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.move_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.center_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.mid_panel.SuspendLayout();
            this.top_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lotto_button
            // 
            this.lotto_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(168)))), ((int)(((byte)(0)))));
            this.lotto_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lotto_button.BackgroundImage")));
            this.lotto_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.lotto_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lotto_button.Location = new System.Drawing.Point(3, 3);
            this.lotto_button.Name = "lotto_button";
            this.lotto_button.Size = new System.Drawing.Size(44, 44);
            this.lotto_button.TabIndex = 0;
            this.lotto_button.UseVisualStyleBackColor = false;
            this.lotto_button.Click += new System.EventHandler(this.lotto_button_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
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
            this.center_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.center_panel.Controls.Add(this.panel1);
            this.center_panel.Controls.Add(this.mid_panel);
            this.center_panel.Controls.Add(this.top_panel);
            this.center_panel.Location = new System.Drawing.Point(12, 12);
            this.center_panel.Name = "center_panel";
            this.center_panel.Size = new System.Drawing.Size(662, 406);
            this.center_panel.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.result_box);
            this.panel1.Controls.Add(this.search_button);
            this.panel1.Controls.Add(this.fixed_label2);
            this.panel1.Controls.Add(this.search_number_box);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 334);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 72);
            this.panel1.TabIndex = 3;
            // 
            // result_box
            // 
            this.result_box.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold);
            this.result_box.Location = new System.Drawing.Point(252, 6);
            this.result_box.Name = "result_box";
            this.result_box.Size = new System.Drawing.Size(406, 57);
            this.result_box.TabIndex = 19;
            this.result_box.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.result_box.Click += new System.EventHandler(this.result_box_Click);
            // 
            // search_button
            // 
            this.search_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(129)))));
            this.search_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("search_button.BackgroundImage")));
            this.search_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.search_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_button.Location = new System.Drawing.Point(196, 9);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(50, 50);
            this.search_button.TabIndex = 1;
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
            this.fixed_label2.Click += new System.EventHandler(this.fixed_label2_Click);
            // 
            // search_number_box
            // 
            this.search_number_box.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.search_number_box.Location = new System.Drawing.Point(3, 6);
            this.search_number_box.Name = "search_number_box";
            this.search_number_box.Size = new System.Drawing.Size(125, 57);
            this.search_number_box.TabIndex = 0;
            this.search_number_box.TextChanged += new System.EventHandler(this.search_number_box_TextChanged);
            this.search_number_box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.search_number_box_KeyDown);
            this.search_number_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.search_number_box_KeyPress);
            // 
            // mid_panel
            // 
            this.mid_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.mid_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mid_panel.Controls.Add(this.num3);
            this.mid_panel.Controls.Add(this.num5);
            this.mid_panel.Controls.Add(this.bonus);
            this.mid_panel.Controls.Add(this.num6);
            this.mid_panel.Controls.Add(this.num4);
            this.mid_panel.Controls.Add(this.num2);
            this.mid_panel.Controls.Add(this.num1);
            this.mid_panel.Controls.Add(this.won_label);
            this.mid_panel.Controls.Add(this.match_num_label);
            this.mid_panel.Controls.Add(this.label2);
            this.mid_panel.Controls.Add(this.match_bonus_num_label);
            this.mid_panel.Controls.Add(this.match_label);
            this.mid_panel.Controls.Add(this.grade_number_label);
            this.mid_panel.Controls.Add(this.grade_label);
            this.mid_panel.Controls.Add(this.money_label);
            this.mid_panel.Controls.Add(this.used_money_label);
            this.mid_panel.Controls.Add(this.fixed_comment);
            this.mid_panel.Controls.Add(this.label1);
            this.mid_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mid_panel.Location = new System.Drawing.Point(0, 50);
            this.mid_panel.Name = "mid_panel";
            this.mid_panel.Size = new System.Drawing.Size(662, 284);
            this.mid_panel.TabIndex = 2;
            this.mid_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.mid_panel_Paint);
            // 
            // num3
            // 
            this.num3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.num3.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold);
            this.num3.Location = new System.Drawing.Point(179, 53);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(65, 65);
            this.num3.TabIndex = 18;
            this.num3.Text = "00";
            this.num3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.num3.Click += new System.EventHandler(this.num3_Click);
            // 
            // num5
            // 
            this.num5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.num5.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold);
            this.num5.Location = new System.Drawing.Point(349, 53);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(65, 65);
            this.num5.TabIndex = 17;
            this.num5.Text = "00";
            this.num5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bonus
            // 
            this.bonus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.bonus.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold);
            this.bonus.Location = new System.Drawing.Point(588, 53);
            this.bonus.Name = "bonus";
            this.bonus.Size = new System.Drawing.Size(65, 65);
            this.bonus.TabIndex = 16;
            this.bonus.Text = "00";
            this.bonus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num6
            // 
            this.num6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.num6.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold);
            this.num6.Location = new System.Drawing.Point(434, 53);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(65, 65);
            this.num6.TabIndex = 15;
            this.num6.Text = "00";
            this.num6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num4
            // 
            this.num4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.num4.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold);
            this.num4.Location = new System.Drawing.Point(264, 53);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(65, 65);
            this.num4.TabIndex = 14;
            this.num4.Text = "00";
            this.num4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num2
            // 
            this.num2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.num2.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold);
            this.num2.Location = new System.Drawing.Point(94, 53);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(65, 65);
            this.num2.TabIndex = 13;
            this.num2.Text = "00";
            this.num2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.num2.Click += new System.EventHandler(this.num2_Click);
            // 
            // num1
            // 
            this.num1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.num1.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold);
            this.num1.Location = new System.Drawing.Point(9, 53);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(65, 65);
            this.num1.TabIndex = 12;
            this.num1.Text = "00";
            this.num1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // won_label
            // 
            this.won_label.AutoSize = true;
            this.won_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.won_label.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.won_label.Location = new System.Drawing.Point(608, 125);
            this.won_label.Name = "won_label";
            this.won_label.Size = new System.Drawing.Size(50, 50);
            this.won_label.TabIndex = 4;
            this.won_label.Text = "\\";
            // 
            // match_num_label
            // 
            this.match_num_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.match_num_label.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.match_num_label.Location = new System.Drawing.Point(381, 229);
            this.match_num_label.Name = "match_num_label";
            this.match_num_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.match_num_label.Size = new System.Drawing.Size(125, 50);
            this.match_num_label.TabIndex = 11;
            this.match_num_label.Text = "null개";
            this.match_num_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(503, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 50);
            this.label2.TabIndex = 10;
            this.label2.Text = "+";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // match_bonus_num_label
            // 
            this.match_bonus_num_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.match_bonus_num_label.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.match_bonus_num_label.Location = new System.Drawing.Point(537, 229);
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
            this.match_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.match_label.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.match_label.Location = new System.Drawing.Point(4, 229);
            this.match_label.Name = "match_label";
            this.match_label.Size = new System.Drawing.Size(306, 50);
            this.match_label.TabIndex = 8;
            this.match_label.Text = "맞춘 번호 개수 : ";
            // 
            // grade_number_label
            // 
            this.grade_number_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.grade_number_label.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.grade_number_label.Location = new System.Drawing.Point(538, 176);
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
            this.grade_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.grade_label.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.grade_label.Location = new System.Drawing.Point(3, 176);
            this.grade_label.Name = "grade_label";
            this.grade_label.Size = new System.Drawing.Size(256, 50);
            this.grade_label.TabIndex = 6;
            this.grade_label.Text = "당신의 등수 : ";
            // 
            // money_label
            // 
            this.money_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.money_label.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.money_label.Location = new System.Drawing.Point(261, 125);
            this.money_label.Name = "money_label";
            this.money_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.money_label.Size = new System.Drawing.Size(358, 50);
            this.money_label.TabIndex = 5;
            this.money_label.Text = "0";
            this.money_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // used_money_label
            // 
            this.used_money_label.AutoSize = true;
            this.used_money_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.used_money_label.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.used_money_label.Location = new System.Drawing.Point(3, 125);
            this.used_money_label.Name = "used_money_label";
            this.used_money_label.Size = new System.Drawing.Size(269, 50);
            this.used_money_label.TabIndex = 3;
            this.used_money_label.Text = "당신이 쓴 돈 : ";
            // 
            // fixed_comment
            // 
            this.fixed_comment.AutoSize = true;
            this.fixed_comment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.fixed_comment.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.fixed_comment.Location = new System.Drawing.Point(3, 1);
            this.fixed_comment.Name = "fixed_comment";
            this.fixed_comment.Size = new System.Drawing.Size(307, 50);
            this.fixed_comment.TabIndex = 0;
            this.fixed_comment.Text = "당신이 뽑은 번호";
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.Color.Black;
            this.top_panel.Controls.Add(this.head_label);
            this.top_panel.Controls.Add(this.close_button);
            this.top_panel.Controls.Add(this.lotto_button);
            this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(662, 50);
            this.top_panel.TabIndex = 1;
            // 
            // head_label
            // 
            this.head_label.AutoSize = true;
            this.head_label.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.head_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.head_label.Location = new System.Drawing.Point(229, 0);
            this.head_label.Name = "head_label";
            this.head_label.Size = new System.Drawing.Size(207, 50);
            this.head_label.TabIndex = 19;
            this.head_label.Text = "자동추첨기";
            // 
            // close_button
            // 
            this.close_button.BackColor = System.Drawing.Color.Brown;
            this.close_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close_button.BackgroundImage")));
            this.close_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.close_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_button.Location = new System.Drawing.Point(614, 3);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(44, 44);
            this.close_button.TabIndex = 1;
            this.close_button.UseVisualStyleBackColor = false;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(300, -91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 100);
            this.panel2.TabIndex = 4;
            // 
            // move_panel
            // 
            this.move_panel.BackColor = System.Drawing.Color.Transparent;
            this.move_panel.Location = new System.Drawing.Point(1, 1);
            this.move_panel.Name = "move_panel";
            this.move_panel.Size = new System.Drawing.Size(684, 12);
            this.move_panel.TabIndex = 0;
            this.move_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.move_panel_MouseDown);
            this.move_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.move_panel_MouseMove);
            this.move_panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.move_panel_MouseUp);
            // 
            // LottoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CancelButton = this.close_button;
            this.ClientSize = new System.Drawing.Size(687, 430);
            this.Controls.Add(this.move_panel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.center_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "LottoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Lotto";
            this.center_panel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mid_panel.ResumeLayout(false);
            this.mid_panel.PerformLayout();
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button lotto_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel center_panel;
        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Panel mid_panel;
        private System.Windows.Forms.Label fixed_comment;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label fixed_label2;
        private System.Windows.Forms.TextBox search_number_box;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Label used_money_label;
        private System.Windows.Forms.Label won_label;
        private System.Windows.Forms.Label money_label;
        private System.Windows.Forms.Label grade_label;
        private System.Windows.Forms.Label grade_number_label;
        private System.Windows.Forms.Label match_label;
        private System.Windows.Forms.Label match_bonus_num_label;
        private System.Windows.Forms.Label match_num_label;
        private System.Windows.Forms.Label label2;
        private RoundLabel num1;
        private RoundLabel num3;
        private RoundLabel num5;
        private RoundLabel bonus;
        private RoundLabel num6;
        private RoundLabel num4;
        private RoundLabel num2;
        private RoundLabel result_box;
        private System.Windows.Forms.Label head_label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel move_panel;
    }
}

