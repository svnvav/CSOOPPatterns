namespace CSOOPPatterns.Behavioral.Mediator
{
    public abstract class BaseComponent
    {
        protected IMediator _mediator;

        public BaseComponent(IMediator mediator)
        {
            _mediator = mediator;
        }

        public abstract void DoStuff();
    }
}