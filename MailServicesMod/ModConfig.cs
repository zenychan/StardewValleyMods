﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailServicesMod
{
    public class ModConfig : RecoveryConfig
    {
        public bool DisableToolDeliveryService;
        public bool DisableToolShipmentService;
        public bool DisableQuestService;
        public bool DisableGiftService;
        public bool ShowDialogOnItemDelivery;
        public int GiftChoicePageSize = 5;
        public bool EnableJealousyFromMailedGifts;
        public bool EnableGiftToMaxFriendshipNPC;
        public bool DisablePerPlayerConfig;
        public Dictionary<long, PlayerRecoveryConfig> PlayerRecoveryConfig = new Dictionary<long, PlayerRecoveryConfig>();
    }

    public class RecoveryConfig
    {
        public bool DisableRecoveryConfigInGameChanges;
        public bool EnableRecoveryService;
        public bool RecoverAllItems;
        public bool RecoverForFree;
        public bool DisableClearLostItemsOnRandomRecovery;
    }

    public class PlayerRecoveryConfig : RecoveryConfig
    {
        public string PlayerName;
    }
}
