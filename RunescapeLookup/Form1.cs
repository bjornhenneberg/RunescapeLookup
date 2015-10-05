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
        }

        public void iniData()
        {
            setTotal();
            setAttack();
        }

        private void btnLookup_Click(object sender, EventArgs e)
        {

            pd.emptyData();
            resetAll();
            string url = "http://services.runescape.com/m=hiscore/index_lite.ws?player=" + txtPlayerName.Text;

            pd.getPlayerData(url);

            iniData();
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

        public void resetAll()
        {
            lblOverallRank.Text = "";
            lblOverallLevel.Text = "";
            lblOverallExp.Text = "";
        }
    }
}
