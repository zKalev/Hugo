namespace Hugo.Helpers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Players;

    public interface IEffect
    {
        void Apply(IPlayer player);
    }
}
