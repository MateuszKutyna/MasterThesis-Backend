namespace MasterThesis_Backend.Services
{
    public class SteelConnectionsService : ISteelConnectionsService
    {
        private static List<SteelConnections> steelConnections = new List<SteelConnections> { };

        public SteelConnectionsService()
        {
            var steel0 = new Steel(0, "S355J2", "IT432017");
            var steel1 = new Steel(1, "S355J2", "IT42017");
            var steel2 = new Steel(2, "S355J2", "IT62017");
            var steel3 = new Steel(3, "S355J2", "IT92017");
            var steel4 = new Steel(4, "S355J2", "IT202018");
            var steel5 = new Steel(5, "S355J2", "IT152020");
            var steel6 = new Steel(6, "S355K2", "IT162015");
            var steel7 = new Steel(7, "S355J2", "WGT122021");
            var steel8 = new Steel(8, "S355J2", "WGT132021");
            var steel9 = new Steel(9, "AH36", "IT182020");
            var steel10 = new Steel(10, "St52.3", "IT172019");
            var steel11 = new Steel(11, "20Mn5", "IT172020");
            var steel12 = new Steel(12, "20Mn5", "WGT152021");
            var steel13 = new Steel(13, "21Mn5", "IT262014");
            var steel14 = new Steel(14, "S235J2", "WGT72021");
            //SPACE
            var steel15 = new Steel(15, "C4D", "IT262018");
            var steel16 = new Steel(16, "C4D+Al.", "IT262018a");
            var steel17 = new Steel(17, "S235JR", "IT82018");
            var steel18 = new Steel(18, "C10C+B", "IT82018a");
            //SPACE
            var steel19 = new Steel(19, "C3D1", "IT272018");
            var steel20 = new Steel(20, "C7D", "IT282017");
            var steel21 = new Steel(21, "C4D", "IT282017a");
            var steel22 = new Steel(22, "1006", "IT282017b");
            var steel23 = new Steel(23, "C4D", "IT22020");
            var steel24 = new Steel(24, "1006", "IT22020a");
            var steel25 = new Steel(25, "C4D", "IT32019");
            var steel26 = new Steel(26, "1006", "IT32019a");
            var steel27 = new Steel(27, "S235JR", "IT202020");

               
           

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
            // SPACE
            var steelConnections15 = new SteelConnections(steel15, new List<SingleConnection>() {
                new SingleConnection(ConnectionType.B, steel17),
                new SingleConnection(ConnectionType.B, steel18),
            });
            var steelConnections16 = new SteelConnections(steel16, new List<SingleConnection>() {
                new SingleConnection(ConnectionType.B, steel17),
                new SingleConnection(ConnectionType.B, steel18),
            });
            var steelConnections17 = new SteelConnections(steel17, new List<SingleConnection>() {
                new SingleConnection(ConnectionType.B, steel15),
                new SingleConnection(ConnectionType.B, steel16),
            });
            var steelConnections18 = new SteelConnections(steel18, new List<SingleConnection>() {
                new SingleConnection(ConnectionType.B, steel15),
                new SingleConnection(ConnectionType.B, steel16),
            });
            // SPACE
            var steelConnections19 = new SteelConnections(steel19, new List<SingleConnection>()
            {
                new SingleConnection(ConnectionType.B, steel23),
                new SingleConnection(ConnectionType.B, steel24)
            });
            var steelConnections20 = new SteelConnections(steel20, new List<SingleConnection>()
            {
                new SingleConnection(ConnectionType.B, steel25),
                new SingleConnection(ConnectionType.B, steel26)
            });
            var steelConnections21 = new SteelConnections(steel21, new List<SingleConnection>()
            {
                new SingleConnection(ConnectionType.B, steel25),
                new SingleConnection(ConnectionType.B, steel26)
            });
            var steelConnections22 = new SteelConnections(steel22, new List<SingleConnection>()
            {
                new SingleConnection(ConnectionType.B, steel25),
                new SingleConnection(ConnectionType.B, steel26)
            });
            var steelConnections23 = new SteelConnections(steel23, new List<SingleConnection>()
            {
                new SingleConnection(ConnectionType.B, steel19),
                new SingleConnection(ConnectionType.B, steel27)
            });
            var steelConnections24 = new SteelConnections(steel24, new List<SingleConnection>()
            {
                new SingleConnection(ConnectionType.B, steel19),
                new SingleConnection(ConnectionType.B, steel27)
            });

            var steelConnections25 = new SteelConnections(steel25, new List<SingleConnection>()
            {
                new SingleConnection(ConnectionType.B, steel20),
                new SingleConnection(ConnectionType.B, steel21),
                new SingleConnection(ConnectionType.B, steel22),
                new SingleConnection(ConnectionType.B, steel27),
            });
            var steelConnections26 = new SteelConnections(steel26, new List<SingleConnection>()
            {
                new SingleConnection(ConnectionType.B, steel20),
                new SingleConnection(ConnectionType.B, steel21),
                new SingleConnection(ConnectionType.B, steel22),
                new SingleConnection(ConnectionType.B, steel27),
            });
            var steelConnections27 = new SteelConnections(steel27, new List<SingleConnection>()
            {
                new SingleConnection(ConnectionType.B, steel23),
                new SingleConnection(ConnectionType.B, steel24),
                new SingleConnection(ConnectionType.B, steel25),
                new SingleConnection(ConnectionType.B, steel26),
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
                steelConnections14,
                steelConnections15,
                steelConnections16,
                steelConnections17,
                steelConnections18,
                steelConnections19,
                steelConnections20,
                steelConnections21,
                steelConnections22,
                steelConnections23,
                steelConnections24,
                steelConnections25,
                steelConnections26,
                steelConnections27,
            };
        }

        public List<SteelConnections> GetSteelConnections()
        {
            return steelConnections;
        }
    }
}
