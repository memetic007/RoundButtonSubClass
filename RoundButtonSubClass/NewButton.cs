using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundButtonSubClass
{
    interface IButton
    {

        Boolean IsAttacker
        {
            get;
            set;
        }
        Boolean IsDefender
        {
            get;
            set;
        }

    }

    class NewButton : GaryPerkin.UserControls.Buttons.RoundButton , IButton
    {
        private Boolean attackerFlag = false;
        private Boolean defenderFlag = false;

        public Boolean IsAttacker
            {
                get
                {
                    return attackerFlag;
                }
                set
                {
                    attackerFlag = value;
                }

            }
            public Boolean IsDefender
            {
                get
                {
                    return defenderFlag;
                }
                set
                {
                    defenderFlag = value;
                }

            }

        }
}
