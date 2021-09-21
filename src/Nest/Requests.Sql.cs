// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗  
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝  
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// -----------------------------------------------
//  
// This file is automatically generated 
// Please do not edit these files manually
// Run the following in the root of the repos:
//
// 		*NIX 		:	./build.sh codegen
// 		Windows 	:	build.bat codegen
//
// -----------------------------------------------
// ReSharper disable RedundantUsingDirective
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using Elasticsearch.Net;
using Elasticsearch.Net.Utf8Json;
using Elasticsearch.Net.Specification.SqlApi;

// ReSharper disable RedundantBaseConstructorCall
// ReSharper disable UnusedTypeParameter
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
namespace Nest
{
	[InterfaceDataContract]
	public partial interface IClearSqlCursorRequest : IRequest<ClearSqlCursorRequestParameters>
	{
	}

	///<summary>Request for ClearCursor <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/clear-sql-cursor-api.html</para></summary>
	public partial class ClearSqlCursorRequest : PlainRequestBase<ClearSqlCursorRequestParameters>, IClearSqlCursorRequest
	{
		protected IClearSqlCursorRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SqlClearCursor;
	// values part of the url path
	// Request parameters
	}

	[InterfaceDataContract]
	public partial interface ISqlDeleteRequest : IRequest<SqlDeleteRequestParameters>
	{
		[IgnoreDataMember]
		Id Id
		{
			get;
		}
	}

	///<summary>Request for Delete <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/delete-async-sql-search-api.html</para></summary>
	public partial class SqlDeleteRequest : PlainRequestBase<SqlDeleteRequestParameters>, ISqlDeleteRequest
	{
		protected ISqlDeleteRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SqlDelete;
		///<summary>/_sql/async/delete/{id}</summary>
		///<param name = "id">this parameter is required</param>
		public SqlDeleteRequest(Id id): base(r => r.Required("id", id))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected SqlDeleteRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Id ISqlDeleteRequest.Id => Self.RouteValues.Get<Id>("id");
	// Request parameters
	}

	[InterfaceDataContract]
	public partial interface ISqlGetRequest : IRequest<SqlGetRequestParameters>
	{
		[IgnoreDataMember]
		Id Id
		{
			get;
		}
	}

	///<summary>Request for Get <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/get-async-sql-search-api.html</para></summary>
	public partial class SqlGetRequest : PlainRequestBase<SqlGetRequestParameters>, ISqlGetRequest
	{
		protected ISqlGetRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SqlGet;
		///<summary>/_sql/async/{id}</summary>
		///<param name = "id">this parameter is required</param>
		public SqlGetRequest(Id id): base(r => r.Required("id", id))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected SqlGetRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Id ISqlGetRequest.Id => Self.RouteValues.Get<Id>("id");
		// Request parameters
		///<summary>Separator for CSV results</summary>
		public string Delimiter
		{
			get => Q<string>("delimiter");
			set => Q("delimiter", value);
		}

		///<summary>Short version of the Accept header, e.g. json, yaml</summary>
		public string Format
		{
			get => Q<string>("format");
			set => Q("format", value);
		}

		///<summary>Retention period for the search and its results</summary>
		public Time KeepAlive
		{
			get => Q<Time>("keep_alive");
			set => Q("keep_alive", value);
		}

		///<summary>Duration to wait for complete results</summary>
		public Time WaitForCompletionTimeout
		{
			get => Q<Time>("wait_for_completion_timeout");
			set => Q("wait_for_completion_timeout", value);
		}
	}

	[InterfaceDataContract]
	public partial interface ISqlSearchStatusRequest : IRequest<SqlSearchStatusRequestParameters>
	{
		[IgnoreDataMember]
		Id Id
		{
			get;
		}
	}

	///<summary>Request for SearchStatus <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/get-async-sql-search-status-api.html</para></summary>
	public partial class SqlSearchStatusRequest : PlainRequestBase<SqlSearchStatusRequestParameters>, ISqlSearchStatusRequest
	{
		protected ISqlSearchStatusRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SqlSearchStatus;
		///<summary>/_sql/async/status/{id}</summary>
		///<param name = "id">this parameter is required</param>
		public SqlSearchStatusRequest(Id id): base(r => r.Required("id", id))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected SqlSearchStatusRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Id ISqlSearchStatusRequest.Id => Self.RouteValues.Get<Id>("id");
	// Request parameters
	}

	[InterfaceDataContract]
	public partial interface IQuerySqlRequest : IRequest<QuerySqlRequestParameters>
	{
	}

	///<summary>Request for Query <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/sql-search-api.html</para></summary>
	public partial class QuerySqlRequest : PlainRequestBase<QuerySqlRequestParameters>, IQuerySqlRequest
	{
		protected IQuerySqlRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SqlQuery;
		// values part of the url path
		// Request parameters
		///<summary>a short version of the Accept header, e.g. json, yaml</summary>
		public string Format
		{
			get => Q<string>("format");
			set => Q("format", value);
		}
	}

	[InterfaceDataContract]
	public partial interface ITranslateSqlRequest : IRequest<TranslateSqlRequestParameters>
	{
	}

	///<summary>Request for Translate <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/sql-translate-api.html</para></summary>
	public partial class TranslateSqlRequest : PlainRequestBase<TranslateSqlRequestParameters>, ITranslateSqlRequest
	{
		protected ITranslateSqlRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SqlTranslate;
	// values part of the url path
	// Request parameters
	}
}