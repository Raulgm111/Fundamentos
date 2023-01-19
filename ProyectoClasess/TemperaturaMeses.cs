using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClasess
{

    public class TemperaturaMeses
    {
        Random random = new Random();
        private int _Temp1;
        private int _Temp2;
        public int Temp1 {
            get
            {
                return _Temp1;
            }
            set
            {
                _Temp1 = random.Next(-20, 50);
            }
        }
        public int Temp2
        {
            get
            {
                return _Temp2;
            }
            set
            {
                _Temp2 = random.Next(-20, 50);
            }
        }

        //public int GetMaximaTmeperatura(int temp1,int temp2)
        //{
        //    if (temp1 > temp2) {
        //        return this.Temp1;
        //    }

        //}



    }
}
