using Services.Interfaces;
using UnityEngine;

namespace Services
{
    public class Math : IMath
    {
        public float Sqrt(float number) => Mathf.Sqrt(number);
        public float Abs(float number) => Mathf.Abs(number);
    }
}