#nullable enable

using System.ComponentModel;
using Microsoft.Extensions.AI;

namespace Polar;

/// <summary>
/// Extensions for using PolarClient as MEAI AIFunction tools with any IChatClient.
/// </summary>
public static partial class PolarClientExtensions
{
    /// <summary>
    /// Returns all AIFunction tools for the Polar client.
    /// </summary>
    /// <param name="client">The Polar client to use.</param>
    /// <returns>A list of AIFunction tools.</returns>
    [CLSCompliant(false)]
    public static IList<AIFunction> AsTools(this PolarClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return
        [
            client.AsListExercisesTool(),
            client.AsListSleepTool(),
            client.AsListDailyActivityTool(),
            client.AsListNightlyRechargeTool(),
        ];
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists exercises/workouts from Polar,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Polar client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsListExercisesTool(this PolarClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async ([Description("Include heart rate and other samples")] bool? samples = null,
                   [Description("Include heart rate zone data")] bool? zones = null,
                   [Description("Include GPS route data")] bool? route = null,
                   CancellationToken cancellationToken = default) =>
            {
                var response = await client.Exercises.ListExercisesWithoutTransactionAsync(
                    samples: samples,
                    zones: zones,
                    route: route,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response;
            },
            name: "PolarListExercises",
            description: "Lists exercises and workouts from the Polar wearable for the last 30 days. Returns exercise type, duration, distance, heart rate, calories, and training load data.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists sleep data from Polar,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Polar client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsListSleepTool(this PolarClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken = default) =>
            {
                var response = await client.Sleep.ListNightsAsync(
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response;
            },
            name: "PolarListSleep",
            description: "Lists sleep data from the Polar wearable for the last 28 days. Returns sleep duration, sleep stages (light, deep, REM), interruptions, and sleep score.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists daily activity data from Polar,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Polar client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsListDailyActivityTool(this PolarClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async ([Description("Include step samples")] bool? steps = null,
                   [Description("Include activity zone data")] bool? activityZones = null,
                   [Description("Include inactivity stamps")] bool? inactivityStamps = null,
                   CancellationToken cancellationToken = default) =>
            {
                var response = await client.DailyActivity.ListActivitiesWithoutTransactionAsync(
                    steps: steps,
                    activityZones: activityZones,
                    inactivityStamps: inactivityStamps,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response;
            },
            name: "PolarListDailyActivity",
            description: "Lists daily activity summaries from the Polar wearable for the last 28 days. Returns steps, calories, active time, and activity zones.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists Nightly Recharge recovery data from Polar,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Polar client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsListNightlyRechargeTool(this PolarClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken = default) =>
            {
                var response = await client.NightlyRecharge.ListNightlyRechargeAsync(
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response;
            },
            name: "PolarListNightlyRecharge",
            description: "Lists Nightly Recharge recovery data from the Polar wearable for the last 28 days. Returns heart rate variability (HRV), overnight heart rate, ANS charge, and recharge status scores.");
    }
}
