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
            this.BadgeFive = new System.Windows.Forms.PictureBox();
            this.BadgeFour = new System.Windows.Forms.PictureBox();
            this.BadgeThree = new System.Windows.Forms.PictureBox();
            this.BadgeTwo = new System.Windows.Forms.PictureBox();
            this.BadgeOne = new System.Windows.Forms.PictureBox();
            this.UserInfoData = new System.Windows.Forms.DataGridView();
            this.Key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdateImg = new System.Windows.Forms.Button();
            this.githubRepo = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarImg)).BeginInit();
            this.BadgesGrp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BadgeFive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BadgeFour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BadgeThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BadgeTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BadgeOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserInfoData)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchTxt
            // 
            resources.ApplyResources(this.SearchTxt, "SearchTxt");
            this.SearchTxt.Name = "SearchTxt";
            // 
            // SearchBtn
            // 
            resources.ApplyResources(this.SearchBtn, "SearchBtn");
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // AvatarImg
            // 
            resources.ApplyResources(this.AvatarImg, "AvatarImg");
            this.AvatarImg.Name = "AvatarImg";
            this.AvatarImg.TabStop = false;
            // 
            // BadgesGrp
            // 
            this.BadgesGrp.Controls.Add(this.BadgeFive);
            this.BadgesGrp.Controls.Add(this.BadgeFour);
            this.BadgesGrp.Controls.Add(this.BadgeThree);
            this.BadgesGrp.Controls.Add(this.BadgeTwo);
            this.BadgesGrp.Controls.Add(this.BadgeOne);
            resources.ApplyResources(this.BadgesGrp, "BadgesGrp");
            this.BadgesGrp.Name = "BadgesGrp";
            this.BadgesGrp.TabStop = false;
            // 
            // BadgeFive
            // 
            resources.ApplyResources(this.BadgeFive, "BadgeFive");
            this.BadgeFive.Name = "BadgeFive";
            this.BadgeFive.TabStop = false;
            // 
            // BadgeFour
            // 
            resources.ApplyResources(this.BadgeFour, "BadgeFour");
            this.BadgeFour.Name = "BadgeFour";
            this.BadgeFour.TabStop = false;
            // 
            // BadgeThree
            // 
            resources.ApplyResources(this.BadgeThree, "BadgeThree");
            this.BadgeThree.Name = "BadgeThree";
            this.BadgeThree.TabStop = false;
            // 
            // BadgeTwo
            // 
            resources.ApplyResources(this.BadgeTwo, "BadgeTwo");
            this.BadgeTwo.Name = "BadgeTwo";
            this.BadgeTwo.TabStop = false;
            // 
            // BadgeOne
            // 
            resources.ApplyResources(this.BadgeOne, "BadgeOne");
            this.BadgeOne.Name = "BadgeOne";
            this.BadgeOne.TabStop = false;
            // 
            // UserInfoData
            // 
            this.UserInfoData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UserInfoData.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UserInfoData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserInfoData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Key,
            this.Value});
            resources.ApplyResources(this.UserInfoData, "UserInfoData");
            this.UserInfoData.Name = "UserInfoData";
            this.UserInfoData.RowHeadersVisible = false;
            // 
            // Key
            // 
            resources.ApplyResources(this.Key, "Key");
            this.Key.Name = "Key";
            // 
            // Value
            // 
            resources.ApplyResources(this.Value, "Value");
            this.Value.Name = "Value";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // UpdateImg
            // 
            resources.ApplyResources(this.UpdateImg, "UpdateImg");
            this.UpdateImg.Name = "UpdateImg";
            this.UpdateImg.UseVisualStyleBackColor = true;
            this.UpdateImg.Click += new System.EventHandler(this.UpdateImg_Click);
            // 
            // githubRepo
            // 
            resources.ApplyResources(this.githubRepo, "githubRepo");
            this.githubRepo.Name = "githubRepo";
            this.githubRepo.TabStop = true;
            this.githubRepo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.githubRepo_LinkClicked);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.AvatarImg)).EndInit();
            this.BadgesGrp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BadgeFive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BadgeFour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BadgeThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BadgeTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BadgeOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserInfoData)).EndInit();
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

