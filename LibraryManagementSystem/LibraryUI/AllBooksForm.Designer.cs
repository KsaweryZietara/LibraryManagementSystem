
namespace LibraryUI {
    partial class AllBooksForm {
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
            this.keyWordText = new System.Windows.Forms.TextBox();
            this.keyWordLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.showAllBooksButton = new System.Windows.Forms.Button();
            this.borrowButton = new System.Windows.Forms.Button();
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
            this.headerLabel.TabIndex = 3;
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
            this.booksListBox.TabIndex = 4;
            // 
            // keyWordText
            // 
            this.keyWordText.Location = new System.Drawing.Point(469, 82);
            this.keyWordText.Name = "keyWordText";
            this.keyWordText.Size = new System.Drawing.Size(238, 35);
            this.keyWordText.TabIndex = 7;
            // 
            // keyWordLabel
            // 
            this.keyWordLabel.AutoSize = true;
            this.keyWordLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.keyWordLabel.ForeColor = System.Drawing.Color.Green;
            this.keyWordLabel.Location = new System.Drawing.Point(465, 58);
            this.keyWordLabel.Name = "keyWordLabel";
            this.keyWordLabel.Size = new System.Drawing.Size(114, 21);
            this.keyWordLabel.TabIndex = 6;
            this.keyWordLabel.Text = "Enter key word";
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.White;
            this.searchButton.ForeColor = System.Drawing.Color.Green;
            this.searchButton.Location = new System.Drawing.Point(499, 123);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(175, 38);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            // 
            // showAllBooksButton
            // 
            this.showAllBooksButton.BackColor = System.Drawing.Color.White;
            this.showAllBooksButton.ForeColor = System.Drawing.Color.Green;
            this.showAllBooksButton.Location = new System.Drawing.Point(469, 221);
            this.showAllBooksButton.Name = "showAllBooksButton";
            this.showAllBooksButton.Size = new System.Drawing.Size(238, 46);
            this.showAllBooksButton.TabIndex = 9;
            this.showAllBooksButton.Text = "Show all books";
            this.showAllBooksButton.UseVisualStyleBackColor = false;
            // 
            // borrowButton
            // 
            this.borrowButton.BackColor = System.Drawing.Color.White;
            this.borrowButton.ForeColor = System.Drawing.Color.Green;
            this.borrowButton.Location = new System.Drawing.Point(469, 339);
            this.borrowButton.Name = "borrowButton";
            this.borrowButton.Size = new System.Drawing.Size(238, 46);
            this.borrowButton.TabIndex = 10;
            this.borrowButton.Text = "Borrow selected book";
            this.borrowButton.UseVisualStyleBackColor = false;
            // 
            // AllBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(779, 468);
            this.Controls.Add(this.borrowButton);
            this.Controls.Add(this.showAllBooksButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.keyWordText);
            this.Controls.Add(this.keyWordLabel);
            this.Controls.Add(this.booksListBox);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.Green;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "AllBooksForm";
            this.Text = "Borrow new book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.ListBox booksListBox;
        private System.Windows.Forms.TextBox keyWordText;
        private System.Windows.Forms.Label keyWordLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button showAllBooksButton;
        private System.Windows.Forms.Button borrowButton;
    }
}