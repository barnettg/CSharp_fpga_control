using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiI2cControlCsharp
{
    class Notes
    {
        // to do:
        // getting \n on received data beginning - can use Trim to remove but need to find where it is comming from



        //MCP4725DAC
        // send DWxxx<cr>   set DAC to hex value xxx
        //      rec back dwxxx
        //
        //AMC7812
        //   send AWRRDDDD<cr>    write register 8-bit hex RR with 16-bit hex  DDDD
        //       rec back awrrdddd
        //   send ARrr<cr>    read 16-bit register rr (8-bit hex)
        //      rec back arRRDDDD 16-bit hex  DDDD
        //
        //   send ADNDDD<cr>  write DAC N(4-bit hex) with 12-bit hex  DDD
        //    rec back adnddd
        //
        //   send AAN<cr>  read ADC N(4-bit hex) 
        //    rec back aanDDD     12-bit hex  DDD
        //
        //   send AGWDD<cr>  write GPIO DD(8-bit hex) 
        //    rec back agwdd   
        //
        //   send AGR<cr>  read GPIO 
        //    rec back agrdd   DD(8-bit hex) 
        //
        //   send AI<cr>  initialize the AMC7812 with the test fixtur default configuraton
        //    rec back ai  
        //
        //
        //MPC23017
        //   send GWNRRDD<cr>  write device N(0-5) reg RR(8-bit hex)  with data  DD(8-bit hex) 
        //    rec back gwnrrdd   
        //
        //   send GRNRR<cr>  read device N(0-5) reg RR(8-bit hex)  
        //    rec back grnrrdd   with data  DD(8-bit hex) 
        //
        //   send GIN<cr>  initialize device N(0-5) with the test fixture default configuraton
        //    rec back gin
        //
        //   send GARN<cr>  read device N(0-5) port A
        //    rec back garnDD   with data  DD(8-bit hex) 
        //
        //   send GBRN<cr>  read device N(0-5) port B
        //    rec back gbrnDD   with data  DD(8-bit hex) 
        //
        //   send GAWNDD<cr>  write device N(0-5) port A with data  DD(8-bit hex) 
        //    rec back gawnDD   
        //
        //   send GBWNDD<cr>  read device N(0-5) port B with data  DD(8-bit hex) 
        //    rec back gbwnDD  



        // to do:

    }
}
