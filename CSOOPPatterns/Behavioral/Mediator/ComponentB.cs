namespace CSOOPPatterns.Behavioral.Mediator
{
    public class ComponentB : BaseComponent
    {
        public ComponentB(IMediator mediator) : base(mediator)
        {
        }

        public override void DoStuff()
        {
            _mediator.Notify(this);
        }
    }
}