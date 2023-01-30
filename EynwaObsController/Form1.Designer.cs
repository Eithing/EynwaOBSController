
namespace EynwaObsController
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabEventSelection = new System.Windows.Forms.TabControl();
            this.ListLocal = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.numMuteDuringTime = new System.Windows.Forms.NumericUpDown();
            this.numLaterDelay = new System.Windows.Forms.NumericUpDown();
            this.numChehDelay = new System.Windows.Forms.NumericUpDown();
            this.numPopopoDelay = new System.Windows.Forms.NumericUpDown();
            this.numMuteDelay = new System.Windows.Forms.NumericUpDown();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.twitchChatEvent = new System.Windows.Forms.TabPage();
            this.AddTextDetector = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TextFromChat = new System.Windows.Forms.TextBox();
            this.twitchFollowEvent = new System.Windows.Forms.TabPage();
            this.twitchSubEvent = new System.Windows.Forms.TabPage();
            this.twitchBitsEvent = new System.Windows.Forms.TabPage();
            this.twitchChanPointEvent = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.tabEventSelection.SuspendLayout();
            this.ListLocal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMuteDuringTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLaterDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChehDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPopopoDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMuteDelay)).BeginInit();
            this.twitchChatEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabEventSelection
            // 
            this.tabEventSelection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabEventSelection.Controls.Add(this.ListLocal);
            this.tabEventSelection.Controls.Add(this.twitchChatEvent);
            this.tabEventSelection.Controls.Add(this.twitchFollowEvent);
            this.tabEventSelection.Controls.Add(this.twitchSubEvent);
            this.tabEventSelection.Controls.Add(this.twitchBitsEvent);
            this.tabEventSelection.Controls.Add(this.twitchChanPointEvent);
            this.tabEventSelection.ItemSize = new System.Drawing.Size(114, 20);
            this.tabEventSelection.Location = new System.Drawing.Point(0, 0);
            this.tabEventSelection.Margin = new System.Windows.Forms.Padding(0);
            this.tabEventSelection.Multiline = true;
            this.tabEventSelection.Name = "tabEventSelection";
            this.tabEventSelection.Padding = new System.Drawing.Point(0, 0);
            this.tabEventSelection.SelectedIndex = 0;
            this.tabEventSelection.Size = new System.Drawing.Size(236, 450);
            this.tabEventSelection.TabIndex = 0;
            // 
            // ListLocal
            // 
            this.ListLocal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.ListLocal.Controls.Add(this.numericUpDown2);
            this.ListLocal.Controls.Add(this.checkBox6);
            this.ListLocal.Controls.Add(this.numericUpDown1);
            this.ListLocal.Controls.Add(this.checkBox5);
            this.ListLocal.Controls.Add(this.label2);
            this.ListLocal.Controls.Add(this.numMuteDuringTime);
            this.ListLocal.Controls.Add(this.numLaterDelay);
            this.ListLocal.Controls.Add(this.numChehDelay);
            this.ListLocal.Controls.Add(this.numPopopoDelay);
            this.ListLocal.Controls.Add(this.numMuteDelay);
            this.ListLocal.Controls.Add(this.checkBox3);
            this.ListLocal.Controls.Add(this.checkBox4);
            this.ListLocal.Controls.Add(this.checkBox2);
            this.ListLocal.Controls.Add(this.checkBox1);
            this.ListLocal.Location = new System.Drawing.Point(4, 44);
            this.ListLocal.Name = "ListLocal";
            this.ListLocal.Padding = new System.Windows.Forms.Padding(3);
            this.ListLocal.Size = new System.Drawing.Size(228, 402);
            this.ListLocal.TabIndex = 1;
            this.ListLocal.Text = "Fonction Locale";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Durée du mute";
            // 
            // numMuteDuringTime
            // 
            this.numMuteDuringTime.Location = new System.Drawing.Point(105, 48);
            this.numMuteDuringTime.Name = "numMuteDuringTime";
            this.numMuteDuringTime.Size = new System.Drawing.Size(120, 23);
            this.numMuteDuringTime.TabIndex = 14;
            this.numMuteDuringTime.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numMuteDuringTime.ValueChanged += new System.EventHandler(this.numMuteDuringTime_ValueChanged);
            // 
            // numLaterDelay
            // 
            this.numLaterDelay.Location = new System.Drawing.Point(105, 127);
            this.numLaterDelay.Name = "numLaterDelay";
            this.numLaterDelay.Size = new System.Drawing.Size(120, 23);
            this.numLaterDelay.TabIndex = 13;
            this.numLaterDelay.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numLaterDelay.ValueChanged += new System.EventHandler(this.numLaterDelay_ValueChanged);
            // 
            // numChehDelay
            // 
            this.numChehDelay.Location = new System.Drawing.Point(105, 102);
            this.numChehDelay.Name = "numChehDelay";
            this.numChehDelay.Size = new System.Drawing.Size(120, 23);
            this.numChehDelay.TabIndex = 12;
            this.numChehDelay.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numChehDelay.ValueChanged += new System.EventHandler(this.numChehDelay_ValueChanged);
            // 
            // numPopopoDelay
            // 
            this.numPopopoDelay.Location = new System.Drawing.Point(105, 77);
            this.numPopopoDelay.Name = "numPopopoDelay";
            this.numPopopoDelay.Size = new System.Drawing.Size(120, 23);
            this.numPopopoDelay.TabIndex = 11;
            this.numPopopoDelay.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numPopopoDelay.ValueChanged += new System.EventHandler(this.numPopopoDelay_ValueChanged);
            // 
            // numMuteDelay
            // 
            this.numMuteDelay.Location = new System.Drawing.Point(105, 23);
            this.numMuteDelay.Name = "numMuteDelay";
            this.numMuteDelay.Size = new System.Drawing.Size(120, 23);
            this.numMuteDelay.TabIndex = 10;
            this.numMuteDelay.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numMuteDelay.ValueChanged += new System.EventHandler(this.numMuteDelay_ValueChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(8, 128);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(49, 19);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "later";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(8, 103);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(52, 19);
            this.checkBox4.TabIndex = 2;
            this.checkBox4.Text = "cheh";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(8, 78);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(68, 19);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "popopo";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(8, 24);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(54, 19);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "mute";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // twitchChatEvent
            // 
            this.twitchChatEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.twitchChatEvent.Controls.Add(this.AddTextDetector);
            this.twitchChatEvent.Controls.Add(this.label1);
            this.twitchChatEvent.Controls.Add(this.TextFromChat);
            this.twitchChatEvent.Location = new System.Drawing.Point(4, 44);
            this.twitchChatEvent.Name = "twitchChatEvent";
            this.twitchChatEvent.Padding = new System.Windows.Forms.Padding(3);
            this.twitchChatEvent.Size = new System.Drawing.Size(228, 402);
            this.twitchChatEvent.TabIndex = 0;
            this.twitchChatEvent.Text = "Chat";
            // 
            // AddTextDetector
            // 
            this.AddTextDetector.Location = new System.Drawing.Point(116, 26);
            this.AddTextDetector.Name = "AddTextDetector";
            this.AddTextDetector.Size = new System.Drawing.Size(75, 23);
            this.AddTextDetector.TabIndex = 2;
            this.AddTextDetector.Text = "Ajouter";
            this.AddTextDetector.UseVisualStyleBackColor = true;
            this.AddTextDetector.Click += new System.EventHandler(this.AddTextDetector_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(146)))), ((int)(((byte)(151)))));
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mot à détecter dans le chat";
            // 
            // TextFromChat
            // 
            this.TextFromChat.Location = new System.Drawing.Point(8, 26);
            this.TextFromChat.Name = "TextFromChat";
            this.TextFromChat.PlaceholderText = "Mot à détecter";
            this.TextFromChat.Size = new System.Drawing.Size(100, 23);
            this.TextFromChat.TabIndex = 0;
            // 
            // twitchFollowEvent
            // 
            this.twitchFollowEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.twitchFollowEvent.Location = new System.Drawing.Point(4, 44);
            this.twitchFollowEvent.Name = "twitchFollowEvent";
            this.twitchFollowEvent.Padding = new System.Windows.Forms.Padding(3);
            this.twitchFollowEvent.Size = new System.Drawing.Size(228, 402);
            this.twitchFollowEvent.TabIndex = 1;
            this.twitchFollowEvent.Text = "Follow";
            // 
            // twitchSubEvent
            // 
            this.twitchSubEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.twitchSubEvent.Location = new System.Drawing.Point(4, 44);
            this.twitchSubEvent.Name = "twitchSubEvent";
            this.twitchSubEvent.Padding = new System.Windows.Forms.Padding(3);
            this.twitchSubEvent.Size = new System.Drawing.Size(228, 402);
            this.twitchSubEvent.TabIndex = 1;
            this.twitchSubEvent.Text = "Subs";
            // 
            // twitchBitsEvent
            // 
            this.twitchBitsEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.twitchBitsEvent.Location = new System.Drawing.Point(4, 44);
            this.twitchBitsEvent.Name = "twitchBitsEvent";
            this.twitchBitsEvent.Padding = new System.Windows.Forms.Padding(3);
            this.twitchBitsEvent.Size = new System.Drawing.Size(228, 402);
            this.twitchBitsEvent.TabIndex = 1;
            this.twitchBitsEvent.Text = "Bits";
            // 
            // twitchChanPointEvent
            // 
            this.twitchChanPointEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.twitchChanPointEvent.Location = new System.Drawing.Point(4, 44);
            this.twitchChanPointEvent.Name = "twitchChanPointEvent";
            this.twitchChanPointEvent.Padding = new System.Windows.Forms.Padding(3);
            this.twitchChanPointEvent.Size = new System.Drawing.Size(228, 402);
            this.twitchChanPointEvent.TabIndex = 1;
            this.twitchChanPointEvent.Text = "Chan-Points";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(239, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(561, 450);
            this.panel1.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(105, 152);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown1.TabIndex = 17;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(8, 153);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(40, 19);
            this.checkBox5.TabIndex = 16;
            this.checkBox5.Text = "gg";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(105, 177);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown2.TabIndex = 19;
            this.numericUpDown2.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(8, 178);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(40, 19);
            this.checkBox6.TabIndex = 18;
            this.checkBox6.Text = "rip";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabEventSelection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form1";
            this.tabEventSelection.ResumeLayout(false);
            this.ListLocal.ResumeLayout(false);
            this.ListLocal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMuteDuringTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLaterDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChehDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPopopoDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMuteDelay)).EndInit();
            this.twitchChatEvent.ResumeLayout(false);
            this.twitchChatEvent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabEventSelection;
        private System.Windows.Forms.TabPage ListLocal;
        private System.Windows.Forms.TabPage twitchChatEvent;
        private System.Windows.Forms.TabPage twitchFollowEvent;
        private System.Windows.Forms.TabPage twitchSubEvent;
        private System.Windows.Forms.TabPage twitchBitsEvent;
        private System.Windows.Forms.TabPage twitchChanPointEvent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextFromChat;
        private System.Windows.Forms.Button AddTextDetector;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label zegzeg;
        private System.Windows.Forms.NumericUpDown numMuteDuringTime;
        private System.Windows.Forms.NumericUpDown numLaterDelay;
        private System.Windows.Forms.NumericUpDown numChehDelay;
        private System.Windows.Forms.NumericUpDown numPopopoDelay;
        private System.Windows.Forms.NumericUpDown numMuteDelay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox checkBox5;
    }
}

