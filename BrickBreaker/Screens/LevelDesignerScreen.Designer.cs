﻿namespace BrickBreaker.Screens
{
    partial class LevelDesignerScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.powerUpLabel = new System.Windows.Forms.Label();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.replaceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // powerUpLabel
            // 
            this.powerUpLabel.AutoSize = true;
            this.powerUpLabel.Location = new System.Drawing.Point(578, 757);
            this.powerUpLabel.Name = "powerUpLabel";
            this.powerUpLabel.Size = new System.Drawing.Size(47, 20);
            this.powerUpLabel.TabIndex = 0;
            this.powerUpLabel.Text = "None";
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.BackColor = System.Drawing.Color.Transparent;
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.ForeColor = System.Drawing.Color.White;
            this.instructionLabel.Location = new System.Drawing.Point(16, 22);
            this.instructionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(192, 37);
            this.instructionLabel.TabIndex = 1;
            this.instructionLabel.Text = "instructions";
            this.instructionLabel.Visible = false;
            // 
            // replaceLabel
            // 
            this.replaceLabel.AutoSize = true;
            this.replaceLabel.Location = new System.Drawing.Point(872, 72);
            this.replaceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.replaceLabel.Name = "replaceLabel";
            this.replaceLabel.Size = new System.Drawing.Size(99, 20);
            this.replaceLabel.TabIndex = 1;
            this.replaceLabel.Text = "replace:false";
            // 
            // LevelDesignerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.replaceLabel);
            this.Controls.Add(this.powerUpLabel);
            this.Name = "LevelDesignerScreen";
            this.Size = new System.Drawing.Size(1280, 812);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.LevelDesignerScreen_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.LevelDesignerScreen_KeyUp);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LevelDesignerScreen_MouseClick);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.LevelDesignerScreen_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label powerUpLabel;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label replaceLabel;
    }
}
