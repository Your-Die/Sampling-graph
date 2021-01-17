namespace Function
{
    public class CrossfadeNode : CombinerNodeBase
    {
        protected override float CombineSamples(float sampleX, float sampleY, float percentage)
        {
            return percentage * sampleY  + (1 - percentage) * sampleX;
        }
    }
}