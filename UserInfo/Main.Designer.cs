namespace UserInfo
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.SearchTxt = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.AvatarImg = new System.Windows.Forms.PictureBox();
            this.BadgesGrp = new System.Windows.Forms.GroupBox();
            this.UserInfoData = new System.Windows.Forms.DataGridView();
            this.Key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BadgeOne = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BadgeTwo = new System.Windows.Forms.PictureBox();
            this.BadgeThree = new System.Windows.Forms.PictureBox();
            this.BadgeFour = new System.Windows.Forms.PictureBox();
            this.BadgeFive = new System.Windows.Forms.PictureBox();
            this.UpdateImg = new System.Windows.Forms.Button();
            this.githubRepo = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarImg)).BeginInit();
            this.BadgesGrp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserInfoData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BadgeOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BadgeTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BadgeThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BadgeFour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BadgeFive)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchTxt
            // 
            this.SearchTxt.Location = new System.Drawing.Point(112, 12);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.Size = new System.Drawing.Size(204, 20);
            this.SearchTxt.TabIndex = 0;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(322, 12);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(99, 23);
            this.SearchBtn.TabIndex = 1;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // AvatarImg
            // 
            this.AvatarImg.ErrorImage = ((System.Drawing.Image)(resources.GetObject("AvatarImg.ErrorImage")));
            this.AvatarImg.Image = ((System.Drawing.Image)(resources.GetObject("AvatarImg.Image")));
            this.AvatarImg.InitialImage = ((System.Drawing.Image)(resources.GetObject("AvatarImg.InitialImage")));
            this.AvatarImg.Location = new System.Drawing.Point(12, 38);
            this.AvatarImg.Name = "AvatarImg";
            this.AvatarImg.Size = new System.Drawing.Size(80, 121);
            this.AvatarImg.TabIndex = 2;
            this.AvatarImg.TabStop = false;
            // 
            // BadgesGrp
            // 
            this.BadgesGrp.Controls.Add(this.BadgeFive);
            this.BadgesGrp.Controls.Add(this.BadgeFour);
            this.BadgesGrp.Controls.Add(this.BadgeThree);
            this.BadgesGrp.Controls.Add(this.BadgeTwo);
            this.BadgesGrp.Controls.Add(this.BadgeOne);
            this.BadgesGrp.Location = new System.Drawing.Point(13, 214);
            this.BadgesGrp.Name = "BadgesGrp";
            this.BadgesGrp.Size = new System.Drawing.Size(408, 87);
            this.BadgesGrp.TabIndex = 3;
            this.BadgesGrp.TabStop = false;
            this.BadgesGrp.Text = "Badges";
            // 
            // UserInfoData
            // 
            this.UserInfoData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UserInfoData.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UserInfoData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserInfoData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Key,
            this.Value});
            this.UserInfoData.Location = new System.Drawing.Point(112, 38);
            this.UserInfoData.Name = "UserInfoData";
            this.UserInfoData.RowHeadersVisible = false;
            this.UserInfoData.Size = new System.Drawing.Size(309, 169);
            this.UserInfoData.TabIndex = 4;
            // 
            // Key
            // 
            this.Key.HeaderText = "Key";
            this.Key.Name = "Key";
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            // 
            // BadgeOne
            // 
            this.BadgeOne.Location = new System.Drawing.Point(6, 19);
            this.BadgeOne.Name = "BadgeOne";
            this.BadgeOne.Size = new System.Drawing.Size(73, 62);
            this.BadgeOne.TabIndex = 0;
            this.BadgeOne.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Habbo Username: ";
            // 
            // BadgeTwo
            // 
            this.BadgeTwo.Location = new System.Drawing.Point(85, 19);
            this.BadgeTwo.Name = "BadgeTwo";
            this.BadgeTwo.Size = new System.Drawing.Size(73, 62);
            this.BadgeTwo.TabIndex = 0;
            this.BadgeTwo.TabStop = false;
            // 
            // BadgeThree
            // 
            this.BadgeThree.Location = new System.Drawing.Point(164, 19);
            this.BadgeThree.Name = "BadgeThree";
            this.BadgeThree.Size = new System.Drawing.Size(73, 62);
            this.BadgeThree.TabIndex = 0;
            this.BadgeThree.TabStop = false;
            // 
            // BadgeFour
            // 
            this.BadgeFour.Location = new System.Drawing.Point(243, 19);
            this.BadgeFour.Name = "BadgeFour";
            this.BadgeFour.Size = new System.Drawing.Size(73, 62);
            this.BadgeFour.TabIndex = 0;
            this.BadgeFour.TabStop = false;
            // 
            // BadgeFive
            // 
            this.BadgeFive.Location = new System.Drawing.Point(322, 19);
            this.BadgeFive.Name = "BadgeFive";
            this.BadgeFive.Size = new System.Drawing.Size(73, 62);
            this.BadgeFive.TabIndex = 0;
            this.BadgeFive.TabStop = false;
            // 
            // UpdateImg
            // 
            this.UpdateImg.Location = new System.Drawing.Point(12, 165);
            this.UpdateImg.Name = "UpdateImg";
            this.UpdateImg.Size = new System.Drawing.Size(80, 41);
            this.UpdateImg.TabIndex = 6;
            this.UpdateImg.Text = "Update";
            this.UpdateImg.UseVisualStyleBackColor = true;
            this.UpdateImg.Click += new System.EventHandler(this.UpdateImg_Click);
            // 
            // githubRepo
            // 
            this.githubRepo.AutoSize = true;
            this.githubRepo.Location = new System.Drawing.Point(288, 317);
            this.githubRepo.Name = "githubRepo";
            this.githubRepo.Size = new System.Drawing.Size(28, 13);
            this.githubRepo.TabIndex = 8;
            this.githubRepo.TabStop = true;
            this.githubRepo.Text = "here";
            this.githubRepo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.githubRepo_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "UserInfo is open source, the source code can be found ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "A JustDevInc Project";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 342);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.githubRepo);
            this.Controls.Add(this.UpdateImg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserInfoData);
            this.Controls.Add(this.BadgesGrp);
            this.Controls.Add(this.AvatarImg);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.SearchTxt);
            this.Name = "Main";
            this.Text = "User Info - JustDevInc";
            ((System.ComponentModel.ISupportInitialize)(this.AvatarImg)).EndInit();
            this.BadgesGrp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserInfoData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BadgeOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BadgeTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BadgeThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BadgeFour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BadgeFive)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchTxt;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.PictureBox AvatarImg;
        private System.Windows.Forms.GroupBox BadgesGrp;
        private System.Windows.Forms.DataGridView UserInfoData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Key;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.PictureBox BadgeOne;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox BadgeFive;
        private System.Windows.Forms.PictureBox BadgeFour;
        private System.Windows.Forms.PictureBox BadgeThree;
        private System.Windows.Forms.PictureBox BadgeTwo;
        private System.Windows.Forms.Button UpdateImg;
        private System.Windows.Forms.LinkLabel githubRepo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

