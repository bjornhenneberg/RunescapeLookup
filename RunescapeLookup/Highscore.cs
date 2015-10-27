using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RunescapeLookup
{
    class Highscore
    {
        List<Skill> playerData = new List<Skill>();

        public Highscore()
        {
            
        }

        public void emptyData()
        {
            playerData.Clear();
        }

        public List<Skill> getPlayerDataList()
        {
            return playerData;
        }

        public void getPlayerData(string url)
        {
            WebClient client = new WebClient();
            string reply = client.DownloadString(url);

            String[] array = reply.Split(null);

            for (int i = 0; i < 27; i++)
            {
                string[] data = array[i].Split(',');

                Skill skill = new Skill();

                skill.Rank = int.Parse(data[0]);
                skill.Level = int.Parse(data[1]);
                skill.Experience = int.Parse(data[2]);
                
                playerData.Add(skill);
            }
        }

        public Skill getTotal()
        {
            return playerData[0];
        }

        public Skill getAttack()
        {
            return playerData[1];
        }

        public Skill getDefence()
        {
            return playerData[2];
        }

        public Skill getStrength()
        {
            return playerData[3];
        }

        public Skill getConstitution()
        {
            return playerData[4];
        }

        public Skill getRanged()
        {
            return playerData[5];
        }

        public Skill getPrayer()
        {
            return playerData[6];
        }

        public Skill getMagic()
        {
            return playerData[7];
        }

        public Skill getCooking()
        {
            return playerData[8];
        }

        public Skill getWoodcutting()
        {
            return playerData[9];
        }

        public Skill getFletching()
        {
            return playerData[10];
        }

        public Skill getFishing()
        {
            return playerData[11];
        }

        public Skill getFiremaking()
        {
            return playerData[12];
        }

        public Skill getCrafting()
        {
            return playerData[13];
        }

        public Skill getSmithing()
        {
            return playerData[14];
        }

        public Skill getMining()
        {
            return playerData[15];
        }

        public Skill getHerblore()
        {
            return playerData[16];
        }

        public Skill getAgility()
        {
            return playerData[17];
        }

        public Skill getThieving()
        {
            return playerData[18];
        }

        public Skill getSlayer()
        {
            return playerData[19];
        }

        public Skill getFarming()
        {
            return playerData[20];
        }

        public Skill getRunecrafting()
        {
            return playerData[21];
        }

        public Skill getHunter()
        {
            return playerData[22];
        }

        public Skill getConstruction()
        {
            return playerData[23];
        }

        public Skill getSummoning()
        {
            return playerData[24];
        }

        public Skill getDungeoneering()
        {
            return playerData[25];
        }

        public Skill getDivination()
        {
            return playerData[26];
        }
    }
}
