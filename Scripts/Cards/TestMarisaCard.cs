// using BaseLib.Utils;
// using marisamod.Scripts.Cards.Abstract;
// using marisamod.Scripts.PatchesNModels;
// using MegaCrit.Sts2.Core.Commands;
// using MegaCrit.Sts2.Core.Entities.Cards;
// using MegaCrit.Sts2.Core.GameActions.Multiplayer;
// using MegaCrit.Sts2.Core.Localization.DynamicVars;
// using MegaCrit.Sts2.Core.ValueProps;
//
// namespace marisamod.Scripts.Cards;
//
// [Pool(typeof(MarisaCardPool))]
// public class TestMarisaCard : AbstractMarisaCard
// {
//     // 蝓ｺ遑閠苓・
//     private const int energyCost = 0;
//
//     // 蜊｡迚檎ｱｻ蝙・//     private const CardType type = CardType.Attack;
//
//     // 蜊｡迚檎ｨ譛牙ｺｦ
//     private const CardRarity rarity = CardRarity.Common;
//
//     // 逶ｮ譬・ｱｻ蝙具ｼ・nyEnemy陦ｨ遉ｺ莉ｻ諢乗阜莠ｺ・・//     private const TargetType targetType = TargetType.AnyEnemy;
//
//     // 譏ｯ蜷ｦ蝨ｨ蜊｡迚悟崟驩ｴ荳ｭ譏ｾ遉ｺ
//     private const bool shouldShowInCardLibrary = true;
//
//     // 蜊｡迚檎噪蝓ｺ遑螻樊ｧ・井ｾ句ｦりｿ咎㈹譏ｯ12轤ｹ莨､螳ｳ・・//     protected override IEnumerable<DynamicVar> CanonicalVars =>
//     [
//         new DamageVar(12, ValueProp.Move),
//         new CardsVar(1)
//     ];
//
//     public TestMarisaCard() : base(energyCost, type, rarity, targetType)
//     {
//     }
//
//     // 謇灘・譌ｶ逧・譜譫憺ｻ霎・//     protected override async Task OnPlay(PlayerChoiceContext choiceContext, CardPlay cardPlay)
//     {
//         ArgumentNullException.ThrowIfNull(cardPlay.Target);
//         await DamageCmd.Attack(DynamicVars.Damage.BaseValue) // 騾謌蝉ｼ､螳ｳ・梧焚蛟ｼ譚･貅蝉ｺ主今迚檎噪蝓ｺ遑莨､螳ｳ螻樊ｧ
//             .FromCard(this, cardPlay) // 莨､螳ｳ譚･貅蝉ｺ手ｿ吝ｼ蜊｡迚・//             .Targeting(cardPlay.Target) // 莨､螳ｳ逶ｮ譬・弍邇ｩ螳ｶ騾画叫逧・岼譬・//             .Execute(choiceContext);
//         await CardPileCmd.Draw(choiceContext, DynamicVars.Cards.BaseValue, Owner);
//     }
//
//     // 蜊・ｺｧ蜷守噪謨域棡騾ｻ霎・//     protected override void OnUpgrade()
//     {
//         DynamicVars.Damage.UpgradeValueBy(4); // 蜊・ｺｧ蜷主｢槫刈4轤ｹ莨､螳ｳ
//         DynamicVars.Cards.UpgradeValueBy(1);
//     }
// }

