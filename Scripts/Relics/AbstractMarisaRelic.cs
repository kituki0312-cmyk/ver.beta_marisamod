using BaseLib.Abstracts;
using BaseLib.Utils;
using marisamod.Scripts.PatchesNModels;

namespace marisamod.Scripts.Relics;

[Pool(typeof(MarisaRelicPool))]
public abstract class AbstractMarisaRelic : CustomRelicModel
{
    // ¬??
    public override string PackedIconPath => $"res://marisamod/images/relics/{Id.Entry.ToLowerInvariant()}.png";
    // ?Šf??
    protected override string PackedIconOutlinePath => $"res://marisamod/images/relics/{Id.Entry.ToLowerInvariant()}.png";
    // ‘å??
    protected override string BigIconPath => $"res://marisamod/images/relics/{Id.Entry.ToLowerInvariant()}.png";
}
