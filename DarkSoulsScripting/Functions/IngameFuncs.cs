using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DarkSoulsScripting.Hook;

namespace DarkSoulsScripting
{
    public static partial class IngameFuncs
    {
        public static bool ActionEnd(int ChrID)
            => Call<bool>(FuncAddress.ActionEnd, ChrID);

        public static bool AddActionCount(int ChrID, int b)
            => Call<bool>(FuncAddress.AddActionCount, ChrID, b);

        public static int AddBlockClearBonus()
            => Call<int>(FuncAddress.AddBlockClearBonus);

        public static int AddClearCount()
            => Call<int>(FuncAddress.AddClearCount);

        public static int AddCorpseEvent(int a, int b)
            => Call<int>(FuncAddress.AddCorpseEvent, a, b);

        public static int AddCustomRoutePoint(int ChrID, int b)
            => Call<int>(FuncAddress.AddCustomRoutePoint, ChrID, b);

        public static int AddDeathCount()
            => Call<int>(FuncAddress.AddDeathCount);

        public static int AddEventGoal(int a, int b, float c, float d, float e, float f, float g, float h, float i, float j, float k)
            => Call<int>(FuncAddress.AddEventGoal, a, b, c, d, e, f, g, h, i, j, k);

        public static bool AddEventSimpleTalk(int a, int b)
            => Call<bool>(FuncAddress.AddEventSimpleTalk, a, b);

        public static bool AddEventSimpleTalkTimer(int a, int b)
            => Call<bool>(FuncAddress.AddEventSimpleTalkTimer, a, b);

        //public static _TYPE_ AddFieldInsFilter(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.AddFieldInsFilter, _ARGS_);

        //public static _TYPE_ AddGeneEvent(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.AddGeneEvent, _ARGS_);

        //public static _TYPE_ AddHelpWhiteGhost(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.AddHelpWhiteGhost, _ARGS_);

        //public static _TYPE_ AddHitMaskByBit(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.AddHitMaskByBit, _ARGS_);

        //public static _TYPE_ AddInfomationBuffer(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.AddInfomationBuffer, _ARGS_);

        //public static _TYPE_ AddInfomationBufferTag(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.AddInfomationBufferTag, _ARGS_);

        //public static _TYPE_ AddInfomationList(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.AddInfomationList, _ARGS_);

        //public static _TYPE_ AddInfomationListItem(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.AddInfomationListItem, _ARGS_);

        //public static _TYPE_ AddInfomationTimeMsgTag(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.AddInfomationTimeMsgTag, _ARGS_);

        //public static _TYPE_ AddInfomationTosBuffer(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.AddInfomationTosBuffer, _ARGS_);

        //public static _TYPE_ AddInfomationTosBufferPlus(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.AddInfomationTosBufferPlus, _ARGS_);

        //public static _TYPE_ AddInventoryItem(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.AddInventoryItem, _ARGS_);

        //public static _TYPE_ AddKillBlackGhost(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.AddKillBlackGhost, _ARGS_);

        //public static _TYPE_ AddQWC(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.AddQWC, _ARGS_);

        //public static _TYPE_ AddRumble(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.AddRumble, _ARGS_);

        //public static _TYPE_ AddTreasureEvent(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.AddTreasureEvent, _ARGS_);

        //public static _TYPE_ AddTrueDeathCount(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.AddTrueDeathCount, _ARGS_);

        //public static _TYPE_ BeginAction(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.BeginAction, _ARGS_);

        //public static _TYPE_ BeginLoopCheck(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.BeginLoopCheck, _ARGS_);

        //public static _TYPE_ CalcExcuteMultiBonus(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.CalcExcuteMultiBonus, _ARGS_);

        //public static _TYPE_ CalcGetCurrentMapEntityId(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.CalcGetCurrentMapEntityId, _ARGS_);

        //public static _TYPE_ CalcGetMultiWallEntityId(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.CalcGetMultiWallEntityId, _ARGS_);

        //public static _TYPE_ CamReset(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.CamReset, _ARGS_);

        //public static _TYPE_ CastPointSpell(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.CastPointSpell, _ARGS_);

        //public static _TYPE_ CastPointSpell_Horming(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.CastPointSpell_Horming, _ARGS_);

        //public static _TYPE_ CastPointSpellPlus(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.CastPointSpellPlus, _ARGS_);

        //public static _TYPE_ CastPointSpellPlus_Horming(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.CastPointSpellPlus_Horming, _ARGS_);

        //public static _TYPE_ CastTargetSpell(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.CastTargetSpell, _ARGS_);

        //public static _TYPE_ CastTargetSpellPlus(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.CastTargetSpellPlus, _ARGS_);

        //public static _TYPE_ ChangeGreyGhost(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.ChangeGreyGhost, _ARGS_);

        //public static _TYPE_ ChangeInitPosAng(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.ChangeInitPosAng, _ARGS_);

        //public static _TYPE_ ChangeModel(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.ChangeModel, _ARGS_);

        //public static _TYPE_ ChangeTarget(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.ChangeTarget, _ARGS_);

        //public static _TYPE_ ChangeThink(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.ChangeThink, _ARGS_);

        //public static _TYPE_ ChangeWander(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.ChangeWander, _ARGS_);

        //public static _TYPE_ CharacterAllAttachSys(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.CharacterAllAttachSys, _ARGS_);

        //public static _TYPE_ CharactorCopyPosAng(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.CharactorCopyPosAng, _ARGS_);

        //public static _TYPE_ CheckChrHit_Obj(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.CheckChrHit_Obj, _ARGS_);

        //public static _TYPE_ CheckChrHit_Wall(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.CheckChrHit_Wall, _ARGS_);

        //public static _TYPE_ CheckEventBody(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.CheckEventBody, _ARGS_);

        //public static _TYPE_ CheckEventChr_Proxy(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.CheckEventChr_Proxy, _ARGS_);

        //public static _TYPE_ CheckPenalty(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.CheckPenalty, _ARGS_);

        //public static _TYPE_ ChrDisableUpdate(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.ChrDisableUpdate, _ARGS_);

        public static int ChrFadeIn(int ChrID, float Duration, float Opacity)
            => Call<int>(FuncAddress.ChrFadeIn, ChrID, Duration, Opacity);

        public static int ChrFadeOut(int ChrID, float Duration, float Opacity)
            => Call<int>(FuncAddress.ChrFadeOut, ChrID, Duration, Opacity);

        //public static _TYPE_ ChrResetAnimation(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.ChrResetAnimation, _ARGS_);

        //public static _TYPE_ ChrResetRequest(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.ChrResetRequest, _ARGS_);

        //public static _TYPE_ ClearBossGauge(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.ClearBossGauge, _ARGS_);

        //public static _TYPE_ ClearMyWorldState(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.ClearMyWorldState, _ARGS_);

        //public static _TYPE_ ClearSosSign(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.ClearSosSign, _ARGS_);

        //public static _TYPE_ ClearTarget(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.ClearTarget, _ARGS_);

        //public static _TYPE_ CloseGenDialog(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.CloseGenDialog, _ARGS_);

        //public static _TYPE_ CloseMenu(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.CloseMenu, _ARGS_);

        //public static _TYPE_ CloseRankingDialog(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.CloseRankingDialog, _ARGS_);

        //public static _TYPE_ CloseTalk(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.CloseTalk, _ARGS_);

        //public static _TYPE_ CompleteEvent(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.CompleteEvent, _ARGS_);

        //public static _TYPE_ CreateCamSfx(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.CreateCamSfx, _ARGS_);

        //public static _TYPE_ CreateDamage_NoCollision(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.CreateDamage_NoCollision, _ARGS_);

        //public static _TYPE_ CreateEventBody(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.CreateEventBody, _ARGS_);

        //public static _TYPE_ CreateEventBodyPlus(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.CreateEventBodyPlus, _ARGS_);

        //public static _TYPE_ CreateHeroBloodStain(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.CreateHeroBloodStain, _ARGS_);

        //public static _TYPE_ CreateSfx(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.CreateSfx, _ARGS_);

        //public static _TYPE_ CreateSfx_DummyPoly(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.CreateSfx_DummyPoly, _ARGS_);

        //public static _TYPE_ CroseBriefingMsg(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.CroseBriefingMsg, _ARGS_);

        //public static _TYPE_ CustomLuaCall(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.CustomLuaCall, _ARGS_);

        //public static _TYPE_ CustomLuaCallStart(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.CustomLuaCallStart, _ARGS_);

        //public static _TYPE_ CustomLuaCallStartPlus(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.CustomLuaCallStartPlus, _ARGS_);

        //public static _TYPE_ DeleteCamSfx(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.DeleteCamSfx, _ARGS_);

        //public static _TYPE_ DeleteEvent(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.DeleteEvent, _ARGS_);

        //public static _TYPE_ DeleteObjSfxAll(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.DeleteObjSfxAll, _ARGS_);

        //public static _TYPE_ DeleteObjSfxDmyPlyID(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.DeleteObjSfxDmyPlyID, _ARGS_);

        //public static _TYPE_ DeleteObjSfxEventID(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.DeleteObjSfxEventID, _ARGS_);

        //public static _TYPE_ DisableCollection(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.DisableCollection, _ARGS_);

        //public static _TYPE_ DisableDamage(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.DisableDamage, _ARGS_);

        //public static _TYPE_ DisableHpGauge(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.DisableHpGauge, _ARGS_);

        //public static _TYPE_ DisableInterupt(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.DisableInterupt, _ARGS_);

        //public static _TYPE_ DisableMapHit(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.DisableMapHit, _ARGS_);

        //public static _TYPE_ DisableMove(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.DisableMove, _ARGS_);

        //public static _TYPE_ DivideRest(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.DivideRest, _ARGS_);

        //public static _TYPE_ EnableAction(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.EnableAction, _ARGS_);

        //public static _TYPE_ EnableGeneratorSystem(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.EnableGeneratorSystem, _ARGS_);

        //public static _TYPE_ EnableHide(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.EnableHide, _ARGS_);

        //public static _TYPE_ EnableInvincible(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.EnableInvincible, _ARGS_);

        //public static _TYPE_ EnableLogic(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.EnableLogic, _ARGS_);

        //public static _TYPE_ EnableObjTreasure(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.EnableObjTreasure, _ARGS_);

        //public static _TYPE_ EndAnimation(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.EndAnimation, _ARGS_);

        //public static _TYPE_ EraseEventSpecialEffect(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.EraseEventSpecialEffect, _ARGS_);

        //public static _TYPE_ EraseEventSpecialEffect_2(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.EraseEventSpecialEffect_2, _ARGS_);

        //public static _TYPE_ EventTagInsertString_forPlayerNo(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.EventTagInsertString_forPlayerNo, _ARGS_);

        //public static _TYPE_ ExcutePenalty(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.ExcutePenalty, _ARGS_);

        //public static _TYPE_ ForceChangeTarget(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.ForceChangeTarget, _ARGS_);

        //public static _TYPE_ ForceDead(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.ForceDead, _ARGS_);

        //public static _TYPE_ ForcePlayAnimation(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.ForcePlayAnimation, _ARGS_);

        //public static _TYPE_ ForcePlayAnimationStayCancel(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.ForcePlayAnimationStayCancel, _ARGS_);

        //public static _TYPE_ ForcePlayLoopAnimation(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.ForcePlayLoopAnimation, _ARGS_);

        //public static _TYPE_ ForceSetOmissionLevel(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.ForceSetOmissionLevel, _ARGS_);

        //public static _TYPE_ ForceUpdateNextFrame(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.ForceUpdateNextFrame, _ARGS_);

        //public static _TYPE_ GetBountyRankPoint(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.GetBountyRankPoint, _ARGS_);

        //public static _TYPE_ GetClearBonus(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.GetClearBonus, _ARGS_);

        //public static _TYPE_ GetClearCount(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.GetClearCount, _ARGS_);

        //public static _TYPE_ GetClearState(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.GetClearState, _ARGS_);

        //public static _TYPE_ GetCurrentMapAreaNo(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.GetCurrentMapAreaNo, _ARGS_);

        //public static _TYPE_ GetCurrentMapBlockNo(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.GetCurrentMapBlockNo, _ARGS_);

        //public static _TYPE_ GetDeathState(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.GetDeathState, _ARGS_);

        //public static _TYPE_ GetDistance(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.GetDistance, _ARGS_);

        //public static _TYPE_ GetEnemyPlayerId_Random(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.GetEnemyPlayerId_Random, _ARGS_);

        //public static _TYPE_ GetEventFlagValue(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.GetEventFlagValue, _ARGS_);

        //public static _TYPE_ GetEventGoalState(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.GetEventGoalState, _ARGS_);

        //public static _TYPE_ GetEventMode(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.GetEventMode, _ARGS_);

        //public static _TYPE_ GetEventRequest(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.GetEventRequest, _ARGS_);

        //public static _TYPE_ GetFloorMaterial(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.GetFloorMaterial, _ARGS_);

        //public static _TYPE_ GetGlobalQWC(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.GetGlobalQWC, _ARGS_);

        //public static _TYPE_ GetHeroPoint(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.GetHeroPoint, _ARGS_);

        //public static _TYPE_ GetHostPlayerNo(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.GetHostPlayerNo, _ARGS_);

        //public static _TYPE_ GetHp(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.GetHp, _ARGS_);

        //public static _TYPE_ GetHpRate(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.GetHpRate, _ARGS_);

        //public static _TYPE_ GetItem(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.GetItem, _ARGS_);

        //public static _TYPE_ GetLadderCount(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.GetLadderCount, _ARGS_);

        //public static _TYPE_ GetLastBlockId(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.GetLastBlockId, _ARGS_);

        //public static _TYPE_ GetLocalPlayerChrType(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.GetLocalPlayerChrType, _ARGS_);

        //public static _TYPE_ GetLocalPlayerId(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.GetLocalPlayerId, _ARGS_);

        //public static _TYPE_ GetLocalPlayerInvadeType(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.GetLocalPlayerInvadeType, _ARGS_);

        //public static _TYPE_ GetLocalPlayerSoulLv(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.GetLocalPlayerSoulLv, _ARGS_);

        //public static _TYPE_ GetLocalPlayerVowType(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.GetLocalPlayerVowType, _ARGS_);

        //public static _TYPE_ GetLocalQWC(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.GetLocalQWC, _ARGS_);

        //public static _TYPE_ GetMultiWallNum(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.GetMultiWallNum, _ARGS_);

        //public static _TYPE_ GetNetPlayerChrType(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.GetNetPlayerChrType, _ARGS_);

        //public static _TYPE_ GetObjHp(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.GetObjHp, _ARGS_);

        //public static _TYPE_ GetParam(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.GetParam, _ARGS_);

        //public static _TYPE_ GetParam1(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.GetParam1, _ARGS_);

        //public static _TYPE_ GetParam2(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.GetParam2, _ARGS_);

        //public static _TYPE_ GetParam3(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.GetParam3, _ARGS_);

        //public static _TYPE_ GetPartyMemberNum_InvadeType(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.GetPartyMemberNum_InvadeType, _ARGS_);

        //public static _TYPE_ GetPartyMemberNum_VowType(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.GetPartyMemberNum_VowType, _ARGS_);

        //public static _TYPE_ GetPlayerId_Random(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.GetPlayerId_Random, _ARGS_);

        //public static _TYPE_ GetPlayerNo_LotNitoMultiItem(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.GetPlayerNo_LotNitoMultiItem, _ARGS_);

        //public static _TYPE_ GetPlayID(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.GetPlayID, _ARGS_);

        //public static _TYPE_ GetQWC(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.GetQWC, _ARGS_);

        //public static _TYPE_ GetRandom(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.GetRandom, _ARGS_);

        //public static _TYPE_ GetRateItem(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.GetRateItem, _ARGS_);

        //public static _TYPE_ GetRateItem_IgnoreMultiPlay(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.GetRateItem_IgnoreMultiPlay, _ARGS_);

        //public static _TYPE_ GetReturnState(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.GetReturnState, _ARGS_);

        //public static _TYPE_ GetRightCurrentWeaponId(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.GetRightCurrentWeaponId, _ARGS_);

        //public static _TYPE_ GetSoloClearBonus(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.GetSoloClearBonus, _ARGS_);

        //public static _TYPE_ GetSummonAnimId(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.GetSummonAnimId, _ARGS_);

        //public static _TYPE_ GetSummonBlackResult(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.GetSummonBlackResult, _ARGS_);

        //public static _TYPE_ GetTargetChrID(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.GetTargetChrID, _ARGS_);

        //public static _TYPE_ GetTempSummonParam(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.GetTempSummonParam, _ARGS_);

        //public static _TYPE_ GetTravelItemParamId(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.GetTravelItemParamId, _ARGS_);

        //public static _TYPE_ GetWhiteGhostCount(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.GetWhiteGhostCount, _ARGS_);

        //public static _TYPE_ HasSuppleItem(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.HasSuppleItem, _ARGS_);

        //public static _TYPE_ HavePartyMember(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.HavePartyMember, _ARGS_);

        //public static _TYPE_ HoverMoveVal(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.HoverMoveVal, _ARGS_);

        //public static _TYPE_ HoverMoveValDmy(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.HoverMoveValDmy, _ARGS_);

        //public static _TYPE_ IncrementCoopPlaySuccessCount(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.IncrementCoopPlaySuccessCount, _ARGS_);

        //public static _TYPE_ IncrementThiefInvadePlaySuccessCount(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.IncrementThiefInvadePlaySuccessCount, _ARGS_);

        //public static _TYPE_ InfomationMenu(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.InfomationMenu, _ARGS_);

        //public static _TYPE_ InitDeathState(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.InitDeathState, _ARGS_);

        //public static _TYPE_ InvalidMyBloodMarkInfo(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.InvalidMyBloodMarkInfo, _ARGS_);

        //public static _TYPE_ InvalidMyBloodMarkInfo_Tutorial(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.InvalidMyBloodMarkInfo_Tutorial, _ARGS_);

        //public static _TYPE_ InvalidPointLight(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.InvalidPointLight, _ARGS_);

        //public static _TYPE_ InvalidSfx(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.InvalidSfx, _ARGS_);

        //public static _TYPE_ IsAction(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.IsAction, _ARGS_);

        //public static _TYPE_ IsAlive(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.IsAlive, _ARGS_);

        //public static _TYPE_ IsAliveMotion(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.IsAliveMotion, _ARGS_);

        //public static _TYPE_ IsAngle(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.IsAngle, _ARGS_);

        //public static _TYPE_ IsAnglePlus(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.IsAnglePlus, _ARGS_);

        //public static _TYPE_ IsAppearancePlayer(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.IsAppearancePlayer, _ARGS_);

        //public static _TYPE_ IsBlackGhost(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.IsBlackGhost, _ARGS_);

        //public static _TYPE_ IsBlackGhost_NetPlayer(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.IsBlackGhost_NetPlayer, _ARGS_);

        //public static _TYPE_ IsClearItem(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.IsClearItem, _ARGS_);

        //public static _TYPE_ IsClient(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.IsClient, _ARGS_);

        //public static _TYPE_ IsColiseumGhost(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.IsColiseumGhost, _ARGS_);

        //public static _TYPE_ IsCompleteEvent(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.IsCompleteEvent, _ARGS_);

        //public static _TYPE_ IsCompleteEventValue(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.IsCompleteEventValue, _ARGS_);

        //public static _TYPE_ IsDead_NextGreyGhost(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.IsDead_NextGreyGhost, _ARGS_);

        //public static _TYPE_ IsDeathPenaltySkip(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.IsDeathPenaltySkip, _ARGS_);

        //public static _TYPE_ IsDestroyed(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.IsDestroyed, _ARGS_);

        //public static _TYPE_ IsDisable(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.IsDisable, _ARGS_);

        //public static _TYPE_ IsDistance(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.IsDistance, _ARGS_);

        //public static _TYPE_ IsDropCheck_Only(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.IsDropCheck_Only, _ARGS_);

        //public static _TYPE_ IsEquip(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.IsEquip, _ARGS_);

        //public static _TYPE_ IsEventAnim(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.IsEventAnim, _ARGS_);

        //public static _TYPE_ IsFireDead(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.IsFireDead, _ARGS_);

        //public static _TYPE_ IsForceSummoned(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.IsForceSummoned, _ARGS_);

        //public static _TYPE_ IsGameClient(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.IsGameClient, _ARGS_);

        //public static _TYPE_ IsGreyGhost(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.IsGreyGhost, _ARGS_);

        //public static _TYPE_ IsGreyGhost_NetPlayer(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.IsGreyGhost_NetPlayer, _ARGS_);

        //public static _TYPE_ IsHost(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.IsHost, _ARGS_);

        //public static _TYPE_ IsInParty(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.IsInParty, _ARGS_);

        //public static _TYPE_ IsInParty_EnemyMember(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.IsInParty_EnemyMember, _ARGS_);

        //public static _TYPE_ IsInParty_FriendMember(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.IsInParty_FriendMember, _ARGS_);

        //public static _TYPE_ IsIntruder(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.IsIntruder, _ARGS_);

        //public static _TYPE_ IsInventoryEquip(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.IsInventoryEquip, _ARGS_);

        //public static _TYPE_ IsJobType(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.IsJobType, _ARGS_);

        //public static _TYPE_ IsLand(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.IsLand, _ARGS_);

        //public static _TYPE_ IsLiveNetPlayer(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.IsLiveNetPlayer, _ARGS_);

        //public static _TYPE_ IsLivePlayer(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.IsLivePlayer, _ARGS_);

        //public static _TYPE_ IsLoadWait(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.IsLoadWait, _ARGS_);

        //public static _TYPE_ IsMatchingMultiPlay(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.IsMatchingMultiPlay, _ARGS_);

        //public static _TYPE_ IsOnline(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.IsOnline, _ARGS_);

        //public static _TYPE_ IsOnlineMode(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.IsOnlineMode, _ARGS_);

        //public static _TYPE_ IsPlayerAssessMenu_Tutorial(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.IsPlayerAssessMenu_Tutorial, _ARGS_);

        //public static _TYPE_ IsPlayerStay(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.IsPlayerStay, _ARGS_);

        //public static _TYPE_ IsPlayMovie(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.IsPlayMovie, _ARGS_);

        //public static _TYPE_ IsPrevGreyGhost(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.IsPrevGreyGhost, _ARGS_);

        //public static _TYPE_ IsProcessEventGoal(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.IsProcessEventGoal, _ARGS_);

        //public static _TYPE_ IsReady_Obj(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.IsReady_Obj, _ARGS_);

        //public static _TYPE_ IsRegionDrop(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.IsRegionDrop, _ARGS_);

        //public static _TYPE_ IsRegionIn(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.IsRegionIn, _ARGS_);

        //public static _TYPE_ IsRevengeRequested(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.IsRevengeRequested, _ARGS_);

        //public static _TYPE_ IsReviveWait(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.IsReviveWait, _ARGS_);

        //public static _TYPE_ IsShow_CampMenu(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.IsShow_CampMenu, _ARGS_);

        //public static _TYPE_ IsShowMenu(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.IsShowMenu, _ARGS_);

        //public static _TYPE_ IsShowMenu_BriefingMsg(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.IsShowMenu_BriefingMsg, _ARGS_);

        //public static _TYPE_ IsShowMenu_GenDialog(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.IsShowMenu_GenDialog, _ARGS_);

        //public static _TYPE_ IsShowMenu_InfoMenu(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.IsShowMenu_InfoMenu, _ARGS_);

        //public static _TYPE_ IsShowSosMsg_Tutorial(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.IsShowSosMsg_Tutorial, _ARGS_);

        //public static _TYPE_ IsSuccessQWC(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.IsSuccessQWC, _ARGS_);

        //public static _TYPE_ IsTryJoinSession(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.IsTryJoinSession, _ARGS_);

        //public static _TYPE_ IsValidInstance(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.IsValidInstance, _ARGS_);

        //public static _TYPE_ IsValidTalk(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.IsValidTalk, _ARGS_);

        //public static _TYPE_ IsWhiteGhost(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.IsWhiteGhost, _ARGS_);

        //public static _TYPE_ IsWhiteGhost_NetPlayer(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.IsWhiteGhost_NetPlayer, _ARGS_);

        //public static _TYPE_ LeaveSession(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.LeaveSession, _ARGS_);

        //public static _TYPE_ LockSession(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.LockSession, _ARGS_);

        //public static _TYPE_ LuaCall(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.LuaCall, _ARGS_);

        //public static _TYPE_ LuaCallStart(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.LuaCallStart, _ARGS_);

        //public static _TYPE_ LuaCallStartPlus(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.LuaCallStartPlus, _ARGS_);

        //public static _TYPE_ MultiDoping_AllEventBody(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.MultiDoping_AllEventBody, _ARGS_);

        //public static _TYPE_ NoAnimeTurnCharactor(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.NoAnimeTurnCharactor, _ARGS_);

        //public static _TYPE_ NotNetMessage_begin(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.NotNetMessage_begin, _ARGS_);

        //public static _TYPE_ NotNetMessage_end(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.NotNetMessage_end, _ARGS_);

        //public static _TYPE_ ObjRootMtxMove(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.ObjRootMtxMove, _ARGS_);

        //public static _TYPE_ ObjRootMtxMoveByChrDmyPoly(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.ObjRootMtxMoveByChrDmyPoly, _ARGS_);

        //public static _TYPE_ ObjRootMtxMoveDmyPoly(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.ObjRootMtxMoveDmyPoly, _ARGS_);

        //public static _TYPE_ OnActionCheckKey(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnActionCheckKey, _ARGS_);

        //public static _TYPE_ OnActionEventRegion(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnActionEventRegion, _ARGS_);

        //public static _TYPE_ OnActionEventRegionAttribute(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnActionEventRegionAttribute, _ARGS_);

        //public static _TYPE_ OnBallista(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnBallista, _ARGS_);

        //public static _TYPE_ OnBloodMenuClose(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnBloodMenuClose, _ARGS_);

        //public static _TYPE_ OnBonfireEvent(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnBonfireEvent, _ARGS_);

        //public static _TYPE_ OnCharacterAnimEnd(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnCharacterAnimEnd, _ARGS_);

        //public static _TYPE_ OnCharacterDead(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnCharacterDead, _ARGS_);

        //public static _TYPE_ OnCharacterHP(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnCharacterHP, _ARGS_);

        //public static _TYPE_ OnCharacterHP_CheckAttacker(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnCharacterHP_CheckAttacker, _ARGS_);

        //public static _TYPE_ OnCharacterHpRate(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnCharacterHpRate, _ARGS_);

        //public static _TYPE_ OnCharacterTotalDamage(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnCharacterTotalDamage, _ARGS_);

        //public static _TYPE_ OnCharacterTotalRateDamage(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnCharacterTotalRateDamage, _ARGS_);

        //public static _TYPE_ OnCheckEzStateMessage(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnCheckEzStateMessage, _ARGS_);

        //public static _TYPE_ OnChrAnimEnd(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnChrAnimEnd, _ARGS_);

        //public static _TYPE_ OnChrAnimEndPlus(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnChrAnimEndPlus, _ARGS_);

        //public static _TYPE_ OnDistanceAction(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnDistanceAction, _ARGS_);

        //public static _TYPE_ OnDistanceActionAttribute(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnDistanceActionAttribute, _ARGS_);

        //public static _TYPE_ OnDistanceActionDmyPoly(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnDistanceActionDmyPoly, _ARGS_);

        //public static _TYPE_ OnDistanceActionPlus(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnDistanceActionPlus, _ARGS_);

        //public static _TYPE_ OnDistanceActionPlusAttribute(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnDistanceActionPlusAttribute, _ARGS_);

        //public static _TYPE_ OnDistanceJustIn(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnDistanceJustIn, _ARGS_);

        //public static _TYPE_ OnEndFlow(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnEndFlow, _ARGS_);

        //public static _TYPE_ OnFireDamage(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnFireDamage, _ARGS_);

        //public static _TYPE_ OnKeyTime2(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnKeyTime2, _ARGS_);

        //public static _TYPE_ OnNetDistanceIn(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnNetDistanceIn, _ARGS_);

        //public static _TYPE_ OnNetRegion(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnNetRegion, _ARGS_);

        //public static _TYPE_ OnNetRegionAttr(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnNetRegionAttr, _ARGS_);

        //public static _TYPE_ OnNetRegionAttrPlus(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnNetRegionAttrPlus, _ARGS_);

        //public static _TYPE_ OnNetRegionPlus(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnNetRegionPlus, _ARGS_);

        //public static _TYPE_ OnObjAnimEnd(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnObjAnimEnd, _ARGS_);

        //public static _TYPE_ OnObjAnimEndPlus(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnObjAnimEndPlus, _ARGS_);

        //public static _TYPE_ OnObjDestroy(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnObjDestroy, _ARGS_);

        //public static _TYPE_ OnObjectDamageHit(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnObjectDamageHit, _ARGS_);

        //public static _TYPE_ OnObjectDamageHit_NoCall(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnObjectDamageHit_NoCall, _ARGS_);

        //public static _TYPE_ OnObjectDamageHit_NoCallPlus(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnObjectDamageHit_NoCallPlus, _ARGS_);

        //public static _TYPE_ OnPlayerActionInRegion(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnPlayerActionInRegion, _ARGS_);

        //public static _TYPE_ OnPlayerActionInRegionAngle(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnPlayerActionInRegionAngle, _ARGS_);

        //public static _TYPE_ OnPlayerActionInRegionAngleAttribute(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnPlayerActionInRegionAngleAttribute, _ARGS_);

        //public static _TYPE_ OnPlayerActionInRegionAttribute(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnPlayerActionInRegionAttribute, _ARGS_);

        //public static _TYPE_ OnPlayerAssessMenu(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnPlayerAssessMenu, _ARGS_);

        //public static _TYPE_ OnPlayerDistanceAngleInTarget(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnPlayerDistanceAngleInTarget, _ARGS_);

        //public static _TYPE_ OnPlayerDistanceInTarget(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnPlayerDistanceInTarget, _ARGS_);

        //public static _TYPE_ OnPlayerDistanceOut(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnPlayerDistanceOut, _ARGS_);

        //public static _TYPE_ OnPlayerKill(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnPlayerKill, _ARGS_);

        //public static _TYPE_ OnRegionIn(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnRegionIn, _ARGS_);

        //public static _TYPE_ OnRegionJustIn(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnRegionJustIn, _ARGS_);

        //public static _TYPE_ OnRegionJustOut(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnRegionJustOut, _ARGS_);

        //public static _TYPE_ OnRegistFunc(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnRegistFunc, _ARGS_);

        //public static _TYPE_ OnRequestMenuEnd(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnRequestMenuEnd, _ARGS_);

        //public static _TYPE_ OnRevengeMenuClose(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnRevengeMenuClose, _ARGS_);

        //public static _TYPE_ OnSelectMenu(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnSelectMenu, _ARGS_);

        //public static _TYPE_ OnSelfBloodMark(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnSelfBloodMark, _ARGS_);

        //public static _TYPE_ OnSelfHeroBloodMark(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnSelfHeroBloodMark, _ARGS_);

        //public static _TYPE_ OnSessionIn(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnSessionIn, _ARGS_);

        //public static _TYPE_ OnSessionInfo(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnSessionInfo, _ARGS_);

        //public static _TYPE_ OnSessionJustIn(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnSessionJustIn, _ARGS_);

        //public static _TYPE_ OnSessionJustOut(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnSessionJustOut, _ARGS_);

        //public static _TYPE_ OnSessionOut(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnSessionOut, _ARGS_);

        //public static _TYPE_ OnSimpleDamage(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnSimpleDamage, _ARGS_);

        //public static _TYPE_ OnTalkEvent(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnTalkEvent, _ARGS_);

        //public static _TYPE_ OnTalkEventAngleOut(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnTalkEventAngleOut, _ARGS_);

        //public static _TYPE_ OnTalkEventDistIn(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnTalkEventDistIn, _ARGS_);

        //public static _TYPE_ OnTalkEventDistOut(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnTalkEventDistOut, _ARGS_);

        //public static _TYPE_ OnTestEffectEndPlus(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnTestEffectEndPlus, _ARGS_);

        //public static _TYPE_ OnTextEffectEnd(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnTextEffectEnd, _ARGS_);

        //public static _TYPE_ OnTurnCharactorEnd(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnTurnCharactorEnd, _ARGS_);

        //public static _TYPE_ OnWanderFade(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnWanderFade, _ARGS_);

        //public static _TYPE_ OnWanderingDemon(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnWanderingDemon, _ARGS_);

        //public static _TYPE_ OnWarpMenuClose(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnWarpMenuClose, _ARGS_);

        //public static _TYPE_ OnYesNoDialog(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OnYesNoDialog, _ARGS_);

        //public static _TYPE_ OpenCampMenu(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OpenCampMenu, _ARGS_);

        //public static _TYPE_ OpeningDead(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OpeningDead, _ARGS_);

        //public static _TYPE_ OpeningDeadPlus(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OpeningDeadPlus, _ARGS_);

        //public static _TYPE_ OpenSOSMsg_Tutorial(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.OpenSOSMsg_Tutorial, _ARGS_);

        //public static _TYPE_ ParamInitialize(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.ParamInitialize, _ARGS_);

        //public static _TYPE_ PauseTutorial(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.PauseTutorial, _ARGS_);

        //public static _TYPE_ PlayAnimation(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.PlayAnimation, _ARGS_);

        //public static _TYPE_ PlayAnimationStayCancel(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.PlayAnimationStayCancel, _ARGS_);

        //public static _TYPE_ PlayerChrResetAnimation_RemoOnly(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.PlayerChrResetAnimation_RemoOnly, _ARGS_);

        //public static _TYPE_ PlayLoopAnimation(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.PlayLoopAnimation, _ARGS_);

        //public static _TYPE_ PlayObjectSE(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.PlayObjectSE, _ARGS_);

        //public static _TYPE_ PlayPointSE(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.PlayPointSE, _ARGS_);

        //public static _TYPE_ PlayTypeSE(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.PlayTypeSE, _ARGS_);

        //public static _TYPE_ RecallMenuEvent(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.RecallMenuEvent, _ARGS_);

        //public static _TYPE_ ReconstructBreak(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.ReconstructBreak, _ARGS_);

        //public static _TYPE_ RecoveryHeroin(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.RecoveryHeroin, _ARGS_);

        //public static _TYPE_ RegistObjact(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.RegistObjact, _ARGS_);

        //public static _TYPE_ RegistSimpleTalk(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.RegistSimpleTalk, _ARGS_);

        //public static _TYPE_ RemoveInventoryEquip(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.RemoveInventoryEquip, _ARGS_);

        //public static _TYPE_ RepeatMessage_begin(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.RepeatMessage_begin, _ARGS_);

        //public static _TYPE_ RepeatMessage_end(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.RepeatMessage_end, _ARGS_);

        //public static _TYPE_ RequestEnding(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.RequestEnding, _ARGS_);

        //public static _TYPE_ RequestForceUpdateNetwork(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.RequestForceUpdateNetwork, _ARGS_);

        //public static _TYPE_ RequestFullRecover(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.RequestFullRecover, _ARGS_);

        //public static _TYPE_ RequestGenerate(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.RequestGenerate, _ARGS_);

        //public static _TYPE_ RequestNormalUpdateNetwork(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.RequestNormalUpdateNetwork, _ARGS_);

        //public static _TYPE_ RequestOpenBriefingMsg(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.RequestOpenBriefingMsg, _ARGS_);

        //public static _TYPE_ RequestOpenBriefingMsgPlus(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.RequestOpenBriefingMsgPlus, _ARGS_);

        //public static _TYPE_ RequestPlayMovie(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.RequestPlayMovie, _ARGS_);

        //public static _TYPE_ RequestPlayMoviePlus(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.RequestPlayMoviePlus, _ARGS_);

        //public static _TYPE_ RequestRemo(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.RequestRemo, _ARGS_);

        //public static _TYPE_ RequestRemoPlus(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.RequestRemoPlus, _ARGS_);

        //public static _TYPE_ RequestUnlockTrophy(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.RequestUnlockTrophy, _ARGS_);

        //public static _TYPE_ ReqularLeavePlayer(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.ReqularLeavePlayer, _ARGS_);

        //public static _TYPE_ ResetCamAngle(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.ResetCamAngle, _ARGS_);

        //public static _TYPE_ ResetEventQwcSpEffect(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.ResetEventQwcSpEffect, _ARGS_);

        //public static _TYPE_ ResetSummonParam(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.ResetSummonParam, _ARGS_);

        //public static _TYPE_ ResetSyncRideObjInfo(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.ResetSyncRideObjInfo, _ARGS_);

        //public static _TYPE_ ResetThink(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.ResetThink, _ARGS_);

        //public static _TYPE_ RestorePiece(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.RestorePiece, _ARGS_);

        //public static _TYPE_ ReturnMapSelect(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.ReturnMapSelect, _ARGS_);

        //public static _TYPE_ RevivePlayer(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.RevivePlayer, _ARGS_);

        //public static _TYPE_ RevivePlayerNext(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.RevivePlayerNext, _ARGS_);

        //public static _TYPE_ SaveRequest(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SaveRequest, _ARGS_);

        //public static _TYPE_ SaveRequest_Profile(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SaveRequest_Profile, _ARGS_);

        //public static _TYPE_ SendEventRequest(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SendEventRequest, _ARGS_);

        //public static _TYPE_ SetAlive(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetAlive, _ARGS_);

        //public static _TYPE_ SetAliveMotion(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetAliveMotion, _ARGS_);

        //public static _TYPE_ SetAlwaysDrawForEvent(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetAlwaysDrawForEvent, _ARGS_);

        //public static _TYPE_ SetAlwaysEnableBackread_forEvent(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetAlwaysEnableBackread_forEvent, _ARGS_);

        //public static _TYPE_ SetAngleFoward(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetAngleFoward, _ARGS_);

        //public static _TYPE_ SetAreaStartMapUid(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetAreaStartMapUid, _ARGS_);

        //public static _TYPE_ SetBossGauge(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetBossGauge, _ARGS_);

        //public static _TYPE_ SetBossUnitJrHit(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetBossUnitJrHit, _ARGS_);

        //public static _TYPE_ SetBountyRankPoint(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetBountyRankPoint, _ARGS_);

        //public static _TYPE_ SetBrokenPiece(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetBrokenPiece, _ARGS_);

        //public static _TYPE_ SetCamModeParamTargetId(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetCamModeParamTargetId, _ARGS_);

        //public static _TYPE_ SetCamModeParamTargetIdForBossLock(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetCamModeParamTargetIdForBossLock, _ARGS_);

        //public static _TYPE_ SetChrType(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetChrType, _ARGS_);

        //public static _TYPE_ SetChrTypeDataGrey(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetChrTypeDataGrey, _ARGS_);

        //public static _TYPE_ SetChrTypeDataGreyNext(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetChrTypeDataGreyNext, _ARGS_);

        //public static _TYPE_ SetClearBonus(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetClearBonus, _ARGS_);

        //public static _TYPE_ SetClearItem(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetClearItem, _ARGS_);

        //public static _TYPE_ SetClearSesiionCount(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetClearSesiionCount, _ARGS_);

        //public static _TYPE_ SetClearState(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetClearState, _ARGS_);

        //public static _TYPE_ SetColiEnable(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetColiEnable, _ARGS_);

        //public static _TYPE_ SetColiEnableArray(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetColiEnableArray, _ARGS_);

        //public static _TYPE_ SetCompletelyNoMove(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetCompletelyNoMove, _ARGS_);

        //public static _TYPE_ SetDeadMode(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetDeadMode, _ARGS_);

        //public static _TYPE_ SetDeadMode2(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetDeadMode2, _ARGS_);

        //public static _TYPE_ SetDefaultAnimation(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetDefaultAnimation, _ARGS_);

        //public static _TYPE_ SetDefaultMapUid(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetDefaultMapUid, _ARGS_);

        //public static _TYPE_ SetDefaultRoutePoint(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetDefaultRoutePoint, _ARGS_);

        //public static _TYPE_ SetDisable(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetDisable, _ARGS_);

        //public static _TYPE_ SetDisableBackread_forEvent(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetDisableBackread_forEvent, _ARGS_);

        //public static _TYPE_ SetDisableDamage(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetDisableDamage, _ARGS_);

        //public static _TYPE_ SetDisableGravity(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetDisableGravity, _ARGS_);

        //public static _TYPE_ SetDisableWeakDamageAnim(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetDisableWeakDamageAnim, _ARGS_);

        //public static _TYPE_ SetDisableWeakDamageAnim_light(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetDisableWeakDamageAnim_light, _ARGS_);

        //public static _TYPE_ SetDispMask(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetDispMask, _ARGS_);

        //public static _TYPE_ SetDrawEnable(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetDrawEnable, _ARGS_);

        //public static _TYPE_ SetDrawEnableArray(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetDrawEnableArray, _ARGS_);

        //public static _TYPE_ SetDrawGroup(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetDrawGroup, _ARGS_);

        //public static _TYPE_ SetEnableEventPad(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetEnableEventPad, _ARGS_);

        //public static _TYPE_ SetEventBodyBulletCorrect(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetEventBodyBulletCorrect, _ARGS_);

        //public static _TYPE_ SetEventBodyMaterialSeAndSfx(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetEventBodyMaterialSeAndSfx, _ARGS_);

        //public static _TYPE_ SetEventBodyMaxHp(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetEventBodyMaxHp, _ARGS_);

        //public static _TYPE_ SetEventCommand(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetEventCommand, _ARGS_);

        //public static _TYPE_ SetEventCommandIndex(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetEventCommandIndex, _ARGS_);

        //public static _TYPE_ SetEventFlag(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetEventFlag, _ARGS_);

        //public static _TYPE_ SetEventFlagValue(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetEventFlagValue, _ARGS_);

        //public static _TYPE_ SetEventGenerate(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetEventGenerate, _ARGS_);

        //public static _TYPE_ SetEventMovePointType(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetEventMovePointType, _ARGS_);

        //public static _TYPE_ SetEventSimpleTalk(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetEventSimpleTalk, _ARGS_);

        //public static _TYPE_ SetEventSpecialEffect(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetEventSpecialEffect, _ARGS_);

        //public static _TYPE_ SetEventSpecialEffect_2(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetEventSpecialEffect_2, _ARGS_);

        //public static _TYPE_ SetEventSpecialEffectOwner(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetEventSpecialEffectOwner, _ARGS_);

        //public static _TYPE_ SetEventSpecialEffectOwner_2(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetEventSpecialEffectOwner_2, _ARGS_);

        //public static _TYPE_ SetEventTarget(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetEventTarget, _ARGS_);

        //public static _TYPE_ SetExVelocity(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetExVelocity, _ARGS_);

        //public static _TYPE_ SetFirstSpeed(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetFirstSpeed, _ARGS_);

        //public static _TYPE_ SetFirstSpeedPlus(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetFirstSpeedPlus, _ARGS_);

        //public static _TYPE_ SetFlagInitState(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetFlagInitState, _ARGS_);

        //public static _TYPE_ SetFootIKInterpolateType(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetFootIKInterpolateType, _ARGS_);

        //public static _TYPE_ SetForceJoinBlackRequest(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetForceJoinBlackRequest, _ARGS_);

        //public static _TYPE_ SetHitInfo(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetHitInfo, _ARGS_);

        //public static _TYPE_ SetHitMask(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetHitMask, _ARGS_);

        //public static _TYPE_ SetHp(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetHp, _ARGS_);

        //public static _TYPE_ SetIgnoreHit(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetIgnoreHit, _ARGS_);

        //public static _TYPE_ SetInfomationPriority(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetInfomationPriority, _ARGS_);

        //public static _TYPE_ SetInsideBattleArea(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetInsideBattleArea, _ARGS_);

        //public static _TYPE_ SetIsAnimPauseOnRemoPlayForEvent(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetIsAnimPauseOnRemoPlayForEvent, _ARGS_);

        //public static _TYPE_ SetKeepCommandIndex(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetKeepCommandIndex, _ARGS_);

        //public static _TYPE_ SetLoadWait(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetLoadWait, _ARGS_);

        //public static _TYPE_ SetLockActPntInvalidateMask(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetLockActPntInvalidateMask, _ARGS_);

        //public static _TYPE_ SetMapUid(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetMapUid, _ARGS_);

        //public static _TYPE_ SetMaxHp(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetMaxHp, _ARGS_);

        //public static _TYPE_ SetMenuBrake(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetMenuBrake, _ARGS_);

        //public static _TYPE_ SetMiniBlockIndex(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetMiniBlockIndex, _ARGS_);

        //public static _TYPE_ SetMovePoint(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetMovePoint, _ARGS_);

        //public static _TYPE_ SetMultiWallMapUid(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetMultiWallMapUid, _ARGS_);

        //public static _TYPE_ SetNoNetSync(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetNoNetSync, _ARGS_);

        //public static _TYPE_ SetObjDeactivate(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetObjDeactivate, _ARGS_);

        //public static _TYPE_ SetObjDisableBreak(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetObjDisableBreak, _ARGS_);

        //public static _TYPE_ SetObjEventCollisionFill(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetObjEventCollisionFill, _ARGS_);

        //public static _TYPE_ SetObjSfx(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetObjSfx, _ARGS_);

        //public static _TYPE_ SetReturnPointEntityId(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetReturnPointEntityId, _ARGS_);

        //public static _TYPE_ SetReviveWait(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetReviveWait, _ARGS_);

        //public static _TYPE_ SetSelfBloodMapUid(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetSelfBloodMapUid, _ARGS_);

        //public static _TYPE_ SetSosSignPos(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetSosSignPos, _ARGS_);

        //public static _TYPE_ SetSosSignWarp(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetSosSignWarp, _ARGS_);

        //public static _TYPE_ SetSpStayAndDamageAnimId(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetSpStayAndDamageAnimId, _ARGS_);

        //public static _TYPE_ SetSpStayAndDamageAnimIdPlus(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetSpStayAndDamageAnimIdPlus, _ARGS_);

        //public static _TYPE_ SetSubMenuBrake(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetSubMenuBrake, _ARGS_);

        //public static _TYPE_ SetSummonedPos(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetSummonedPos, _ARGS_);

        //public static _TYPE_ SetSyncRideObjInfo(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetSyncRideObjInfo, _ARGS_);

        //public static _TYPE_ SetSystemIgnore(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetSystemIgnore, _ARGS_);

        //public static _TYPE_ SetTalkMsg(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetTalkMsg, _ARGS_);

        //public static _TYPE_ SetTeamType(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetTeamType, _ARGS_);

        //public static _TYPE_ SetTeamTypeDefault(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetTeamTypeDefault, _ARGS_);

        //public static _TYPE_ SetTeamTypePlus(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetTeamTypePlus, _ARGS_);

        //public static _TYPE_ SetTextEffect(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetTextEffect, _ARGS_);

        //public static _TYPE_ SetTutorialSummonedPos(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetTutorialSummonedPos, _ARGS_);

        //public static _TYPE_ SetValidTalk(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SetValidTalk, _ARGS_);

        //public static _TYPE_ ShowGenDialog(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.ShowGenDialog, _ARGS_);

        //public static _TYPE_ ShowRankingDialog(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.ShowRankingDialog, _ARGS_);

        //public static _TYPE_ SOSMsgGetResult_Tutorial(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SOSMsgGetResult_Tutorial, _ARGS_);

        //public static _TYPE_ StopLoopAnimation(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.StopLoopAnimation, _ARGS_);

        //public static _TYPE_ StopPlayer(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.StopPlayer, _ARGS_);

        //public static _TYPE_ StopPointSE(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.StopPointSE, _ARGS_);

        //public static _TYPE_ SubActionCount(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SubActionCount, _ARGS_);

        //public static _TYPE_ SubDispMaskByBit(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SubDispMaskByBit, _ARGS_);

        //public static _TYPE_ SubHitMask(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SubHitMask, _ARGS_);

        //public static _TYPE_ SubHitMaskByBit(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SubHitMaskByBit, _ARGS_);

        //public static _TYPE_ SummonBlackRequest(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SummonBlackRequest, _ARGS_);

        //public static _TYPE_ SummonedMapReload(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SummonedMapReload, _ARGS_);

        //public static _TYPE_ SummonSuccess(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SummonSuccess, _ARGS_);

        //public static _TYPE_ SwitchDispMask(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SwitchDispMask, _ARGS_);

        //public static _TYPE_ SwitchHitMask(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.SwitchHitMask, _ARGS_);

        //public static _TYPE_ TalkNextPage(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.TalkNextPage, _ARGS_);

        //public static _TYPE_ TreasureDispModeChange(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.TreasureDispModeChange, _ARGS_);

        //public static _TYPE_ TreasureDispModeChange2(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.TreasureDispModeChange2, _ARGS_);

        //public static _TYPE_ TurnCharactor(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.TurnCharactor, _ARGS_);

        //public static _TYPE_ Tutorial_begin(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.Tutorial_begin, _ARGS_);

        //public static _TYPE_ Tutorial_end(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.Tutorial_end, _ARGS_);

        //public static _TYPE_ UnLockSession(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.UnLockSession, _ARGS_);

        //public static _TYPE_ UpDateBloodMark(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.UpDateBloodMark, _ARGS_);

        //public static _TYPE_ Util_RequestLevelUp(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.Util_RequestLevelUp, _ARGS_);

        //public static _TYPE_ Util_RequestLevelUpFirst(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.Util_RequestLevelUpFirst, _ARGS_);

        //public static _TYPE_ Util_RequestRegene(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.Util_RequestRegene, _ARGS_);

        //public static _TYPE_ Util_RequestRespawn(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.Util_RequestRespawn, _ARGS_);

        //public static _TYPE_ ValidPointLight(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.ValidPointLight, _ARGS_);

        //public static _TYPE_ ValidSfx(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.ValidSfx, _ARGS_);

        //public static _TYPE_ VariableExpand_211_Param1(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.VariableExpand_211_Param1, _ARGS_);

        //public static _TYPE_ VariableExpand_211_param2(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.VariableExpand_211_param2, _ARGS_);

        //public static _TYPE_ VariableExpand_211_param3(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.VariableExpand_211_param3, _ARGS_);

        //public static _TYPE_ VariableExpand_22_param1(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.VariableExpand_22_param1, _ARGS_);

        //public static _TYPE_ VariableExpand_22_param2(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.VariableExpand_22_param2, _ARGS_);

        //public static _TYPE_ VariableOrder_211(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.VariableOrder_211, _ARGS_);

        //public static _TYPE_ VariableOrder_22(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.VariableOrder_22, _ARGS_);

        //public static _TYPE_ WARN(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.WARN, _ARGS_);

        //public static _TYPE_ Warp(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.Warp, _ARGS_);

        //public static _TYPE_ WarpDmy(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.WarpDmy, _ARGS_);

        //public static _TYPE_ WarpNextStage(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.WarpNextStage, _ARGS_);

        //public static _TYPE_ WarpNextStage_Bonfire(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.WarpNextStage_Bonfire, _ARGS_);

        //public static _TYPE_ WarpNextStageKick(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.WarpNextStageKick, _ARGS_);

        //public static _TYPE_ WarpRestart(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.WarpRestart, _ARGS_);

        //public static _TYPE_ WarpRestartNoGrey(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.WarpRestartNoGrey, _ARGS_);

        //public static _TYPE_ WarpSelfBloodMark(_ARGS_)
        //    => Call<_TYPE_>(FuncAddress.WarpSelfBloodMark, _ARGS_);


    }
}
