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
namespace Elastic.Clients.Elasticsearch.Ingest
{
	public partial class RemoveProcessor : ProcessorBase, IProcessorContainerVariant
	{
		[JsonIgnore]
		string IProcessorContainerVariant.ProcessorContainerVariantName => "remove";
		[JsonInclude]
		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Fields Field { get; set; }

		[JsonInclude]
		[JsonPropertyName("ignore_missing")]
		public bool? IgnoreMissing { get; set; }
	}

	public sealed partial class RemoveProcessorDescriptor<TDocument> : SerializableDescriptorBase<RemoveProcessorDescriptor<TDocument>>
	{
		internal RemoveProcessorDescriptor(Action<RemoveProcessorDescriptor<TDocument>> configure) => configure.Invoke(this);
		public RemoveProcessorDescriptor() : base()
		{
		}

		private IEnumerable<Elastic.Clients.Elasticsearch.Ingest.ProcessorContainer>? OnFailureValue { get; set; }

		private ProcessorContainerDescriptor<TDocument> OnFailureDescriptor { get; set; }

		private Action<ProcessorContainerDescriptor<TDocument>> OnFailureDescriptorAction { get; set; }

		private Action<ProcessorContainerDescriptor<TDocument>>[] OnFailureDescriptorActions { get; set; }

		private Elastic.Clients.Elasticsearch.Fields FieldValue { get; set; }

		private string? IfValue { get; set; }

		private bool? IgnoreFailureValue { get; set; }

		private bool? IgnoreMissingValue { get; set; }

		private string? TagValue { get; set; }

		public RemoveProcessorDescriptor<TDocument> OnFailure(IEnumerable<Elastic.Clients.Elasticsearch.Ingest.ProcessorContainer>? onFailure)
		{
			OnFailureDescriptor = null;
			OnFailureDescriptorAction = null;
			OnFailureDescriptorActions = null;
			OnFailureValue = onFailure;
			return Self;
		}

		public RemoveProcessorDescriptor<TDocument> OnFailure(ProcessorContainerDescriptor<TDocument> descriptor)
		{
			OnFailureValue = null;
			OnFailureDescriptorAction = null;
			OnFailureDescriptorActions = null;
			OnFailureDescriptor = descriptor;
			return Self;
		}

		public RemoveProcessorDescriptor<TDocument> OnFailure(Action<ProcessorContainerDescriptor<TDocument>> configure)
		{
			OnFailureValue = null;
			OnFailureDescriptor = null;
			OnFailureDescriptorActions = null;
			OnFailureDescriptorAction = configure;
			return Self;
		}

		public RemoveProcessorDescriptor<TDocument> OnFailure(params Action<ProcessorContainerDescriptor<TDocument>>[] configure)
		{
			OnFailureValue = null;
			OnFailureDescriptor = null;
			OnFailureDescriptorAction = null;
			OnFailureDescriptorActions = configure;
			return Self;
		}

		public RemoveProcessorDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Fields field)
		{
			FieldValue = field;
			return Self;
		}

		public RemoveProcessorDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
		{
			FieldValue = field;
			return Self;
		}

		public RemoveProcessorDescriptor<TDocument> If(string? ifValue)
		{
			IfValue = ifValue;
			return Self;
		}

		public RemoveProcessorDescriptor<TDocument> IgnoreFailure(bool? ignoreFailure = true)
		{
			IgnoreFailureValue = ignoreFailure;
			return Self;
		}

		public RemoveProcessorDescriptor<TDocument> IgnoreMissing(bool? ignoreMissing = true)
		{
			IgnoreMissingValue = ignoreMissing;
			return Self;
		}

		public RemoveProcessorDescriptor<TDocument> Tag(string? tag)
		{
			TagValue = tag;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (OnFailureDescriptor is not null)
			{
				writer.WritePropertyName("on_failure");
				JsonSerializer.Serialize(writer, OnFailureDescriptor, options);
			}
			else if (OnFailureDescriptorAction is not null)
			{
				writer.WritePropertyName("on_failure");
				JsonSerializer.Serialize(writer, new ProcessorContainerDescriptor<TDocument>(OnFailureDescriptorAction), options);
			}
			else if (OnFailureDescriptorActions is not null)
			{
				writer.WritePropertyName("on_failure");
				writer.WriteStartArray();
				foreach (var action in OnFailureDescriptorActions)
				{
					JsonSerializer.Serialize(writer, new ProcessorContainerDescriptor<TDocument>(action), options);
				}

				writer.WriteEndArray();
			}
			else if (OnFailureValue is not null)
			{
				writer.WritePropertyName("on_failure");
				JsonSerializer.Serialize(writer, OnFailureValue, options);
			}

			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
			if (!string.IsNullOrEmpty(IfValue))
			{
				writer.WritePropertyName("if");
				writer.WriteStringValue(IfValue);
			}

			if (IgnoreFailureValue.HasValue)
			{
				writer.WritePropertyName("ignore_failure");
				writer.WriteBooleanValue(IgnoreFailureValue.Value);
			}

			if (IgnoreMissingValue.HasValue)
			{
				writer.WritePropertyName("ignore_missing");
				writer.WriteBooleanValue(IgnoreMissingValue.Value);
			}

			if (!string.IsNullOrEmpty(TagValue))
			{
				writer.WritePropertyName("tag");
				writer.WriteStringValue(TagValue);
			}

			writer.WriteEndObject();
		}
	}

	public sealed partial class RemoveProcessorDescriptor : SerializableDescriptorBase<RemoveProcessorDescriptor>
	{
		internal RemoveProcessorDescriptor(Action<RemoveProcessorDescriptor> configure) => configure.Invoke(this);
		public RemoveProcessorDescriptor() : base()
		{
		}

		private IEnumerable<Elastic.Clients.Elasticsearch.Ingest.ProcessorContainer>? OnFailureValue { get; set; }

		private ProcessorContainerDescriptor OnFailureDescriptor { get; set; }

		private Action<ProcessorContainerDescriptor> OnFailureDescriptorAction { get; set; }

		private Action<ProcessorContainerDescriptor>[] OnFailureDescriptorActions { get; set; }

		private Elastic.Clients.Elasticsearch.Fields FieldValue { get; set; }

		private string? IfValue { get; set; }

		private bool? IgnoreFailureValue { get; set; }

		private bool? IgnoreMissingValue { get; set; }

		private string? TagValue { get; set; }

		public RemoveProcessorDescriptor OnFailure(IEnumerable<Elastic.Clients.Elasticsearch.Ingest.ProcessorContainer>? onFailure)
		{
			OnFailureDescriptor = null;
			OnFailureDescriptorAction = null;
			OnFailureDescriptorActions = null;
			OnFailureValue = onFailure;
			return Self;
		}

		public RemoveProcessorDescriptor OnFailure(ProcessorContainerDescriptor descriptor)
		{
			OnFailureValue = null;
			OnFailureDescriptorAction = null;
			OnFailureDescriptorActions = null;
			OnFailureDescriptor = descriptor;
			return Self;
		}

		public RemoveProcessorDescriptor OnFailure(Action<ProcessorContainerDescriptor> configure)
		{
			OnFailureValue = null;
			OnFailureDescriptor = null;
			OnFailureDescriptorActions = null;
			OnFailureDescriptorAction = configure;
			return Self;
		}

		public RemoveProcessorDescriptor OnFailure(params Action<ProcessorContainerDescriptor>[] configure)
		{
			OnFailureValue = null;
			OnFailureDescriptor = null;
			OnFailureDescriptorAction = null;
			OnFailureDescriptorActions = configure;
			return Self;
		}

		public RemoveProcessorDescriptor Field(Elastic.Clients.Elasticsearch.Fields field)
		{
			FieldValue = field;
			return Self;
		}

		public RemoveProcessorDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
		{
			FieldValue = field;
			return Self;
		}

		public RemoveProcessorDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
		{
			FieldValue = field;
			return Self;
		}

		public RemoveProcessorDescriptor If(string? ifValue)
		{
			IfValue = ifValue;
			return Self;
		}

		public RemoveProcessorDescriptor IgnoreFailure(bool? ignoreFailure = true)
		{
			IgnoreFailureValue = ignoreFailure;
			return Self;
		}

		public RemoveProcessorDescriptor IgnoreMissing(bool? ignoreMissing = true)
		{
			IgnoreMissingValue = ignoreMissing;
			return Self;
		}

		public RemoveProcessorDescriptor Tag(string? tag)
		{
			TagValue = tag;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (OnFailureDescriptor is not null)
			{
				writer.WritePropertyName("on_failure");
				JsonSerializer.Serialize(writer, OnFailureDescriptor, options);
			}
			else if (OnFailureDescriptorAction is not null)
			{
				writer.WritePropertyName("on_failure");
				JsonSerializer.Serialize(writer, new ProcessorContainerDescriptor(OnFailureDescriptorAction), options);
			}
			else if (OnFailureDescriptorActions is not null)
			{
				writer.WritePropertyName("on_failure");
				writer.WriteStartArray();
				foreach (var action in OnFailureDescriptorActions)
				{
					JsonSerializer.Serialize(writer, new ProcessorContainerDescriptor(action), options);
				}

				writer.WriteEndArray();
			}
			else if (OnFailureValue is not null)
			{
				writer.WritePropertyName("on_failure");
				JsonSerializer.Serialize(writer, OnFailureValue, options);
			}

			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
			if (!string.IsNullOrEmpty(IfValue))
			{
				writer.WritePropertyName("if");
				writer.WriteStringValue(IfValue);
			}

			if (IgnoreFailureValue.HasValue)
			{
				writer.WritePropertyName("ignore_failure");
				writer.WriteBooleanValue(IgnoreFailureValue.Value);
			}

			if (IgnoreMissingValue.HasValue)
			{
				writer.WritePropertyName("ignore_missing");
				writer.WriteBooleanValue(IgnoreMissingValue.Value);
			}

			if (!string.IsNullOrEmpty(TagValue))
			{
				writer.WritePropertyName("tag");
				writer.WriteStringValue(TagValue);
			}

			writer.WriteEndObject();
		}
	}
}