namespace Noise
{
    public class NullNoise : INoise
    {
        public float Sample(float x, float y) => 0;
    }
}