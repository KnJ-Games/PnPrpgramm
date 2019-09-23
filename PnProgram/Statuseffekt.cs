using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PnProgram
{
    public class Statuseffekt
    {
        Boolean STATUS = false;
        String BEZEICHNUNG;
        Boolean WIRDANGEZEIGT;

        public Statuseffekt(String bezeichnung, Boolean status, Boolean wirdAngezeigt)
        {
            BEZEICHNUNG = bezeichnung;
            STATUS = status;
            WIRDANGEZEIGT = wirdAngezeigt;
        }





        public Boolean getSTATUS()
        {
            return STATUS;
        }

        public void setSTATUS(Boolean STATUS)
        {
            this.STATUS = STATUS;
        }

        public String getBEZEICHNUNG()
        {
            return BEZEICHNUNG;
        }

        public void setBEZEICHNUNG(String BEZEICHNUNG)
        {
            this.BEZEICHNUNG = BEZEICHNUNG;
        }

        public Boolean getWIRDANGEZEIGT()
        {
            return WIRDANGEZEIGT;
        }

        public void setWIRDANGEZEIGT(Boolean WIRDANGEZEIGT)
        {
            this.WIRDANGEZEIGT = WIRDANGEZEIGT;
        }
    }
}
