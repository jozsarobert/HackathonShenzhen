using Reelables.Api.Fake.Models;

namespace Reelables.Api.Fake.Services;

public interface IAssetService
{
    public Asset GetAsset(string id);
}