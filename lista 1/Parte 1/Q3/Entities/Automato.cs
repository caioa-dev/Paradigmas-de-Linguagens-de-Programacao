using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3.Entities
{
    internal class Automato
    {
        public State State { get; internal set; } = State.q0;
        public Automato()
        {
        }

        public void UpdateState(char c)
        {
            if (c == 'a' || c == 'b')
            {
                switch (c)
                {
                    case 'a':
                        if (State == State.q0)
                        {
                            State = State.q1;
                            break;
                        }
                        else if (State == State.q1)
                        {
                            State = State.qf;
                            break;
                        }
                        else if (State == State.q2)
                        {
                            State = State.q1;
                            break;
                        }
                        break;

                    case 'b':
                        if (State == State.q0)
                        {
                            State = State.q2;
                            break;
                        }
                        else if (State == State.q1)
                        {
                            State = State.q2;
                            break;
                        }
                        else if (State == State.q2)
                        {
                            State = State.qf;
                            break;
                        }
                        break;

                    default:
                        break;
                }
            }
        }

        public bool ReconhecidoPeloAutomato(char[] cadeia)
        {
            foreach (char c in cadeia)
                UpdateState(c);

            return State == State.qf;
        }
    }
}
