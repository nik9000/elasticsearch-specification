using Nest.CommonAbstractions;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
namespace Nest.Cat {

	public class CatDatafeedsRequest : RequestBase {
		
		[DataMember(Name="allow_no_datafeeds")]
		public bool AllowNoDatafeeds { get; set; }


		[DataMember(Name="format")]
		public string Format { get; set; }


		[DataMember(Name="headers")]
		public List<string> Headers { get; set; }


		[DataMember(Name="help")]
		public bool Help { get; set; }


		[DataMember(Name="sort_by_columns")]
		public List<string> SortByColumns { get; set; }


		[DataMember(Name="verbose")]
		public bool Verbose { get; set; }

	}
}