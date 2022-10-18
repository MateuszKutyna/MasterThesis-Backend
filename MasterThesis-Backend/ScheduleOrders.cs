using MasterThesis_Backend;
using NRules.Fluent.Dsl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleRules
{
    public class ScheduleOrders : Rule
    {


        public override void Define()
        {
            Order order = null;
            List<SteelConnections>? steelConnections = null;
            Schedule schedule = null;


            When()
                .Match<List<SteelConnections>?>
                    (() => steelConnections)
                .Match<Schedule?>
                    (() => schedule)
                .Match<Order>
                    (() => order,
                        o => CheckIfSteelIsInConnectionList(o, FindConnectionsToTheLastSteelFromSchedule(schedule.Orders.Last(), steelConnections)));


            Then()
                .Do(_ => AddSteelToSchedule(order, schedule))
                .Do(ctx => ctx.Update(schedule))
                .Do(ctx => ctx.Retract(order));

        }

        public void AddSteelToSchedule(Order? steel, Schedule? schedule)
        {
            if (steel != null)
                if (steel.ConnectionType == ConnectionType.A)
                {
                    schedule.Orders.Last().Tonnage = schedule.Orders.Last().Tonnage - 43;
                    steel.Tonnage = steel.Tonnage + 43;
                }
                else if (steel.ConnectionType == ConnectionType.B)
                {
                    schedule.Orders.Last().Tonnage = schedule.Orders.Last().Tonnage + 43;
                    steel.Tonnage = steel.Tonnage - 43;
                }
            schedule.Orders.Add(steel);



        }

        public SteelConnections? FindConnectionsToTheLastSteelFromSchedule(Order lastSteel, List<SteelConnections>? steelConnections)
        {
            

            var element = steelConnections?.FirstOrDefault((connection) => connection.Steel.SteelGrade == lastSteel.SteelGrade);
            if (element != null)
            {
                return element;
            }
            return null;
        }

        public bool CheckIfSteelIsInConnectionList(Order? steel, SteelConnections? steelConnections1)
        {
            var element = steelConnections1?.ListOfConnections.FirstOrDefault((connection) => connection.ConnectedSteel.SteelGrade == steel?.SteelGrade);



            if (element == null)
            {
                return false;
            }

            steel.ConnectionType = element.ConnectionType;

            return true;
        }
    }
}
