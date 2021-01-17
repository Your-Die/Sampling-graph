namespace Function
{
    public class InputNode : FunctionNode
    {
        public override float SampleFunction(float percentage)
        {
            return percentage;
        }
    }
}