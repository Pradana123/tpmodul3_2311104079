using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul3_2311104079
{
    class DoorMachine
    {
        private enum State { Terkunci, Terbuka }

        private State currentState;



        public DoorMachine()

        {

            currentState = State.Terkunci;

            Console.WriteLine("Pintu terkunci");

        }



        public void BukaPintu()

        {

            if (currentState == State.Terkunci)

            {

                currentState = State.Terbuka;

                Console.WriteLine("Pintu tidak terkunci");

            }

        }



        public void KunciPintu()

        {

            if (currentState == State.Terbuka)

            {

                currentState = State.Terkunci;

                Console.WriteLine("Pintu terkunci");

            }

        }

    }
}
