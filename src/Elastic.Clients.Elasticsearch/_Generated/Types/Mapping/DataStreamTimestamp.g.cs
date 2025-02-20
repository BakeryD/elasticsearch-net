// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.
//
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// ------------------------------------------------
//
// This file is automatically generated.
// Please do not edit these files manually.
//
// ------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Mapping
{
	public partial class DataStreamTimestamp
	{
		[JsonInclude]
		[JsonPropertyName("enabled")]
		public bool Enabled { get; set; }
	}

	public sealed partial class DataStreamTimestampDescriptor : SerializableDescriptorBase<DataStreamTimestampDescriptor>
	{
		internal DataStreamTimestampDescriptor(Action<DataStreamTimestampDescriptor> configure) => configure.Invoke(this);
		public DataStreamTimestampDescriptor() : base()
		{
		}

		private bool EnabledValue { get; set; }

		public DataStreamTimestampDescriptor Enabled(bool enabled = true)
		{
			EnabledValue = enabled;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("enabled");
			writer.WriteBooleanValue(EnabledValue);
			writer.WriteEndObject();
		}
	}
}