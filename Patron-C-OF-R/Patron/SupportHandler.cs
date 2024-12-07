namespace Patron_C_OF_R.Patron
{
    public abstract class SupportHandler
    {
        protected SupportHandler? NextHandler;

        public void SetNext(SupportHandler handler) => NextHandler = handler;

        public abstract void HandleRequest(string request);
    }
}
