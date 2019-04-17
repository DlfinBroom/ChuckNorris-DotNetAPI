namespace ChuckNorrisForms
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
            this.btnGetJoke = new System.Windows.Forms.Button();
            this.ddlCategories = new System.Windows.Forms.ComboBox();
            this.tbxJokeText = new System.Windows.Forms.TextBox();
            this.lblCategories = new System.Windows.Forms.Label();
            this.gbxChuckNorris = new System.Windows.Forms.GroupBox();
            this.gbxChuckNorris.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetJoke
            // 
            this.btnGetJoke.Location = new System.Drawing.Point(143, 22);
            this.btnGetJoke.Name = "btnGetJoke";
            this.btnGetJoke.Size = new System.Drawing.Size(173, 37);
            this.btnGetJoke.TabIndex = 0;
            this.btnGetJoke.Text = "Get Random Joke";
            this.btnGetJoke.UseVisualStyleBackColor = true;
            this.btnGetJoke.Click += new System.EventHandler(this.btnGetJoke_Click);
            // 
            // ddlCategories
            // 
            this.ddlCategories.FormattingEnabled = true;
            this.ddlCategories.Location = new System.Drawing.Point(16, 38);
            this.ddlCategories.Name = "ddlCategories";
            this.ddlCategories.Size = new System.Drawing.Size(121, 21);
            this.ddlCategories.TabIndex = 1;
            this.ddlCategories.SelectedIndexChanged += new System.EventHandler(this.ddlCategories_SelectedIndexChanged);
            // 
            // tbxJokeText
            // 
            this.tbxJokeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxJokeText.Location = new System.Drawing.Point(16, 65);
            this.tbxJokeText.Multiline = true;
            this.tbxJokeText.Name = "tbxJokeText";
            this.tbxJokeText.Size = new System.Drawing.Size(300, 150);
            this.tbxJokeText.TabIndex = 2;
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Location = new System.Drawing.Point(13, 22);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(55, 13);
            this.lblCategories.TabIndex = 3;
            this.lblCategories.Text = "Category: ";
            // 
            // gbxChuckNorris
            // 
            this.gbxChuckNorris.Controls.Add(this.tbxJokeText);
            this.gbxChuckNorris.Controls.Add(this.lblCategories);
            this.gbxChuckNorris.Controls.Add(this.btnGetJoke);
            this.gbxChuckNorris.Controls.Add(this.ddlCategories);
            this.gbxChuckNorris.Location = new System.Drawing.Point(12, 12);
            this.gbxChuckNorris.Name = "gbxChuckNorris";
            this.gbxChuckNorris.Size = new System.Drawing.Size(333, 231);
            this.gbxChuckNorris.TabIndex = 4;
            this.gbxChuckNorris.TabStop = false;
            this.gbxChuckNorris.Text = "Chuck Norris Joke Generator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 254);
            this.Controls.Add(this.gbxChuckNorris);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.gbxChuckNorris.ResumeLayout(false);
            this.gbxChuckNorris.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetJoke;
        private System.Windows.Forms.ComboBox ddlCategories;
        private System.Windows.Forms.TextBox tbxJokeText;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.GroupBox gbxChuckNorris;
    }
}

