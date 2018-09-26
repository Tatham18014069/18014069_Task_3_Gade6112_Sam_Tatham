using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS_game
{
    class GameEngine
    {
        Map m = new Map();

        public GameEngine()
        {
        }

        private void CombatCheck()
        {
            for (int i = 0; i <= 40; i++)
            {
                {

                }
            }
        }

        private void CombatContinue()
        {

        }

        private void CombatStart()
        {

        }

        private void CombatDisingage()
        {

        }

        public void initialiseMap()
        {
            m.initialiseMap();
        }

        public void Load()
        {
            m.ReadFactoryBuilding();
            m.ReadResourceBuilding();
            m.ReadRangedUnit();
            m.ReadMeleeUnit();
        }

        public void Save()
        {
             m.Save();
        }
    }
}
