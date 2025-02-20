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
	public interface IDataframeAnalysisContainerVariant
	{
		string DataframeAnalysisContainerVariantName { get; }
	}

	[JsonConverter(typeof(DataframeAnalysisContainerConverter))]
	public partial class DataframeAnalysisContainer : IContainer
	{
		public DataframeAnalysisContainer(IDataframeAnalysisContainerVariant variant) => Variant = variant ?? throw new ArgumentNullException(nameof(variant));
		internal IDataframeAnalysisContainerVariant Variant { get; }
	}

	internal sealed class DataframeAnalysisContainerConverter : JsonConverter<DataframeAnalysisContainer>
	{
		public override DataframeAnalysisContainer Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var readerCopy = reader;
			readerCopy.Read();
			if (readerCopy.TokenType != JsonTokenType.PropertyName)
			{
				throw new JsonException();
			}

			var propertyName = readerCopy.GetString();
			if (propertyName == "classification")
			{
				var variant = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Ml.DataframeAnalysisClassification?>(ref reader, options);
				return new DataframeAnalysisContainer(variant);
			}

			if (propertyName == "outlier_detection")
			{
				var variant = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Ml.DataframeAnalysisOutlierDetection?>(ref reader, options);
				return new DataframeAnalysisContainer(variant);
			}

			if (propertyName == "regression")
			{
				var variant = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Ml.DataframeAnalysisRegression?>(ref reader, options);
				return new DataframeAnalysisContainer(variant);
			}

			throw new JsonException();
		}

		public override void Write(Utf8JsonWriter writer, DataframeAnalysisContainer value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			writer.WritePropertyName(value.Variant.DataframeAnalysisContainerVariantName);
			switch (value.Variant)
			{
				case Elastic.Clients.Elasticsearch.Ml.DataframeAnalysisClassification variant:
					JsonSerializer.Serialize(writer, variant, options);
					break;
				case Elastic.Clients.Elasticsearch.Ml.DataframeAnalysisOutlierDetection variant:
					JsonSerializer.Serialize(writer, variant, options);
					break;
				case Elastic.Clients.Elasticsearch.Ml.DataframeAnalysisRegression variant:
					JsonSerializer.Serialize(writer, variant, options);
					break;
			}

			writer.WriteEndObject();
		}
	}

	public sealed partial class DataframeAnalysisContainerDescriptor<TDocument> : SerializableDescriptorBase<DataframeAnalysisContainerDescriptor<TDocument>>
	{
		internal DataframeAnalysisContainerDescriptor(Action<DataframeAnalysisContainerDescriptor<TDocument>> configure) => configure.Invoke(this);
		public DataframeAnalysisContainerDescriptor() : base()
		{
		}

		internal bool ContainsVariant { get; private set; }

		internal string ContainedVariantName { get; private set; }

		internal DataframeAnalysisContainer Container { get; private set; }

		internal Descriptor Descriptor { get; private set; }

		internal Type DescriptorType { get; private set; }

		private void Set<T>(Action<T> descriptorAction, string variantName)
			where T : Descriptor, new()
		{
			if (ContainsVariant)
				throw new Exception("TODO");
			ContainedVariantName = variantName;
			ContainsVariant = true;
			DescriptorType = typeof(T);
			var descriptor = new T();
			descriptorAction?.Invoke(descriptor);
			Descriptor = descriptor;
		}

		private void Set(IDataframeAnalysisContainerVariant variant, string variantName)
		{
			if (ContainsVariant)
				throw new Exception("TODO");
			Container = new DataframeAnalysisContainer(variant);
			ContainedVariantName = variantName;
			ContainsVariant = true;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			if (!ContainsVariant)
			{
				writer.WriteNullValue();
				return;
			}

			if (Container is not null)
			{
				JsonSerializer.Serialize(writer, Container, options);
				return;
			}

			writer.WriteStartObject();
			writer.WritePropertyName(ContainedVariantName);
			JsonSerializer.Serialize(writer, Descriptor, DescriptorType, options);
			writer.WriteEndObject();
		}

		public void Classification(DataframeAnalysisClassification variant) => Set(variant, "classification");
		public void Classification(Action<DataframeAnalysisClassificationDescriptor<TDocument>> configure) => Set(configure, "classification");
		public void OutlierDetection(DataframeAnalysisOutlierDetection variant) => Set(variant, "outlier_detection");
		public void OutlierDetection(Action<DataframeAnalysisOutlierDetectionDescriptor> configure) => Set(configure, "outlier_detection");
		public void Regression(DataframeAnalysisRegression variant) => Set(variant, "regression");
		public void Regression(Action<DataframeAnalysisRegressionDescriptor<TDocument>> configure) => Set(configure, "regression");
	}

	public sealed partial class DataframeAnalysisContainerDescriptor : SerializableDescriptorBase<DataframeAnalysisContainerDescriptor>
	{
		internal DataframeAnalysisContainerDescriptor(Action<DataframeAnalysisContainerDescriptor> configure) => configure.Invoke(this);
		public DataframeAnalysisContainerDescriptor() : base()
		{
		}

		internal bool ContainsVariant { get; private set; }

		internal string ContainedVariantName { get; private set; }

		internal DataframeAnalysisContainer Container { get; private set; }

		internal Descriptor Descriptor { get; private set; }

		internal Type DescriptorType { get; private set; }

		private void Set<T>(Action<T> descriptorAction, string variantName)
			where T : Descriptor, new()
		{
			if (ContainsVariant)
				throw new Exception("TODO");
			ContainedVariantName = variantName;
			ContainsVariant = true;
			DescriptorType = typeof(T);
			var descriptor = new T();
			descriptorAction?.Invoke(descriptor);
			Descriptor = descriptor;
		}

		private void Set(IDataframeAnalysisContainerVariant variant, string variantName)
		{
			if (ContainsVariant)
				throw new Exception("TODO");
			Container = new DataframeAnalysisContainer(variant);
			ContainedVariantName = variantName;
			ContainsVariant = true;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			if (!ContainsVariant)
			{
				writer.WriteNullValue();
				return;
			}

			if (Container is not null)
			{
				JsonSerializer.Serialize(writer, Container, options);
				return;
			}

			writer.WriteStartObject();
			writer.WritePropertyName(ContainedVariantName);
			JsonSerializer.Serialize(writer, Descriptor, DescriptorType, options);
			writer.WriteEndObject();
		}

		public void Classification(DataframeAnalysisClassification variant) => Set(variant, "classification");
		public void Classification(Action<DataframeAnalysisClassificationDescriptor> configure) => Set(configure, "classification");
		public void Classification<TDocument>(Action<DataframeAnalysisClassificationDescriptor<TDocument>> configure) => Set(configure, "classification");
		public void OutlierDetection(DataframeAnalysisOutlierDetection variant) => Set(variant, "outlier_detection");
		public void OutlierDetection(Action<DataframeAnalysisOutlierDetectionDescriptor> configure) => Set(configure, "outlier_detection");
		public void Regression(DataframeAnalysisRegression variant) => Set(variant, "regression");
		public void Regression(Action<DataframeAnalysisRegressionDescriptor> configure) => Set(configure, "regression");
		public void Regression<TDocument>(Action<DataframeAnalysisRegressionDescriptor<TDocument>> configure) => Set(configure, "regression");
	}
}