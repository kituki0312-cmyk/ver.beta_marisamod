using BaseLib.Abstracts;
using Godot;

namespace marisamod.Scripts.PatchesNModels;

public class MarisaRelicPool : CustomRelicPoolModel
{
    // 蜊｡豎逧・・驥丞崟譬・ょ刈霓ｽ霍ｯ蠕・ｸｺ窶徨es://images/atlases/ui_atlas.sprites/card/energy_{EnergyColorName}.tres窶昴・    //public override string EnergyColorName => "marisa";

    public override string BigEnergyIconPath => "res://marisamod/images/ui/cardOrb.png";

    public override string TextEnergyIconPath => "res://marisamod/images/ui/energyOrb-lighter.png";

    public override Color LabOutlineColor => new(0f, 0.1f, 0.5f);
}

