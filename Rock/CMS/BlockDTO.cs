//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Rock.CodeGeneration project
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
//
// THIS WORK IS LICENSED UNDER A CREATIVE COMMONS ATTRIBUTION-NONCOMMERCIAL-
// SHAREALIKE 3.0 UNPORTED LICENSE:
// http://creativecommons.org/licenses/by-nc-sa/3.0/
//
using System;

using Rock.Data;

namespace Rock.Cms
{
	/// <summary>
	/// Data Transfer Object for Block object
	/// </summary>
	public partial class BlockDto : Dto<Block>
	{

#pragma warning disable 1591
		public bool IsSystem { get; set; }
		public string Path { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
#pragma warning restore 1591

		/// <summary>
		/// Instantiates a new DTO object
		/// </summary>
		public BlockDto ()
		{
		}

		/// <summary>
		/// Instantiates a new DTO object from the model
		/// </summary>
		/// <param name="block"></param>
		public BlockDto ( Block block )
		{
			CopyFromModel( block );
		}

		/// <summary>
		/// Copies the model property values to the DTO properties
		/// </summary>
		/// <param name="block"></param>
		public override void CopyFromModel( Block block )
		{
			this.IsSystem = block.IsSystem;
			this.Path = block.Path;
			this.Name = block.Name;
			this.Description = block.Description;
			this.CreatedDateTime = block.CreatedDateTime;
			this.ModifiedDateTime = block.ModifiedDateTime;
			this.CreatedByPersonId = block.CreatedByPersonId;
			this.ModifiedByPersonId = block.ModifiedByPersonId;
			this.Id = block.Id;
			this.Guid = block.Guid;
		}

		/// <summary>
		/// Copies the DTO property values to the model properties
		/// </summary>
		/// <param name="block"></param>
		public override void CopyToModel ( Block block )
		{
			block.IsSystem = this.IsSystem;
			block.Path = this.Path;
			block.Name = this.Name;
			block.Description = this.Description;
			block.CreatedDateTime = this.CreatedDateTime;
			block.ModifiedDateTime = this.ModifiedDateTime;
			block.CreatedByPersonId = this.CreatedByPersonId;
			block.ModifiedByPersonId = this.ModifiedByPersonId;
			block.Id = this.Id;
			block.Guid = this.Guid;
		}
	}
}