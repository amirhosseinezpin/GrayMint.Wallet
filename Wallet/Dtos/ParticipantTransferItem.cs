﻿namespace EWallet.Dtos;

public class ParticipantTransferItem
{
    public required int SenderWalletId { get; init; }
    public required int ReceiverWalletId { get; init; }
    public required decimal Amount { get; init; }
}