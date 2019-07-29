// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Azure Data Explorer command activity.
    /// </summary>
    [Newtonsoft.Json.JsonObject("AzureDataExplorerCommand")]
    [Rest.Serialization.JsonTransformation]
    public partial class AzureDataExplorerCommandActivity : ExecutionActivity
    {
        /// <summary>
        /// Initializes a new instance of the AzureDataExplorerCommandActivity
        /// class.
        /// </summary>
        public AzureDataExplorerCommandActivity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureDataExplorerCommandActivity
        /// class.
        /// </summary>
        /// <param name="name">Activity name.</param>
        /// <param name="command">A control command, according to the Azure
        /// Data Explorer command syntax. Type: string (or Expression with
        /// resultType string).</param>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="description">Activity description.</param>
        /// <param name="dependsOn">Activity depends on condition.</param>
        /// <param name="userProperties">Activity user properties.</param>
        /// <param name="linkedServiceName">Linked service reference.</param>
        /// <param name="policy">Activity policy.</param>
        /// <param name="commandTimeout">Control command timeout. Type: string
        /// (or Expression with resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9]))..)</param>
        public AzureDataExplorerCommandActivity(string name, object command, IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string description = default(string), IList<ActivityDependency> dependsOn = default(IList<ActivityDependency>), IList<UserProperty> userProperties = default(IList<UserProperty>), LinkedServiceReference linkedServiceName = default(LinkedServiceReference), ActivityPolicy policy = default(ActivityPolicy), object commandTimeout = default(object))
            : base(name, additionalProperties, description, dependsOn, userProperties, linkedServiceName, policy)
        {
            Command = command;
            CommandTimeout = commandTimeout;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a control command, according to the Azure Data
        /// Explorer command syntax. Type: string (or Expression with
        /// resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.command")]
        public object Command { get; set; }

        /// <summary>
        /// Gets or sets control command timeout. Type: string (or Expression
        /// with resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9]))..)
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.commandTimeout")]
        public object CommandTimeout { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Command == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Command");
            }
        }
    }
}