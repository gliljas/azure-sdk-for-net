// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A server secure connection policy. </summary>
    public partial class ServerConnectionPolicy : Resource
    {
        /// <summary> Initializes a new instance of ServerConnectionPolicy. </summary>
        public ServerConnectionPolicy()
        {
        }

        /// <summary> Initializes a new instance of ServerConnectionPolicy. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="kind"> Metadata used for the Azure portal experience. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="connectionType"> The server connection type. </param>
        internal ServerConnectionPolicy(string id, string name, string type, string kind, string location, ServerConnectionType? connectionType) : base(id, name, type)
        {
            Kind = kind;
            Location = location;
            ConnectionType = connectionType;
        }

        /// <summary> Metadata used for the Azure portal experience. </summary>
        public string Kind { get; }
        /// <summary> Resource location. </summary>
        public string Location { get; }
        /// <summary> The server connection type. </summary>
        public ServerConnectionType? ConnectionType { get; set; }
    }
}
