using Function;

namespace Noise
{
    using System;

    [Serializable]
    public class NoiseConnection : NodeConnection<INoise>, INoise
    {
        private static readonly NullNoise NullNoise = new NullNoise();

        protected override INoise Null => NullNoise;
        public float Sample(float x, float y) => this.Source.Sample(x, y);

        public object SampleFunction(float f, float f1)
        {
            throw new NotImplementedException();
        }
    }
}