
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
            this.freezeTrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.musicComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.startGroup = new System.Windows.Forms.GroupBox();
            this.startTrackBar = new System.Windows.Forms.TrackBar();
            this.startButton = new System.Windows.Forms.Button();
            this.startTextBox = new System.Windows.Forms.TextBox();
            this.songPanel = new System.Windows.Forms.Panel();
            this.MVPGroup = new System.Windows.Forms.GroupBox();
            this.MVPTrackBar = new System.Windows.Forms.TrackBar();
            this.MBPButton = new System.Windows.Forms.Button();
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
            this.createButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.freezeGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.freezeTrackBar)).BeginInit();
            this.startGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startTrackBar)).BeginInit();
            this.songPanel.SuspendLayout();
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
            this.freezeButton.Location = new System.Drawing.Point(6, 49);
            this.freezeButton.Name = "freezeButton";
            this.freezeButton.Size = new System.Drawing.Size(75, 23);
            this.freezeButton.TabIndex = 1;
            this.freezeButton.Text = "Browse";
            this.freezeButton.UseVisualStyleBackColor = true;
            // 
            // freezeTextBox
            // 
            this.freezeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.freezeTextBox.Location = new System.Drawing.Point(98, 49);
            this.freezeTextBox.Name = "freezeTextBox";
            this.freezeTextBox.Size = new System.Drawing.Size(131, 23);
            this.freezeTextBox.TabIndex = 2;
            // 
            // freezeGroup
            // 
            this.freezeGroup.Controls.Add(this.freezeTrackBar);
            this.freezeGroup.Controls.Add(this.freezeButton);
            this.freezeGroup.Controls.Add(this.freezeTextBox);
            this.freezeGroup.Location = new System.Drawing.Point(11, 3);
            this.freezeGroup.Name = "freezeGroup";
            this.freezeGroup.Size = new System.Drawing.Size(235, 78);
            this.freezeGroup.TabIndex = 3;
            this.freezeGroup.TabStop = false;
            this.freezeGroup.Text = "Freeze Time:";
            // 
            // freezeTrackBar
            // 
            this.freezeTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.freezeTrackBar.AutoSize = false;
            this.freezeTrackBar.LargeChange = 10;
            this.freezeTrackBar.Location = new System.Drawing.Point(6, 25);
            this.freezeTrackBar.Maximum = 100;
            this.freezeTrackBar.Name = "freezeTrackBar";
            this.freezeTrackBar.Size = new System.Drawing.Size(223, 24);
            this.freezeTrackBar.SmallChange = 5;
            this.freezeTrackBar.TabIndex = 3;
            this.freezeTrackBar.Tag = "";
            this.freezeTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.freezeTrackBar.Value = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select Music Kit:";
            // 
            // musicComboBox
            // 
            this.musicComboBox.FormattingEnabled = true;
            this.musicComboBox.Location = new System.Drawing.Point(12, 27);
            this.musicComboBox.Name = "musicComboBox";
            this.musicComboBox.Size = new System.Drawing.Size(121, 23);
            this.musicComboBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(136, 27);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(121, 23);
            this.nameTextBox.TabIndex = 8;
            // 
            // startGroup
            // 
            this.startGroup.Controls.Add(this.startTrackBar);
            this.startGroup.Controls.Add(this.startButton);
            this.startGroup.Controls.Add(this.startTextBox);
            this.startGroup.Location = new System.Drawing.Point(11, 87);
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
            // 
            // startTextBox
            // 
            this.startTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.startTextBox.Location = new System.Drawing.Point(98, 49);
            this.startTextBox.Name = "startTextBox";
            this.startTextBox.Size = new System.Drawing.Size(131, 23);
            this.startTextBox.TabIndex = 2;
            // 
            // songPanel
            // 
            this.songPanel.AccessibleName = "";
            this.songPanel.AutoScroll = true;
            this.songPanel.Controls.Add(this.MVPGroup);
            this.songPanel.Controls.Add(this.lostGroup);
            this.songPanel.Controls.Add(this.wonGroup);
            this.songPanel.Controls.Add(this.bombGroup);
            this.songPanel.Controls.Add(this.freezeGroup);
            this.songPanel.Controls.Add(this.startGroup);
            this.songPanel.Location = new System.Drawing.Point(2, 85);
            this.songPanel.Name = "songPanel";
            this.songPanel.Size = new System.Drawing.Size(266, 336);
            this.songPanel.TabIndex = 10;
            this.songPanel.Tag = "";
            // 
            // MVPGroup
            // 
            this.MVPGroup.Controls.Add(this.MVPTrackBar);
            this.MVPGroup.Controls.Add(this.MBPButton);
            this.MVPGroup.Controls.Add(this.MVPTextBox);
            this.MVPGroup.Location = new System.Drawing.Point(11, 419);
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
            // MBPButton
            // 
            this.MBPButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MBPButton.Location = new System.Drawing.Point(6, 46);
            this.MBPButton.Name = "MBPButton";
            this.MBPButton.Size = new System.Drawing.Size(75, 23);
            this.MBPButton.TabIndex = 1;
            this.MBPButton.Text = "Browse";
            this.MBPButton.UseVisualStyleBackColor = true;
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
            this.lostGroup.Location = new System.Drawing.Point(11, 336);
            this.lostGroup.Name = "lostGroup";
            this.lostGroup.Size = new System.Drawing.Size(235, 77);
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
            this.lostButton.Location = new System.Drawing.Point(6, 48);
            this.lostButton.Name = "lostButton";
            this.lostButton.Size = new System.Drawing.Size(75, 23);
            this.lostButton.TabIndex = 1;
            this.lostButton.Text = "Browse";
            this.lostButton.UseVisualStyleBackColor = true;
            // 
            // lostTextBox
            // 
            this.lostTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lostTextBox.Location = new System.Drawing.Point(98, 48);
            this.lostTextBox.Name = "lostTextBox";
            this.lostTextBox.Size = new System.Drawing.Size(131, 23);
            this.lostTextBox.TabIndex = 2;
            // 
            // wonGroup
            // 
            this.wonGroup.Controls.Add(this.wonTrackBar);
            this.wonGroup.Controls.Add(this.wonButton);
            this.wonGroup.Controls.Add(this.wonTextBox);
            this.wonGroup.Location = new System.Drawing.Point(11, 255);
            this.wonGroup.Name = "wonGroup";
            this.wonGroup.Size = new System.Drawing.Size(235, 75);
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
            this.wonButton.Location = new System.Drawing.Point(6, 46);
            this.wonButton.Name = "wonButton";
            this.wonButton.Size = new System.Drawing.Size(75, 23);
            this.wonButton.TabIndex = 1;
            this.wonButton.Text = "Browse";
            this.wonButton.UseVisualStyleBackColor = true;
            // 
            // wonTextBox
            // 
            this.wonTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.wonTextBox.Location = new System.Drawing.Point(98, 46);
            this.wonTextBox.Name = "wonTextBox";
            this.wonTextBox.Size = new System.Drawing.Size(131, 23);
            this.wonTextBox.TabIndex = 2;
            // 
            // bombGroup
            // 
            this.bombGroup.Controls.Add(this.bombTrackBar);
            this.bombGroup.Controls.Add(this.bombButton);
            this.bombGroup.Controls.Add(this.bombTextBox);
            this.bombGroup.Location = new System.Drawing.Point(11, 171);
            this.bombGroup.Name = "bombGroup";
            this.bombGroup.Size = new System.Drawing.Size(235, 78);
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
            this.bombButton.Location = new System.Drawing.Point(6, 49);
            this.bombButton.Name = "bombButton";
            this.bombButton.Size = new System.Drawing.Size(75, 23);
            this.bombButton.TabIndex = 1;
            this.bombButton.Text = "Browse";
            this.bombButton.UseVisualStyleBackColor = true;
            // 
            // bombTextBox
            // 
            this.bombTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bombTextBox.Location = new System.Drawing.Point(98, 49);
            this.bombTextBox.Name = "bombTextBox";
            this.bombTextBox.Size = new System.Drawing.Size(131, 23);
            this.bombTextBox.TabIndex = 2;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveButton.Location = new System.Drawing.Point(12, 425);
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
            this.cancelButton.Location = new System.Drawing.Point(182, 425);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(36, 56);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 13;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(167, 56);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 14;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // MusicSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 454);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.songPanel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.musicComboBox);
            this.Controls.Add(this.label1);
            this.Name = "MusicSelector";
            this.Text = "Music Selector";
            this.Load += new System.EventHandler(this.MusicSelector_Load);
            this.freezeGroup.ResumeLayout(false);
            this.freezeGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.freezeTrackBar)).EndInit();
            this.startGroup.ResumeLayout(false);
            this.startGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startTrackBar)).EndInit();
            this.songPanel.ResumeLayout(false);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox musicComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.GroupBox startGroup;
        private System.Windows.Forms.TrackBar startTrackBar;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox startTextBox;
        private System.Windows.Forms.Panel songPanel;
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
        private System.Windows.Forms.Button MBPButton;
        private System.Windows.Forms.TextBox MVPTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button deleteButton;
    }
}