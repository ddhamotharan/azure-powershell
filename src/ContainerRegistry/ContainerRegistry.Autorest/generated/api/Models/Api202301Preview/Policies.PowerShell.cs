// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.PowerShell;

    /// <summary>The policies for a container registry.</summary>
    [System.ComponentModel.TypeConverter(typeof(PoliciesTypeConverter))]
    public partial class Policies
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.Policies"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPolicies" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPolicies DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new Policies(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.Policies"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPolicies" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPolicies DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new Policies(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Policies" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="Policies" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPolicies FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.Policies"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal Policies(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("QuarantinePolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPoliciesInternal)this).QuarantinePolicy = (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IQuarantinePolicy) content.GetValueForProperty("QuarantinePolicy",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPoliciesInternal)this).QuarantinePolicy, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.QuarantinePolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("TrustPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPoliciesInternal)this).TrustPolicy = (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.ITrustPolicy) content.GetValueForProperty("TrustPolicy",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPoliciesInternal)this).TrustPolicy, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.TrustPolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("RetentionPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPoliciesInternal)this).RetentionPolicy = (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IRetentionPolicy) content.GetValueForProperty("RetentionPolicy",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPoliciesInternal)this).RetentionPolicy, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.RetentionPolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("ExportPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPoliciesInternal)this).ExportPolicy = (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IExportPolicy) content.GetValueForProperty("ExportPolicy",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPoliciesInternal)this).ExportPolicy, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.ExportPolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("AzureAdAuthenticationAsArmPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPoliciesInternal)this).AzureAdAuthenticationAsArmPolicy = (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IAzureAdAuthenticationAsArmPolicy) content.GetValueForProperty("AzureAdAuthenticationAsArmPolicy",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPoliciesInternal)this).AzureAdAuthenticationAsArmPolicy, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.AzureAdAuthenticationAsArmPolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("SoftDeletePolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPoliciesInternal)this).SoftDeletePolicy = (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.ISoftDeletePolicy) content.GetValueForProperty("SoftDeletePolicy",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPoliciesInternal)this).SoftDeletePolicy, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.SoftDeletePolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("TrustPolicyType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPoliciesInternal)this).TrustPolicyType = (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TrustPolicyType?) content.GetValueForProperty("TrustPolicyType",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPoliciesInternal)this).TrustPolicyType, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TrustPolicyType.CreateFrom);
            }
            if (content.Contains("RetentionPolicyDay"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPoliciesInternal)this).RetentionPolicyDay = (int?) content.GetValueForProperty("RetentionPolicyDay",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPoliciesInternal)this).RetentionPolicyDay, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("ExportPolicyStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPoliciesInternal)this).ExportPolicyStatus = (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.ExportPolicyStatus?) content.GetValueForProperty("ExportPolicyStatus",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPoliciesInternal)this).ExportPolicyStatus, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.ExportPolicyStatus.CreateFrom);
            }
            if (content.Contains("SoftDeletePolicyRetentionDay"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPoliciesInternal)this).SoftDeletePolicyRetentionDay = (int?) content.GetValueForProperty("SoftDeletePolicyRetentionDay",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPoliciesInternal)this).SoftDeletePolicyRetentionDay, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("QuarantinePolicyStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPoliciesInternal)this).QuarantinePolicyStatus = (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.PolicyStatus?) content.GetValueForProperty("QuarantinePolicyStatus",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPoliciesInternal)this).QuarantinePolicyStatus, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.PolicyStatus.CreateFrom);
            }
            if (content.Contains("TrustPolicyStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPoliciesInternal)this).TrustPolicyStatus = (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.PolicyStatus?) content.GetValueForProperty("TrustPolicyStatus",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPoliciesInternal)this).TrustPolicyStatus, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.PolicyStatus.CreateFrom);
            }
            if (content.Contains("RetentionPolicyLastUpdatedTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPoliciesInternal)this).RetentionPolicyLastUpdatedTime = (global::System.DateTime?) content.GetValueForProperty("RetentionPolicyLastUpdatedTime",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPoliciesInternal)this).RetentionPolicyLastUpdatedTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("RetentionPolicyStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPoliciesInternal)this).RetentionPolicyStatus = (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.PolicyStatus?) content.GetValueForProperty("RetentionPolicyStatus",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPoliciesInternal)this).RetentionPolicyStatus, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.PolicyStatus.CreateFrom);
            }
            if (content.Contains("AzureAdAuthenticationAsArmPolicyStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPoliciesInternal)this).AzureAdAuthenticationAsArmPolicyStatus = (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.AzureAdAuthenticationAsArmPolicyStatus?) content.GetValueForProperty("AzureAdAuthenticationAsArmPolicyStatus",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPoliciesInternal)this).AzureAdAuthenticationAsArmPolicyStatus, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.AzureAdAuthenticationAsArmPolicyStatus.CreateFrom);
            }
            if (content.Contains("SoftDeletePolicyLastUpdatedTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPoliciesInternal)this).SoftDeletePolicyLastUpdatedTime = (global::System.DateTime?) content.GetValueForProperty("SoftDeletePolicyLastUpdatedTime",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPoliciesInternal)this).SoftDeletePolicyLastUpdatedTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SoftDeletePolicyStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPoliciesInternal)this).SoftDeletePolicyStatus = (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.PolicyStatus?) content.GetValueForProperty("SoftDeletePolicyStatus",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPoliciesInternal)this).SoftDeletePolicyStatus, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.PolicyStatus.CreateFrom);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.Policies"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal Policies(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("QuarantinePolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPoliciesInternal)this).QuarantinePolicy = (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IQuarantinePolicy) content.GetValueForProperty("QuarantinePolicy",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPoliciesInternal)this).QuarantinePolicy, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.QuarantinePolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("TrustPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPoliciesInternal)this).TrustPolicy = (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.ITrustPolicy) content.GetValueForProperty("TrustPolicy",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPoliciesInternal)this).TrustPolicy, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.TrustPolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("RetentionPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPoliciesInternal)this).RetentionPolicy = (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IRetentionPolicy) content.GetValueForProperty("RetentionPolicy",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPoliciesInternal)this).RetentionPolicy, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.RetentionPolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("ExportPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPoliciesInternal)this).ExportPolicy = (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IExportPolicy) content.GetValueForProperty("ExportPolicy",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPoliciesInternal)this).ExportPolicy, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.ExportPolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("AzureAdAuthenticationAsArmPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPoliciesInternal)this).AzureAdAuthenticationAsArmPolicy = (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IAzureAdAuthenticationAsArmPolicy) content.GetValueForProperty("AzureAdAuthenticationAsArmPolicy",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPoliciesInternal)this).AzureAdAuthenticationAsArmPolicy, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.AzureAdAuthenticationAsArmPolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("SoftDeletePolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPoliciesInternal)this).SoftDeletePolicy = (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.ISoftDeletePolicy) content.GetValueForProperty("SoftDeletePolicy",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPoliciesInternal)this).SoftDeletePolicy, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.SoftDeletePolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("TrustPolicyType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPoliciesInternal)this).TrustPolicyType = (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TrustPolicyType?) content.GetValueForProperty("TrustPolicyType",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPoliciesInternal)this).TrustPolicyType, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TrustPolicyType.CreateFrom);
            }
            if (content.Contains("RetentionPolicyDay"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPoliciesInternal)this).RetentionPolicyDay = (int?) content.GetValueForProperty("RetentionPolicyDay",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPoliciesInternal)this).RetentionPolicyDay, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("ExportPolicyStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPoliciesInternal)this).ExportPolicyStatus = (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.ExportPolicyStatus?) content.GetValueForProperty("ExportPolicyStatus",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPoliciesInternal)this).ExportPolicyStatus, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.ExportPolicyStatus.CreateFrom);
            }
            if (content.Contains("SoftDeletePolicyRetentionDay"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPoliciesInternal)this).SoftDeletePolicyRetentionDay = (int?) content.GetValueForProperty("SoftDeletePolicyRetentionDay",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPoliciesInternal)this).SoftDeletePolicyRetentionDay, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("QuarantinePolicyStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPoliciesInternal)this).QuarantinePolicyStatus = (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.PolicyStatus?) content.GetValueForProperty("QuarantinePolicyStatus",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPoliciesInternal)this).QuarantinePolicyStatus, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.PolicyStatus.CreateFrom);
            }
            if (content.Contains("TrustPolicyStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPoliciesInternal)this).TrustPolicyStatus = (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.PolicyStatus?) content.GetValueForProperty("TrustPolicyStatus",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPoliciesInternal)this).TrustPolicyStatus, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.PolicyStatus.CreateFrom);
            }
            if (content.Contains("RetentionPolicyLastUpdatedTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPoliciesInternal)this).RetentionPolicyLastUpdatedTime = (global::System.DateTime?) content.GetValueForProperty("RetentionPolicyLastUpdatedTime",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPoliciesInternal)this).RetentionPolicyLastUpdatedTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("RetentionPolicyStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPoliciesInternal)this).RetentionPolicyStatus = (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.PolicyStatus?) content.GetValueForProperty("RetentionPolicyStatus",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPoliciesInternal)this).RetentionPolicyStatus, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.PolicyStatus.CreateFrom);
            }
            if (content.Contains("AzureAdAuthenticationAsArmPolicyStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPoliciesInternal)this).AzureAdAuthenticationAsArmPolicyStatus = (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.AzureAdAuthenticationAsArmPolicyStatus?) content.GetValueForProperty("AzureAdAuthenticationAsArmPolicyStatus",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPoliciesInternal)this).AzureAdAuthenticationAsArmPolicyStatus, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.AzureAdAuthenticationAsArmPolicyStatus.CreateFrom);
            }
            if (content.Contains("SoftDeletePolicyLastUpdatedTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPoliciesInternal)this).SoftDeletePolicyLastUpdatedTime = (global::System.DateTime?) content.GetValueForProperty("SoftDeletePolicyLastUpdatedTime",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPoliciesInternal)this).SoftDeletePolicyLastUpdatedTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SoftDeletePolicyStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPoliciesInternal)this).SoftDeletePolicyStatus = (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.PolicyStatus?) content.GetValueForProperty("SoftDeletePolicyStatus",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPoliciesInternal)this).SoftDeletePolicyStatus, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.PolicyStatus.CreateFrom);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// The policies for a container registry.
    [System.ComponentModel.TypeConverter(typeof(PoliciesTypeConverter))]
    public partial interface IPolicies

    {

    }
}