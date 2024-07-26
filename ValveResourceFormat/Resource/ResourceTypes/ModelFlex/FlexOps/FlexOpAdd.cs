namespace ValveResourceFormat.ResourceTypes.ModelFlex.FlexOps
{
    public class FlexOpAdd : FlexOp
    {
        public FlexOpAdd(float data) : base(data) { }

        public override void Run(in FlexRuleContext context)
        {
            var v1 = context.Stack.Pop();
            var v2 = context.Stack.Pop();

            context.Stack.Push(v2 + v1);
        }
    }
}
