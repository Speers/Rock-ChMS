//
// THIS WORK IS LICENSED UNDER A CREATIVE COMMONS ATTRIBUTION-NONCOMMERCIAL-
// SHAREALIKE 3.0 UNPORTED LICENSE:
// http://creativecommons.org/licenses/by-nc-sa/3.0/
//
using System;
using System.Collections.Generic;
using System.Linq;

using Rock.Data;

namespace Rock.Model
{
    /// <summary>
    /// Html Content POCO Service class
    /// </summary>
    public partial class HtmlContentService 
    {
        /// <summary>
        /// Gets Html Contents by Approved By Person Id
        /// </summary>
        /// <param name="approvedByPersonId">Approved By Person Id.</param>
        /// <returns>An enumerable list of HtmlContent objects.</returns>
        public IEnumerable<HtmlContent> GetByApprovedByPersonId( int? approvedByPersonId )
        {
            return Repository.Find( t => ( t.ApprovedByPersonId == approvedByPersonId || ( approvedByPersonId == null && t.ApprovedByPersonId == null ) ) );
        }
        
        /// <summary>
        /// Gets Html Contents by Block Instance
        /// </summary>
        /// <param name="blockId">a block instance id</param>
        /// <returns>An enumerable list of HtmlContent objects.</returns>
        public IEnumerable<HtmlContent> GetByBlockId( int blockId )
        {
            return Repository.Find( t => t.BlockId == blockId );
        }
        
        /// <summary>
        /// Gets Html Content by Block And Entity Value And Version
        /// </summary>
        /// <param name="blockId">a block id</param>
        /// <param name="entityValue">Entity Value.</param>
        /// <param name="version">Version.</param>
        /// <returns>HtmlContent object.</returns>
        public HtmlContent GetByBlockIdAndEntityValueAndVersion( int blockId, string entityValue, int version )
        {
            return Repository.FirstOrDefault( t => t.BlockId == blockId && ( t.EntityValue == entityValue || ( entityValue == null && t.EntityValue == null ) ) && t.Version == version );
        }

        /// <summary>
        /// Gets the active content for a specific block-instance/context.
        /// </summary>
        /// <param name="blockId">a block instance id</param>
        /// <param name="entityValue">The entity value.</param>
        /// <returns></returns>
        public HtmlContent GetActiveContent( int blockId, string entityValue )
        {
            // Only consider approved content and content that is not prior to the start date 
            // or past the expire date
            var content = Queryable().
                Where( c => c.IsApproved &&
                    ( c.StartDateTime ?? (DateTime)System.Data.SqlTypes.SqlDateTime.MinValue ) <= DateTime.Now &&
                    ( c.ExpireDateTime ?? (DateTime)System.Data.SqlTypes.SqlDateTime.MaxValue ) >= DateTime.Now );

            // If an entity value is specified, then return content specific to that context, 
            // otherewise return content for the current block instance
            if ( !string.IsNullOrEmpty( entityValue ) )
                content = content.Where( c => c.EntityValue == entityValue );
            else
                content = content.Where( c => c.BlockId == blockId );

            // return the most recently approved item
            return content.OrderByDescending( c => c.ApprovedDateTime ).FirstOrDefault();
        }

        /// <summary>
        /// Gets all versions of content for a specific block-instance/context.
        /// </summary>
        /// <param name="blockId">a block instance id</param>
        /// <param name="entityValue">The entity value.</param>
        /// <returns></returns>
        public IEnumerable<HtmlContent> GetContent( int blockId, string entityValue )
        {
            var content = Queryable();

            // If an entity value is specified, then return content specific to that context, 
            // otherewise return content for the current block instance
            if ( !string.IsNullOrEmpty( entityValue ) )
                content = content.Where( c => c.EntityValue == entityValue );
            else
                content = content.Where( c => c.BlockId == blockId );

            // return the most recently approved item
            return content.OrderByDescending( c => c.Version );
        }
    }
}
