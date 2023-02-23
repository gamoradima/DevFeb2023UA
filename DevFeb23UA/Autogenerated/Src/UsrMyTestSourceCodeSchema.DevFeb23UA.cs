namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrMyTestSourceCodeSchema

	/// <exclude/>
	public class UsrMyTestSourceCodeSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrMyTestSourceCodeSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrMyTestSourceCodeSchema(UsrMyTestSourceCodeSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d9d7955d-3868-4af8-9a32-aa641081c0f3");
			Name = "UsrMyTestSourceCode";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b3105303-efff-4aa7-9ded-0170bb644b5a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,29,142,193,10,131,48,12,134,207,10,123,135,224,201,93,124,1,217,105,183,129,238,176,189,64,236,162,235,168,173,164,169,226,164,239,190,118,16,2,249,243,255,95,2,22,103,242,11,42,130,39,49,163,119,163,52,87,103,71,61,5,70,209,206,194,81,22,16,188,182,19,244,180,137,179,127,203,205,59,219,166,69,170,37,12,70,43,80,6,189,135,110,239,19,48,103,10,47,156,67,221,222,145,188,221,171,62,159,146,120,228,86,172,200,224,5,46,144,49,233,218,74,44,205,131,88,163,209,95,186,15,31,82,82,91,218,224,128,5,25,231,228,172,86,52,129,42,136,231,54,19,152,36,176,77,144,60,197,244,69,44,33,254,0,3,51,203,159,205,0,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d9d7955d-3868-4af8-9a32-aa641081c0f3"));
		}

		#endregion

	}

	#endregion

}

