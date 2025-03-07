---
external help file:
Module Name: Az.Marketplace
online version: https://learn.microsoft.com/powershell/module/az.marketplace/update-azmarketplaceprivatestorecollectionoffer
schema: 2.0.0
---

# Update-AzMarketplacePrivateStoreCollectionOffer

## SYNOPSIS
Update or add an offer to a specific collection of the private store.

## SYNTAX

### UpdateExpanded (Default)
```
Update-AzMarketplacePrivateStoreCollectionOffer -CollectionId <String> -OfferId <String>
 -PrivateStoreId <String> [-ETag <String>] [-IconFileUri <Hashtable>] [-Plan <IPlan[]>]
 [-SpecificPlanIdLimitation <String[]>] [-UpdateSuppressedDueIdempotence] [-DefaultProfile <PSObject>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityCollection
```
Update-AzMarketplacePrivateStoreCollectionOffer -CollectionInputObject <IMarketplaceIdentity>
 -OfferId <String> -Payload <IOffer> [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityCollectionExpanded
```
Update-AzMarketplacePrivateStoreCollectionOffer -CollectionInputObject <IMarketplaceIdentity>
 -OfferId <String> [-ETag <String>] [-IconFileUri <Hashtable>] [-Plan <IPlan[]>]
 [-SpecificPlanIdLimitation <String[]>] [-UpdateSuppressedDueIdempotence] [-DefaultProfile <PSObject>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-AzMarketplacePrivateStoreCollectionOffer -InputObject <IMarketplaceIdentity> [-ETag <String>]
 [-IconFileUri <Hashtable>] [-Plan <IPlan[]>] [-SpecificPlanIdLimitation <String[]>]
 [-UpdateSuppressedDueIdempotence] [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityPrivateStore
```
Update-AzMarketplacePrivateStoreCollectionOffer -CollectionId <String> -OfferId <String>
 -PrivateStoreInputObject <IMarketplaceIdentity> -Payload <IOffer> [-DefaultProfile <PSObject>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityPrivateStoreExpanded
```
Update-AzMarketplacePrivateStoreCollectionOffer -CollectionId <String> -OfferId <String>
 -PrivateStoreInputObject <IMarketplaceIdentity> [-ETag <String>] [-IconFileUri <Hashtable>] [-Plan <IPlan[]>]
 [-SpecificPlanIdLimitation <String[]>] [-UpdateSuppressedDueIdempotence] [-DefaultProfile <PSObject>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update or add an offer to a specific collection of the private store.

## EXAMPLES

### Example 1: Update private store collection offer
```powershell
Update-AzMarketplacePrivateStoreCollectionOffer -PrivateStoreId a260d38c-96cf-492d-a340-404d0c4b3ad6 -CollectionId 8c7a91db-cd41-43b6-af47-2e869654126d -OfferId "aumatics.azure_managedservices" -SpecificPlanIdLimitation $null
```

Update private store collection offer.

## PARAMETERS

### -CollectionId
The collection ID

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityPrivateStore, UpdateViaIdentityPrivateStoreExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CollectionInputObject
Identity Parameter
To construct, see NOTES section for COLLECTIONINPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IMarketplaceIdentity
Parameter Sets: UpdateViaIdentityCollection, UpdateViaIdentityCollectionExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DefaultProfile
The DefaultProfile parameter is not functional.
Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.

```yaml
Type: System.Management.Automation.PSObject
Parameter Sets: (All)
Aliases: AzureRMContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ETag
Identifier for purposes of race condition

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityCollectionExpanded, UpdateViaIdentityExpanded, UpdateViaIdentityPrivateStoreExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IconFileUri
Icon File Uris

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded, UpdateViaIdentityCollectionExpanded, UpdateViaIdentityExpanded, UpdateViaIdentityPrivateStoreExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IMarketplaceIdentity
Parameter Sets: UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -OfferId
The offer ID to update or delete

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityCollection, UpdateViaIdentityCollectionExpanded, UpdateViaIdentityPrivateStore, UpdateViaIdentityPrivateStoreExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Payload
The privateStore offer data structure.
To construct, see NOTES section for PAYLOAD properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IOffer
Parameter Sets: UpdateViaIdentityCollection, UpdateViaIdentityPrivateStore
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Plan
Offer plans
To construct, see NOTES section for PLAN properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IPlan[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityCollectionExpanded, UpdateViaIdentityExpanded, UpdateViaIdentityPrivateStoreExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PrivateStoreId
The store ID - must use the tenant ID

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PrivateStoreInputObject
Identity Parameter
To construct, see NOTES section for PRIVATESTOREINPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IMarketplaceIdentity
Parameter Sets: UpdateViaIdentityPrivateStore, UpdateViaIdentityPrivateStoreExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -SpecificPlanIdLimitation
Plan ids limitation for this offer

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityCollectionExpanded, UpdateViaIdentityExpanded, UpdateViaIdentityPrivateStoreExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UpdateSuppressedDueIdempotence
Indicating whether the offer was not updated to db (true = not updated).
If the allow list is identical to the existed one in db, the offer would not be updated.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityCollectionExpanded, UpdateViaIdentityExpanded, UpdateViaIdentityPrivateStoreExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IMarketplaceIdentity

### Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IOffer

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IOffer

## NOTES

## RELATED LINKS

