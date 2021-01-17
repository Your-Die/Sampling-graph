using System;

namespace Function
{
    [Serializable]
    public class NullFunction : IMathFunction
    {
        public float SampleFunction(float percentage) => percentage;
    }
}