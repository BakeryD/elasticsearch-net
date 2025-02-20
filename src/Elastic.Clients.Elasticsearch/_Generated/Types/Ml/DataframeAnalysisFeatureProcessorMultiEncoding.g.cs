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
namespace Elastic.Clients.Elasticsearch.Ml
{
	public partial class DataframeAnalysisFeatureProcessorMultiEncoding : IDataframeAnalysisFeatureProcessorVariant
	{
		[JsonIgnore]
		string IDataframeAnalysisFeatureProcessorVariant.DataframeAnalysisFeatureProcessorVariantName => "multi_encoding";
		[JsonInclude]
		[JsonPropertyName("processors")]
		public IEnumerable<int> Processors { get; set; }
	}

	public sealed partial class DataframeAnalysisFeatureProcessorMultiEncodingDescriptor : SerializableDescriptorBase<DataframeAnalysisFeatureProcessorMultiEncodingDescriptor>
	{
		internal DataframeAnalysisFeatureProcessorMultiEncodingDescriptor(Action<DataframeAnalysisFeatureProcessorMultiEncodingDescriptor> configure) => configure.Invoke(this);
		public DataframeAnalysisFeatureProcessorMultiEncodingDescriptor() : base()
		{
		}

		private IEnumerable<int> ProcessorsValue { get; set; }

		public DataframeAnalysisFeatureProcessorMultiEncodingDescriptor Processors(IEnumerable<int> processors)
		{
			ProcessorsValue = processors;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("processors");
			JsonSerializer.Serialize(writer, ProcessorsValue, options);
			writer.WriteEndObject();
		}
	}
}