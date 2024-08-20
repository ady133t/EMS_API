// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using SEETEK_EMS_DB;
using SEETEK_EMS_DB.Models;
using System;

Console.WriteLine("Hello, World!");


using (var context = new DBContext())
{
    //var operations = context.Operations
    //    .Join(
    //        context.Stations,
    //        operation => operation.StationID,
    //        station => station.ID,
    //        (operation, station) => new { Operation = operation, Station = station }
    //    )
    //    .Where(joined => joined.Station.ID == 2)
    //    .Select(joined => joined.Operation);


    // await operations.ForEachAsync(o => Console.WriteLine( o.Name));

    var routings = context.RoutingMaps.Select(x => x.Name).Distinct();

    await routings.ForEachAsync(r => { Console.WriteLine(r); });


    //var result = context.RoutingMaps.Select(o => new { RoutingID = o.ID, Resource = o.ResourceGroup.Name });

   // await result.ForEachAsync(data => { Console.WriteLine(data.Resource); });



    var resources = context.RoutingMaps
        .Join(context.ResourceGroups,
        routing => routing.ResourceGroupID,
        resource => resource.ID,
        (routing, resource) => new { Resource = resource, Routing = routing })
        .Where(joined => joined.Routing.Name.Equals("dsdsadasd"))
        .Select(joined => joined.Resource);

    await resources.ForEachAsync(data => { Console.WriteLine(data.Name); });


}


