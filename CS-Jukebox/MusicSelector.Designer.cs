
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
            this.freezeButton = new System.Windows.Forms.Button();
            this.freezeTextBox = new System.Windows.Forms.TextBox();
            this.freezeGroup = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.freezeStartTextBox = new System.Windows.Forms.TextBox();
            this.freezeTrackBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.startGroup = new System.Windows.Forms.GroupBox();
            this.startTrackBar = new System.Windows.Forms.TrackBar();
            this.startButton = new System.Windows.Forms.Button();
            this.startTextBox = new System.Windows.Forms.TextBox();
            this.MVPGroup = new System.Windows.Forms.GroupBox();
            this.MVPTrackBar = new System.Windows.Forms.TrackBar();
            this.MVPButton = new System.Windows.Forms.Button();
            this.MVPTextBox = new System.Windows.Forms.TextBox();
            this.lostGroup = new System.Windows.Forms.GroupBox();
            this.lostTrackBar = new System.Windows.Forms.TrackBar();
            this.lostButton = new System.Windows.Forms.Button();
            this.lostTextBox = new System.Windows.Forms.TextBox();
            this.wonGroup = new System.Windows.Forms.GroupBox();
            this.wonTrackBar = new System.Windows.Forms.TrackBar();
            this.wonButton = new System.Windows.Forms.Button();
            this.wonTextBox = new System.Windows.Forms.TextBox();
            this.bombGroup = new System.Windows.Forms.GroupBox();
            this.bombTrackBar = new System.Windows.Forms.TrackBar();
            this.bombButton = new System.Windows.Forms.Button();
            this.bombTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.freezeGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.freezeTrackBar)).BeginInit();
            this.startGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startTrackBar)).BeginInit();
            this.MVPGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MVPTrackBar)).BeginInit();
            this.lostGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lostTrackBar)).BeginInit();
            this.wonGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wonTrackBar)).BeginInit();
            this.bombGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bombTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // freezeButton
            // 
            this.freezeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.freezeButton.Location = new System.Drawing.Point(6, 77);
            this.freezeButton.Name = "freezeButton";
            this.freezeButton.Size = new System.Drawing.Size(75, 23);
            this.freezeButton.TabIndex = 1;
            this.freezeButton.Text = "Browse";
            this.freezeButton.UseVisualStyleBackColor = true;
            this.freezeButton.Click += new System.EventHandler(this.freezeButton_Click);
            // 
            // freezeTextBox
            // 
            this.freezeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.freezeTextBox.Location = new System.Drawing.Point(98, 77);
            this.freezeTextBox.Name = "freezeTextBox";
            this.freezeTextBox.Size = new System.Drawing.Size(131, 23);
            this.freezeTextBox.TabIndex = 2;
            this.freezeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // freezeGroup
            // 
            this.freezeGroup.Controls.Add(this.label1);
            this.freezeGroup.Controls.Add(this.freezeStartTextBox);
            this.freezeGroup.Controls.Add(this.freezeTrackBar);
            this.freezeGroup.Controls.Add(this.freezeButton);
            this.freezeGroup.Controls.Add(this.freezeTextBox);
            this.freezeGroup.Location = new System.Drawing.Point(12, 50);
            this.freezeGroup.Name = "freezeGroup";
            this.freezeGroup.Size = new System.Drawing.Size(235, 106);
            this.freezeGroup.TabIndex = 3;
            this.freezeGroup.TabStop = false;
            this.freezeGroup.Text = "Freeze Time:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Start At:";
            // 
            // freezeStartTextBox
            // 
            this.freezeStartTextBox.Location = new System.Drawing.Point(61, 16);
            this.freezeStartTextBox.Name = "freezeStartTextBox";
            this.freezeStartTextBox.PlaceholderText = "Seconds";
            this.freezeStartTextBox.Size = new System.Drawing.Size(55, 23);
            this.freezeStartTextBox.TabIndex = 5;
            this.freezeStartTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // freezeTrackBar
            // 
            this.freezeTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.freezeTrackBar.AutoSize = false;
            this.freezeTrackBar.LargeChange = 10;
            this.freezeTrackBar.Location = new System.Drawing.Point(6, 47);
            this.freezeTrackBar.Maximum = 100;
            this.freezeTrackBar.Name = "freezeTrackBar";
            this.freezeTrackBar.Size = new System.Drawing.Size(217, 24);
            this.freezeTrackBar.SmallChange = 5;
            this.freezeTrackBar.TabIndex = 3;
            this.freezeTrackBar.Tag = "";
            this.freezeTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.freezeTrackBar.Value = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(60, 6);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(121, 23);
            this.nameTextBox.TabIndex = 8;
            // 
            // startGroup
            // 
            this.startGroup.Controls.Add(this.startTrackBar);
            this.startGroup.Controls.Add(this.startButton);
            this.startGroup.Controls.Add(this.startTextBox);
            this.startGroup.Location = new System.Drawing.Point(18, 197);
            this.startGroup.Name = "startGroup";
            this.startGroup.Size = new System.Drawing.Size(235, 78);
            this.startGroup.TabIndex = 9;
            this.startGroup.TabStop = false;
            this.startGroup.Text = "Round Start:";
            // 
            // startTrackBar
            // 
            this.startTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startTrackBar.AutoSize = false;
            this.startTrackBar.LargeChange = 10;
            this.startTrackBar.Location = new System.Drawing.Point(6, 22);
            this.startTrackBar.Maximum = 100;
            this.startTrackBar.Name = "startTrackBar";
            this.startTrackBar.Size = new System.Drawing.Size(223, 24);
            this.startTrackBar.SmallChange = 5;
            this.startTrackBar.TabIndex = 3;
            this.startTrackBar.Tag = "";
            this.startTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.startTrackBar.Value = 100;
            // 
            // startButton
            // 
            this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.startButton.Location = new System.Drawing.Point(6, 49);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Browse";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // startTextBox
            // 
            this.startTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.startTextBox.Location = new System.Drawing.Point(98, 49);
            this.startTextBox.Name = "startTextBox";
            this.startTextBox.Size = new System.Drawing.Size(131, 23);
            this.startTextBox.TabIndex = 2;
            // 
            // MVPGroup
            // 
            this.MVPGroup.Controls.Add(this.MVPTrackBar);
            this.MVPGroup.Controls.Add(this.MVPButton);
            this.MVPGroup.Controls.Add(this.MVPTextBox);
            this.MVPGroup.Location = new System.Drawing.Point(253, 206);
            this.MVPGroup.Name = "MVPGroup";
            this.MVPGroup.Size = new System.Drawing.Size(235, 75);
            this.MVPGroup.TabIndex = 13;
            this.MVPGroup.TabStop = false;
            this.MVPGroup.Text = "MVP:";
            // 
            // MVPTrackBar
            // 
            this.MVPTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MVPTrackBar.AutoSize = false;
            this.MVPTrackBar.LargeChange = 10;
            this.MVPTrackBar.Location = new System.Drawing.Point(6, 22);
            this.MVPTrackBar.Maximum = 100;
            this.MVPTrackBar.Name = "MVPTrackBar";
            this.MVPTrackBar.Size = new System.Drawing.Size(223, 24);
            this.MVPTrackBar.SmallChange = 5;
            this.MVPTrackBar.TabIndex = 3;
            this.MVPTrackBar.Tag = "";
            this.MVPTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.MVPTrackBar.Value = 100;
            // 
            // MVPButton
            // 
            this.MVPButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MVPButton.Location = new System.Drawing.Point(6, 46);
            this.MVPButton.Name = "MVPButton";
            this.MVPButton.Size = new System.Drawing.Size(75, 23);
            this.MVPButton.TabIndex = 1;
            this.MVPButton.Text = "Browse";
            this.MVPButton.UseVisualStyleBackColor = true;
            this.MVPButton.Click += new System.EventHandler(this.MVPButton_Click);
            // 
            // MVPTextBox
            // 
            this.MVPTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MVPTextBox.Location = new System.Drawing.Point(104, 46);
            this.MVPTextBox.Name = "MVPTextBox";
            this.MVPTextBox.Size = new System.Drawing.Size(125, 23);
            this.MVPTextBox.TabIndex = 2;
            // 
            // lostGroup
            // 
            this.lostGroup.Controls.Add(this.lostTrackBar);
            this.lostGroup.Controls.Add(this.lostButton);
            this.lostGroup.Controls.Add(this.lostTextBox);
            this.lostGroup.Location = new System.Drawing.Point(253, 128);
            this.lostGroup.Name = "lostGroup";
            this.lostGroup.Size = new System.Drawing.Size(235, 78);
            this.lostGroup.TabIndex = 12;
            this.lostGroup.TabStop = false;
            this.lostGroup.Text = "Round Lost:";
            // 
            // lostTrackBar
            // 
            this.lostTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lostTrackBar.AutoSize = false;
            this.lostTrackBar.LargeChange = 10;
            this.lostTrackBar.Location = new System.Drawing.Point(6, 22);
            this.lostTrackBar.Maximum = 100;
            this.lostTrackBar.Name = "lostTrackBar";
            this.lostTrackBar.Size = new System.Drawing.Size(223, 24);
            this.lostTrackBar.SmallChange = 5;
            this.lostTrackBar.TabIndex = 3;
            this.lostTrackBar.Tag = "";
            this.lostTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.lostTrackBar.Value = 100;
            // 
            // lostButton
            // 
            this.lostButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lostButton.Location = new System.Drawing.Point(6, 49);
            this.lostButton.Name = "lostButton";
            this.lostButton.Size = new System.Drawing.Size(75, 23);
            this.lostButton.TabIndex = 1;
            this.lostButton.Text = "Browse";
            this.lostButton.UseVisualStyleBackColor = true;
            this.lostButton.Click += new System.EventHandler(this.lostButton_Click);
            // 
            // lostTextBox
            // 
            this.lostTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lostTextBox.Location = new System.Drawing.Point(98, 49);
            this.lostTextBox.Name = "lostTextBox";
            this.lostTextBox.Size = new System.Drawing.Size(131, 23);
            this.lostTextBox.TabIndex = 2;
            // 
            // wonGroup
            // 
            this.wonGroup.Controls.Add(this.wonTrackBar);
            this.wonGroup.Controls.Add(this.wonButton);
            this.wonGroup.Controls.Add(this.wonTextBox);
            this.wonGroup.Location = new System.Drawing.Point(253, 50);
            this.wonGroup.Name = "wonGroup";
            this.wonGroup.Size = new System.Drawing.Size(235, 78);
            this.wonGroup.TabIndex = 11;
            this.wonGroup.TabStop = false;
            this.wonGroup.Text = "Round Won:";
            // 
            // wonTrackBar
            // 
            this.wonTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wonTrackBar.AutoSize = false;
            this.wonTrackBar.LargeChange = 10;
            this.wonTrackBar.Location = new System.Drawing.Point(6, 22);
            this.wonTrackBar.Maximum = 100;
            this.wonTrackBar.Name = "wonTrackBar";
            this.wonTrackBar.Size = new System.Drawing.Size(223, 24);
            this.wonTrackBar.SmallChange = 5;
            this.wonTrackBar.TabIndex = 3;
            this.wonTrackBar.Tag = "";
            this.wonTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.wonTrackBar.Value = 100;
            // 
            // wonButton
            // 
            this.wonButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.wonButton.Location = new System.Drawing.Point(6, 49);
            this.wonButton.Name = "wonButton";
            this.wonButton.Size = new System.Drawing.Size(75, 23);
            this.wonButton.TabIndex = 1;
            this.wonButton.Text = "Browse";
            this.wonButton.UseVisualStyleBackColor = true;
            this.wonButton.Click += new System.EventHandler(this.wonButton_Click);
            // 
            // wonTextBox
            // 
            this.wonTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.wonTextBox.Location = new System.Drawing.Point(98, 49);
            this.wonTextBox.Name = "wonTextBox";
            this.wonTextBox.Size = new System.Drawing.Size(131, 23);
            this.wonTextBox.TabIndex = 2;
            // 
            // bombGroup
            // 
            this.bombGroup.Controls.Add(this.bombTrackBar);
            this.bombGroup.Controls.Add(this.bombButton);
            this.bombGroup.Controls.Add(this.bombTextBox);
            this.bombGroup.Location = new System.Drawing.Point(12, 272);
            this.bombGroup.Name = "bombGroup";
            this.bombGroup.Size = new System.Drawing.Size(235, 75);
            this.bombGroup.TabIndex = 10;
            this.bombGroup.TabStop = false;
            this.bombGroup.Text = "Bomb Planted:";
            // 
            // bombTrackBar
            // 
            this.bombTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bombTrackBar.AutoSize = false;
            this.bombTrackBar.LargeChange = 10;
            this.bombTrackBar.Location = new System.Drawing.Point(6, 22);
            this.bombTrackBar.Maximum = 100;
            this.bombTrackBar.Name = "bombTrackBar";
            this.bombTrackBar.Size = new System.Drawing.Size(223, 24);
            this.bombTrackBar.SmallChange = 5;
            this.bombTrackBar.TabIndex = 3;
            this.bombTrackBar.Tag = "";
            this.bombTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.bombTrackBar.Value = 100;
            // 
            // bombButton
            // 
            this.bombButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bombButton.Location = new System.Drawing.Point(6, 46);
            this.bombButton.Name = "bombButton";
            this.bombButton.Size = new System.Drawing.Size(75, 23);
            this.bombButton.TabIndex = 1;
            this.bombButton.Text = "Browse";
            this.bombButton.UseVisualStyleBackColor = true;
            this.bombButton.Click += new System.EventHandler(this.bombButton_Click);
            // 
            // bombTextBox
            // 
            this.bombTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bombTextBox.Location = new System.Drawing.Point(98, 46);
            this.bombTextBox.Name = "bombTextBox";
            this.bombTextBox.Size = new System.Drawing.Size(131, 23);
            this.bombTextBox.TabIndex = 2;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveButton.Location = new System.Drawing.Point(12, 362);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(444, 362);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(187, 5);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 24);
            this.deleteButton.TabIndex = 14;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.AddExtension = false;
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "MP3|*.mp3|Windows Audio|*.wav|MP4 Audio|*.m4a";
            this.openFileDialog1.ReadOnlyChecked = true;
            this.openFileDialog1.ShowReadOnly = true;
            // 
            // MusicSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 391);
            this.Controls.Add(this.MVPGroup);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.lostGroup);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.wonGroup);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.bombGroup);
            this.Controls.Add(this.startGroup);
            this.Controls.Add(this.freezeGroup);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label2);
            this.Name = "MusicSelector";
            this.Text = "Music Selector";
            this.Load += new System.EventHandler(this.MusicSelector_Load);
            this.freezeGroup.ResumeLayout(false);
            this.freezeGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.freezeTrackBar)).EndInit();
            this.startGroup.ResumeLayout(false);
            this.startGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startTrackBar)).EndInit();
            this.MVPGroup.ResumeLayout(false);
            this.MVPGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MVPTrackBar)).EndInit();
            this.lostGroup.ResumeLayout(false);
            this.lostGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lostTrackBar)).EndInit();
            this.wonGroup.ResumeLayout(false);
            this.wonGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wonTrackBar)).EndInit();
            this.bombGroup.ResumeLayout(false);
            this.bombGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bombTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button freezeButton;
        private System.Windows.Forms.TextBox freezeTextBox;
        private System.Windows.Forms.GroupBox freezeGroup;
        private System.Windows.Forms.TrackBar freezeTrackBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.GroupBox startGroup;
        private System.Windows.Forms.TrackBar startTrackBar;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox startTextBox;
        private System.Windows.Forms.GroupBox bombGroup;
        private System.Windows.Forms.TrackBar bombTrackBar;
        private System.Windows.Forms.Button bombButton;
        private System.Windows.Forms.TextBox bombTextBox;
        private System.Windows.Forms.GroupBox wonGroup;
        private System.Windows.Forms.TrackBar wonTrackBar;
        private System.Windows.Forms.Button wonButton;
        private System.Windows.Forms.TextBox wonTextBox;
        private System.Windows.Forms.GroupBox lostGroup;
        private System.Windows.Forms.TrackBar lostTrackBar;
        private System.Windows.Forms.Button lostButton;
        private System.Windows.Forms.TextBox lostTextBox;
        private System.Windows.Forms.GroupBox MVPGroup;
        private System.Windows.Forms.TrackBar MVPTrackBar;
        private System.Windows.Forms.Button MVPButton;
        private System.Windows.Forms.TextBox MVPTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox freezeStartTextBox;
        private System.Windows.Forms.Label label1;
    }
}