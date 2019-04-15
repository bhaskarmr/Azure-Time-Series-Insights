// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.TimeSeriesInsights.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Request to get or delete instances by time series IDs or time series
    /// names. Exactly one of "timeSeriesIds" or "names" must be set.
    /// </summary>
    public partial class InstancesRequestBatchGetOrDelete
    {
        /// <summary>
        /// Initializes a new instance of the InstancesRequestBatchGetOrDelete
        /// class.
        /// </summary>
        public InstancesRequestBatchGetOrDelete()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InstancesRequestBatchGetOrDelete
        /// class.
        /// </summary>
        /// <param name="timeSeriesIds">List of time series IDs of the time
        /// series instances to return or delete.</param>
        /// <param name="names">List of names of the time series instances to
        /// return or delete.</param>
        public InstancesRequestBatchGetOrDelete(IList<System.Guid?> timeSeriesIds = default(IList<System.Guid?>), IList<string> names = default(IList<string>))
        {
            TimeSeriesIds = timeSeriesIds;
            Names = names;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of time series IDs of the time series instances
        /// to return or delete.
        /// </summary>
        [JsonProperty(PropertyName = "timeSeriesIds")]
        public IList<System.Guid?> TimeSeriesIds { get; set; }

        /// <summary>
        /// Gets or sets list of names of the time series instances to return
        /// or delete.
        /// </summary>
        [JsonProperty(PropertyName = "names")]
        public IList<string> Names { get; set; }

    }
}
