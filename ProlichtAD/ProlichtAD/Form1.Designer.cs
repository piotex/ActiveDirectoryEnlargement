namespace ProlichtAD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.FolderPathButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FolderPathTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UserIdTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UserIdButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // FolderPathButton
            // 
            this.FolderPathButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.FolderPathButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FolderPathButton.Location = new System.Drawing.Point(544, 18);
            this.FolderPathButton.Name = "FolderPathButton";
            this.FolderPathButton.Size = new System.Drawing.Size(123, 55);
            this.FolderPathButton.TabIndex = 0;
            this.FolderPathButton.Text = "Get Users";
            this.FolderPathButton.UseVisualStyleBackColor = false;
            this.FolderPathButton.Click += new System.EventHandler(this.FolderPathButton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Get Users with acces to folder from path:";
            // 
            // FolderPathTextBox
            // 
            this.FolderPathTextBox.Location = new System.Drawing.Point(126, 38);
            this.FolderPathTextBox.MaximumSize = new System.Drawing.Size(400, 30);
            this.FolderPathTextBox.MinimumSize = new System.Drawing.Size(400, 30);
            this.FolderPathTextBox.Name = "FolderPathTextBox";
            this.FolderPathTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.FolderPathTextBox.Size = new System.Drawing.Size(400, 20);
            this.FolderPathTextBox.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Wheat;
            this.panel1.Controls.Add(this.FolderPathTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.FolderPathButton);
            this.panel1.Location = new System.Drawing.Point(-6, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 108);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Wheat;
            this.panel2.Controls.Add(this.UserIdTextBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.UserIdButton);
            this.panel2.Location = new System.Drawing.Point(-3, 159);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(683, 108);
            this.panel2.TabIndex = 4;
            // 
            // UserIdTextBox
            // 
            this.UserIdTextBox.Location = new System.Drawing.Point(126, 38);
            this.UserIdTextBox.MaximumSize = new System.Drawing.Size(400, 30);
            this.UserIdTextBox.MinimumSize = new System.Drawing.Size(400, 30);
            this.UserIdTextBox.Name = "UserIdTextBox";
            this.UserIdTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.UserIdTextBox.Size = new System.Drawing.Size(400, 20);
            this.UserIdTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(17, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 55);
            this.label2.TabIndex = 1;
            this.label2.Text = "Get folders to which User has access:";
            // 
            // UserIdButton
            // 
            this.UserIdButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.UserIdButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UserIdButton.Location = new System.Drawing.Point(544, 18);
            this.UserIdButton.Name = "UserIdButton";
            this.UserIdButton.Size = new System.Drawing.Size(123, 55);
            this.UserIdButton.TabIndex = 0;
            this.UserIdButton.Text = "Get Folders";
            this.UserIdButton.UseVisualStyleBackColor = false;
            this.UserIdButton.Click += new System.EventHandler(this.UserIdButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(670, 266);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "   Search";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FolderPathButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FolderPathTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox UserIdTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button UserIdButton;
    }
}

