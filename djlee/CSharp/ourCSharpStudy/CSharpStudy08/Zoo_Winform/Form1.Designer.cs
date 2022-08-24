namespace Zoo_Winform
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
            this.button_console = new System.Windows.Forms.Button();
            this.button_MessageBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_console
            // 
            this.button_console.Location = new System.Drawing.Point(13, 22);
            this.button_console.Name = "button_console";
            this.button_console.Size = new System.Drawing.Size(251, 70);
            this.button_console.TabIndex = 0;
            this.button_console.Text = "콘솔창";
            this.button_console.UseVisualStyleBackColor = true;
            this.button_console.Click += new System.EventHandler(this.button_console_Click);
            // 
            // button_MessageBox
            // 
            this.button_MessageBox.Location = new System.Drawing.Point(12, 140);
            this.button_MessageBox.Name = "button_MessageBox";
            this.button_MessageBox.Size = new System.Drawing.Size(251, 70);
            this.button_MessageBox.TabIndex = 1;
            this.button_MessageBox.Text = "메시지 박스창";
            this.button_MessageBox.UseVisualStyleBackColor = true;
            this.button_MessageBox.Click += new System.EventHandler(this.button_MessageBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_MessageBox);
            this.Controls.Add(this.button_console);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_console;
        private System.Windows.Forms.Button button_MessageBox;
    }
}

