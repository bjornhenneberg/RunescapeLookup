using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunescapeLookup
{
    public partial class Form1 : Form
    {
        Highscore pd = new Highscore();
        public Form1()
        {
            InitializeComponent();
            this.Text = "Runescape Lookup";
            txtPlayerName.KeyDown += new KeyEventHandler(txtPlayerName_KeyDown);
            CenterToScreen();
            Icon = Properties.Resources.overall;
        }

        public void iniData()
        {
            setTotal();
            setAttack();
            setDefence();
            setStrength();
        }

        private void btnLookup_Click(object sender, EventArgs e)
        {
            setStats();
        }

        public void setStats()
        {
            if (txtPlayerName.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Please enter a Runescape name.","Error!", MessageBoxButtons.OK ,MessageBoxIcon.Error);
            }
            else
            {
                pd.emptyData();
                resetAll();
                string hiscoreurl = "http://services.runescape.com/m=hiscore/index_lite.ws?player=" + txtPlayerName.Text;
                string advlogurl = "http://services.runescape.com/m=adventurers-log/rssfeed?searchName=" + txtPlayerName.Text;

                pd.getPlayerData(hiscoreurl);

                iniData();
            }
        }

        public void txtPlayerName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                setStats();
            }
            if (e.KeyCode == Keys.Escape)
            {
                resetAll();
                txtPlayerName.Text = "";
            }
        }

        public void setTotal()
        {
            Skill total = pd.getTotal();
            lblOverallRank.Text = total.Rank.ToString();
            lblOverallLevel.Text = total.Level.ToString();
            lblOverallExp.Text = total.Experience.ToString();
        }

        public void setAttack()
        {
            Skill attack = pd.getAttack();
            lblAttackRank.Text = attack.Rank.ToString();
            lblAttackLevel.Text = attack.Level.ToString();
            lblAttackExp.Text = attack.Experience.ToString();
        }

        public void setDefence()
        {
            Skill defence = pd.getDefence();
            lblDefenceRank.Text = defence.Rank.ToString();
            lblDefenceLevel.Text = defence.Level.ToString();
            lblDefenceExp.Text = defence.Experience.ToString();
        }

        public void setStrength()
        {
            Skill strength = pd.getStrength();
            lblStrRank.Text = strength.Rank.ToString();
            lblStrLvl.Text = strength.Level.ToString();
            lblStrExp.Text = strength.Experience.ToString();
        }

        public void resetAll()
        {
            lblOverallRank.Text = "";
            lblOverallLevel.Text = "";
            lblOverallExp.Text = "";

            lblAttackExp.Text = "";
            lblAttackLevel.Text = "";
            lblAttackRank.Text = "";

            lblStrExp.Text = "";
            lblStrLvl.Text = "";
            lblStrRank.Text = "";

            lblDefenceExp.Text = "";
            lblDefenceLevel.Text = "";
            lblDefenceRank.Text = "";

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://headlezz.dk");
        }
    }
}
