using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using XRPCLib;
using XDevkitPlusPlus;
using System.Net.NetworkInformation;
using System.Diagnostics;

namespace SonicUnleashedRTMByBoxuga
{
    public partial class Form1 : Form
    {
        XRPC rpc = new XRPC();
        public Form1()
        {
            InitializeComponent();
            actions.Text = $"Welcome {Environment.UserName} to the Sonic CD Mod Tool";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            rpc.Connect();
            if (rpc.activeConnection)
            {
                actions.Text = $"Connected to {Environment.UserName}'s Xbox";
                MessageBox.Show($"Connected to {Environment.UserName}'s Xbox");
                button2.Enabled = true;
                button3.Enabled = true;
                button1.Enabled = true;
                LivesEditorbtn.Enabled = true;
                LivesEditorNum.Enabled = true;
                NoRings.Enabled = true;
                FiveZeroRings.Enabled = true;
                HundredRings.Enabled = true;
                HundredFiveRings.Enabled = true;
                NineNineNineRings.Enabled = true;
                ZeroScore.Enabled = true;
                ScoreNineNineNineHundred.Enabled = true;
                OneHundredKScore.Enabled = true;
                FiveHundredKScore.Enabled = true;
                NineNineNineKScore.Enabled = true;
                RingsCustomNum.Enabled = true;
                CustomScoreBTN.Enabled = true;
                CustomScoreNum.Enabled = true;
                checkBox1.Enabled = true;
                refreshbtn.Enabled = true;
                ScoreUpdater();

            }
            else
            {
                actions.Text = $"Connection Failed to Connect to XRPC";
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            rpc.xbCon.DebugTarget.WriteInt32(Convert.ToUInt32(0xC23F957C), 99);
            actions.Text = $"Set to 99 Lives on {Environment.UserName}'s Xbox";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rpc.xbCon.DebugTarget.WriteInt32(Convert.ToUInt32(0xC23F957C), 0);
            actions.Text = $"Set to 0 Lives on {Environment.UserName}'s Xbox";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rpc.xbCon.DebugTarget.WriteInt32(Convert.ToUInt32(0xC23F957C), 50);
            actions.Text = $"Set to 50 Lives on {Environment.UserName}'s Xbox";
        }

        private void NoRings_Click(object sender, EventArgs e)
        {
            rpc.xbCon.DebugTarget.WriteInt32(Convert.ToUInt32(0xC23CFBD0), 0);
            actions.Text = $"Set to 0 Rings on {Environment.UserName}'s Xbox";
        }

        private void FiveZeroRings_Click(object sender, EventArgs e)
        {
            rpc.xbCon.DebugTarget.WriteInt32(Convert.ToUInt32(0xC23CFBD0), 50);
            actions.Text = $"Set to 50 Rings on {Environment.UserName}'s Xbox";
        }

        private void HundredRings_Click(object sender, EventArgs e)
        {
            rpc.xbCon.DebugTarget.WriteInt32(Convert.ToUInt32(0xC23CFBD0), 100);
            actions.Text = $"Set to 100 Rings on {Environment.UserName}'s Xbox";
        }

        private void HundredFiveRings_Click(object sender, EventArgs e)
        {
            rpc.xbCon.DebugTarget.WriteInt32(Convert.ToUInt32(0xC23CFBD0), 150);
            actions.Text = $"Set to 150 Rings on {Environment.UserName}'s Xbox";
        }

        private void NineNineNineRings_Click(object sender, EventArgs e)
        {
            rpc.xbCon.DebugTarget.WriteInt32(Convert.ToUInt32(0xC23CFBD0), 999);
            actions.Text = $"Set to 999 Rings on {Environment.UserName}'s Xbox";
        }

        private void YTBoxuga_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/@Boxuga");
        }

        private void Boxudotga_Click(object sender, EventArgs e)
        {
            Process.Start("https://boxu.ga");
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Process.Start("http://rtm.boxu.ga/");
        }

        private void LivesEditorbtn_Click(object sender, EventArgs e)
        {
            rpc.xbCon.DebugTarget.WriteInt32(Convert.ToUInt32(0xC23F957C), ((int)LivesEditorNum.Value));
            actions.Text = $"Set to {LivesEditorNum.Value} Rings on {Environment.UserName}'s Xbox";
        }

        private void ZeroScore_Click(object sender, EventArgs e)
        {
            rpc.xbCon.DebugTarget.WriteInt32(Convert.ToUInt32(0xC23F9574), 0);
            actions.Text = $"Set your score to 0 on {Environment.UserName}'s Xbox";
        }

        private void SetRingsCustomBTN_Click(object sender, EventArgs e)
        {
            rpc.xbCon.DebugTarget.WriteInt32(Convert.ToUInt32(0xC23F957C), ((int)RingsCustomNum.Value));
            actions.Text = $"Set to {RingsCustomNum.Value} Rings on {Environment.UserName}'s Xbox";
        }

        private void ScoreNineNineNineHundred_Click(object sender, EventArgs e)
        {
            rpc.xbCon.DebugTarget.WriteInt32(Convert.ToUInt32(0xC23F9574), 999);
            actions.Text = $"Set your score to 999 on {Environment.UserName}'s Xbox";
        }

        private void OneHundredKScore_Click(object sender, EventArgs e)
        {
            rpc.xbCon.DebugTarget.WriteInt32(Convert.ToUInt32(0xC23F9574), 100000);
            actions.Text = $"Set your score to 100,000 on {Environment.UserName}'s Xbox";
        }

        private void FiveHundredKScore_Click(object sender, EventArgs e)
        {
            rpc.xbCon.DebugTarget.WriteInt32(Convert.ToUInt32(0xC23F9574), 500000);
            actions.Text = $"Set your score to 500,000 on {Environment.UserName}'s Xbox";
        }

        private void NineNineNineKScore_Click(object sender, EventArgs e)
        {
            rpc.xbCon.DebugTarget.WriteInt32(Convert.ToUInt32(0xC23F9574), 0);
            actions.Text = $"Set your score to 999,999 on {Environment.UserName}'s Xbox";
        }

        private void CustomScoreBTN_Click(object sender, EventArgs e)
        {
            rpc.xbCon.DebugTarget.WriteInt32(Convert.ToUInt32(0xC23F9574), ((int)CustomScoreNum.Value));
            actions.Text = $"Set your score to {CustomScoreNum.Value} on {Environment.UserName}'s Xbox";
        }

        private void ScoreUpdater()
        {
            ScoreStat.Text = $"Score: {rpc.xbCon.DebugTarget.ReadInt32(Convert.ToUInt32(0xC23F9574))}";
            LivesStat.Text = $"Lives: {rpc.xbCon.DebugTarget.ReadInt32(Convert.ToUInt32(0xC23F957C))}";
        }

        private void stattimer_Tick(object sender, EventArgs e)
        {
            ScoreUpdater();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                stattimer.Start();
            }
            else
            {
                stattimer.Stop();
            }
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            ScoreUpdater();
        }
    }
}
