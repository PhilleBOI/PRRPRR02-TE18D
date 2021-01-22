using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Labb
{
    class Owner
    {
        string _owner;

        public void TransferOwnership(string owner)
        {
            _owner = owner;
        }

    }
}
