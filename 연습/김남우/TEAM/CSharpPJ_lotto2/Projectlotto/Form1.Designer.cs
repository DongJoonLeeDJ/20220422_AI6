namespace Projectlotto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.Record = new System.Windows.Forms.Button();
            this.Game = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Button();
            this.mainimg = new System.Windows.Forms.PictureBox();
            this.userControl_Record1 = new CSharpPJ_lotto.UserControl_Record();
            this.game1 = new Projectlotto.game();
            this.userControl_Home1 = new CSharpPJ_lotto.UserControl_Home();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainimg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.panelLeft);
            this.panel1.Controls.Add(this.Record);
            this.panel1.Controls.Add(this.Game);
            this.panel1.Controls.Add(this.Home);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 608);
            this.panel1.TabIndex = 0;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panelLeft.Location = new System.Drawing.Point(167, 165);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(11, 118);
            this.panelLeft.TabIndex = 2;
            // 
            // Record
            // 
            this.Record.BackColor = System.Drawing.SystemColors.Control;
            this.Record.FlatAppearance.BorderSize = 0;
            this.Record.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Record.Font = new System.Drawing.Font("1훈시나몬베이글 R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Record.Image = ((System.Drawing.Image)(resources.GetObject("Record.Image")));
            this.Record.Location = new System.Drawing.Point(0, 449);
            this.Record.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Record.Name = "Record";
            this.Record.Size = new System.Drawing.Size(178, 118);
            this.Record.TabIndex = 1;
            this.Record.Text = "Record";
            this.Record.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Record.UseVisualStyleBackColor = false;
            this.Record.Click += new System.EventHandler(this.Record_Click);
            // 
            // Game
            // 
            this.Game.BackColor = System.Drawing.SystemColors.Control;
            this.Game.FlatAppearance.BorderSize = 0;
            this.Game.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Game.Font = new System.Drawing.Font("1훈시나몬베이글 R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Game.Image = ((System.Drawing.Image)(resources.GetObject("Game.Image")));
            this.Game.Location = new System.Drawing.Point(-1, 311);
            this.Game.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Game.Name = "Game";
            this.Game.Size = new System.Drawing.Size(178, 118);
            this.Game.TabIndex = 1;
            this.Game.Text = "Game";
            this.Game.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Game.UseVisualStyleBackColor = false;
            this.Game.Click += new System.EventHandler(this.Game_Click);
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.SystemColors.Control;
            this.Home.FlatAppearance.BorderSize = 0;
            this.Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home.Font = new System.Drawing.Font("1훈시나몬베이글 R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Home.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Home.Image = ((System.Drawing.Image)(resources.GetObject("Home.Image")));
            this.Home.Location = new System.Drawing.Point(0, 165);
            this.Home.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(178, 118);
            this.Home.TabIndex = 1;
            this.Home.Text = "Home";
            this.Home.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.userControl_Record1);
            this.panel2.Controls.Add(this.game1);
            this.panel2.Controls.Add(this.userControl_Home1);
            this.panel2.Location = new System.Drawing.Point(183, 162);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(764, 433);
            this.panel2.TabIndex = 3;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.Location = new System.Drawing.Point(904, 13);
            this.Exit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(43, 36);
            this.Exit.TabIndex = 2;
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // mainimg
            // 
            this.mainimg.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mainimg.Image = ((System.Drawing.Image)(resources.GetObject("mainimg.Image")));
            this.mainimg.Location = new System.Drawing.Point(-1, 0);
            this.mainimg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainimg.Name = "mainimg";
            this.mainimg.Size = new System.Drawing.Size(961, 154);
            this.mainimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainimg.TabIndex = 1;
            this.mainimg.TabStop = false;
            this.mainimg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.mainimg.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // userControl_Record1
            // 
            this.userControl_Record1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_Record1.Location = new System.Drawing.Point(0, 0);
            this.userControl_Record1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userControl_Record1.Name = "userControl_Record1";
            this.userControl_Record1.Size = new System.Drawing.Size(764, 433);
            this.userControl_Record1.TabIndex = 3;
            // 
            // game1
            // 
            this.game1.Location = new System.Drawing.Point(0, -26);
            this.game1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.game1.Name = "game1";
            this.game1.Size = new System.Drawing.Size(764, 459);
            this.game1.TabIndex = 1;
            // 
            // userControl_Home1
            // 
            this.userControl_Home1.Location = new System.Drawing.Point(6, -12);
            this.userControl_Home1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.userControl_Home1.Name = "userControl_Home1";
            this.userControl_Home1.Size = new System.Drawing.Size(751, 445);
            this.userControl_Home1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(959, 608);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.mainimg);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainimg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Record;
        private System.Windows.Forms.Button Game;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.PictureBox mainimg;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Panel panel2;
        private CSharpPJ_lotto.UserControl_Home userControl_Home1;
        private game game1;
        private CSharpPJ_lotto.UserControl_Record userControl_Record1;
        private System.Windows.Forms.Panel panelLeft;
    }
}

