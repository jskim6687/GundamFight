namespace GundamFight
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
            this.gundamPicture = new System.Windows.Forms.PictureBox();
            this.buttonS = new System.Windows.Forms.Button();
            this.buttonR = new System.Windows.Forms.Button();
            this.buttonP = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.result = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gundamPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gundamPicture
            // 
            this.gundamPicture.Image = ((System.Drawing.Image)(resources.GetObject("gundamPicture.Image")));
            this.gundamPicture.Location = new System.Drawing.Point(13, 13);
            this.gundamPicture.Name = "gundamPicture";
            this.gundamPicture.Size = new System.Drawing.Size(343, 309);
            this.gundamPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gundamPicture.TabIndex = 0;
            this.gundamPicture.TabStop = false;
            // 
            // buttonS
            // 
            this.buttonS.Location = new System.Drawing.Point(376, 13);
            this.buttonS.Name = "buttonS";
            this.buttonS.Size = new System.Drawing.Size(246, 57);
            this.buttonS.TabIndex = 1;
            this.buttonS.Text = "가위";
            this.buttonS.UseVisualStyleBackColor = true;
            this.buttonS.Click += new System.EventHandler(this.buttonS_Click);
            // 
            // buttonR
            // 
            this.buttonR.Location = new System.Drawing.Point(376, 137);
            this.buttonR.Name = "buttonR";
            this.buttonR.Size = new System.Drawing.Size(246, 57);
            this.buttonR.TabIndex = 2;
            this.buttonR.Text = "바위";
            this.buttonR.UseVisualStyleBackColor = true;
            this.buttonR.Click += new System.EventHandler(this.buttonR_Click);
            // 
            // buttonP
            // 
            this.buttonP.Location = new System.Drawing.Point(376, 265);
            this.buttonP.Name = "buttonP";
            this.buttonP.Size = new System.Drawing.Size(246, 57);
            this.buttonP.TabIndex = 3;
            this.buttonP.Text = "보";
            this.buttonP.UseVisualStyleBackColor = true;
            this.buttonP.Click += new System.EventHandler(this.buttonP_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(647, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 309);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("굴림", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.result.Location = new System.Drawing.Point(392, 371);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(212, 48);
            this.result.TabIndex = 5;
            this.result.Text = "경기결과";
            this.result.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 519);
            this.Controls.Add(this.result);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonP);
            this.Controls.Add(this.buttonR);
            this.Controls.Add(this.buttonS);
            this.Controls.Add(this.gundamPicture);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gundamPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox gundamPicture;
        private System.Windows.Forms.Button buttonS;
        private System.Windows.Forms.Button buttonR;
        private System.Windows.Forms.Button buttonP;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label result;
    }
}

