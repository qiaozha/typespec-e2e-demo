// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
// <auto-generated />

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DemoService.Service.Models
{

    ///<summary>
    /// Paged response of Widget items
    ///</summary>
    public partial class WidgetCollectionWithNextLink
    {
        ///<summary>
        /// The items on this page
        ///</summary>
        public Widget[] Value { get; set; }

        ///<summary>
        /// The link to the next page of items
        ///</summary>
        public string NextLink { get; set; }


    }
}
