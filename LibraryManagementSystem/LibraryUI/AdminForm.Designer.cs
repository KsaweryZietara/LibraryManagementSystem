
namespace LibraryUI {
    partial class AdminForm {
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.booksListBox = new System.Windows.Forms.ListBox();
            this.deleteBookButton = new System.Windows.Forms.Button();
            this.addNewBookButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.headerLabel.ForeColor = System.Drawing.Color.Green;
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(217, 50);
            this.headerLabel.TabIndex = 4;
            this.headerLabel.Text = "Books:";
            // 
            // booksListBox
            // 
            this.booksListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.booksListBox.FormattingEnabled = true;
            this.booksListBox.ItemHeight = 30;
            this.booksListBox.Location = new System.Drawing.Point(12, 62);
            this.booksListBox.Name = "booksListBox";
            this.booksListBox.Size = new System.Drawing.Size(415, 392);
            this.booksListBox.TabIndex = 5;
            // 
            // deleteBookButton
            // 
            this.deleteBookButton.BackColor = System.Drawing.Color.White;
            this.deleteBookButton.ForeColor = System.Drawing.Color.Green;
            this.deleteBookButton.Location = new System.Drawing.Point(484, 112);
            this.deleteBookButton.Name = "deleteBookButton";
            this.deleteBookButton.Size = new System.Drawing.Size(224, 59);
            this.deleteBookButton.TabIndex = 7;
            this.deleteBookButton.Text = "Delete selected book";
            this.deleteBookButton.UseVisualStyleBackColor = false;
            // 
            // addNewBookButton
            // 
            this.addNewBookButton.BackColor = System.Drawing.Color.White;
            this.addNewBookButton.ForeColor = System.Drawing.Color.Green;
            this.addNewBookButton.Location = new System.Drawing.Point(484, 295);
            this.addNewBookButton.Name = "addNewBookButton";
            this.addNewBookButton.Size = new System.Drawing.Size(224, 59);
            this.addNewBookButton.TabIndex = 8;
            this.addNewBookButton.Text = "Add new book";
            this.addNewBookButton.UseVisualStyleBackColor = false;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(779, 468);
            this.Controls.Add(this.addNewBookButton);
            this.Controls.Add(this.deleteBookButton);
            this.Controls.Add(this.booksListBox);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.Green;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "AdminForm";
            this.Text = "Admin panel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.ListBox booksListBox;
        private System.Windows.Forms.Button deleteBookButton;
        private System.Windows.Forms.Button addNewBookButton;
    }
}