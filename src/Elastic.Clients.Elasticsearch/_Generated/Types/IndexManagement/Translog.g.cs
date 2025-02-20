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
namespace Elastic.Clients.Elasticsearch.IndexManagement
{
	public partial class Translog
	{
		[JsonInclude]
		[JsonPropertyName("durability")]
		public Elastic.Clients.Elasticsearch.IndexManagement.TranslogDurability? Durability { get; set; }

		[JsonInclude]
		[JsonPropertyName("flush_threshold_size")]
		public Elastic.Clients.Elasticsearch.ByteSize? FlushThresholdSize { get; set; }

		[JsonInclude]
		[JsonPropertyName("retention")]
		public Elastic.Clients.Elasticsearch.IndexManagement.TranslogRetention? Retention { get; set; }

		[JsonInclude]
		[JsonPropertyName("sync_interval")]
		public Elastic.Clients.Elasticsearch.Time? SyncInterval { get; set; }
	}

	public sealed partial class TranslogDescriptor : SerializableDescriptorBase<TranslogDescriptor>
	{
		internal TranslogDescriptor(Action<TranslogDescriptor> configure) => configure.Invoke(this);
		public TranslogDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.IndexManagement.TranslogDurability? DurabilityValue { get; set; }

		private Elastic.Clients.Elasticsearch.ByteSize? FlushThresholdSizeValue { get; set; }

		private Elastic.Clients.Elasticsearch.IndexManagement.TranslogRetention? RetentionValue { get; set; }

		private TranslogRetentionDescriptor RetentionDescriptor { get; set; }

		private Action<TranslogRetentionDescriptor> RetentionDescriptorAction { get; set; }

		private Elastic.Clients.Elasticsearch.Time? SyncIntervalValue { get; set; }

		public TranslogDescriptor Durability(Elastic.Clients.Elasticsearch.IndexManagement.TranslogDurability? durability)
		{
			DurabilityValue = durability;
			return Self;
		}

		public TranslogDescriptor FlushThresholdSize(Elastic.Clients.Elasticsearch.ByteSize? flushThresholdSize)
		{
			FlushThresholdSizeValue = flushThresholdSize;
			return Self;
		}

		public TranslogDescriptor Retention(Elastic.Clients.Elasticsearch.IndexManagement.TranslogRetention? retention)
		{
			RetentionDescriptor = null;
			RetentionDescriptorAction = null;
			RetentionValue = retention;
			return Self;
		}

		public TranslogDescriptor Retention(TranslogRetentionDescriptor descriptor)
		{
			RetentionValue = null;
			RetentionDescriptorAction = null;
			RetentionDescriptor = descriptor;
			return Self;
		}

		public TranslogDescriptor Retention(Action<TranslogRetentionDescriptor> configure)
		{
			RetentionValue = null;
			RetentionDescriptor = null;
			RetentionDescriptorAction = configure;
			return Self;
		}

		public TranslogDescriptor SyncInterval(Elastic.Clients.Elasticsearch.Time? syncInterval)
		{
			SyncIntervalValue = syncInterval;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (DurabilityValue is not null)
			{
				writer.WritePropertyName("durability");
				JsonSerializer.Serialize(writer, DurabilityValue, options);
			}

			if (FlushThresholdSizeValue is not null)
			{
				writer.WritePropertyName("flush_threshold_size");
				JsonSerializer.Serialize(writer, FlushThresholdSizeValue, options);
			}

			if (RetentionDescriptor is not null)
			{
				writer.WritePropertyName("retention");
				JsonSerializer.Serialize(writer, RetentionDescriptor, options);
			}
			else if (RetentionDescriptorAction is not null)
			{
				writer.WritePropertyName("retention");
				JsonSerializer.Serialize(writer, new TranslogRetentionDescriptor(RetentionDescriptorAction), options);
			}
			else if (RetentionValue is not null)
			{
				writer.WritePropertyName("retention");
				JsonSerializer.Serialize(writer, RetentionValue, options);
			}

			if (SyncIntervalValue is not null)
			{
				writer.WritePropertyName("sync_interval");
				JsonSerializer.Serialize(writer, SyncIntervalValue, options);
			}

			writer.WriteEndObject();
		}
	}
}