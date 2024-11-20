// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
// <auto-generated />

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DemoService.Service.Models;

namespace DemoService.Service
{

    public interface IWidgetService
    {
        ///<summary>
        /// Gets an instance of the resource.
        ///</summary>
        Task<Widget> GetAsync(string id);
        ///<summary>
        /// Updates an existing instance of the resource.
        ///</summary>
        Task<Widget> UpdateAsync(string id, WidgetUpdate properties);
        ///<summary>
        /// Deletes an existing instance of the resource.
        ///</summary>
        Task DeleteAsync(string id);
        ///<summary>
        /// Creates a new instance of the resource.
        ///</summary>
        Task<Widget> CreateAsync(WidgetCreate resource);
        ///<summary>
        /// Lists all instances of the resource.
        ///</summary>
        Task<WidgetCollectionWithNextLink> ListAsync();

    }
}
