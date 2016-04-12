using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamesTore.Repository
{
    interface IFactory<T1, T2>
    {
        T2 ToDto(T1 objectIn);
        T1 FromDto(T2 objectIn);
        IEnumerable<T2> ToDto(IEnumerable<T1> objectIn);
        IEnumerable<T1> FromDto(IEnumerable<T2> objectIn);
    }
}
