using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DataTypes
{
    interface IContest
    {
        ICompetitor[] getCompetitor();
        void updateScore(int player, int new_score);
    }
}
