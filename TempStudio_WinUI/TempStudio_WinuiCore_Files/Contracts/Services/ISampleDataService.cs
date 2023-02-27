using TempStudio_WinUI.Core.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace TempStudio_WinUI.Core.Contracts.Services;

// Remove this class once your pages/features are using your data.
public interface ISampleDataService
{
    Task<IEnumerable<SampleOrder>> GetListDetailsDataAsync();
}
