// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Networking/Requests/RequestType.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Requests {

  /// <summary>Holder for reflection information generated from POGOProtos/Networking/Requests/RequestType.proto</summary>
  public static partial class RequestTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Networking/Requests/RequestType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RequestTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjBQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVxdWVzdHMvUmVxdWVzdFR5cGUu",
            "cHJvdG8SHlBPR09Qcm90b3MuTmV0d29ya2luZy5SZXF1ZXN0cyrBDQoLUmVx",
            "dWVzdFR5cGUSEAoMTUVUSE9EX1VOU0VUEAASEQoNUExBWUVSX1VQREFURRAB",
            "Eg4KCkdFVF9QTEFZRVIQAhIRCg1HRVRfSU5WRU5UT1JZEAQSFQoRRE9XTkxP",
            "QURfU0VUVElOR1MQBRIbChdET1dOTE9BRF9JVEVNX1RFTVBMQVRFUxAGEiIK",
            "HkRPV05MT0FEX1JFTU9URV9DT05GSUdfVkVSU0lPThAHEh4KGlJFR0lTVEVS",
            "X0JBQ0tHUk9VTkRfREVWSUNFEAgSDwoLRk9SVF9TRUFSQ0gQZRINCglFTkNP",
            "VU5URVIQZhIRCg1DQVRDSF9QT0tFTU9OEGcSEAoMRk9SVF9ERVRBSUxTEGgS",
            "DAoISVRFTV9VU0UQaRITCg9HRVRfTUFQX09CSkVDVFMQahIXChNGT1JUX0RF",
            "UExPWV9QT0tFTU9OEG4SFwoTRk9SVF9SRUNBTExfUE9LRU1PThBvEhMKD1JF",
            "TEVBU0VfUE9LRU1PThBwEhMKD1VTRV9JVEVNX1BPVElPThBxEhQKEFVTRV9J",
            "VEVNX0NBUFRVUkUQchIRCg1VU0VfSVRFTV9GTEVFEHMSEwoPVVNFX0lURU1f",
            "UkVWSVZFEHQSEAoMVFJBREVfU0VBUkNIEHUSDwoLVFJBREVfT0ZGRVIQdhIS",
            "Cg5UUkFERV9SRVNQT05TRRB3EhAKDFRSQURFX1JFU1VMVBB4EhYKEkdFVF9Q",
            "TEFZRVJfUFJPRklMRRB5EhEKDUdFVF9JVEVNX1BBQ0sQehIRCg1CVVlfSVRF",
            "TV9QQUNLEHsSEAoMQlVZX0dFTV9QQUNLEHwSEgoORVZPTFZFX1BPS0VNT04Q",
            "fRIUChBHRVRfSEFUQ0hFRF9FR0dTEH4SHwobRU5DT1VOVEVSX1RVVE9SSUFM",
            "X0NPTVBMRVRFEH8SFQoQTEVWRUxfVVBfUkVXQVJEUxCAARIZChRDSEVDS19B",
            "V0FSREVEX0JBREdFUxCBARIRCgxVU0VfSVRFTV9HWU0QhQESFAoPR0VUX0dZ",
            "TV9ERVRBSUxTEIYBEhUKEFNUQVJUX0dZTV9CQVRUTEUQhwESDwoKQVRUQUNL",
            "X0dZTRCIARIbChZSRUNZQ0xFX0lOVkVOVE9SWV9JVEVNEIkBEhgKE0NPTExF",
            "Q1RfREFJTFlfQk9OVVMQigESFgoRVVNFX0lURU1fWFBfQk9PU1QQiwESGwoW",
            "VVNFX0lURU1fRUdHX0lOQ1VCQVRPUhCMARIQCgtVU0VfSU5DRU5TRRCNARIY",
            "ChNHRVRfSU5DRU5TRV9QT0tFTU9OEI4BEhYKEUlOQ0VOU0VfRU5DT1VOVEVS",
            "EI8BEhYKEUFERF9GT1JUX01PRElGSUVSEJABEhMKDkRJU0tfRU5DT1VOVEVS",
            "EJEBEiEKHENPTExFQ1RfREFJTFlfREVGRU5ERVJfQk9OVVMQkgESFAoPVVBH",
            "UkFERV9QT0tFTU9OEJMBEhkKFFNFVF9GQVZPUklURV9QT0tFTU9OEJQBEhUK",
            "EE5JQ0tOQU1FX1BPS0VNT04QlQESEAoLRVFVSVBfQkFER0UQlgESGQoUU0VU",
            "X0NPTlRBQ1RfU0VUVElOR1MQlwESFgoRU0VUX0JVRERZX1BPS0VNT04QmAES",
            "FQoQR0VUX0JVRERZX1dBTEtFRBCZARIVChBHRVRfQVNTRVRfRElHRVNUEKwC",
            "EhYKEUdFVF9ET1dOTE9BRF9VUkxTEK0CEhMKDkNMQUlNX0NPREVOQU1FEJMD",
            "Eg8KClNFVF9BVkFUQVIQlAMSFAoPU0VUX1BMQVlFUl9URUFNEJUDEhsKFk1B",
            "UktfVFVUT1JJQUxfQ09NUExFVEUQlgMSFgoRTE9BRF9TUEFXTl9QT0lOVFMQ",
            "9AMSFAoPQ0hFQ0tfQ0hBTExFTkdFENgEEhUKEFZFUklGWV9DSEFMTEVOR0UQ",
            "2QQSCQoERUNITxCaBRIbChZERUJVR19VUERBVEVfSU5WRU5UT1JZELwFEhgK",
            "E0RFQlVHX0RFTEVURV9QTEFZRVIQvQUSFwoSU0ZJREFfUkVHSVNUUkFUSU9O",
            "EKAGEhUKEFNGSURBX0FDVElPTl9MT0cQoQYSGAoTU0ZJREFfQ0VSVElGSUNB",
            "VElPThCiBhIRCgxTRklEQV9VUERBVEUQowYSEQoMU0ZJREFfQUNUSU9OEKQG",
            "EhEKDFNGSURBX0RPV1NFUhClBhISCg1TRklEQV9DQVBUVVJFEKYGEh8KGkxJ",
            "U1RfQVZBVEFSX0NVU1RPTUlaQVRJT05TEKcGEh4KGVNFVF9BVkFUQVJfSVRF",
            "TV9BU19WSUVXRUQQqAZiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::POGOProtos.Networking.Requests.RequestType), }, null));
    }
    #endregion

  }
  #region Enums
  public enum RequestType {
    /// <summary>
    ///  No implementation required
    /// </summary>
    [pbr::OriginalName("METHOD_UNSET")] MethodUnset = 0,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("PLAYER_UPDATE")] PlayerUpdate = 1,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("GET_PLAYER")] GetPlayer = 2,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("GET_INVENTORY")] GetInventory = 4,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("DOWNLOAD_SETTINGS")] DownloadSettings = 5,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("DOWNLOAD_ITEM_TEMPLATES")] DownloadItemTemplates = 6,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("DOWNLOAD_REMOTE_CONFIG_VERSION")] DownloadRemoteConfigVersion = 7,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("REGISTER_BACKGROUND_DEVICE")] RegisterBackgroundDevice = 8,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("FORT_SEARCH")] FortSearch = 101,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("ENCOUNTER")] Encounter = 102,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("CATCH_POKEMON")] CatchPokemon = 103,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("FORT_DETAILS")] FortDetails = 104,
    /// <summary>
    ///  Can't find this one
    /// </summary>
    [pbr::OriginalName("ITEM_USE")] ItemUse = 105,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("GET_MAP_OBJECTS")] GetMapObjects = 106,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("FORT_DEPLOY_POKEMON")] FortDeployPokemon = 110,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("FORT_RECALL_POKEMON")] FortRecallPokemon = 111,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("RELEASE_POKEMON")] ReleasePokemon = 112,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("USE_ITEM_POTION")] UseItemPotion = 113,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("USE_ITEM_CAPTURE")] UseItemCapture = 114,
    /// <summary>
    ///  Can't find this one
    /// </summary>
    [pbr::OriginalName("USE_ITEM_FLEE")] UseItemFlee = 115,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("USE_ITEM_REVIVE")] UseItemRevive = 116,
    /// <summary>
    ///  Not yet implemented in the game
    /// </summary>
    [pbr::OriginalName("TRADE_SEARCH")] TradeSearch = 117,
    /// <summary>
    ///  Not yet implemented in the game
    /// </summary>
    [pbr::OriginalName("TRADE_OFFER")] TradeOffer = 118,
    /// <summary>
    ///  Not yet implemented in the game
    /// </summary>
    [pbr::OriginalName("TRADE_RESPONSE")] TradeResponse = 119,
    /// <summary>
    ///  Not yet implemented in the game
    /// </summary>
    [pbr::OriginalName("TRADE_RESULT")] TradeResult = 120,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("GET_PLAYER_PROFILE")] GetPlayerProfile = 121,
    /// <summary>
    ///  Can't find this one
    /// </summary>
    [pbr::OriginalName("GET_ITEM_PACK")] GetItemPack = 122,
    /// <summary>
    ///  Can't find this one
    /// </summary>
    [pbr::OriginalName("BUY_ITEM_PACK")] BuyItemPack = 123,
    /// <summary>
    ///  Can't find this one
    /// </summary>
    [pbr::OriginalName("BUY_GEM_PACK")] BuyGemPack = 124,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("EVOLVE_POKEMON")] EvolvePokemon = 125,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("GET_HATCHED_EGGS")] GetHatchedEggs = 126,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("ENCOUNTER_TUTORIAL_COMPLETE")] EncounterTutorialComplete = 127,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("LEVEL_UP_REWARDS")] LevelUpRewards = 128,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("CHECK_AWARDED_BADGES")] CheckAwardedBadges = 129,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("USE_ITEM_GYM")] UseItemGym = 133,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("GET_GYM_DETAILS")] GetGymDetails = 134,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("START_GYM_BATTLE")] StartGymBattle = 135,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("ATTACK_GYM")] AttackGym = 136,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("RECYCLE_INVENTORY_ITEM")] RecycleInventoryItem = 137,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("COLLECT_DAILY_BONUS")] CollectDailyBonus = 138,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("USE_ITEM_XP_BOOST")] UseItemXpBoost = 139,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("USE_ITEM_EGG_INCUBATOR")] UseItemEggIncubator = 140,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("USE_INCENSE")] UseIncense = 141,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("GET_INCENSE_POKEMON")] GetIncensePokemon = 142,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("INCENSE_ENCOUNTER")] IncenseEncounter = 143,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("ADD_FORT_MODIFIER")] AddFortModifier = 144,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("DISK_ENCOUNTER")] DiskEncounter = 145,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("COLLECT_DAILY_DEFENDER_BONUS")] CollectDailyDefenderBonus = 146,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("UPGRADE_POKEMON")] UpgradePokemon = 147,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("SET_FAVORITE_POKEMON")] SetFavoritePokemon = 148,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("NICKNAME_POKEMON")] NicknamePokemon = 149,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("EQUIP_BADGE")] EquipBadge = 150,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("SET_CONTACT_SETTINGS")] SetContactSettings = 151,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("SET_BUDDY_POKEMON")] SetBuddyPokemon = 152,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("GET_BUDDY_WALKED")] GetBuddyWalked = 153,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("GET_ASSET_DIGEST")] GetAssetDigest = 300,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("GET_DOWNLOAD_URLS")] GetDownloadUrls = 301,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("CLAIM_CODENAME")] ClaimCodename = 403,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("SET_AVATAR")] SetAvatar = 404,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("SET_PLAYER_TEAM")] SetPlayerTeam = 405,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("MARK_TUTORIAL_COMPLETE")] MarkTutorialComplete = 406,
    /// <summary>
    ///  Can't find this one
    /// </summary>
    [pbr::OriginalName("LOAD_SPAWN_POINTS")] LoadSpawnPoints = 500,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("CHECK_CHALLENGE")] CheckChallenge = 600,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("VERIFY_CHALLENGE")] VerifyChallenge = 601,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("ECHO")] Echo = 666,
    [pbr::OriginalName("DEBUG_UPDATE_INVENTORY")] DebugUpdateInventory = 700,
    [pbr::OriginalName("DEBUG_DELETE_PLAYER")] DebugDeletePlayer = 701,
    /// <summary>
    ///  Not yet released.
    /// </summary>
    [pbr::OriginalName("SFIDA_REGISTRATION")] SfidaRegistration = 800,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("SFIDA_ACTION_LOG")] SfidaActionLog = 801,
    /// <summary>
    ///  Not yet released.
    /// </summary>
    [pbr::OriginalName("SFIDA_CERTIFICATION")] SfidaCertification = 802,
    /// <summary>
    ///  Not yet released.
    /// </summary>
    [pbr::OriginalName("SFIDA_UPDATE")] SfidaUpdate = 803,
    /// <summary>
    ///  Not yet released.
    /// </summary>
    [pbr::OriginalName("SFIDA_ACTION")] SfidaAction = 804,
    /// <summary>
    ///  Not yet released.
    /// </summary>
    [pbr::OriginalName("SFIDA_DOWSER")] SfidaDowser = 805,
    /// <summary>
    ///  Not yet released.
    /// </summary>
    [pbr::OriginalName("SFIDA_CAPTURE")] SfidaCapture = 806,
    [pbr::OriginalName("LIST_AVATAR_CUSTOMIZATIONS")] ListAvatarCustomizations = 807,
    [pbr::OriginalName("SET_AVATAR_ITEM_AS_VIEWED")] SetAvatarItemAsViewed = 808,
  }

  #endregion

}

#endregion Designer generated code