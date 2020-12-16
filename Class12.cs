using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace RussianRGun
{
    class Class12
    {

        
        string message;
        SoundPlayer load = new SoundPlayer(RussianRGun.Properties.Resources.loadp);
        public string loadbtn( out int chanc)
        {
            
            chanc = 2;

           
            message = "Bullet is loaded ..Spin Chamber";
           
            load.Play();

            return message;
           
        }

       
        
    }
}
