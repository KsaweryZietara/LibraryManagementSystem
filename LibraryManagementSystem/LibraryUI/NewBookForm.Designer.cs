
namespace LibraryUI {
    partial class NewBookForm {
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
            this.createButton = new System.Windows.Forms.Button();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.authorText = new System.Windows.Forms.TextBox();
            this.authorLabel = new System.Windows.Forms.Label();
            this.titleText = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.White;
            this.createButton.ForeColor = System.Drawing.Color.Green;
            this.createButton.Location = new System.Drawing.Point(339, 315);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(91, 38);
            this.createButton.TabIndex = 30;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.categoryLabel.ForeColor = System.Drawing.Color.Green;
            this.categoryLabel.Location = new System.Drawing.Point(268, 233);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(73, 21);
            this.categoryLabel.TabIndex = 22;
            this.categoryLabel.Text = "Category";
            // 
            // authorText
            // 
            this.authorText.Location = new System.Drawing.Point(272, 187);
            this.authorText.Name = "authorText";
            this.authorText.Size = new System.Drawing.Size(238, 35);
            this.authorText.TabIndex = 21;
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.authorLabel.ForeColor = System.Drawing.Color.Green;
            this.authorLabel.Location = new System.Drawing.Point(268, 163);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(58, 21);
            this.authorLabel.TabIndex = 20;
            this.authorLabel.Text = "Author";
            // 
            // titleText
            // 
            this.titleText.Location = new System.Drawing.Point(272, 117);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(238, 35);
            this.titleText.TabIndex = 19;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleLabel.ForeColor = System.Drawing.Color.Green;
            this.titleLabel.Location = new System.Drawing.Point(268, 93);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(39, 21);
            this.titleLabel.TabIndex = 18;
            this.titleLabel.Text = "Title";
            // 
            // headerLabel
            // 
            this.headerLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.headerLabel.ForeColor = System.Drawing.Color.Green;
            this.headerLabel.Location = new System.Drawing.Point(299, 33);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(192, 50);
            this.headerLabel.TabIndex = 17;
            this.headerLabel.Text = "New book";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.BackColor = System.Drawing.Color.White;
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(272, 257);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(238, 38);
            this.categoryComboBox.TabIndex = 31;
            // 
            // NewBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(779, 468);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.authorText);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.Green;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "NewBookForm";
            this.Text = "New book";
            this.Load += new System.EventHandler(this.NewBookForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.TextBox authorText;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.TextBox titleText;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.ComboBox categoryComboBox;
    }
}