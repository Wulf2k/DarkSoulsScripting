﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkSoulsScripting
{
    public enum FuncAddress : Int64
    {
        ActionEnd = 0xD616D0,
        AddActionCount = 0xD5FC20,
        AddBlockClearBonus = 0xD5E480,
        AddClearCount = 0x1404A8390,
        AddCorpseEvent = 0xD60930,
        AddCurrentVowRankPoint = 0x1404A3120,
        AddCustomRoutePoint = 0xD645C0,
        AddDeathCount = 0xD5DE20,
        AddEventGoal = 0xD66000,
        AddEventParts = 0xD60D30,
        AddEventParts_Ignore = 0xD60CF0,
        AddEventSimpleTalk = 0xD62860,
        AddEventSimpleTalkTimer = 0xD62820,
        AddFieldInsFilter = 0xD62790,
        AddGeneEvent = 0xD622B0,
        AddHelpWhiteGhost = 0x1404A5410,
        AddHitMaskByBit = 0xD64D50,
        AddInfomationBuffer = 0xD64720,
        AddInfomationBufferTag = 0xD64730,
        AddInfomationList = 0xD62370,
        AddInfomationListItem = 0xD62350,
        AddInfomationTimeMsgTag = 0xD646F0,
        AddInfomationTosBuffer = 0xD646D0,
        AddInfomationTosBufferPlus = 0xD646B0,
        AddInventoryItem = 0x1404A4F90,
        AddKillBlackGhost = 0xD5DB30,
        AddQWC = 0x1404A53B0,
        AddRumble = 0xD640D0,
        AddTreasureEvent = 0xD5F3B0,
        AddTrueDeathCount = 0xD5DDF0,
        BeginAction = 0xD5FCF0,
        BeginLoopCheck = 0xD5FB90,
        CalcExcuteMultiBonus = 0xD5F4C0,
        CalcGetCurrentMapEntityId = 0xD5F230,
        CalcGetMultiWallEntityId = 0xD5E360,
        CamReset = 0x1404A4C50,
        CastPointSpell = 0xD65FB0,
        CastPointSpell_Horming = 0xD65F10,
        CastPointSpellPlus = 0xD65F60,
        CastPointSpellPlus_Horming = 0xD65EC0,
        CastTargetSpell = 0xD65E90,
        CastTargetSpellPlus = 0xD65E50,
        ChangeGreyGhost = 0xD663D0,
        ChangeInitPosAng = 0xD60D70,
        ChangeModel = 0xD64C70,
        ChangeTarget = 0xD61DA0,
        ChangeThink = 0xD658A0,
        ChangeWander = 0xD61000,
        CharacterAllAttachSys = 0xD60860,
        CharactorCopyPosAng = 0xD64190,
        CheckChrHit_Obj = 0xD5EA00,
        CheckChrHit_Wall = 0xD5EA30,
        CheckEventBody = 0xD5EC60,
        CheckEventChr_Proxy = 0xD5E9E0,
        CheckPenalty = 0xD5EE50,
        ChrDisableUpdate = 0xD61460,
        ChrFadeIn = 0x1404A9080,
        ChrFadeOut = 0x1404A90A0,
        ChrResetAnimation = 0x1404A9300,
        ChrResetRequest = 0x1404A92C0,
        ClearBossGauge = 0xD5DD80,
        ClearMyWorldState = 0xD5EDD0,
        ClearSosSign = 0xD5EED0,
        ClearTarget = 0xD613C0,
        CloseGenDialog = 0xD5E500,
        CloseMenu = 0xD5ED00,
        CloseRankingDialog = 0xD5D950,
        CloseTalk = 0xD5E610,
        CompleteEvent = 0xD660A0,
        CreateCamSfx = 0xD620B0,
        CreateDamage_NoCollision = 0xD65DC0,
        CreateEventBody = 0xD65830,
        CreateEventBodyPlus = 0xD657C0,
        CreateHeroBloodStain = 0xD62640,
        CreateSfx = 0xD5F000,
        CreateSfx_DummyPoly = 0xD64140,
        CroseBriefingMsg = 0xD5E400,
        CustomLuaCall = 0xD62C30,
        CustomLuaCallStart = 0xD66240,
        CustomLuaCallStartPlus = 0xD66210,
        DeleteCamSfx = 0xD5E8A0,
        DeleteEvent = 0xD5EAA0,
        DeleteObjSfxAll = 0xD5E7B0,
        DeleteObjSfxDmyPlyID = 0xD5E7F0,
        DeleteObjSfxEventID = 0xD5E7D0,
        DisableCollection = 0xD60A40,
        DisableDamage = 0xD60DD0,
        DisableHpGauge = 0xD60A00,
        DisableInterupt = 0xD612B0,
        DisableMapHit = 0xD61790,
        DisableMove = 0xD617D0,
        DivideRest = 0x490520,
        EnableAction = 0xD5FD60,
        EnableGeneratorSystem = 0xD5EF20,
        EnableHide = 0x1404A7590,
        EnableInvincible = 0xD60D90,
        EnableLogic = 0xD5FD90,
        EnableObjTreasure = 0xD661D0,
        EndAnimation = 0xD61BF0,
        EraseEventSpecialEffect = 0xD61210,
        EraseEventSpecialEffect_2 = 0xD61170,
        EventTagInsertString_forPlayerNo = 0xD5E820,
        ExcutePenalty = 0xD5EBE0,
        ForceChangeTarget = 0xD61E00,
        ForceDead = 0xD66690,
        ForcePlayAnimation = 0xD61CF0,
        ForcePlayAnimationStayCancel = 0xD61CA0,
        ForcePlayLoopAnimation = 0xD61C50,
        ForceSetOmissionLevel = 0xD60CB0,
        ForceUpdateNextFrame = 0xD60C90,
        GetBountyRankPoint = 0xD60130,
        GetClearBonus = 0xD5DEB0,
        GetClearCount = 0xD5E5A0,
        GetClearState = 0xD5E580,
        GetCurrentMapAreaNo = 0x1404A74A0,
        GetCurrentMapBlockNo = 0x1404A74C0,
        GetDeathState = 0xD5D800,
        GetDistance = 0xD61B70,
        GetEnemyPlayerId_Random = 0xD5ED10,
        GetEventFlagValue = 0xD60340,
        GetEventGoalState = 0xD612F0,
        GetEventMode = 0xD61690,
        GetEventRequest = 0xD610D0,
        GetFloorMaterial = 0xD60480,
        GetGlobalQWC = 0xD5F850,
        GetHeroPoint = 0xD5DC50,
        GetHostPlayerNo = 0xD5E260,
        GetHp = 0x1405ABAA0,
        GetHpRate = 0xD5FA30,
        GetItem = 0xD5E240,
        GetLadderCount = 0xD64580,
        GetLastBlockId = 0xD5EFC0,
        GetLocalPlayerChrType = 0x1404a4b70,
        GetLocalPlayerId = 0xD5E270,
        GetLocalPlayerInvadeType = 0xD5FB50,
        GetLocalPlayerSoulLv = 0x1404A94F0,
        GetLocalPlayerVowType = 0x1404A4BF0,
        GetLocalQWC = 0x1404A5370,
        GetMultiWallNum = 0xD5DC40,
        GetNetPlayerChrType = 0xD5E8C0,
        GetObjHp = 0xD5F320,
        GetParam = 0xCD9FF0,
        GetParam1 = 0x403B00,
        GetParam2 = 0xB1CD50,
        GetParam3 = 0x788EE0,
        GetPartyMemberNum_InvadeType = 0xD5EBA0,
        GetPartyMemberNum_VowType = 0xD5F3A0,
        GetPlayerId_Random = 0xD5ED30,
        GetPlayerNo_LotNitoMultiItem = 0xD64100,
        GetPlayID = 0xB0E260,
        GetQWC = 0x1404A5350,
        GetRandom = 0xD5E0F0,
        GetRateItem = 0xD665B0,
        GetRateItem_IgnoreMultiPlay = 0xD66590,
        GetReturnState = 0xD5E230,
        GetRightCurrentWeaponId = 0xD5EF80,
        GetSoloClearBonus = 0xD5DE60,
        GetSummonAnimId = 0xD60890,
        GetSummonBlackResult = 0xD5E530,
        GetTargetChrID = 0xD64160,
        GetTempSummonParam = 0xD5DDE0,
        GetTravelItemParamId = 0xD60440,
        GetWhiteGhostCount = 0xD5E3D0,
        HasSuppleItem = 0xD60430,
        HavePartyMember = 0xD5E1D0,
        HoverMoveVal = 0xD62C00,
        HoverMoveValDmy = 0xD648E0,
        IncrementCoopPlaySuccessCount = 0xD5F1D0,
        IncrementThiefInvadePlaySuccessCount = 0xD5F1A0,
        InfomationMenu = 0xD64110,
        InitDeathState = 0xD5D7E0,
        InvalidMyBloodMarkInfo = 0xD60E50,
        InvalidMyBloodMarkInfo_Tutorial = 0xD60E30,
        InvalidPointLight = 0xD5F060,
        InvalidSfx = 0xD5F780,
        IsAction = 0xD5FAB0,
        IsAlive = 0x1404A5430,
        IsAliveMotion = 0xD5E6A0,
        IsAngle = 0xD61B30,
        IsAnglePlus = 0xD61AF0,
        IsAppearancePlayer = 0xD5F170,
        IsBlackGhost = 0xD60EF0,
        IsBlackGhost_NetPlayer = 0xD5E8F0,
        IsClearItem = 0xD5DCF0,
        IsClient = 0xD5E2E0,
        IsColiseumGhost = 0xD60EB0,
        IsCompleteEvent = 0xD60170,
        IsCompleteEventValue = 0xD60150,
        IsDead_NextGreyGhost = 0xD5E160,
        IsDeathPenaltySkip = 0xD5D7D0,
        IsDestroyed = 0xD5F0E0,
        IsDisable = 0xD60F70,
        IsDistance = 0xD61BA0,
        IsDropCheck_Only = 0xD60C00,
        IsEquip = 0xD5F4F0,
        IsEventAnim = 0xD61C30,
        IsFireDead = 0xD60400,
        IsForceSummoned = 0xD5EC00,
        IsGameClient = 0xD5EAF0,
        IsGreyGhost = 0xD60F30,
        IsGreyGhost_NetPlayer = 0xD5E970,
        IsHost = 0xD5E300,
        IsInParty = 0xD5E1F0,
        IsInParty_EnemyMember = 0xD5EEC0,
        IsInParty_FriendMember = 0xD5E440,
        IsIntruder = 0xD60ED0,
        IsInventoryEquip = 0xD5EF40,
        IsJobType = 0xD5E040,
        IsLand = 0xD60450,
        IsLiveNetPlayer = 0xD5E9B0,
        IsLivePlayer = 0xD60F50,
        IsLoadWait = 0xD5D930,
        IsMatchingMultiPlay = 0xD5ED80,
        IsOnline = 0x1404A0470,
        IsOnlineMode = 0xD5DD50,
        IsPlayerAssessMenu_Tutorial = 0xD5E010,
        IsPlayerStay = 0xD61610,
        IsPlayMovie = 0xD60AF0,
        IsPrevGreyGhost = 0xD5E140,
        IsProcessEventGoal = 0xD61340,
        IsReady_Obj = 0xD5F370,
        IsRegionDrop = 0xD60C30,
        IsRegionIn = 0xD61020,
        IsRevengeRequested = 0xD5E2A0,
        IsReviveWait = 0xD5E660,
        IsShow_CampMenu = 0x1404A77E0,
        IsShowMenu = 0x1404A4E80,
        IsShowMenu_BriefingMsg = 0xD5DD70,
        IsShowMenu_GenDialog = 0xD5EA80,
        IsShowMenu_InfoMenu = 0xD5DB80,
        IsShowSosMsg_Tutorial = 0xD5E000,
        IsSuccessQWC = 0xD5F7D0,
        IsTryJoinSession = 0xD5E2B0,
        IsValidInstance = 0xD5F510,
        IsValidTalk = 0xD5E5F0,
        IsWhiteGhost = 0xD60F10,
        IsWhiteGhost_NetPlayer = 0xD5E930,
        LeaveSession = 0xD62900,
        LockSession = 0xD5EE60,
        LuaCall = 0x1404A3C80,
        LuaCallStart = 0xD66290,
        LuaCallStartPlus = 0xD66260,
        MultiDoping_AllEventBody = 0xD61D60,
        NoAnimeTurnCharactor = 0xD61480,
        NotNetMessage_begin = 0xD5DBE0,
        NotNetMessage_end = 0xD5DBD0,
        ObjRootMtxMove = 0xD647A0,
        ObjRootMtxMoveByChrDmyPoly = 0xD64760,
        ObjRootMtxMoveDmyPoly = 0xD64780,
        OnActionCheckKey = 0xD63B70,
        OnActionEventRegion = 0xD63C70,
        OnActionEventRegionAttribute = 0xD63BE0,
        OnBallista = 0xD5E290,
        OnBloodMenuClose = 0xD62FF0,
        OnBonfireEvent = 0xD64B40,
        OnCharacterAnimEnd = 0xD63860,
        OnCharacterDead = 0xD63AB0,
        OnCharacterHP = 0xD63A50,
        OnCharacterHP_CheckAttacker = 0xD639E0,
        OnCharacterHpRate = 0xD63980,
        OnCharacterTotalDamage = 0xD63750,
        OnCharacterTotalRateDamage = 0xD636C0,
        OnCheckEzStateMessage = 0xD63B10,
        OnChrAnimEnd = 0xD64570,
        OnChrAnimEndPlus = 0xD637D0,
        OnDistanceAction = 0xD65240,
        OnDistanceActionAttribute = 0xD65190,
        OnDistanceActionDmyPoly = 0xD64F70,
        OnDistanceActionPlus = 0xD650D0,
        OnDistanceActionPlusAttribute = 0xD65010,
        OnDistanceJustIn = 0xD64E50,
        OnEndFlow = 0xD62990,
        OnFireDamage = 0xD634B0,
        OnKeyTime2 = 0xD635D0,
        OnNetDistanceIn = 0xD62D40,
        OnNetRegion = 0xD625D0,
        OnNetRegionAttr = 0xD625A0,
        OnNetRegionAttrPlus = 0xD62DA0,
        OnNetRegionPlus = 0xD62E00,
        OnObjAnimEnd = 0xD64560,
        OnObjAnimEndPlus = 0xD64550,
        OnObjDestroy = 0xD63900,
        OnObjectDamageHit = 0xD659A0,
        OnObjectDamageHit_NoCall = 0xD65940,
        OnObjectDamageHit_NoCallPlus = 0xD658E0,
        OnPlayerActionInRegion = 0xD63EB0,
        OnPlayerActionInRegionAngle = 0xD63D90,
        OnPlayerActionInRegionAngleAttribute = 0xD63D00,
        OnPlayerActionInRegionAttribute = 0xD63E20,
        OnPlayerAssessMenu = 0xD629E0,
        OnPlayerDistanceAngleInTarget = 0xD652F0,
        OnPlayerDistanceInTarget = 0xD65380,
        OnPlayerDistanceOut = 0xD64EE0,
        OnPlayerKill = 0xD63430,
        OnRegionIn = 0xD64050,
        OnRegionJustIn = 0xD63FC0,
        OnRegionJustOut = 0xD63F40,
        OnRegistFunc = 0xD63050,
        OnRequestMenuEnd = 0xD62670,
        OnRevengeMenuClose = 0xD64AC0,
        OnSelectMenu = 0xD62EF0,
        OnSelfBloodMark = 0xD633B0,
        OnSelfHeroBloodMark = 0xD63330,
        OnSessionIn = 0xD63230,
        OnSessionInfo = 0xD630E0,
        OnSessionJustIn = 0xD632B0,
        OnSessionJustOut = 0xD631B0,
        OnSessionOut = 0xD63130,
        OnSimpleDamage = 0xD63540,
        OnTalkEvent = 0xD65BB0,
        OnTalkEventAngleOut = 0xD65A20,
        OnTalkEventDistIn = 0xD65B30,
        OnTalkEventDistOut = 0xD65AB0,
        OnTestEffectEndPlus = 0xD626C0,
        OnTextEffectEnd = 0xD62720,
        OnTurnCharactorEnd = 0xD62A30,
        OnWanderFade = 0xD622D0,
        OnWanderingDemon = 0xD62240,
        OnWarpMenuClose = 0xD62F90,
        OnYesNoDialog = 0xD62E60,
        OpenCampMenu = 0xD5DA80,
        OpeningDead = 0xD66600,
        OpeningDeadPlus = 0xD665D0,
        OpenSOSMsg_Tutorial = 0xD5E750,
        ParamInitialize = 0xD66360,
        PauseTutorial = 0xD5E0B0,
        PlayAnimation = 0xD61D10,
        PlayAnimationStayCancel = 0xD61CC0,
        PlayerChrResetAnimation_RemoOnly = 0xD60630,
        PlayLoopAnimation = 0xD61C70,
        PlayObjectSE = 0xD61660,
        PlayPointSE = 0xD61F00,
        PlayTypeSE = 0xD61630,
        RecallMenuEvent = 0xD62780,
        ReconstructBreak = 0xD66070,
        RecoveryHeroin = 0xD60740,
        RegistObjact = 0xD5D870,
        RegistSimpleTalk = 0xD628A0,
        RemoveInventoryEquip = 0xD60C70,
        RepeatMessage_begin = 0xD5DBC0,
        RepeatMessage_end = 0xD5DBB0,
        RequestEnding = 0xD5DDD0,
        RequestForceUpdateNetwork = 0xD60AA0,
        RequestFullRecover = 0xD5DD40,
        RequestGenerate = 0xD5F290,
        RequestNormalUpdateNetwork = 0xD60A70,
        RequestOpenBriefingMsg = 0xD5EB50,
        RequestOpenBriefingMsgPlus = 0xD62260,
        RequestPlayMovie = 0xD65750,
        RequestPlayMoviePlus = 0xD656D0,
        RequestRemo = 0xD66440,
        RequestRemoPlus = 0xD663E0,
        RequestUnlockTrophy = 0xD5EBB0,
        ReqularLeavePlayer = 0x1404A9580,
        ResetCamAngle = 0xD5EB20,
        ResetEventQwcSpEffect = 0xD61ED0,
        ResetSummonParam = 0xD5EB80,
        ResetSyncRideObjInfo = 0xD60500,
        ResetThink = 0xD61070,
        RestorePiece = 0xD64C40,
        ReturnMapSelect = 0x1404A4C30,
        RevivePlayer = 0x1404A7260,
        RevivePlayerNext = 0xD5E0A0,
        SaveRequest = 0x1404A9180,
        SaveRequest_Profile = 0x1404A91A0,
        SendEventRequest = 0xD61130,
        SetAlive = 0xD664A0,
        SetAliveMotion = 0xD5E6C0,
        SetAlwaysDrawForEvent = 0xD60570,
        SetAlwaysEnableBackread_forEvent = 0xD60750,
        SetAngleFoward = 0xD61A80,
        SetAreaStartMapUid = 0xD5F720,
        SetBossGauge = 0xD60700,
        SetBossUnitJrHit = 0xD61710,
        SetBountyRankPoint = 0xD64E00,
        SetBrokenPiece = 0xD5F7A0,
        SetCamModeParamTargetId = 0xD5DF00,
        SetCamModeParamTargetIdForBossLock = 0xD5DEF0,
        SetChrType = 0x1404A6A80,
        SetChrTypeDataGrey = 0xD5DFB0,
        SetChrTypeDataGreyNext = 0xD5DF50,
        SetClearBonus = 0xD5F3D0,
        SetClearItem = 0xD5DCD0,
        SetClearSesiionCount = 0xD5E4C0,
        SetClearState = 0xD5E560,
        SetColiEnable = 0xD60090,
        SetColiEnableArray = 0xD64AA0,
        SetCompletelyNoMove = 0xD604E0,
        SetDeadMode = 0xD61430,
        SetDeadMode2 = 0x1404A5F20,
        SetDefaultAnimation = 0xD5F110,
        SetDefaultMapUid = 0xD5F680,
        SetDefaultRoutePoint = 0xD645A0,
        SetDisable = 0x1404A6300,
        SetDisableBackread_forEvent = 0xD60AD0,
        SetDisableDamage = 0xD5EC30,
        SetDisableGravity = 0xD610A0,
        SetDisableWeakDamageAnim = 0xD603D0,
        SetDisableWeakDamageAnim_light = 0xD60390,
        SetDispMask = 0xD61800,
        SetDrawEnable = 0xD600B0,
        SetDrawEnableArray = 0xD64530,
        SetDrawGroup = 0xD61A00,
        SetEnableEventPad = 0xD5E420,
        SetEventBodyBulletCorrect = 0xD5E6E0,
        SetEventBodyMaterialSeAndSfx = 0xD5E710,
        SetEventBodyMaxHp = 0xD61D70,
        SetEventCommand = 0xD5FCB0,
        SetEventCommandIndex = 0xD5FC70,
        SetEventFlag = 0x1404A0340,
        SetEventFlagValue = 0xD60360,
        SetEventGenerate = 0xD604B0,
        SetEventMovePointType = 0xD60BB0,
        SetEventSimpleTalk = 0xD64BD0,
        SetEventSpecialEffect = 0xD61280,
        SetEventSpecialEffect_2 = 0xD611C0,
        SetEventSpecialEffectOwner = 0xD61240,
        SetEventSpecialEffectOwner_2 = 0xD61190,
        SetEventTarget = 0xD61AA0,
        SetExVelocity = 0xD61F30,
        SetFirstSpeed = 0xD61E90,
        SetFirstSpeedPlus = 0xD61E50,
        SetFlagInitState = 0xD5DBF0,
        SetFootIKInterpolateType = 0xD60310,
        SetForceJoinBlackRequest = 0xD65DF0,
        SetHitInfo = 0xD61990,
        SetHitMask = 0xD64920,
        SetHp = 0x1404A51E0,
        SetIgnoreHit = 0xD61750,
        SetInfomationPriority = 0xD5DB10,
        SetInsideBattleArea = 0xD61050,
        SetIsAnimPauseOnRemoPlayForEvent = 0xD5F300,
        SetKeepCommandIndex = 0xD624F0,
        SetLoadWait = 0xD5D940,
        SetLockActPntInvalidateMask = 0xD608F0,
        SetMapUid = 0x1404A7120,
        SetMaxHp = 0xD5F910,
        SetMenuBrake = 0xD5DB70,
        SetMiniBlockIndex = 0xD5F5F0,
        SetMovePoint = 0xD61390,
        SetMultiWallMapUid = 0xD5F200,
        SetNoNetSync = 0xD606D0,
        SetObjDeactivate = 0xD5F120,
        SetObjDisableBreak = 0xD5F340,
        SetObjEventCollisionFill = 0xD5FF80,
        SetObjSfx = 0xD62320,
        SetReturnPointEntityId = 0xD5DC70,
        SetReviveWait = 0xD5E680,
        SetSelfBloodMapUid = 0xD5FFF0,
        SetSosSignPos = 0xD5F570,
        SetSosSignWarp = 0xD5E070,
        SetSpStayAndDamageAnimId = 0xD609C0,
        SetSpStayAndDamageAnimIdPlus = 0xD60980,
        SetSubMenuBrake = 0xD5D880,
        SetSummonedPos = 0xD5E090,
        SetSyncRideObjInfo = 0xD60520,
        SetSystemIgnore = 0xD605A0,
        SetTalkMsg = 0xD5E190,
        SetTeamType = 0xD60B50,
        SetTeamTypeDefault = 0xD60B00,
        SetTeamTypePlus = 0xD60B30,
        SetTextEffect = 0xD5E430,
        SetTutorialSummonedPos = 0xD5E080,
        SetValidTalk = 0xD5E5C0,
        ShowGenDialog = 0xD5EEF0,
        ShowRankingDialog = 0xD5D960,
        SOSMsgGetResult_Tutorial = 0xD5DA50,
        StopLoopAnimation = 0xD5FFC0,
        StopPlayer = 0xD60950,
        StopPointSE = 0xD5EA60,
        SubActionCount = 0xD5FBC0,
        SubDispMaskByBit = 0xD5FEA0,
        SubHitMask = 0xD64CA0,
        SubHitMaskByBit = 0xD64CF0,
        SummonBlackRequest = 0xD627D0,
        SummonedMapReload = 0xD60850,
        SummonSuccess = 0xD64BB0,
        SwitchDispMask = 0xD5FF20,
        SwitchHitMask = 0xD64DB0,
        TalkNextPage = 0xD5E640,
        TreasureDispModeChange = 0xD64860,
        TreasureDispModeChange2 = 0xD647C0,
        TurnCharactor = 0xD623A0,
        Tutorial_begin = 0xD5E030,
        Tutorial_end = 0xD5E020,
        UnLockSession = 0xD5E3F0,
        UpDateBloodMark = 0xD661F0,
        Util_RequestLevelUp = 0xD5D830,
        Util_RequestLevelUpFirst = 0xD5D850,
        Util_RequestRegene = 0xD5D820,
        Util_RequestRespawn = 0xD5D810,
        ValidPointLight = 0xD5F020,
        ValidSfx = 0xD5F0A0,
        VariableExpand_211_Param1 = 0xD5D8C0,
        VariableExpand_211_param2 = 0xD5D8B0,
        VariableExpand_211_param3 = 0xD5D8A0,
        VariableExpand_22_param1 = 0xD5D8E0,
        VariableExpand_22_param2 = 0xD5D8D0,
        VariableOrder_211 = 0xD5D8F0,
        VariableOrder_22 = 0xD5D910,
        WARN = 0xD62050,
        Warp = 0xD61D40,
        WarpDmy = 0xD64A70,
        WarpNextStage = 0x1404A37F0,
        WarpNextStage_Bonfire = 0xD62CA0,
        WarpNextStageKick = 0xD62930,
        WarpRestart = 0xD62580,
        WarpRestartNoGrey = 0xD62550,
        WarpSelfBloodMark = 0xD649D0
    }
    public enum FuncAddress32 : Int32
    {
        ActionEnd = 0xD616D0,
        AddActionCount = 0xD5FC20,
        AddBlockClearBonus = 0xD5E480,
        AddClearCount = 0xD5EC20,
        AddCorpseEvent = 0xD60930,
        AddCurrentVowRankPoint = 0xD600D0,
        AddCustomRoutePoint = 0xD645C0,
        AddDeathCount = 0xD5DE20,
        AddEventGoal = 0xD66000,
        AddEventParts = 0xD60D30,
        AddEventParts_Ignore = 0xD60CF0,
        AddEventSimpleTalk = 0xD62860,
        AddEventSimpleTalkTimer = 0xD62820,
        AddFieldInsFilter = 0xD62790,
        AddGeneEvent = 0xD622B0,
        AddHelpWhiteGhost = 0xD5DB50,
        AddHitMaskByBit = 0xD64D50,
        AddInfomationBuffer = 0xD64720,
        AddInfomationBufferTag = 0xD64730,
        AddInfomationList = 0xD62370,
        AddInfomationListItem = 0xD62350,
        AddInfomationTimeMsgTag = 0xD646F0,
        AddInfomationTosBuffer = 0xD646D0,
        AddInfomationTosBufferPlus = 0xD646B0,
        AddInventoryItem = 0xD664C0,
        AddKillBlackGhost = 0xD5DB30,
        AddQWC = 0xD5F810,
        AddRumble = 0xD640D0,
        AddTreasureEvent = 0xD5F3B0,
        AddTrueDeathCount = 0xD5DDF0,
        BeginAction = 0xD5FCF0,
        BeginLoopCheck = 0xD5FB90,
        CalcExcuteMultiBonus = 0xD5F4C0,
        CalcGetCurrentMapEntityId = 0xD5F230,
        CalcGetMultiWallEntityId = 0xD5E360,
        CamReset = 0xD5FB00,
        CastPointSpell = 0xD65FB0,
        CastPointSpell_Horming = 0xD65F10,
        CastPointSpellPlus = 0xD65F60,
        CastPointSpellPlus_Horming = 0xD65EC0,
        CastTargetSpell = 0xD65E90,
        CastTargetSpellPlus = 0xD65E50,
        ChangeGreyGhost = 0xD663D0,
        ChangeInitPosAng = 0xD60D70,
        ChangeModel = 0xD64C70,
        ChangeTarget = 0xD61DA0,
        ChangeThink = 0xD658A0,
        ChangeWander = 0xD61000,
        CharacterAllAttachSys = 0xD60860,
        CharactorCopyPosAng = 0xD64190,
        CheckChrHit_Obj = 0xD5EA00,
        CheckChrHit_Wall = 0xD5EA30,
        CheckEventBody = 0xD5EC60,
        CheckEventChr_Proxy = 0xD5E9E0,
        CheckPenalty = 0xD5EE50,
        ChrDisableUpdate = 0xD61460,
        ChrFadeIn = 0xD607E0,
        ChrFadeOut = 0xD60770,
        ChrResetAnimation = 0xD60670,
        ChrResetRequest = 0xD606A0,
        ClearBossGauge = 0xD5DD80,
        ClearMyWorldState = 0xD5EDD0,
        ClearSosSign = 0xD5EED0,
        ClearTarget = 0xD613C0,
        CloseGenDialog = 0xD5E500,
        CloseMenu = 0xD5ED00,
        CloseRankingDialog = 0xD5D950,
        CloseTalk = 0xD5E610,
        CompleteEvent = 0xD660A0,
        CreateCamSfx = 0xD620B0,
        CreateDamage_NoCollision = 0xD65DC0,
        CreateEventBody = 0xD65830,
        CreateEventBodyPlus = 0xD657C0,
        CreateHeroBloodStain = 0xD62640,
        CreateSfx = 0xD5F000,
        CreateSfx_DummyPoly = 0xD64140,
        CroseBriefingMsg = 0xD5E400,
        CustomLuaCall = 0xD62C30,
        CustomLuaCallStart = 0xD66240,
        CustomLuaCallStartPlus = 0xD66210,
        DeleteCamSfx = 0xD5E8A0,
        DeleteEvent = 0xD5EAA0,
        DeleteObjSfxAll = 0xD5E7B0,
        DeleteObjSfxDmyPlyID = 0xD5E7F0,
        DeleteObjSfxEventID = 0xD5E7D0,
        DisableCollection = 0xD60A40,
        DisableDamage = 0xD60DD0,
        DisableHpGauge = 0xD60A00,
        DisableInterupt = 0xD612B0,
        DisableMapHit = 0xD61790,
        DisableMove = 0xD617D0,
        DivideRest = 0x490520,
        EnableAction = 0xD5FD60,
        EnableGeneratorSystem = 0xD5EF20,
        EnableHide = 0xD60E00,
        EnableInvincible = 0xD60D90,
        EnableLogic = 0xD5FD90,
        EnableObjTreasure = 0xD661D0,
        EndAnimation = 0xD61BF0,
        EraseEventSpecialEffect = 0xD61210,
        EraseEventSpecialEffect_2 = 0xD61170,
        EventTagInsertString_forPlayerNo = 0xD5E820,
        ExcutePenalty = 0xD5EBE0,
        ForceChangeTarget = 0xD61E00,
        ForceDead = 0xD66690,
        ForcePlayAnimation = 0xD61CF0,
        ForcePlayAnimationStayCancel = 0xD61CA0,
        ForcePlayLoopAnimation = 0xD61C50,
        ForceSetOmissionLevel = 0xD60CB0,
        ForceUpdateNextFrame = 0xD60C90,
        GetBountyRankPoint = 0xD60130,
        GetClearBonus = 0xD5DEB0,
        GetClearCount = 0xD5E5A0,
        GetClearState = 0xD5E580,
        GetCurrentMapAreaNo = 0xD5F650,
        GetCurrentMapBlockNo = 0xD5F620,
        GetDeathState = 0xD5D800,
        GetDistance = 0xD61B70,
        GetEnemyPlayerId_Random = 0xD5ED10,
        GetEventFlagValue = 0xD60340,
        GetEventGoalState = 0xD612F0,
        GetEventMode = 0xD61690,
        GetEventRequest = 0xD610D0,
        GetFloorMaterial = 0xD60480,
        GetGlobalQWC = 0xD5F850,
        GetHeroPoint = 0xD5DC50,
        GetHostPlayerNo = 0xD5E260,
        GetHp = 0xD5FA80,
        GetHpRate = 0xD5FA30,
        GetItem = 0xD5E240,
        GetLadderCount = 0xD64580,
        GetLastBlockId = 0xD5EFC0,
        GetLocalPlayerChrType = 0xD5FB70,
        GetLocalPlayerId = 0xD5E270,
        GetLocalPlayerInvadeType = 0xD5FB50,
        GetLocalPlayerSoulLv = 0xD5EB30,
        GetLocalPlayerVowType = 0xD5FB20,
        GetLocalQWC = 0xD5F870,
        GetMultiWallNum = 0xD5DC40,
        GetNetPlayerChrType = 0xD5E8C0,
        GetObjHp = 0xD5F320,
        GetParam = 0xCD9FF0,
        GetParam1 = 0x403B00,
        GetParam2 = 0xB1CD50,
        GetParam3 = 0x788EE0,
        GetPartyMemberNum_InvadeType = 0xD5EBA0,
        GetPartyMemberNum_VowType = 0xD5F3A0,
        GetPlayerId_Random = 0xD5ED30,
        GetPlayerNo_LotNitoMultiItem = 0xD64100,
        GetPlayID = 0xB0E260,
        GetQWC = 0xD5F8C0,
        GetRandom = 0xD5E0F0,
        GetRateItem = 0xD665B0,
        GetRateItem_IgnoreMultiPlay = 0xD66590,
        GetReturnState = 0xD5E230,
        GetRightCurrentWeaponId = 0xD5EF80,
        GetSoloClearBonus = 0xD5DE60,
        GetSummonAnimId = 0xD60890,
        GetSummonBlackResult = 0xD5E530,
        GetTargetChrID = 0xD64160,
        GetTempSummonParam = 0xD5DDE0,
        GetTravelItemParamId = 0xD60440,
        GetWhiteGhostCount = 0xD5E3D0,
        HasSuppleItem = 0xD60430,
        HavePartyMember = 0xD5E1D0,
        HoverMoveVal = 0xD62C00,
        HoverMoveValDmy = 0xD648E0,
        IncrementCoopPlaySuccessCount = 0xD5F1D0,
        IncrementThiefInvadePlaySuccessCount = 0xD5F1A0,
        InfomationMenu = 0xD64110,
        InitDeathState = 0xD5D7E0,
        InvalidMyBloodMarkInfo = 0xD60E50,
        InvalidMyBloodMarkInfo_Tutorial = 0xD60E30,
        InvalidPointLight = 0xD5F060,
        InvalidSfx = 0xD5F780,
        IsAction = 0xD5FAB0,
        IsAlive = 0xD615E0,
        IsAliveMotion = 0xD5E6A0,
        IsAngle = 0xD61B30,
        IsAnglePlus = 0xD61AF0,
        IsAppearancePlayer = 0xD5F170,
        IsBlackGhost = 0xD60EF0,
        IsBlackGhost_NetPlayer = 0xD5E8F0,
        IsClearItem = 0xD5DCF0,
        IsClient = 0xD5E2E0,
        IsColiseumGhost = 0xD60EB0,
        IsCompleteEvent = 0xD60170,
        IsCompleteEventValue = 0xD60150,
        IsDead_NextGreyGhost = 0xD5E160,
        IsDeathPenaltySkip = 0xD5D7D0,
        IsDestroyed = 0xD5F0E0,
        IsDisable = 0xD60F70,
        IsDistance = 0xD61BA0,
        IsDropCheck_Only = 0xD60C00,
        IsEquip = 0xD5F4F0,
        IsEventAnim = 0xD61C30,
        IsFireDead = 0xD60400,
        IsForceSummoned = 0xD5EC00,
        IsGameClient = 0xD5EAF0,
        IsGreyGhost = 0xD60F30,
        IsGreyGhost_NetPlayer = 0xD5E970,
        IsHost = 0xD5E300,
        IsInParty = 0xD5E1F0,
        IsInParty_EnemyMember = 0xD5EEC0,
        IsInParty_FriendMember = 0xD5E440,
        IsIntruder = 0xD60ED0,
        IsInventoryEquip = 0xD5EF40,
        IsJobType = 0xD5E040,
        IsLand = 0xD60450,
        IsLiveNetPlayer = 0xD5E9B0,
        IsLivePlayer = 0xD60F50,
        IsLoadWait = 0xD5D930,
        IsMatchingMultiPlay = 0xD5ED80,
        IsOnline = 0xD5E2D0,
        IsOnlineMode = 0xD5DD50,
        IsPlayerAssessMenu_Tutorial = 0xD5E010,
        IsPlayerStay = 0xD61610,
        IsPlayMovie = 0xD60AF0,
        IsPrevGreyGhost = 0xD5E140,
        IsProcessEventGoal = 0xD61340,
        IsReady_Obj = 0xD5F370,
        IsRegionDrop = 0xD60C30,
        IsRegionIn = 0xD61020,
        IsRevengeRequested = 0xD5E2A0,
        IsReviveWait = 0xD5E660,
        IsShow_CampMenu = 0xD5DA20,
        IsShowMenu = 0xD5EA90,
        IsShowMenu_BriefingMsg = 0xD5DD70,
        IsShowMenu_GenDialog = 0xD5EA80,
        IsShowMenu_InfoMenu = 0xD5DB80,
        IsShowSosMsg_Tutorial = 0xD5E000,
        IsSuccessQWC = 0xD5F7D0,
        IsTryJoinSession = 0xD5E2B0,
        IsValidInstance = 0xD5F510,
        IsValidTalk = 0xD5E5F0,
        IsWhiteGhost = 0xD60F10,
        IsWhiteGhost_NetPlayer = 0xD5E930,
        LeaveSession = 0xD62900,
        LockSession = 0xD5EE60,
        LuaCall = 0xD62C60,
        LuaCallStart = 0xD66290,
        LuaCallStartPlus = 0xD66260,
        MultiDoping_AllEventBody = 0xD61D60,
        NoAnimeTurnCharactor = 0xD61480,
        NotNetMessage_begin = 0xD5DBE0,
        NotNetMessage_end = 0xD5DBD0,
        ObjRootMtxMove = 0xD647A0,
        ObjRootMtxMoveByChrDmyPoly = 0xD64760,
        ObjRootMtxMoveDmyPoly = 0xD64780,
        OnActionCheckKey = 0xD63B70,
        OnActionEventRegion = 0xD63C70,
        OnActionEventRegionAttribute = 0xD63BE0,
        OnBallista = 0xD5E290,
        OnBloodMenuClose = 0xD62FF0,
        OnBonfireEvent = 0xD64B40,
        OnCharacterAnimEnd = 0xD63860,
        OnCharacterDead = 0xD63AB0,
        OnCharacterHP = 0xD63A50,
        OnCharacterHP_CheckAttacker = 0xD639E0,
        OnCharacterHpRate = 0xD63980,
        OnCharacterTotalDamage = 0xD63750,
        OnCharacterTotalRateDamage = 0xD636C0,
        OnCheckEzStateMessage = 0xD63B10,
        OnChrAnimEnd = 0xD64570,
        OnChrAnimEndPlus = 0xD637D0,
        OnDistanceAction = 0xD65240,
        OnDistanceActionAttribute = 0xD65190,
        OnDistanceActionDmyPoly = 0xD64F70,
        OnDistanceActionPlus = 0xD650D0,
        OnDistanceActionPlusAttribute = 0xD65010,
        OnDistanceJustIn = 0xD64E50,
        OnEndFlow = 0xD62990,
        OnFireDamage = 0xD634B0,
        OnKeyTime2 = 0xD635D0,
        OnNetDistanceIn = 0xD62D40,
        OnNetRegion = 0xD625D0,
        OnNetRegionAttr = 0xD625A0,
        OnNetRegionAttrPlus = 0xD62DA0,
        OnNetRegionPlus = 0xD62E00,
        OnObjAnimEnd = 0xD64560,
        OnObjAnimEndPlus = 0xD64550,
        OnObjDestroy = 0xD63900,
        OnObjectDamageHit = 0xD659A0,
        OnObjectDamageHit_NoCall = 0xD65940,
        OnObjectDamageHit_NoCallPlus = 0xD658E0,
        OnPlayerActionInRegion = 0xD63EB0,
        OnPlayerActionInRegionAngle = 0xD63D90,
        OnPlayerActionInRegionAngleAttribute = 0xD63D00,
        OnPlayerActionInRegionAttribute = 0xD63E20,
        OnPlayerAssessMenu = 0xD629E0,
        OnPlayerDistanceAngleInTarget = 0xD652F0,
        OnPlayerDistanceInTarget = 0xD65380,
        OnPlayerDistanceOut = 0xD64EE0,
        OnPlayerKill = 0xD63430,
        OnRegionIn = 0xD64050,
        OnRegionJustIn = 0xD63FC0,
        OnRegionJustOut = 0xD63F40,
        OnRegistFunc = 0xD63050,
        OnRequestMenuEnd = 0xD62670,
        OnRevengeMenuClose = 0xD64AC0,
        OnSelectMenu = 0xD62EF0,
        OnSelfBloodMark = 0xD633B0,
        OnSelfHeroBloodMark = 0xD63330,
        OnSessionIn = 0xD63230,
        OnSessionInfo = 0xD630E0,
        OnSessionJustIn = 0xD632B0,
        OnSessionJustOut = 0xD631B0,
        OnSessionOut = 0xD63130,
        OnSimpleDamage = 0xD63540,
        OnTalkEvent = 0xD65BB0,
        OnTalkEventAngleOut = 0xD65A20,
        OnTalkEventDistIn = 0xD65B30,
        OnTalkEventDistOut = 0xD65AB0,
        OnTestEffectEndPlus = 0xD626C0,
        OnTextEffectEnd = 0xD62720,
        OnTurnCharactorEnd = 0xD62A30,
        OnWanderFade = 0xD622D0,
        OnWanderingDemon = 0xD62240,
        OnWarpMenuClose = 0xD62F90,
        OnYesNoDialog = 0xD62E60,
        OpenCampMenu = 0xD5DA80,
        OpeningDead = 0xD66600,
        OpeningDeadPlus = 0xD665D0,
        OpenSOSMsg_Tutorial = 0xD5E750,
        ParamInitialize = 0xD66360,
        PauseTutorial = 0xD5E0B0,
        PlayAnimation = 0xD61D10,
        PlayAnimationStayCancel = 0xD61CC0,
        PlayerChrResetAnimation_RemoOnly = 0xD60630,
        PlayLoopAnimation = 0xD61C70,
        PlayObjectSE = 0xD61660,
        PlayPointSE = 0xD61F00,
        PlayTypeSE = 0xD61630,
        RecallMenuEvent = 0xD62780,
        ReconstructBreak = 0xD66070,
        RecoveryHeroin = 0xD60740,
        RegistObjact = 0xD5D870,
        RegistSimpleTalk = 0xD628A0,
        RemoveInventoryEquip = 0xD60C70,
        RepeatMessage_begin = 0xD5DBC0,
        RepeatMessage_end = 0xD5DBB0,
        RequestEnding = 0xD5DDD0,
        RequestForceUpdateNetwork = 0xD60AA0,
        RequestFullRecover = 0xD5DD40,
        RequestGenerate = 0xD5F290,
        RequestNormalUpdateNetwork = 0xD60A70,
        RequestOpenBriefingMsg = 0xD5EB50,
        RequestOpenBriefingMsgPlus = 0xD62260,
        RequestPlayMovie = 0xD65750,
        RequestPlayMoviePlus = 0xD656D0,
        RequestRemo = 0xD66440,
        RequestRemoPlus = 0xD663E0,
        RequestUnlockTrophy = 0xD5EBB0,
        ReqularLeavePlayer = 0xD5E3E0,
        ResetCamAngle = 0xD5EB20,
        ResetEventQwcSpEffect = 0xD61ED0,
        ResetSummonParam = 0xD5EB80,
        ResetSyncRideObjInfo = 0xD60500,
        ResetThink = 0xD61070,
        RestorePiece = 0xD64C40,
        ReturnMapSelect = 0xD5E1C0,
        RevivePlayer = 0xD645E0,
        RevivePlayerNext = 0xD5E0A0,
        SaveRequest = 0xD5EE90,
        SaveRequest_Profile = 0xD5EE70,
        SendEventRequest = 0xD61130,
        SetAlive = 0xD664A0,
        SetAliveMotion = 0xD5E6C0,
        SetAlwaysDrawForEvent = 0xD60570,
        SetAlwaysEnableBackread_forEvent = 0xD60750,
        SetAngleFoward = 0xD61A80,
        SetAreaStartMapUid = 0xD5F720,
        SetBossGauge = 0xD60700,
        SetBossUnitJrHit = 0xD61710,
        SetBountyRankPoint = 0xD64E00,
        SetBrokenPiece = 0xD5F7A0,
        SetCamModeParamTargetId = 0xD5DF00,
        SetCamModeParamTargetIdForBossLock = 0xD5DEF0,
        SetChrType = 0xD60E70,
        SetChrTypeDataGrey = 0xD5DFB0,
        SetChrTypeDataGreyNext = 0xD5DF50,
        SetClearBonus = 0xD5F3D0,
        SetClearItem = 0xD5DCD0,
        SetClearSesiionCount = 0xD5E4C0,
        SetClearState = 0xD5E560,
        SetColiEnable = 0xD60090,
        SetColiEnableArray = 0xD64AA0,
        SetCompletelyNoMove = 0xD604E0,
        SetDeadMode = 0xD61430,
        SetDeadMode2 = 0xD613F0,
        SetDefaultAnimation = 0xD5F110,
        SetDefaultMapUid = 0xD5F680,
        SetDefaultRoutePoint = 0xD645A0,
        SetDisable = 0xD60FC0,
        SetDisableBackread_forEvent = 0xD60AD0,
        SetDisableDamage = 0xD5EC30,
        SetDisableGravity = 0xD610A0,
        SetDisableWeakDamageAnim = 0xD603D0,
        SetDisableWeakDamageAnim_light = 0xD60390,
        SetDispMask = 0xD61800,
        SetDrawEnable = 0xD600B0,
        SetDrawEnableArray = 0xD64530,
        SetDrawGroup = 0xD61A00,
        SetEnableEventPad = 0xD5E420,
        SetEventBodyBulletCorrect = 0xD5E6E0,
        SetEventBodyMaterialSeAndSfx = 0xD5E710,
        SetEventBodyMaxHp = 0xD61D70,
        SetEventCommand = 0xD5FCB0,
        SetEventCommandIndex = 0xD5FC70,
        SetEventFlag = 0xD60190,
        SetEventFlagValue = 0xD60360,
        SetEventGenerate = 0xD604B0,
        SetEventMovePointType = 0xD60BB0,
        SetEventSimpleTalk = 0xD64BD0,
        SetEventSpecialEffect = 0xD61280,
        SetEventSpecialEffect_2 = 0xD611C0,
        SetEventSpecialEffectOwner = 0xD61240,
        SetEventSpecialEffectOwner_2 = 0xD61190,
        SetEventTarget = 0xD61AA0,
        SetExVelocity = 0xD61F30,
        SetFirstSpeed = 0xD61E90,
        SetFirstSpeedPlus = 0xD61E50,
        SetFlagInitState = 0xD5DBF0,
        SetFootIKInterpolateType = 0xD60310,
        SetForceJoinBlackRequest = 0xD65DF0,
        SetHitInfo = 0xD61990,
        SetHitMask = 0xD64920,
        SetHp = 0xD5F9A0,
        SetIgnoreHit = 0xD61750,
        SetInfomationPriority = 0xD5DB10,
        SetInsideBattleArea = 0xD61050,
        SetIsAnimPauseOnRemoPlayForEvent = 0xD5F300,
        SetKeepCommandIndex = 0xD624F0,
        SetLoadWait = 0xD5D940,
        SetLockActPntInvalidateMask = 0xD608F0,
        SetMapUid = 0xD64610,
        SetMaxHp = 0xD5F910,
        SetMenuBrake = 0xD5DB70,
        SetMiniBlockIndex = 0xD5F5F0,
        SetMovePoint = 0xD61390,
        SetMultiWallMapUid = 0xD5F200,
        SetNoNetSync = 0xD606D0,
        SetObjDeactivate = 0xD5F120,
        SetObjDisableBreak = 0xD5F340,
        SetObjEventCollisionFill = 0xD5FF80,
        SetObjSfx = 0xD62320,
        SetReturnPointEntityId = 0xD5DC70,
        SetReviveWait = 0xD5E680,
        SetSelfBloodMapUid = 0xD5FFF0,
        SetSosSignPos = 0xD5F570,
        SetSosSignWarp = 0xD5E070,
        SetSpStayAndDamageAnimId = 0xD609C0,
        SetSpStayAndDamageAnimIdPlus = 0xD60980,
        SetSubMenuBrake = 0xD5D880,
        SetSummonedPos = 0xD5E090,
        SetSyncRideObjInfo = 0xD60520,
        SetSystemIgnore = 0xD605A0,
        SetTalkMsg = 0xD5E190,
        SetTeamType = 0xD60B50,
        SetTeamTypeDefault = 0xD60B00,
        SetTeamTypePlus = 0xD60B30,
        SetTextEffect = 0xD5E430,
        SetTutorialSummonedPos = 0xD5E080,
        SetValidTalk = 0xD5E5C0,
        ShowGenDialog = 0xD5EEF0,
        ShowRankingDialog = 0xD5D960,
        SOSMsgGetResult_Tutorial = 0xD5DA50,
        StopLoopAnimation = 0xD5FFC0,
        StopPlayer = 0xD60950,
        StopPointSE = 0xD5EA60,
        SubActionCount = 0xD5FBC0,
        SubDispMaskByBit = 0xD5FEA0,
        SubHitMask = 0xD64CA0,
        SubHitMaskByBit = 0xD64CF0,
        SummonBlackRequest = 0xD627D0,
        SummonedMapReload = 0xD60850,
        SummonSuccess = 0xD64BB0,
        SwitchDispMask = 0xD5FF20,
        SwitchHitMask = 0xD64DB0,
        TalkNextPage = 0xD5E640,
        TreasureDispModeChange = 0xD64860,
        TreasureDispModeChange2 = 0xD647C0,
        TurnCharactor = 0xD623A0,
        Tutorial_begin = 0xD5E030,
        Tutorial_end = 0xD5E020,
        UnLockSession = 0xD5E3F0,
        UpDateBloodMark = 0xD661F0,
        Util_RequestLevelUp = 0xD5D830,
        Util_RequestLevelUpFirst = 0xD5D850,
        Util_RequestRegene = 0xD5D820,
        Util_RequestRespawn = 0xD5D810,
        ValidPointLight = 0xD5F020,
        ValidSfx = 0xD5F0A0,
        VariableExpand_211_Param1 = 0xD5D8C0,
        VariableExpand_211_param2 = 0xD5D8B0,
        VariableExpand_211_param3 = 0xD5D8A0,
        VariableExpand_22_param1 = 0xD5D8E0,
        VariableExpand_22_param2 = 0xD5D8D0,
        VariableOrder_211 = 0xD5D8F0,
        VariableOrder_22 = 0xD5D910,
        WARN = 0xD62050,
        Warp = 0xD61D40,
        WarpDmy = 0xD64A70,
        WarpNextStage = 0xD62D00,
        WarpNextStage_Bonfire = 0xD62CA0,
        WarpNextStageKick = 0xD62930,
        WarpRestart = 0xD62580,
        WarpRestartNoGrey = 0xD62550,
        WarpSelfBloodMark = 0xD649D0
    }


}
