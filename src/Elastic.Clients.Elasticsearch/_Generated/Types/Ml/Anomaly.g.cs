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
	public partial class Anomaly
	{
		[JsonInclude]
		[JsonPropertyName("actual")]
		public IReadOnlyCollection<double>? Actual { get; init; }

		[JsonInclude]
		[JsonPropertyName("bucket_span")]
		public Elastic.Clients.Elasticsearch.Time BucketSpan { get; init; }

		[JsonInclude]
		[JsonPropertyName("by_field_name")]
		public string? ByFieldName { get; init; }

		[JsonInclude]
		[JsonPropertyName("by_field_value")]
		public string? ByFieldValue { get; init; }

		[JsonInclude]
		[JsonPropertyName("causes")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Ml.AnomalyCause>? Causes { get; init; }

		[JsonInclude]
		[JsonPropertyName("detector_index")]
		public int DetectorIndex { get; init; }

		[JsonInclude]
		[JsonPropertyName("field_name")]
		public string? FieldName { get; init; }

		[JsonInclude]
		[JsonPropertyName("function")]
		public string? Function { get; init; }

		[JsonInclude]
		[JsonPropertyName("function_description")]
		public string? FunctionDescription { get; init; }

		[JsonInclude]
		[JsonPropertyName("influencers")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Ml.Influence>? Influencers { get; init; }

		[JsonInclude]
		[JsonPropertyName("initial_record_score")]
		public double InitialRecordScore { get; init; }

		[JsonInclude]
		[JsonPropertyName("is_interim")]
		public bool IsInterim { get; init; }

		[JsonInclude]
		[JsonPropertyName("job_id")]
		public string JobId { get; init; }

		[JsonInclude]
		[JsonPropertyName("over_field_name")]
		public string? OverFieldName { get; init; }

		[JsonInclude]
		[JsonPropertyName("over_field_value")]
		public string? OverFieldValue { get; init; }

		[JsonInclude]
		[JsonPropertyName("partition_field_name")]
		public string? PartitionFieldName { get; init; }

		[JsonInclude]
		[JsonPropertyName("partition_field_value")]
		public string? PartitionFieldValue { get; init; }

		[JsonInclude]
		[JsonPropertyName("probability")]
		public double Probability { get; init; }

		[JsonInclude]
		[JsonPropertyName("record_score")]
		public double RecordScore { get; init; }

		[JsonInclude]
		[JsonPropertyName("result_type")]
		public string ResultType { get; init; }

		[JsonInclude]
		[JsonPropertyName("timestamp")]
		public Elastic.Clients.Elasticsearch.EpochMillis Timestamp { get; init; }

		[JsonInclude]
		[JsonPropertyName("typical")]
		public IReadOnlyCollection<double>? Typical { get; init; }
	}
}