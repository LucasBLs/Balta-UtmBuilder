using UtmBuilder.Core.ValueObjects;

namespace UtmBuilder.Core;
public class Utm
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="url">URL (Web)site Link</param>
    /// <param name="campaign">Campaign Details</param>
    public Utm(Url url, Campaign campaign)
    {
        Url = url;
        Campaign = campaign;
    }

    /// <summary>
    /// URL (Web)site Link
    /// </summary>
    public Url Url { get; }
    /// <summary>
    /// Campaign Details
    /// </summary>
    public Campaign Campaign { get; }
}