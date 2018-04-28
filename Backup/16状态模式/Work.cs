using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _16状态模式
{
   public class Work
    {
        State s = null;
        public Work() 
        {
            s =new  ForeNoonState();
        }

        public bool Finsh { get; set; }
        public int Hour { get; set; }

        public void SetState(State state) 
        {
            this.s = state;
        }


        public void WriteProgram() 
        {
            s.WirteProgram(this);
        }
    }

}
