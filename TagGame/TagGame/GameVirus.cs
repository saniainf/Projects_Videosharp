using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagGame
{
    class GameVirus
    {
        public List<IPlayer> players { get; private set; }
        private List<IPlayer> virused;

        public GameVirus()
        {
            players = new List<IPlayer>();
            virused = new List<IPlayer>();
        }

        public void AddGamer(IPlayer p)
        {
            players.Add(p);
            SetNewVirus(p);
        }

        public void Step()
        {
            RunAll();
            FindNewVirus();
        }

        private void RunAll()
        {
            foreach (IPlayer p in players)
            {
                if (!virused.Contains(p))
                    p.Run();
            }
        }

        public void SetNewVirus(IPlayer player)
        {
            virused = new List<IPlayer>();
            foreach (IPlayer p in players)
            {
                p.NoTaggedIt();
            }
            player.TaggedIt();
            virused.Add(player);
        }

        private void FindNewVirus()
        {
            foreach (IPlayer p in players)
                if (!virused.Contains(p))
                {
                    if (virused.Count == players.Count - 1)
                    {
                        SetNewVirus(p);
                        break;
                    }
                    foreach (IPlayer v in virused)
                    {
                        if (p.Touching(v))
                        {
                            virused.Add(p);
                            p.TaggedIt();
                            break;
                        }
                    }
                }
        }
    }
}
