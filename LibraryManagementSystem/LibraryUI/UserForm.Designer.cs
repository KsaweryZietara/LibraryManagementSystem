
namespace LibraryUI {
    partial class UserForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.booksListBox = new System.Windows.Forms.ListBox();
            this.headerLabel = new System.Windows.Forms.Label();
            this.returnButton = new System.Windows.Forms.Button();
            this.borrowButton = new System.Windows.Forms.Button();
            this.loginLabel = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // booksListBox
            // 
            this.booksListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.booksListBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.booksListBox.FormattingEnabled = true;
            this.booksListBox.ItemHeight = 17;
            this.booksListBox.Location = new System.Drawing.Point(12, 62);
            this.booksListBox.Name = "booksListBox";
            this.booksListBox.Size = new System.Drawing.Size(415, 376);
            this.booksListBox.TabIndex = 0;
            // 
            // headerLabel
            // 
            this.headerLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.headerLabel.ForeColor = System.Drawing.Color.Green;
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(217, 50);
            this.headerLabel.TabIndex = 2;
            this.headerLabel.Text = "Your books";
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.White;
            this.returnButton.ForeColor = System.Drawing.Color.Green;
            this.returnButton.Location = new System.Drawing.Point(464, 62);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(224, 59);
            this.returnButton.TabIndex = 6;
            this.returnButton.Text = "Return selected book";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // borrowButton
            // 
            this.borrowButton.BackColor = System.Drawing.Color.White;
            this.borrowButton.ForeColor = System.Drawing.Color.Green;
            this.borrowButton.Location = new System.Drawing.Point(464, 262);
            this.borrowButton.Name = "borrowButton";
            this.borrowButton.Size = new System.Drawing.Size(224, 59);
            this.borrowButton.TabIndex = 7;
            this.borrowButton.Text = "Borrow new book";
            this.borrowButton.UseVisualStyleBackColor = false;
            this.borrowButton.Click += new System.EventHandler(this.borrowButton_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginLabel.Location = new System.Drawing.Point(715, 9);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(45, 21);
            this.loginLabel.TabIndex = 8;
            this.loginLabel.Text = "login";
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.White;
            this.refreshButton.ForeColor = System.Drawing.Color.Green;
            this.refreshButton.Location = new System.Drawing.Point(464, 159);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(224, 59);
            this.refreshButton.TabIndex = 9;
            this.refreshButton.Text = "Refresh you books";
            this.refreshButton.UseVisualStyleBackColor = false;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(779, 468);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.borrowButton);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.booksListBox);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.Green;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "UserForm";
            this.Text = "User panel";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox booksListBox;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button borrowButton;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Button refreshButton;
    }
}