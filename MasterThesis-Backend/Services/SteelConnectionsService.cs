namespace MasterThesis_Backend.Services
{
    public class SteelConnectionsService : ISteelConnectionsService
    {
        private static List<SteelConnections> steelConnections = new List<SteelConnections> { };

        public SteelConnectionsService()
        {
            var steel0 = new Steel("S355J2", "IT43/2017");
            var steel1 = new Steel("S355J2", "IT4/2017");
            var steel2 = new Steel("S355J2", "IT6/2017");
            var steel3 = new Steel("S355J2", "IT9/2017");
            var steel4 = new Steel("S355J2", "IT20/2018");
            var steel5 = new Steel("S355J2", "IT15/2020");
            var steel6 = new Steel("S355K2", "IT16/2015");
            var steel7 = new Steel("S355J2", "WGT12/2021");
            var steel8 = new Steel("S355J2", "WGT13/2021");
            var steel9 = new Steel("AH36", "IT18/2020");
            var steel10 = new Steel("St52.3", "IT17/2019");
            var steel11 = new Steel("20Mn5", "IT17/2020");
            var steel12 = new Steel("20Mn5", "WGT15/2021");
            var steel13 = new Steel("21Mn5", "IT26/2014");
            var steel14 = new Steel("S235J2", "WGT7/2021");

            var steelConnections0 = new SteelConnections(steel0, new List<SingleConnection>() {
                new SingleConnection(ConnectionType.A, steel4),
                new SingleConnection(ConnectionType.A, steel5),
                new SingleConnection(ConnectionType.A, steel7),
                new SingleConnection(ConnectionType.A, steel8),
                new SingleConnection(ConnectionType.A, steel10),
                new SingleConnection(ConnectionType.A, steel12),
                new SingleConnection(ConnectionType.A, steel13),
            });

            var steelConnections1 = new SteelConnections(steel1, new List<SingleConnection>() {
                new SingleConnection(ConnectionType.A, steel2),
                new SingleConnection(ConnectionType.A, steel3),
                new SingleConnection(ConnectionType.A, steel6),
                new SingleConnection(ConnectionType.B, steel7),
                new SingleConnection(ConnectionType.A, steel9),
            });

            var steelConnections2 = new SteelConnections(steel2, new List<SingleConnection>() {
                new SingleConnection(ConnectionType.B, steel1),
                new SingleConnection(ConnectionType.B, steel3),
                new SingleConnection(ConnectionType.B, steel6),
                new SingleConnection(ConnectionType.B, steel7),
             });

            var steelConnections3 = new SteelConnections(steel3, new List<SingleConnection>() {
                new SingleConnection(ConnectionType.B, steel1),
                new SingleConnection(ConnectionType.A, steel2),
                new SingleConnection(ConnectionType.X, steel6),
                new SingleConnection(ConnectionType.B, steel7),
                new SingleConnection(ConnectionType.A, steel9),
                new SingleConnection(ConnectionType.A, steel14),
            });

            var steelConnections4 = new SteelConnections(steel4, new List<SingleConnection>() {
                new SingleConnection(ConnectionType.B, steel1),
                new SingleConnection(ConnectionType.X, steel12),
            });

            var steelConnections5 = new SteelConnections(steel5, new List<SingleConnection>() {
                new SingleConnection(ConnectionType.B, steel0),
                new SingleConnection(ConnectionType.A, steel10),
                new SingleConnection(ConnectionType.B, steel12),
                new SingleConnection(ConnectionType.B, steel13),
             });

            var steelConnections6 = new SteelConnections(steel6, new List<SingleConnection>() {
                 new SingleConnection(ConnectionType.B, steel1),
                 new SingleConnection(ConnectionType.A, steel2),
                 new SingleConnection(ConnectionType.X, steel3),
                 new SingleConnection(ConnectionType.B, steel7),
                 new SingleConnection(ConnectionType.A, steel9),
            });
            var steelConnections7 = new SteelConnections(steel7, new List<SingleConnection>() {
                new SingleConnection(ConnectionType.B, steel0),
                new SingleConnection(ConnectionType.A, steel1),
                new SingleConnection(ConnectionType.A, steel2),
                new SingleConnection(ConnectionType.A, steel3),
                new SingleConnection(ConnectionType.A, steel6),
                new SingleConnection(ConnectionType.B, steel8),
                new SingleConnection(ConnectionType.A, steel10),
            });
            var steelConnections8 = new SteelConnections(steel8, new List<SingleConnection>() {
                new SingleConnection(ConnectionType.B, steel0),
                new SingleConnection(ConnectionType.A, steel1),
                new SingleConnection(ConnectionType.A, steel2),
                new SingleConnection(ConnectionType.A, steel3),
                new SingleConnection(ConnectionType.A, steel6),
                new SingleConnection(ConnectionType.A, steel7),
                new SingleConnection(ConnectionType.A, steel10),
            });
            var steelConnections9 = new SteelConnections(steel9, new List<SingleConnection>() {
                new SingleConnection(ConnectionType.B, steel1),
                new SingleConnection(ConnectionType.B, steel3),
                new SingleConnection(ConnectionType.B, steel6),
                new SingleConnection(ConnectionType.B, steel7),
            });
            var steelConnections10 = new SteelConnections(steel10, new List<SingleConnection>() {
                new SingleConnection(ConnectionType.B, steel0),
                new SingleConnection(ConnectionType.B, steel5),
                new SingleConnection(ConnectionType.B, steel7),
                new SingleConnection(ConnectionType.B, steel8),
                new SingleConnection(ConnectionType.B, steel12),
                new SingleConnection(ConnectionType.B, steel13),
            });
            var steelConnections11 = new SteelConnections(steel11, new List<SingleConnection>()
            {
            });
            var steelConnections12 = new SteelConnections(steel12, new List<SingleConnection>() {
                new SingleConnection(ConnectionType.B, steel0),
                new SingleConnection(ConnectionType.X, steel4),
                new SingleConnection(ConnectionType.A, steel5),
                new SingleConnection(ConnectionType.A, steel10),
                new SingleConnection(ConnectionType.A, steel13),
            });
            var steelConnections13 = new SteelConnections(steel13, new List<SingleConnection>() {
                new SingleConnection(ConnectionType.B, steel0),
                new SingleConnection(ConnectionType.A, steel5),
                new SingleConnection(ConnectionType.A, steel10),
                new SingleConnection(ConnectionType.B, steel12),
            });
            var steelConnections14 = new SteelConnections(steel14, new List<SingleConnection>() {
                new SingleConnection(ConnectionType.B, steel3),
            });

            steelConnections = new List<SteelConnections>() {
                steelConnections0,
                steelConnections1,
                steelConnections2,
                steelConnections3,
                steelConnections4,
                steelConnections5,
                steelConnections6,
                steelConnections7,
                steelConnections8,
                steelConnections9,
                steelConnections10,
                steelConnections11,
                steelConnections12,
                steelConnections13,
                steelConnections14
            };
        }

        public List<SteelConnections> GetSteelConnections()
        {
            return steelConnections;
        }
    }
}
