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

using Elastic.Transport.Products.Elasticsearch;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Ml
{
	public sealed partial class MlPutTrainedModelResponse : ElasticsearchResponseBase
	{
		[JsonInclude]
		[JsonPropertyName("compressed_definition")]
		public string? CompressedDefinition { get; init; }

		[JsonInclude]
		[JsonPropertyName("created_by")]
		public string? CreatedBy { get; init; }

		[JsonInclude]
		[JsonPropertyName("create_time")]
		public Elastic.Clients.Elasticsearch.Time? CreateTime { get; init; }

		[JsonInclude]
		[JsonPropertyName("default_field_map")]
		public Dictionary<string, string>? DefaultFieldMap { get; init; }

		[JsonInclude]
		[JsonPropertyName("description")]
		public string? Description { get; init; }

		[JsonInclude]
		[JsonPropertyName("estimated_heap_memory_usage_bytes")]
		public int? EstimatedHeapMemoryUsageBytes { get; init; }

		[JsonInclude]
		[JsonPropertyName("estimated_operations")]
		public int? EstimatedOperations { get; init; }

		[JsonInclude]
		[JsonPropertyName("inference_config")]
		public Elastic.Clients.Elasticsearch.Ml.InferenceConfigCreateContainer InferenceConfig { get; init; }

		[JsonInclude]
		[JsonPropertyName("input")]
		public Elastic.Clients.Elasticsearch.Ml.TrainedModelConfigInput Input { get; init; }

		[JsonInclude]
		[JsonPropertyName("license_level")]
		public string? LicenseLevel { get; init; }

		[JsonInclude]
		[JsonPropertyName("location")]
		public Elastic.Clients.Elasticsearch.Ml.TrainedModelLocation? Location { get; init; }

		[JsonInclude]
		[JsonPropertyName("metadata")]
		public Elastic.Clients.Elasticsearch.Ml.TrainedModelConfigMetadata? Metadata { get; init; }

		[JsonInclude]
		[JsonPropertyName("model_id")]
		public string ModelId { get; init; }

		[JsonInclude]
		[JsonPropertyName("model_size_bytes")]
		public Elastic.Clients.Elasticsearch.ByteSize? ModelSizeBytes { get; init; }

		[JsonInclude]
		[JsonPropertyName("model_type")]
		public Elastic.Clients.Elasticsearch.Ml.TrainedModelType? ModelType { get; init; }

		[JsonInclude]
		[JsonPropertyName("tags")]
		public IReadOnlyCollection<string> Tags { get; init; }

		[JsonInclude]
		[JsonPropertyName("version")]
		public string? Version { get; init; }
	}
}