using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagGame
{
    class GameCatch
    {
        public List<IPlayer> players { get; private set; }
        IPlayer leader;
        IPlayer prevPlayer;

        public GameCatch()
        {
            players = new List<IPlayer>();
            leader = null;
            prevPlayer = null;
        }

        public void AddGamer(IPlayer p)
        {
            players.Add(p);
            SetNewLeader(p);
        }

        public void Step()
        {
            runAll();
            FindNewLeader();
        }

        private void FindNewLeader()
        {
            if (leader == null)
                return;
            foreach (IPlayer p in players)
            {
                if (!leader.Equals(p) && !prevPlayer.Equals(p))
                    if (leader.Touching(p))
                    {
                        SetNewLeader(p);
                        return;
                    }
            }
        }

        void runAll()
        {
            foreach (IPlayer p in players)
                p.Run();
        }

        private void SetNewLeader(IPlayer p)
        {
            if (leader != null)
            {
                prevPlayer = leader;
                leader.NoTaggedIt();
            }
            leader = p;
            leader.TaggedIt();
        }
    }
}
