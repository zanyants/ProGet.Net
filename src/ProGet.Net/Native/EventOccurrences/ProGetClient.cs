﻿using System.Collections.Generic;
using System.Threading.Tasks;
using ProGet.Net.Common;
using ProGet.Net.Native.Models;

// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace

namespace ProGet.Net
{
    public partial class ProGetClient
    {
        /// <summary>
        /// Gets details about a specific event occurrence
        /// </summary>
        public async Task<EventOccurrence> EventOccurrences_GetOccurrenceAsync(int eventOccurrence_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(eventOccurrence_Id).Capitalize(), eventOccurrence_Id)
            );

            return await ExecuteNativeApiMethodAsync<EventOccurrence>(nameof(EventOccurrences_GetOccurrenceAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets all event occurrences, optionally filtered by feed
        /// </summary>
        public async Task<IEnumerable<EventOccurrence>> EventOccurrences_GetOccurrencesAsync(int? feed_Id = null)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<EventOccurrence>>(nameof(EventOccurrences_GetOccurrencesAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets all of the users which have initiated events
        /// </summary>
        public async Task<IEnumerable<EventOccurrences_Users>> EventOccurrences_GetUsersAsync() => 
            await ExecuteNativeApiMethodAsync<IEnumerable<EventOccurrences_Users>>(nameof(EventOccurrences_GetUsersAsync).WithoutAsyncSuffix()).ConfigureAwait(false);
    }
}
