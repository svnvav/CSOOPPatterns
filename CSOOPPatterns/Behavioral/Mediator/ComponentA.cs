namespace CSOOPPatterns.Behavioral.Mediator
{
    public class ComponentA : BaseComponent
    {
        public ComponentA(IMediator mediator) : base(mediator)
        {
        }

        public override void DoStuff()
        {
            _mediator.Notify(this);
        }
    }
}