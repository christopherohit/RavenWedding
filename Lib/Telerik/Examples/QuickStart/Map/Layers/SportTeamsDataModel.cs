using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls.UI.Map;

namespace Telerik.Examples.WinControls.Map.Layers
{
    public static class SportTeamsDataModel
    {
        public static IEnumerable<SportTeamInfo> GetNflData()
        {
            yield return new SportTeamInfo(new PointG(39.2779876, -76.62270440), "Baltimore", "Ravens", "M&T Bank Stadium");
            yield return new SportTeamInfo(new PointG(39.0954576, -84.51605770), "Cincinnati", "Bengals", "Paul Brown Stadium");
            yield return new SportTeamInfo(new PointG(41.5060535, -81.69954810), "Cleveland", "Browns", "FirstEnergy Stadium");
            yield return new SportTeamInfo(new PointG(40.4467648, -80.01576030), "Pittsburgh", "Steelers", "Heinz Field");
            yield return new SportTeamInfo(new PointG(41.8623132, -87.61668840), "Chicago", "Bears", "Soldier Field");
            yield return new SportTeamInfo(new PointG(42.3400064, -83.04560300), "Detroit", "Lions", "Ford Field");
            yield return new SportTeamInfo(new PointG(44.5013406, -88.06220830), "Green Bay", "Packers", "Lambeau Field");
            yield return new SportTeamInfo(new PointG(44.9736920, -93.25767300), "Minnesota", "Vikings", "U.S. Bank Stadium");
            yield return new SportTeamInfo(new PointG(29.6847219, -95.41070740), "Houston", "Texans", "NRG Stadium");
            yield return new SportTeamInfo(new PointG(39.7601007, -86.16388770), "Indianapolis", "Colts", "Lucas Oil Stadium");
            yield return new SportTeamInfo(new PointG(30.3239248, -81.63732280), "Jacksonville", "Jaguars", "EverBank Field");
            yield return new SportTeamInfo(new PointG(36.1664790, -86.77128980), "Tennessee", "Titans", "Nissan Stadium");
            yield return new SportTeamInfo(new PointG(33.7553225, -84.40109910), "Atlanta", "Falcons", "Mercedes-Benz Stadium");
            yield return new SportTeamInfo(new PointG(35.2258272, -80.85283810), "Carolina", "Panthers", "Bank of America Stadium");
            yield return new SportTeamInfo(new PointG(29.9510610, -90.08124420), "New Orleans", "Saints", "Mercedes-Benz Superdome");
            yield return new SportTeamInfo(new PointG(27.9758691, -82.50333440), "Tampa Bay", "Buccaneers", "Raymond James Stadium");
            yield return new SportTeamInfo(new PointG(42.7737720, -78.78702730), "Buffalo", "Bills", "New Era Field");
            yield return new SportTeamInfo(new PointG(25.9579665, -80.23886040), "Miami", "Dolphins", "Hard Rock Stadium");
            yield return new SportTeamInfo(new PointG(42.0909170, -71.26431840), "New England", "Patriots", "Gillette Stadium");
            yield return new SportTeamInfo(new PointG(40.8139697, -74.07439790), "New York", "Jets", "MetLife Stadium");
            yield return new SportTeamInfo(new PointG(32.7477844, -97.09268260), "Dallas", "Cowboys", "AT&T Stadium");
            yield return new SportTeamInfo(new PointG(40.8130697, -74.07439790), "New York", "Giants", "MetLife Stadium");
            yield return new SportTeamInfo(new PointG(39.9008053, -75.16749540), "Philadelphia", "Eagles", "Lincoln Financial Field");
            yield return new SportTeamInfo(new PointG(38.9076426, -76.86453510), "Washington", "Redskins", "FedExField");
            yield return new SportTeamInfo(new PointG(39.7439145, -105.0202494), "Denver", "Broncos", "Sports Authority Field at Mile High");
            yield return new SportTeamInfo(new PointG(39.0489391, -94.48398040), "Kansas City", "Chiefs", "Arrowhead Stadium");
            yield return new SportTeamInfo(new PointG(37.7515946, -122.2009345), "Oakland", "Raiders", "O.co Coliseum");
            yield return new SportTeamInfo(new PointG(32.7831122, -117.1195603), "San Diego", "Chargers", "Qualcomm Stadium");
            yield return new SportTeamInfo(new PointG(33.5276247, -112.2625480), "Arizona", "Cardinals", "University of Phoenix Stadium");
            yield return new SportTeamInfo(new PointG(34.0140562, -118.2880489), "Los Angeles", "Rams", "Los Angeles Memorial Coliseum");
            yield return new SportTeamInfo(new PointG(37.4032110, -121.9698312), "San Francisco", "49ers", "Levi's Stadium");
            yield return new SportTeamInfo(new PointG(47.5951518, -122.3316280), "Seattle", "Seahawks", "CenturyLink Field");
        }

        public static IEnumerable<SportTeamInfo> GetNbaData()
        {
            yield return new SportTeamInfo(new PointG(42.3665137, -71.06160420), "Boston", "Celtics", "TD Garden");
            yield return new SportTeamInfo(new PointG(40.6824143, -73.97511300), "Brooklyn", "Nets", "Barclays Center");
            yield return new SportTeamInfo(new PointG(40.7505045, -73.99313870), "New York", "Knicks", "Madison Square Garden");
            yield return new SportTeamInfo(new PointG(39.9012015, -75.17156820), "Philadelphia", "76ers", "Wells Fargo Center");
            yield return new SportTeamInfo(new PointG(43.6434661, -79.37909890), "Toronto", "Raptors", "Air Canada Centre");
            yield return new SportTeamInfo(new PointG(32.7903512, -96.81056720), "Dallas", "Mavericks", "American Airlines Center");
            yield return new SportTeamInfo(new PointG(29.7507604, -95.36210050), "Houston", "Rockets", "Toyota Center");
            yield return new SportTeamInfo(new PointG(35.1382248, -90.05069630), "Memphis", "Grizzlies", "FedExForum");
            yield return new SportTeamInfo(new PointG(29.9490351, -90.08205680), "New Orleans", "Pelicans", "Smoothie King Center");
            yield return new SportTeamInfo(new PointG(29.4270198, -98.43744520), "San Antonio", "Spurs", "AT&T Center");
            yield return new SportTeamInfo(new PointG(41.8806908, -87.67417590), "Chicago", "Bulls", "United Center");
            yield return new SportTeamInfo(new PointG(41.4966329, -81.68820880), "Cleveland", "Cavaliers", "Quicken Loans Arena");
            yield return new SportTeamInfo(new PointG(42.6968850, -83.24579290), "Detroit", "Pistons", "The Palace of Auburn Hills");
            yield return new SportTeamInfo(new PointG(39.7639304, -86.15554370), "Indiana", "Pacers", "Bankers Life Fieldhouse");
            yield return new SportTeamInfo(new PointG(43.0436587, -87.91723260), "Milwaukee", "Bucks", "BMO Harris Bradley Center");
            yield return new SportTeamInfo(new PointG(39.7486600, -105.0077100), "Denver", "Nuggets", "Pepsi Center");
            yield return new SportTeamInfo(new PointG(44.9794545, -93.27618990), "Minnesota", "Timberwolves", "Target Center");
            yield return new SportTeamInfo(new PointG(35.4634175, -97.51511760), "Oklahoma City", "Thunder", "Chesapeake Energy Arena");
            yield return new SportTeamInfo(new PointG(45.5315651, -122.6668423), "Portland", "Trail Blazers", "Moda Center");
            yield return new SportTeamInfo(new PointG(40.7682681, -111.9010874), "Utah", "Jazz", "Vivint Smart Home Arena");
            yield return new SportTeamInfo(new PointG(33.7572891, -84.39632440), "Atlanta", "Hawks", "Philips Arena");
            yield return new SportTeamInfo(new PointG(35.2251638, -80.83929050), "Charlotte", "Hornets", "Time Warner Cable Arena");
            yield return new SportTeamInfo(new PointG(25.7814014, -80.18696900), "Miami", "Heat", "American Airlines Arena");
            yield return new SportTeamInfo(new PointG(28.5392562, -81.38385990), "Orlando", "Magic", "Amway Center");
            yield return new SportTeamInfo(new PointG(38.8981984, -77.02105210), "Washington", "Wizards", "Verizon Center");
            yield return new SportTeamInfo(new PointG(37.7502917, -122.2030494), "Golden State", "Warriors", "Oracle Arena");
            yield return new SportTeamInfo(new PointG(34.0430175, -118.2665541), "Los Angeles", "Clippers", "STAPLES Center");
            yield return new SportTeamInfo(new PointG(34.0430175, -118.2676541), "Los Angeles", "Lakers", "STAPLES Center");
            yield return new SportTeamInfo(new PointG(33.4457369, -112.0712006), "Phoenix", "Suns", "Talking Stick Resort Arena");
            yield return new SportTeamInfo(new PointG(38.6490388, -121.5181284), "Sacramento", "Kings", "Sleep Train Arena");
        }

        public static IEnumerable<SportTeamInfo> GetNhlData()
        {
            yield return new SportTeamInfo(new PointG(35.8033394, -78.72179460), "Carolina", "Hurricanes", "PNC Arena");
            yield return new SportTeamInfo(new PointG(39.9694084, -83.00587220), "Columbus", "Blue Jackets", "Nationwide Arena");
            yield return new SportTeamInfo(new PointG(40.7336167, -74.17123870), "New Jersey", "Devils", "Prudential Center");
            yield return new SportTeamInfo(new PointG(40.6824952, -73.97522360), "New York", "Islanders", "Barclays Center");
            yield return new SportTeamInfo(new PointG(40.7505045, -73.99413870), "New York", "Rangers", "Madison Square Garden");
            yield return new SportTeamInfo(new PointG(39.9012015, -75.17256820), "Philadelphia", "Flyers", "Wells Fargo Center");
            yield return new SportTeamInfo(new PointG(40.4395827, -79.98935300), "Pittsburgh", "Penguins", "CONSOL Energy Center");
            yield return new SportTeamInfo(new PointG(38.8981984, -77.02104080), "Washington", "Capitals", "Verizon Center");
            yield return new SportTeamInfo(new PointG(42.3661980, -71.06263470), "Boston", "Bruins", "TD Garden");
            yield return new SportTeamInfo(new PointG(42.8749987, -78.87643230), "Buffalo", "Sabres", "KeyBank Center");
            yield return new SportTeamInfo(new PointG(42.3252263, -83.05142440), "Detroit", "Red Wings", "Joe Louis Arena");
            yield return new SportTeamInfo(new PointG(26.1584073, -80.32538060), "Florida", "Panthers", "BB&T Center");
            yield return new SportTeamInfo(new PointG(45.4960667, -73.56920400), "Montréal", "Canadiens", "Centre Bell");
            yield return new SportTeamInfo(new PointG(45.2969151, -75.92721170), "Ottawa", "Senators", "Canadian Tire Centre");
            yield return new SportTeamInfo(new PointG(27.9427373, -82.45176580), "Tampa Bay", "Lightning", "Amalie Arena");
            yield return new SportTeamInfo(new PointG(43.6434661, -79.37898760), "Toronto", "Maple Leafs", "Air Canada Centre");
            yield return new SportTeamInfo(new PointG(41.8806908, -87.67416460), "Chicago", "Blackhawks", "United Center");
            yield return new SportTeamInfo(new PointG(39.7486600, -105.0075987), "Colorado", "Avalanche", "Pepsi Center");
            yield return new SportTeamInfo(new PointG(32.7903512, -96.81025590), "Dallas", "Stars", "American Airlines Center");
            yield return new SportTeamInfo(new PointG(44.9448954, -93.10125840), "Minnesota", "Wild", "Xcel Energy Center");
            yield return new SportTeamInfo(new PointG(36.1591736, -86.77848460), "Nashville", "Predators", "Bridgestone Arena");
            yield return new SportTeamInfo(new PointG(38.6268402, -90.20286700), "St.Louis", "Blues", "Scottrade Center");
            yield return new SportTeamInfo(new PointG(49.8922646, -97.14359910), "Winnipeg", "Jets", "MTS Centre");
            yield return new SportTeamInfo(new PointG(33.8078476, -117.8766574), "Anaheim", "Ducks", "Honda Center");
            yield return new SportTeamInfo(new PointG(33.5319368, -112.2613757), "Arizona", "Coyotes", "Gila River Arena");
            yield return new SportTeamInfo(new PointG(51.0374336, -114.0521228), "Clgary", "Flames", "Scotiabank Saddledome");
            yield return new SportTeamInfo(new PointG(53.5713027, -113.4559612), "Edmonton", "Oilers", "Rexall Place");
            yield return new SportTeamInfo(new PointG(34.0435175, -118.2670541), "Los Angeles", "Kings", "STAPLES Center");
            yield return new SportTeamInfo(new PointG(37.3325855, -121.9012461), "San Jose", "Sharks", "SAP Center at San Jose");
            yield return new SportTeamInfo(new PointG(49.2778358, -123.1088114), "Vancouver", "Canucks", "Rogers Arena");
        }

        public static IEnumerable<SportTeamInfo> GetMlbData()
        {
            yield return new SportTeamInfo(new PointG(39.2840516, -76.62270040), "Baltimore", "Orioles", "Oriole Park");
            yield return new SportTeamInfo(new PointG(42.3466764, -71.09740650), "Boston", "Red sox", "Fenway Park");
            yield return new SportTeamInfo(new PointG(41.8299411, -87.63394920), "Chicago", "White Sox", "U.S. Cellular Field");
            yield return new SportTeamInfo(new PointG(41.4962110, -81.68541760), "Cleveland", "Indians", "Progressive Field");
            yield return new SportTeamInfo(new PointG(42.3389984, -83.04870840), "Detroit", "Tigers", "Comerica Park");
            yield return new SportTeamInfo(new PointG(29.7572684, -95.35570720), "Houston", "Astros", "Minute Maid Park");
            yield return new SportTeamInfo(new PointG(39.0516719, -94.48050290), "Kansas City", "Royals", "Kauffman Stadium");
            yield return new SportTeamInfo(new PointG(33.8003080, -117.8829208), "Los Angeles", "Angels", "Angel Stadium");
            yield return new SportTeamInfo(new PointG(44.9816528, -93.27796510), "Minnesota", "Twins", "Target Field");
            yield return new SportTeamInfo(new PointG(40.8296426, -73.92636320), "New York", "Yankees", "Yankee Stadium");
            yield return new SportTeamInfo(new PointG(37.7515946, -122.2001845), "Oakland", "Athletics", "Oakland Coliseum");
            yield return new SportTeamInfo(new PointG(47.5917930, -122.3321297), "Seattle", "Mariners", "Safeco Field");
            yield return new SportTeamInfo(new PointG(27.7682246, -82.65358080), "Tampa Bay", "Rays", "Tropicana Field");
            yield return new SportTeamInfo(new PointG(32.7512802, -97.08269310), "Texas", "Rangers", "Globe Life Park in Arlington");
            yield return new SportTeamInfo(new PointG(43.6414378, -79.38954190), "Toronto", "Blue Jays", "Rogers Centre");
            yield return new SportTeamInfo(new PointG(33.4455264, -112.0668528), "Arizona", "Diamondbacks", "Chase Field");
            yield return new SportTeamInfo(new PointG(33.7354080, -84.38916160), "Atlanta", "Braves", "Turner Field");
            yield return new SportTeamInfo(new PointG(41.9484384, -87.65552140), "Chicago", "Cubs", "Wrigley Field");
            yield return new SportTeamInfo(new PointG(39.0971313, -84.50673970), "Cincinnati", "Reds", "Great American Ball Park");
            yield return new SportTeamInfo(new PointG(39.7558823, -104.9943668), "Colorado", "Rockies", "Coors Field");
            yield return new SportTeamInfo(new PointG(34.0738510, -118.2401470), "Los Angeles", "Dodgers", "Dodger Stadium");
            yield return new SportTeamInfo(new PointG(25.7782050, -80.21972870), "Miami", "Marlins", "Marlins Park");
            yield return new SportTeamInfo(new PointG(43.0279776, -87.97133910), "Milwaukee", "Brewers", "Miller Park");
            yield return new SportTeamInfo(new PointG(40.7570877, -73.84601000), "New York", "Mets", "Citi Field");
            yield return new SportTeamInfo(new PointG(39.9060572, -75.16668390), "Philadelphia", "Phillies", "Citizens Bank Park");
            yield return new SportTeamInfo(new PointG(40.4468548, -80.00585440), "Pittsburgh", "Pirates", "PNC Park");
            yield return new SportTeamInfo(new PointG(32.7076359, -117.1572837), "San Diego", "Padres", "Petco Park");
            yield return new SportTeamInfo(new PointG(37.7785951, -122.3894585), "San Francisco", "Giants", "AT&T Park");
            yield return new SportTeamInfo(new PointG(38.6226188, -90.19300960), "St.Louis", "Cardinals", "Busch Stadium");
            yield return new SportTeamInfo(new PointG(38.8730102, -77.00762160), "Washington", "Nationals", "Nationals Park");
        }
    }
}
