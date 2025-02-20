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
namespace Elastic.Clients.Elasticsearch.Cluster
{
	public partial class Command
	{
		[JsonInclude]
		[JsonPropertyName("allocate_empty_primary")]
		public Elastic.Clients.Elasticsearch.Cluster.CommandAllocatePrimaryAction? AllocateEmptyPrimary { get; set; }

		[JsonInclude]
		[JsonPropertyName("allocate_replica")]
		public Elastic.Clients.Elasticsearch.Cluster.CommandAllocateReplicaAction? AllocateReplica { get; set; }

		[JsonInclude]
		[JsonPropertyName("allocate_stale_primary")]
		public Elastic.Clients.Elasticsearch.Cluster.CommandAllocatePrimaryAction? AllocateStalePrimary { get; set; }

		[JsonInclude]
		[JsonPropertyName("cancel")]
		public Elastic.Clients.Elasticsearch.Cluster.CommandCancelAction? Cancel { get; set; }

		[JsonInclude]
		[JsonPropertyName("move")]
		public Elastic.Clients.Elasticsearch.Cluster.CommandMoveAction? Move { get; set; }
	}

	public sealed partial class CommandDescriptor : SerializableDescriptorBase<CommandDescriptor>
	{
		internal CommandDescriptor(Action<CommandDescriptor> configure) => configure.Invoke(this);
		public CommandDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.Cluster.CommandAllocatePrimaryAction? AllocateEmptyPrimaryValue { get; set; }

		private CommandAllocatePrimaryActionDescriptor AllocateEmptyPrimaryDescriptor { get; set; }

		private Action<CommandAllocatePrimaryActionDescriptor> AllocateEmptyPrimaryDescriptorAction { get; set; }

		private Elastic.Clients.Elasticsearch.Cluster.CommandAllocateReplicaAction? AllocateReplicaValue { get; set; }

		private CommandAllocateReplicaActionDescriptor AllocateReplicaDescriptor { get; set; }

		private Action<CommandAllocateReplicaActionDescriptor> AllocateReplicaDescriptorAction { get; set; }

		private Elastic.Clients.Elasticsearch.Cluster.CommandAllocatePrimaryAction? AllocateStalePrimaryValue { get; set; }

		private CommandAllocatePrimaryActionDescriptor AllocateStalePrimaryDescriptor { get; set; }

		private Action<CommandAllocatePrimaryActionDescriptor> AllocateStalePrimaryDescriptorAction { get; set; }

		private Elastic.Clients.Elasticsearch.Cluster.CommandCancelAction? CancelValue { get; set; }

		private CommandCancelActionDescriptor CancelDescriptor { get; set; }

		private Action<CommandCancelActionDescriptor> CancelDescriptorAction { get; set; }

		private Elastic.Clients.Elasticsearch.Cluster.CommandMoveAction? MoveValue { get; set; }

		private CommandMoveActionDescriptor MoveDescriptor { get; set; }

		private Action<CommandMoveActionDescriptor> MoveDescriptorAction { get; set; }

		public CommandDescriptor AllocateEmptyPrimary(Elastic.Clients.Elasticsearch.Cluster.CommandAllocatePrimaryAction? allocateEmptyPrimary)
		{
			AllocateEmptyPrimaryDescriptor = null;
			AllocateEmptyPrimaryDescriptorAction = null;
			AllocateEmptyPrimaryValue = allocateEmptyPrimary;
			return Self;
		}

		public CommandDescriptor AllocateEmptyPrimary(CommandAllocatePrimaryActionDescriptor descriptor)
		{
			AllocateEmptyPrimaryValue = null;
			AllocateEmptyPrimaryDescriptorAction = null;
			AllocateEmptyPrimaryDescriptor = descriptor;
			return Self;
		}

		public CommandDescriptor AllocateEmptyPrimary(Action<CommandAllocatePrimaryActionDescriptor> configure)
		{
			AllocateEmptyPrimaryValue = null;
			AllocateEmptyPrimaryDescriptor = null;
			AllocateEmptyPrimaryDescriptorAction = configure;
			return Self;
		}

		public CommandDescriptor AllocateReplica(Elastic.Clients.Elasticsearch.Cluster.CommandAllocateReplicaAction? allocateReplica)
		{
			AllocateReplicaDescriptor = null;
			AllocateReplicaDescriptorAction = null;
			AllocateReplicaValue = allocateReplica;
			return Self;
		}

		public CommandDescriptor AllocateReplica(CommandAllocateReplicaActionDescriptor descriptor)
		{
			AllocateReplicaValue = null;
			AllocateReplicaDescriptorAction = null;
			AllocateReplicaDescriptor = descriptor;
			return Self;
		}

		public CommandDescriptor AllocateReplica(Action<CommandAllocateReplicaActionDescriptor> configure)
		{
			AllocateReplicaValue = null;
			AllocateReplicaDescriptor = null;
			AllocateReplicaDescriptorAction = configure;
			return Self;
		}

		public CommandDescriptor AllocateStalePrimary(Elastic.Clients.Elasticsearch.Cluster.CommandAllocatePrimaryAction? allocateStalePrimary)
		{
			AllocateStalePrimaryDescriptor = null;
			AllocateStalePrimaryDescriptorAction = null;
			AllocateStalePrimaryValue = allocateStalePrimary;
			return Self;
		}

		public CommandDescriptor AllocateStalePrimary(CommandAllocatePrimaryActionDescriptor descriptor)
		{
			AllocateStalePrimaryValue = null;
			AllocateStalePrimaryDescriptorAction = null;
			AllocateStalePrimaryDescriptor = descriptor;
			return Self;
		}

		public CommandDescriptor AllocateStalePrimary(Action<CommandAllocatePrimaryActionDescriptor> configure)
		{
			AllocateStalePrimaryValue = null;
			AllocateStalePrimaryDescriptor = null;
			AllocateStalePrimaryDescriptorAction = configure;
			return Self;
		}

		public CommandDescriptor Cancel(Elastic.Clients.Elasticsearch.Cluster.CommandCancelAction? cancel)
		{
			CancelDescriptor = null;
			CancelDescriptorAction = null;
			CancelValue = cancel;
			return Self;
		}

		public CommandDescriptor Cancel(CommandCancelActionDescriptor descriptor)
		{
			CancelValue = null;
			CancelDescriptorAction = null;
			CancelDescriptor = descriptor;
			return Self;
		}

		public CommandDescriptor Cancel(Action<CommandCancelActionDescriptor> configure)
		{
			CancelValue = null;
			CancelDescriptor = null;
			CancelDescriptorAction = configure;
			return Self;
		}

		public CommandDescriptor Move(Elastic.Clients.Elasticsearch.Cluster.CommandMoveAction? move)
		{
			MoveDescriptor = null;
			MoveDescriptorAction = null;
			MoveValue = move;
			return Self;
		}

		public CommandDescriptor Move(CommandMoveActionDescriptor descriptor)
		{
			MoveValue = null;
			MoveDescriptorAction = null;
			MoveDescriptor = descriptor;
			return Self;
		}

		public CommandDescriptor Move(Action<CommandMoveActionDescriptor> configure)
		{
			MoveValue = null;
			MoveDescriptor = null;
			MoveDescriptorAction = configure;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (AllocateEmptyPrimaryDescriptor is not null)
			{
				writer.WritePropertyName("allocate_empty_primary");
				JsonSerializer.Serialize(writer, AllocateEmptyPrimaryDescriptor, options);
			}
			else if (AllocateEmptyPrimaryDescriptorAction is not null)
			{
				writer.WritePropertyName("allocate_empty_primary");
				JsonSerializer.Serialize(writer, new CommandAllocatePrimaryActionDescriptor(AllocateEmptyPrimaryDescriptorAction), options);
			}
			else if (AllocateEmptyPrimaryValue is not null)
			{
				writer.WritePropertyName("allocate_empty_primary");
				JsonSerializer.Serialize(writer, AllocateEmptyPrimaryValue, options);
			}

			if (AllocateReplicaDescriptor is not null)
			{
				writer.WritePropertyName("allocate_replica");
				JsonSerializer.Serialize(writer, AllocateReplicaDescriptor, options);
			}
			else if (AllocateReplicaDescriptorAction is not null)
			{
				writer.WritePropertyName("allocate_replica");
				JsonSerializer.Serialize(writer, new CommandAllocateReplicaActionDescriptor(AllocateReplicaDescriptorAction), options);
			}
			else if (AllocateReplicaValue is not null)
			{
				writer.WritePropertyName("allocate_replica");
				JsonSerializer.Serialize(writer, AllocateReplicaValue, options);
			}

			if (AllocateStalePrimaryDescriptor is not null)
			{
				writer.WritePropertyName("allocate_stale_primary");
				JsonSerializer.Serialize(writer, AllocateStalePrimaryDescriptor, options);
			}
			else if (AllocateStalePrimaryDescriptorAction is not null)
			{
				writer.WritePropertyName("allocate_stale_primary");
				JsonSerializer.Serialize(writer, new CommandAllocatePrimaryActionDescriptor(AllocateStalePrimaryDescriptorAction), options);
			}
			else if (AllocateStalePrimaryValue is not null)
			{
				writer.WritePropertyName("allocate_stale_primary");
				JsonSerializer.Serialize(writer, AllocateStalePrimaryValue, options);
			}

			if (CancelDescriptor is not null)
			{
				writer.WritePropertyName("cancel");
				JsonSerializer.Serialize(writer, CancelDescriptor, options);
			}
			else if (CancelDescriptorAction is not null)
			{
				writer.WritePropertyName("cancel");
				JsonSerializer.Serialize(writer, new CommandCancelActionDescriptor(CancelDescriptorAction), options);
			}
			else if (CancelValue is not null)
			{
				writer.WritePropertyName("cancel");
				JsonSerializer.Serialize(writer, CancelValue, options);
			}

			if (MoveDescriptor is not null)
			{
				writer.WritePropertyName("move");
				JsonSerializer.Serialize(writer, MoveDescriptor, options);
			}
			else if (MoveDescriptorAction is not null)
			{
				writer.WritePropertyName("move");
				JsonSerializer.Serialize(writer, new CommandMoveActionDescriptor(MoveDescriptorAction), options);
			}
			else if (MoveValue is not null)
			{
				writer.WritePropertyName("move");
				JsonSerializer.Serialize(writer, MoveValue, options);
			}

			writer.WriteEndObject();
		}
	}
}