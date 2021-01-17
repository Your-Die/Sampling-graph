using UnityEngine;

namespace Noise
{
    public interface INoise
    {
        float Sample(float x, float y);
    }

    public static class NoiseExtensions
    {
        public static float Sample(this INoise noise, Vector2 input)
        {
            return noise.Sample(input.x, input.y);
        }
    }
}