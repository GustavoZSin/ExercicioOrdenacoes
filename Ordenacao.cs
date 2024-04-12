using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteOrdenacao
{
    public class Ordenacao
    {//Ao invés de retornar um vetor, deve retornar lista duplamente encadeada
        public int[]? NumArray { get; set; }
        //Ao invés de retornar um vetor, deve retornar lista duplamente encadeada
        public int[] SelectionSort()
        {
            var arrayLength = NumArray.Length;
            for (int i = 0; i < arrayLength - 1; i++)
            {
                var smallestVal = i;
                for (int j = i + 1; j < arrayLength; j++)
                {
                    if (NumArray[j] < NumArray[smallestVal])
                    {
                        smallestVal = j;
                    }
                }
                var tempVar = NumArray[smallestVal];
                NumArray[smallestVal] = NumArray[i];
                NumArray[i] = tempVar;
            }
            return NumArray;
        }
    }
}
