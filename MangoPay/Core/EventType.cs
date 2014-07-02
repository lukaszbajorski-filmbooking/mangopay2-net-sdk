﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangoPay.Core
{
    /// <summary>Event types enumeration.</summary>
    public enum EventType
    {
        All,
        PAYIN_NORMAL_CREATED,
        PAYIN_NORMAL_SUCCEEDED,
        PAYIN_NORMAL_FAILED,
        PAYOUT_NORMAL_CREATED,
        PAYOUT_NORMAL_SUCCEEDED,
        PAYOUT_NORMAL_FAILED,
        TRANSFER_NORMAL_CREATED,
        TRANSFER_NORMAL_SUCCEEDED,
        TRANSFER_NORMAL_FAILED,
        PAYIN_REFUND_CREATED,
        PAYIN_REFUND_SUCCEEDED,
        PAYIN_REFUND_FAILED,
        PAYOUT_REFUND_CREATED,
        PAYOUT_REFUND_SUCCEEDED,
        PAYOUT_REFUND_FAILED,
        TRANSFER_REFUND_CREATED,
        TRANSFER_REFUND_SUCCEEDED,
        TRANSFER_REFUND_FAILED,
        KYC_CREATED,
        KYC_VALIDATION_ASKED,
        KYC_SUCCEEDED,
        KYC_FAILED
    }
}
