namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrRealtyEventsSchema

	/// <exclude/>
	public class UsrRealtyEventsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrRealtyEventsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrRealtyEventsSchema(UsrRealtyEventsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a215ca8e-dbb7-4e0d-b6fa-069bbd0194e4");
			Name = "UsrRealtyEvents";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b3105303-efff-4aa7-9ded-0170bb644b5a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,146,193,106,27,49,16,134,239,251,20,195,146,195,46,132,37,185,198,73,32,118,220,96,8,73,168,237,94,66,15,178,118,188,81,209,74,139,164,117,234,22,67,30,160,208,91,158,164,183,246,33,236,55,234,104,101,39,94,219,135,204,73,140,126,125,250,255,97,20,43,209,86,140,35,140,208,24,102,245,212,101,61,173,166,162,168,13,115,66,171,232,103,4,84,181,21,170,128,225,220,58,44,59,91,157,237,87,6,179,190,114,194,9,180,31,144,100,253,25,42,183,86,62,54,221,121,211,186,21,244,137,66,147,12,249,19,150,236,142,28,194,5,196,99,107,62,35,147,110,30,167,95,155,55,85,61,145,130,3,151,204,90,8,87,7,40,112,6,93,102,241,192,77,3,9,233,182,112,122,70,118,69,142,48,211,34,135,123,53,80,22,141,163,28,137,158,124,67,238,192,162,202,209,28,67,32,118,113,74,161,26,238,149,41,44,96,250,6,124,71,251,154,144,137,108,27,183,225,96,218,105,9,3,23,76,19,136,130,39,161,145,6,125,91,155,35,23,37,147,80,25,193,253,144,194,163,236,6,221,104,94,97,222,211,178,46,213,23,38,107,60,95,75,47,19,63,200,7,175,31,15,175,227,157,191,197,20,146,192,186,132,211,147,77,165,45,77,59,150,47,204,6,182,199,20,71,137,57,153,112,166,198,206,158,200,58,227,151,129,182,205,178,2,71,88,86,146,57,242,188,39,244,181,206,49,166,89,209,50,42,26,59,109,162,143,117,171,57,147,226,7,155,72,28,54,192,228,125,47,194,62,197,199,16,55,137,7,118,164,117,87,20,187,25,247,205,144,231,208,200,62,105,83,50,151,236,152,36,226,105,118,2,203,127,171,215,229,223,213,175,213,239,213,203,242,15,28,29,2,187,39,163,159,65,225,51,244,191,115,172,188,237,13,109,71,189,136,218,167,69,20,45,254,3,181,124,252,99,141,3,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateValueIsTooBigLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateValueIsTooBigLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("f0698292-d647-84cd-cacb-f3939117c32a"),
				Name = "ValueIsTooBig",
				CreatedInPackageId = new Guid("b3105303-efff-4aa7-9ded-0170bb644b5a"),
				CreatedInSchemaUId = new Guid("a215ca8e-dbb7-4e0d-b6fa-069bbd0194e4"),
				ModifiedInSchemaUId = new Guid("a215ca8e-dbb7-4e0d-b6fa-069bbd0194e4")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a215ca8e-dbb7-4e0d-b6fa-069bbd0194e4"));
		}

		#endregion

	}

	#endregion

}

