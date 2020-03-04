namespace CSOOPPatterns.Structural.Adapter
{
    public class Adapter : IAdapterInyerface
    {
        private AdapterService _adapterService;

        public Adapter(AdapterService adapterService)
        {
            _adapterService = adapterService;
        }

        public string GetShit()
        {
            return _adapterService.GetServiceShit().ToString();
        }
    }
}