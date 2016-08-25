using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagGame
{
    class GameBoxVsCircle
    {
        public List<IPlayer> Players { get; private set; }
        private List<Box> playersBox;
        private List<Circle> playerCircle;

        public GameBoxVsCircle()
        {
            Players = new List<IPlayer>();
            playersBox = new List<Box>();
            playerCircle = new List<Circle>();
        }

        public void AddGamer(IPlayer p)
        {
            Players.Add(p);
            if (p is Box)
                playersBox.Add((Box)p);
            if (p is Circle)
                playerCircle.Add((Circle)p);
        }

        public void Step()
        {
            runAll();
            findIntersect();
        }

        private void runAll()
        {
            foreach (IPlayer p in Players)
                p.Run();
        }

        private void findIntersect()
        {
            foreach (Box b in playersBox)
            {
                foreach (Circle c in playerCircle)
                {
                    if (b.Touching(c))
                    {
                        Box newB = new Box(c.CenterC.X - c.RadiusC, c.CenterC.Y - c.RadiusC, c.RadiusC*2, c.RadiusC*2, c.SX, c.SY);
                        Players.Remove(c);
                        playerCircle.Remove(c);
                        Players.Add(newB);
                        playersBox.Add(newB);
                        return;
                    }
                }
            }
        }
    }
}
