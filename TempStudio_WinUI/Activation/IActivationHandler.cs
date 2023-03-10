using System.Threading.Tasks;

namespace TempStudio_WinUI.Activation;

public interface IActivationHandler
{
    bool CanHandle(object args);

    Task HandleAsync(object args);
}
