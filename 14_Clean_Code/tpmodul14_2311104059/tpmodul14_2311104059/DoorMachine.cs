using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul14_2311104059
{
    public class DoorMachine
    {
        private enum State { Terkunci, Terbuka }

        private State currentState;

        public DoorMachine()
        {
            currentState = State.Terkunci;
            TampilkanStatus();
        }

        public void Toggle()
        {
            if (currentState == State.Terkunci)
                currentState = State.Terbuka;
            else
                currentState = State.Terkunci;

            TampilkanStatus();
        }

        private void TampilkanStatus()
        {
            if (currentState == State.Terkunci)
                Console.WriteLine("Pintu terkunci");
            else
                Console.WriteLine("Pintu tidak terkunci");
        }
    }

}
