using CertificateCreator.Views;
using Microsoft.Extensions.Logging;
using WinFormsMVP.NET;

namespace CertificateCreator.Presenters
{
    public class MainPresenter : Presenter<IMainView>
    {

        public MainPresenter(IMainView view, ILogger logger) 
            : base(view)
        {
            logger.LogInformation(new EventId(1, "Presenter construction."), "Presenter {presenter}", nameof(MainPresenter));
        }
    }
}
