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
            ((System.ComponentModel.ISupportInitialize)(this.gundamPicture)).BeginInit();
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
            this.buttonS.Location = new System.Drawing.Point(409, 49);
            this.buttonS.Name = "buttonS";
            this.buttonS.Size = new System.Drawing.Size(246, 57);
            this.buttonS.TabIndex = 1;
            this.buttonS.Text = "가위";
            this.buttonS.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 519);
            this.Controls.Add(this.buttonS);
            this.Controls.Add(this.gundamPicture);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gundamPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox gundamPicture;
        private System.Windows.Forms.Button buttonS;
    }
}

