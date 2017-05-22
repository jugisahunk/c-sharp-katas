using System;
using System.Collections;
using System.Linq;

namespace BinaryNumbers
{
	public class BinaryNumbers
	{
        IEnumerable _powersOfTwo;

        public BinaryNumbers(){
            _powersOfTwo = Enumerable.Range(0,31).Reverse();
        }
		public string IntegerToBinary(int i)
        {
            /*string binaryResult = String.Empty;
            double remainder = i;

            foreach(int power in _powersOfTwo){
                double product = Math.Pow(2, power);

                if(product <= remainder){
                    binaryResult += "1";
                    remainder -= product;
                }
                else{
                    binaryResult += "0";
                }
            }

            return binaryResult;*/

            return Convert.ToString(i, 2);
		}

		public int BinaryToInteger(string s)
		{
            return Convert.ToInt32(s, 2);
		}
	}
}