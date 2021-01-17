namespace Function
{
    public class InverseCrossfadeNode : CombinerNodeBase
    {
        protected override float CombineSamples(float sampleX, float sampleY, float percentage)
        {
            return percentage * sampleX + (1 - percentage) * sampleY;
        }
    }
}