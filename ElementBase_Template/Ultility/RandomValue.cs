using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementBase_Template.Ultility
{
    internal class RandomValue
    {
        #region FIELDS
        public float value_temp;
        #endregion
        public float random_float(float min, float max)
        {
            Random random = new Random();
            value_temp = (0.1f)*(random.Next(0, 10)); // 0.1 - 0.9
            float value;
            value = min + (max - min) * value_temp;
            return value;
        }

        public int random_int(int min, int max)
        {
            Random random = new Random();
            value_temp = random.Next(min, max); // range from min - max
            int value;
            value = min + Convert.ToInt32(value_temp);
            return value;
        }
    }
}
