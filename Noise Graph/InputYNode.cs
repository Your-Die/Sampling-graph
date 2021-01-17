namespace Noise
{
    public class InputYNode : NoiseNode
    {
        public override float Sample(float x, float y)
        {
            return y;
        }
    }
}