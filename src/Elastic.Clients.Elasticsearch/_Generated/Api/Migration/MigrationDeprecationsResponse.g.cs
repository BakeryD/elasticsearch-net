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
namespace Elastic.Clients.Elasticsearch.Migration
{
	public sealed partial class MigrationDeprecationsResponse : ElasticsearchResponseBase
	{
		[JsonInclude]
		[JsonPropertyName("cluster_settings")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Migration.Deprecation> ClusterSettings { get; init; }

		[JsonInclude]
		[JsonPropertyName("index_settings")]
		public Dictionary<string, IReadOnlyCollection<Elastic.Clients.Elasticsearch.Migration.Deprecation>> IndexSettings { get; init; }

		[JsonInclude]
		[JsonPropertyName("ml_settings")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Migration.Deprecation> MlSettings { get; init; }

		[JsonInclude]
		[JsonPropertyName("node_settings")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Migration.Deprecation> NodeSettings { get; init; }
	}
}