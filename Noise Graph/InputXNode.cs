namespace Noise
{
    public class InputXNode : NoiseNode
    {
        public override float Sample(float x, float y)
        {
            return x;
        }
    }
}