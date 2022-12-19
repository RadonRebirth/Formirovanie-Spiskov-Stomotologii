
namespace Praktika
{
    partial class AdminMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenu));
            this.buttonUsers = new System.Windows.Forms.Button();
            this.buttonUslug = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonUsers
            // 
            this.buttonUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonUsers.Location = new System.Drawing.Point(23, 315);
            this.buttonUsers.Name = "buttonUsers";
            this.buttonUsers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonUsers.Size = new System.Drawing.Size(686, 43);
            this.buttonUsers.TabIndex = 0;
            this.buttonUsers.Text = "Управление зарегистрированными пользователями";
            this.buttonUsers.UseVisualStyleBackColor = true;
            this.buttonUsers.Click += new System.EventHandler(this.buttonUsers_Click);
            // 
            // buttonUslug
            // 
            this.buttonUslug.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonUslug.Location = new System.Drawing.Point(23, 382);
            this.buttonUslug.Name = "buttonUslug";
            this.buttonUslug.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonUslug.Size = new System.Drawing.Size(686, 43);
            this.buttonUslug.TabIndex = 1;
            this.buttonUslug.Text = "Управление услугами";
            this.buttonUslug.UseVisualStyleBackColor = true;
            this.buttonUslug.Click += new System.EventHandler(this.buttonUslug_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.Location = new System.Drawing.Point(230, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Выберите действие";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(245, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 205);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // AdminMenu
            // 
            this.ClientSize = new System.Drawing.Size(731, 571);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonUslug);
            this.Controls.Add(this.buttonUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminMenu";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "Информационное окно";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.Button buttonUsers;
        private System.Windows.Forms.Button buttonUslug;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}