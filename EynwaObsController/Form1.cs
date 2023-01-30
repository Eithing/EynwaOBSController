using EynwaObsController.Functions;
using EynwaObsController.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EynwaObsController
{
    public partial class Form1 : Form
    {
        private List<Event> events;
        private ObsController obsController;
        private TwitchChatBot twitchChatBot;
        public Form1()
        {
            InitializeComponent();
            obsController = new ObsController();
            this.twitchChatBot = new TwitchChatBot(obsController);
        }

        private void AddTextDetector_Click(object sender, EventArgs e)
        {
            events.Add(new Event{ Name = this.TextFromChat.Text, Delay = 5, Type = EventType.TextChatDetector });
            //flEventListSelected.Controls.Add()
        }

        private void tabEventSelection_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).CheckState == CheckState.Checked)
                this.twitchChatBot.IsMuteEnable = true;
            else
                this.twitchChatBot.IsMuteEnable = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).CheckState == CheckState.Checked)
                this.twitchChatBot.IsPopoEnable = true;
            else
                this.twitchChatBot.IsPopoEnable = false;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).CheckState == CheckState.Checked)
                this.twitchChatBot.IsChehEnable = true;
            else
                this.twitchChatBot.IsChehEnable = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).CheckState == CheckState.Checked)
                this.twitchChatBot.IsLaterEnable = true;
            else
                this.twitchChatBot.IsLaterEnable = false;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).CheckState == CheckState.Checked)
                this.twitchChatBot.IsGgEnable = true;
            else
                this.twitchChatBot.IsGgEnable = false;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).CheckState == CheckState.Checked)
                this.twitchChatBot.IsRipEnable = true;
            else
                this.twitchChatBot.IsRipEnable = false;
        }

        private void numMuteDuringTime_ValueChanged(object sender, EventArgs e)
        {
            this.obsController.MuteTime = (int)((NumericUpDown)sender).Value;
        }

        private void numMuteDelay_ValueChanged(object sender, EventArgs e)
        {
            this.twitchChatBot.MuteDelay = (int)((NumericUpDown)sender).Value;
        }

        private void numPopopoDelay_ValueChanged(object sender, EventArgs e)
        {
            this.twitchChatBot.PopoDelay = (int)((NumericUpDown)sender).Value;
        }

        private void numChehDelay_ValueChanged(object sender, EventArgs e)
        {
            this.twitchChatBot.ChehDelay = (int)((NumericUpDown)sender).Value;
        }

        private void numLaterDelay_ValueChanged(object sender, EventArgs e)
        {
            this.twitchChatBot.LaterDelay = (int)((NumericUpDown)sender).Value;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.twitchChatBot.GgDelay = (int)((NumericUpDown)sender).Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            this.twitchChatBot.RipDelay = (int)((NumericUpDown)sender).Value;
        }
    }
}
