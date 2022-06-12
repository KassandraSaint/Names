
namespace Names
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.boyBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.girlBox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.infoBoy = new System.Windows.Forms.Label();
            this.infoGirl = new System.Windows.Forms.Label();
            this.errorMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 13.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(749, 46);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter a boy\'s name, a girl\'s name or both:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 36);
            this.label2.TabIndex = 7;
            this.label2.Text = "Boy\'s Name:";
            // 
            // boyBox
            // 
            this.boyBox.Font = new System.Drawing.Font("Microsoft YaHei", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boyBox.Location = new System.Drawing.Point(377, 118);
            this.boyBox.Name = "boyBox";
            this.boyBox.Size = new System.Drawing.Size(315, 43);
            this.boyBox.TabIndex = 0;
            this.boyBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 36);
            this.label3.TabIndex = 8;
            this.label3.Text = "Girl\'s Name:";
            // 
            // girlBox
            // 
            this.girlBox.Font = new System.Drawing.Font("Microsoft YaHei", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.girlBox.Location = new System.Drawing.Point(377, 346);
            this.girlBox.Name = "girlBox";
            this.girlBox.Size = new System.Drawing.Size(315, 43);
            this.girlBox.TabIndex = 1;
            this.girlBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(105, 570);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(265, 85);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Search Name";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitBtn.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(427, 570);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(265, 85);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // infoBoy
            // 
            this.infoBoy.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoBoy.Location = new System.Drawing.Point(107, 190);
            this.infoBoy.Name = "infoBoy";
            this.infoBoy.Size = new System.Drawing.Size(585, 110);
            this.infoBoy.TabIndex = 4;
            this.infoBoy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoGirl
            // 
            this.infoGirl.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoGirl.Location = new System.Drawing.Point(108, 424);
            this.infoGirl.Name = "infoGirl";
            this.infoGirl.Size = new System.Drawing.Size(585, 110);
            this.infoGirl.TabIndex = 5;
            this.infoGirl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorMsg
            // 
            this.errorMsg.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMsg.ForeColor = System.Drawing.Color.Red;
            this.errorMsg.Location = new System.Drawing.Point(108, 682);
            this.errorMsg.Name = "errorMsg";
            this.errorMsg.Size = new System.Drawing.Size(585, 80);
            this.errorMsg.TabIndex = 9;
            this.errorMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AcceptButton = this.searchBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitBtn;
            this.ClientSize = new System.Drawing.Size(800, 786);
            this.Controls.Add(this.errorMsg);
            this.Controls.Add(this.infoGirl);
            this.Controls.Add(this.infoBoy);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.girlBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.boyBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Name Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox boyBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox girlBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label infoBoy;
        private System.Windows.Forms.Label infoGirl;
        private System.Windows.Forms.Label errorMsg;
    }
}

