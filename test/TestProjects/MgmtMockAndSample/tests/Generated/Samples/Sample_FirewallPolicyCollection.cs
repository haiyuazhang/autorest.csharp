// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;
using MgmtMockAndSample.Models;
using NUnit.Framework;

namespace MgmtMockAndSample.Samples
{
    public partial class Sample_FirewallPolicyCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateFirewallPolicy()
        {
            // Generated from example definition:
            // this example is just showing the usage of "FirewallPolicies_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this FirewallPolicyResource
            FirewallPolicyCollection collection = resourceGroupResource.GetFirewallPolicies();

            // invoke the operation
            string firewallPolicyName = "firewallPolicy";
            FirewallPolicyData data = new FirewallPolicyData(new AzureLocation("West US"))
            {
                StartupProbe = default,
                ReadinessProbe = new Probe(false)
                {
                    InitialDelaySeconds = 30,
                    PeriodSeconds = 10,
                    FailureThreshold = 3,
                },
                DesiredStatusCode = DesiredStatusCode.TwoHundredTwo,
                ThreatIntelWhitelist = new FirewallPolicyThreatIntelWhitelist
                {
                    IpAddresses = { IPAddress.Parse("20.3.4.5") },
                    Fqdns = { "*.microsoft.com" },
                },
                Insights = new FirewallPolicyInsights
                {
                    IsEnabled = true,
                    RetentionDays = 100,
                    LogAnalyticsResources = new FirewallPolicyLogAnalyticsResources
                    {
                        Workspaces = {new FirewallPolicyLogAnalyticsWorkspace
{
Region = "westus",
WorkspaceIdId = new ResourceIdentifier("/subscriptions/subid/resourcegroups/rg1/providers/microsoft.operationalinsights/workspaces/workspace1"),
}, new FirewallPolicyLogAnalyticsWorkspace
{
Region = "eastus",
WorkspaceIdId = new ResourceIdentifier("/subscriptions/subid/resourcegroups/rg1/providers/microsoft.operationalinsights/workspaces/workspace2"),
}},
                        DefaultWorkspaceIdId = new ResourceIdentifier("/subscriptions/subid/resourcegroups/rg1/providers/microsoft.operationalinsights/workspaces/defaultWorkspace"),
                    },
                },
                SnatPrivateRanges = { "IANAPrivateRanges" },
                DnsSettings = new DnsSettings
                {
                    Servers = { "30.3.4.5" },
                    EnableProxy = true,
                    RequireProxyForNetworkRules = false,
                },
                IntrusionDetection = new FirewallPolicyIntrusionDetection
                {
                    Mode = FirewallPolicyIntrusionDetectionStateType.Alert,
                    Configuration = new FirewallPolicyIntrusionDetectionConfiguration
                    {
                        SignatureOverrides = {new FirewallPolicyIntrusionDetectionSignatureSpecification
{
Id = "2525004",
Mode = FirewallPolicyIntrusionDetectionStateType.Deny,
}},
                        BypassTrafficSettings = {new FirewallPolicyIntrusionDetectionBypassTrafficSpecifications
{
Name = "bypassRule1",
Description = "Rule 1",
Protocol = FirewallPolicyIntrusionDetectionProtocol.TCP,
SourceAddresses = {"1.2.3.4"},
DestinationAddresses = {"5.6.7.8"},
DestinationPorts = {"*"},
}},
                    },
                },
                TransportSecurityCertificateAuthority = new FirewallPolicyCertificateAuthority
                {
                    KeyVaultSecretId = "https://kv/secret",
                    Name = "clientcert",
                },
                SkuTier = FirewallPolicySkuTier.Premium,
                Tags =
{
["key1"] = "value1"
},
            };
            ArmOperation<FirewallPolicyResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, firewallPolicyName, data);
            FirewallPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FirewallPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateFirewallPolicyWithDifferentValues()
        {
            // Generated from example definition:
            // this example is just showing the usage of "FirewallPolicies_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this FirewallPolicyResource
            FirewallPolicyCollection collection = resourceGroupResource.GetFirewallPolicies();

            // invoke the operation
            string firewallPolicyName = "firewallPolicy";
            FirewallPolicyData data = new FirewallPolicyData(new AzureLocation("West US"))
            {
                StartupProbe = default,
                ReadinessProbe = new Probe(false)
                {
                    InitialDelaySeconds = 30,
                    PeriodSeconds = 10,
                    FailureThreshold = 3,
                },
                DesiredStatusCode = new DesiredStatusCode(600),
                ThreatIntelWhitelist = new FirewallPolicyThreatIntelWhitelist
                {
                    IpAddresses = { IPAddress.Parse("20.3.4.5") },
                    Fqdns = { "*.microsoft.com" },
                },
                Insights = new FirewallPolicyInsights
                {
                    IsEnabled = true,
                    RetentionDays = 100,
                    LogAnalyticsResources = new FirewallPolicyLogAnalyticsResources
                    {
                        Workspaces = {new FirewallPolicyLogAnalyticsWorkspace
{
Region = "westus",
WorkspaceIdId = new ResourceIdentifier("/subscriptions/subid/resourcegroups/rg1/providers/microsoft.operationalinsights/workspaces/workspace1"),
}, new FirewallPolicyLogAnalyticsWorkspace
{
Region = "eastus",
WorkspaceIdId = new ResourceIdentifier("/subscriptions/subid/resourcegroups/rg1/providers/microsoft.operationalinsights/workspaces/workspace2"),
}},
                        DefaultWorkspaceIdId = new ResourceIdentifier("/subscriptions/subid/resourcegroups/rg1/providers/microsoft.operationalinsights/workspaces/defaultWorkspace"),
                    },
                },
                SnatPrivateRanges = { "IANAPrivateRanges" },
                DnsSettings = new DnsSettings
                {
                    Servers = { "30.3.4.5" },
                    EnableProxy = true,
                    RequireProxyForNetworkRules = false,
                },
                IntrusionDetection = new FirewallPolicyIntrusionDetection
                {
                    Mode = FirewallPolicyIntrusionDetectionStateType.Alert,
                    Configuration = new FirewallPolicyIntrusionDetectionConfiguration
                    {
                        SignatureOverrides = {new FirewallPolicyIntrusionDetectionSignatureSpecification
{
Id = "2525004",
Mode = FirewallPolicyIntrusionDetectionStateType.Deny,
}},
                        BypassTrafficSettings = {new FirewallPolicyIntrusionDetectionBypassTrafficSpecifications
{
Name = "bypassRule1",
Description = "Rule 1",
Protocol = FirewallPolicyIntrusionDetectionProtocol.TCP,
SourceAddresses = {"1.2.3.4"},
DestinationAddresses = {"5.6.7.8"},
DestinationPorts = {"*"},
}},
                    },
                },
                TransportSecurityCertificateAuthority = new FirewallPolicyCertificateAuthority
                {
                    KeyVaultSecretId = "https://kv/secret",
                    Name = "clientcert",
                },
                SkuTier = FirewallPolicySkuTier.Premium,
                NetworkConfigurations = {new Dictionary<string, string>
{
["config1"] = "value1",
["config2"] = "value2"
}},
                Tags =
{
["key1"] = "value1"
},
            };
            ArmOperation<FirewallPolicyResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, firewallPolicyName, data);
            FirewallPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FirewallPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetFirewallPolicy()
        {
            // Generated from example definition:
            // this example is just showing the usage of "FirewallPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this FirewallPolicyResource
            FirewallPolicyCollection collection = resourceGroupResource.GetFirewallPolicies();

            // invoke the operation
            string firewallPolicyName = "firewallPolicy";
            FirewallPolicyResource result = await collection.GetAsync(firewallPolicyName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FirewallPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListAllFirewallPoliciesForAGivenResourceGroup()
        {
            // Generated from example definition:
            // this example is just showing the usage of "FirewallPolicies_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this FirewallPolicyResource
            FirewallPolicyCollection collection = resourceGroupResource.GetFirewallPolicies();

            // invoke the operation and iterate over the result
            await foreach (FirewallPolicyResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                FirewallPolicyData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetFirewallPolicy()
        {
            // Generated from example definition:
            // this example is just showing the usage of "FirewallPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this FirewallPolicyResource
            FirewallPolicyCollection collection = resourceGroupResource.GetFirewallPolicies();

            // invoke the operation
            string firewallPolicyName = "firewallPolicy";
            bool result = await collection.ExistsAsync(firewallPolicyName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetFirewallPolicy()
        {
            // Generated from example definition:
            // this example is just showing the usage of "FirewallPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this FirewallPolicyResource
            FirewallPolicyCollection collection = resourceGroupResource.GetFirewallPolicies();

            // invoke the operation
            string firewallPolicyName = "firewallPolicy";
            NullableResponse<FirewallPolicyResource> response = await collection.GetIfExistsAsync(firewallPolicyName);
            FirewallPolicyResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                FirewallPolicyData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
