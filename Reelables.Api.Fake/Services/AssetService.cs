using System;
using System.Collections.Generic;
using Reelables.Api.Fake.Models;

namespace Reelables.Api.Fake.Services;

public class AssetService : IAssetService
{
    public Asset GetAsset(string id)
    {
        var startDateTime = new DateTime(2024, 02, 18, 10, 21, 0);

        return new Asset
        {
            Id = id,
            CreatedOn = new DateTime(2024, 02, 18, 10, 21, 0),
            InSpaces = new List<AssetInSpace>
            {
                new AssetInSpace
                {
                    EnteredOn = new DateTime(2024, 02, 22, 10, 21, 0),
                    ExitedOn = null,
                    HasExited = false,
                    SpaceId = Guid.NewGuid().ToString(),
                    SpaceName = "Gate Enter"
                }
            },
            Label = new AssetLabel
            {
                AddedOn = new DateTime(2024, 02, 21, 14, 3, 0),
                NfcId = "20A0009C",
                BleId = 110
            },
            Locations = new AssetLocations
            {
                Items = new List<Location>
                {
                    new Location
                    {
                        Coordinate = new Coordinate
                        {
                            Latitude = 42,
                            Longitude = 42
                        },
                        Timestamp = new DateTime(2024, 02, 22, 10, 21, 0)
                    }
                },
                NextToken = Guid.NewGuid().ToString()
            },
            Name = "Label for temp controlled goods",
            WorkspaceId = Guid.NewGuid(),
            Temperatures = new AssetTemperatures
            {
                NextToken = Guid.NewGuid().ToString(),
                Items = new List<Temperature>
                {
                    new Temperature
                    {
                        Timestamp = new DateTime(2024, 02, 22, 10, 21, 0),
                        DegreesCelcius = 8,
                        NumberReadings = 1
                    },
                    new Temperature
                    {
                        Timestamp = new DateTime(2024, 02, 22, 10, 22, 0),
                        DegreesCelcius = 8,
                        NumberReadings = 1
                    },
                    new Temperature
                    {
                        Timestamp = new DateTime(2024, 02, 22, 10, 23, 0),
                        DegreesCelcius = 8,
                        NumberReadings = 1
                    }
                }
            },
                
        };
    }

    private DateTime GetRandomDateTime(DateTime baseDateTime)
    {
        Random random = new Random();
        int randomNumber = random.Next(15, 3001);

        return baseDateTime.AddMinutes(randomNumber);
    }
}