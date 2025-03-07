﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Commands.Batch.Models;
using System.Management.Automation;
using Constants = Microsoft.Azure.Commands.Batch.Utils.Constants;
using Microsoft.WindowsAzure.Commands.Common.CustomAttributes;

namespace Microsoft.Azure.Commands.Batch
{
    [System.Obsolete]
    [GenericBreakingChange("The Batch account certificates feature is deprecated. Please transition to using Azure Key Vault to securely access and install certificates on your Batch pools, learn more: https://learn.microsoft.com/azure/batch/batch-certificate-migration-guide", "4.0.0", "02/29/2024")]
    [Cmdlet("Get", ResourceManager.Common.AzureRMConstants.AzurePrefix + "BatchCertificate", DefaultParameterSetName = Constants.ODataFilterParameterSet),OutputType(typeof(PSCertificate))]
    public class GetBatchCertificateCommand : BatchObjectModelCmdletBase
    {
        internal const string ThumbprintParameterSet = "Thumbprint";
        private int maxCount = Constants.DefaultMaxCount;

        [Parameter(Position = 0, ParameterSetName = ThumbprintParameterSet, Mandatory = true, ValueFromPipelineByPropertyName = true,
            HelpMessage = "The algorithm used to derive the Thumbprint parameter. This must be sha1.")]
        [ValidateNotNullOrEmpty]
        public string ThumbprintAlgorithm { get; set; }

        [Parameter(Position = 1, ParameterSetName = ThumbprintParameterSet, Mandatory = true, ValueFromPipelineByPropertyName = true,
            HelpMessage = "The thumbprint of the certificate to get.")]
        [ValidateNotNullOrEmpty]
        public string Thumbprint { get; set; }

        [Parameter(ParameterSetName = Constants.ODataFilterParameterSet)]
        [ValidateNotNullOrEmpty]
        public string Filter { get; set; }

        [Parameter(ParameterSetName = Constants.ODataFilterParameterSet)]
        public int MaxCount
        {
            get { return this.maxCount; }
            set { this.maxCount = value; }
        }

        [Parameter]
        [ValidateNotNullOrEmpty]
        public string Select { get; set; }

        protected override void ExecuteCmdletImpl()
        {
            ListCertificateOptions options = new ListCertificateOptions(this.BatchContext, this.AdditionalBehaviors)
            {
                ThumbprintAlgorithm = this.ThumbprintAlgorithm,
                Thumbprint = this.Thumbprint,
                Filter = this.Filter,
                Select = this.Select,
                MaxCount = this.MaxCount
            };

            // The enumerator will internally query the service in chunks. Using WriteObject with the enumerate flag will enumerate
            // the entire collection first and then write the items out one by one in a single group.  Using foreach, we can take 
            // advantage of the enumerator's behavior and write output to the pipeline in bursts.
            foreach (PSCertificate certificate in BatchClient.ListCertificates(options))
            {
                WriteObject(certificate);
            }
        }
    }
}
