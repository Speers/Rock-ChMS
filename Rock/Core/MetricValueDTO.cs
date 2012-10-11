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

namespace Rock.Core
{
    /// <summary>
    /// Data Transfer Object for MetricValue object
    /// </summary>
    public partial class MetricValueDto : IDto
    {

#pragma warning disable 1591
        public bool IsSystem { get; set; }
        public int MetricId { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }
        public string xValue { get; set; }
        public bool isDateBased { get; set; }
        public string Label { get; set; }
        public int Order { get; set; }
        public int Id { get; set; }
        public Guid Guid { get; set; }
#pragma warning restore 1591

        /// <summary>
        /// Instantiates a new DTO object
        /// </summary>
        public MetricValueDto ()
        {
        }

        /// <summary>
        /// Instantiates a new DTO object from the entity
        /// </summary>
        /// <param name="metricValue"></param>
        public MetricValueDto ( MetricValue metricValue )
        {
            CopyFromModel( metricValue );
        }

        /// <summary>
        /// Copies the model property values to the DTO properties
        /// </summary>
        /// <param name="model">The model.</param>
        public void CopyFromModel( IEntity model )
        {
            if ( model is MetricValue )
            {
                var metricValue = (MetricValue)model;
                this.IsSystem = metricValue.IsSystem;
                this.MetricId = metricValue.MetricId;
                this.Value = metricValue.Value;
                this.Description = metricValue.Description;
                this.xValue = metricValue.xValue;
                this.isDateBased = metricValue.isDateBased;
                this.Label = metricValue.Label;
                this.Order = metricValue.Order;
                this.Id = metricValue.Id;
                this.Guid = metricValue.Guid;
            }
        }

        /// <summary>
        /// Copies the DTO property values to the entity properties
        /// </summary>
        /// <param name="model">The model.</param>
        public void CopyToModel ( IEntity model )
        {
            if ( model is MetricValue )
            {
                var metricValue = (MetricValue)model;
                metricValue.IsSystem = this.IsSystem;
                metricValue.MetricId = this.MetricId;
                metricValue.Value = this.Value;
                metricValue.Description = this.Description;
                metricValue.xValue = this.xValue;
                metricValue.isDateBased = this.isDateBased;
                metricValue.Label = this.Label;
                metricValue.Order = this.Order;
                metricValue.Id = this.Id;
                metricValue.Guid = this.Guid;
            }
        }
    }
}