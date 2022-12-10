using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCADA_MP2.Entity.DataMapping
{
    public class Page_Home
    {
        public float FlowInTotal { get; set; }
        public float FlowInCap { get; set; }
        public float FlowOutTotal { get; set; }
        public float FlowOutCap { get; set; }
        public float CodIndex { get; set; }
        public float TssIndex { get; set; }
        public float PHIndex { get; set; }
        public float AmoniIndex { get; set; }
        public float TemperatureIndex { get; set; }
        public float ColorIndex { get; set; }

        public Entity.Motor.Motor mtk01 { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor mtk02 { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor mtk03 { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor mtetn {get; set;} = new Motor.Motor();
        public Entity.Motor.Motor dpetn { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor dp03 {get; set;} = new Motor.Motor();
        public Entity.Motor.Motor mt03 { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor mkt1 { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor mkt2 { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor mkt3 { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor mt05 { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor dp05 { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor dp06_1 { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor mt06_1 { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor bb1 { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor bb2 { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor p0101 { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor p0102 { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor p0103 { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor bs02a { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor p0201 { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor p0202 { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor wp02a { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor wp02b { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor sm01 { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor sm02 { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor sm03 { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor sm04 { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor sm05 { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor sm06 { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor sm07 { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor sm08 { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor th1 { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor th2 { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor th3 { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor gb1 { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor mc04 { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor mc03 { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor dp04a { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor dp04b { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor dp03a { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor dp03b { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor dp05a { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor dp05b { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor dp06a { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor dp06b { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor mi03 { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor mi04a { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor mi04b { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor ms05 { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor ab06a { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor ab06b { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor ab06c { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor ms07 { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor mt02 { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor dp02 { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor mt04 { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor dp04 { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor mt02b { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor mt02a { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor mt01 { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor sp10 { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor dp04a_1 { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor dp04a_2 { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor ms09 { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor sp05a { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor sp05b { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor sp07a { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor sp07b { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor dp07a { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor dp07b { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor sp11 { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor ggb { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor mc09 { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor dp09a { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor dp09b { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor dp01 { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor dp06_2 { get; set; } = new Motor.Motor();
        public Entity.Motor.Motor mt06_2 { get; set; } = new Motor.Motor();

        public Entity.Sensor.Phao.Phao hl101 { get; set; } = new Sensor.Phao.Phao();
        public Entity.Sensor.Phao.Phao ml101 { get; set; } = new Sensor.Phao.Phao();
        public Entity.Sensor.Phao.Phao ll101 { get; set; } = new Sensor.Phao.Phao();
        public Entity.Sensor.Phao.Phao hl201 { get; set; } = new Sensor.Phao.Phao();
        public Entity.Sensor.Phao.Phao ll201 { get; set; } = new Sensor.Phao.Phao();
        public Entity.Sensor.Phao.Phao hl10 { get; set; } = new Sensor.Phao.Phao();
        public Entity.Sensor.Phao.Phao hl05 { get; set; } = new Sensor.Phao.Phao();
        public Entity.Sensor.Phao.Phao hl07 { get; set; } = new Sensor.Phao.Phao();
    }
}
