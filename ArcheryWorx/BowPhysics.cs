using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace ArcheryWorx
{
    class ArcheryData
    {
        //xxx
    }
    
    /// <summary>
    /// string CalcFoc (double dTotalNockWeight, double dShaftLength, double dTotalFlecthingWeight, double dShaftGpI, double dTipWeight)
    ///     Grains (gr) : dTotalNockWeight, dTotalFletchingWeight, dShaftGpI, dTipWeight
    ///     Inches : dShaftLength
    ///     
    ///     * It calculates the Front of Center value and returns for what uses it will be effective.
    /// 
    /// double GetRecommendedDrawDistance(double dArcherHeightMeter)
    ///     Meters(m) : dArcherArmSpanMeter
    /// 
    ///     * It calculates what the draw distance hould be and returns a double in inches.
    /// 
    /// GetRecommendedBowWeight
    ///     
    ///     Kilogram (kg): dArcherWeightKilogram
    ///     [Male/Female]: sArcherGender
    ///     years : iArcherAge
    /// 
    ///     * According to the archer's height, age and gender a bow weight is calculated which is returned in string.
    ///    
    /// CalcBowSpeed
    /// 
    ///     * Calculates the Bow Speed
    /// 
    /// CalcKE
    ///    
    ///     * Calculates the Kinetic Energy
    /// 
    /// CalcMom
    /// 
    ///     * Calculates the Momentum
    ///     
    /// CalcMaxGame
    /// 
    ///     * Calculates the largest type of game you should hunt.
    /// 
    /// CalcMinArrowWeight
    /// 
    ///     * Gets the minimum arrow weight.
    /// 
    /// CalcMinArrowLength
    ///     
    ///     * Gets the minimum arrow length 
    /// </summary>
    class BowPhysics
    {
        /*
         CalcFOC takes all the specifications of arrow to see the total weight and FOC
        */
        public string CalcFOC(double dTotalNockWeight, double dShaftLength, double dTotalFlecthingWeight, double dShaftGpI, double dTipWeight)
        {
            /*
                BETTER FORMULA
                e = evalue;

                n = nock + nockadapter + nockvalue;
                    10.4 + 0 + 0
                    10.4

                l = Shaft Length
                    28.5

                f = numberOfFletches * fletchWeight
                    3 * 6.3
                    18.9

                s = Shaft weight
                    8.9

                p = tip + insert
                    125 + 18
                    143
                // ---------------------------------------------------------------------------------------------

                b = (-n * l - f * l + f + (f * e)/2 - (s * l * l)/2) / (-n - f - l * s - p);


                c = l/2 - b;

                foc = Math.round(c/l * 1000)/10;

                focform.focsum.value = (foc);

                // ---------------------------------------------------------------------------------------------
            */
            double b, c = 0;
            double e = 4;
            double n = dTotalNockWeight; //10.4;
            double l = dShaftLength;// 28.5;
            double f = dTotalFlecthingWeight;//18.9;
            double s = dShaftGpI;//8.9;
            double p = dTipWeight;//143;

            b = (-n * l - f * l + f + (f * e) / 2 - (s * l * l) / 2) / (-n - f - l * s - p);

            c = l / 2 - b;

            return Convert.ToString(Math.Round(c / l * 1000) / 10);

        }

        public double GetRecommendedDrawDistance (double dArcherArmSpanMeter)
		{
			return Math.Round(dArcherArmSpanMeter * 15.75757575,2);
		}
                
		public string GetRecommendedBowWeight (double dArcherWeigthKilogram, string sArcherGender, int iArcherAge = 25)
		{
            
            string sRetVal = "N/A";

            sArcherGender = sArcherGender.ToUpper();

            if (sArcherGender == "FEMALE") {
				//the fairer sex?
				if (iArcherAge<16)
				{
					//little girl?
					sRetVal = "10 - 15 lbs"; //Very Small Child (55-70 lbs. / 31kg)	10-15 lbs.
					if (dArcherWeigthKilogram>31) sRetVal = "15 - 25 lbs";//Small Child (70-100 lbs./ 45kg)	15-25 lbs.
					if (dArcherWeigthKilogram>45) sRetVal = "25 - 35 lbs";//Larger Child (100-130 lbs. 59kg)	25-35 lbs.
				}
		    else{
					//girl your a woman now!
					sRetVal = "25 - 35 lbs"; //Small Frame Women (100-130 lbs. 59kg)	25-35 lbs.
					if (dArcherWeigthKilogram>58) sRetVal = "30 - 40 lbs"; //Medium Frame Women (130-160 lbs 72kg)	30-40 lbs.
					if (dArcherWeigthKilogram>72) sRetVal = "45 - 55 lbs"; //Large Frame Women (+)	45-55 lbs.
				}
			} else {
				// if your not a woman, you must be a man...
				if (iArcherAge<16)
				{
					sRetVal = "10 - 15 lbs"; //Very Small Child (55-70 lbs. / 31kg)	10-15 lbs.
					if (dArcherWeigthKilogram>31) sRetVal = "15 - 25 lbs";//Small Child (70-100 lbs./ 45kg)	15-25 lbs.
					if (dArcherWeigthKilogram>45) sRetVal = "25 - 35 lbs"; //Larger Child (100-130 lbs. 59kg)	25-35 lbs.
					if (dArcherWeigthKilogram>59) sRetVal = "40 - 50 lbs"; //Athletic Older Child (Boys 130-150 lbs. 68kg)	40-50 lbs
				}
				else{
					//Finally you are what we WANT!
					sRetVal = "45 - 55 lbs"; //Small Frame Men (120-150 lbs. 68kg)	45-55 lbs.
					if (dArcherWeigthKilogram>68) sRetVal = "55 - 65 lbs"; //Medium Frame Men (150-180 lbs. 81kg)	55-65 lbs.
					if (dArcherWeigthKilogram>81) sRetVal = "65 - 75 lbs"; //Large Frame Men (+)	65-75 lbs.
				}
			}

			return sRetVal;
		}
	
        public double CalcBowSpeed(double IBO, double DrawWeigth, double DrawLength, double ArrowWeight, double StringWeight)
        {
            double dRetVal = (((IBO - (ArrowWeight - 350) / 3) - ((30 - DrawLength) * 10)) - (((70 - DrawWeigth) / 5) * 10)) - (StringWeight / 3);

            dRetVal = Math.Round(dRetVal, 2);
            return dRetVal;
        }

        public double CalcKE(double Velocity, double Weight)
        {
            double dRetval = 0;

            dRetval = (Velocity * Velocity * Weight) / 450240;

            if (dRetval == 0)
                return 0;
            else
            {
                dRetval = Math.Round(dRetval, 2);

                return dRetval;
            }
        }

        public double CalcMom(double Velocity, double Weight)
        {
            double dRetval = 0;
            dRetval = Math.Round(((Weight / 7000) / 32.2) * Velocity, 2);
            return dRetval;
        }

        public string CalcMaxGame(double dKineticEnergy)
        {
            //string sType = "";

            if (dKineticEnergy < 25) return "Small Game";
            if (dKineticEnergy < 41) return "Medium Game";
            if (dKineticEnergy < 65) return "Large Game";
            else return "Big / Dangerous Game";

            //return sType;
            /*  25 ft. lbs.	Small Game (rabbit, groundhog, etc.)
                25-41 ft. lbs.	Medium Game (Deer, Antelope)
                42-65 ft. lbs.	Large Game (Elk, Black Bear, Boar)
                65 ft. lbs.	Big Game (Cape Buffalo, Grizzly) */
        }

        public double CalcMinArrowWeight(double dDrawWeight)
        {

            double dRetval = 0;

            dRetval = dDrawWeight * 5;

            return dRetval;
        }

        public double CalcMinArrowLength(double dDrawLength)
        {
            return dDrawLength + 1;
        }
    }

    /// <summary>
    /// List<string> GetBows()
    /// 
    ///     GetBows ~ It returns a list filled with ALL the bows.
    /// 
    /// List<string> FindBows(string query)
    /// 
    ///     FindBows ~ Returns a list of all the bows that fit a SQL query.
    ///     select * from Bows where + query
    ///     
    /// cCompoundBow GetBowSpecs(string BowName)
    /// 
    ///     GetBowSpecs ~ takes a bow name, and returns a cCompoundBow class filled with all the specifications.
    ///     
    /// </summary>
    public class cCompoundBowTools
    {
        public List<string> GetBows()
        {
            List<string> lReturnValue = new List<string>();

            cDataController db = new cDataController();
            db.OpenDatabase(Directory.GetCurrentDirectory().ToString() +"./data/AW.db");
            DataTable dtTmp = db.ExecuteQuery("select Name from Bows order by Name");

            foreach (DataRow row in dtTmp.Rows)
            {
                for (int i = 0; i < dtTmp.Columns.Count; i++)
                    lReturnValue.Add(row[i].ToString());
            }

            return lReturnValue;
        }

        //public List<cCompoundBow> GetBowSpecs(string BowName)
        public cCompoundBow GetBowSpecs(string BowName)
        {            
            if (BowName != "")
            {
                cDataController db = new cDataController();
                db.OpenDatabase(Directory.GetCurrentDirectory().ToString() +"./data/AW.db");
                //Name,MinDrawLength,MaxDrawLength,MinDrawWeight,MaxDrawWeight,AxleToAxle,Weight,BraceHeight,Letoff,IBOSpeed
                DataTable dtTmp = db.ExecuteQuery("select * from Bows where Name='" + BowName + "'");

                foreach (DataRow row in dtTmp.Rows)
                {
                    string Name;
                    double MinDrawLength,MaxDrawLength, MinDrawWeight, MaxDrawWeight,AxleToAxle, Weight, BraceHeight, LetOff, IBOSpeed;

                    Name = row["Name"].ToString();
                    MinDrawLength = Convert.ToDouble(row["MinDrawLength"].ToString());
                    MaxDrawLength = Convert.ToDouble(row["MaxDrawLength"].ToString());
                    MinDrawWeight = Convert.ToDouble(row["MinDrawWeight"].ToString());
                    MaxDrawWeight = Convert.ToDouble(row["MaxDrawWeight"].ToString());
                    AxleToAxle = Convert.ToDouble(row["AxleToAxle"].ToString());
                    Weight = Convert.ToDouble(row["Weight"].ToString());
                    BraceHeight = Convert.ToDouble(row["BraceHeight"].ToString());
                    // fix db or try catch
                    LetOff = Convert.ToDouble(row["Letoff"].ToString());
                    IBOSpeed = Convert.ToDouble(row["IBOSpeed"].ToString());

                    cCompoundBow tmpCompoundBow = new cCompoundBow(Name,MinDrawLength, MaxDrawLength,MinDrawWeight,MaxDrawWeight,AxleToAxle, Weight, BraceHeight, LetOff, IBOSpeed);
                    return tmpCompoundBow;
                }
            }
            return null;
        }

        public List<string> FindBows(string query)
        {
            List<string> lReturnValue = new List<string>();

            cDataController db = new cDataController();
            db.OpenDatabase(Directory.GetCurrentDirectory().ToString() +"./data/AW.db");
            string tquery = "select * from Bows where " + query + " order by Name";
            
            DataTable dtTmp = db.ExecuteQuery(tquery);
            
            foreach (DataRow row in dtTmp.Rows)
            {
                lReturnValue.Add(row["Name"].ToString());
            }
            return lReturnValue;
        }
    }

    /// <summary>
    /// The cCompoundBow class is a class that just stores most of the compound bow variables.
    /// Extend this as needed.
    /// </summary>
    public class cCompoundBow : cCompoundBowTools
    {     
        public string BowName;
        public double MinDrawDistance, MaxDrawDistance, MinDrawWeight, MaxDrawWeight, AxleToAxleLength, Weight, BraceHeight, LetOff, IBOSpeed;

        public cCompoundBow(string sBowName, double fMinDrawDistance = 16, double fMaxDrawDistance = 32, double fMinDrawWeight = 50, double fMaxDrawWeight = 70, double fAxleToAxleLength = 32.25, double fWeight = 4, double fBraceHeight = 7, double fLetOff = 80, double fIBOSpeed = 300)
        {
            BowName = sBowName;
            MinDrawDistance = fMinDrawDistance;
            MaxDrawDistance = fMaxDrawDistance;
            MinDrawWeight = fMinDrawWeight;
            MaxDrawWeight = fMaxDrawWeight;
            AxleToAxleLength = fAxleToAxleLength;
            Weight = fWeight;
            BraceHeight = fBraceHeight;
            LetOff = fLetOff;
            IBOSpeed = fIBOSpeed;
        }

    }

    public class cArcherTools
    {
        public cArcherTools()
        {
        }

        public bool SaveArcher(cArcher tmpArcher)
        {            
            XDocument doc = new XDocument(
               new XDeclaration("1.0", "utf-8", "yes"),
               new XComment("ArcheryWorx BETA V1"),
               new XElement("Archer",
                  new XElement("Name", tmpArcher.Name),
                  new XElement("Handiness", tmpArcher.Handiness),
                  new XElement("DrawLength", tmpArcher.DrawLength),
                  new XElement("DrawWeight", tmpArcher.DrawWeight),
                  new XElement("Weight", tmpArcher.Weight),
                  new XElement("Height", tmpArcher.Height),
                  new XElement("CompoundBow",tmpArcher.CompoundBow),
                  new XElement("DoB", tmpArcher.DoB),
                  new XElement("Gender", tmpArcher.Gender)));

            doc.Save("./Archers/" + tmpArcher.Name + ".xml");
            return true;
        }

        public cArcher GetArcher(string xmlUrl)
        {
            if (xmlUrl.Length < 15)
            {
                if (xmlUrl.Substring(xmlUrl.Length - 4) != ".xml")
                    xmlUrl = xmlUrl + ".xml";

                if (xmlUrl.Length < 9)
                {
                    //if (xmlUrl.Substring(0, 9) != "./Archers/")
                    xmlUrl = "./Archers/" + xmlUrl;
                }
                else
                {
                    if (xmlUrl.Substring(0, 9) != "./Archers/")
                        xmlUrl = "./Archers/" + xmlUrl;
                }
            }

            cArcher tmpArcher = new cArcher();
            XDocument doc = XDocument.Load(xmlUrl);            
            
            var data = from item in doc.Descendants("Archer")
                 select new
                 {
                     Name = item.Element("Name").Value,
                        Handiness = item.Element("Handiness").Value,
                        DrawLength = item.Element("DrawLength").Value,                       
                        DrawWeight = item.Element("DrawWeight").Value,
                        Weight = item.Element("Weight").Value,
                        Height = item.Element("Height").Value,
                        Bow = item.Element("CompoundBow").Value,
                        DoB = item.Element("DoB").Value,
                        Gender = item.Element("Gender").Value,
                      
                  };

            foreach (var p in data)
            {
                tmpArcher.Name = p.Name;
                tmpArcher.Handiness = p.Handiness;
                tmpArcher.DrawLength = p.DrawLength;
                tmpArcher.DrawWeight = p.DrawWeight;                
                tmpArcher.Weight = p.Weight;
                tmpArcher.Height = p.Height;
                tmpArcher.CompoundBow = p.Bow;
                tmpArcher.DoB = p.DoB;
                tmpArcher.Gender = p.Gender;
            }
 
           return tmpArcher;
        }
    }

    public class cArcher : cArcherTools
    {
        public string Name, CompoundBow,Handiness,DrawLength,DrawWeight,Height,Weight,DoB,Gender;
        
        public cArcher()
        {
            Name = "n/a";
            Handiness = "Right Handed";
            DrawLength = "n/a";
            DrawWeight = "n/a";            
            Height = "n/a";
            Weight = "n/a";
            CompoundBow = "n/a";
            DoB = "n/a";
            Gender = "n/a";
        }
    }

    public class cShop
    {
        public string ShopName,Description,MainBrands,Area,GPS, IndoorRange,OutdoorRange,a3DRange, Sales, BowTuning,Fletching,Promoted, Enabled, URL;

        public cShop(string inShopName, string inDescription, string inMainBrands, string inArea, string inGPS, string inIndoorRange, string inOutdoorRange, string ina3Drange, string inSales,string inBowTuning, string inFletching, string inEnabled, string inPromoted, string inURL)
        {
            ShopName = inShopName;
            Description = inDescription;
            MainBrands = inMainBrands;
            Area = inArea;
            GPS = inGPS;
            IndoorRange = inIndoorRange;
            OutdoorRange = inOutdoorRange;
            a3DRange = ina3Drange;
            Sales = inSales;
            BowTuning = inBowTuning;
            Fletching = inFletching;
            Promoted = inPromoted;
            Enabled = inEnabled;
            URL = inURL;
        }
    }

    public class cShopTools
    {
        public List<string> GetShops()
        {
            List<string> lReturnValue = new List<string>();

            try
            {
                cDataController db = new cDataController();
                db.OpenDatabase(Directory.GetCurrentDirectory().ToString() + "./data/AW.db");
                DataTable dtTmp = db.ExecuteQuery("select ShopName from shops order by ShopName");

                foreach (DataRow row in dtTmp.Rows)
                {
                    for (int i = 0; i < dtTmp.Columns.Count; i++)
                        lReturnValue.Add(row[i].ToString());
                }
            }
            catch
            {
            }
            return lReturnValue;
        }

        public List<string> FindShops(string query)
        {
            List<string> lReturnValue = new List<string>();

            cDataController db = new cDataController();

            try
            {
                db.OpenDatabase(Directory.GetCurrentDirectory().ToString() + "./data/AW.db");
                string tquery = "select * from shops where " + query;

                DataTable dtTmp = db.ExecuteQuery(tquery);

                foreach (DataRow row in dtTmp.Rows)
                {
                    lReturnValue.Add(row["ShopName"].ToString());
                }
            }
            catch
            {
            }
            return lReturnValue;
        }

                
        public cShop GetShopDetails(string ShopName)
        {
            if (ShopName != "")
            {
                cDataController db = new cDataController();
                db.OpenDatabase(Directory.GetCurrentDirectory().ToString() +"./data/AW.db");                
                DataTable dtTmp = db.ExecuteQuery("select * from shops where ShopName='" + ShopName + "'");

                foreach (DataRow row in dtTmp.Rows)
                {
                    // string inShopName, string inDescription, string inMainBrands, string inArea, string inGPS, string inIndoorRange, string inOutdoorRange, string ina3Drange,string inBowTuning, string inFletching, string inEnabled, string inPromoted, string inURL
                    cShop tmpShopDetails = new cShop(row["ShopName"].ToString(), row["Description"].ToString(), row["MainBrands"].ToString(), row["Area"].ToString(), row["GPS"].ToString(), row["IndoorRange"].ToString(), row["OutdoorRange"].ToString(), row["i3DRange"].ToString(), row["Sales"].ToString(), row["BowTuning"].ToString(), row["Fletching"].ToString(), row["Promoted"].ToString(), row["Enabled"].ToString(), row["URL"].ToString());
                    return tmpShopDetails;
                }
            }
            return null;
        }
    }

    public class cArrow
    {
        public string ArrowShaft, Insert, Nock, NockAdapter;
        public string ShaftLength, GpI, TipWeight, Fletches, TotalRearWeight, TotalShaftWeight, TotalTipWeight, TotalWeight, FOC;

        public cArrow()
        {
        }

        public cArrow(string inArrowShaft, string inInsert, string inNock, string inNockAdapter, string inShaftLength, string inGpI, string inTipWeight,string inFletches, string inTotalRearWeight, string inTotalShaftWeight, string inTotalTipWeight, string inTotalWeight, string inFOC)
        {
            ArrowShaft = inArrowShaft;
            Insert = inInsert;
            Nock = inNock;
            NockAdapter = inNockAdapter;
            ShaftLength = inShaftLength;
            GpI = inGpI;
            TipWeight = inTipWeight;
            Fletches = inFletches;
            TotalRearWeight = inTotalRearWeight;
            TotalShaftWeight = inTotalShaftWeight;
            TotalTipWeight = inTotalTipWeight;
            TotalWeight = inTotalWeight;
            FOC = inFOC;
        }

        public bool SaveArrow(cArrow tmpArrow, string filename)
        {
            XDocument doc = new XDocument(
               new XDeclaration("1.0", "utf-8", "yes"),
               new XComment("ArcheryWorx BETA V1"),
               new XElement("Arrow",
                  //new XElement("Name", tmpArcher.Name),
                  new XElement("ArrowShaft", tmpArrow.ArrowShaft),
                  new XElement("Insert", tmpArrow.Insert),
                  new XElement("Nock", tmpArrow.Nock),
                  new XElement("NockAdapter", tmpArrow.NockAdapter),
                  new XElement("ShaftLength", tmpArrow.ShaftLength),
                  new XElement("GpI", tmpArrow.GpI),
                  new XElement("TipWeight", tmpArrow.TipWeight),
                  new XElement("Fletches", tmpArrow.Fletches),
                  new XElement("TotalRearWeight", tmpArrow.TotalRearWeight),
                  new XElement("TotalShaftWeight", tmpArrow.TotalShaftWeight),
                  new XElement("TotalTipWeight", tmpArrow.TotalTipWeight),
                  new XElement("TotalWeight", tmpArrow.TotalWeight),                  
                  new XElement("FOC", tmpArrow.FOC)));

            doc.Save(filename);
            return true;
        }
        
        public cArrow GetArrow(string xmlUrl)
        {
            if (xmlUrl.Length < 15)
            {
                if (xmlUrl.Substring(xmlUrl.Length - 4) != ".xml")
                    xmlUrl = xmlUrl + ".xml";

                if (xmlUrl.Length < 9)
                {
                    xmlUrl = "./Arrows/" + xmlUrl;
                }
                else
                {
                    if (xmlUrl.Substring(0, 9) != "./Arrows/")
                        xmlUrl = "./Arrows/" + xmlUrl;
                }
            }
            
            cArrow tmpArrow= new cArrow();
            XDocument doc = XDocument.Load(xmlUrl);

            var data = from item in doc.Descendants("Arrow")
                 select new
                 {
                        ArrowShaft = item.Element("ArrowShaft").Value,
                        Insert = item.Element("Insert").Value,
                        Nock = item.Element("Nock").Value,                       
                        NockAdapter = item.Element("NockAdapter").Value,
                        ShaftLength = item.Element("ShaftLength").Value,
                        GpI = item.Element("GpI").Value,
                        TipWeight = item.Element("TipWeight").Value,
                        Fletches = item.Element("Fletches").Value,                        
                        TotalRearWeight = item.Element("TotalRearWeight").Value,
                        TotalShaftWeight = item.Element("TotalShaftWeight").Value,
                        TotalTipWeight = item.Element("TotalTipWeight").Value,
                        TotalWeight = item.Element("TotalWeight").Value,
                        FOC = item.Element("FOC").Value
                  };
            
            foreach (var p in data)
            {
                tmpArrow.ArrowShaft = p.ArrowShaft;
                tmpArrow.Insert = p.Insert;
                tmpArrow.Nock = p.Nock;
                tmpArrow.NockAdapter = p.NockAdapter;
                tmpArrow.ShaftLength = p.ShaftLength;
                tmpArrow.GpI = p.GpI;
                tmpArrow.TipWeight = p.TipWeight;
                tmpArrow.Fletches = p.Fletches;
                tmpArrow.TotalRearWeight = p.TotalRearWeight;
                tmpArrow.TotalShaftWeight = p.TotalShaftWeight;
                tmpArrow.TotalTipWeight = p.TotalTipWeight;
                tmpArrow.TotalWeight = p.TotalWeight;
                tmpArrow.FOC = p.FOC;
            }
 
           return tmpArrow;
        }
    }

    class cBroadheads
    {
        public string TipID;
        public string Manufacturer, TipName, Type; 
        public int BladeCount, Grains;
        public double CuttingDiameter;

        public cBroadheads(string inTipID, string inManufacturer, string inTipName, string inType, string inBladeCount, string inGrains, string inCutrringDiameter)
        {
            TipID = inTipID;
            Manufacturer = inManufacturer;
            TipName = inTipName;
            Type = inType;
            BladeCount = Convert.ToInt32(inBladeCount);
            Grains = Convert.ToInt32(inGrains);
            CuttingDiameter = Convert.ToDouble( inCutrringDiameter.Replace('.',','));
        }

        public cBroadheads(string inTipID, string inManufacturer, string inTipName, string inType, int inBladeCount, int inGrains, double inCuttingDiameter)
        {
            TipID = inTipID;
            Manufacturer = inManufacturer;
            TipName = inTipName;
            Type = inType;
            BladeCount = inBladeCount;
            Grains = inGrains;
            CuttingDiameter = inCuttingDiameter;
        }

        public cBroadheads()
        {
        }
    }

    class cBroadheadTools : cBroadheads
    {
        public List<cBroadheads> GetBroadheads()
        {
            List<cBroadheads> lReturnValue = new List<cBroadheads>();

            cDataController db = new cDataController();
            try
            {
                db.OpenDatabase(Directory.GetCurrentDirectory().ToString() + "./data/AW.db");
                DataTable dtTmp = db.ExecuteQuery("select * from broadheads order by Manufacturer");

                foreach (DataRow row in dtTmp.Rows)
                {

                    cBroadheads tmpTip = new cBroadheads(row["BroadheadID"].ToString(), row["Manufacturer"].ToString(), row["TipName"].ToString(), row["Type"].ToString(), row["BladeCount"].ToString(), row["Grains"].ToString(), row["CuttingDiameter"].ToString());
                    lReturnValue.Add(tmpTip);
                }
            }
            catch
            {
            }

            return lReturnValue;
        }
        
        public List<cBroadheads> GetBroadheads(string query)
        {
            List<cBroadheads> lReturnValue = new List<cBroadheads>();

            cDataController db = new cDataController();
            db.OpenDatabase(Directory.GetCurrentDirectory().ToString() +"./data/AW.db");
            DataTable dtTmp = db.ExecuteQuery("select * from broadheads "+query+" order by Manufacturer");

            foreach (DataRow row in dtTmp.Rows)
            {
                cBroadheads tmpTip = new cBroadheads(row["BroadheadID"].ToString(), row["Manufacturer"].ToString(), row["TipName"].ToString(), row["Type"].ToString(), row["BladeCount"].ToString(), row["Grains"].ToString(), row["CuttingDiameter"].ToString());
                lReturnValue.Add(tmpTip);
            }

            return lReturnValue;
        }

        public cBroadheads FindBroadhead(string BroadheadID)
        {
            cBroadheads tmpTip = new cBroadheads();
            cDataController db = new cDataController();
            db.OpenDatabase(Directory.GetCurrentDirectory().ToString() +"./data/AW.db");
            DataTable dtTmp = db.ExecuteQuery("select * from broadheads where broadheadID = "+BroadheadID);

            foreach (DataRow row in dtTmp.Rows)
            {
                tmpTip = new cBroadheads(row["BroadheadID"].ToString(), row["Manufacturer"].ToString(), row["TipName"].ToString(), row["Type"].ToString(), row["BladeCount"].ToString(), row["Grains"].ToString(), row["CuttingDiameter"].ToString());                
            }

            return tmpTip;
            
        }
    }

    public class cArcherEvent
    {
        public string ArcherHistoryID,ArcherName, Organization, EventName, EventDate, Note;
        public int score;

        public cArcherEvent()
        {
        }

        public cArcherEvent(string inArcherHistoryID, string inArcherName, string inOrganization, string inEventName, string inEventDate, string inNote, string inScore)        
        {
            ArcherHistoryID = inArcherHistoryID;
            ArcherName = inArcherName;
            Organization = inOrganization;
            EventName = inEventName;
            EventDate = inEventDate;
            Note = inNote;
            score = Convert.ToInt32(inScore);
        }
    }

    public class cArcherEventTools
    {
        public List<cArcherEvent> GetEvents()
        {
            List<cArcherEvent> lReturnValue = new List<cArcherEvent>();

            cDataController db = new cDataController();
            try
            {
                db.OpenDatabase(Directory.GetCurrentDirectory().ToString() + "./data/AW.db");
                DataTable dtTmp = db.ExecuteQuery("select * from ArcherHistory order by EventDate");

                foreach (DataRow row in dtTmp.Rows)
                {
                    cArcherEvent tmpEventEntry = new cArcherEvent(row["ArcherHistory"].ToString(), row["ArcherName"].ToString(), row["Organization"].ToString(), row["EventName"].ToString(), row["EventDate"].ToString(), row["Note"].ToString(), row["Score"].ToString());                    
                    lReturnValue.Add(tmpEventEntry);
                }
            }
            catch
            {
            }

            return lReturnValue;
        }

        public List<cArcherEvent> GetArcherEvent(string query)
        {
            List<cArcherEvent> lReturnValue = new List<cArcherEvent>();
            cArcherEvent tmpEventEntry = new cArcherEvent();
            cDataController db = new cDataController();
            db.OpenDatabase(Directory.GetCurrentDirectory().ToString() + "./data/AW.db");
            DataTable dtTmp = db.ExecuteQuery("select * from ArcherHistory " + query + "");

            foreach (DataRow row in dtTmp.Rows)
            {
                tmpEventEntry = new cArcherEvent(row["ArcherHistory"].ToString(), row["ArcherName"].ToString(), row["Organization"].ToString(), row["EventName"].ToString(), row["EventDate"].ToString(), row["Note"].ToString(), row["Score"].ToString()); 
                lReturnValue.Add(tmpEventEntry);
            }

            return lReturnValue;
        }

        public cArcherEvent FindArcherEvent(string EventID)
        {
            cArcherEvent tmpEventEntry = new cArcherEvent();
            cDataController db = new cDataController();
            db.OpenDatabase(Directory.GetCurrentDirectory().ToString() + "./data/AW.db");
            DataTable dtTmp = db.ExecuteQuery("select * from ArcherHistory where AcherHistory = " + EventID);

            foreach (DataRow row in dtTmp.Rows)
            {
                tmpEventEntry = new cArcherEvent(row["ArcherHistory"].ToString(), row["ArcherName"].ToString(), row["Organization"].ToString(), row["EventName"].ToString(), row["EventDate"].ToString(), row["Note"].ToString(), row["Score"].ToString());                    
            }

            return tmpEventEntry;

        }
    }
}