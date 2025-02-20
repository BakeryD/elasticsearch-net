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

using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Cluster
{
	public sealed class ClusterPostVotingConfigExclusionsRequestParameters : RequestParameters<ClusterPostVotingConfigExclusionsRequestParameters>
	{
		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Names? NodeNames { get => Q<Elastic.Clients.Elasticsearch.Names?>("node_names"); set => Q("node_names", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Ids? NodeIds { get => Q<Elastic.Clients.Elasticsearch.Ids?>("node_ids"); set => Q("node_ids", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? Timeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("timeout"); set => Q("timeout", value); }
	}

	public partial class ClusterPostVotingConfigExclusionsRequest : PlainRequestBase<ClusterPostVotingConfigExclusionsRequestParameters>
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterPostVotingConfigExclusions;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Names? NodeNames { get => Q<Elastic.Clients.Elasticsearch.Names?>("node_names"); set => Q("node_names", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Ids? NodeIds { get => Q<Elastic.Clients.Elasticsearch.Ids?>("node_ids"); set => Q("node_ids", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? Timeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("timeout"); set => Q("timeout", value); }
	}

	public sealed partial class ClusterPostVotingConfigExclusionsRequestDescriptor : RequestDescriptorBase<ClusterPostVotingConfigExclusionsRequestDescriptor, ClusterPostVotingConfigExclusionsRequestParameters>
	{
		internal ClusterPostVotingConfigExclusionsRequestDescriptor(Action<ClusterPostVotingConfigExclusionsRequestDescriptor> configure) => configure.Invoke(this);
		public ClusterPostVotingConfigExclusionsRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterPostVotingConfigExclusions;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		public ClusterPostVotingConfigExclusionsRequestDescriptor NodeIds(Elastic.Clients.Elasticsearch.Ids? nodeIds) => Qs("node_ids", nodeIds);
		public ClusterPostVotingConfigExclusionsRequestDescriptor NodeNames(Elastic.Clients.Elasticsearch.Names? nodeNames) => Qs("node_names", nodeNames);
		public ClusterPostVotingConfigExclusionsRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Time? timeout) => Qs("timeout", timeout);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
		}
	}
}