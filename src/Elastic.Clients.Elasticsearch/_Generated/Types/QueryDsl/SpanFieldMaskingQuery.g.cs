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
namespace Elastic.Clients.Elasticsearch.QueryDsl
{
	public partial class SpanFieldMaskingQuery : QueryBase, IQueryContainerVariant, ISpanQueryVariant
	{
		[JsonIgnore]
		string IQueryContainerVariant.QueryContainerVariantName => "field_masking_span";
		[JsonIgnore]
		string ISpanQueryVariant.SpanQueryVariantName => "field_masking_span";
		[JsonInclude]
		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Field Field { get; set; }

		[JsonInclude]
		[JsonPropertyName("query")]
		public Elastic.Clients.Elasticsearch.QueryDsl.SpanQuery Query { get; set; }
	}

	public sealed partial class SpanFieldMaskingQueryDescriptor<TDocument> : SerializableDescriptorBase<SpanFieldMaskingQueryDescriptor<TDocument>>
	{
		internal SpanFieldMaskingQueryDescriptor(Action<SpanFieldMaskingQueryDescriptor<TDocument>> configure) => configure.Invoke(this);
		public SpanFieldMaskingQueryDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.QueryDsl.SpanQuery QueryValue { get; set; }

		private SpanQueryDescriptor<TDocument> QueryDescriptor { get; set; }

		private Action<SpanQueryDescriptor<TDocument>> QueryDescriptorAction { get; set; }

		private string? QueryNameValue { get; set; }

		private float? BoostValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }

		public SpanFieldMaskingQueryDescriptor<TDocument> Query(Elastic.Clients.Elasticsearch.QueryDsl.SpanQuery query)
		{
			QueryDescriptor = null;
			QueryDescriptorAction = null;
			QueryValue = query;
			return Self;
		}

		public SpanFieldMaskingQueryDescriptor<TDocument> Query(SpanQueryDescriptor<TDocument> descriptor)
		{
			QueryValue = null;
			QueryDescriptorAction = null;
			QueryDescriptor = descriptor;
			return Self;
		}

		public SpanFieldMaskingQueryDescriptor<TDocument> Query(Action<SpanQueryDescriptor<TDocument>> configure)
		{
			QueryValue = null;
			QueryDescriptor = null;
			QueryDescriptorAction = configure;
			return Self;
		}

		public SpanFieldMaskingQueryDescriptor<TDocument> QueryName(string? queryName)
		{
			QueryNameValue = queryName;
			return Self;
		}

		public SpanFieldMaskingQueryDescriptor<TDocument> Boost(float? boost)
		{
			BoostValue = boost;
			return Self;
		}

		public SpanFieldMaskingQueryDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field field)
		{
			FieldValue = field;
			return Self;
		}

		public SpanFieldMaskingQueryDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
		{
			FieldValue = field;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (QueryDescriptor is not null)
			{
				writer.WritePropertyName("query");
				JsonSerializer.Serialize(writer, QueryDescriptor, options);
			}
			else if (QueryDescriptorAction is not null)
			{
				writer.WritePropertyName("query");
				JsonSerializer.Serialize(writer, new SpanQueryDescriptor<TDocument>(QueryDescriptorAction), options);
			}
			else
			{
				writer.WritePropertyName("query");
				JsonSerializer.Serialize(writer, QueryValue, options);
			}

			if (!string.IsNullOrEmpty(QueryNameValue))
			{
				writer.WritePropertyName("_name");
				writer.WriteStringValue(QueryNameValue);
			}

			if (BoostValue.HasValue)
			{
				writer.WritePropertyName("boost");
				writer.WriteNumberValue(BoostValue.Value);
			}

			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
			writer.WriteEndObject();
		}
	}

	public sealed partial class SpanFieldMaskingQueryDescriptor : SerializableDescriptorBase<SpanFieldMaskingQueryDescriptor>
	{
		internal SpanFieldMaskingQueryDescriptor(Action<SpanFieldMaskingQueryDescriptor> configure) => configure.Invoke(this);
		public SpanFieldMaskingQueryDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.QueryDsl.SpanQuery QueryValue { get; set; }

		private SpanQueryDescriptor QueryDescriptor { get; set; }

		private Action<SpanQueryDescriptor> QueryDescriptorAction { get; set; }

		private string? QueryNameValue { get; set; }

		private float? BoostValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }

		public SpanFieldMaskingQueryDescriptor Query(Elastic.Clients.Elasticsearch.QueryDsl.SpanQuery query)
		{
			QueryDescriptor = null;
			QueryDescriptorAction = null;
			QueryValue = query;
			return Self;
		}

		public SpanFieldMaskingQueryDescriptor Query(SpanQueryDescriptor descriptor)
		{
			QueryValue = null;
			QueryDescriptorAction = null;
			QueryDescriptor = descriptor;
			return Self;
		}

		public SpanFieldMaskingQueryDescriptor Query(Action<SpanQueryDescriptor> configure)
		{
			QueryValue = null;
			QueryDescriptor = null;
			QueryDescriptorAction = configure;
			return Self;
		}

		public SpanFieldMaskingQueryDescriptor QueryName(string? queryName)
		{
			QueryNameValue = queryName;
			return Self;
		}

		public SpanFieldMaskingQueryDescriptor Boost(float? boost)
		{
			BoostValue = boost;
			return Self;
		}

		public SpanFieldMaskingQueryDescriptor Field(Elastic.Clients.Elasticsearch.Field field)
		{
			FieldValue = field;
			return Self;
		}

		public SpanFieldMaskingQueryDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
		{
			FieldValue = field;
			return Self;
		}

		public SpanFieldMaskingQueryDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
		{
			FieldValue = field;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (QueryDescriptor is not null)
			{
				writer.WritePropertyName("query");
				JsonSerializer.Serialize(writer, QueryDescriptor, options);
			}
			else if (QueryDescriptorAction is not null)
			{
				writer.WritePropertyName("query");
				JsonSerializer.Serialize(writer, new SpanQueryDescriptor(QueryDescriptorAction), options);
			}
			else
			{
				writer.WritePropertyName("query");
				JsonSerializer.Serialize(writer, QueryValue, options);
			}

			if (!string.IsNullOrEmpty(QueryNameValue))
			{
				writer.WritePropertyName("_name");
				writer.WriteStringValue(QueryNameValue);
			}

			if (BoostValue.HasValue)
			{
				writer.WritePropertyName("boost");
				writer.WriteNumberValue(BoostValue.Value);
			}

			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
			writer.WriteEndObject();
		}
	}
}