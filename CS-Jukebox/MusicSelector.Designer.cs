
namespace CS_Jukebox
{
    partial class MusicSelector
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
            this.freezeBtn = new System.Windows.Forms.Button();
            this.freezeBox = new System.Windows.Forms.TextBox();
            this.freezeGroup = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.freezeGroup.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // freezeBtn
            // 
            this.freezeBtn.Location = new System.Drawing.Point(6, 22);
            this.freezeBtn.Name = "freezeBtn";
            this.freezeBtn.Size = new System.Drawing.Size(75, 23);
            this.freezeBtn.TabIndex = 1;
            this.freezeBtn.Text = "Browse";
            this.freezeBtn.UseVisualStyleBackColor = true;
            // 
            // freezeBox
            // 
            this.freezeBox.Location = new System.Drawing.Point(87, 22);
            this.freezeBox.Name = "freezeBox";
            this.freezeBox.Size = new System.Drawing.Size(148, 23);
            this.freezeBox.TabIndex = 2;
            // 
            // freezeGroup
            // 
            this.freezeGroup.Controls.Add(this.freezeBtn);
            this.freezeGroup.Controls.Add(this.freezeBox);
            this.freezeGroup.Location = new System.Drawing.Point(12, 74);
            this.freezeGroup.Name = "freezeGroup";
            this.freezeGroup.Size = new System.Drawing.Size(241, 55);
            this.freezeGroup.TabIndex = 3;
            this.freezeGroup.TabStop = false;
            this.freezeGroup.Text = "Freeze Time:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 55);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 23);
            this.textBox1.TabIndex = 2;
            // 
            // MusicSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 400);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.freezeGroup);
            this.Name = "MusicSelector";
            this.Text = "Music Selector";
            this.freezeGroup.ResumeLayout(false);
            this.freezeGroup.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button freezeBtn;
        private System.Windows.Forms.TextBox freezeBox;
        private System.Windows.Forms.GroupBox freezeGroup;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}