namespace survey
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.bauPicBox = new System.Windows.Forms.PictureBox();
            this.bauLabel = new System.Windows.Forms.Label();
            this.createSurveyBTN = new System.Windows.Forms.Button();
            this.createMCQBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bauPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // bauPicBox
            // 
            this.bauPicBox.Image = ((System.Drawing.Image)(resources.GetObject("bauPicBox.Image")));
            this.bauPicBox.Location = new System.Drawing.Point(178, 41);
            this.bauPicBox.Name = "bauPicBox";
            this.bauPicBox.Size = new System.Drawing.Size(154, 210);
            this.bauPicBox.TabIndex = 0;
            this.bauPicBox.TabStop = false;
            // 
            // bauLabel
            // 
            this.bauLabel.AutoSize = true;
            this.bauLabel.Font = new System.Drawing.Font("Lucida Fax", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bauLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bauLabel.Location = new System.Drawing.Point(88, 267);
            this.bauLabel.Name = "bauLabel";
            this.bauLabel.Size = new System.Drawing.Size(341, 33);
            this.bauLabel.TabIndex = 1;
            this.bauLabel.Text = "Beirut Arab University";
            // 
            // createSurveyBTN
            // 
            this.createSurveyBTN.Location = new System.Drawing.Point(94, 345);
            this.createSurveyBTN.Name = "createSurveyBTN";
            this.createSurveyBTN.Size = new System.Drawing.Size(140, 29);
            this.createSurveyBTN.TabIndex = 2;
            this.createSurveyBTN.Text = "Create Survey Form";
            this.createSurveyBTN.UseVisualStyleBackColor = true;
            this.createSurveyBTN.Click += new System.EventHandler(this.createSurveyBTN_Click);
            // 
            // createMCQBTN
            // 
            this.createMCQBTN.Location = new System.Drawing.Point(289, 345);
            this.createMCQBTN.Name = "createMCQBTN";
            this.createMCQBTN.Size = new System.Drawing.Size(140, 29);
            this.createMCQBTN.TabIndex = 3;
            this.createMCQBTN.Text = "Create MCQ Exam";
            this.createMCQBTN.UseVisualStyleBackColor = true;
            this.createMCQBTN.Click += new System.EventHandler(this.createMCQBTN_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(505, 412);
            this.Controls.Add(this.createMCQBTN);
            this.Controls.Add(this.createSurveyBTN);
            this.Controls.Add(this.bauLabel);
            this.Controls.Add(this.bauPicBox);
            this.Name = "main";
            this.Text = "main";
            ((System.ComponentModel.ISupportInitialize)(this.bauPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bauPicBox;
        private System.Windows.Forms.Label bauLabel;
        private System.Windows.Forms.Button createSurveyBTN;
        private System.Windows.Forms.Button createMCQBTN;
    }
}