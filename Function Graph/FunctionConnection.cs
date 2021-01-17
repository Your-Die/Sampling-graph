using System;

namespace Function
{
    [Serializable]
    public class FunctionConnection : NodeConnection<IMathFunction>, IMathFunction
    {
        private static NullFunction nullFunction = new NullFunction();

        protected override IMathFunction Null => nullFunction;
        
        public float SampleFunction(float percentage) => this.Source.SampleFunction(percentage);
    }
}