// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Data.Tables.Models
{
    public partial class TableProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (TableName != null)
            {
                writer.WritePropertyName("TableName");
                writer.WriteStringValue(TableName);
            }
            writer.WriteEndObject();
        }
    }
}