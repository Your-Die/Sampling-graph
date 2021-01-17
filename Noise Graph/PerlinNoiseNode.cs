namespace Noise
{
    using UnityEngine;

    public class PerlinNoiseNode : NoiseNode
    {
        [SerializeField] private int octaveCount = 1;

        [SerializeField] private float persistence;
        
        public override float Sample(float x, float y)
        {
            var total     = 0f;
            var frequency = 1f;
            var amplitude = 1f;
            var maxValue  = 0f;

            for (var octave = 0; octave < this.octaveCount; octave++)
            {
                var perlin = Mathf.PerlinNoise(x * frequency, y * frequency);
             
                total += perlin * amplitude;

                maxValue  += amplitude;
                amplitude *= this.persistence;
                frequency *= 2;
            }

            return total / maxValue;
        }
    }
}